


/*
'===============================================================================
'  GD.FM.BL.NhanvienManagerBase
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
	public class NhanvienManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Manhanvien="Manhanvien";				
		
		public const String Field_Hoten="Hoten";				
		
		public const String Field_Maphongban="Maphongban";				
		
		public const String Field_Tenphongban="Tenphongban";				
		
		public const String Field_Machucvu="Machucvu";				
		
		public const String Field_Tenchucvu="Tenchucvu";				
		
		public const String Field_Gioitinh="Gioitinh";				
		
		public const String Field_Ngaysinh="Ngaysinh";				
		
		public const String Field_Diachi="Diachi";				
		
		public const String Field_Sodienthoai="Sodienthoai";				
		
		public const String Field_Email="Email";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhanvienManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Manhanvien,typeof(System.String));
			
			dt.Columns.Add(Field_Hoten,typeof(System.String));
			
			dt.Columns.Add(Field_Maphongban,typeof(System.String));
			
			dt.Columns.Add(Field_Tenphongban,typeof(System.String));
			
			dt.Columns.Add(Field_Machucvu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenchucvu,typeof(System.String));
			
			dt.Columns.Add(Field_Gioitinh,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Ngaysinh,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Diachi,typeof(System.String));
			
			dt.Columns.Add(Field_Sodienthoai,typeof(System.String));
			
			dt.Columns.Add(Field_Email,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(NhanvienEntity _NhanvienEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Manhanvien]=_NhanvienEntity.Manhanvien;
			}
			catch { }
			
			try
			{
				r[Field_Hoten]=_NhanvienEntity.Hoten;
			}
			catch { }
			
			try
			{
				r[Field_Maphongban]=_NhanvienEntity.Maphongban;
			}
			catch { }
			
			try
			{
				r[Field_Tenphongban]=_NhanvienEntity.Tenphongban;
			}
			catch { }
			
			try
			{
				r[Field_Machucvu]=_NhanvienEntity.Machucvu;
			}
			catch { }
			
			try
			{
				r[Field_Tenchucvu]=_NhanvienEntity.Tenchucvu;
			}
			catch { }
			
			try
			{
				r[Field_Gioitinh]=_NhanvienEntity.Gioitinh;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysinh]=_NhanvienEntity.Ngaysinh;
			}
			catch { }
			
			try
			{
				r[Field_Diachi]=_NhanvienEntity.Diachi;
			}
			catch { }
			
			try
			{
				r[Field_Sodienthoai]=_NhanvienEntity.Sodienthoai;
			}
			catch { }
			
			try
			{
				r[Field_Email]=_NhanvienEntity.Email;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public NhanvienEntity Convert(DataRow r)
		{	
			
			NhanvienEntity _NhanvienEntity=new NhanvienEntity(r[Field_Manhanvien].ToString());					
						
			
			
			try
			{
				_NhanvienEntity.Hoten= r[Field_Hoten].ToString();						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Maphongban= r[Field_Maphongban].ToString();						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Tenphongban= r[Field_Tenphongban].ToString();						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Machucvu= r[Field_Machucvu].ToString();						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Tenchucvu= r[Field_Tenchucvu].ToString();						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Gioitinh= System.Boolean.Parse(r[Field_Gioitinh].ToString());						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Ngaysinh= System.DateTime.Parse(r[Field_Ngaysinh].ToString());						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Diachi= r[Field_Diachi].ToString();						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Sodienthoai= r[Field_Sodienthoai].ToString();						
			}
			catch { }
			
			try
			{
				_NhanvienEntity.Email= r[Field_Email].ToString();						
			}
			catch { }
									
									
			return _NhanvienEntity;
		}			
		
		public NhanvienEntity Convert_Entity(NhanvienEntity _NhanvienEntity,NhanvienEntity _NhanvienEntity_XML)
		{	
			
			
			_NhanvienEntity.Manhanvien= _NhanvienEntity_XML.Manhanvien;
			
			_NhanvienEntity.Hoten= _NhanvienEntity_XML.Hoten;
			
			_NhanvienEntity.Maphongban= _NhanvienEntity_XML.Maphongban;
			
			_NhanvienEntity.Tenphongban= _NhanvienEntity_XML.Tenphongban;
			
			_NhanvienEntity.Machucvu= _NhanvienEntity_XML.Machucvu;
			
			_NhanvienEntity.Tenchucvu= _NhanvienEntity_XML.Tenchucvu;
			
			_NhanvienEntity.Gioitinh= _NhanvienEntity_XML.Gioitinh;
			
			_NhanvienEntity.Ngaysinh= _NhanvienEntity_XML.Ngaysinh;
			
			_NhanvienEntity.Diachi= _NhanvienEntity_XML.Diachi;
			
			_NhanvienEntity.Sodienthoai= _NhanvienEntity_XML.Sodienthoai;
			
			_NhanvienEntity.Email= _NhanvienEntity_XML.Email;
									
				
			return _NhanvienEntity;
		}	
		
		public String InsertV2(NhanvienEntity _NhanvienEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new NhanvienManagerBase()).Insert(_NhanvienEntity).Manhanvien.ToString();
			
			
			try
			{
				r.SetField(Field_Manhanvien,_NhanvienEntity.Manhanvien);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Hoten,_NhanvienEntity.Hoten);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maphongban,_NhanvienEntity.Maphongban);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenphongban,_NhanvienEntity.Tenphongban);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Machucvu,_NhanvienEntity.Machucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenchucvu,_NhanvienEntity.Tenchucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Gioitinh,_NhanvienEntity.Gioitinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysinh,_NhanvienEntity.Ngaysinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachi,_NhanvienEntity.Diachi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoai,_NhanvienEntity.Sodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Email,_NhanvienEntity.Email);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(NhanvienEntity _NhanvienEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new NhanvienManagerBase()).Update(_NhanvienEntity);
			r.SetField(Field_Manhanvien,_NhanvienEntity.Manhanvien);
									
			
			
			
			try
			{
				r.SetField(Field_Hoten,_NhanvienEntity.Hoten);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maphongban,_NhanvienEntity.Maphongban);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenphongban,_NhanvienEntity.Tenphongban);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Machucvu,_NhanvienEntity.Machucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenchucvu,_NhanvienEntity.Tenchucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Gioitinh,_NhanvienEntity.Gioitinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysinh,_NhanvienEntity.Ngaysinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachi,_NhanvienEntity.Diachi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoai,_NhanvienEntity.Sodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Email,_NhanvienEntity.Email);
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

		public NhanvienEntity Insert(NhanvienEntity NhanvienEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(NhanvienEntity, true);
			}
			return NhanvienEntity;
		}

		public NhanvienEntity Insert(System.String  Manhanvien, System.String  Hoten, System.String  Maphongban, System.String  Tenphongban, System.String  Machucvu, System.String  Tenchucvu, System.Boolean  Gioitinh, System.DateTime  Ngaysinh, System.String  Diachi, System.String  Sodienthoai, System.String  Email)
		{
			NhanvienEntity _NhanvienEntity = new NhanvienEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NhanvienEntity.Manhanvien = Manhanvien;
				
				_NhanvienEntity.Hoten = Hoten;
				
				_NhanvienEntity.Maphongban = Maphongban;
				
				_NhanvienEntity.Tenphongban = Tenphongban;
				
				_NhanvienEntity.Machucvu = Machucvu;
				
				_NhanvienEntity.Tenchucvu = Tenchucvu;
				
				_NhanvienEntity.Gioitinh = Gioitinh;
				
				_NhanvienEntity.Ngaysinh = Ngaysinh;
				
				_NhanvienEntity.Diachi = Diachi;
				
				_NhanvienEntity.Sodienthoai = Sodienthoai;
				
				_NhanvienEntity.Email = Email;
					
					
				adapter.SaveEntity(_NhanvienEntity, true);
			}
			return _NhanvienEntity;
		}

		public NhanvienEntity Insert(System.String Hoten, System.String Maphongban, System.String Tenphongban, System.String Machucvu, System.String Tenchucvu, System.Boolean Gioitinh, System.DateTime Ngaysinh, System.String Diachi, System.String Sodienthoai, System.String Email)//ko co mahieu
		{
			NhanvienEntity _NhanvienEntity = new NhanvienEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_NhanvienEntity.Hoten = Hoten;
				
				_NhanvienEntity.Maphongban = Maphongban;
				
				_NhanvienEntity.Tenphongban = Tenphongban;
				
				_NhanvienEntity.Machucvu = Machucvu;
				
				_NhanvienEntity.Tenchucvu = Tenchucvu;
				
				_NhanvienEntity.Gioitinh = Gioitinh;
				
				_NhanvienEntity.Ngaysinh = Ngaysinh;
				
				_NhanvienEntity.Diachi = Diachi;
				
				_NhanvienEntity.Sodienthoai = Sodienthoai;
				
				_NhanvienEntity.Email = Email;
					

				adapter.SaveEntity(_NhanvienEntity, true);
			}
			return _NhanvienEntity;
		}

		public bool Update(NhanvienEntity _NhanvienEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(NhanvienFields.Manhanvien == _NhanvienEntity.Manhanvien);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NhanvienEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NhanvienEntity _NhanvienEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NhanvienEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Manhanvien, System.String Hoten, System.String Maphongban, System.String Tenphongban, System.String Machucvu, System.String Tenchucvu, System.Boolean Gioitinh, System.DateTime Ngaysinh, System.String Diachi, System.String Sodienthoai, System.String Email)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhanvienEntity _NhanvienEntity = new NhanvienEntity(Manhanvien);
				if (adapter.FetchEntity(_NhanvienEntity))
				{
				
					
					
					_NhanvienEntity.Hoten = Hoten;
					
					_NhanvienEntity.Maphongban = Maphongban;
					
					_NhanvienEntity.Tenphongban = Tenphongban;
					
					_NhanvienEntity.Machucvu = Machucvu;
					
					_NhanvienEntity.Tenchucvu = Tenchucvu;
					
					_NhanvienEntity.Gioitinh = Gioitinh;
					
					_NhanvienEntity.Ngaysinh = Ngaysinh;
					
					_NhanvienEntity.Diachi = Diachi;
					
					_NhanvienEntity.Sodienthoai = Sodienthoai;
					
					_NhanvienEntity.Email = Email;
						

					adapter.SaveEntity(_NhanvienEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Manhanvien)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhanvienEntity _NhanvienEntity = new NhanvienEntity(Manhanvien);
				if (adapter.FetchEntity(_NhanvienEntity))
				{
					adapter.DeleteEntity(_NhanvienEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NhanvienEntity", null);
			}
		}
		
		
		
		public int DeleteByManhanvien(System.String Manhanvien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Manhanvien == Manhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHoten(System.String Hoten)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Hoten == Hoten);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaphongban(System.String Maphongban)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Maphongban == Maphongban);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenphongban(System.String Tenphongban)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Tenphongban == Tenphongban);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMachucvu(System.String Machucvu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Machucvu == Machucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenchucvu(System.String Tenchucvu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGioitinh(System.Boolean Gioitinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Gioitinh == Gioitinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysinh(System.DateTime Ngaysinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Ngaysinh == Ngaysinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDiachi(System.String Diachi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySodienthoai(System.String Sodienthoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByEmail(System.String Email)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhanvienEntity", filter);
			}
			return toReturn;
		}		
			
		
		public NhanvienEntity SelectOne(System.String Manhanvien)
		{
			NhanvienEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhanvienEntity _NhanvienEntity = new NhanvienEntity(Manhanvien);
				if (adapter.FetchEntity(_NhanvienEntity))
				{
					toReturn = _NhanvienEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _NhanvienCollection = new EntityCollection( new NhanvienEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, null, 0, null);
			}
			return _NhanvienCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByManhanvien(System.String Manhanvien)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Manhanvien == Manhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByManhanvienRDT(System.String Manhanvien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Manhanvien == Manhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHoten(System.String Hoten)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Hoten == Hoten);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByHotenRDT(System.String Hoten)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Hoten == Hoten);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaphongban(System.String Maphongban)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Maphongban == Maphongban);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByMaphongbanRDT(System.String Maphongban)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Maphongban == Maphongban);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenphongban(System.String Tenphongban)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Tenphongban == Tenphongban);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByTenphongbanRDT(System.String Tenphongban)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Tenphongban == Tenphongban);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMachucvu(System.String Machucvu)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Machucvu == Machucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByMachucvuRDT(System.String Machucvu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Machucvu == Machucvu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenchucvu(System.String Tenchucvu)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByTenchucvuRDT(System.String Tenchucvu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGioitinh(System.Boolean Gioitinh)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Gioitinh == Gioitinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByGioitinhRDT(System.Boolean Gioitinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Gioitinh == Gioitinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysinh(System.DateTime Ngaysinh)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Ngaysinh == Ngaysinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysinhRDT(System.DateTime Ngaysinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Ngaysinh == Ngaysinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDiachi(System.String Diachi)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByDiachiRDT(System.String Diachi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySodienthoai(System.String Sodienthoai)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectBySodienthoaiRDT(System.String Sodienthoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByEmail(System.String Email)
		{
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhanvienCollection, filter, 0, null);
			}
			return _NhanvienCollection;
		}
		// Return DataTable
		public DataTable SelectByEmailRDT(System.String Email)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhanvienCollection = new EntityCollection(new NhanvienEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhanvienFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhanvienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
