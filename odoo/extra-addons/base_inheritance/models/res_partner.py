import itertools
import logging
from collections import defaultdict

from odoo import api, fields, models#, tools, _, SUPERUSER_ID
# from odoo.exceptions import ValidationError, RedirectWarning, UserError
# from odoo.osv import expression

# _logger = logging.getLogger(__name__)


class ResPartner(models.Model):
    _inherit = "res.partner"
    _description = "Contact"
    _order = "display_name"

    code_partner = fields.Char(string='Code Partner')
    partner_name = fields.Char('Partner name')