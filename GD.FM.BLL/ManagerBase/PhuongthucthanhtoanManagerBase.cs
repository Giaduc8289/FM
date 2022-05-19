


/*
'===============================================================================
'  GD.FM.BL.PhuongthucthanhtoanManagerBase
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
	public class PhuongthucthanhtoanManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mahieu="Mahieu";				
		
		public const String Field_Tenhieu="Tenhieu";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
		public const String Field_Deposit="Deposit";				
		
		public const String Field_Pay="Pay";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhuongthucthanhtoanManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mahieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenhieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
			
			dt.Columns.Add(Field_Deposit,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Pay,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_PhuongthucthanhtoanEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenhieu]=_PhuongthucthanhtoanEntity.Tenhieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_PhuongthucthanhtoanEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Deposit]=_PhuongthucthanhtoanEntity.Deposit;
			}
			catch { }
			
			try
			{
				r[Field_Pay]=_PhuongthucthanhtoanEntity.Pay;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_PhuongthucthanhtoanEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_PhuongthucthanhtoanEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_PhuongthucthanhtoanEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_PhuongthucthanhtoanEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public PhuongthucthanhtoanEntity Convert(DataRow r)
		{	
			
			PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity=new PhuongthucthanhtoanEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_PhuongthucthanhtoanEntity.Tenhieu= r[Field_Tenhieu].ToString();						
			}
			catch { }
			
			try
			{
				_PhuongthucthanhtoanEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_PhuongthucthanhtoanEntity.Deposit= System.Decimal.Parse(r[Field_Deposit].ToString());						
			}
			catch { }
			
			try
			{
				_PhuongthucthanhtoanEntity.Pay= System.Decimal.Parse(r[Field_Pay].ToString());						
			}
			catch { }
			
			try
			{
				_PhuongthucthanhtoanEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_PhuongthucthanhtoanEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_PhuongthucthanhtoanEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_PhuongthucthanhtoanEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _PhuongthucthanhtoanEntity;
		}			
		
		public PhuongthucthanhtoanEntity Convert_Entity(PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity,PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity_XML)
		{	
			
			
			_PhuongthucthanhtoanEntity.Mahieu= _PhuongthucthanhtoanEntity_XML.Mahieu;
			
			_PhuongthucthanhtoanEntity.Tenhieu= _PhuongthucthanhtoanEntity_XML.Tenhieu;
			
			_PhuongthucthanhtoanEntity.Tenrutgon= _PhuongthucthanhtoanEntity_XML.Tenrutgon;
			
			_PhuongthucthanhtoanEntity.Deposit= _PhuongthucthanhtoanEntity_XML.Deposit;
			
			_PhuongthucthanhtoanEntity.Pay= _PhuongthucthanhtoanEntity_XML.Pay;
			
			_PhuongthucthanhtoanEntity.Ngaytao= _PhuongthucthanhtoanEntity_XML.Ngaytao;
			
			_PhuongthucthanhtoanEntity.Nguoitao= _PhuongthucthanhtoanEntity_XML.Nguoitao;
			
			_PhuongthucthanhtoanEntity.Ngaysua= _PhuongthucthanhtoanEntity_XML.Ngaysua;
			
			_PhuongthucthanhtoanEntity.Nguoisua= _PhuongthucthanhtoanEntity_XML.Nguoisua;
									
				
			return _PhuongthucthanhtoanEntity;
		}	
		
		public String InsertV2(PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new PhuongthucthanhtoanManagerBase()).Insert(_PhuongthucthanhtoanEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_PhuongthucthanhtoanEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_PhuongthucthanhtoanEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_PhuongthucthanhtoanEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Deposit,_PhuongthucthanhtoanEntity.Deposit);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pay,_PhuongthucthanhtoanEntity.Pay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhuongthucthanhtoanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhuongthucthanhtoanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhuongthucthanhtoanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhuongthucthanhtoanEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new PhuongthucthanhtoanManagerBase()).Update(_PhuongthucthanhtoanEntity);
			r.SetField(Field_Mahieu,_PhuongthucthanhtoanEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_PhuongthucthanhtoanEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_PhuongthucthanhtoanEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Deposit,_PhuongthucthanhtoanEntity.Deposit);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pay,_PhuongthucthanhtoanEntity.Pay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhuongthucthanhtoanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhuongthucthanhtoanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhuongthucthanhtoanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhuongthucthanhtoanEntity.Nguoisua);
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

		public PhuongthucthanhtoanEntity Insert(PhuongthucthanhtoanEntity PhuongthucthanhtoanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(PhuongthucthanhtoanEntity, true);
			}
			return PhuongthucthanhtoanEntity;
		}

		public PhuongthucthanhtoanEntity Insert(System.String  Mahieu, System.String  Tenhieu, System.String  Tenrutgon, System.Decimal  Deposit, System.Decimal  Pay, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhuongthucthanhtoanEntity.Mahieu = Mahieu;
				
				_PhuongthucthanhtoanEntity.Tenhieu = Tenhieu;
				
				_PhuongthucthanhtoanEntity.Tenrutgon = Tenrutgon;
				
				_PhuongthucthanhtoanEntity.Deposit = Deposit;
				
				_PhuongthucthanhtoanEntity.Pay = Pay;
				
				_PhuongthucthanhtoanEntity.Ngaytao = Ngaytao;
				
				_PhuongthucthanhtoanEntity.Nguoitao = Nguoitao;
				
				_PhuongthucthanhtoanEntity.Ngaysua = Ngaysua;
				
				_PhuongthucthanhtoanEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_PhuongthucthanhtoanEntity, true);
			}
			return _PhuongthucthanhtoanEntity;
		}

		public PhuongthucthanhtoanEntity Insert(System.String Tenhieu, System.String Tenrutgon, System.Decimal Deposit, System.Decimal Pay, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_PhuongthucthanhtoanEntity.Tenhieu = Tenhieu;
				
				_PhuongthucthanhtoanEntity.Tenrutgon = Tenrutgon;
				
				_PhuongthucthanhtoanEntity.Deposit = Deposit;
				
				_PhuongthucthanhtoanEntity.Pay = Pay;
				
				_PhuongthucthanhtoanEntity.Ngaytao = Ngaytao;
				
				_PhuongthucthanhtoanEntity.Nguoitao = Nguoitao;
				
				_PhuongthucthanhtoanEntity.Ngaysua = Ngaysua;
				
				_PhuongthucthanhtoanEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_PhuongthucthanhtoanEntity, true);
			}
			return _PhuongthucthanhtoanEntity;
		}

		public bool Update(PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(PhuongthucthanhtoanFields.Mahieu == _PhuongthucthanhtoanEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhuongthucthanhtoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhuongthucthanhtoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Tenhieu, System.String Tenrutgon, System.Decimal Deposit, System.Decimal Pay, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity(Mahieu);
				if (adapter.FetchEntity(_PhuongthucthanhtoanEntity))
				{
				
					
					
					_PhuongthucthanhtoanEntity.Tenhieu = Tenhieu;
					
					_PhuongthucthanhtoanEntity.Tenrutgon = Tenrutgon;
					
					_PhuongthucthanhtoanEntity.Deposit = Deposit;
					
					_PhuongthucthanhtoanEntity.Pay = Pay;
					
					_PhuongthucthanhtoanEntity.Ngaytao = Ngaytao;
					
					_PhuongthucthanhtoanEntity.Nguoitao = Nguoitao;
					
					_PhuongthucthanhtoanEntity.Ngaysua = Ngaysua;
					
					_PhuongthucthanhtoanEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_PhuongthucthanhtoanEntity, true);
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
				PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity(Mahieu);
				if (adapter.FetchEntity(_PhuongthucthanhtoanEntity))
				{
					adapter.DeleteEntity(_PhuongthucthanhtoanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhieu(System.String Tenhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDeposit(System.Decimal Deposit)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Deposit == Deposit);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPay(System.Decimal Pay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Pay == Pay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongthucthanhtoanEntity", filter);
			}
			return toReturn;
		}		
			
		
		public PhuongthucthanhtoanEntity SelectOne(System.String Mahieu)
		{
			PhuongthucthanhtoanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhuongthucthanhtoanEntity _PhuongthucthanhtoanEntity = new PhuongthucthanhtoanEntity(Mahieu);
				if (adapter.FetchEntity(_PhuongthucthanhtoanEntity))
				{
					toReturn = _PhuongthucthanhtoanEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection( new PhuongthucthanhtoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, null, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhieu(System.String Tenhieu)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhieuRDT(System.String Tenhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDeposit(System.Decimal Deposit)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Deposit == Deposit);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByDepositRDT(System.Decimal Deposit)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Deposit == Deposit);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPay(System.Decimal Pay)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Pay == Pay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByPayRDT(System.Decimal Pay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Pay == Pay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongthucthanhtoanCollection, filter, 0, null);
			}
			return _PhuongthucthanhtoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongthucthanhtoanCollection = new EntityCollection(new PhuongthucthanhtoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongthucthanhtoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongthucthanhtoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
