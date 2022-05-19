


/*
'===============================================================================
'  GD.FM.BL.ThamsoManagerBase
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
	public class ThamsoManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mahieu="Mahieu";				
		
		public const String Field_Stt="Stt";				
		
		public const String Field_Tenthamso="Tenthamso";				
		
		public const String Field_Giatri="Giatri";				
		
		public const String Field_Thaydoi="Thaydoi";				
		
		public const String Field_Kieudulieu="Kieudulieu";				
		
		public const String Field_Ghichu="Ghichu";				
		
		public const String Field_Loaithamso="Loaithamso";				
		
		public const String Field_An="An";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThamsoManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mahieu,typeof(System.String));
			
			dt.Columns.Add(Field_Stt,typeof(System.Int32));
			
			dt.Columns.Add(Field_Tenthamso,typeof(System.String));
			
			dt.Columns.Add(Field_Giatri,typeof(System.String));
			
			dt.Columns.Add(Field_Thaydoi,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Kieudulieu,typeof(System.Int32));
			
			dt.Columns.Add(Field_Ghichu,typeof(System.String));
			
			dt.Columns.Add(Field_Loaithamso,typeof(System.Int32));
			
			dt.Columns.Add(Field_An,typeof(System.Boolean));
									
		            
			return dt;			
		}
		public DataRow Convert(ThamsoEntity _ThamsoEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_ThamsoEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Stt]=_ThamsoEntity.Stt;
			}
			catch { }
			
			try
			{
				r[Field_Tenthamso]=_ThamsoEntity.Tenthamso;
			}
			catch { }
			
			try
			{
				r[Field_Giatri]=_ThamsoEntity.Giatri;
			}
			catch { }
			
			try
			{
				r[Field_Thaydoi]=_ThamsoEntity.Thaydoi;
			}
			catch { }
			
			try
			{
				r[Field_Kieudulieu]=_ThamsoEntity.Kieudulieu;
			}
			catch { }
			
			try
			{
				r[Field_Ghichu]=_ThamsoEntity.Ghichu;
			}
			catch { }
			
			try
			{
				r[Field_Loaithamso]=_ThamsoEntity.Loaithamso;
			}
			catch { }
			
			try
			{
				r[Field_An]=_ThamsoEntity.An;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public ThamsoEntity Convert(DataRow r)
		{	
			
			ThamsoEntity _ThamsoEntity=new ThamsoEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_ThamsoEntity.Stt= System.Int32.Parse(r[Field_Stt].ToString());						
			}
			catch { }
			
			try
			{
				_ThamsoEntity.Tenthamso= r[Field_Tenthamso].ToString();						
			}
			catch { }
			
			try
			{
				_ThamsoEntity.Giatri= r[Field_Giatri].ToString();						
			}
			catch { }
			
			try
			{
				_ThamsoEntity.Thaydoi= System.Boolean.Parse(r[Field_Thaydoi].ToString());						
			}
			catch { }
			
			try
			{
				_ThamsoEntity.Kieudulieu= System.Int32.Parse(r[Field_Kieudulieu].ToString());						
			}
			catch { }
			
			try
			{
				_ThamsoEntity.Ghichu= r[Field_Ghichu].ToString();						
			}
			catch { }
			
			try
			{
				_ThamsoEntity.Loaithamso= System.Int32.Parse(r[Field_Loaithamso].ToString());						
			}
			catch { }
			
			try
			{
				_ThamsoEntity.An= System.Boolean.Parse(r[Field_An].ToString());						
			}
			catch { }
									
									
			return _ThamsoEntity;
		}			
		
		public ThamsoEntity Convert_Entity(ThamsoEntity _ThamsoEntity,ThamsoEntity _ThamsoEntity_XML)
		{	
			
			
			_ThamsoEntity.Mahieu= _ThamsoEntity_XML.Mahieu;
			
			_ThamsoEntity.Stt= _ThamsoEntity_XML.Stt;
			
			_ThamsoEntity.Tenthamso= _ThamsoEntity_XML.Tenthamso;
			
			_ThamsoEntity.Giatri= _ThamsoEntity_XML.Giatri;
			
			_ThamsoEntity.Thaydoi= _ThamsoEntity_XML.Thaydoi;
			
			_ThamsoEntity.Kieudulieu= _ThamsoEntity_XML.Kieudulieu;
			
			_ThamsoEntity.Ghichu= _ThamsoEntity_XML.Ghichu;
			
			_ThamsoEntity.Loaithamso= _ThamsoEntity_XML.Loaithamso;
			
			_ThamsoEntity.An= _ThamsoEntity_XML.An;
									
				
			return _ThamsoEntity;
		}	
		
		public String InsertV2(ThamsoEntity _ThamsoEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new ThamsoManagerBase()).Insert(_ThamsoEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_ThamsoEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Stt,_ThamsoEntity.Stt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenthamso,_ThamsoEntity.Tenthamso);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Giatri,_ThamsoEntity.Giatri);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thaydoi,_ThamsoEntity.Thaydoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kieudulieu,_ThamsoEntity.Kieudulieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_ThamsoEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaithamso,_ThamsoEntity.Loaithamso);
			}
			catch { }
			
			try
			{
				r.SetField(Field_An,_ThamsoEntity.An);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(ThamsoEntity _ThamsoEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new ThamsoManagerBase()).Update(_ThamsoEntity);
			r.SetField(Field_Mahieu,_ThamsoEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Stt,_ThamsoEntity.Stt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenthamso,_ThamsoEntity.Tenthamso);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Giatri,_ThamsoEntity.Giatri);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thaydoi,_ThamsoEntity.Thaydoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kieudulieu,_ThamsoEntity.Kieudulieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_ThamsoEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaithamso,_ThamsoEntity.Loaithamso);
			}
			catch { }
			
			try
			{
				r.SetField(Field_An,_ThamsoEntity.An);
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

		public ThamsoEntity Insert(ThamsoEntity ThamsoEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(ThamsoEntity, true);
			}
			return ThamsoEntity;
		}

		public ThamsoEntity Insert(System.String  Mahieu, System.Int32  Stt, System.String  Tenthamso, System.String  Giatri, System.Boolean  Thaydoi, System.Int32  Kieudulieu, System.String  Ghichu, System.Int32  Loaithamso, System.Boolean  An)
		{
			ThamsoEntity _ThamsoEntity = new ThamsoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ThamsoEntity.Mahieu = Mahieu;
				
				_ThamsoEntity.Stt = Stt;
				
				_ThamsoEntity.Tenthamso = Tenthamso;
				
				_ThamsoEntity.Giatri = Giatri;
				
				_ThamsoEntity.Thaydoi = Thaydoi;
				
				_ThamsoEntity.Kieudulieu = Kieudulieu;
				
				_ThamsoEntity.Ghichu = Ghichu;
				
				_ThamsoEntity.Loaithamso = Loaithamso;
				
				_ThamsoEntity.An = An;
					
					
				adapter.SaveEntity(_ThamsoEntity, true);
			}
			return _ThamsoEntity;
		}

		public ThamsoEntity Insert(System.Int32 Stt, System.String Tenthamso, System.String Giatri, System.Boolean Thaydoi, System.Int32 Kieudulieu, System.String Ghichu, System.Int32 Loaithamso, System.Boolean An)//ko co mahieu
		{
			ThamsoEntity _ThamsoEntity = new ThamsoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_ThamsoEntity.Stt = Stt;
				
				_ThamsoEntity.Tenthamso = Tenthamso;
				
				_ThamsoEntity.Giatri = Giatri;
				
				_ThamsoEntity.Thaydoi = Thaydoi;
				
				_ThamsoEntity.Kieudulieu = Kieudulieu;
				
				_ThamsoEntity.Ghichu = Ghichu;
				
				_ThamsoEntity.Loaithamso = Loaithamso;
				
				_ThamsoEntity.An = An;
					

				adapter.SaveEntity(_ThamsoEntity, true);
			}
			return _ThamsoEntity;
		}

		public bool Update(ThamsoEntity _ThamsoEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(ThamsoFields.Mahieu == _ThamsoEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ThamsoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ThamsoEntity _ThamsoEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ThamsoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.Int32 Stt, System.String Tenthamso, System.String Giatri, System.Boolean Thaydoi, System.Int32 Kieudulieu, System.String Ghichu, System.Int32 Loaithamso, System.Boolean An)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThamsoEntity _ThamsoEntity = new ThamsoEntity(Mahieu);
				if (adapter.FetchEntity(_ThamsoEntity))
				{
				
					
					
					_ThamsoEntity.Stt = Stt;
					
					_ThamsoEntity.Tenthamso = Tenthamso;
					
					_ThamsoEntity.Giatri = Giatri;
					
					_ThamsoEntity.Thaydoi = Thaydoi;
					
					_ThamsoEntity.Kieudulieu = Kieudulieu;
					
					_ThamsoEntity.Ghichu = Ghichu;
					
					_ThamsoEntity.Loaithamso = Loaithamso;
					
					_ThamsoEntity.An = An;
						

					adapter.SaveEntity(_ThamsoEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Mahieu)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThamsoEntity _ThamsoEntity = new ThamsoEntity(Mahieu);
				if (adapter.FetchEntity(_ThamsoEntity))
				{
					adapter.DeleteEntity(_ThamsoEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ThamsoEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByStt(System.Int32 Stt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Stt == Stt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenthamso(System.String Tenthamso)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Tenthamso == Tenthamso);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGiatri(System.String Giatri)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Giatri == Giatri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThaydoi(System.Boolean Thaydoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Thaydoi == Thaydoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKieudulieu(System.Int32 Kieudulieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Kieudulieu == Kieudulieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGhichu(System.String Ghichu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaithamso(System.Int32 Loaithamso)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Loaithamso == Loaithamso);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByAn(System.Boolean An)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.An == An);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThamsoEntity", filter);
			}
			return toReturn;
		}		
			
		
		public ThamsoEntity SelectOne(System.String Mahieu)
		{
			ThamsoEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThamsoEntity _ThamsoEntity = new ThamsoEntity(Mahieu);
				if (adapter.FetchEntity(_ThamsoEntity))
				{
					toReturn = _ThamsoEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _ThamsoCollection = new EntityCollection( new ThamsoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, null, 0, null);
			}
			return _ThamsoCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByStt(System.Int32 Stt)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Stt == Stt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectBySttRDT(System.Int32 Stt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Stt == Stt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenthamso(System.String Tenthamso)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Tenthamso == Tenthamso);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectByTenthamsoRDT(System.String Tenthamso)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Tenthamso == Tenthamso);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGiatri(System.String Giatri)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Giatri == Giatri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectByGiatriRDT(System.String Giatri)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Giatri == Giatri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThaydoi(System.Boolean Thaydoi)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Thaydoi == Thaydoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectByThaydoiRDT(System.Boolean Thaydoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Thaydoi == Thaydoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKieudulieu(System.Int32 Kieudulieu)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Kieudulieu == Kieudulieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectByKieudulieuRDT(System.Int32 Kieudulieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Kieudulieu == Kieudulieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGhichu(System.String Ghichu)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectByGhichuRDT(System.String Ghichu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaithamso(System.Int32 Loaithamso)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Loaithamso == Loaithamso);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaithamsoRDT(System.Int32 Loaithamso)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.Loaithamso == Loaithamso);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByAn(System.Boolean An)
		{
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.An == An);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThamsoCollection, filter, 0, null);
			}
			return _ThamsoCollection;
		}
		// Return DataTable
		public DataTable SelectByAnRDT(System.Boolean An)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThamsoCollection = new EntityCollection(new ThamsoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThamsoFields.An == An);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThamsoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
