


/*
'===============================================================================
'  GD.FM.BL.HopdongbanhangchitietManagerBase
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
	public class HopdongbanhangchitietManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Sohopdong="Sohopdong";				
		
		public const String Field_Ngayhopdong="Ngayhopdong";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Macangden="Macangden";				
		
		public const String Field_Tencangden="Tencangden";				
		
		public const String Field_Mahangphiakhach="Mahangphiakhach";				
		
		public const String Field_Codefiller="Codefiller";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Dongiavnd="Dongiavnd";				
		
		public const String Field_Tygia="Tygia";				
		
		public const String Field_Dongiausd="Dongiausd";				
		
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
		public HopdongbanhangchitietManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Sohopdong,typeof(System.String));
			
			dt.Columns.Add(Field_Ngayhopdong,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Macangden,typeof(System.String));
			
			dt.Columns.Add(Field_Tencangden,typeof(System.String));
			
			dt.Columns.Add(Field_Mahangphiakhach,typeof(System.String));
			
			dt.Columns.Add(Field_Codefiller,typeof(System.String));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dongiavnd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tygia,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dongiausd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thanhtienvnd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thanhtienusd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(HopdongbanhangchitietEntity _HopdongbanhangchitietEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_HopdongbanhangchitietEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Sohopdong]=_HopdongbanhangchitietEntity.Sohopdong;
			}
			catch { }
			
			try
			{
				r[Field_Ngayhopdong]=_HopdongbanhangchitietEntity.Ngayhopdong;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_HopdongbanhangchitietEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_HopdongbanhangchitietEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Macangden]=_HopdongbanhangchitietEntity.Macangden;
			}
			catch { }
			
			try
			{
				r[Field_Tencangden]=_HopdongbanhangchitietEntity.Tencangden;
			}
			catch { }
			
			try
			{
				r[Field_Mahangphiakhach]=_HopdongbanhangchitietEntity.Mahangphiakhach;
			}
			catch { }
			
			try
			{
				r[Field_Codefiller]=_HopdongbanhangchitietEntity.Codefiller;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_HopdongbanhangchitietEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Dongiavnd]=_HopdongbanhangchitietEntity.Dongiavnd;
			}
			catch { }
			
			try
			{
				r[Field_Tygia]=_HopdongbanhangchitietEntity.Tygia;
			}
			catch { }
			
			try
			{
				r[Field_Dongiausd]=_HopdongbanhangchitietEntity.Dongiausd;
			}
			catch { }
			
			try
			{
				r[Field_Thanhtienvnd]=_HopdongbanhangchitietEntity.Thanhtienvnd;
			}
			catch { }
			
			try
			{
				r[Field_Thanhtienusd]=_HopdongbanhangchitietEntity.Thanhtienusd;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_HopdongbanhangchitietEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_HopdongbanhangchitietEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_HopdongbanhangchitietEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_HopdongbanhangchitietEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public HopdongbanhangchitietEntity Convert(DataRow r)
		{	
			
			HopdongbanhangchitietEntity _HopdongbanhangchitietEntity=new HopdongbanhangchitietEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_HopdongbanhangchitietEntity.Sohopdong= r[Field_Sohopdong].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Ngayhopdong= System.DateTime.Parse(r[Field_Ngayhopdong].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Macangden= r[Field_Macangden].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Tencangden= r[Field_Tencangden].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Mahangphiakhach= r[Field_Mahangphiakhach].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Codefiller= r[Field_Codefiller].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Dongiavnd= System.Decimal.Parse(r[Field_Dongiavnd].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Tygia= System.Decimal.Parse(r[Field_Tygia].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Dongiausd= System.Decimal.Parse(r[Field_Dongiausd].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Thanhtienvnd= System.Decimal.Parse(r[Field_Thanhtienvnd].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Thanhtienusd= System.Decimal.Parse(r[Field_Thanhtienusd].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_HopdongbanhangchitietEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _HopdongbanhangchitietEntity;
		}			
		
		public HopdongbanhangchitietEntity Convert_Entity(HopdongbanhangchitietEntity _HopdongbanhangchitietEntity,HopdongbanhangchitietEntity _HopdongbanhangchitietEntity_XML)
		{	
			
			
			_HopdongbanhangchitietEntity.Id= _HopdongbanhangchitietEntity_XML.Id;
			
			_HopdongbanhangchitietEntity.Sohopdong= _HopdongbanhangchitietEntity_XML.Sohopdong;
			
			_HopdongbanhangchitietEntity.Ngayhopdong= _HopdongbanhangchitietEntity_XML.Ngayhopdong;
			
			_HopdongbanhangchitietEntity.Makhach= _HopdongbanhangchitietEntity_XML.Makhach;
			
			_HopdongbanhangchitietEntity.Tenkhach= _HopdongbanhangchitietEntity_XML.Tenkhach;
			
			_HopdongbanhangchitietEntity.Macangden= _HopdongbanhangchitietEntity_XML.Macangden;
			
			_HopdongbanhangchitietEntity.Tencangden= _HopdongbanhangchitietEntity_XML.Tencangden;
			
			_HopdongbanhangchitietEntity.Mahangphiakhach= _HopdongbanhangchitietEntity_XML.Mahangphiakhach;
			
			_HopdongbanhangchitietEntity.Codefiller= _HopdongbanhangchitietEntity_XML.Codefiller;
			
			_HopdongbanhangchitietEntity.Soluong= _HopdongbanhangchitietEntity_XML.Soluong;
			
			_HopdongbanhangchitietEntity.Dongiavnd= _HopdongbanhangchitietEntity_XML.Dongiavnd;
			
			_HopdongbanhangchitietEntity.Tygia= _HopdongbanhangchitietEntity_XML.Tygia;
			
			_HopdongbanhangchitietEntity.Dongiausd= _HopdongbanhangchitietEntity_XML.Dongiausd;
			
			_HopdongbanhangchitietEntity.Thanhtienvnd= _HopdongbanhangchitietEntity_XML.Thanhtienvnd;
			
			_HopdongbanhangchitietEntity.Thanhtienusd= _HopdongbanhangchitietEntity_XML.Thanhtienusd;
			
			_HopdongbanhangchitietEntity.Ngaytao= _HopdongbanhangchitietEntity_XML.Ngaytao;
			
			_HopdongbanhangchitietEntity.Nguoitao= _HopdongbanhangchitietEntity_XML.Nguoitao;
			
			_HopdongbanhangchitietEntity.Ngaysua= _HopdongbanhangchitietEntity_XML.Ngaysua;
			
			_HopdongbanhangchitietEntity.Nguoisua= _HopdongbanhangchitietEntity_XML.Nguoisua;
									
				
			return _HopdongbanhangchitietEntity;
		}	
		
		public String InsertV2(HopdongbanhangchitietEntity _HopdongbanhangchitietEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new HopdongbanhangchitietManagerBase()).Insert(_HopdongbanhangchitietEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_HopdongbanhangchitietEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Sohopdong,_HopdongbanhangchitietEntity.Sohopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhopdong,_HopdongbanhangchitietEntity.Ngayhopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_HopdongbanhangchitietEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_HopdongbanhangchitietEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macangden,_HopdongbanhangchitietEntity.Macangden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencangden,_HopdongbanhangchitietEntity.Tencangden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangphiakhach,_HopdongbanhangchitietEntity.Mahangphiakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Codefiller,_HopdongbanhangchitietEntity.Codefiller);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_HopdongbanhangchitietEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiavnd,_HopdongbanhangchitietEntity.Dongiavnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tygia,_HopdongbanhangchitietEntity.Tygia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiausd,_HopdongbanhangchitietEntity.Dongiausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienvnd,_HopdongbanhangchitietEntity.Thanhtienvnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienusd,_HopdongbanhangchitietEntity.Thanhtienusd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_HopdongbanhangchitietEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_HopdongbanhangchitietEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_HopdongbanhangchitietEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_HopdongbanhangchitietEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(HopdongbanhangchitietEntity _HopdongbanhangchitietEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new HopdongbanhangchitietManagerBase()).Update(_HopdongbanhangchitietEntity);
			r.SetField(Field_Id,_HopdongbanhangchitietEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Sohopdong,_HopdongbanhangchitietEntity.Sohopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhopdong,_HopdongbanhangchitietEntity.Ngayhopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_HopdongbanhangchitietEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_HopdongbanhangchitietEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macangden,_HopdongbanhangchitietEntity.Macangden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencangden,_HopdongbanhangchitietEntity.Tencangden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangphiakhach,_HopdongbanhangchitietEntity.Mahangphiakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Codefiller,_HopdongbanhangchitietEntity.Codefiller);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_HopdongbanhangchitietEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiavnd,_HopdongbanhangchitietEntity.Dongiavnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tygia,_HopdongbanhangchitietEntity.Tygia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiausd,_HopdongbanhangchitietEntity.Dongiausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienvnd,_HopdongbanhangchitietEntity.Thanhtienvnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienusd,_HopdongbanhangchitietEntity.Thanhtienusd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_HopdongbanhangchitietEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_HopdongbanhangchitietEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_HopdongbanhangchitietEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_HopdongbanhangchitietEntity.Nguoisua);
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

		public HopdongbanhangchitietEntity Insert(HopdongbanhangchitietEntity HopdongbanhangchitietEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(HopdongbanhangchitietEntity, true);
			}
			return HopdongbanhangchitietEntity;
		}

		public HopdongbanhangchitietEntity Insert(System.Int64  Id, System.String  Sohopdong, System.DateTime  Ngayhopdong, System.String  Makhach, System.String  Tenkhach, System.String  Macangden, System.String  Tencangden, System.String  Mahangphiakhach, System.String  Codefiller, System.Decimal  Soluong, System.Decimal  Dongiavnd, System.Decimal  Tygia, System.Decimal  Dongiausd, System.Decimal  Thanhtienvnd, System.Decimal  Thanhtienusd, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			HopdongbanhangchitietEntity _HopdongbanhangchitietEntity = new HopdongbanhangchitietEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HopdongbanhangchitietEntity.Id = Id;
				
				_HopdongbanhangchitietEntity.Sohopdong = Sohopdong;
				
				_HopdongbanhangchitietEntity.Ngayhopdong = Ngayhopdong;
				
				_HopdongbanhangchitietEntity.Makhach = Makhach;
				
				_HopdongbanhangchitietEntity.Tenkhach = Tenkhach;
				
				_HopdongbanhangchitietEntity.Macangden = Macangden;
				
				_HopdongbanhangchitietEntity.Tencangden = Tencangden;
				
				_HopdongbanhangchitietEntity.Mahangphiakhach = Mahangphiakhach;
				
				_HopdongbanhangchitietEntity.Codefiller = Codefiller;
				
				_HopdongbanhangchitietEntity.Soluong = Soluong;
				
				_HopdongbanhangchitietEntity.Dongiavnd = Dongiavnd;
				
				_HopdongbanhangchitietEntity.Tygia = Tygia;
				
				_HopdongbanhangchitietEntity.Dongiausd = Dongiausd;
				
				_HopdongbanhangchitietEntity.Thanhtienvnd = Thanhtienvnd;
				
				_HopdongbanhangchitietEntity.Thanhtienusd = Thanhtienusd;
				
				_HopdongbanhangchitietEntity.Ngaytao = Ngaytao;
				
				_HopdongbanhangchitietEntity.Nguoitao = Nguoitao;
				
				_HopdongbanhangchitietEntity.Ngaysua = Ngaysua;
				
				_HopdongbanhangchitietEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_HopdongbanhangchitietEntity, true);
			}
			return _HopdongbanhangchitietEntity;
		}

		public HopdongbanhangchitietEntity Insert(System.String Sohopdong, System.DateTime Ngayhopdong, System.String Makhach, System.String Tenkhach, System.String Macangden, System.String Tencangden, System.String Mahangphiakhach, System.String Codefiller, System.Decimal Soluong, System.Decimal Dongiavnd, System.Decimal Tygia, System.Decimal Dongiausd, System.Decimal Thanhtienvnd, System.Decimal Thanhtienusd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			HopdongbanhangchitietEntity _HopdongbanhangchitietEntity = new HopdongbanhangchitietEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_HopdongbanhangchitietEntity.Sohopdong = Sohopdong;
				
				_HopdongbanhangchitietEntity.Ngayhopdong = Ngayhopdong;
				
				_HopdongbanhangchitietEntity.Makhach = Makhach;
				
				_HopdongbanhangchitietEntity.Tenkhach = Tenkhach;
				
				_HopdongbanhangchitietEntity.Macangden = Macangden;
				
				_HopdongbanhangchitietEntity.Tencangden = Tencangden;
				
				_HopdongbanhangchitietEntity.Mahangphiakhach = Mahangphiakhach;
				
				_HopdongbanhangchitietEntity.Codefiller = Codefiller;
				
				_HopdongbanhangchitietEntity.Soluong = Soluong;
				
				_HopdongbanhangchitietEntity.Dongiavnd = Dongiavnd;
				
				_HopdongbanhangchitietEntity.Tygia = Tygia;
				
				_HopdongbanhangchitietEntity.Dongiausd = Dongiausd;
				
				_HopdongbanhangchitietEntity.Thanhtienvnd = Thanhtienvnd;
				
				_HopdongbanhangchitietEntity.Thanhtienusd = Thanhtienusd;
				
				_HopdongbanhangchitietEntity.Ngaytao = Ngaytao;
				
				_HopdongbanhangchitietEntity.Nguoitao = Nguoitao;
				
				_HopdongbanhangchitietEntity.Ngaysua = Ngaysua;
				
				_HopdongbanhangchitietEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_HopdongbanhangchitietEntity, true);
			}
			return _HopdongbanhangchitietEntity;
		}

		public bool Update(HopdongbanhangchitietEntity _HopdongbanhangchitietEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(HopdongbanhangchitietFields.Id == _HopdongbanhangchitietEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HopdongbanhangchitietEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HopdongbanhangchitietEntity _HopdongbanhangchitietEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HopdongbanhangchitietEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Sohopdong, System.DateTime Ngayhopdong, System.String Makhach, System.String Tenkhach, System.String Macangden, System.String Tencangden, System.String Mahangphiakhach, System.String Codefiller, System.Decimal Soluong, System.Decimal Dongiavnd, System.Decimal Tygia, System.Decimal Dongiausd, System.Decimal Thanhtienvnd, System.Decimal Thanhtienusd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HopdongbanhangchitietEntity _HopdongbanhangchitietEntity = new HopdongbanhangchitietEntity(Id);
				if (adapter.FetchEntity(_HopdongbanhangchitietEntity))
				{
				
					
					
					_HopdongbanhangchitietEntity.Sohopdong = Sohopdong;
					
					_HopdongbanhangchitietEntity.Ngayhopdong = Ngayhopdong;
					
					_HopdongbanhangchitietEntity.Makhach = Makhach;
					
					_HopdongbanhangchitietEntity.Tenkhach = Tenkhach;
					
					_HopdongbanhangchitietEntity.Macangden = Macangden;
					
					_HopdongbanhangchitietEntity.Tencangden = Tencangden;
					
					_HopdongbanhangchitietEntity.Mahangphiakhach = Mahangphiakhach;
					
					_HopdongbanhangchitietEntity.Codefiller = Codefiller;
					
					_HopdongbanhangchitietEntity.Soluong = Soluong;
					
					_HopdongbanhangchitietEntity.Dongiavnd = Dongiavnd;
					
					_HopdongbanhangchitietEntity.Tygia = Tygia;
					
					_HopdongbanhangchitietEntity.Dongiausd = Dongiausd;
					
					_HopdongbanhangchitietEntity.Thanhtienvnd = Thanhtienvnd;
					
					_HopdongbanhangchitietEntity.Thanhtienusd = Thanhtienusd;
					
					_HopdongbanhangchitietEntity.Ngaytao = Ngaytao;
					
					_HopdongbanhangchitietEntity.Nguoitao = Nguoitao;
					
					_HopdongbanhangchitietEntity.Ngaysua = Ngaysua;
					
					_HopdongbanhangchitietEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_HopdongbanhangchitietEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.Int64 Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HopdongbanhangchitietEntity _HopdongbanhangchitietEntity = new HopdongbanhangchitietEntity(Id);
				if (adapter.FetchEntity(_HopdongbanhangchitietEntity))
				{
					adapter.DeleteEntity(_HopdongbanhangchitietEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohopdong(System.String Sohopdong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayhopdong(System.DateTime Ngayhopdong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacangden(System.String Macangden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Macangden == Macangden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencangden(System.String Tencangden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tencangden == Tencangden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMahangphiakhach(System.String Mahangphiakhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCodefiller(System.String Codefiller)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongiavnd(System.Decimal Dongiavnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Dongiavnd == Dongiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTygia(System.Decimal Tygia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tygia == Tygia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongiausd(System.Decimal Dongiausd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThanhtienvnd(System.Decimal Thanhtienvnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThanhtienusd(System.Decimal Thanhtienusd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HopdongbanhangchitietEntity", filter);
			}
			return toReturn;
		}		
			
		
		public HopdongbanhangchitietEntity SelectOne(System.Int64 Id)
		{
			HopdongbanhangchitietEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HopdongbanhangchitietEntity _HopdongbanhangchitietEntity = new HopdongbanhangchitietEntity(Id);
				if (adapter.FetchEntity(_HopdongbanhangchitietEntity))
				{
					toReturn = _HopdongbanhangchitietEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection( new HopdongbanhangchitietEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, null, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohopdong(System.String Sohopdong)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectBySohopdongRDT(System.String Sohopdong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayhopdong(System.DateTime Ngayhopdong)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayhopdongRDT(System.DateTime Ngayhopdong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacangden(System.String Macangden)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Macangden == Macangden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByMacangdenRDT(System.String Macangden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Macangden == Macangden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencangden(System.String Tencangden)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tencangden == Tencangden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByTencangdenRDT(System.String Tencangden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tencangden == Tencangden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMahangphiakhach(System.String Mahangphiakhach)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByMahangphiakhachRDT(System.String Mahangphiakhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCodefiller(System.String Codefiller)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByCodefillerRDT(System.String Codefiller)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongiavnd(System.Decimal Dongiavnd)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Dongiavnd == Dongiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiavndRDT(System.Decimal Dongiavnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Dongiavnd == Dongiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTygia(System.Decimal Tygia)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tygia == Tygia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByTygiaRDT(System.Decimal Tygia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Tygia == Tygia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongiausd(System.Decimal Dongiausd)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiausdRDT(System.Decimal Dongiausd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThanhtienvnd(System.Decimal Thanhtienvnd)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByThanhtienvndRDT(System.Decimal Thanhtienvnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThanhtienusd(System.Decimal Thanhtienusd)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByThanhtienusdRDT(System.Decimal Thanhtienusd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HopdongbanhangchitietCollection, filter, 0, null);
			}
			return _HopdongbanhangchitietCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HopdongbanhangchitietCollection = new EntityCollection(new HopdongbanhangchitietEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HopdongbanhangchitietFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HopdongbanhangchitietCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
