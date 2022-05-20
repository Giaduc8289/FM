


/*
'===============================================================================
'  GD.FM.BL.HopdongbanhangManagerBase
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
	public class HopdongbanhangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Sohopdong="Sohopdong";				
		
		public const String Field_Ngayhopdong="Ngayhopdong";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Macangden="Macangden";				
		
		public const String Field_Tencangden="Tencangden";				
		
		public const String Field_Thanhtienvnd="Thanhtienvnd";				
		
		public const String Field_Thanhtienusd="Thanhtienusd";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HopdongbanhangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Sohopdong,typeof(System.String));
			
			dt.Columns.Add(Field_Ngayhopdong,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Macangden,typeof(System.String));
			
			dt.Columns.Add(Field_Tencangden,typeof(System.String));
			
			dt.Columns.Add(Field_Thanhtienvnd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thanhtienusd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(HopdongbanhangEntity _HopdongbanhangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Sohopdong]=_HopdongbanhangEntity.Sohopdong;
			}
			catch { }
			
			try
			{
				r[Field_Ngayhopdong]=_HopdongbanhangEntity.Ngayhopdong;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_HopdongbanhangEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_HopdongbanhangEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Macangden]=_HopdongbanhangEntity.Macangden;
			}
			catch { }
			
			try
			{
				r[Field_Tencangden]=_HopdongbanhangEntity.Tencangden;
			}
			catch { }
			
			try
			{
				r[Field_Thanhtienvnd]=_HopdongbanhangEntity.Thanhtienvnd;
			}
			catch { }
			
			try
			{
				r[Field_Thanhtienusd]=_HopdongbanhangEntity.Thanhtienusd;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_HopdongbanhangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_HopdongbanhangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_HopdongbanhangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_HopdongbanhangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public HopdongbanhangEntity Convert(DataRow r)
		{	
			
			HopdongbanhangEntity _HopdongbanhangEntity=new HopdongbanhangEntity(r[Field_Sohopdong].ToString());					
						
			
			
			try
			{
				_HopdongbanhangEntity.Ngayhopdong= System.DateTime.Parse(r[Field_Ngayhopdong].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Macangden= r[Field_Macangden].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Tencangden= r[Field_Tencangden].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Thanhtienvnd= System.Decimal.Parse(r[Field_Thanhtienvnd].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Thanhtienusd= System.Decimal.Parse(r[Field_Thanhtienusd].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _HopdongbanhangEntity;
		}			
		
		public HopdongbanhangEntity Convert_Entity(HopdongbanhangEntity _HopdongbanhangEntity,HopdongbanhangEntity _HopdongbanhangEntity_XML)
		{	
			
			
			_HopdongbanhangEntity.Sohopdong= _HopdongbanhangEntity_XML.Sohopdong;
			
			_HopdongbanhangEntity.Ngayhopdong= _HopdongbanhangEntity_XML.Ngayhopdong;
			
			_HopdongbanhangEntity.Makhach= _HopdongbanhangEntity_XML.Makhach;
			
			_HopdongbanhangEntity.Tenkhach= _HopdongbanhangEntity_XML.Tenkhach;
			
			_HopdongbanhangEntity.Macangden= _HopdongbanhangEntity_XML.Macangden;
			
			_HopdongbanhangEntity.Tencangden= _HopdongbanhangEntity_XML.Tencangden;
			
			_HopdongbanhangEntity.Thanhtienvnd= _HopdongbanhangEntity_XML.Thanhtienvnd;
			
			_HopdongbanhangEntity.Thanhtienusd= _HopdongbanhangEntity_XML.Thanhtienusd;
			
			_HopdongbanhangEntity.Ngaytao= _HopdongbanhangEntity_XML.Ngaytao;
			
			_HopdongbanhangEntity.Nguoitao= _HopdongbanhangEntity_XML.Nguoitao;
			
			_HopdongbanhangEntity.Ngaysua= _HopdongbanhangEntity_XML.Ngaysua;
			
			_HopdongbanhangEntity.Nguoisua= _HopdongbanhangEntity_XML.Nguoisua;
									
				
			return _HopdongbanhangEntity;
		}	
		
		public String InsertV2(HopdongbanhangEntity _HopdongbanhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new HopdongbanhangManagerBase()).Insert(_HopdongbanhangEntity).Sohopdong.ToString();
			
			
			try
			{
				r.SetField(Field_Sohopdong,_HopdongbanhangEntity.Sohopdong);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngayhopdong,_HopdongbanhangEntity.Ngayhopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_HopdongbanhangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_HopdongbanhangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macangden,_HopdongbanhangEntity.Macangden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencangden,_HopdongbanhangEntity.Tencangden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienvnd,_HopdongbanhangEntity.Thanhtienvnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienusd,_HopdongbanhangEntity.Thanhtienusd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_HopdongbanhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_HopdongbanhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_HopdongbanhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_HopdongbanhangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(HopdongbanhangEntity _HopdongbanhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new HopdongbanhangManagerBase()).Update(_HopdongbanhangEntity);
			r.SetField(Field_Sohopdong,_HopdongbanhangEntity.Sohopdong);
									
			
			
			
			try
			{
				r.SetField(Field_Ngayhopdong,_HopdongbanhangEntity.Ngayhopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_HopdongbanhangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_HopdongbanhangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macangden,_HopdongbanhangEntity.Macangden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencangden,_HopdongbanhangEntity.Tencangden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienvnd,_HopdongbanhangEntity.Thanhtienvnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienusd,_HopdongbanhangEntity.Thanhtienusd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_HopdongbanhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_HopdongbanhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_HopdongbanhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_HopdongbanhangEntity.Nguoisua);
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

		public HopdongbanhangEntity Insert(HopdongbanhangEntity HopdongbanhangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(HopdongbanhangEntity, true);
			}
			return HopdongbanhangEntity;
		}

		public HopdongbanhangEntity Insert(System.String  Sohopdong, System.DateTime  Ngayhopdong, System.String  Makhach, System.String  Tenkhach, System.String  Macangden, System.String  Tencangden, System.Decimal  Thanhtienvnd, System.Decimal  Thanhtienusd, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HopdongbanhangEntity.Sohopdong = Sohopdong;
				
				_HopdongbanhangEntity.Ngayhopdong = Ngayhopdong;
				
				_HopdongbanhangEntity.Makhach = Makhach;
				
				_HopdongbanhangEntity.Tenkhach = Tenkhach;
				
				_HopdongbanhangEntity.Macangden = Macangden;
				
				_HopdongbanhangEntity.Tencangden = Tencangden;
				
				_HopdongbanhangEntity.Thanhtienvnd = Thanhtienvnd;
				
				_HopdongbanhangEntity.Thanhtienusd = Thanhtienusd;
				
				_HopdongbanhangEntity.Ngaytao = Ngaytao;
				
				_HopdongbanhangEntity.Nguoitao = Nguoitao;
				
				_HopdongbanhangEntity.Ngaysua = Ngaysua;
				
				_HopdongbanhangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_HopdongbanhangEntity, true);
			}
			return _HopdongbanhangEntity;
		}

		public HopdongbanhangEntity Insert(System.DateTime Ngayhopdong, System.String Makhach, System.String Tenkhach, System.String Macangden, System.String Tencangden, System.Decimal Thanhtienvnd, System.Decimal Thanhtienusd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_HopdongbanhangEntity.Ngayhopdong = Ngayhopdong;
				
				_HopdongbanhangEntity.Makhach = Makhach;
				
				_HopdongbanhangEntity.Tenkhach = Tenkhach;
				
				_HopdongbanhangEntity.Macangden = Macangden;
				
				_HopdongbanhangEntity.Tencangden = Tencangden;
				
				_HopdongbanhangEntity.Thanhtienvnd = Thanhtienvnd;
				
				_HopdongbanhangEntity.Thanhtienusd = Thanhtienusd;
				
				_HopdongbanhangEntity.Ngaytao = Ngaytao;
				
				_HopdongbanhangEntity.Nguoitao = Nguoitao;
				
				_HopdongbanhangEntity.Ngaysua = Ngaysua;
				
				_HopdongbanhangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_HopdongbanhangEntity, true);
			}
			return _HopdongbanhangEntity;
		}

		public bool Update(HopdongbanhangEntity _HopdongbanhangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(HopdongbanhangFields.Sohopdong == _HopdongbanhangEntity.Sohopdong);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HopdongbanhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HopdongbanhangEntity _HopdongbanhangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HopdongbanhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Sohopdong, System.DateTime Ngayhopdong, System.String Makhach, System.String Tenkhach, System.String Macangden, System.String Tencangden, System.Decimal Thanhtienvnd, System.Decimal Thanhtienusd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity(Sohopdong);
				if (adapter.FetchEntity(_HopdongbanhangEntity))
				{
				
					
					
					_HopdongbanhangEntity.Ngayhopdong = Ngayhopdong;
					
					_HopdongbanhangEntity.Makhach = Makhach;
					
					_HopdongbanhangEntity.Tenkhach = Tenkhach;
					
					_HopdongbanhangEntity.Macangden = Macangden;
					
					_HopdongbanhangEntity.Tencangden = Tencangden;
					
					_HopdongbanhangEntity.Thanhtienvnd = Thanhtienvnd;
					
					_HopdongbanhangEntity.Thanhtienusd = Thanhtienusd;
					
					_HopdongbanhangEntity.Ngaytao = Ngaytao;
					
					_HopdongbanhangEntity.Nguoitao = Nguoitao;
					
					_HopdongbanhangEntity.Ngaysua = Ngaysua;
					
					_HopdongbanhangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_HopdongbanhangEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Sohopdong)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity(Sohopdong);
				if (adapter.FetchEntity(_HopdongbanhangEntity))
				{
					adapter.DeleteEntity(_HopdongbanhangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", null);
			}
		}
		
		
		
		public int DeleteBySohopdong(System.String Sohopdong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayhopdong(System.DateTime Ngayhopdong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacangden(System.String Macangden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Macangden == Macangden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencangden(System.String Tencangden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Tencangden == Tencangden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThanhtienvnd(System.Decimal Thanhtienvnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThanhtienusd(System.Decimal Thanhtienusd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public HopdongbanhangEntity SelectOne(System.String Sohopdong)
		{
			HopdongbanhangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HopdongbanhangEntity _HopdongbanhangEntity = new HopdongbanhangEntity(Sohopdong);
				if (adapter.FetchEntity(_HopdongbanhangEntity))
				{
					toReturn = _HopdongbanhangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection( new HopdongbanhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, null, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectBySohopdong(System.String Sohopdong)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySohopdongRDT(System.String Sohopdong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayhopdong(System.DateTime Ngayhopdong)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayhopdongRDT(System.DateTime Ngayhopdong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacangden(System.String Macangden)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Macangden == Macangden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMacangdenRDT(System.String Macangden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Macangden == Macangden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencangden(System.String Tencangden)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Tencangden == Tencangden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTencangdenRDT(System.String Tencangden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Tencangden == Tencangden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThanhtienvnd(System.Decimal Thanhtienvnd)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByThanhtienvndRDT(System.Decimal Thanhtienvnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThanhtienusd(System.Decimal Thanhtienusd)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByThanhtienusdRDT(System.Decimal Thanhtienusd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangCollection, filter, 0, null);
			}
			return _HopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangCollection = new EntityCollection(new HopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
