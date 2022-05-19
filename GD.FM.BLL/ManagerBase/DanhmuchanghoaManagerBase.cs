


/*
'===============================================================================
'  GD.FM.DAL.BL.DanhmuchanghoaManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GD.FM.DAL.BLL;
using GD.FM.DAL.DAL;
using GD.FM.DAL.DAL.EntityClasses;
using GD.FM.DAL.DAL.FactoryClasses;
using GD.FM.DAL.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Windows.Forms;
namespace GD.FM.DAL.BLL
{
	public class DanhmuchanghoaManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mahieu="Mahieu";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Mahangphiakhach="Mahangphiakhach";				
		
		public const String Field_Maungdung="Maungdung";				
		
		public const String Field_Tocdomay="Tocdomay";				
		
		public const String Field_Caco3kh="Caco3kh";				
		
		public const String Field_Tio2kh="Tio2kh";				
		
		public const String Field_Mikh="Mikh";				
		
		public const String Field_Khackh="Khackh";				
		
		public const String Field_Caco3fm="Caco3fm";				
		
		public const String Field_Tio2fm="Tio2fm";				
		
		public const String Field_Mifm="Mifm";				
		
		public const String Field_Khacfm="Khacfm";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DanhmuchanghoaManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mahieu,typeof(System.String));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Mahangphiakhach,typeof(System.String));
			
			dt.Columns.Add(Field_Maungdung,typeof(System.String));
			
			dt.Columns.Add(Field_Tocdomay,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Caco3kh,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tio2kh,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Mikh,typeof(System.String));
			
			dt.Columns.Add(Field_Khackh,typeof(System.String));
			
			dt.Columns.Add(Field_Caco3fm,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tio2fm,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Mifm,typeof(System.String));
			
			dt.Columns.Add(Field_Khacfm,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DanhmuchanghoaEntity _DanhmuchanghoaEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_DanhmuchanghoaEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_DanhmuchanghoaEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_DanhmuchanghoaEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Mahangphiakhach]=_DanhmuchanghoaEntity.Mahangphiakhach;
			}
			catch { }
			
			try
			{
				r[Field_Maungdung]=_DanhmuchanghoaEntity.Maungdung;
			}
			catch { }
			
			try
			{
				r[Field_Tocdomay]=_DanhmuchanghoaEntity.Tocdomay;
			}
			catch { }
			
			try
			{
				r[Field_Caco3kh]=_DanhmuchanghoaEntity.Caco3kh;
			}
			catch { }
			
			try
			{
				r[Field_Tio2kh]=_DanhmuchanghoaEntity.Tio2kh;
			}
			catch { }
			
			try
			{
				r[Field_Mikh]=_DanhmuchanghoaEntity.Mikh;
			}
			catch { }
			
			try
			{
				r[Field_Khackh]=_DanhmuchanghoaEntity.Khackh;
			}
			catch { }
			
			try
			{
				r[Field_Caco3fm]=_DanhmuchanghoaEntity.Caco3fm;
			}
			catch { }
			
			try
			{
				r[Field_Tio2fm]=_DanhmuchanghoaEntity.Tio2fm;
			}
			catch { }
			
			try
			{
				r[Field_Mifm]=_DanhmuchanghoaEntity.Mifm;
			}
			catch { }
			
			try
			{
				r[Field_Khacfm]=_DanhmuchanghoaEntity.Khacfm;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DanhmuchanghoaEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DanhmuchanghoaEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DanhmuchanghoaEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DanhmuchanghoaEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DanhmuchanghoaEntity Convert(DataRow r)
		{	
			
			DanhmuchanghoaEntity _DanhmuchanghoaEntity=new DanhmuchanghoaEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_DanhmuchanghoaEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Mahangphiakhach= r[Field_Mahangphiakhach].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Maungdung= r[Field_Maungdung].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Tocdomay= System.Decimal.Parse(r[Field_Tocdomay].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Caco3kh= System.Decimal.Parse(r[Field_Caco3kh].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Tio2kh= System.Decimal.Parse(r[Field_Tio2kh].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Mikh= r[Field_Mikh].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Khackh= r[Field_Khackh].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Caco3fm= System.Decimal.Parse(r[Field_Caco3fm].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Tio2fm= System.Decimal.Parse(r[Field_Tio2fm].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Mifm= r[Field_Mifm].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Khacfm= r[Field_Khacfm].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuchanghoaEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DanhmuchanghoaEntity;
		}			
		
		public DanhmuchanghoaEntity Convert_Entity(DanhmuchanghoaEntity _DanhmuchanghoaEntity,DanhmuchanghoaEntity _DanhmuchanghoaEntity_XML)
		{	
			
			
			_DanhmuchanghoaEntity.Mahieu= _DanhmuchanghoaEntity_XML.Mahieu;
			
			_DanhmuchanghoaEntity.Makhach= _DanhmuchanghoaEntity_XML.Makhach;
			
			_DanhmuchanghoaEntity.Tenkhach= _DanhmuchanghoaEntity_XML.Tenkhach;
			
			_DanhmuchanghoaEntity.Mahangphiakhach= _DanhmuchanghoaEntity_XML.Mahangphiakhach;
			
			_DanhmuchanghoaEntity.Maungdung= _DanhmuchanghoaEntity_XML.Maungdung;
			
			_DanhmuchanghoaEntity.Tocdomay= _DanhmuchanghoaEntity_XML.Tocdomay;
			
			_DanhmuchanghoaEntity.Caco3kh= _DanhmuchanghoaEntity_XML.Caco3kh;
			
			_DanhmuchanghoaEntity.Tio2kh= _DanhmuchanghoaEntity_XML.Tio2kh;
			
			_DanhmuchanghoaEntity.Mikh= _DanhmuchanghoaEntity_XML.Mikh;
			
			_DanhmuchanghoaEntity.Khackh= _DanhmuchanghoaEntity_XML.Khackh;
			
			_DanhmuchanghoaEntity.Caco3fm= _DanhmuchanghoaEntity_XML.Caco3fm;
			
			_DanhmuchanghoaEntity.Tio2fm= _DanhmuchanghoaEntity_XML.Tio2fm;
			
			_DanhmuchanghoaEntity.Mifm= _DanhmuchanghoaEntity_XML.Mifm;
			
			_DanhmuchanghoaEntity.Khacfm= _DanhmuchanghoaEntity_XML.Khacfm;
			
			_DanhmuchanghoaEntity.Ngaytao= _DanhmuchanghoaEntity_XML.Ngaytao;
			
			_DanhmuchanghoaEntity.Nguoitao= _DanhmuchanghoaEntity_XML.Nguoitao;
			
			_DanhmuchanghoaEntity.Ngaysua= _DanhmuchanghoaEntity_XML.Ngaysua;
			
			_DanhmuchanghoaEntity.Nguoisua= _DanhmuchanghoaEntity_XML.Nguoisua;
									
				
			return _DanhmuchanghoaEntity;
		}	
		
		public String InsertV2(DanhmuchanghoaEntity _DanhmuchanghoaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DanhmuchanghoaManagerBase()).Insert(_DanhmuchanghoaEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_DanhmuchanghoaEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Makhach,_DanhmuchanghoaEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DanhmuchanghoaEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangphiakhach,_DanhmuchanghoaEntity.Mahangphiakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maungdung,_DanhmuchanghoaEntity.Maungdung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdomay,_DanhmuchanghoaEntity.Tocdomay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Caco3kh,_DanhmuchanghoaEntity.Caco3kh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tio2kh,_DanhmuchanghoaEntity.Tio2kh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mikh,_DanhmuchanghoaEntity.Mikh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khackh,_DanhmuchanghoaEntity.Khackh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Caco3fm,_DanhmuchanghoaEntity.Caco3fm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tio2fm,_DanhmuchanghoaEntity.Tio2fm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mifm,_DanhmuchanghoaEntity.Mifm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khacfm,_DanhmuchanghoaEntity.Khacfm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmuchanghoaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmuchanghoaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmuchanghoaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmuchanghoaEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DanhmuchanghoaEntity _DanhmuchanghoaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DanhmuchanghoaManagerBase()).Update(_DanhmuchanghoaEntity);
			r.SetField(Field_Mahieu,_DanhmuchanghoaEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Makhach,_DanhmuchanghoaEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DanhmuchanghoaEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangphiakhach,_DanhmuchanghoaEntity.Mahangphiakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maungdung,_DanhmuchanghoaEntity.Maungdung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdomay,_DanhmuchanghoaEntity.Tocdomay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Caco3kh,_DanhmuchanghoaEntity.Caco3kh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tio2kh,_DanhmuchanghoaEntity.Tio2kh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mikh,_DanhmuchanghoaEntity.Mikh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khackh,_DanhmuchanghoaEntity.Khackh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Caco3fm,_DanhmuchanghoaEntity.Caco3fm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tio2fm,_DanhmuchanghoaEntity.Tio2fm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mifm,_DanhmuchanghoaEntity.Mifm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khacfm,_DanhmuchanghoaEntity.Khacfm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmuchanghoaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmuchanghoaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmuchanghoaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmuchanghoaEntity.Nguoisua);
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

		public DanhmuchanghoaEntity Insert(DanhmuchanghoaEntity DanhmuchanghoaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DanhmuchanghoaEntity, true);
			}
			return DanhmuchanghoaEntity;
		}

		public DanhmuchanghoaEntity Insert(System.String  Mahieu, System.String  Makhach, System.String  Tenkhach, System.String  Mahangphiakhach, System.String  Maungdung, System.Decimal  Tocdomay, System.Decimal  Caco3kh, System.Decimal  Tio2kh, System.String  Mikh, System.String  Khackh, System.Decimal  Caco3fm, System.Decimal  Tio2fm, System.String  Mifm, System.String  Khacfm, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DanhmuchanghoaEntity.Mahieu = Mahieu;
				
				_DanhmuchanghoaEntity.Makhach = Makhach;
				
				_DanhmuchanghoaEntity.Tenkhach = Tenkhach;
				
				_DanhmuchanghoaEntity.Mahangphiakhach = Mahangphiakhach;
				
				_DanhmuchanghoaEntity.Maungdung = Maungdung;
				
				_DanhmuchanghoaEntity.Tocdomay = Tocdomay;
				
				_DanhmuchanghoaEntity.Caco3kh = Caco3kh;
				
				_DanhmuchanghoaEntity.Tio2kh = Tio2kh;
				
				_DanhmuchanghoaEntity.Mikh = Mikh;
				
				_DanhmuchanghoaEntity.Khackh = Khackh;
				
				_DanhmuchanghoaEntity.Caco3fm = Caco3fm;
				
				_DanhmuchanghoaEntity.Tio2fm = Tio2fm;
				
				_DanhmuchanghoaEntity.Mifm = Mifm;
				
				_DanhmuchanghoaEntity.Khacfm = Khacfm;
				
				_DanhmuchanghoaEntity.Ngaytao = Ngaytao;
				
				_DanhmuchanghoaEntity.Nguoitao = Nguoitao;
				
				_DanhmuchanghoaEntity.Ngaysua = Ngaysua;
				
				_DanhmuchanghoaEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DanhmuchanghoaEntity, true);
			}
			return _DanhmuchanghoaEntity;
		}

		public DanhmuchanghoaEntity Insert(System.String Makhach, System.String Tenkhach, System.String Mahangphiakhach, System.String Maungdung, System.Decimal Tocdomay, System.Decimal Caco3kh, System.Decimal Tio2kh, System.String Mikh, System.String Khackh, System.Decimal Caco3fm, System.Decimal Tio2fm, System.String Mifm, System.String Khacfm, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, )//ko co mahieu
		{
			DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DanhmuchanghoaEntity.Makhach = Makhach;
				
				_DanhmuchanghoaEntity.Tenkhach = Tenkhach;
				
				_DanhmuchanghoaEntity.Mahangphiakhach = Mahangphiakhach;
				
				_DanhmuchanghoaEntity.Maungdung = Maungdung;
				
				_DanhmuchanghoaEntity.Tocdomay = Tocdomay;
				
				_DanhmuchanghoaEntity.Caco3kh = Caco3kh;
				
				_DanhmuchanghoaEntity.Tio2kh = Tio2kh;
				
				_DanhmuchanghoaEntity.Mikh = Mikh;
				
				_DanhmuchanghoaEntity.Khackh = Khackh;
				
				_DanhmuchanghoaEntity.Caco3fm = Caco3fm;
				
				_DanhmuchanghoaEntity.Tio2fm = Tio2fm;
				
				_DanhmuchanghoaEntity.Mifm = Mifm;
				
				_DanhmuchanghoaEntity.Khacfm = Khacfm;
				
				_DanhmuchanghoaEntity.Ngaytao = Ngaytao;
				
				_DanhmuchanghoaEntity.Nguoitao = Nguoitao;
				
				_DanhmuchanghoaEntity.Ngaysua = Ngaysua;
				
				_DanhmuchanghoaEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DanhmuchanghoaEntity, true);
			}
			return _DanhmuchanghoaEntity;
		}

		public bool Update(DanhmuchanghoaEntity _DanhmuchanghoaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DanhmuchanghoaFields.Mahieu == _DanhmuchanghoaEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DanhmuchanghoaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DanhmuchanghoaEntity _DanhmuchanghoaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DanhmuchanghoaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Makhach, System.String Tenkhach, System.String Mahangphiakhach, System.String Maungdung, System.Decimal Tocdomay, System.Decimal Caco3kh, System.Decimal Tio2kh, System.String Mikh, System.String Khackh, System.Decimal Caco3fm, System.Decimal Tio2fm, System.String Mifm, System.String Khacfm, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmuchanghoaEntity))
				{
				
					
					
					_DanhmuchanghoaEntity.Makhach = Makhach;
					
					_DanhmuchanghoaEntity.Tenkhach = Tenkhach;
					
					_DanhmuchanghoaEntity.Mahangphiakhach = Mahangphiakhach;
					
					_DanhmuchanghoaEntity.Maungdung = Maungdung;
					
					_DanhmuchanghoaEntity.Tocdomay = Tocdomay;
					
					_DanhmuchanghoaEntity.Caco3kh = Caco3kh;
					
					_DanhmuchanghoaEntity.Tio2kh = Tio2kh;
					
					_DanhmuchanghoaEntity.Mikh = Mikh;
					
					_DanhmuchanghoaEntity.Khackh = Khackh;
					
					_DanhmuchanghoaEntity.Caco3fm = Caco3fm;
					
					_DanhmuchanghoaEntity.Tio2fm = Tio2fm;
					
					_DanhmuchanghoaEntity.Mifm = Mifm;
					
					_DanhmuchanghoaEntity.Khacfm = Khacfm;
					
					_DanhmuchanghoaEntity.Ngaytao = Ngaytao;
					
					_DanhmuchanghoaEntity.Nguoitao = Nguoitao;
					
					_DanhmuchanghoaEntity.Ngaysua = Ngaysua;
					
					_DanhmuchanghoaEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DanhmuchanghoaEntity, true);
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
				DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmuchanghoaEntity))
				{
					adapter.DeleteEntity(_DanhmuchanghoaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMahangphiakhach(System.String Mahangphiakhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaungdung(System.String Maungdung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Maungdung == Maungdung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTocdomay(System.Decimal Tocdomay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tocdomay == Tocdomay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCaco3kh(System.Decimal Caco3kh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Caco3kh == Caco3kh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTio2kh(System.Decimal Tio2kh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tio2kh == Tio2kh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMikh(System.String Mikh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mikh == Mikh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhackh(System.String Khackh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Khackh == Khackh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCaco3fm(System.Decimal Caco3fm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Caco3fm == Caco3fm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTio2fm(System.Decimal Tio2fm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tio2fm == Tio2fm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMifm(System.String Mifm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mifm == Mifm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhacfm(System.String Khacfm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Khacfm == Khacfm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuchanghoaEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DanhmuchanghoaEntity SelectOne(System.String Mahieu)
		{
			DanhmuchanghoaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmuchanghoaEntity _DanhmuchanghoaEntity = new DanhmuchanghoaEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmuchanghoaEntity))
				{
					toReturn = _DanhmuchanghoaEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection( new DanhmuchanghoaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, null, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMahangphiakhach(System.String Mahangphiakhach)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByMahangphiakhachRDT(System.String Mahangphiakhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaungdung(System.String Maungdung)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Maungdung == Maungdung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByMaungdungRDT(System.String Maungdung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Maungdung == Maungdung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTocdomay(System.Decimal Tocdomay)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tocdomay == Tocdomay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByTocdomayRDT(System.Decimal Tocdomay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tocdomay == Tocdomay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCaco3kh(System.Decimal Caco3kh)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Caco3kh == Caco3kh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByCaco3khRDT(System.Decimal Caco3kh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Caco3kh == Caco3kh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTio2kh(System.Decimal Tio2kh)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tio2kh == Tio2kh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByTio2khRDT(System.Decimal Tio2kh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tio2kh == Tio2kh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMikh(System.String Mikh)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mikh == Mikh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByMikhRDT(System.String Mikh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mikh == Mikh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhackh(System.String Khackh)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Khackh == Khackh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByKhackhRDT(System.String Khackh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Khackh == Khackh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCaco3fm(System.Decimal Caco3fm)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Caco3fm == Caco3fm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByCaco3fmRDT(System.Decimal Caco3fm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Caco3fm == Caco3fm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTio2fm(System.Decimal Tio2fm)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tio2fm == Tio2fm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByTio2fmRDT(System.Decimal Tio2fm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Tio2fm == Tio2fm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMifm(System.String Mifm)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mifm == Mifm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByMifmRDT(System.String Mifm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Mifm == Mifm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhacfm(System.String Khacfm)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Khacfm == Khacfm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByKhacfmRDT(System.String Khacfm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Khacfm == Khacfm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuchanghoaCollection, filter, 0, null);
			}
			return _DanhmuchanghoaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuchanghoaCollection = new EntityCollection(new DanhmuchanghoaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuchanghoaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuchanghoaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
