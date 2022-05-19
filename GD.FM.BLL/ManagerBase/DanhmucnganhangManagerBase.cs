


/*
'===============================================================================
'  GD.FM.BL.DanhmucnganhangManagerBase
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
	public class DanhmucnganhangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mahieu="Mahieu";				
		
		public const String Field_AccountHolder="AccountHolder";				
		
		public const String Field_Bank="Bank";				
		
		public const String Field_Address="Address";				
		
		public const String Field_Accountnumber="Accountnumber";				
		
		public const String Field_Swift="Swift";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DanhmucnganhangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mahieu,typeof(System.String));
			
			dt.Columns.Add(Field_AccountHolder,typeof(System.String));
			
			dt.Columns.Add(Field_Bank,typeof(System.String));
			
			dt.Columns.Add(Field_Address,typeof(System.String));
			
			dt.Columns.Add(Field_Accountnumber,typeof(System.String));
			
			dt.Columns.Add(Field_Swift,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DanhmucnganhangEntity _DanhmucnganhangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_DanhmucnganhangEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_AccountHolder]=_DanhmucnganhangEntity.AccountHolder;
			}
			catch { }
			
			try
			{
				r[Field_Bank]=_DanhmucnganhangEntity.Bank;
			}
			catch { }
			
			try
			{
				r[Field_Address]=_DanhmucnganhangEntity.Address;
			}
			catch { }
			
			try
			{
				r[Field_Accountnumber]=_DanhmucnganhangEntity.Accountnumber;
			}
			catch { }
			
			try
			{
				r[Field_Swift]=_DanhmucnganhangEntity.Swift;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DanhmucnganhangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DanhmucnganhangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DanhmucnganhangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DanhmucnganhangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DanhmucnganhangEntity Convert(DataRow r)
		{	
			
			DanhmucnganhangEntity _DanhmucnganhangEntity=new DanhmucnganhangEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_DanhmucnganhangEntity.AccountHolder= r[Field_AccountHolder].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucnganhangEntity.Bank= r[Field_Bank].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucnganhangEntity.Address= r[Field_Address].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucnganhangEntity.Accountnumber= r[Field_Accountnumber].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucnganhangEntity.Swift= r[Field_Swift].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucnganhangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmucnganhangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmucnganhangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmucnganhangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DanhmucnganhangEntity;
		}			
		
		public DanhmucnganhangEntity Convert_Entity(DanhmucnganhangEntity _DanhmucnganhangEntity,DanhmucnganhangEntity _DanhmucnganhangEntity_XML)
		{	
			
			
			_DanhmucnganhangEntity.Mahieu= _DanhmucnganhangEntity_XML.Mahieu;
			
			_DanhmucnganhangEntity.AccountHolder= _DanhmucnganhangEntity_XML.AccountHolder;
			
			_DanhmucnganhangEntity.Bank= _DanhmucnganhangEntity_XML.Bank;
			
			_DanhmucnganhangEntity.Address= _DanhmucnganhangEntity_XML.Address;
			
			_DanhmucnganhangEntity.Accountnumber= _DanhmucnganhangEntity_XML.Accountnumber;
			
			_DanhmucnganhangEntity.Swift= _DanhmucnganhangEntity_XML.Swift;
			
			_DanhmucnganhangEntity.Ngaytao= _DanhmucnganhangEntity_XML.Ngaytao;
			
			_DanhmucnganhangEntity.Nguoitao= _DanhmucnganhangEntity_XML.Nguoitao;
			
			_DanhmucnganhangEntity.Ngaysua= _DanhmucnganhangEntity_XML.Ngaysua;
			
			_DanhmucnganhangEntity.Nguoisua= _DanhmucnganhangEntity_XML.Nguoisua;
									
				
			return _DanhmucnganhangEntity;
		}	
		
		public String InsertV2(DanhmucnganhangEntity _DanhmucnganhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DanhmucnganhangManagerBase()).Insert(_DanhmucnganhangEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_DanhmucnganhangEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_AccountHolder,_DanhmucnganhangEntity.AccountHolder);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Bank,_DanhmucnganhangEntity.Bank);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Address,_DanhmucnganhangEntity.Address);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Accountnumber,_DanhmucnganhangEntity.Accountnumber);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Swift,_DanhmucnganhangEntity.Swift);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmucnganhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmucnganhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmucnganhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmucnganhangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DanhmucnganhangEntity _DanhmucnganhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DanhmucnganhangManagerBase()).Update(_DanhmucnganhangEntity);
			r.SetField(Field_Mahieu,_DanhmucnganhangEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_AccountHolder,_DanhmucnganhangEntity.AccountHolder);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Bank,_DanhmucnganhangEntity.Bank);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Address,_DanhmucnganhangEntity.Address);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Accountnumber,_DanhmucnganhangEntity.Accountnumber);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Swift,_DanhmucnganhangEntity.Swift);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmucnganhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmucnganhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmucnganhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmucnganhangEntity.Nguoisua);
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

		public DanhmucnganhangEntity Insert(DanhmucnganhangEntity DanhmucnganhangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DanhmucnganhangEntity, true);
			}
			return DanhmucnganhangEntity;
		}

		public DanhmucnganhangEntity Insert(System.String  Mahieu, System.String  AccountHolder, System.String  Bank, System.String  Address, System.String  Accountnumber, System.String  Swift, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DanhmucnganhangEntity.Mahieu = Mahieu;
				
				_DanhmucnganhangEntity.AccountHolder = AccountHolder;
				
				_DanhmucnganhangEntity.Bank = Bank;
				
				_DanhmucnganhangEntity.Address = Address;
				
				_DanhmucnganhangEntity.Accountnumber = Accountnumber;
				
				_DanhmucnganhangEntity.Swift = Swift;
				
				_DanhmucnganhangEntity.Ngaytao = Ngaytao;
				
				_DanhmucnganhangEntity.Nguoitao = Nguoitao;
				
				_DanhmucnganhangEntity.Ngaysua = Ngaysua;
				
				_DanhmucnganhangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DanhmucnganhangEntity, true);
			}
			return _DanhmucnganhangEntity;
		}

		public DanhmucnganhangEntity Insert(System.String AccountHolder, System.String Bank, System.String Address, System.String Accountnumber, System.String Swift, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DanhmucnganhangEntity.AccountHolder = AccountHolder;
				
				_DanhmucnganhangEntity.Bank = Bank;
				
				_DanhmucnganhangEntity.Address = Address;
				
				_DanhmucnganhangEntity.Accountnumber = Accountnumber;
				
				_DanhmucnganhangEntity.Swift = Swift;
				
				_DanhmucnganhangEntity.Ngaytao = Ngaytao;
				
				_DanhmucnganhangEntity.Nguoitao = Nguoitao;
				
				_DanhmucnganhangEntity.Ngaysua = Ngaysua;
				
				_DanhmucnganhangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DanhmucnganhangEntity, true);
			}
			return _DanhmucnganhangEntity;
		}

		public bool Update(DanhmucnganhangEntity _DanhmucnganhangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DanhmucnganhangFields.Mahieu == _DanhmucnganhangEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DanhmucnganhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DanhmucnganhangEntity _DanhmucnganhangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DanhmucnganhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String AccountHolder, System.String Bank, System.String Address, System.String Accountnumber, System.String Swift, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucnganhangEntity))
				{
				
					
					
					_DanhmucnganhangEntity.AccountHolder = AccountHolder;
					
					_DanhmucnganhangEntity.Bank = Bank;
					
					_DanhmucnganhangEntity.Address = Address;
					
					_DanhmucnganhangEntity.Accountnumber = Accountnumber;
					
					_DanhmucnganhangEntity.Swift = Swift;
					
					_DanhmucnganhangEntity.Ngaytao = Ngaytao;
					
					_DanhmucnganhangEntity.Nguoitao = Nguoitao;
					
					_DanhmucnganhangEntity.Ngaysua = Ngaysua;
					
					_DanhmucnganhangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DanhmucnganhangEntity, true);
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
				DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucnganhangEntity))
				{
					adapter.DeleteEntity(_DanhmucnganhangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByAccountHolder(System.String AccountHolder)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.AccountHolder == AccountHolder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByBank(System.String Bank)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Bank == Bank);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByAddress(System.String Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByAccountnumber(System.String Accountnumber)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Accountnumber == Accountnumber);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySwift(System.String Swift)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Swift == Swift);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmucnganhangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DanhmucnganhangEntity SelectOne(System.String Mahieu)
		{
			DanhmucnganhangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmucnganhangEntity _DanhmucnganhangEntity = new DanhmucnganhangEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmucnganhangEntity))
				{
					toReturn = _DanhmucnganhangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection( new DanhmucnganhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, null, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByAccountHolder(System.String AccountHolder)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.AccountHolder == AccountHolder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByAccountHolderRDT(System.String AccountHolder)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.AccountHolder == AccountHolder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByBank(System.String Bank)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Bank == Bank);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByBankRDT(System.String Bank)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Bank == Bank);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByAddress(System.String Address)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByAddressRDT(System.String Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByAccountnumber(System.String Accountnumber)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Accountnumber == Accountnumber);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByAccountnumberRDT(System.String Accountnumber)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Accountnumber == Accountnumber);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySwift(System.String Swift)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Swift == Swift);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySwiftRDT(System.String Swift)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Swift == Swift);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmucnganhangCollection, filter, 0, null);
			}
			return _DanhmucnganhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmucnganhangCollection = new EntityCollection(new DanhmucnganhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmucnganhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmucnganhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
