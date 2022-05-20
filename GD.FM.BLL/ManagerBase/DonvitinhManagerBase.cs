


/*
'===============================================================================
'  GD.FM.BL.DonvitinhManagerBase
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
	public class DonvitinhManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mahieu="Mahieu";				
		
		public const String Field_Tenhieu="Tenhieu";				
		
		public const String Field_Tentienganh="Tentienganh";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonvitinhManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mahieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenhieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tentienganh,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DonvitinhEntity _DonvitinhEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_DonvitinhEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenhieu]=_DonvitinhEntity.Tenhieu;
			}
			catch { }
			
			try
			{
				r[Field_Tentienganh]=_DonvitinhEntity.Tentienganh;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DonvitinhEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DonvitinhEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DonvitinhEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DonvitinhEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DonvitinhEntity Convert(DataRow r)
		{	
			
			DonvitinhEntity _DonvitinhEntity=new DonvitinhEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_DonvitinhEntity.Tenhieu= r[Field_Tenhieu].ToString();						
			}
			catch { }
			
			try
			{
				_DonvitinhEntity.Tentienganh= r[Field_Tentienganh].ToString();						
			}
			catch { }
			
			try
			{
				_DonvitinhEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DonvitinhEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DonvitinhEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DonvitinhEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DonvitinhEntity;
		}			
		
		public DonvitinhEntity Convert_Entity(DonvitinhEntity _DonvitinhEntity,DonvitinhEntity _DonvitinhEntity_XML)
		{	
			
			
			_DonvitinhEntity.Mahieu= _DonvitinhEntity_XML.Mahieu;
			
			_DonvitinhEntity.Tenhieu= _DonvitinhEntity_XML.Tenhieu;
			
			_DonvitinhEntity.Tentienganh= _DonvitinhEntity_XML.Tentienganh;
			
			_DonvitinhEntity.Ngaytao= _DonvitinhEntity_XML.Ngaytao;
			
			_DonvitinhEntity.Nguoitao= _DonvitinhEntity_XML.Nguoitao;
			
			_DonvitinhEntity.Ngaysua= _DonvitinhEntity_XML.Ngaysua;
			
			_DonvitinhEntity.Nguoisua= _DonvitinhEntity_XML.Nguoisua;
									
				
			return _DonvitinhEntity;
		}	
		
		public String InsertV2(DonvitinhEntity _DonvitinhEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DonvitinhManagerBase()).Insert(_DonvitinhEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_DonvitinhEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_DonvitinhEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentienganh,_DonvitinhEntity.Tentienganh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DonvitinhEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DonvitinhEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DonvitinhEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DonvitinhEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DonvitinhEntity _DonvitinhEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DonvitinhManagerBase()).Update(_DonvitinhEntity);
			r.SetField(Field_Mahieu,_DonvitinhEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_DonvitinhEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentienganh,_DonvitinhEntity.Tentienganh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DonvitinhEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DonvitinhEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DonvitinhEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DonvitinhEntity.Nguoisua);
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

		public DonvitinhEntity Insert(DonvitinhEntity DonvitinhEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DonvitinhEntity, true);
			}
			return DonvitinhEntity;
		}

		public DonvitinhEntity Insert(System.String  Mahieu, System.String  Tenhieu, System.String  Tentienganh, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DonvitinhEntity _DonvitinhEntity = new DonvitinhEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DonvitinhEntity.Mahieu = Mahieu;
				
				_DonvitinhEntity.Tenhieu = Tenhieu;
				
				_DonvitinhEntity.Tentienganh = Tentienganh;
				
				_DonvitinhEntity.Ngaytao = Ngaytao;
				
				_DonvitinhEntity.Nguoitao = Nguoitao;
				
				_DonvitinhEntity.Ngaysua = Ngaysua;
				
				_DonvitinhEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DonvitinhEntity, true);
			}
			return _DonvitinhEntity;
		}

		public DonvitinhEntity Insert(System.String Tenhieu, System.String Tentienganh, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DonvitinhEntity _DonvitinhEntity = new DonvitinhEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DonvitinhEntity.Tenhieu = Tenhieu;
				
				_DonvitinhEntity.Tentienganh = Tentienganh;
				
				_DonvitinhEntity.Ngaytao = Ngaytao;
				
				_DonvitinhEntity.Nguoitao = Nguoitao;
				
				_DonvitinhEntity.Ngaysua = Ngaysua;
				
				_DonvitinhEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DonvitinhEntity, true);
			}
			return _DonvitinhEntity;
		}

		public bool Update(DonvitinhEntity _DonvitinhEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DonvitinhFields.Mahieu == _DonvitinhEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DonvitinhEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DonvitinhEntity _DonvitinhEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DonvitinhEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Tenhieu, System.String Tentienganh, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DonvitinhEntity _DonvitinhEntity = new DonvitinhEntity(Mahieu);
				if (adapter.FetchEntity(_DonvitinhEntity))
				{
				
					
					
					_DonvitinhEntity.Tenhieu = Tenhieu;
					
					_DonvitinhEntity.Tentienganh = Tentienganh;
					
					_DonvitinhEntity.Ngaytao = Ngaytao;
					
					_DonvitinhEntity.Nguoitao = Nguoitao;
					
					_DonvitinhEntity.Ngaysua = Ngaysua;
					
					_DonvitinhEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DonvitinhEntity, true);
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
				DonvitinhEntity _DonvitinhEntity = new DonvitinhEntity(Mahieu);
				if (adapter.FetchEntity(_DonvitinhEntity))
				{
					adapter.DeleteEntity(_DonvitinhEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DonvitinhEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonvitinhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhieu(System.String Tenhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonvitinhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTentienganh(System.String Tentienganh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Tentienganh == Tentienganh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonvitinhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonvitinhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonvitinhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonvitinhEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonvitinhEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DonvitinhEntity SelectOne(System.String Mahieu)
		{
			DonvitinhEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DonvitinhEntity _DonvitinhEntity = new DonvitinhEntity(Mahieu);
				if (adapter.FetchEntity(_DonvitinhEntity))
				{
					toReturn = _DonvitinhEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DonvitinhCollection = new EntityCollection( new DonvitinhEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonvitinhCollection, null, 0, null);
			}
			return _DonvitinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonvitinhCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonvitinhCollection, filter, 0, null);
			}
			return _DonvitinhCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonvitinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhieu(System.String Tenhieu)
		{
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonvitinhCollection, filter, 0, null);
			}
			return _DonvitinhCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhieuRDT(System.String Tenhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonvitinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTentienganh(System.String Tentienganh)
		{
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Tentienganh == Tentienganh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonvitinhCollection, filter, 0, null);
			}
			return _DonvitinhCollection;
		}
		// Return DataTable
		public DataTable SelectByTentienganhRDT(System.String Tentienganh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Tentienganh == Tentienganh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonvitinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonvitinhCollection, filter, 0, null);
			}
			return _DonvitinhCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonvitinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonvitinhCollection, filter, 0, null);
			}
			return _DonvitinhCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonvitinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonvitinhCollection, filter, 0, null);
			}
			return _DonvitinhCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonvitinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonvitinhCollection, filter, 0, null);
			}
			return _DonvitinhCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonvitinhCollection = new EntityCollection(new DonvitinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonvitinhFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonvitinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
