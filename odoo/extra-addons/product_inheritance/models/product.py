import itertools
import logging
from collections import defaultdict

from odoo import api, fields, models, tools, _, SUPERUSER_ID
from odoo.exceptions import ValidationError, RedirectWarning, UserError
from odoo.osv import expression

_logger = logging.getLogger(__name__)


class ProductTemplateInheritance(models.Model):
    _inherit = "product.template"
    _description = "Product Template"

    code_product_partner = fields.Char('Code product partner', index=True, required=True, translate=True)
    code_partner = fields.Many2one('res.partner', recursive=True, store=True, index=True)


