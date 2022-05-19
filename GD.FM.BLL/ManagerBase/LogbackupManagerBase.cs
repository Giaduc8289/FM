


/*
'===============================================================================
'  GD.FM.BL.LogbackupManagerBase
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
	public class LogbackupManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mahieu="Mahieu";				
		
		public const String Field_Nam="Nam";				
		
		public const String Field_Duongdan="Duongdan";				
		
		public const String Field_Ngay="Ngay";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LogbackupManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mahieu,typeof(System.Int64));
			
			dt.Columns.Add(Field_Nam,typeof(System.Int32));
			
			dt.Columns.Add(Field_Duongdan,typeof(System.String));
			
			dt.Columns.Add(Field_Ngay,typeof(System.DateTime));
									
		            
			return dt;			
		}
		public DataRow Convert(LogbackupEntity _LogbackupEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_LogbackupEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Nam]=_LogbackupEntity.Nam;
			}
			catch { }
			
			try
			{
				r[Field_Duongdan]=_LogbackupEntity.Duongdan;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_LogbackupEntity.Ngay;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public LogbackupEntity Convert(DataRow r)
		{	
			
			LogbackupEntity _LogbackupEntity=new LogbackupEntity(System.Int64.Parse(r[Field_Mahieu].ToString()));					
						
			
			
			try
			{
				_LogbackupEntity.Nam= System.Int32.Parse(r[Field_Nam].ToString());						
			}
			catch { }
			
			try
			{
				_LogbackupEntity.Duongdan= r[Field_Duongdan].ToString();						
			}
			catch { }
			
			try
			{
				_LogbackupEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
									
									
			return _LogbackupEntity;
		}			
		
		public LogbackupEntity Convert_Entity(LogbackupEntity _LogbackupEntity,LogbackupEntity _LogbackupEntity_XML)
		{	
			
			
			_LogbackupEntity.Mahieu= _LogbackupEntity_XML.Mahieu;
			
			_LogbackupEntity.Nam= _LogbackupEntity_XML.Nam;
			
			_LogbackupEntity.Duongdan= _LogbackupEntity_XML.Duongdan;
			
			_LogbackupEntity.Ngay= _LogbackupEntity_XML.Ngay;
									
				
			return _LogbackupEntity;
		}	
		
		public String InsertV2(LogbackupEntity _LogbackupEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new LogbackupManagerBase()).Insert(_LogbackupEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_LogbackupEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Nam,_LogbackupEntity.Nam);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Duongdan,_LogbackupEntity.Duongdan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngay,_LogbackupEntity.Ngay);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(LogbackupEntity _LogbackupEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new LogbackupManagerBase()).Update(_LogbackupEntity);
			r.SetField(Field_Mahieu,_LogbackupEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Nam,_LogbackupEntity.Nam);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Duongdan,_LogbackupEntity.Duongdan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngay,_LogbackupEntity.Ngay);
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

		public LogbackupEntity Insert(LogbackupEntity LogbackupEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(LogbackupEntity, true);
			}
			return LogbackupEntity;
		}

		public LogbackupEntity Insert(System.Int64  Mahieu, System.Int32  Nam, System.String  Duongdan, System.DateTime  Ngay)
		{
			LogbackupEntity _LogbackupEntity = new LogbackupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LogbackupEntity.Mahieu = Mahieu;
				
				_LogbackupEntity.Nam = Nam;
				
				_LogbackupEntity.Duongdan = Duongdan;
				
				_LogbackupEntity.Ngay = Ngay;
					
					
				adapter.SaveEntity(_LogbackupEntity, true);
			}
			return _LogbackupEntity;
		}

		public LogbackupEntity Insert(System.Int32 Nam, System.String Duongdan, System.DateTime Ngay)//ko co mahieu
		{
			LogbackupEntity _LogbackupEntity = new LogbackupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_LogbackupEntity.Nam = Nam;
				
				_LogbackupEntity.Duongdan = Duongdan;
				
				_LogbackupEntity.Ngay = Ngay;
					

				adapter.SaveEntity(_LogbackupEntity, true);
			}
			return _LogbackupEntity;
		}

		public bool Update(LogbackupEntity _LogbackupEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(LogbackupFields.Mahieu == _LogbackupEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_LogbackupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(LogbackupEntity _LogbackupEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_LogbackupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Mahieu, System.Int32 Nam, System.String Duongdan, System.DateTime Ngay)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LogbackupEntity _LogbackupEntity = new LogbackupEntity(Mahieu);
				if (adapter.FetchEntity(_LogbackupEntity))
				{
				
					
					
					_LogbackupEntity.Nam = Nam;
					
					_LogbackupEntity.Duongdan = Duongdan;
					
					_LogbackupEntity.Ngay = Ngay;
						

					adapter.SaveEntity(_LogbackupEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.Int64 Mahieu)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LogbackupEntity _LogbackupEntity = new LogbackupEntity(Mahieu);
				if (adapter.FetchEntity(_LogbackupEntity))
				{
					adapter.DeleteEntity(_LogbackupEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("LogbackupEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.Int64 Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LogbackupEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNam(System.Int32 Nam)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Nam == Nam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LogbackupEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDuongdan(System.String Duongdan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Duongdan == Duongdan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LogbackupEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LogbackupEntity", filter);
			}
			return toReturn;
		}		
			
		
		public LogbackupEntity SelectOne(System.Int64 Mahieu)
		{
			LogbackupEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LogbackupEntity _LogbackupEntity = new LogbackupEntity(Mahieu);
				if (adapter.FetchEntity(_LogbackupEntity))
				{
					toReturn = _LogbackupEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _LogbackupCollection = new EntityCollection( new LogbackupEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LogbackupCollection, null, 0, null);
			}
			return _LogbackupCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LogbackupCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.Int64 Mahieu)
		{
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LogbackupCollection, filter, 0, null);
			}
			return _LogbackupCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.Int64 Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LogbackupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNam(System.Int32 Nam)
		{
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Nam == Nam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LogbackupCollection, filter, 0, null);
			}
			return _LogbackupCollection;
		}
		// Return DataTable
		public DataTable SelectByNamRDT(System.Int32 Nam)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Nam == Nam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LogbackupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDuongdan(System.String Duongdan)
		{
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Duongdan == Duongdan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LogbackupCollection, filter, 0, null);
			}
			return _LogbackupCollection;
		}
		// Return DataTable
		public DataTable SelectByDuongdanRDT(System.String Duongdan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Duongdan == Duongdan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LogbackupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LogbackupCollection, filter, 0, null);
			}
			return _LogbackupCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LogbackupCollection = new EntityCollection(new LogbackupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LogbackupFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LogbackupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
