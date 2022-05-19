


/*
'===============================================================================
'  GD.FM.BL.MenuroleManagerBase
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
using System.Windows.Forms;
namespace GD.FM.BLL
{
	public class MenuroleManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Menuid="Menuid";				
		
		public const String Field_Rolesid="Rolesid";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MenuroleManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Menuid,typeof(System.String));
			
			dt.Columns.Add(Field_Rolesid,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(MenuroleEntity _MenuroleEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Menuid]=_MenuroleEntity.Menuid;
			}
			catch { }
			
			try
			{
				r[Field_Rolesid]=_MenuroleEntity.Rolesid;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public MenuroleEntity Convert(DataRow r)
		{	
			
			MenuroleEntity _MenuroleEntity=new MenuroleEntity(r[Field_Menuid].ToString(), r[Field_Rolesid].ToString());					
						
			
			
									
									
			return _MenuroleEntity;
		}			
		
		public MenuroleEntity Convert_Entity(MenuroleEntity _MenuroleEntity,MenuroleEntity _MenuroleEntity_XML)
		{	
			
			
			_MenuroleEntity.Menuid= _MenuroleEntity_XML.Menuid;
			
			_MenuroleEntity.Rolesid= _MenuroleEntity_XML.Rolesid;
									
				
			return _MenuroleEntity;
		}	
		
		public String InsertV2(MenuroleEntity _MenuroleEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			//String id =(new MenuroleManagerBase()).Insert(_MenuroleEntity).Menuid.ToString();
			
			String id =(new MenuroleManagerBase()).Insert(_MenuroleEntity).Rolesid.ToString();
			
			
			try
			{
				r.SetField(Field_Menuid,_MenuroleEntity.Menuid);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Rolesid,_MenuroleEntity.Rolesid);
			}
			catch { }
			
			
			
			
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(MenuroleEntity _MenuroleEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new MenuroleManagerBase()).Update(_MenuroleEntity);
			r.SetField(Field_Menuid,_MenuroleEntity.Menuid);
			
			(new MenuroleManagerBase()).Update(_MenuroleEntity);
			r.SetField(Field_Rolesid,_MenuroleEntity.Rolesid);
									
			
			
			
									
			
			_BindingSource.ResetCurrentItem();
		}

		public void InsertCollection(EntityCollection _Collection)
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntityCollection(_Collection);
			}
		}

		public MenuroleEntity Insert(MenuroleEntity MenuroleEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(MenuroleEntity, true);
			}
			return MenuroleEntity;
		}

		public MenuroleEntity Insert(System.String  Menuid, System.String  Rolesid)
		{
			MenuroleEntity _MenuroleEntity = new MenuroleEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MenuroleEntity.Menuid = Menuid;
				
				_MenuroleEntity.Rolesid = Rolesid;
					
					
				adapter.SaveEntity(_MenuroleEntity, true);
			}
			return _MenuroleEntity;
		}

		public MenuroleEntity Insert()//ko co mahieu
		{
			MenuroleEntity _MenuroleEntity = new MenuroleEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
					

				adapter.SaveEntity(_MenuroleEntity, true);
			}
			return _MenuroleEntity;
		}

		public bool Update(MenuroleEntity _MenuroleEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(MenuroleFields.Menuid == _MenuroleEntity.Menuid);
				
				_PredicateExpression.Add(MenuroleFields.Rolesid == _MenuroleEntity.Rolesid);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MenuroleEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MenuroleEntity _MenuroleEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MenuroleEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Menuid, System.String Rolesid)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuroleEntity _MenuroleEntity = new MenuroleEntity(Menuid, Rolesid);
				if (adapter.FetchEntity(_MenuroleEntity))
				{
				
					
					
						

					adapter.SaveEntity(_MenuroleEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Menuid, System.String Rolesid)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuroleEntity _MenuroleEntity = new MenuroleEntity(Menuid, Rolesid);
				if (adapter.FetchEntity(_MenuroleEntity))
				{
					adapter.DeleteEntity(_MenuroleEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MenuroleEntity", null);
			}
		}
		
		
		
		public int DeleteByMenuid(System.String Menuid)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuroleFields.Menuid == Menuid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuroleEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByRolesid(System.String Rolesid)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuroleFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuroleEntity", filter);
			}
			return toReturn;
		}		
			
		
		public MenuroleEntity SelectOne(System.String Menuid, System.String Rolesid)
		{
			MenuroleEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuroleEntity _MenuroleEntity = new MenuroleEntity(Menuid, Rolesid);
				if (adapter.FetchEntity(_MenuroleEntity))
				{
					toReturn = _MenuroleEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _MenuroleCollection = new EntityCollection( new MenuroleEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuroleCollection, null, 0, null);
			}
			return _MenuroleCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuroleCollection = new EntityCollection(new MenuroleEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuroleCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMenuid(System.String Menuid)
		{
			EntityCollection _MenuroleCollection = new EntityCollection(new MenuroleEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuroleFields.Menuid == Menuid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuroleCollection, filter, 0, null);
			}
			return _MenuroleCollection;
		}
		// Return DataTable
		public DataTable SelectByMenuidRDT(System.String Menuid)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuroleCollection = new EntityCollection(new MenuroleEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuroleFields.Menuid == Menuid);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuroleCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByRolesid(System.String Rolesid)
		{
			EntityCollection _MenuroleCollection = new EntityCollection(new MenuroleEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuroleFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuroleCollection, filter, 0, null);
			}
			return _MenuroleCollection;
		}
		// Return DataTable
		public DataTable SelectByRolesidRDT(System.String Rolesid)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuroleCollection = new EntityCollection(new MenuroleEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuroleFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuroleCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
