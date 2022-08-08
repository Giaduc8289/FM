# License LGPL-3.0 or later (http://www.gnu.org/licenses/lgpl.html)

{
    "name": "Sales inheritance",
    "version": "15.0",
    # "author": "anhnth.mta@gmail.com",
    "sequence": "8",
    "license": "LGPL-3",
    "category": "Hidden",
    "depends": ["sale", 'coupon', "sale_coupon", "product"],
    "data": [
        'security/ir.model.access.csv',
        "views/product_views.xml",
        'views/sale_view.xml',
        'wizard/turnover_report.xml',
        'wizard/turnover_report_document.xml',
        'wizard/sale_backorder.xml',
        'wizard/sale_backorder_document.xml',
    ],
    "installable": True,
    # "maintainers": ["anhnth.mta@gmail.com"]
}
