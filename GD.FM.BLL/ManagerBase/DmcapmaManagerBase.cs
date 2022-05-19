


/*
'===============================================================================
'  GD.FM.BL.DmcapmaManagerBase
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
	public class DmcapmaManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Macappk="Macappk";				
		
		public const String Field_Loaima="Loaima";				
		
		public const String Field_Mastart="Mastart";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcapmaManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Macappk,typeof(System.String));
			
			dt.Columns.Add(Field_Loaima,typeof(System.String));
			
			dt.Columns.Add(Field_Mastart,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmcapmaEntity _DmcapmaEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Macappk]=_DmcapmaEntity.Macappk;
			}
			catch { }
			
			try
			{
				r[Field_Loaima]=_DmcapmaEntity.Loaima;
			}
			catch { }
			
			try
			{
				r[Field_Mastart]=_DmcapmaEntity.Mastart;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmcapmaEntity Convert(DataRow r)
		{	
			
			DmcapmaEntity _DmcapmaEntity=new DmcapmaEntity(r[Field_Loaima].ToString());					
						
			
			try
			{
				_DmcapmaEntity.Macappk= r[Field_Macappk].ToString();						
			}
			catch { }
			
			
			try
			{
				_DmcapmaEntity.Mastart= r[Field_Mastart].ToString();						
			}
			catch { }
									
									
			return _DmcapmaEntity;
		}			
		
		public DmcapmaEntity Convert_Entity(DmcapmaEntity _DmcapmaEntity,DmcapmaEntity _DmcapmaEntity_XML)
		{	
			
			
			_DmcapmaEntity.Macappk= _DmcapmaEntity_XML.Macappk;
			
			_DmcapmaEntity.Loaima= _DmcapmaEntity_XML.Loaima;
			
			_DmcapmaEntity.Mastart= _DmcapmaEntity_XML.Mastart;
									
				
			return _DmcapmaEntity;
		}	
		
		public String InsertV2(DmcapmaEntity _DmcapmaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmcapmaManagerBase()).Insert(_DmcapmaEntity).Loaima.ToString();
			
			
			try
			{
				r.SetField(Field_Loaima,_DmcapmaEntity.Loaima);
			}
			catch { }
			
			
			
			try
			{
				r.SetField(Field_Macappk,_DmcapmaEntity.Macappk);
			}
			catch { }
			
			
			try
			{
				r.SetField(Field_Mastart,_DmcapmaEntity.Mastart);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmcapmaEntity _DmcapmaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmcapmaManagerBase()).Update(_DmcapmaEntity);
			r.SetField(Field_Loaima,_DmcapmaEntity.Loaima);
									
			
			
			try
			{
				r.SetField(Field_Macappk,_DmcapmaEntity.Macappk);
			}
			catch { }
			
			
			try
			{
				r.SetField(Field_Mastart,_DmcapmaEntity.Mastart);
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

		public DmcapmaEntity Insert(DmcapmaEntity DmcapmaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmcapmaEntity, true);
			}
			return DmcapmaEntity;
		}

		public DmcapmaEntity Insert(System.String  Macappk, System.String  Loaima, System.String  Mastart)
		{
			DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmcapmaEntity.Macappk = Macappk;
				
				_DmcapmaEntity.Loaima = Loaima;
				
				_DmcapmaEntity.Mastart = Mastart;
					
					
				adapter.SaveEntity(_DmcapmaEntity, true);
			}
			return _DmcapmaEntity;
		}

		public DmcapmaEntity Insert(System.String Macappk, System.String Mastart)//ko co mahieu
		{
			DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmcapmaEntity.Macappk = Macappk;
				
				
				_DmcapmaEntity.Mastart = Mastart;
					

				adapter.SaveEntity(_DmcapmaEntity, true);
			}
			return _DmcapmaEntity;
		}

		public bool Update(DmcapmaEntity _DmcapmaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
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
		
		public bool Update(DmcapmaEntity _DmcapmaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmcapmaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Macappk, System.String Loaima, System.String Mastart)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity(Loaima);
				if (adapter.FetchEntity(_DmcapmaEntity))
				{
				
					
					_DmcapmaEntity.Macappk = Macappk;
					
					
					_DmcapmaEntity.Mastart = Mastart;
						

					adapter.SaveEntity(_DmcapmaEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Loaima)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity(Loaima);
				if (adapter.FetchEntity(_DmcapmaEntity))
				{
					adapter.DeleteEntity(_DmcapmaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmcapmaEntity", null);
			}
		}
		
		
		
		public int DeleteByMacappk(System.String Macappk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Macappk == Macappk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcapmaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaima(System.String Loaima)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Loaima == Loaima);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcapmaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMastart(System.String Mastart)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Mastart == Mastart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcapmaEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmcapmaEntity SelectOne(System.String Loaima)
		{
			DmcapmaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity(Loaima);
				if (adapter.FetchEntity(_DmcapmaEntity))
				{
					toReturn = _DmcapmaEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmcapmaCollection = new EntityCollection( new DmcapmaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcapmaCollection, null, 0, null);
			}
			return _DmcapmaCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcapmaCollection = new EntityCollection(new DmcapmaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcapmaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMacappk(System.String Macappk)
		{
			EntityCollection _DmcapmaCollection = new EntityCollection(new DmcapmaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Macappk == Macappk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcapmaCollection, filter, 0, null);
			}
			return _DmcapmaCollection;
		}
		// Return DataTable
		public DataTable SelectByMacappkRDT(System.String Macappk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcapmaCollection = new EntityCollection(new DmcapmaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Macappk == Macappk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcapmaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaima(System.String Loaima)
		{
			EntityCollection _DmcapmaCollection = new EntityCollection(new DmcapmaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Loaima == Loaima);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcapmaCollection, filter, 0, null);
			}
			return _DmcapmaCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaimaRDT(System.String Loaima)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcapmaCollection = new EntityCollection(new DmcapmaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Loaima == Loaima);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcapmaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMastart(System.String Mastart)
		{
			EntityCollection _DmcapmaCollection = new EntityCollection(new DmcapmaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Mastart == Mastart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcapmaCollection, filter, 0, null);
			}
			return _DmcapmaCollection;
		}
		// Return DataTable
		public DataTable SelectByMastartRDT(System.String Mastart)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcapmaCollection = new EntityCollection(new DmcapmaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcapmaFields.Mastart == Mastart);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcapmaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
