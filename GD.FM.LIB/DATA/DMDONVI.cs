using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using KTXPT.BLL;
using KTXPT.DAL;
using KTXPT.DAL.EntityClasses;
using KTXPT.DAL.FactoryClasses;
using KTXPT.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
namespace KTXPT.DATA
{
    public class DMDONVI
    {
        public static bool DV_TH = false;
        public static string MADONVI_TH = "0000";
        public static DmdonviEntity _Current;
        public static DataTable _Current_dt;
        private static DataTable _DMDONVI_ALL = null;
        public static DataTable DMDONVI_ALL
        {
            get
            {
                if (_DMDONVI_ALL == null || _DMDONVI_ALL.Rows.Count == 0)
                {
                    _DMDONVI_ALL = (new DmdonviManagerBase()).SelectAllRDT();
                    DataView dv = _DMDONVI_ALL.DefaultView;
                    dv.Sort = DmdonviFields.Madonvi.Name + " ASC";
                    _DMDONVI_ALL = dv.ToTable().Copy();
                }
                return _DMDONVI_ALL;
            }
            set
            {
                _DMDONVI_ALL = value;
            }
        }
        private static DataTable _DMDONVI_ALL_IN_DVTH = null;
        public static DataTable DMDONVI_ALL_IN_DVTH
        {
            get
            {
                try
                {
                    _DMDONVI_ALL_IN_DVTH = DMDONVI_ALL.Select(DmdonviFields.Madonvicha.Name + " ='" + KTXPT.DATA.DMDONVI._Current.Madonvi + "'").CopyToDataTable();
                }
                catch { }
                return _DMDONVI_ALL_IN_DVTH;
            }
            set
            {
                _DMDONVI_ALL_IN_DVTH = value;
            }
        }
    }
}
