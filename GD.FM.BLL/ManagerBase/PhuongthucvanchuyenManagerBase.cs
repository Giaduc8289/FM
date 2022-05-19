


/*
'===============================================================================
'  GD.FM.BL.PhuongthucvanchuyenManagerBase
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
	public class PhuongthucvanchuyenManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mahieu="Mahieu";				
		
		public const String Field_Tenhieu="Tenhieu";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhuongthucvanchuyenManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mahieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenhieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_PhuongthucvanchuyenEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenhieu]=_PhuongthucvanchuyenEntity.Tenhieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_PhuongthucvanchuyenEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_PhuongthucvanchuyenEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_PhuongthucvanchuyenEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_PhuongthucvanchuyenEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_PhuongthucvanchuyenEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public PhuongthucvanchuyenEntity Convert(DataRow r)
		{	
			
			PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity=new PhuongthucvanchuyenEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_PhuongthucvanchuyenEntity.Tenhieu= r[Field_Tenhieu].ToString();						
			}
			catch { }
			
			try
			{
				_PhuongthucvanchuyenEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_PhuongthucvanchuyenEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_PhuongthucvanchuyenEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_PhuongthucvanchuyenEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_PhuongthucvanchuyenEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _PhuongthucvanchuyenEntity;
		}			
		
		public PhuongthucvanchuyenEntity Convert_Entity(PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity,PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity_XML)
		{	
			
			
			_PhuongthucvanchuyenEntity.Mahieu= _PhuongthucvanchuyenEntity_XML.Mahieu;
			
			_PhuongthucvanchuyenEntity.Tenhieu= _PhuongthucvanchuyenEntity_XML.Tenhieu;
			
			_PhuongthucvanchuyenEntity.Tenrutgon= _PhuongthucvanchuyenEntity_XML.Tenrutgon;
			
			_PhuongthucvanchuyenEntity.Ngaytao= _PhuongthucvanchuyenEntity_XML.Ngaytao;
			
			_PhuongthucvanchuyenEntity.Nguoitao= _PhuongthucvanchuyenEntity_XML.Nguoitao;
			
			_PhuongthucvanchuyenEntity.Ngaysua= _PhuongthucvanchuyenEntity_XML.Ngaysua;
			
			_PhuongthucvanchuyenEntity.Nguoisua= _PhuongthucvanchuyenEntity_XML.Nguoisua;
									
				
			return _PhuongthucvanchuyenEntity;
		}	
		
		public String InsertV2(PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new PhuongthucvanchuyenManagerBase()).Insert(_PhuongthucvanchuyenEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_PhuongthucvanchuyenEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_PhuongthucvanchuyenEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_PhuongthucvanchuyenEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhuongthucvanchuyenEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhuongthucvanchuyenEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhuongthucvanchuyenEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhuongthucvanchuyenEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new PhuongthucvanchuyenManagerBase()).Update(_PhuongthucvanchuyenEntity);
			r.SetField(Field_Mahieu,_PhuongthucvanchuyenEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_PhuongthucvanchuyenEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_PhuongthucvanchuyenEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhuongthucvanchuyenEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhuongthucvanchuyenEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhuongthucvanchuyenEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhuongthucvanchuyenEntity.Nguoisua);
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

		public PhuongthucvanchuyenEntity Insert(PhuongthucvanchuyenEntity PhuongthucvanchuyenEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(PhuongthucvanchuyenEntity, true);
			}
			return PhuongthucvanchuyenEntity;
		}

		public PhuongthucvanchuyenEntity Insert(System.String  Mahieu, System.String  Tenhieu, System.String  Tenrutgon, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhuongthucvanchuyenEntity.Mahieu = Mahieu;
				
				_PhuongthucvanchuyenEntity.Tenhieu = Tenhieu;
				
				_PhuongthucvanchuyenEntity.Tenrutgon = Tenrutgon;
				
				_PhuongthucvanchuyenEntity.Ngaytao = Ngaytao;
				
				_PhuongthucvanchuyenEntity.Nguoitao = Nguoitao;
				
				_PhuongthucvanchuyenEntity.Ngaysua = Ngaysua;
				
				_PhuongthucvanchuyenEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_PhuongthucvanchuyenEntity, true);
			}
			return _PhuongthucvanchuyenEntity;
		}

		public PhuongthucvanchuyenEntity Insert(System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_PhuongthucvanchuyenEntity.Tenhieu = Tenhieu;
				
				_PhuongthucvanchuyenEntity.Tenrutgon = Tenrutgon;
				
				_PhuongthucvanchuyenEntity.Ngaytao = Ngaytao;
				
				_PhuongthucvanchuyenEntity.Nguoitao = Nguoitao;
				
				_PhuongthucvanchuyenEntity.Ngaysua = Ngaysua;
				
				_PhuongthucvanchuyenEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_PhuongthucvanchuyenEntity, true);
			}
			return _PhuongthucvanchuyenEntity;
		}

		public bool Update(PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(PhuongthucvanchuyenFields.Mahieu == _PhuongthucvanchuyenEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhuongthucvanchuyenEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhuongthucvanchuyenEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity(Mahieu);
				if (adapter.FetchEntity(_PhuongthucvanchuyenEntity))
				{
				
					
					
					_PhuongthucvanchuyenEntity.Tenhieu = Tenhieu;
					
					_PhuongthucvanchuyenEntity.Tenrutgon = Tenrutgon;
					
					_PhuongthucvanchuyenEntity.Ngaytao = Ngaytao;
					
					_PhuongthucvanchuyenEntity.Nguoitao = Nguoitao;
					
					_PhuongthucvanchuyenEntity.Ngaysua = Ngaysua;
					
					_PhuongthucvanchuyenEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_PhuongthucvanchuyenEntity, true);
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
				PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity(Mahieu);
				if (adapter.FetchEntity(_PhuongthucvanchuyenEntity))
				{
					adapter.DeleteEntity(_PhuongthucvanchuyenEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhuongthucvanchuyenEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucvanchuyenEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhieu(System.String Tenhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucvanchuyenEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucvanchuyenEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucvanchuyenEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucvanchuyenEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucvanchuyenEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucvanchuyenEntity", filter);
			}
			return toReturn;
		}		
			
		
		public PhuongthucvanchuyenEntity SelectOne(System.String Mahieu)
		{
			PhuongthucvanchuyenEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhuongthucvanchuyenEntity _PhuongthucvanchuyenEntity = new PhuongthucvanchuyenEntity(Mahieu);
				if (adapter.FetchEntity(_PhuongthucvanchuyenEntity))
				{
					toReturn = _PhuongthucvanchuyenEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection( new PhuongthucvanchuyenEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucvanchuyenCollection, null, 0, null);
			}
			return _PhuongthucvanchuyenCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucvanchuyenCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucvanchuyenCollection, filter, 0, null);
			}
			return _PhuongthucvanchuyenCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucvanchuyenCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhieu(System.String Tenhieu)
		{
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucvanchuyenCollection, filter, 0, null);
			}
			return _PhuongthucvanchuyenCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhieuRDT(System.String Tenhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucvanchuyenCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucvanchuyenCollection, filter, 0, null);
			}
			return _PhuongthucvanchuyenCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucvanchuyenCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucvanchuyenCollection, filter, 0, null);
			}
			return _PhuongthucvanchuyenCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucvanchuyenCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucvanchuyenCollection, filter, 0, null);
			}
			return _PhuongthucvanchuyenCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucvanchuyenCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucvanchuyenCollection, filter, 0, null);
			}
			return _PhuongthucvanchuyenCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucvanchuyenCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucvanchuyenCollection, filter, 0, null);
			}
			return _PhuongthucvanchuyenCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucvanchuyenCollection = new EntityCollection(new PhuongthucvanchuyenEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucvanchuyenFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucvanchuyenCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
