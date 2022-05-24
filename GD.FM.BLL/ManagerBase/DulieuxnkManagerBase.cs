


/*
'===============================================================================
'  GD.FM.BL.DulieuxnkManagerBase
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
	public class DulieuxnkManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Nam="Nam";				
		
		public const String Field_Thang="Thang";				
		
		public const String Field_Ngaythongquan="Ngaythongquan";				
		
		public const String Field_Masothuexuat="Masothuexuat";				
		
		public const String Field_Tencongtyxuat="Tencongtyxuat";				
		
		public const String Field_Diachicongtyxuat="Diachicongtyxuat";				
		
		public const String Field_Dienthoaicongtyxuat="Dienthoaicongtyxuat";				
		
		public const String Field_Tencongtynhap="Tencongtynhap";				
		
		public const String Field_Diachicongtynhap="Diachicongtynhap";				
		
		public const String Field_Hscode="Hscode";				
		
		public const String Field_Motahanghoa="Motahanghoa";				
		
		public const String Field_Thuexuat="Thuexuat";				
		
		public const String Field_Xuatxu="Xuatxu";				
		
		public const String Field_Madonvi="Madonvi";				
		
		public const String Field_Sotan="Sotan";				
		
		public const String Field_Giausd="Giausd";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Dongianguyente="Dongianguyente";				
		
		public const String Field_Dongiausd="Dongiausd";				
		
		public const String Field_Trigiausd="Trigiausd";				
		
		public const String Field_Tygiavnd="Tygiavnd";				
		
		public const String Field_Madongtien="Madongtien";				
		
		public const String Field_Dieukiengia="Dieukiengia";				
		
		public const String Field_Phuongthucthanhtoan="Phuongthucthanhtoan";				
		
		public const String Field_Chicuchaiquan="Chicuchaiquan";				
		
		public const String Field_Loaihinhxuatkhau="Loaihinhxuatkhau";				
		
		public const String Field_Tennuocxuatkhau="Tennuocxuatkhau";				
		
		public const String Field_Tennuocnhapkhau="Tennuocnhapkhau";				
		
		public const String Field_Diadiemxephang="Diadiemxephang";				
		
		public const String Field_Diadiemnhanhangcuoicung="Diadiemnhanhangcuoicung";				
		
		public const String Field_Sotokhai="Sotokhai";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DulieuxnkManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Nam,typeof(System.Int32));
			
			dt.Columns.Add(Field_Thang,typeof(System.Int32));
			
			dt.Columns.Add(Field_Ngaythongquan,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Masothuexuat,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongtyxuat,typeof(System.String));
			
			dt.Columns.Add(Field_Diachicongtyxuat,typeof(System.String));
			
			dt.Columns.Add(Field_Dienthoaicongtyxuat,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongtynhap,typeof(System.String));
			
			dt.Columns.Add(Field_Diachicongtynhap,typeof(System.String));
			
			dt.Columns.Add(Field_Hscode,typeof(System.String));
			
			dt.Columns.Add(Field_Motahanghoa,typeof(System.String));
			
			dt.Columns.Add(Field_Thuexuat,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Xuatxu,typeof(System.String));
			
			dt.Columns.Add(Field_Madonvi,typeof(System.String));
			
			dt.Columns.Add(Field_Sotan,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Giausd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dongianguyente,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dongiausd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Trigiausd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tygiavnd,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Madongtien,typeof(System.String));
			
			dt.Columns.Add(Field_Dieukiengia,typeof(System.String));
			
			dt.Columns.Add(Field_Phuongthucthanhtoan,typeof(System.String));
			
			dt.Columns.Add(Field_Chicuchaiquan,typeof(System.String));
			
			dt.Columns.Add(Field_Loaihinhxuatkhau,typeof(System.String));
			
			dt.Columns.Add(Field_Tennuocxuatkhau,typeof(System.String));
			
			dt.Columns.Add(Field_Tennuocnhapkhau,typeof(System.String));
			
			dt.Columns.Add(Field_Diadiemxephang,typeof(System.String));
			
			dt.Columns.Add(Field_Diadiemnhanhangcuoicung,typeof(System.String));
			
			dt.Columns.Add(Field_Sotokhai,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DulieuxnkEntity _DulieuxnkEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_DulieuxnkEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Nam]=_DulieuxnkEntity.Nam;
			}
			catch { }
			
			try
			{
				r[Field_Thang]=_DulieuxnkEntity.Thang;
			}
			catch { }
			
			try
			{
				r[Field_Ngaythongquan]=_DulieuxnkEntity.Ngaythongquan;
			}
			catch { }
			
			try
			{
				r[Field_Masothuexuat]=_DulieuxnkEntity.Masothuexuat;
			}
			catch { }
			
			try
			{
				r[Field_Tencongtyxuat]=_DulieuxnkEntity.Tencongtyxuat;
			}
			catch { }
			
			try
			{
				r[Field_Diachicongtyxuat]=_DulieuxnkEntity.Diachicongtyxuat;
			}
			catch { }
			
			try
			{
				r[Field_Dienthoaicongtyxuat]=_DulieuxnkEntity.Dienthoaicongtyxuat;
			}
			catch { }
			
			try
			{
				r[Field_Tencongtynhap]=_DulieuxnkEntity.Tencongtynhap;
			}
			catch { }
			
			try
			{
				r[Field_Diachicongtynhap]=_DulieuxnkEntity.Diachicongtynhap;
			}
			catch { }
			
			try
			{
				r[Field_Hscode]=_DulieuxnkEntity.Hscode;
			}
			catch { }
			
			try
			{
				r[Field_Motahanghoa]=_DulieuxnkEntity.Motahanghoa;
			}
			catch { }
			
			try
			{
				r[Field_Thuexuat]=_DulieuxnkEntity.Thuexuat;
			}
			catch { }
			
			try
			{
				r[Field_Xuatxu]=_DulieuxnkEntity.Xuatxu;
			}
			catch { }
			
			try
			{
				r[Field_Madonvi]=_DulieuxnkEntity.Madonvi;
			}
			catch { }
			
			try
			{
				r[Field_Sotan]=_DulieuxnkEntity.Sotan;
			}
			catch { }
			
			try
			{
				r[Field_Giausd]=_DulieuxnkEntity.Giausd;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_DulieuxnkEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Dongianguyente]=_DulieuxnkEntity.Dongianguyente;
			}
			catch { }
			
			try
			{
				r[Field_Dongiausd]=_DulieuxnkEntity.Dongiausd;
			}
			catch { }
			
			try
			{
				r[Field_Trigiausd]=_DulieuxnkEntity.Trigiausd;
			}
			catch { }
			
			try
			{
				r[Field_Tygiavnd]=_DulieuxnkEntity.Tygiavnd;
			}
			catch { }
			
			try
			{
				r[Field_Madongtien]=_DulieuxnkEntity.Madongtien;
			}
			catch { }
			
			try
			{
				r[Field_Dieukiengia]=_DulieuxnkEntity.Dieukiengia;
			}
			catch { }
			
			try
			{
				r[Field_Phuongthucthanhtoan]=_DulieuxnkEntity.Phuongthucthanhtoan;
			}
			catch { }
			
			try
			{
				r[Field_Chicuchaiquan]=_DulieuxnkEntity.Chicuchaiquan;
			}
			catch { }
			
			try
			{
				r[Field_Loaihinhxuatkhau]=_DulieuxnkEntity.Loaihinhxuatkhau;
			}
			catch { }
			
			try
			{
				r[Field_Tennuocxuatkhau]=_DulieuxnkEntity.Tennuocxuatkhau;
			}
			catch { }
			
			try
			{
				r[Field_Tennuocnhapkhau]=_DulieuxnkEntity.Tennuocnhapkhau;
			}
			catch { }
			
			try
			{
				r[Field_Diadiemxephang]=_DulieuxnkEntity.Diadiemxephang;
			}
			catch { }
			
			try
			{
				r[Field_Diadiemnhanhangcuoicung]=_DulieuxnkEntity.Diadiemnhanhangcuoicung;
			}
			catch { }
			
			try
			{
				r[Field_Sotokhai]=_DulieuxnkEntity.Sotokhai;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DulieuxnkEntity Convert(DataRow r)
		{	
			
			DulieuxnkEntity _DulieuxnkEntity=new DulieuxnkEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_DulieuxnkEntity.Nam= System.Int32.Parse(r[Field_Nam].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Thang= System.Int32.Parse(r[Field_Thang].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Ngaythongquan= System.DateTime.Parse(r[Field_Ngaythongquan].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Masothuexuat= r[Field_Masothuexuat].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Tencongtyxuat= r[Field_Tencongtyxuat].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Diachicongtyxuat= r[Field_Diachicongtyxuat].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Dienthoaicongtyxuat= r[Field_Dienthoaicongtyxuat].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Tencongtynhap= r[Field_Tencongtynhap].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Diachicongtynhap= r[Field_Diachicongtynhap].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Hscode= r[Field_Hscode].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Motahanghoa= r[Field_Motahanghoa].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Thuexuat= System.Decimal.Parse(r[Field_Thuexuat].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Xuatxu= r[Field_Xuatxu].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Madonvi= r[Field_Madonvi].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Sotan= System.Decimal.Parse(r[Field_Sotan].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Giausd= System.Decimal.Parse(r[Field_Giausd].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Dongianguyente= System.Decimal.Parse(r[Field_Dongianguyente].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Dongiausd= System.Decimal.Parse(r[Field_Dongiausd].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Trigiausd= System.Decimal.Parse(r[Field_Trigiausd].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Tygiavnd= System.Decimal.Parse(r[Field_Tygiavnd].ToString());						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Madongtien= r[Field_Madongtien].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Dieukiengia= r[Field_Dieukiengia].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Phuongthucthanhtoan= r[Field_Phuongthucthanhtoan].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Chicuchaiquan= r[Field_Chicuchaiquan].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Loaihinhxuatkhau= r[Field_Loaihinhxuatkhau].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Tennuocxuatkhau= r[Field_Tennuocxuatkhau].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Tennuocnhapkhau= r[Field_Tennuocnhapkhau].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Diadiemxephang= r[Field_Diadiemxephang].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Diadiemnhanhangcuoicung= r[Field_Diadiemnhanhangcuoicung].ToString();						
			}
			catch { }
			
			try
			{
				_DulieuxnkEntity.Sotokhai= r[Field_Sotokhai].ToString();						
			}
			catch { }
									
									
			return _DulieuxnkEntity;
		}			
		
		public DulieuxnkEntity Convert_Entity(DulieuxnkEntity _DulieuxnkEntity,DulieuxnkEntity _DulieuxnkEntity_XML)
		{	
			
			
			_DulieuxnkEntity.Id= _DulieuxnkEntity_XML.Id;
			
			_DulieuxnkEntity.Nam= _DulieuxnkEntity_XML.Nam;
			
			_DulieuxnkEntity.Thang= _DulieuxnkEntity_XML.Thang;
			
			_DulieuxnkEntity.Ngaythongquan= _DulieuxnkEntity_XML.Ngaythongquan;
			
			_DulieuxnkEntity.Masothuexuat= _DulieuxnkEntity_XML.Masothuexuat;
			
			_DulieuxnkEntity.Tencongtyxuat= _DulieuxnkEntity_XML.Tencongtyxuat;
			
			_DulieuxnkEntity.Diachicongtyxuat= _DulieuxnkEntity_XML.Diachicongtyxuat;
			
			_DulieuxnkEntity.Dienthoaicongtyxuat= _DulieuxnkEntity_XML.Dienthoaicongtyxuat;
			
			_DulieuxnkEntity.Tencongtynhap= _DulieuxnkEntity_XML.Tencongtynhap;
			
			_DulieuxnkEntity.Diachicongtynhap= _DulieuxnkEntity_XML.Diachicongtynhap;
			
			_DulieuxnkEntity.Hscode= _DulieuxnkEntity_XML.Hscode;
			
			_DulieuxnkEntity.Motahanghoa= _DulieuxnkEntity_XML.Motahanghoa;
			
			_DulieuxnkEntity.Thuexuat= _DulieuxnkEntity_XML.Thuexuat;
			
			_DulieuxnkEntity.Xuatxu= _DulieuxnkEntity_XML.Xuatxu;
			
			_DulieuxnkEntity.Madonvi= _DulieuxnkEntity_XML.Madonvi;
			
			_DulieuxnkEntity.Sotan= _DulieuxnkEntity_XML.Sotan;
			
			_DulieuxnkEntity.Giausd= _DulieuxnkEntity_XML.Giausd;
			
			_DulieuxnkEntity.Soluong= _DulieuxnkEntity_XML.Soluong;
			
			_DulieuxnkEntity.Dongianguyente= _DulieuxnkEntity_XML.Dongianguyente;
			
			_DulieuxnkEntity.Dongiausd= _DulieuxnkEntity_XML.Dongiausd;
			
			_DulieuxnkEntity.Trigiausd= _DulieuxnkEntity_XML.Trigiausd;
			
			_DulieuxnkEntity.Tygiavnd= _DulieuxnkEntity_XML.Tygiavnd;
			
			_DulieuxnkEntity.Madongtien= _DulieuxnkEntity_XML.Madongtien;
			
			_DulieuxnkEntity.Dieukiengia= _DulieuxnkEntity_XML.Dieukiengia;
			
			_DulieuxnkEntity.Phuongthucthanhtoan= _DulieuxnkEntity_XML.Phuongthucthanhtoan;
			
			_DulieuxnkEntity.Chicuchaiquan= _DulieuxnkEntity_XML.Chicuchaiquan;
			
			_DulieuxnkEntity.Loaihinhxuatkhau= _DulieuxnkEntity_XML.Loaihinhxuatkhau;
			
			_DulieuxnkEntity.Tennuocxuatkhau= _DulieuxnkEntity_XML.Tennuocxuatkhau;
			
			_DulieuxnkEntity.Tennuocnhapkhau= _DulieuxnkEntity_XML.Tennuocnhapkhau;
			
			_DulieuxnkEntity.Diadiemxephang= _DulieuxnkEntity_XML.Diadiemxephang;
			
			_DulieuxnkEntity.Diadiemnhanhangcuoicung= _DulieuxnkEntity_XML.Diadiemnhanhangcuoicung;
			
			_DulieuxnkEntity.Sotokhai= _DulieuxnkEntity_XML.Sotokhai;
									
				
			return _DulieuxnkEntity;
		}	
		
		public String InsertV2(DulieuxnkEntity _DulieuxnkEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DulieuxnkManagerBase()).Insert(_DulieuxnkEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_DulieuxnkEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Nam,_DulieuxnkEntity.Nam);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thang,_DulieuxnkEntity.Thang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaythongquan,_DulieuxnkEntity.Ngaythongquan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masothuexuat,_DulieuxnkEntity.Masothuexuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongtyxuat,_DulieuxnkEntity.Tencongtyxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachicongtyxuat,_DulieuxnkEntity.Diachicongtyxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dienthoaicongtyxuat,_DulieuxnkEntity.Dienthoaicongtyxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongtynhap,_DulieuxnkEntity.Tencongtynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachicongtynhap,_DulieuxnkEntity.Diachicongtynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hscode,_DulieuxnkEntity.Hscode);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Motahanghoa,_DulieuxnkEntity.Motahanghoa);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuexuat,_DulieuxnkEntity.Thuexuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuatxu,_DulieuxnkEntity.Xuatxu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madonvi,_DulieuxnkEntity.Madonvi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sotan,_DulieuxnkEntity.Sotan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Giausd,_DulieuxnkEntity.Giausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_DulieuxnkEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongianguyente,_DulieuxnkEntity.Dongianguyente);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiausd,_DulieuxnkEntity.Dongiausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trigiausd,_DulieuxnkEntity.Trigiausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tygiavnd,_DulieuxnkEntity.Tygiavnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madongtien,_DulieuxnkEntity.Madongtien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dieukiengia,_DulieuxnkEntity.Dieukiengia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phuongthucthanhtoan,_DulieuxnkEntity.Phuongthucthanhtoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chicuchaiquan,_DulieuxnkEntity.Chicuchaiquan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaihinhxuatkhau,_DulieuxnkEntity.Loaihinhxuatkhau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennuocxuatkhau,_DulieuxnkEntity.Tennuocxuatkhau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennuocnhapkhau,_DulieuxnkEntity.Tennuocnhapkhau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diadiemxephang,_DulieuxnkEntity.Diadiemxephang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diadiemnhanhangcuoicung,_DulieuxnkEntity.Diadiemnhanhangcuoicung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sotokhai,_DulieuxnkEntity.Sotokhai);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DulieuxnkEntity _DulieuxnkEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DulieuxnkManagerBase()).Update(_DulieuxnkEntity);
			r.SetField(Field_Id,_DulieuxnkEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Nam,_DulieuxnkEntity.Nam);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thang,_DulieuxnkEntity.Thang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaythongquan,_DulieuxnkEntity.Ngaythongquan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masothuexuat,_DulieuxnkEntity.Masothuexuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongtyxuat,_DulieuxnkEntity.Tencongtyxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachicongtyxuat,_DulieuxnkEntity.Diachicongtyxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dienthoaicongtyxuat,_DulieuxnkEntity.Dienthoaicongtyxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongtynhap,_DulieuxnkEntity.Tencongtynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachicongtynhap,_DulieuxnkEntity.Diachicongtynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hscode,_DulieuxnkEntity.Hscode);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Motahanghoa,_DulieuxnkEntity.Motahanghoa);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuexuat,_DulieuxnkEntity.Thuexuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuatxu,_DulieuxnkEntity.Xuatxu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madonvi,_DulieuxnkEntity.Madonvi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sotan,_DulieuxnkEntity.Sotan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Giausd,_DulieuxnkEntity.Giausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_DulieuxnkEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongianguyente,_DulieuxnkEntity.Dongianguyente);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongiausd,_DulieuxnkEntity.Dongiausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trigiausd,_DulieuxnkEntity.Trigiausd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tygiavnd,_DulieuxnkEntity.Tygiavnd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madongtien,_DulieuxnkEntity.Madongtien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dieukiengia,_DulieuxnkEntity.Dieukiengia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phuongthucthanhtoan,_DulieuxnkEntity.Phuongthucthanhtoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chicuchaiquan,_DulieuxnkEntity.Chicuchaiquan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaihinhxuatkhau,_DulieuxnkEntity.Loaihinhxuatkhau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennuocxuatkhau,_DulieuxnkEntity.Tennuocxuatkhau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennuocnhapkhau,_DulieuxnkEntity.Tennuocnhapkhau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diadiemxephang,_DulieuxnkEntity.Diadiemxephang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diadiemnhanhangcuoicung,_DulieuxnkEntity.Diadiemnhanhangcuoicung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sotokhai,_DulieuxnkEntity.Sotokhai);
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

		public DulieuxnkEntity Insert(DulieuxnkEntity DulieuxnkEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DulieuxnkEntity, true);
			}
			return DulieuxnkEntity;
		}

		public DulieuxnkEntity Insert(System.Int64  Id, System.Int32  Nam, System.Int32  Thang, System.DateTime  Ngaythongquan, System.String  Masothuexuat, System.String  Tencongtyxuat, System.String  Diachicongtyxuat, System.String  Dienthoaicongtyxuat, System.String  Tencongtynhap, System.String  Diachicongtynhap, System.String  Hscode, System.String  Motahanghoa, System.Decimal  Thuexuat, System.String  Xuatxu, System.String  Madonvi, System.Decimal  Sotan, System.Decimal  Giausd, System.Decimal  Soluong, System.Decimal  Dongianguyente, System.Decimal  Dongiausd, System.Decimal  Trigiausd, System.Decimal  Tygiavnd, System.String  Madongtien, System.String  Dieukiengia, System.String  Phuongthucthanhtoan, System.String  Chicuchaiquan, System.String  Loaihinhxuatkhau, System.String  Tennuocxuatkhau, System.String  Tennuocnhapkhau, System.String  Diadiemxephang, System.String  Diadiemnhanhangcuoicung, System.String  Sotokhai)
		{
			DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DulieuxnkEntity.Id = Id;
				
				_DulieuxnkEntity.Nam = Nam;
				
				_DulieuxnkEntity.Thang = Thang;
				
				_DulieuxnkEntity.Ngaythongquan = Ngaythongquan;
				
				_DulieuxnkEntity.Masothuexuat = Masothuexuat;
				
				_DulieuxnkEntity.Tencongtyxuat = Tencongtyxuat;
				
				_DulieuxnkEntity.Diachicongtyxuat = Diachicongtyxuat;
				
				_DulieuxnkEntity.Dienthoaicongtyxuat = Dienthoaicongtyxuat;
				
				_DulieuxnkEntity.Tencongtynhap = Tencongtynhap;
				
				_DulieuxnkEntity.Diachicongtynhap = Diachicongtynhap;
				
				_DulieuxnkEntity.Hscode = Hscode;
				
				_DulieuxnkEntity.Motahanghoa = Motahanghoa;
				
				_DulieuxnkEntity.Thuexuat = Thuexuat;
				
				_DulieuxnkEntity.Xuatxu = Xuatxu;
				
				_DulieuxnkEntity.Madonvi = Madonvi;
				
				_DulieuxnkEntity.Sotan = Sotan;
				
				_DulieuxnkEntity.Giausd = Giausd;
				
				_DulieuxnkEntity.Soluong = Soluong;
				
				_DulieuxnkEntity.Dongianguyente = Dongianguyente;
				
				_DulieuxnkEntity.Dongiausd = Dongiausd;
				
				_DulieuxnkEntity.Trigiausd = Trigiausd;
				
				_DulieuxnkEntity.Tygiavnd = Tygiavnd;
				
				_DulieuxnkEntity.Madongtien = Madongtien;
				
				_DulieuxnkEntity.Dieukiengia = Dieukiengia;
				
				_DulieuxnkEntity.Phuongthucthanhtoan = Phuongthucthanhtoan;
				
				_DulieuxnkEntity.Chicuchaiquan = Chicuchaiquan;
				
				_DulieuxnkEntity.Loaihinhxuatkhau = Loaihinhxuatkhau;
				
				_DulieuxnkEntity.Tennuocxuatkhau = Tennuocxuatkhau;
				
				_DulieuxnkEntity.Tennuocnhapkhau = Tennuocnhapkhau;
				
				_DulieuxnkEntity.Diadiemxephang = Diadiemxephang;
				
				_DulieuxnkEntity.Diadiemnhanhangcuoicung = Diadiemnhanhangcuoicung;
				
				_DulieuxnkEntity.Sotokhai = Sotokhai;
					
					
				adapter.SaveEntity(_DulieuxnkEntity, true);
			}
			return _DulieuxnkEntity;
		}

		public DulieuxnkEntity Insert(System.Int32 Nam, System.Int32 Thang, System.DateTime Ngaythongquan, System.String Masothuexuat, System.String Tencongtyxuat, System.String Diachicongtyxuat, System.String Dienthoaicongtyxuat, System.String Tencongtynhap, System.String Diachicongtynhap, System.String Hscode, System.String Motahanghoa, System.Decimal Thuexuat, System.String Xuatxu, System.String Madonvi, System.Decimal Sotan, System.Decimal Giausd, System.Decimal Soluong, System.Decimal Dongianguyente, System.Decimal Dongiausd, System.Decimal Trigiausd, System.Decimal Tygiavnd, System.String Madongtien, System.String Dieukiengia, System.String Phuongthucthanhtoan, System.String Chicuchaiquan, System.String Loaihinhxuatkhau, System.String Tennuocxuatkhau, System.String Tennuocnhapkhau, System.String Diadiemxephang, System.String Diadiemnhanhangcuoicung, System.String Sotokhai)//ko co mahieu
		{
			DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DulieuxnkEntity.Nam = Nam;
				
				_DulieuxnkEntity.Thang = Thang;
				
				_DulieuxnkEntity.Ngaythongquan = Ngaythongquan;
				
				_DulieuxnkEntity.Masothuexuat = Masothuexuat;
				
				_DulieuxnkEntity.Tencongtyxuat = Tencongtyxuat;
				
				_DulieuxnkEntity.Diachicongtyxuat = Diachicongtyxuat;
				
				_DulieuxnkEntity.Dienthoaicongtyxuat = Dienthoaicongtyxuat;
				
				_DulieuxnkEntity.Tencongtynhap = Tencongtynhap;
				
				_DulieuxnkEntity.Diachicongtynhap = Diachicongtynhap;
				
				_DulieuxnkEntity.Hscode = Hscode;
				
				_DulieuxnkEntity.Motahanghoa = Motahanghoa;
				
				_DulieuxnkEntity.Thuexuat = Thuexuat;
				
				_DulieuxnkEntity.Xuatxu = Xuatxu;
				
				_DulieuxnkEntity.Madonvi = Madonvi;
				
				_DulieuxnkEntity.Sotan = Sotan;
				
				_DulieuxnkEntity.Giausd = Giausd;
				
				_DulieuxnkEntity.Soluong = Soluong;
				
				_DulieuxnkEntity.Dongianguyente = Dongianguyente;
				
				_DulieuxnkEntity.Dongiausd = Dongiausd;
				
				_DulieuxnkEntity.Trigiausd = Trigiausd;
				
				_DulieuxnkEntity.Tygiavnd = Tygiavnd;
				
				_DulieuxnkEntity.Madongtien = Madongtien;
				
				_DulieuxnkEntity.Dieukiengia = Dieukiengia;
				
				_DulieuxnkEntity.Phuongthucthanhtoan = Phuongthucthanhtoan;
				
				_DulieuxnkEntity.Chicuchaiquan = Chicuchaiquan;
				
				_DulieuxnkEntity.Loaihinhxuatkhau = Loaihinhxuatkhau;
				
				_DulieuxnkEntity.Tennuocxuatkhau = Tennuocxuatkhau;
				
				_DulieuxnkEntity.Tennuocnhapkhau = Tennuocnhapkhau;
				
				_DulieuxnkEntity.Diadiemxephang = Diadiemxephang;
				
				_DulieuxnkEntity.Diadiemnhanhangcuoicung = Diadiemnhanhangcuoicung;
				
				_DulieuxnkEntity.Sotokhai = Sotokhai;
					

				adapter.SaveEntity(_DulieuxnkEntity, true);
			}
			return _DulieuxnkEntity;
		}

		public bool Update(DulieuxnkEntity _DulieuxnkEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DulieuxnkFields.Id == _DulieuxnkEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DulieuxnkEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DulieuxnkEntity _DulieuxnkEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DulieuxnkEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.Int32 Nam, System.Int32 Thang, System.DateTime Ngaythongquan, System.String Masothuexuat, System.String Tencongtyxuat, System.String Diachicongtyxuat, System.String Dienthoaicongtyxuat, System.String Tencongtynhap, System.String Diachicongtynhap, System.String Hscode, System.String Motahanghoa, System.Decimal Thuexuat, System.String Xuatxu, System.String Madonvi, System.Decimal Sotan, System.Decimal Giausd, System.Decimal Soluong, System.Decimal Dongianguyente, System.Decimal Dongiausd, System.Decimal Trigiausd, System.Decimal Tygiavnd, System.String Madongtien, System.String Dieukiengia, System.String Phuongthucthanhtoan, System.String Chicuchaiquan, System.String Loaihinhxuatkhau, System.String Tennuocxuatkhau, System.String Tennuocnhapkhau, System.String Diadiemxephang, System.String Diadiemnhanhangcuoicung, System.String Sotokhai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity(Id);
				if (adapter.FetchEntity(_DulieuxnkEntity))
				{
				
					
					
					_DulieuxnkEntity.Nam = Nam;
					
					_DulieuxnkEntity.Thang = Thang;
					
					_DulieuxnkEntity.Ngaythongquan = Ngaythongquan;
					
					_DulieuxnkEntity.Masothuexuat = Masothuexuat;
					
					_DulieuxnkEntity.Tencongtyxuat = Tencongtyxuat;
					
					_DulieuxnkEntity.Diachicongtyxuat = Diachicongtyxuat;
					
					_DulieuxnkEntity.Dienthoaicongtyxuat = Dienthoaicongtyxuat;
					
					_DulieuxnkEntity.Tencongtynhap = Tencongtynhap;
					
					_DulieuxnkEntity.Diachicongtynhap = Diachicongtynhap;
					
					_DulieuxnkEntity.Hscode = Hscode;
					
					_DulieuxnkEntity.Motahanghoa = Motahanghoa;
					
					_DulieuxnkEntity.Thuexuat = Thuexuat;
					
					_DulieuxnkEntity.Xuatxu = Xuatxu;
					
					_DulieuxnkEntity.Madonvi = Madonvi;
					
					_DulieuxnkEntity.Sotan = Sotan;
					
					_DulieuxnkEntity.Giausd = Giausd;
					
					_DulieuxnkEntity.Soluong = Soluong;
					
					_DulieuxnkEntity.Dongianguyente = Dongianguyente;
					
					_DulieuxnkEntity.Dongiausd = Dongiausd;
					
					_DulieuxnkEntity.Trigiausd = Trigiausd;
					
					_DulieuxnkEntity.Tygiavnd = Tygiavnd;
					
					_DulieuxnkEntity.Madongtien = Madongtien;
					
					_DulieuxnkEntity.Dieukiengia = Dieukiengia;
					
					_DulieuxnkEntity.Phuongthucthanhtoan = Phuongthucthanhtoan;
					
					_DulieuxnkEntity.Chicuchaiquan = Chicuchaiquan;
					
					_DulieuxnkEntity.Loaihinhxuatkhau = Loaihinhxuatkhau;
					
					_DulieuxnkEntity.Tennuocxuatkhau = Tennuocxuatkhau;
					
					_DulieuxnkEntity.Tennuocnhapkhau = Tennuocnhapkhau;
					
					_DulieuxnkEntity.Diadiemxephang = Diadiemxephang;
					
					_DulieuxnkEntity.Diadiemnhanhangcuoicung = Diadiemnhanhangcuoicung;
					
					_DulieuxnkEntity.Sotokhai = Sotokhai;
						

					adapter.SaveEntity(_DulieuxnkEntity, true);
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
				DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity(Id);
				if (adapter.FetchEntity(_DulieuxnkEntity))
				{
					adapter.DeleteEntity(_DulieuxnkEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DulieuxnkEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNam(System.Int32 Nam)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Nam == Nam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThang(System.Int32 Thang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Thang == Thang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaythongquan(System.DateTime Ngaythongquan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Ngaythongquan == Ngaythongquan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasothuexuat(System.String Masothuexuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Masothuexuat == Masothuexuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongtyxuat(System.String Tencongtyxuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tencongtyxuat == Tencongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDiachicongtyxuat(System.String Diachicongtyxuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diachicongtyxuat == Diachicongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDienthoaicongtyxuat(System.String Dienthoaicongtyxuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dienthoaicongtyxuat == Dienthoaicongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongtynhap(System.String Tencongtynhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tencongtynhap == Tencongtynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDiachicongtynhap(System.String Diachicongtynhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diachicongtynhap == Diachicongtynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHscode(System.String Hscode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Hscode == Hscode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMotahanghoa(System.String Motahanghoa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Motahanghoa == Motahanghoa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThuexuat(System.Decimal Thuexuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Thuexuat == Thuexuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByXuatxu(System.String Xuatxu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Xuatxu == Xuatxu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadonvi(System.String Madonvi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Madonvi == Madonvi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySotan(System.Decimal Sotan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Sotan == Sotan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGiausd(System.Decimal Giausd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Giausd == Giausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongianguyente(System.Decimal Dongianguyente)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dongianguyente == Dongianguyente);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongiausd(System.Decimal Dongiausd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTrigiausd(System.Decimal Trigiausd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Trigiausd == Trigiausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTygiavnd(System.Decimal Tygiavnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tygiavnd == Tygiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadongtien(System.String Madongtien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Madongtien == Madongtien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDieukiengia(System.String Dieukiengia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dieukiengia == Dieukiengia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhuongthucthanhtoan(System.String Phuongthucthanhtoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Phuongthucthanhtoan == Phuongthucthanhtoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChicuchaiquan(System.String Chicuchaiquan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Chicuchaiquan == Chicuchaiquan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaihinhxuatkhau(System.String Loaihinhxuatkhau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Loaihinhxuatkhau == Loaihinhxuatkhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennuocxuatkhau(System.String Tennuocxuatkhau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tennuocxuatkhau == Tennuocxuatkhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennuocnhapkhau(System.String Tennuocnhapkhau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tennuocnhapkhau == Tennuocnhapkhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDiadiemxephang(System.String Diadiemxephang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diadiemxephang == Diadiemxephang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDiadiemnhanhangcuoicung(System.String Diadiemnhanhangcuoicung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diadiemnhanhangcuoicung == Diadiemnhanhangcuoicung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySotokhai(System.String Sotokhai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Sotokhai == Sotokhai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DulieuxnkEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DulieuxnkEntity SelectOne(System.Int64 Id)
		{
			DulieuxnkEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DulieuxnkEntity _DulieuxnkEntity = new DulieuxnkEntity(Id);
				if (adapter.FetchEntity(_DulieuxnkEntity))
				{
					toReturn = _DulieuxnkEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection( new DulieuxnkEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, null, 0, null);
			}
			return _DulieuxnkCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNam(System.Int32 Nam)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Nam == Nam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByNamRDT(System.Int32 Nam)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Nam == Nam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThang(System.Int32 Thang)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Thang == Thang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByThangRDT(System.Int32 Thang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Thang == Thang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaythongquan(System.DateTime Ngaythongquan)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Ngaythongquan == Ngaythongquan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaythongquanRDT(System.DateTime Ngaythongquan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Ngaythongquan == Ngaythongquan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasothuexuat(System.String Masothuexuat)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Masothuexuat == Masothuexuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByMasothuexuatRDT(System.String Masothuexuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Masothuexuat == Masothuexuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongtyxuat(System.String Tencongtyxuat)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tencongtyxuat == Tencongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongtyxuatRDT(System.String Tencongtyxuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tencongtyxuat == Tencongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDiachicongtyxuat(System.String Diachicongtyxuat)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diachicongtyxuat == Diachicongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByDiachicongtyxuatRDT(System.String Diachicongtyxuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diachicongtyxuat == Diachicongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDienthoaicongtyxuat(System.String Dienthoaicongtyxuat)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dienthoaicongtyxuat == Dienthoaicongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByDienthoaicongtyxuatRDT(System.String Dienthoaicongtyxuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dienthoaicongtyxuat == Dienthoaicongtyxuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongtynhap(System.String Tencongtynhap)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tencongtynhap == Tencongtynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongtynhapRDT(System.String Tencongtynhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tencongtynhap == Tencongtynhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDiachicongtynhap(System.String Diachicongtynhap)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diachicongtynhap == Diachicongtynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByDiachicongtynhapRDT(System.String Diachicongtynhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diachicongtynhap == Diachicongtynhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHscode(System.String Hscode)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Hscode == Hscode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByHscodeRDT(System.String Hscode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Hscode == Hscode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMotahanghoa(System.String Motahanghoa)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Motahanghoa == Motahanghoa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByMotahanghoaRDT(System.String Motahanghoa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Motahanghoa == Motahanghoa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThuexuat(System.Decimal Thuexuat)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Thuexuat == Thuexuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByThuexuatRDT(System.Decimal Thuexuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Thuexuat == Thuexuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByXuatxu(System.String Xuatxu)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Xuatxu == Xuatxu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByXuatxuRDT(System.String Xuatxu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Xuatxu == Xuatxu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadonvi(System.String Madonvi)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Madonvi == Madonvi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonviRDT(System.String Madonvi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Madonvi == Madonvi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySotan(System.Decimal Sotan)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Sotan == Sotan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectBySotanRDT(System.Decimal Sotan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Sotan == Sotan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGiausd(System.Decimal Giausd)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Giausd == Giausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByGiausdRDT(System.Decimal Giausd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Giausd == Giausd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongianguyente(System.Decimal Dongianguyente)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dongianguyente == Dongianguyente);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByDongianguyenteRDT(System.Decimal Dongianguyente)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dongianguyente == Dongianguyente);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongiausd(System.Decimal Dongiausd)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiausdRDT(System.Decimal Dongiausd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dongiausd == Dongiausd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTrigiausd(System.Decimal Trigiausd)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Trigiausd == Trigiausd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByTrigiausdRDT(System.Decimal Trigiausd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Trigiausd == Trigiausd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTygiavnd(System.Decimal Tygiavnd)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tygiavnd == Tygiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByTygiavndRDT(System.Decimal Tygiavnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tygiavnd == Tygiavnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadongtien(System.String Madongtien)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Madongtien == Madongtien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByMadongtienRDT(System.String Madongtien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Madongtien == Madongtien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDieukiengia(System.String Dieukiengia)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dieukiengia == Dieukiengia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByDieukiengiaRDT(System.String Dieukiengia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Dieukiengia == Dieukiengia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhuongthucthanhtoan(System.String Phuongthucthanhtoan)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Phuongthucthanhtoan == Phuongthucthanhtoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByPhuongthucthanhtoanRDT(System.String Phuongthucthanhtoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Phuongthucthanhtoan == Phuongthucthanhtoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChicuchaiquan(System.String Chicuchaiquan)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Chicuchaiquan == Chicuchaiquan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByChicuchaiquanRDT(System.String Chicuchaiquan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Chicuchaiquan == Chicuchaiquan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaihinhxuatkhau(System.String Loaihinhxuatkhau)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Loaihinhxuatkhau == Loaihinhxuatkhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaihinhxuatkhauRDT(System.String Loaihinhxuatkhau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Loaihinhxuatkhau == Loaihinhxuatkhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennuocxuatkhau(System.String Tennuocxuatkhau)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tennuocxuatkhau == Tennuocxuatkhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByTennuocxuatkhauRDT(System.String Tennuocxuatkhau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tennuocxuatkhau == Tennuocxuatkhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennuocnhapkhau(System.String Tennuocnhapkhau)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tennuocnhapkhau == Tennuocnhapkhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByTennuocnhapkhauRDT(System.String Tennuocnhapkhau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Tennuocnhapkhau == Tennuocnhapkhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDiadiemxephang(System.String Diadiemxephang)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diadiemxephang == Diadiemxephang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByDiadiemxephangRDT(System.String Diadiemxephang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diadiemxephang == Diadiemxephang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDiadiemnhanhangcuoicung(System.String Diadiemnhanhangcuoicung)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diadiemnhanhangcuoicung == Diadiemnhanhangcuoicung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectByDiadiemnhanhangcuoicungRDT(System.String Diadiemnhanhangcuoicung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Diadiemnhanhangcuoicung == Diadiemnhanhangcuoicung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySotokhai(System.String Sotokhai)
		{
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Sotokhai == Sotokhai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DulieuxnkCollection, filter, 0, null);
			}
			return _DulieuxnkCollection;
		}
		// Return DataTable
		public DataTable SelectBySotokhaiRDT(System.String Sotokhai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DulieuxnkCollection = new EntityCollection(new DulieuxnkEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DulieuxnkFields.Sotokhai == Sotokhai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DulieuxnkCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
