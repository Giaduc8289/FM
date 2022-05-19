


/*
'===============================================================================
'  GD.FM.BL.DanhmuckhachManagerBase
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
	public class DanhmuckhachManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mahieu="Mahieu";				
		
		public const String Field_Tenhieu="Tenhieu";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
		public const String Field_Diachi="Diachi";				
		
		public const String Field_Sodienthoai="Sodienthoai";				
		
		public const String Field_Sofax="Sofax";				
		
		public const String Field_Masothue="Masothue";				
		
		public const String Field_Taikhoannganhang="Taikhoannganhang";				
		
		public const String Field_Tennganhang="Tennganhang";				
		
		public const String Field_Email="Email";				
		
		public const String Field_Noidia="Noidia";				
		
		public const String Field_Truyenthong="Truyenthong";				
		
		public const String Field_Nguoilienhehoten="Nguoilienhehoten";				
		
		public const String Field_Nguoilienhechucvu="Nguoilienhechucvu";				
		
		public const String Field_Nguoilienhesodienthoai="Nguoilienhesodienthoai";				
		
		public const String Field_Nguoilienhethongtinbosung="Nguoilienhethongtinbosung";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Manhanvien="Manhanvien";				
		
		public const String Field_Tennhanvien="Tennhanvien";				
		
		public const String Field_Macode="Macode";				
		
		public const String Field_Mafiller="Mafiller";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DanhmuckhachManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mahieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenhieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
			
			dt.Columns.Add(Field_Diachi,typeof(System.String));
			
			dt.Columns.Add(Field_Sodienthoai,typeof(System.String));
			
			dt.Columns.Add(Field_Sofax,typeof(System.String));
			
			dt.Columns.Add(Field_Masothue,typeof(System.String));
			
			dt.Columns.Add(Field_Taikhoannganhang,typeof(System.String));
			
			dt.Columns.Add(Field_Tennganhang,typeof(System.String));
			
			dt.Columns.Add(Field_Email,typeof(System.String));
			
			dt.Columns.Add(Field_Noidia,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Truyenthong,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Nguoilienhehoten,typeof(System.String));
			
			dt.Columns.Add(Field_Nguoilienhechucvu,typeof(System.String));
			
			dt.Columns.Add(Field_Nguoilienhesodienthoai,typeof(System.String));
			
			dt.Columns.Add(Field_Nguoilienhethongtinbosung,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Manhanvien,typeof(System.String));
			
			dt.Columns.Add(Field_Tennhanvien,typeof(System.String));
			
			dt.Columns.Add(Field_Macode,typeof(System.String));
			
			dt.Columns.Add(Field_Mafiller,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DanhmuckhachEntity _DanhmuckhachEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mahieu]=_DanhmuckhachEntity.Mahieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenhieu]=_DanhmuckhachEntity.Tenhieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DanhmuckhachEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Diachi]=_DanhmuckhachEntity.Diachi;
			}
			catch { }
			
			try
			{
				r[Field_Sodienthoai]=_DanhmuckhachEntity.Sodienthoai;
			}
			catch { }
			
			try
			{
				r[Field_Sofax]=_DanhmuckhachEntity.Sofax;
			}
			catch { }
			
			try
			{
				r[Field_Masothue]=_DanhmuckhachEntity.Masothue;
			}
			catch { }
			
			try
			{
				r[Field_Taikhoannganhang]=_DanhmuckhachEntity.Taikhoannganhang;
			}
			catch { }
			
			try
			{
				r[Field_Tennganhang]=_DanhmuckhachEntity.Tennganhang;
			}
			catch { }
			
			try
			{
				r[Field_Email]=_DanhmuckhachEntity.Email;
			}
			catch { }
			
			try
			{
				r[Field_Noidia]=_DanhmuckhachEntity.Noidia;
			}
			catch { }
			
			try
			{
				r[Field_Truyenthong]=_DanhmuckhachEntity.Truyenthong;
			}
			catch { }
			
			try
			{
				r[Field_Nguoilienhehoten]=_DanhmuckhachEntity.Nguoilienhehoten;
			}
			catch { }
			
			try
			{
				r[Field_Nguoilienhechucvu]=_DanhmuckhachEntity.Nguoilienhechucvu;
			}
			catch { }
			
			try
			{
				r[Field_Nguoilienhesodienthoai]=_DanhmuckhachEntity.Nguoilienhesodienthoai;
			}
			catch { }
			
			try
			{
				r[Field_Nguoilienhethongtinbosung]=_DanhmuckhachEntity.Nguoilienhethongtinbosung;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DanhmuckhachEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DanhmuckhachEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DanhmuckhachEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DanhmuckhachEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Manhanvien]=_DanhmuckhachEntity.Manhanvien;
			}
			catch { }
			
			try
			{
				r[Field_Tennhanvien]=_DanhmuckhachEntity.Tennhanvien;
			}
			catch { }
			
			try
			{
				r[Field_Macode]=_DanhmuckhachEntity.Macode;
			}
			catch { }
			
			try
			{
				r[Field_Mafiller]=_DanhmuckhachEntity.Mafiller;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DanhmuckhachEntity Convert(DataRow r)
		{	
			
			DanhmuckhachEntity _DanhmuckhachEntity=new DanhmuckhachEntity(r[Field_Mahieu].ToString());					
						
			
			
			try
			{
				_DanhmuckhachEntity.Tenhieu= r[Field_Tenhieu].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Diachi= r[Field_Diachi].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Sodienthoai= r[Field_Sodienthoai].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Sofax= r[Field_Sofax].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Masothue= r[Field_Masothue].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Taikhoannganhang= r[Field_Taikhoannganhang].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Tennganhang= r[Field_Tennganhang].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Email= r[Field_Email].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Noidia= System.Boolean.Parse(r[Field_Noidia].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Truyenthong= System.Boolean.Parse(r[Field_Truyenthong].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Nguoilienhehoten= r[Field_Nguoilienhehoten].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Nguoilienhechucvu= r[Field_Nguoilienhechucvu].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Nguoilienhesodienthoai= r[Field_Nguoilienhesodienthoai].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Nguoilienhethongtinbosung= r[Field_Nguoilienhethongtinbosung].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Manhanvien= r[Field_Manhanvien].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Tennhanvien= r[Field_Tennhanvien].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Macode= r[Field_Macode].ToString();						
			}
			catch { }
			
			try
			{
				_DanhmuckhachEntity.Mafiller= r[Field_Mafiller].ToString();						
			}
			catch { }
									
									
			return _DanhmuckhachEntity;
		}			
		
		public DanhmuckhachEntity Convert_Entity(DanhmuckhachEntity _DanhmuckhachEntity,DanhmuckhachEntity _DanhmuckhachEntity_XML)
		{	
			
			
			_DanhmuckhachEntity.Mahieu= _DanhmuckhachEntity_XML.Mahieu;
			
			_DanhmuckhachEntity.Tenhieu= _DanhmuckhachEntity_XML.Tenhieu;
			
			_DanhmuckhachEntity.Tenrutgon= _DanhmuckhachEntity_XML.Tenrutgon;
			
			_DanhmuckhachEntity.Diachi= _DanhmuckhachEntity_XML.Diachi;
			
			_DanhmuckhachEntity.Sodienthoai= _DanhmuckhachEntity_XML.Sodienthoai;
			
			_DanhmuckhachEntity.Sofax= _DanhmuckhachEntity_XML.Sofax;
			
			_DanhmuckhachEntity.Masothue= _DanhmuckhachEntity_XML.Masothue;
			
			_DanhmuckhachEntity.Taikhoannganhang= _DanhmuckhachEntity_XML.Taikhoannganhang;
			
			_DanhmuckhachEntity.Tennganhang= _DanhmuckhachEntity_XML.Tennganhang;
			
			_DanhmuckhachEntity.Email= _DanhmuckhachEntity_XML.Email;
			
			_DanhmuckhachEntity.Noidia= _DanhmuckhachEntity_XML.Noidia;
			
			_DanhmuckhachEntity.Truyenthong= _DanhmuckhachEntity_XML.Truyenthong;
			
			_DanhmuckhachEntity.Nguoilienhehoten= _DanhmuckhachEntity_XML.Nguoilienhehoten;
			
			_DanhmuckhachEntity.Nguoilienhechucvu= _DanhmuckhachEntity_XML.Nguoilienhechucvu;
			
			_DanhmuckhachEntity.Nguoilienhesodienthoai= _DanhmuckhachEntity_XML.Nguoilienhesodienthoai;
			
			_DanhmuckhachEntity.Nguoilienhethongtinbosung= _DanhmuckhachEntity_XML.Nguoilienhethongtinbosung;
			
			_DanhmuckhachEntity.Ngaytao= _DanhmuckhachEntity_XML.Ngaytao;
			
			_DanhmuckhachEntity.Nguoitao= _DanhmuckhachEntity_XML.Nguoitao;
			
			_DanhmuckhachEntity.Ngaysua= _DanhmuckhachEntity_XML.Ngaysua;
			
			_DanhmuckhachEntity.Nguoisua= _DanhmuckhachEntity_XML.Nguoisua;
			
			_DanhmuckhachEntity.Manhanvien= _DanhmuckhachEntity_XML.Manhanvien;
			
			_DanhmuckhachEntity.Tennhanvien= _DanhmuckhachEntity_XML.Tennhanvien;
			
			_DanhmuckhachEntity.Macode= _DanhmuckhachEntity_XML.Macode;
			
			_DanhmuckhachEntity.Mafiller= _DanhmuckhachEntity_XML.Mafiller;
									
				
			return _DanhmuckhachEntity;
		}	
		
		public String InsertV2(DanhmuckhachEntity _DanhmuckhachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DanhmuckhachManagerBase()).Insert(_DanhmuckhachEntity).Mahieu.ToString();
			
			
			try
			{
				r.SetField(Field_Mahieu,_DanhmuckhachEntity.Mahieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_DanhmuckhachEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DanhmuckhachEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachi,_DanhmuckhachEntity.Diachi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoai,_DanhmuckhachEntity.Sodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sofax,_DanhmuckhachEntity.Sofax);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masothue,_DanhmuckhachEntity.Masothue);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Taikhoannganhang,_DanhmuckhachEntity.Taikhoannganhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennganhang,_DanhmuckhachEntity.Tennganhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Email,_DanhmuckhachEntity.Email);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Noidia,_DanhmuckhachEntity.Noidia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Truyenthong,_DanhmuckhachEntity.Truyenthong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoilienhehoten,_DanhmuckhachEntity.Nguoilienhehoten);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoilienhechucvu,_DanhmuckhachEntity.Nguoilienhechucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoilienhesodienthoai,_DanhmuckhachEntity.Nguoilienhesodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoilienhethongtinbosung,_DanhmuckhachEntity.Nguoilienhethongtinbosung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmuckhachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmuckhachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmuckhachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmuckhachEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhanvien,_DanhmuckhachEntity.Manhanvien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhanvien,_DanhmuckhachEntity.Tennhanvien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macode,_DanhmuckhachEntity.Macode);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mafiller,_DanhmuckhachEntity.Mafiller);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DanhmuckhachEntity _DanhmuckhachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DanhmuckhachManagerBase()).Update(_DanhmuckhachEntity);
			r.SetField(Field_Mahieu,_DanhmuckhachEntity.Mahieu);
									
			
			
			
			try
			{
				r.SetField(Field_Tenhieu,_DanhmuckhachEntity.Tenhieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DanhmuckhachEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachi,_DanhmuckhachEntity.Diachi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoai,_DanhmuckhachEntity.Sodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sofax,_DanhmuckhachEntity.Sofax);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masothue,_DanhmuckhachEntity.Masothue);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Taikhoannganhang,_DanhmuckhachEntity.Taikhoannganhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennganhang,_DanhmuckhachEntity.Tennganhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Email,_DanhmuckhachEntity.Email);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Noidia,_DanhmuckhachEntity.Noidia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Truyenthong,_DanhmuckhachEntity.Truyenthong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoilienhehoten,_DanhmuckhachEntity.Nguoilienhehoten);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoilienhechucvu,_DanhmuckhachEntity.Nguoilienhechucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoilienhesodienthoai,_DanhmuckhachEntity.Nguoilienhesodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoilienhethongtinbosung,_DanhmuckhachEntity.Nguoilienhethongtinbosung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DanhmuckhachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DanhmuckhachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DanhmuckhachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DanhmuckhachEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhanvien,_DanhmuckhachEntity.Manhanvien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhanvien,_DanhmuckhachEntity.Tennhanvien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macode,_DanhmuckhachEntity.Macode);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mafiller,_DanhmuckhachEntity.Mafiller);
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

		public DanhmuckhachEntity Insert(DanhmuckhachEntity DanhmuckhachEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DanhmuckhachEntity, true);
			}
			return DanhmuckhachEntity;
		}

		public DanhmuckhachEntity Insert(System.String  Mahieu, System.String  Tenhieu, System.String  Tenrutgon, System.String  Diachi, System.String  Sodienthoai, System.String  Sofax, System.String  Masothue, System.String  Taikhoannganhang, System.String  Tennganhang, System.String  Email, System.Boolean  Noidia, System.Boolean  Truyenthong, System.String  Nguoilienhehoten, System.String  Nguoilienhechucvu, System.String  Nguoilienhesodienthoai, System.String  Nguoilienhethongtinbosung, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.String  Manhanvien, System.String  Tennhanvien, System.String  Macode, System.String  Mafiller)
		{
			DanhmuckhachEntity _DanhmuckhachEntity = new DanhmuckhachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DanhmuckhachEntity.Mahieu = Mahieu;
				
				_DanhmuckhachEntity.Tenhieu = Tenhieu;
				
				_DanhmuckhachEntity.Tenrutgon = Tenrutgon;
				
				_DanhmuckhachEntity.Diachi = Diachi;
				
				_DanhmuckhachEntity.Sodienthoai = Sodienthoai;
				
				_DanhmuckhachEntity.Sofax = Sofax;
				
				_DanhmuckhachEntity.Masothue = Masothue;
				
				_DanhmuckhachEntity.Taikhoannganhang = Taikhoannganhang;
				
				_DanhmuckhachEntity.Tennganhang = Tennganhang;
				
				_DanhmuckhachEntity.Email = Email;
				
				_DanhmuckhachEntity.Noidia = Noidia;
				
				_DanhmuckhachEntity.Truyenthong = Truyenthong;
				
				_DanhmuckhachEntity.Nguoilienhehoten = Nguoilienhehoten;
				
				_DanhmuckhachEntity.Nguoilienhechucvu = Nguoilienhechucvu;
				
				_DanhmuckhachEntity.Nguoilienhesodienthoai = Nguoilienhesodienthoai;
				
				_DanhmuckhachEntity.Nguoilienhethongtinbosung = Nguoilienhethongtinbosung;
				
				_DanhmuckhachEntity.Ngaytao = Ngaytao;
				
				_DanhmuckhachEntity.Nguoitao = Nguoitao;
				
				_DanhmuckhachEntity.Ngaysua = Ngaysua;
				
				_DanhmuckhachEntity.Nguoisua = Nguoisua;
				
				_DanhmuckhachEntity.Manhanvien = Manhanvien;
				
				_DanhmuckhachEntity.Tennhanvien = Tennhanvien;
				
				_DanhmuckhachEntity.Macode = Macode;
				
				_DanhmuckhachEntity.Mafiller = Mafiller;
					
					
				adapter.SaveEntity(_DanhmuckhachEntity, true);
			}
			return _DanhmuckhachEntity;
		}

		public DanhmuckhachEntity Insert(System.String Tenhieu, System.String Tenrutgon, System.String Diachi, System.String Sodienthoai, System.String Sofax, System.String Masothue, System.String Taikhoannganhang, System.String Tennganhang, System.String Email, System.Boolean Noidia, System.Boolean Truyenthong, System.String Nguoilienhehoten, System.String Nguoilienhechucvu, System.String Nguoilienhesodienthoai, System.String Nguoilienhethongtinbosung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Manhanvien, System.String Tennhanvien, System.String Macode, System.String Mafiller)//ko co mahieu
		{
			DanhmuckhachEntity _DanhmuckhachEntity = new DanhmuckhachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DanhmuckhachEntity.Tenhieu = Tenhieu;
				
				_DanhmuckhachEntity.Tenrutgon = Tenrutgon;
				
				_DanhmuckhachEntity.Diachi = Diachi;
				
				_DanhmuckhachEntity.Sodienthoai = Sodienthoai;
				
				_DanhmuckhachEntity.Sofax = Sofax;
				
				_DanhmuckhachEntity.Masothue = Masothue;
				
				_DanhmuckhachEntity.Taikhoannganhang = Taikhoannganhang;
				
				_DanhmuckhachEntity.Tennganhang = Tennganhang;
				
				_DanhmuckhachEntity.Email = Email;
				
				_DanhmuckhachEntity.Noidia = Noidia;
				
				_DanhmuckhachEntity.Truyenthong = Truyenthong;
				
				_DanhmuckhachEntity.Nguoilienhehoten = Nguoilienhehoten;
				
				_DanhmuckhachEntity.Nguoilienhechucvu = Nguoilienhechucvu;
				
				_DanhmuckhachEntity.Nguoilienhesodienthoai = Nguoilienhesodienthoai;
				
				_DanhmuckhachEntity.Nguoilienhethongtinbosung = Nguoilienhethongtinbosung;
				
				_DanhmuckhachEntity.Ngaytao = Ngaytao;
				
				_DanhmuckhachEntity.Nguoitao = Nguoitao;
				
				_DanhmuckhachEntity.Ngaysua = Ngaysua;
				
				_DanhmuckhachEntity.Nguoisua = Nguoisua;
				
				_DanhmuckhachEntity.Manhanvien = Manhanvien;
				
				_DanhmuckhachEntity.Tennhanvien = Tennhanvien;
				
				_DanhmuckhachEntity.Macode = Macode;
				
				_DanhmuckhachEntity.Mafiller = Mafiller;
					

				adapter.SaveEntity(_DanhmuckhachEntity, true);
			}
			return _DanhmuckhachEntity;
		}

		public bool Update(DanhmuckhachEntity _DanhmuckhachEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DanhmuckhachFields.Mahieu == _DanhmuckhachEntity.Mahieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DanhmuckhachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DanhmuckhachEntity _DanhmuckhachEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DanhmuckhachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mahieu, System.String Tenhieu, System.String Tenrutgon, System.String Diachi, System.String Sodienthoai, System.String Sofax, System.String Masothue, System.String Taikhoannganhang, System.String Tennganhang, System.String Email, System.Boolean Noidia, System.Boolean Truyenthong, System.String Nguoilienhehoten, System.String Nguoilienhechucvu, System.String Nguoilienhesodienthoai, System.String Nguoilienhethongtinbosung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Manhanvien, System.String Tennhanvien, System.String Macode, System.String Mafiller)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmuckhachEntity _DanhmuckhachEntity = new DanhmuckhachEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmuckhachEntity))
				{
				
					
					
					_DanhmuckhachEntity.Tenhieu = Tenhieu;
					
					_DanhmuckhachEntity.Tenrutgon = Tenrutgon;
					
					_DanhmuckhachEntity.Diachi = Diachi;
					
					_DanhmuckhachEntity.Sodienthoai = Sodienthoai;
					
					_DanhmuckhachEntity.Sofax = Sofax;
					
					_DanhmuckhachEntity.Masothue = Masothue;
					
					_DanhmuckhachEntity.Taikhoannganhang = Taikhoannganhang;
					
					_DanhmuckhachEntity.Tennganhang = Tennganhang;
					
					_DanhmuckhachEntity.Email = Email;
					
					_DanhmuckhachEntity.Noidia = Noidia;
					
					_DanhmuckhachEntity.Truyenthong = Truyenthong;
					
					_DanhmuckhachEntity.Nguoilienhehoten = Nguoilienhehoten;
					
					_DanhmuckhachEntity.Nguoilienhechucvu = Nguoilienhechucvu;
					
					_DanhmuckhachEntity.Nguoilienhesodienthoai = Nguoilienhesodienthoai;
					
					_DanhmuckhachEntity.Nguoilienhethongtinbosung = Nguoilienhethongtinbosung;
					
					_DanhmuckhachEntity.Ngaytao = Ngaytao;
					
					_DanhmuckhachEntity.Nguoitao = Nguoitao;
					
					_DanhmuckhachEntity.Ngaysua = Ngaysua;
					
					_DanhmuckhachEntity.Nguoisua = Nguoisua;
					
					_DanhmuckhachEntity.Manhanvien = Manhanvien;
					
					_DanhmuckhachEntity.Tennhanvien = Tennhanvien;
					
					_DanhmuckhachEntity.Macode = Macode;
					
					_DanhmuckhachEntity.Mafiller = Mafiller;
						

					adapter.SaveEntity(_DanhmuckhachEntity, true);
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
				DanhmuckhachEntity _DanhmuckhachEntity = new DanhmuckhachEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmuckhachEntity))
				{
					adapter.DeleteEntity(_DanhmuckhachEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", null);
			}
		}
		
		
		
		public int DeleteByMahieu(System.String Mahieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhieu(System.String Tenhieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDiachi(System.String Diachi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySodienthoai(System.String Sodienthoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySofax(System.String Sofax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Sofax == Sofax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasothue(System.String Masothue)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Masothue == Masothue);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTaikhoannganhang(System.String Taikhoannganhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Taikhoannganhang == Taikhoannganhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennganhang(System.String Tennganhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tennganhang == Tennganhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByEmail(System.String Email)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNoidia(System.Boolean Noidia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Noidia == Noidia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTruyenthong(System.Boolean Truyenthong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Truyenthong == Truyenthong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoilienhehoten(System.String Nguoilienhehoten)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhehoten == Nguoilienhehoten);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoilienhechucvu(System.String Nguoilienhechucvu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhechucvu == Nguoilienhechucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoilienhesodienthoai(System.String Nguoilienhesodienthoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhesodienthoai == Nguoilienhesodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoilienhethongtinbosung(System.String Nguoilienhethongtinbosung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhethongtinbosung == Nguoilienhethongtinbosung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManhanvien(System.String Manhanvien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Manhanvien == Manhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhanvien(System.String Tennhanvien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tennhanvien == Tennhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacode(System.String Macode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Macode == Macode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMafiller(System.String Mafiller)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Mafiller == Mafiller);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DanhmuckhachEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DanhmuckhachEntity SelectOne(System.String Mahieu)
		{
			DanhmuckhachEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DanhmuckhachEntity _DanhmuckhachEntity = new DanhmuckhachEntity(Mahieu);
				if (adapter.FetchEntity(_DanhmuckhachEntity))
				{
					toReturn = _DanhmuckhachEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection( new DanhmuckhachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, null, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMahieu(System.String Mahieu)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByMahieuRDT(System.String Mahieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Mahieu == Mahieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhieu(System.String Tenhieu)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhieuRDT(System.String Tenhieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tenhieu == Tenhieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDiachi(System.String Diachi)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByDiachiRDT(System.String Diachi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySodienthoai(System.String Sodienthoai)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectBySodienthoaiRDT(System.String Sodienthoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySofax(System.String Sofax)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Sofax == Sofax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectBySofaxRDT(System.String Sofax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Sofax == Sofax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasothue(System.String Masothue)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Masothue == Masothue);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByMasothueRDT(System.String Masothue)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Masothue == Masothue);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTaikhoannganhang(System.String Taikhoannganhang)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Taikhoannganhang == Taikhoannganhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTaikhoannganhangRDT(System.String Taikhoannganhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Taikhoannganhang == Taikhoannganhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennganhang(System.String Tennganhang)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tennganhang == Tennganhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTennganhangRDT(System.String Tennganhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tennganhang == Tennganhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByEmail(System.String Email)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByEmailRDT(System.String Email)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNoidia(System.Boolean Noidia)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Noidia == Noidia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNoidiaRDT(System.Boolean Noidia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Noidia == Noidia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTruyenthong(System.Boolean Truyenthong)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Truyenthong == Truyenthong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTruyenthongRDT(System.Boolean Truyenthong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Truyenthong == Truyenthong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoilienhehoten(System.String Nguoilienhehoten)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhehoten == Nguoilienhehoten);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoilienhehotenRDT(System.String Nguoilienhehoten)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhehoten == Nguoilienhehoten);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoilienhechucvu(System.String Nguoilienhechucvu)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhechucvu == Nguoilienhechucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoilienhechucvuRDT(System.String Nguoilienhechucvu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhechucvu == Nguoilienhechucvu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoilienhesodienthoai(System.String Nguoilienhesodienthoai)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhesodienthoai == Nguoilienhesodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoilienhesodienthoaiRDT(System.String Nguoilienhesodienthoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhesodienthoai == Nguoilienhesodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoilienhethongtinbosung(System.String Nguoilienhethongtinbosung)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhethongtinbosung == Nguoilienhethongtinbosung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoilienhethongtinbosungRDT(System.String Nguoilienhethongtinbosung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoilienhethongtinbosung == Nguoilienhethongtinbosung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManhanvien(System.String Manhanvien)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Manhanvien == Manhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByManhanvienRDT(System.String Manhanvien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Manhanvien == Manhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhanvien(System.String Tennhanvien)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tennhanvien == Tennhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhanvienRDT(System.String Tennhanvien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Tennhanvien == Tennhanvien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacode(System.String Macode)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Macode == Macode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByMacodeRDT(System.String Macode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Macode == Macode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMafiller(System.String Mafiller)
		{
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Mafiller == Mafiller);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DanhmuckhachCollection, filter, 0, null);
			}
			return _DanhmuckhachCollection;
		}
		// Return DataTable
		public DataTable SelectByMafillerRDT(System.String Mafiller)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DanhmuckhachCollection = new EntityCollection(new DanhmuckhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DanhmuckhachFields.Mafiller == Mafiller);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DanhmuckhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
