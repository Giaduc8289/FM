using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using TBNET.ERP.BLL;
using TBNET.ERP.DAL;
using TBNET.ERP.DAL.EntityClasses;
using TBNET.ERP.DAL.FactoryClasses;
using TBNET.ERP.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
namespace TBNET.ERP.DATA
{
    //[System.ComponentModel.DesignerCategory("Code")]
    //[SerializableAttribute]

    public class TimkiemgiatriData : DataSet
    {
        public const string DanhMuc_Table = "DanhMuc";
        public const string DmTaiKhoan_Table = "DmTaiKhoan";
        public const string DmKhachHang_Table = "DmKhachHang";

        public const string MaPK = "MaPK";
        public const string MaLoaiHinh = "MaLoaiHinh";
        public const string Ma = "Ma";
        public const string Ten = "Ten";
        public const string MaCha = "MaCha";
        public const string MaCha1 = "MaCha1";
        public const string TenCha = "TenCha";
        public const string TenDVT = "TenDVT";
        public const string TyLeHaoMon = "TyLeHaoMon";
        public const string TyLeKhauHao = "TyLeKhauHao";

        public const string DiaChi = "DiaChi";
        public const string MaSoThue = "MaSoThue";
        public const string DienThoai = "DienThoai";
        public const string Fax = "Fax";
        public const string Email = "Email";

        public const string DangSoDu = "DangSoDu";
        public const string TrongBang = "TrongBang";
        public const string LHDoiTuong = "LHDoiTuong";
        public const string LHKhoanMuc = "LHKhoanMuc";
        public const string LHChiTiet = "LHChiTiet";
        public const string LHNguonVon = "LHNguonVon";
        public const string LHQuy = "LHQuy";
        public const string TheoDoiLuong = "TheoDoiLuong";
        public const string TheoDoiNT = "TheoDoiNT";
        public const string LKKhoiDau = "LKKhoiDau";
        public const string Bac = "Bac";
        public const string Chon = "Chon";

        public TimkiemgiatriData()
        {
            BuildKhoaSoTable();
        }
        private void BuildKhoaSoTable()
        {
            DataTable table = new DataTable(DanhMuc_Table);
            DataColumnCollection columns = table.Columns;
            columns.Add(MaPK, typeof(System.String));
            columns.Add(MaLoaiHinh, typeof(System.String));
            columns.Add(Ma, typeof(System.String));
            columns.Add(Ten, typeof(System.String));
            columns.Add(MaCha, typeof(System.String));
            columns.Add(MaCha1, typeof(System.String));
            columns.Add(TenCha, typeof(System.String));
            columns.Add(TenDVT, typeof(System.String));
            columns.Add(TyLeHaoMon, typeof(System.Decimal));
            columns.Add(TyLeKhauHao, typeof(System.Decimal));
            columns.Add(Chon, typeof(System.Boolean));
            columns[Chon].DefaultValue = false;
            this.Tables.Add(table);

            DataTable tableKH = new DataTable(DmKhachHang_Table);
            DataColumnCollection columnKHs = tableKH.Columns;
            columnKHs.Add(MaPK, typeof(System.String));
            columnKHs.Add(MaLoaiHinh, typeof(System.String));
            columnKHs.Add(Ma, typeof(System.String));
            columnKHs.Add(Ten, typeof(System.String));
            columnKHs.Add(MaCha, typeof(System.String));
            columnKHs.Add(MaCha1, typeof(System.String));
            columnKHs.Add(TenCha, typeof(System.String));
            columnKHs.Add(DiaChi, typeof(System.String));
            columnKHs.Add(MaSoThue, typeof(System.String));
            columnKHs.Add(DienThoai, typeof(System.String));
            columnKHs.Add(Fax, typeof(System.String));
            columnKHs.Add(Email, typeof(System.String));
            columnKHs.Add(Chon, typeof(System.Boolean));
            columnKHs[Chon].DefaultValue = false;
            this.Tables.Add(tableKH);

            DataTable tableTK = new DataTable(DmTaiKhoan_Table);
            DataColumnCollection columnTKs = tableTK.Columns;
            columnTKs.Add(MaPK, typeof(System.String));
            columnTKs.Add(Ma, typeof(System.String));
            columnTKs.Add(Ten, typeof(System.String));
            columnTKs.Add(DangSoDu, typeof(System.String));
            columnTKs.Add(TrongBang, typeof(System.Boolean));
            columnTKs.Add(LHDoiTuong, typeof(System.String));
            columnTKs.Add(LHKhoanMuc, typeof(System.String));
            columnTKs.Add(LHChiTiet, typeof(System.String));
            columnTKs.Add(LHNguonVon, typeof(System.String));
            columnTKs.Add(LHQuy, typeof(System.String));
            columnTKs.Add(TheoDoiLuong, typeof(System.Boolean));
            columnTKs.Add(TheoDoiNT, typeof(System.Boolean));
            columnTKs.Add(LKKhoiDau, typeof(System.Boolean));
            columnTKs.Add(Bac, typeof(System.Byte));
            columnTKs.Add(Chon, typeof(System.Boolean));
            columnTKs[Chon].DefaultValue = false;
            this.Tables.Add(tableTK);
        }
    }
}
