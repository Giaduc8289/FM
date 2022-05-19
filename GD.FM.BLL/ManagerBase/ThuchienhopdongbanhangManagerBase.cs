


/*
'===============================================================================
'  GD.FM.BL.ThuchienhopdongbanhangManagerBase
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
	public class ThuchienhopdongbanhangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Sohopdong="Sohopdong";				
		
		public const String Field_Ngayhopdong="Ngayhopdong";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Mahangphiakhach="Mahangphiakhach";				
		
		public const String Field_Codefiller="Codefiller";				
		
		public const String Field_Soluonggiao="Soluonggiao";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
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
		public ThuchienhopdongbanhangManagerBase()
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
			
			dt.Columns.Add(Field_Mahangphiakhach,typeof(System.String));
			
			dt.Columns.Add(Field_Codefiller,typeof(System.String));
			
			dt.Columns.Add(Field_Soluonggiao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
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
		public DataRow Convert(ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_ThuchienhopdongbanhangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Sohopdong]=_ThuchienhopdongbanhangEntity.Sohopdong;
			}
			catch { }
			
			try
			{
				r[Field_Ngayhopdong]=_ThuchienhopdongbanhangEntity.Ngayhopdong;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_ThuchienhopdongbanhangEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_ThuchienhopdongbanhangEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Mahangphiakhach]=_ThuchienhopdongbanhangEntity.Mahangphiakhach;
			}
			catch { }
			
			try
			{
				r[Field_Codefiller]=_ThuchienhopdongbanhangEntity.Codefiller;
			}
			catch { }
			
			try
			{
				r[Field_Soluonggiao]=_ThuchienhopdongbanhangEntity.Soluonggiao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_ThuchienhopdongbanhangEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Dongiavnd]=_ThuchienhopdongbanhangEntity.Dongiavnd;
			}
			catch { }
			
			try
			{
				r[Field_Tygia]=_ThuchienhopdongbanhangEntity.Tygia;
			}
			catch { }
			
			try
			{
				r[Field_Dongiausd]=_ThuchienhopdongbanhangEntity.Dongiausd;
			}
			catch { }
			
			try
			{
				r[Field_Thanhtienvnd]=_ThuchienhopdongbanhangEntity.Thanhtienvnd;
			}
			catch { }
			
			try
			{
				r[Field_Thanhtienusd]=_ThuchienhopdongbanhangEntity.Thanhtienusd;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_ThuchienhopdongbanhangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_ThuchienhopdongbanhangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_ThuchienhopdongbanhangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_ThuchienhopdongbanhangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public ThuchienhopdongbanhangEntity Convert(DataRow r)
		{	
			
			ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity=new ThuchienhopdongbanhangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_ThuchienhopdongbanhangEntity.Sohopdong= r[Field_Sohopdong].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Ngayhopdong= System.DateTime.Parse(r[Field_Ngayhopdong].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Mahangphiakhach= r[Field_Mahangphiakhach].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Codefiller= r[Field_Codefiller].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Soluonggiao= System.Decimal.Parse(r[Field_Soluonggiao].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Dongiavnd= System.Decimal.Parse(r[Field_Dongiavnd].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Tygia= System.Decimal.Parse(r[Field_Tygia].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Dongiausd= System.Decimal.Parse(r[Field_Dongiausd].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Thanhtienvnd= System.Decimal.Parse(r[Field_Thanhtienvnd].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Thanhtienusd= System.Decimal.Parse(r[Field_Thanhtienusd].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienhopdongbanhangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _ThuchienhopdongbanhangEntity;
		}			
		
		public ThuchienhopdongbanhangEntity Convert_Entity(ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity,ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity_XML)
		{	
			
			
			_ThuchienhopdongbanhangEntity.Id= _ThuchienhopdongbanhangEntity_XML.Id;
			
			_ThuchienhopdongbanhangEntity.Sohopdong= _ThuchienhopdongbanhangEntity_XML.Sohopdong;
			
			_ThuchienhopdongbanhangEntity.Ngayhopdong= _ThuchienhopdongbanhangEntity_XML.Ngayhopdong;
			
			_ThuchienhopdongbanhangEntity.Makhach= _ThuchienhopdongbanhangEntity_XML.Makhach;
			
			_ThuchienhopdongbanhangEntity.Tenkhach= _ThuchienhopdongbanhangEntity_XML.Tenkhach;
			
			_ThuchienhopdongbanhangEntity.Mahangphiakhach= _ThuchienhopdongbanhangEntity_XML.Mahangphiakhach;
			
			_ThuchienhopdongbanhangEntity.Codefiller= _ThuchienhopdongbanhangEntity_XML.Codefiller;
			
			_ThuchienhopdongbanhangEntity.Soluonggiao= _ThuchienhopdongbanhangEntity_XML.Soluonggiao;
			
			_ThuchienhopdongbanhangEntity.Ngaygiao= _ThuchienhopdongbanhangEntity_XML.Ngaygiao;
			
			_ThuchienhopdongbanhangEntity.Dongiavnd= _ThuchienhopdongbanhangEntity_XML.Dongiavnd;
			
			_ThuchienhopdongbanhangEntity.Tygia= _ThuchienhopdongbanhangEntity_XML.Tygia;
			
			_ThuchienhopdongbanhangEntity.Dongiausd= _ThuchienhopdongbanhangEntity_XML.Dongiausd;
			
			_ThuchienhopdongbanhangEntity.Thanhtienvnd= _ThuchienhopdongbanhangEntity_XML.Thanhtienvnd;
			
			_ThuchienhopdongbanhangEntity.Thanhtienusd= _ThuchienhopdongbanhangEntity_XML.Thanhtienusd;
			
			_ThuchienhopdongbanhangEntity.Ngaytao= _ThuchienhopdongbanhangEntity_XML.Ngaytao;
			
			_ThuchienhopdongbanhangEntity.Nguoitao= _ThuchienhopdongbanhangEntity_XML.Nguoitao;
			
			_ThuchienhopdongbanhangEntity.Ngaysua= _ThuchienhopdongbanhangEntity_XML.Ngaysua;
			
			_ThuchienhopdongbanhangEntity.Nguoisua= _ThuchienhopdongbanhangEntity_XML.Nguoisua;
									
				
			return _ThuchienhopdongbanhangEntity;
		}	
		
		public String InsertV2(ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new ThuchienhopdongbanhangManagerBase()).Insert(_ThuchienhopdongbanhangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_ThuchienhopdongbanhangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Sohopdong,_ThuchienhopdongbanhangEntity.Sohopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhopdong,_ThuchienhopdongbanhangEntity.Ngayhopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_ThuchienhopdongbanhangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_ThuchienhopdongbanhangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangphiakhach,_ThuchienhopdongbanhangEntity.Mahangphiakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Codefiller,_ThuchienhopdongbanhangEntity.Codefiller);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluonggiao,_ThuchienhopdongbanhangEntity.Soluonggiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_ThuchienhopdongbanhangEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiavnd,_ThuchienhopdongbanhangEntity.Dongiavnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tygia,_ThuchienhopdongbanhangEntity.Tygia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiausd,_ThuchienhopdongbanhangEntity.Dongiausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienvnd,_ThuchienhopdongbanhangEntity.Thanhtienvnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienusd,_ThuchienhopdongbanhangEntity.Thanhtienusd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_ThuchienhopdongbanhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_ThuchienhopdongbanhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_ThuchienhopdongbanhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_ThuchienhopdongbanhangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new ThuchienhopdongbanhangManagerBase()).Update(_ThuchienhopdongbanhangEntity);
			r.SetField(Field_Id,_ThuchienhopdongbanhangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Sohopdong,_ThuchienhopdongbanhangEntity.Sohopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhopdong,_ThuchienhopdongbanhangEntity.Ngayhopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_ThuchienhopdongbanhangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_ThuchienhopdongbanhangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangphiakhach,_ThuchienhopdongbanhangEntity.Mahangphiakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Codefiller,_ThuchienhopdongbanhangEntity.Codefiller);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluonggiao,_ThuchienhopdongbanhangEntity.Soluonggiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_ThuchienhopdongbanhangEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiavnd,_ThuchienhopdongbanhangEntity.Dongiavnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tygia,_ThuchienhopdongbanhangEntity.Tygia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiausd,_ThuchienhopdongbanhangEntity.Dongiausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienvnd,_ThuchienhopdongbanhangEntity.Thanhtienvnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtienusd,_ThuchienhopdongbanhangEntity.Thanhtienusd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_ThuchienhopdongbanhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_ThuchienhopdongbanhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_ThuchienhopdongbanhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_ThuchienhopdongbanhangEntity.Nguoisua);
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

		public ThuchienhopdongbanhangEntity Insert(ThuchienhopdongbanhangEntity ThuchienhopdongbanhangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(ThuchienhopdongbanhangEntity, true);
			}
			return ThuchienhopdongbanhangEntity;
		}

		public ThuchienhopdongbanhangEntity Insert(System.Int64  Id, System.String  Sohopdong, System.DateTime  Ngayhopdong, System.String  Makhach, System.String  Tenkhach, System.String  Mahangphiakhach, System.String  Codefiller, System.Decimal  Soluonggiao, System.DateTime  Ngaygiao, System.Decimal  Dongiavnd, System.Decimal  Tygia, System.Decimal  Dongiausd, System.Decimal  Thanhtienvnd, System.Decimal  Thanhtienusd, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ThuchienhopdongbanhangEntity.Id = Id;
				
				_ThuchienhopdongbanhangEntity.Sohopdong = Sohopdong;
				
				_ThuchienhopdongbanhangEntity.Ngayhopdong = Ngayhopdong;
				
				_ThuchienhopdongbanhangEntity.Makhach = Makhach;
				
				_ThuchienhopdongbanhangEntity.Tenkhach = Tenkhach;
				
				_ThuchienhopdongbanhangEntity.Mahangphiakhach = Mahangphiakhach;
				
				_ThuchienhopdongbanhangEntity.Codefiller = Codefiller;
				
				_ThuchienhopdongbanhangEntity.Soluonggiao = Soluonggiao;
				
				_ThuchienhopdongbanhangEntity.Ngaygiao = Ngaygiao;
				
				_ThuchienhopdongbanhangEntity.Dongiavnd = Dongiavnd;
				
				_ThuchienhopdongbanhangEntity.Tygia = Tygia;
				
				_ThuchienhopdongbanhangEntity.Dongiausd = Dongiausd;
				
				_ThuchienhopdongbanhangEntity.Thanhtienvnd = Thanhtienvnd;
				
				_ThuchienhopdongbanhangEntity.Thanhtienusd = Thanhtienusd;
				
				_ThuchienhopdongbanhangEntity.Ngaytao = Ngaytao;
				
				_ThuchienhopdongbanhangEntity.Nguoitao = Nguoitao;
				
				_ThuchienhopdongbanhangEntity.Ngaysua = Ngaysua;
				
				_ThuchienhopdongbanhangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_ThuchienhopdongbanhangEntity, true);
			}
			return _ThuchienhopdongbanhangEntity;
		}

		public ThuchienhopdongbanhangEntity Insert(System.String Sohopdong, System.DateTime Ngayhopdong, System.String Makhach, System.String Tenkhach, System.String Mahangphiakhach, System.String Codefiller, System.Decimal Soluonggiao, System.DateTime Ngaygiao, System.Decimal Dongiavnd, System.Decimal Tygia, System.Decimal Dongiausd, System.Decimal Thanhtienvnd, System.Decimal Thanhtienusd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_ThuchienhopdongbanhangEntity.Sohopdong = Sohopdong;
				
				_ThuchienhopdongbanhangEntity.Ngayhopdong = Ngayhopdong;
				
				_ThuchienhopdongbanhangEntity.Makhach = Makhach;
				
				_ThuchienhopdongbanhangEntity.Tenkhach = Tenkhach;
				
				_ThuchienhopdongbanhangEntity.Mahangphiakhach = Mahangphiakhach;
				
				_ThuchienhopdongbanhangEntity.Codefiller = Codefiller;
				
				_ThuchienhopdongbanhangEntity.Soluonggiao = Soluonggiao;
				
				_ThuchienhopdongbanhangEntity.Ngaygiao = Ngaygiao;
				
				_ThuchienhopdongbanhangEntity.Dongiavnd = Dongiavnd;
				
				_ThuchienhopdongbanhangEntity.Tygia = Tygia;
				
				_ThuchienhopdongbanhangEntity.Dongiausd = Dongiausd;
				
				_ThuchienhopdongbanhangEntity.Thanhtienvnd = Thanhtienvnd;
				
				_ThuchienhopdongbanhangEntity.Thanhtienusd = Thanhtienusd;
				
				_ThuchienhopdongbanhangEntity.Ngaytao = Ngaytao;
				
				_ThuchienhopdongbanhangEntity.Nguoitao = Nguoitao;
				
				_ThuchienhopdongbanhangEntity.Ngaysua = Ngaysua;
				
				_ThuchienhopdongbanhangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_ThuchienhopdongbanhangEntity, true);
			}
			return _ThuchienhopdongbanhangEntity;
		}

		public bool Update(ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(ThuchienhopdongbanhangFields.Id == _ThuchienhopdongbanhangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ThuchienhopdongbanhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ThuchienhopdongbanhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Sohopdong, System.DateTime Ngayhopdong, System.String Makhach, System.String Tenkhach, System.String Mahangphiakhach, System.String Codefiller, System.Decimal Soluonggiao, System.DateTime Ngaygiao, System.Decimal Dongiavnd, System.Decimal Tygia, System.Decimal Dongiausd, System.Decimal Thanhtienvnd, System.Decimal Thanhtienusd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity(Id);
				if (adapter.FetchEntity(_ThuchienhopdongbanhangEntity))
				{
				
					
					
					_ThuchienhopdongbanhangEntity.Sohopdong = Sohopdong;
					
					_ThuchienhopdongbanhangEntity.Ngayhopdong = Ngayhopdong;
					
					_ThuchienhopdongbanhangEntity.Makhach = Makhach;
					
					_ThuchienhopdongbanhangEntity.Tenkhach = Tenkhach;
					
					_ThuchienhopdongbanhangEntity.Mahangphiakhach = Mahangphiakhach;
					
					_ThuchienhopdongbanhangEntity.Codefiller = Codefiller;
					
					_ThuchienhopdongbanhangEntity.Soluonggiao = Soluonggiao;
					
					_ThuchienhopdongbanhangEntity.Ngaygiao = Ngaygiao;
					
					_ThuchienhopdongbanhangEntity.Dongiavnd = Dongiavnd;
					
					_ThuchienhopdongbanhangEntity.Tygia = Tygia;
					
					_ThuchienhopdongbanhangEntity.Dongiausd = Dongiausd;
					
					_ThuchienhopdongbanhangEntity.Thanhtienvnd = Thanhtienvnd;
					
					_ThuchienhopdongbanhangEntity.Thanhtienusd = Thanhtienusd;
					
					_ThuchienhopdongbanhangEntity.Ngaytao = Ngaytao;
					
					_ThuchienhopdongbanhangEntity.Nguoitao = Nguoitao;
					
					_ThuchienhopdongbanhangEntity.Ngaysua = Ngaysua;
					
					_ThuchienhopdongbanhangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_ThuchienhopdongbanhangEntity, true);
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
				ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity(Id);
				if (adapter.FetchEntity(_ThuchienhopdongbanhangEntity))
				{
					adapter.DeleteEntity(_ThuchienhopdongbanhangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohopdong(System.String Sohopdong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayhopdong(System.DateTime Ngayhopdong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMahangphiakhach(System.String Mahangphiakhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCodefiller(System.String Codefiller)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluonggiao(System.Decimal Soluonggiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongiavnd(System.Decimal Dongiavnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Dongiavnd == Dongiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTygia(System.Decimal Tygia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Tygia == Tygia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongiausd(System.Decimal Dongiausd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThanhtienvnd(System.Decimal Thanhtienvnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThanhtienusd(System.Decimal Thanhtienusd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienhopdongbanhangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public ThuchienhopdongbanhangEntity SelectOne(System.Int64 Id)
		{
			ThuchienhopdongbanhangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThuchienhopdongbanhangEntity _ThuchienhopdongbanhangEntity = new ThuchienhopdongbanhangEntity(Id);
				if (adapter.FetchEntity(_ThuchienhopdongbanhangEntity))
				{
					toReturn = _ThuchienhopdongbanhangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection( new ThuchienhopdongbanhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, null, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohopdong(System.String Sohopdong)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySohopdongRDT(System.String Sohopdong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayhopdong(System.DateTime Ngayhopdong)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayhopdongRDT(System.DateTime Ngayhopdong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMahangphiakhach(System.String Mahangphiakhach)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMahangphiakhachRDT(System.String Mahangphiakhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCodefiller(System.String Codefiller)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByCodefillerRDT(System.String Codefiller)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluonggiao(System.Decimal Soluonggiao)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluonggiaoRDT(System.Decimal Soluonggiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongiavnd(System.Decimal Dongiavnd)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Dongiavnd == Dongiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiavndRDT(System.Decimal Dongiavnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Dongiavnd == Dongiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTygia(System.Decimal Tygia)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Tygia == Tygia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTygiaRDT(System.Decimal Tygia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Tygia == Tygia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongiausd(System.Decimal Dongiausd)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiausdRDT(System.Decimal Dongiausd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThanhtienvnd(System.Decimal Thanhtienvnd)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByThanhtienvndRDT(System.Decimal Thanhtienvnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Thanhtienvnd == Thanhtienvnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThanhtienusd(System.Decimal Thanhtienusd)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByThanhtienusdRDT(System.Decimal Thanhtienusd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Thanhtienusd == Thanhtienusd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienhopdongbanhangCollection, filter, 0, null);
			}
			return _ThuchienhopdongbanhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienhopdongbanhangCollection = new EntityCollection(new ThuchienhopdongbanhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienhopdongbanhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienhopdongbanhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
