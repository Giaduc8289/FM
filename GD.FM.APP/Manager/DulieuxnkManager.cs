
/*
'===============================================================================
'  GD.FM.BL.DulieuxnkManager
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
	public class DulieuxnkManager : DulieuxnkManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DulieuxnkManager()
		{
			// Nothing for now.
		}

        public DataTable SelectBy_Nam_Thang(string Nam, string Thang)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.AddWithAnd(DulieuxnkFields.Nam == Nam);
            _PredicateExpression.AddWithAnd(DulieuxnkFields.Thang == Thang);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
