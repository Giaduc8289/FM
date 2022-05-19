


/*
'===============================================================================
'  GD.FM.BL.RolesManagerBase
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
	public class RolesManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Rolesid="Rolesid";				
		
		public const String Field_Rolesname="Rolesname";				
		
		public const String Field_Description="Description";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public RolesManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Rolesid,typeof(System.String));
			
			dt.Columns.Add(Field_Rolesname,typeof(System.String));
			
			dt.Columns.Add(Field_Description,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(RolesEntity _RolesEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Rolesid]=_RolesEntity.Rolesid;
			}
			catch { }
			
			try
			{
				r[Field_Rolesname]=_RolesEntity.Rolesname;
			}
			catch { }
			
			try
			{
				r[Field_Description]=_RolesEntity.Description;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public RolesEntity Convert(DataRow r)
		{	
			
			RolesEntity _RolesEntity=new RolesEntity(r[Field_Rolesid].ToString());					
						
			
			
			try
			{
				_RolesEntity.Rolesname= r[Field_Rolesname].ToString();						
			}
			catch { }
			
			try
			{
				_RolesEntity.Description= r[Field_Description].ToString();						
			}
			catch { }
									
									
			return _RolesEntity;
		}			
		
		public RolesEntity Convert_Entity(RolesEntity _RolesEntity,RolesEntity _RolesEntity_XML)
		{	
			
			
			_RolesEntity.Rolesid= _RolesEntity_XML.Rolesid;
			
			_RolesEntity.Rolesname= _RolesEntity_XML.Rolesname;
			
			_RolesEntity.Description= _RolesEntity_XML.Description;
									
				
			return _RolesEntity;
		}	
		
		public String InsertV2(RolesEntity _RolesEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new RolesManagerBase()).Insert(_RolesEntity).Rolesid.ToString();
			
			
			try
			{
				r.SetField(Field_Rolesid,_RolesEntity.Rolesid);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Rolesname,_RolesEntity.Rolesname);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Description,_RolesEntity.Description);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(RolesEntity _RolesEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new RolesManagerBase()).Update(_RolesEntity);
			r.SetField(Field_Rolesid,_RolesEntity.Rolesid);
									
			
			
			
			try
			{
				r.SetField(Field_Rolesname,_RolesEntity.Rolesname);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Description,_RolesEntity.Description);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
		}

		public void InsertCollection(EntityCollection _Collection)
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntityCollection(_Collection);
			}
		}

		public RolesEntity Insert(RolesEntity RolesEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(RolesEntity, true);
			}
			return RolesEntity;
		}

		public RolesEntity Insert(System.String  Rolesid, System.String  Rolesname, System.String  Description)
		{
			RolesEntity _RolesEntity = new RolesEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_RolesEntity.Rolesid = Rolesid;
				
				_RolesEntity.Rolesname = Rolesname;
				
				_RolesEntity.Description = Description;
					
					
				adapter.SaveEntity(_RolesEntity, true);
			}
			return _RolesEntity;
		}

		public RolesEntity Insert(System.String Rolesname, System.String Description)//ko co mahieu
		{
			RolesEntity _RolesEntity = new RolesEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_RolesEntity.Rolesname = Rolesname;
				
				_RolesEntity.Description = Description;
					

				adapter.SaveEntity(_RolesEntity, true);
			}
			return _RolesEntity;
		}

		public bool Update(RolesEntity _RolesEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(RolesFields.Rolesid == _RolesEntity.Rolesid);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_RolesEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(RolesEntity _RolesEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_RolesEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Rolesid, System.String Rolesname, System.String Description)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RolesEntity _RolesEntity = new RolesEntity(Rolesid);
				if (adapter.FetchEntity(_RolesEntity))
				{
				
					
					
					_RolesEntity.Rolesname = Rolesname;
					
					_RolesEntity.Description = Description;
						

					adapter.SaveEntity(_RolesEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Rolesid)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RolesEntity _RolesEntity = new RolesEntity(Rolesid);
				if (adapter.FetchEntity(_RolesEntity))
				{
					adapter.DeleteEntity(_RolesEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("RolesEntity", null);
			}
		}
		
		
		
		public int DeleteByRolesid(System.String Rolesid)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("RolesEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByRolesname(System.String Rolesname)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Rolesname == Rolesname);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("RolesEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDescription(System.String Description)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("RolesEntity", filter);
			}
			return toReturn;
		}		
			
		
		public RolesEntity SelectOne(System.String Rolesid)
		{
			RolesEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RolesEntity _RolesEntity = new RolesEntity(Rolesid);
				if (adapter.FetchEntity(_RolesEntity))
				{
					toReturn = _RolesEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _RolesCollection = new EntityCollection( new RolesEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_RolesCollection, null, 0, null);
			}
			return _RolesCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _RolesCollection = new EntityCollection(new RolesEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_RolesCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByRolesid(System.String Rolesid)
		{
			EntityCollection _RolesCollection = new EntityCollection(new RolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_RolesCollection, filter, 0, null);
			}
			return _RolesCollection;
		}
		// Return DataTable
		public DataTable SelectByRolesidRDT(System.String Rolesid)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _RolesCollection = new EntityCollection(new RolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_RolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByRolesname(System.String Rolesname)
		{
			EntityCollection _RolesCollection = new EntityCollection(new RolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Rolesname == Rolesname);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_RolesCollection, filter, 0, null);
			}
			return _RolesCollection;
		}
		// Return DataTable
		public DataTable SelectByRolesnameRDT(System.String Rolesname)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _RolesCollection = new EntityCollection(new RolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Rolesname == Rolesname);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_RolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDescription(System.String Description)
		{
			EntityCollection _RolesCollection = new EntityCollection(new RolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_RolesCollection, filter, 0, null);
			}
			return _RolesCollection;
		}
		// Return DataTable
		public DataTable SelectByDescriptionRDT(System.String Description)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _RolesCollection = new EntityCollection(new RolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(RolesFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_RolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
