


/*
'===============================================================================
'  GD.FM.BL.PhongbanManagerBase
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
	public class PhongbanManagerBase
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
		public PhongbanManagerBase()
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
		public DataRow Convert(PhongbanEntity _PhongbanEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_PhongbanEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenhieu]=_PhongbanEntity.Tenhieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_PhongbanEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_PhongbanEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_PhongbanEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_PhongbanEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_PhongbanEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public PhongbanEntity Convert(DataRow r)
		{	
			
			PhongbanEntity _PhongbanEntity=new PhongbanEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_PhongbanEntity.Tenhieu= r[Field_Tenhieu].ToString();						
			}
			catch { }
			
			try
			{
				_PhongbanEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_PhongbanEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_PhongbanEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_PhongbanEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_PhongbanEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _PhongbanEntity;
		}			
		
		public PhongbanEntity Convert_Entity(PhongbanEntity _PhongbanEntity,PhongbanEntity _PhongbanEntity_XML)
		{	
			
			
			_PhongbanEntity.Mahieu= _PhongbanEntity_XML.Mahieu;
			
			_PhongbanEntity.Tenhieu= _PhongbanEntity_XML.Tenhieu;
			
			_PhongbanEntity.Tenrutgon= _PhongbanEntity_XML.Tenrutgon;
			
			_PhongbanEntity.Ngaytao= _PhongbanEntity_XML.Ngaytao;
			
			_PhongbanEntity.Nguoitao= _PhongbanEntity_XML.Nguoitao;
			
			_PhongbanEntity.Ngaysua= _PhongbanEntity_XML.Ngaysua;
			
			_PhongbanEntity.Nguoisua= _PhongbanEntity_XML.Nguoisua;
									
				
			return _PhongbanEntity;
		}	
		
		public String InsertV2(PhongbanEntity _PhongbanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new PhongbanManagerBase()).Insert(_PhongbanEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_PhongbanEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_PhongbanEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_PhongbanEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhongbanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhongbanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhongbanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhongbanEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(PhongbanEntity _PhongbanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new PhongbanManagerBase()).Update(_PhongbanEntity);
			r.SetField(Field_Mahieu,_PhongbanEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_PhongbanEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_PhongbanEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhongbanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhongbanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhongbanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhongbanEntity.Nguoisua);
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

		public PhongbanEntity Insert(PhongbanEntity PhongbanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(PhongbanEntity, true);
			}
			return PhongbanEntity;
		}

		public PhongbanEntity Insert(System.String  Mahieu, System.String  Tenhieu, System.String  Tenrutgon, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			PhongbanEntity _PhongbanEntity = new PhongbanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhongbanEntity.Mahieu = Mahieu;
				
				_PhongbanEntity.Tenhieu = Tenhieu;
				
				_PhongbanEntity.Tenrutgon = Tenrutgon;
				
				_PhongbanEntity.Ngaytao = Ngaytao;
				
				_PhongbanEntity.Nguoitao = Nguoitao;
				
				_PhongbanEntity.Ngaysua = Ngaysua;
				
				_PhongbanEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_PhongbanEntity, true);
			}
			return _PhongbanEntity;
		}

		public PhongbanEntity Insert(System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			PhongbanEntity _PhongbanEntity = new PhongbanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_PhongbanEntity.Tenhieu = Tenhieu;
				
				_PhongbanEntity.Tenrutgon = Tenrutgon;
				
				_PhongbanEntity.Ngaytao = Ngaytao;
				
				_PhongbanEntity.Nguoitao = Nguoitao;
				
				_PhongbanEntity.Ngaysua = Ngaysua;
				
				_PhongbanEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_PhongbanEntity, true);
			}
			return _PhongbanEntity;
		}

		public bool Update(PhongbanEntity _PhongbanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(PhongbanFields.Mahieu == _PhongbanEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhongbanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhongbanEntity _PhongbanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhongbanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Tenhieu, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhongbanEntity _PhongbanEntity = new PhongbanEntity(Mahieu);
				if (adapter.FetchEntity(_PhongbanEntity))
				{
				
					
					
					_PhongbanEntity.Tenhieu = Tenhieu;
					
					_PhongbanEntity.Tenrutgon = Tenrutgon;
					
					_PhongbanEntity.Ngaytao = Ngaytao;
					
					_PhongbanEntity.Nguoitao = Nguoitao;
					
					_PhongbanEntity.Ngaysua = Ngaysua;
					
					_PhongbanEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_PhongbanEntity, true);
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
				PhongbanEntity _PhongbanEntity = new PhongbanEntity(Mahieu);
				if (adapter.FetchEntity(_PhongbanEntity))
				{
					adapter.DeleteEntity(_PhongbanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhongbanEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhongbanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhieu(System.String Tenhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhongbanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhongbanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhongbanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhongbanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhongbanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhongbanEntity", filter);
			}
			return toReturn;
		}		
			
		
		public PhongbanEntity SelectOne(System.String Mahieu)
		{
			PhongbanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhongbanEntity _PhongbanEntity = new PhongbanEntity(Mahieu);
				if (adapter.FetchEntity(_PhongbanEntity))
				{
					toReturn = _PhongbanEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _PhongbanCollection = new EntityCollection( new PhongbanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhongbanCollection, null, 0, null);
			}
			return _PhongbanCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhongbanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhongbanCollection, filter, 0, null);
			}
			return _PhongbanCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhongbanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhieu(System.String Tenhieu)
		{
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhongbanCollection, filter, 0, null);
			}
			return _PhongbanCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhieuRDT(System.String Tenhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhongbanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhongbanCollection, filter, 0, null);
			}
			return _PhongbanCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhongbanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhongbanCollection, filter, 0, null);
			}
			return _PhongbanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhongbanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhongbanCollection, filter, 0, null);
			}
			return _PhongbanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhongbanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhongbanCollection, filter, 0, null);
			}
			return _PhongbanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhongbanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhongbanCollection, filter, 0, null);
			}
			return _PhongbanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhongbanCollection = new EntityCollection(new PhongbanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhongbanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhongbanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
