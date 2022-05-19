
/*
'===============================================================================
'  GD.FM.BL.DmcapmaManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GD.FM.BLL;
using GD.FM.DAL;
using GD.FM.DAL.EntityClasses;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.BLL
{
	public class DmcapmaManager : DmcapmaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcapmaManager()
		{
			// Nothing for now.
		}
        public static string GET_MA_INT(string LOAI_MA, bool IsOk)
        {
            string to_Return = "0001";
            string day = GD.FM.DATA.DATE.NGAYHACHTOAN.Day.ToString();
            string month = GD.FM.DATA.DATE.NGAYHACHTOAN.Month.ToString();
            string year = GD.FM.DATA.DATE.NGAYHACHTOAN.Year.ToString().Substring(2, 2);
            string Mastart = day + month + year;
            EntityCollection _Collection = SelectByLoaima_Mastart(LOAI_MA, Mastart);
         
            #region _Collection=NULL
            if (_Collection == null || _Collection.Items.Count == 0)
            {
                DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
                _DmcapmaEntity.Macappk = to_Return;
                _DmcapmaEntity.Loaima = LOAI_MA;
                _DmcapmaEntity.Mastart = Mastart;
                if (IsOk) (new DmcapmaManagerBase()).Insert(_DmcapmaEntity);
                //sua de dung them MASTART
                if (_DmcapmaEntity.Mastart.Trim() != "")
                {
                    to_Return = _DmcapmaEntity.Mastart.Trim() + to_Return;
                }
                return to_Return;
            }
            #endregion

            #region _Collection<>NULL
            DmcapmaEntity _DmcapmaEntity_DATA = (DmcapmaEntity)_Collection[0];
            string strindex = _DmcapmaEntity_DATA.Macappk;
            int index = int.Parse(strindex);
            //if (Mastart != _DmcapmaEntity_DATA.Mastart) index = 0;
            index = index + 1;
            if (index < 10)
            {
                to_Return = "000" + index;
            }
            else if (index < 100)
            {
                to_Return = "00" + index;
            }
            else if (index < 1000)
            {
                to_Return = "0" + index;
            }
            //else if (index < 10000)
            //{
            //    to_Return = "" + index;
            //}
            //else if (index < 100000)
            //{
            //    to_Return = "0" + index;
            //}
            else
            {
                to_Return = index.ToString();
            }
            _DmcapmaEntity_DATA.Macappk = to_Return;
            _DmcapmaEntity_DATA.Mastart = Mastart;
            if (IsOk) Update_get_ma_int(_DmcapmaEntity_DATA);

            //sua de dung them MASTART
            if (_DmcapmaEntity_DATA.Mastart.Trim() != "")
            {
                to_Return = _DmcapmaEntity_DATA.Mastart.Trim() + to_Return;
            }
            return to_Return;
            #endregion
        }
        public static string GET_MA_DANHMUC_01(string LOAI_MA, bool IsOk, string MATRUOC)
        {
            string to_Return = "01", Mastart = MATRUOC;
            EntityCollection _Collection = SelectByLoaima_Mastart(LOAI_MA, Mastart);
            #region _Collection=NULL
            if (_Collection == null || _Collection.Items.Count == 0)
            {
                DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
                _DmcapmaEntity.Macappk = to_Return;
                _DmcapmaEntity.Loaima = LOAI_MA;
                _DmcapmaEntity.Mastart = Mastart;
                if (IsOk) (new DmcapmaManagerBase()).Insert(_DmcapmaEntity);
                //sua de dung them MASTART
                if (_DmcapmaEntity.Mastart.Trim() != "") to_Return = Mastart + to_Return;
                return to_Return;
            }
            #endregion

            #region _Collection<>NULL
            DmcapmaEntity _DmcapmaEntity_DATA = (DmcapmaEntity)_Collection[0];
            string strindex = _DmcapmaEntity_DATA.Macappk;
            int index = int.Parse(strindex);
            if (Mastart != _DmcapmaEntity_DATA.Mastart) index = 0;
            index = index + 1;
            if (index < 10)
            {
                to_Return = "0" + index;
            }
            else
            {
                to_Return = index.ToString();
            }
            _DmcapmaEntity_DATA.Macappk = to_Return;
            _DmcapmaEntity_DATA.Mastart = Mastart;
            if (IsOk) Update(_DmcapmaEntity_DATA);

            //sua de dung them MASTART
            if (_DmcapmaEntity_DATA.Mastart.Trim() != "") to_Return = _DmcapmaEntity_DATA.Mastart.Trim() + to_Return;
            return to_Return;
            #endregion
        }
        public static string GET_MA_DANHMUC_001(string LOAI_MA, bool IsOk, string MATRUOC)
        {
            string to_Return = "001", Mastart = MATRUOC;
            EntityCollection _Collection = SelectByLoaima_Mastart(LOAI_MA, Mastart);
            #region _Collection=NULL
            if (_Collection == null || _Collection.Items.Count == 0)
            {
                DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
                _DmcapmaEntity.Macappk = to_Return;
                _DmcapmaEntity.Loaima = LOAI_MA;
                _DmcapmaEntity.Mastart = Mastart;
                if (IsOk) (new DmcapmaManagerBase()).Insert(_DmcapmaEntity);
                //sua de dung them MASTART
                if (_DmcapmaEntity.Mastart.Trim() != "") to_Return = Mastart + to_Return;
                return to_Return;
            }
            #endregion

            #region _Collection<>NULL
            DmcapmaEntity _DmcapmaEntity_DATA = (DmcapmaEntity)_Collection[0];
            string strindex = _DmcapmaEntity_DATA.Macappk;
            int index = int.Parse(strindex);
            if (Mastart != _DmcapmaEntity_DATA.Mastart) index = 0;
            index = index + 1;
            if (index < 10)
            {
                to_Return = "0" + index;
            }
            if (index < 100)
            {
                to_Return = "00" + index;
            }
            else
            {
                to_Return = index.ToString();
            }
            _DmcapmaEntity_DATA.Macappk = to_Return;
            _DmcapmaEntity_DATA.Mastart = Mastart;
            if (IsOk) Update(_DmcapmaEntity_DATA);

            //sua de dung them MASTART
            if (_DmcapmaEntity_DATA.Mastart.Trim() != "") to_Return = _DmcapmaEntity_DATA.Mastart.Trim() + to_Return;
            return to_Return;
            #endregion
        }
        public static string GET_MA_DANHMUC_0001(string LOAI_MA, bool IsOk, string MATRUOC)
        {
            string to_Return = "0001", Mastart = MATRUOC;
            EntityCollection _Collection = SelectByLoaima_Mastart(LOAI_MA, Mastart);
            #region _Collection=NULL
            if (_Collection == null || _Collection.Items.Count == 0)
            {
                DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
                _DmcapmaEntity.Macappk = to_Return;
                _DmcapmaEntity.Loaima = LOAI_MA;
                _DmcapmaEntity.Mastart = Mastart;
                if (IsOk) (new DmcapmaManagerBase()).Insert(_DmcapmaEntity);
                //sua de dung them MASTART
                if (_DmcapmaEntity.Mastart.Trim() != "") to_Return = Mastart + to_Return;
                return to_Return;
            }
            #endregion

            #region _Collection<>NULL
            DmcapmaEntity _DmcapmaEntity_DATA = (DmcapmaEntity)_Collection[0];
            string strindex = _DmcapmaEntity_DATA.Macappk;
            int index = int.Parse(strindex);
            if (Mastart != _DmcapmaEntity_DATA.Mastart) index = 0;
            index = index + 1;
            if (index < 10)
            {
                to_Return = "0" + index;
            }
            if (index < 100)
            {
                to_Return = "00" + index;
            }
            if (index < 1000)
            {
                to_Return = "000" + index;
            }
            else
            {
                to_Return = index.ToString();
            }
            _DmcapmaEntity_DATA.Macappk = to_Return;
            _DmcapmaEntity_DATA.Mastart = Mastart;
            if (IsOk) Update(_DmcapmaEntity_DATA);

            //sua de dung them MASTART
            if (_DmcapmaEntity_DATA.Mastart.Trim() != "") to_Return = _DmcapmaEntity_DATA.Mastart.Trim() + to_Return;
            return to_Return;
            #endregion
        }
        public static string GET_MA_DANHMUC_000001(string LOAI_MA, bool IsOk, string MATRUOC)
        {
            string to_Return = "000001", Mastart = MATRUOC;
            EntityCollection _Collection = SelectByLoaima_Mastart(LOAI_MA, Mastart);
            #region _Collection=NULL
            if (_Collection == null || _Collection.Items.Count == 0)
            {
                DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
                _DmcapmaEntity.Macappk = to_Return;
                _DmcapmaEntity.Loaima = LOAI_MA;
                _DmcapmaEntity.Mastart = Mastart;
                if (IsOk) (new DmcapmaManagerBase()).Insert(_DmcapmaEntity);
                //sua de dung them MASTART
                if (_DmcapmaEntity.Mastart.Trim() != "") to_Return = Mastart + to_Return;
                return to_Return;
            }
            #endregion

            #region _Collection<>NULL
            DmcapmaEntity _DmcapmaEntity_DATA = (DmcapmaEntity)_Collection[0];
            string strindex = _DmcapmaEntity_DATA.Macappk;
            int index = int.Parse(strindex);
            if (Mastart != _DmcapmaEntity_DATA.Mastart) index = 0;
            index = index + 1;
            if (index < 10)
            {
                to_Return = "00000" + index;
            }
            else if (index < 100)
            {
                to_Return = "0000" + index;
            }
            else if (index < 1000)
            {
                to_Return = "000" + index;
            }
            else if (index < 10000)
            {
                to_Return = "00" + index;
            }
            else if (index < 100000)
            {
                to_Return = "0" + index;
            }
            else
            {
                to_Return = index.ToString();
            }
            _DmcapmaEntity_DATA.Macappk = to_Return;
            _DmcapmaEntity_DATA.Mastart = Mastart;
            if (IsOk) Update(_DmcapmaEntity_DATA);

            //sua de dung them MASTART
            if (_DmcapmaEntity_DATA.Mastart.Trim() != "") to_Return = _DmcapmaEntity_DATA.Mastart.Trim() + to_Return;
            return to_Return;
            #endregion
        }
        public static string GET_MA_DANHMUC(string LOAI_MA, bool IsOk, int Chieudai)
        {
            string to_Return = "1", Mastart = "";
            DmcapmaManagerBase _DmcapmaManagerBase = new DmcapmaManagerBase();
            EntityCollection _Collection = _DmcapmaManagerBase.SelectByLoaima(LOAI_MA);
            #region _Collection=NULL
            if (_Collection == null || _Collection.Items.Count == 0)
            {
                DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
                _DmcapmaEntity.Macappk = to_Return.PadLeft(Chieudai, '0');
                _DmcapmaEntity.Loaima = LOAI_MA;
                _DmcapmaEntity.Mastart = Mastart;
                if (IsOk) (new DmcapmaManagerBase()).Insert(_DmcapmaEntity);
                //sua de dung them MASTART
                if (_DmcapmaEntity.Mastart.Trim() != "") to_Return = Mastart + to_Return;
                return to_Return;
            }
            #endregion
            
            #region _Collection<>NULL
            DmcapmaEntity _DmcapmaEntity_DATA = (DmcapmaEntity)_Collection[0];
            string strindex = _DmcapmaEntity_DATA.Macappk;
            int index = int.Parse(strindex);
            if (Mastart != _DmcapmaEntity_DATA.Mastart) index = 0;
            index = index + 1;
            to_Return = index.ToString();
            to_Return = to_Return.PadLeft(Chieudai, '0');
            _DmcapmaEntity_DATA.Macappk = to_Return;
            _DmcapmaEntity_DATA.Mastart = Mastart;
            if (IsOk) Update(_DmcapmaEntity_DATA);

            //sua de dung them MASTART
            if (_DmcapmaEntity_DATA.Mastart.Trim() != "") to_Return = _DmcapmaEntity_DATA.Mastart.Trim() + to_Return;
            return to_Return;
            #endregion
        }
        private static bool Update_get_ma_int(DmcapmaEntity _DmcapmaEntity)
        {
            bool toReturn = false;
            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                RelationPredicateBucket filter = new RelationPredicateBucket();
                IPredicateExpression _PredicateExpression = new PredicateExpression();
                _PredicateExpression.Add(DmcapmaFields.Loaima == _DmcapmaEntity.Loaima);
                _PredicateExpression.AddWithAnd(DmcapmaFields.Mastart == _DmcapmaEntity.Mastart);
                filter.PredicateExpression.Add(_PredicateExpression);
                adapter.UpdateEntitiesDirectly(_DmcapmaEntity, filter);
                toReturn = true;
            }
            return toReturn;
        }
        private static bool Update(DmcapmaEntity _DmcapmaEntity)
        {
            bool toReturn = false;
            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                RelationPredicateBucket filter = new RelationPredicateBucket();
                IPredicateExpression _PredicateExpression = new PredicateExpression();
                _PredicateExpression.Add(DmcapmaFields.Loaima == _DmcapmaEntity.Loaima);
                filter.PredicateExpression.Add(_PredicateExpression);
                adapter.UpdateEntitiesDirectly(_DmcapmaEntity, filter);
                toReturn = true;
            }
            return toReturn;
        }
        public static EntityCollection SelectByLoaima_Mastart(string Loaima, string Mastart)
        {
            EntityCollection _DmcapmaCollection = new EntityCollection(new DmcapmaEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(DmcapmaFields.Loaima == Loaima);
            _PredicateExpression.AddWithAnd(DmcapmaFields.Mastart == Mastart);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchEntityCollection(_DmcapmaCollection, filter, 0, null);
            }
            return _DmcapmaCollection;
        }
	}
}
