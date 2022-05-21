


/*
'===============================================================================
'  GD.FM.BL.CacbuoclogisticManagerBase
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
	public class CacbuoclogisticManagerBase
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
		public CacbuoclogisticManagerBase()
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
		public DataRow Convert(CacbuoclogisticEntity _CacbuoclogisticEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_CacbuoclogisticEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenhieu]=_CacbuoclogisticEntity.Tenhieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_CacbuoclogisticEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_CacbuoclogisticEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_CacbuoclogisticEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_CacbuoclogisticEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_CacbuoclogisticEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public CacbuoclogisticEntity Convert(DataRow r)
		{	
			
			CacbuoclogisticEntity _CacbuoclogisticEntity=new CacbuoclogisticEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_CacbuoclogisticEntity.Tenhieu= r[Field_Tenhieu].ToString();						
			}
			catch { }
			
			try
			{
				_CacbuoclogisticEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_CacbuoclogisticEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_CacbuoclogisticEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_CacbuoclogisticEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_CacbuoclogisticEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _CacbuoclogisticEntity;
		}			
		
		public CacbuoclogisticEntity Convert_Entity(CacbuoclogisticEntity _CacbuoclogisticEntity,CacbuoclogisticEntity _CacbuoclogisticEntity_XML)
		{	
			
			
			_CacbuoclogisticEntity.Mahieu= _CacbuoclogisticEntity_XML.Mahieu;
			
			_CacbuoclogisticEntity.Tenhieu= _CacbuoclogisticEntity_XML.Tenhieu;
			
			_CacbuoclogisticEntity.Tenrutgon= _CacbuoclogisticEntity_XML.Tenrutgon;
			
			_CacbuoclogisticEntity.Ngaytao= _CacbuoclogisticEntity_XML.Ngaytao;
			
			_CacbuoclogisticEntity.Nguoitao= _CacbuoclogisticEntity_XML.Nguoitao;
			
			_CacbuoclogisticEntity.Ngaysua= _CacbuoclogisticEntity_XML.Ngaysua;
			
			_CacbuoclogisticEntity.Nguoisua= _CacbuoclogisticEntity_XML.Nguoisua;
									
				
			return _CacbuoclogisticEntity;
		}	
		
		public String InsertV2(CacbuoclogisticEntity _CacbuoclogisticEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new CacbuoclogisticManagerBase()).Insert(_CacbuoclogisticEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_CacbuoclogisticEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_CacbuoclogisticEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_CacbuoclogisticEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_CacbuoclogisticEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_CacbuoclogisticEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_CacbuoclogisticEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_CacbuoclogisticEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(CacbuoclogisticEntity _CacbuoclogisticEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new CacbuoclogisticManagerBase()).Update(_CacbuoclogisticEntity);
			r.SetField(Field_Mahieu,_CacbuoclogisticEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_CacbuoclogisticEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_CacbuoclogisticEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_CacbuoclogisticEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_CacbuoclogisticEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_CacbuoclogisticEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_CacbuoclogisticEntity.Nguoisua);
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

		public CacbuoclogisticEntity Insert(CacbuoclogisticEntity CacbuoclogisticEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(CacbuoclogisticEntity, true);
			}
			return CacbuoclogisticEntity;
		}

		public CacbuoclogisticEntity Insert(System.String  Mahieu, System.String  Tenhieu, System.String  Tenrutgon, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			CacbuoclogisticEntity _CacbuoclogisticEntity = new CacbuoclogisticEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CacbuoclogisticEntity.Mahieu = Mahieu;
				
				_CacbuoclogisticEntity.Tenhieu = Tenhieu;
				
				_CacbuoclogisticEntity.Tenrutgon = Tenrutgon;
				
				_CacbuoclogisticEntity.Ngaytao = Ngaytao;
				
				_CacbuoclogisticEntity.Nguoitao = Nguoitao;
				
				_CacbuoclogisticEntity.Ngaysua = Ngaysua;
				
				_CacbuoclogisticEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_CacbuoclogisticEntity, true);
			}
			return _CacbuoclogisticEntity;
		}

		public CacbuoclogisticEntity Insert(System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			CacbuoclogisticEntity _CacbuoclogisticEntity = new CacbuoclogisticEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_CacbuoclogisticEntity.Tenhieu = Tenhieu;
				
				_CacbuoclogisticEntity.Tenrutgon = Tenrutgon;
				
				_CacbuoclogisticEntity.Ngaytao = Ngaytao;
				
				_CacbuoclogisticEntity.Nguoitao = Nguoitao;
				
				_CacbuoclogisticEntity.Ngaysua = Ngaysua;
				
				_CacbuoclogisticEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_CacbuoclogisticEntity, true);
			}
			return _CacbuoclogisticEntity;
		}

		public bool Update(CacbuoclogisticEntity _CacbuoclogisticEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(CacbuoclogisticFields.Mahieu == _CacbuoclogisticEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CacbuoclogisticEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CacbuoclogisticEntity _CacbuoclogisticEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CacbuoclogisticEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CacbuoclogisticEntity _CacbuoclogisticEntity = new CacbuoclogisticEntity(Mahieu);
				if (adapter.FetchEntity(_CacbuoclogisticEntity))
				{
				
					
					
					_CacbuoclogisticEntity.Tenhieu = Tenhieu;
					
					_CacbuoclogisticEntity.Tenrutgon = Tenrutgon;
					
					_CacbuoclogisticEntity.Ngaytao = Ngaytao;
					
					_CacbuoclogisticEntity.Nguoitao = Nguoitao;
					
					_CacbuoclogisticEntity.Ngaysua = Ngaysua;
					
					_CacbuoclogisticEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_CacbuoclogisticEntity, true);
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
				CacbuoclogisticEntity _CacbuoclogisticEntity = new CacbuoclogisticEntity(Mahieu);
				if (adapter.FetchEntity(_CacbuoclogisticEntity))
				{
					adapter.DeleteEntity(_CacbuoclogisticEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CacbuoclogisticEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CacbuoclogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhieu(System.String Tenhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CacbuoclogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CacbuoclogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CacbuoclogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CacbuoclogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CacbuoclogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CacbuoclogisticEntity", filter);
			}
			return toReturn;
		}		
			
		
		public CacbuoclogisticEntity SelectOne(System.String Mahieu)
		{
			CacbuoclogisticEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CacbuoclogisticEntity _CacbuoclogisticEntity = new CacbuoclogisticEntity(Mahieu);
				if (adapter.FetchEntity(_CacbuoclogisticEntity))
				{
					toReturn = _CacbuoclogisticEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _CacbuoclogisticCollection = new EntityCollection( new CacbuoclogisticEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CacbuoclogisticCollection, null, 0, null);
			}
			return _CacbuoclogisticCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CacbuoclogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CacbuoclogisticCollection, filter, 0, null);
			}
			return _CacbuoclogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CacbuoclogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhieu(System.String Tenhieu)
		{
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CacbuoclogisticCollection, filter, 0, null);
			}
			return _CacbuoclogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhieuRDT(System.String Tenhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CacbuoclogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CacbuoclogisticCollection, filter, 0, null);
			}
			return _CacbuoclogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CacbuoclogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CacbuoclogisticCollection, filter, 0, null);
			}
			return _CacbuoclogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CacbuoclogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CacbuoclogisticCollection, filter, 0, null);
			}
			return _CacbuoclogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CacbuoclogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CacbuoclogisticCollection, filter, 0, null);
			}
			return _CacbuoclogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CacbuoclogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CacbuoclogisticCollection, filter, 0, null);
			}
			return _CacbuoclogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CacbuoclogisticCollection = new EntityCollection(new CacbuoclogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CacbuoclogisticFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CacbuoclogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
