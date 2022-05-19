


/*
'===============================================================================
'  GD.FM.BL.DanhmucungdungManagerBase
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
	public class DanhmucungdungManagerBase
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
		public DanhmucungdungManagerBase()
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
		public DataRow Convert(DanhmucungdungEntity _DanhmucungdungEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_DanhmucungdungEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenhieu]=_DanhmucungdungEntity.Tenhieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DanhmucungdungEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DanhmucungdungEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DanhmucungdungEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DanhmucungdungEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DanhmucungdungEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DanhmucungdungEntity Convert(DataRow r)
		{	
			
			DanhmucungdungEntity _DanhmucungdungEntity=new DanhmucungdungEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_DanhmucungdungEntity.Tenhieu= r[Field_Tenhieu].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucungdungEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucungdungEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmucungdungEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucungdungEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmucungdungEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DanhmucungdungEntity;
		}			
		
		public DanhmucungdungEntity Convert_Entity(DanhmucungdungEntity _DanhmucungdungEntity,DanhmucungdungEntity _DanhmucungdungEntity_XML)
		{	
			
			
			_DanhmucungdungEntity.Mahieu= _DanhmucungdungEntity_XML.Mahieu;
			
			_DanhmucungdungEntity.Tenhieu= _DanhmucungdungEntity_XML.Tenhieu;
			
			_DanhmucungdungEntity.Tenrutgon= _DanhmucungdungEntity_XML.Tenrutgon;
			
			_DanhmucungdungEntity.Ngaytao= _DanhmucungdungEntity_XML.Ngaytao;
			
			_DanhmucungdungEntity.Nguoitao= _DanhmucungdungEntity_XML.Nguoitao;
			
			_DanhmucungdungEntity.Ngaysua= _DanhmucungdungEntity_XML.Ngaysua;
			
			_DanhmucungdungEntity.Nguoisua= _DanhmucungdungEntity_XML.Nguoisua;
									
				
			return _DanhmucungdungEntity;
		}	
		
		public String InsertV2(DanhmucungdungEntity _DanhmucungdungEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DanhmucungdungManagerBase()).Insert(_DanhmucungdungEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_DanhmucungdungEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_DanhmucungdungEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DanhmucungdungEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmucungdungEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmucungdungEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmucungdungEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmucungdungEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DanhmucungdungEntity _DanhmucungdungEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DanhmucungdungManagerBase()).Update(_DanhmucungdungEntity);
			r.SetField(Field_Mahieu,_DanhmucungdungEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_DanhmucungdungEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DanhmucungdungEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmucungdungEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmucungdungEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmucungdungEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmucungdungEntity.Nguoisua);
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

		public DanhmucungdungEntity Insert(DanhmucungdungEntity DanhmucungdungEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DanhmucungdungEntity, true);
			}
			return DanhmucungdungEntity;
		}

		public DanhmucungdungEntity Insert(System.String  Mahieu, System.String  Tenhieu, System.String  Tenrutgon, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DanhmucungdungEntity _DanhmucungdungEntity = new DanhmucungdungEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DanhmucungdungEntity.Mahieu = Mahieu;
				
				_DanhmucungdungEntity.Tenhieu = Tenhieu;
				
				_DanhmucungdungEntity.Tenrutgon = Tenrutgon;
				
				_DanhmucungdungEntity.Ngaytao = Ngaytao;
				
				_DanhmucungdungEntity.Nguoitao = Nguoitao;
				
				_DanhmucungdungEntity.Ngaysua = Ngaysua;
				
				_DanhmucungdungEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DanhmucungdungEntity, true);
			}
			return _DanhmucungdungEntity;
		}

		public DanhmucungdungEntity Insert(System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DanhmucungdungEntity _DanhmucungdungEntity = new DanhmucungdungEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DanhmucungdungEntity.Tenhieu = Tenhieu;
				
				_DanhmucungdungEntity.Tenrutgon = Tenrutgon;
				
				_DanhmucungdungEntity.Ngaytao = Ngaytao;
				
				_DanhmucungdungEntity.Nguoitao = Nguoitao;
				
				_DanhmucungdungEntity.Ngaysua = Ngaysua;
				
				_DanhmucungdungEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DanhmucungdungEntity, true);
			}
			return _DanhmucungdungEntity;
		}

		public bool Update(DanhmucungdungEntity _DanhmucungdungEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DanhmucungdungFields.Mahieu == _DanhmucungdungEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DanhmucungdungEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DanhmucungdungEntity _DanhmucungdungEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DanhmucungdungEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmucungdungEntity _DanhmucungdungEntity = new DanhmucungdungEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucungdungEntity))
				{
				
					
					
					_DanhmucungdungEntity.Tenhieu = Tenhieu;
					
					_DanhmucungdungEntity.Tenrutgon = Tenrutgon;
					
					_DanhmucungdungEntity.Ngaytao = Ngaytao;
					
					_DanhmucungdungEntity.Nguoitao = Nguoitao;
					
					_DanhmucungdungEntity.Ngaysua = Ngaysua;
					
					_DanhmucungdungEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DanhmucungdungEntity, true);
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
				DanhmucungdungEntity _DanhmucungdungEntity = new DanhmucungdungEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucungdungEntity))
				{
					adapter.DeleteEntity(_DanhmucungdungEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DanhmucungdungEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucungdungEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhieu(System.String Tenhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucungdungEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucungdungEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucungdungEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucungdungEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucungdungEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucungdungEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DanhmucungdungEntity SelectOne(System.String Mahieu)
		{
			DanhmucungdungEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmucungdungEntity _DanhmucungdungEntity = new DanhmucungdungEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucungdungEntity))
				{
					toReturn = _DanhmucungdungEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DanhmucungdungCollection = new EntityCollection( new DanhmucungdungEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucungdungCollection, null, 0, null);
			}
			return _DanhmucungdungCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucungdungCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucungdungCollection, filter, 0, null);
			}
			return _DanhmucungdungCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucungdungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhieu(System.String Tenhieu)
		{
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucungdungCollection, filter, 0, null);
			}
			return _DanhmucungdungCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhieuRDT(System.String Tenhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucungdungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucungdungCollection, filter, 0, null);
			}
			return _DanhmucungdungCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucungdungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucungdungCollection, filter, 0, null);
			}
			return _DanhmucungdungCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucungdungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucungdungCollection, filter, 0, null);
			}
			return _DanhmucungdungCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucungdungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucungdungCollection, filter, 0, null);
			}
			return _DanhmucungdungCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucungdungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucungdungCollection, filter, 0, null);
			}
			return _DanhmucungdungCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucungdungCollection = new EntityCollection(new DanhmucungdungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucungdungFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucungdungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
