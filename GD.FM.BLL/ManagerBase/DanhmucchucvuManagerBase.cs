


/*
'===============================================================================
'  GD.FM.BL.DanhmucchucvuManagerBase
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
	public class DanhmucchucvuManagerBase
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
		public DanhmucchucvuManagerBase()
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
		public DataRow Convert(DanhmucchucvuEntity _DanhmucchucvuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_DanhmucchucvuEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenhieu]=_DanhmucchucvuEntity.Tenhieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DanhmucchucvuEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DanhmucchucvuEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DanhmucchucvuEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DanhmucchucvuEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DanhmucchucvuEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DanhmucchucvuEntity Convert(DataRow r)
		{	
			
			DanhmucchucvuEntity _DanhmucchucvuEntity=new DanhmucchucvuEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_DanhmucchucvuEntity.Tenhieu= r[Field_Tenhieu].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucchucvuEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucchucvuEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmucchucvuEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucchucvuEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmucchucvuEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DanhmucchucvuEntity;
		}			
		
		public DanhmucchucvuEntity Convert_Entity(DanhmucchucvuEntity _DanhmucchucvuEntity,DanhmucchucvuEntity _DanhmucchucvuEntity_XML)
		{	
			
			
			_DanhmucchucvuEntity.Mahieu= _DanhmucchucvuEntity_XML.Mahieu;
			
			_DanhmucchucvuEntity.Tenhieu= _DanhmucchucvuEntity_XML.Tenhieu;
			
			_DanhmucchucvuEntity.Tenrutgon= _DanhmucchucvuEntity_XML.Tenrutgon;
			
			_DanhmucchucvuEntity.Ngaytao= _DanhmucchucvuEntity_XML.Ngaytao;
			
			_DanhmucchucvuEntity.Nguoitao= _DanhmucchucvuEntity_XML.Nguoitao;
			
			_DanhmucchucvuEntity.Ngaysua= _DanhmucchucvuEntity_XML.Ngaysua;
			
			_DanhmucchucvuEntity.Nguoisua= _DanhmucchucvuEntity_XML.Nguoisua;
									
				
			return _DanhmucchucvuEntity;
		}	
		
		public String InsertV2(DanhmucchucvuEntity _DanhmucchucvuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DanhmucchucvuManagerBase()).Insert(_DanhmucchucvuEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_DanhmucchucvuEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_DanhmucchucvuEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DanhmucchucvuEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmucchucvuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmucchucvuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmucchucvuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmucchucvuEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DanhmucchucvuEntity _DanhmucchucvuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DanhmucchucvuManagerBase()).Update(_DanhmucchucvuEntity);
			r.SetField(Field_Mahieu,_DanhmucchucvuEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_DanhmucchucvuEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DanhmucchucvuEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmucchucvuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmucchucvuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmucchucvuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmucchucvuEntity.Nguoisua);
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

		public DanhmucchucvuEntity Insert(DanhmucchucvuEntity DanhmucchucvuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DanhmucchucvuEntity, true);
			}
			return DanhmucchucvuEntity;
		}

		public DanhmucchucvuEntity Insert(System.String  Mahieu, System.String  Tenhieu, System.String  Tenrutgon, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DanhmucchucvuEntity _DanhmucchucvuEntity = new DanhmucchucvuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DanhmucchucvuEntity.Mahieu = Mahieu;
				
				_DanhmucchucvuEntity.Tenhieu = Tenhieu;
				
				_DanhmucchucvuEntity.Tenrutgon = Tenrutgon;
				
				_DanhmucchucvuEntity.Ngaytao = Ngaytao;
				
				_DanhmucchucvuEntity.Nguoitao = Nguoitao;
				
				_DanhmucchucvuEntity.Ngaysua = Ngaysua;
				
				_DanhmucchucvuEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DanhmucchucvuEntity, true);
			}
			return _DanhmucchucvuEntity;
		}

		public DanhmucchucvuEntity Insert(System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DanhmucchucvuEntity _DanhmucchucvuEntity = new DanhmucchucvuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DanhmucchucvuEntity.Tenhieu = Tenhieu;
				
				_DanhmucchucvuEntity.Tenrutgon = Tenrutgon;
				
				_DanhmucchucvuEntity.Ngaytao = Ngaytao;
				
				_DanhmucchucvuEntity.Nguoitao = Nguoitao;
				
				_DanhmucchucvuEntity.Ngaysua = Ngaysua;
				
				_DanhmucchucvuEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DanhmucchucvuEntity, true);
			}
			return _DanhmucchucvuEntity;
		}

		public bool Update(DanhmucchucvuEntity _DanhmucchucvuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DanhmucchucvuFields.Mahieu == _DanhmucchucvuEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DanhmucchucvuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DanhmucchucvuEntity _DanhmucchucvuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DanhmucchucvuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmucchucvuEntity _DanhmucchucvuEntity = new DanhmucchucvuEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucchucvuEntity))
				{
				
					
					
					_DanhmucchucvuEntity.Tenhieu = Tenhieu;
					
					_DanhmucchucvuEntity.Tenrutgon = Tenrutgon;
					
					_DanhmucchucvuEntity.Ngaytao = Ngaytao;
					
					_DanhmucchucvuEntity.Nguoitao = Nguoitao;
					
					_DanhmucchucvuEntity.Ngaysua = Ngaysua;
					
					_DanhmucchucvuEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DanhmucchucvuEntity, true);
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
				DanhmucchucvuEntity _DanhmucchucvuEntity = new DanhmucchucvuEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucchucvuEntity))
				{
					adapter.DeleteEntity(_DanhmucchucvuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DanhmucchucvuEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhieu(System.String Tenhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucchucvuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DanhmucchucvuEntity SelectOne(System.String Mahieu)
		{
			DanhmucchucvuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmucchucvuEntity _DanhmucchucvuEntity = new DanhmucchucvuEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucchucvuEntity))
				{
					toReturn = _DanhmucchucvuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DanhmucchucvuCollection = new EntityCollection( new DanhmucchucvuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucchucvuCollection, null, 0, null);
			}
			return _DanhmucchucvuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucchucvuCollection, filter, 0, null);
			}
			return _DanhmucchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhieu(System.String Tenhieu)
		{
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucchucvuCollection, filter, 0, null);
			}
			return _DanhmucchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhieuRDT(System.String Tenhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucchucvuCollection, filter, 0, null);
			}
			return _DanhmucchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucchucvuCollection, filter, 0, null);
			}
			return _DanhmucchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucchucvuCollection, filter, 0, null);
			}
			return _DanhmucchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucchucvuCollection, filter, 0, null);
			}
			return _DanhmucchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucchucvuCollection, filter, 0, null);
			}
			return _DanhmucchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucchucvuCollection = new EntityCollection(new DanhmucchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucchucvuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
