# -*- coding: utf-8 -*-
# Part of Odoo. See LICENSE file for full copyright and licensing details.
from datetime import datetime

from odoo.osv import expression
from odoo.tools.misc import formatLang
from odoo import api, fields, models, _

class SaleOrder(models.Model):
    _inherit = "sale.order"

