
/*
'===============================================================================
'  GD.FM.BL.ThuchienhopdongbanhangManager
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
	public class ThuchienhopdongbanhangManager : ThuchienhopdongbanhangManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThuchienhopdongbanhangManager()
		{
			// Nothing for now.
		}
        public EntityCollection SelectBy_Sohopdong_Mahangphiakhach(string Sohopdong, string Mahangphiakhach)
        {
            EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.AddWithAnd(ThuchienhopdongbanhangFields.Sohopdong == Sohopdong);
            _PredicateExpression.AddWithAnd(ThuchienhopdongbanhangFields.Mahangphiakhach == Mahangphiakhach);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
            }
            return _ThuchienhopdongbanhangCollection;
        }
    }
}
