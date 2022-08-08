# -*- coding: utf-8 -*-

from odoo import models, fields, api

from datetime import datetime, timedelta

from odoo.osv import expression
from odoo.tools import DEFAULT_SERVER_DATE_FORMAT as DATE_FORMAT
from odoo.tools import DEFAULT_SERVER_DATETIME_FORMAT as DATETIME_FORMAT


class SaleBackorderWizard(models.TransientModel):
    _name = 'sale.backorder.wizard'
    _rec_name = 'date_start'

    date_start = fields.Date(string='Start Date')
    date_end = fields.Date(string='End Date')

    price_total = fields.Float("Tong tien", readonly=True, store=True)
    khachhang = fields.Char("Tên khach hang", readonly=True, store=True)
    sale_name = fields.Char("Tên hợp đồng", readonly=True, store=True)
    product_tmpl_id = fields.Many2one("product.template", "Product Template", readonly=True, store=True)
    total_product_qty = fields.Float("Khối lượng hợp đồng", readonly=True, store=True)
    price_unit = fields.Float("Đơn giá", readonly=True, store=True)
    qty_delivered = fields.Float("Tổng đã nhận", readonly=True, store=True)
    date_done = fields.Date("Ngày nhận", readonly=True, store=True)
    product_qty = fields.Float("Khối lượng nhận", readonly=True, store=True)
    date_order = fields.Date("Ngày nhận", readonly=True, store=True)
    amount_total = fields.Float("Tổng tiền thanh toán", readonly=True, store=True)
    amount_residual = fields.Float("Tổng tiền chưa thanh toán", readonly=True, store=True)

    def get_report(self):
        if self.date_end:
            to_date = self.date_end + timedelta(days=1)
        else:
            to_date = 0

        data = {
            'model': self._name,
            'ids': self.ids,
            'form': {
                'date_start': self.date_start, 'to_date': to_date,
                'date_end': self.date_end,
            },
        }

        action = self.env.ref('sale_inheritance.action_backorder_sale').report_action(self, data=data)
        return action


class ReportSaleBackorder(models.AbstractModel):
    _name = 'report.sale_inheritance.report_sale_backorder_document'

    @api.model
    def _get_report_values(self, docids, data=None):
        date_start = data['form']['date_start']
        date_end = data['form']['date_end']
        to_date = data['form']['to_date']
        # nhacungcap = data['form']['nhacungcap']
        # hopdong = data['form']['hopdong']
        # tenkhach = data['form']['tenkhach']

        where_string = ""
        param = {}
        # if nhacungcap:
        #     where_string = "And (dh.partner_id= %(partner_id)s ) "
        #     param['partner_id'] = nhacungcap
        # if hopdong:
        #     where_string += " And (dh.name= %(hopdong)s ) "
        #     param['hopdong'] = hopdong
        if date_start:
            where_string += " And (dh.date_approve >= %(date_start)s ) "
            param['date_start'] = date_start
        if date_end:
            where_string += " And (dh.date_approve <= %(to_date)s ) "
            param['to_date'] = to_date
        query = """
                        Select dh.partner_id, dh.name
                            , dhct.product_id, dhct.product_uom_qty, dhct.price_unit, dhct.qty_delivered
                            , dh.amount_total, am.amount_residual
                            ,dh.date_order , dhct.price_total
                            , date_done
                            , dc.product_qty
                        From sale_order dh Left Join sale_order_line dhct on dhct.order_id=dh.id
                            Left Join stock_picking lh on lh.origin=dh.name
                             Left Join stock_move dc on dc.picking_id=lh.id and dc.product_id=dhct.product_id 
                            Left Join account_move am on am.invoice_origin=dh.name 
                         where (am.move_type = 'out_invoice') and (lh.state='done') {where_string}
                         order by dh.name, dhct.product_id
                        """.format(where_string=where_string, )

        self.env.cr.execute(query, param)
        data_puback = self.env.cr.fetchall()
        _ids = []
        for line in data_puback:
            data_row = ({
                'khachhang': line[0],
                'sale_name': line[1],
                'product_tmpl_id': line[2],
                'total_product_qty': line[3],
                'price_unit': line[4],
                'qty_delivered': line[5],
                'date_order': line[8],
                'amount_total': line[6],
                'amount_residual': line[7],
                'price_total': line[9],
                'date_done': line[10],
                'product_qty': line[11],


            })
            _ids.append(self.env['sale.backorder.wizard'].create(data_row).id)

        docs = self.env['sale.backorder.wizard'].browse(_ids)

        return {
            'doc_ids': data['ids'],
            'doc_model': data['model'],
            'date_start': date_start,
            'date_end': date_end,
            'docs': docs,
        }
