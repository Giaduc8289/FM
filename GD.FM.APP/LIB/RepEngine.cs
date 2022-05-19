using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace GD.FM
{
    /// <summary>
    /// code by Nguyen Duc Khanh 19-May-2015
    /// </summary>
    class RepEngine
    {
        public RepEngine() { }

        public DataTable CreateTableStruct(int col_number)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < col_number; i++)
            {
                dt.Columns.Add(new DataColumn("C" + Convert.ToString(i + 1), typeof(string)));
            }

            return dt;
        }

        #region nhat ky thu chi
        private DataTable LoadData_NK_Thuchi(string tai_khoan, DateTime tu_ngay, DateTime den_ngay)
        {
            string tk_quy = tai_khoan;
            if (tk_quy == "") tk_quy = "111";
            string strSQL = @"
    Select ct.Sothutubanghi, ct.Sothutubanghi1, ct.Sothutubanghi2, ct.Thutubanghi2cu,
		h.Sochungtu,h.Ongba, h.Diachi, h.Ngaychungtu, h.Ngayhachtoan,
		h.Diengiai, h.Machuongtrinhmuctieu,h.Matinhchatnguon,h.Machungtu, 
		d.Thanhly, d.Muamoi,d.Taikhoanno, d.Taikhoanco, ct.Loai, 
		ct.Madoituong, ct.Makhoanmuc, ct.Machitiet, ct.Chuong, 
		ct.Loaikhoan, ct.Muc, ct.Soluong, ct.Gia, 
		ct.tien, ct.TienNSNN, ct.Tienthoaithu, ct.Tienthoaichi 
	From Chungtuheader h, Chungtudetail d, Chungtuchitiet ct
	Where h.Sothutubanghi = d.Sothutubanghi And d.Sothutubanghi1 = ct.Sothutubanghi1
		And Ngayhachtoan Between @Tungay And @Denngay
		And Taikhoan = @Taikhoan ORDER BY Ngaychungtu ";
            ArrayList p = new ArrayList();
            p.Add(new SqlParameter("@Tungay", tu_ngay));
            p.Add(new SqlParameter("@Denngay", den_ngay));
            p.Add(new SqlParameter("@Taikhoan", tk_quy));

            DataTable dt = DataFactory.SelectTable(strSQL, p);

            return dt;
        }

        /// <summary>
        /// 1-Ngay ghi so 2-ngay chung tu 3-so phieu thu 4-so phieu chi 5-dien giai 6-thu 7-chi 8-ton quy
        /// chi tiet tung quy : 9-thu 10-chi 11-ton
        /// </summary>
        /// <returns></returns>
        public DataTable NhatKy_Thuchi(string taikhoan, DateTime tu_ngay, DateTime den_ngay)
        {
            DataTable dt = LoadData_NK_Thuchi(taikhoan, tu_ngay, den_ngay);
            DataTable kq = CreateTableStruct(13);
            Int64 tong_thu = 0;
            Int64 tong_chi = 0;
            Int64 gia_tri_ton = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Sochungtu = dt.Rows[i]["Sochungtu"].ToString();

                DataRow row = kq.NewRow();
                kq.Rows.Add(row);
                row[0] = Convert.ToDateTime(dt.Rows[i]["Ngayhachtoan"]).ToString("dd/MM/yyyy");
                row[1] = Convert.ToDateTime(dt.Rows[i]["Ngaychungtu"]).ToString("dd/MM/yyyy");

                bool thu = (dt.Rows[i]["Taikhoanno"].ToString() == "111");
                Int64 tien = Convert.ToInt64(dt.Rows[i]["tien"]);
                if (thu)
                {
                    row[2] = Sochungtu;
                    row[3] = "";
                }
                else
                {
                    row[2] = "";
                    row[3] = Sochungtu;
                }
                row[4] = dt.Rows[i]["Diengiai"].ToString();
                if (thu)
                {
                    row[5] = tien.ToString("#,###");
                    row[6] = "";
                    tong_thu += tien;
                    gia_tri_ton += tien;
                }
                else
                {
                    row[5] = "";
                    row[6] = tien.ToString("#,###");
                    tong_chi += tien;
                    gia_tri_ton -= tien;
                }
                row[7] = gia_tri_ton.ToString("#,###");

                string Madoituong = dt.Rows[i]["Madoituong"].ToString();
            }
            DataRow rowTotal = kq.NewRow();
            kq.Rows.Add(rowTotal);
            rowTotal[4] = "Cộng phát sinh tháng \r\nLũy kế đầu năm\r\nSố dư cuối tháng";
            rowTotal[5] = tong_thu.ToString("#,###");
            rowTotal[6] = tong_chi.ToString("#,###");
            Int64 con_ton = tong_thu - tong_chi;
            rowTotal[7] = con_ton.ToString("#,###");

            return kq;
        }
        #endregion

        #region So cai
        private int get_so_cot(string tk, ArrayList ds_tk)
        {
            for (int i = 0; i < ds_tk.Count; i++)
            {
                string tai_khoan = ds_tk[i].ToString();
                if (tai_khoan == tk) return i;
            }
            return -1;
        }

        private void SetRowValue(int idx, DataRow row, int total_col, string val)
        {
            if (idx < total_col) row[idx] = val;
        }

        private ArrayList Danhsach_TK(DataTable dt)
        {
            ArrayList a = new ArrayList();
            Hashtable ds_tk = new Hashtable();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Taikhoanno = dt.Rows[i]["Taikhoanno"].ToString();
                if (!ds_tk.ContainsKey(Taikhoanno))
                {
                    if (Taikhoanno != "")
                    {
                        ds_tk.Add(Taikhoanno, i);
                        a.Add(Taikhoanno);
                    }
                }
                string Taikhoanco = dt.Rows[i]["Taikhoanco"].ToString();
                if (!ds_tk.ContainsKey(Taikhoanco))
                {
                    if (Taikhoanco != "")
                    {
                        ds_tk.Add(Taikhoanco, i);
                        a.Add(Taikhoanco);
                    }
                }
            }

            return a;
        }

        private Int64 CongPhatSinhTK_NhatkySoCai(int col, DataTable kq)
        {
            Int64 tong = 0;
            // bo qua row[0] (so du dau nam)
            for (int i = 1; i < kq.Rows.Count; i++)
            {
                Int64 val = 0;
                try
                {
                    if (kq.Rows[i][col].ToString() != "")
                    {
                        val = Convert.ToInt64(kq.Rows[i][col].ToString().Replace(".", ""));
                        tong += val;
                    }
                }
                catch (Exception ex) { }
            }
            return tong;
        }

        private void Sodudauky(DataTable kq, ArrayList ds_tk)
        {
            string strSQL = @"
                    SELECT     Mahieu, Thang, Taikhoan, Dunodauky, Ducodauky
                    FROM         Candoitaikhoan
                    WHERE     (Thang = 1) AND (Dunodauky > 0)";
            DataTable dt_sodu = DataFactory.SelectTable(strSQL);

            DataRow row1 = kq.NewRow();
            kq.Rows.Add(row1);
            row1[3] = "Số dư đầu kỳ";

            for (int j = 0; j < ds_tk.Count; j++)
            {
                string tk = ds_tk[j].ToString();
                for (int i = 0; i < dt_sodu.Rows.Count; i++)
                {
                    if (tk == dt_sodu.Rows[i]["Taikhoan"].ToString())
                    {
                        if(2 * j + 8 < kq.Columns.Count)
                            row1[2 * j + 8] = Convert.ToInt64(dt_sodu.Rows[i]["Dunodauky"]).ToString("#,###");

                        if (2 * j + 8 + 1 < kq.Columns.Count)
                            row1[2 * j + 8 + 1] = Convert.ToInt64(dt_sodu.Rows[i]["Ducodauky"]).ToString("#,###");
                        break;
                    }
                }
            }
            //if (dt_sodu.Rows.Count > 0)
            //{
            //    row1[4] = Convert.ToInt64(dt_sodu.Rows[0]["Dunodauky"]).ToString("#,###");
            //}
        }

        private Int64 getRowValue(string tien)
        {
            Int64 val = 0;
            try{
                tien = tien.Replace(".", "");
                val = Convert.ToInt64(tien);
            }
            catch { }
            return val;
        }

        /// <summary>
        /// 1-ngay ghi so  2-so chung tu 3-ngay chung tu 4-dien giai 5-so phat sinh
        /// 6-tk no 7-tk co 8-so thu tu
        /// tai khoan chi tiet (moi tai khoan 2 cot) : no + co
        /// </summary>
        /// <param name="tu_ngay"></param>
        /// <param name="den_ngay"></param>
        /// <returns></returns>
        public DataTable SoCai(DateTime tu_ngay, DateTime den_ngay, out ArrayList ds_tk)
        {
            string strSQL = @"Select h.Sochungtu, h.Ongba, h.Diachi, h.Ngaychungtu, h.Ngayhachtoan,
		h.Diengiai, h.Machuongtrinhmuctieu, h.Matinhchatnguon, h.Machungtu, 
		d.Taikhoanno, d.Taikhoanco, d.Tien 
	From Chungtuheader h, Chungtudetail d
	Where h.Sothutubanghi = d.Sothutubanghi 
		And ((Ngayhachtoan >= @tu_ngay) and (Ngayhachtoan <= @den_ngay)) order by Ngayhachtoan";
            ArrayList p = new ArrayList();
            p.Add(new SqlParameter("@tu_ngay", tu_ngay));
            p.Add(new SqlParameter("@den_ngay", den_ngay));
            DataTable dt = DataFactory.SelectTable(strSQL, p);

            // danh sach tai khoan
            ds_tk = Danhsach_TK(dt);
            int tong_so_cot_chi_tiet = ds_tk.Count * 2; // no + co

            int total_col = 8 + tong_so_cot_chi_tiet;
            DataTable kq = CreateTableStruct(total_col);

            Sodudauky(kq, ds_tk);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = kq.NewRow();
                kq.Rows.Add(row);

                row[0] = Convert.ToDateTime(dt.Rows[i]["Ngayhachtoan"]).ToString("dd/MM/yyyy");
                row[1] = dt.Rows[i]["Sochungtu"].ToString();
                row[2] = Convert.ToDateTime(dt.Rows[i]["Ngaychungtu"]).ToString("dd/MM/yyyy");
                row[3] = dt.Rows[i]["Diengiai"].ToString();
                row[4] = Convert.ToInt64(dt.Rows[i]["Tien"]).ToString("#,###");
                row[5] = dt.Rows[i]["Taikhoanno"].ToString();
                row[6] = dt.Rows[i]["Taikhoanco"].ToString();
                row[7] = Convert.ToString(i + 1);

                string Taikhoanno = dt.Rows[i]["Taikhoanno"].ToString();
                string Taikhoanco = dt.Rows[i]["Taikhoanco"].ToString();
                string tien = row[4].ToString();
                // chi tiet no co
                int idx = get_so_cot(Taikhoanno, ds_tk);
                if (idx != -1)
                    SetRowValue(idx * 2 + 8, row, total_col, tien);
                int idx1 = get_so_cot(Taikhoanco, ds_tk);
                if (idx1 != -1)
                    SetRowValue(idx1 * 2 + 9, row, total_col, tien);
            }

            DataRow rowTong = kq.NewRow();
            kq.Rows.Add(rowTong);
            rowTong[3] = "Cộng";
            for (int i = 8; i < kq.Columns.Count; i++)
            {
                // col [5] = tk no, col [6] = tk co, col [7] = stt
                Int64 tong = CongPhatSinhTK_NhatkySoCai(i, kq);
                if (tong != 0)
                    rowTong[i] = tong.ToString("#,###");

            }

            DataRow row1 = kq.Rows[0];
            DataRow rowSodu = kq.NewRow();
            kq.Rows.Add(rowSodu);
            rowSodu[3] = "Số dư cuối kỳ";
            for (int i = 8; i < kq.Columns.Count; i++)
            {
                // chi tinh cot 8 - 10 - 12 ...
                int iv = i % 2;
                if (iv == 0)
                {
                    Int64 _so_du = getRowValue(rowTong[i].ToString()) - getRowValue(rowTong[i + 1].ToString());
                    rowSodu[i] = _so_du.ToString("#,###");
                }
            }
            // cong du no dau ky theo tung tai khoan
            DataRow rowLuyke = kq.NewRow();
            kq.Rows.Add(rowLuyke);
            rowLuyke[3] = "Lũy kế từ đầu năm";
            for (int i = 8; i < kq.Columns.Count; i++)
            {
                Int64 _luy_ke = getRowValue(rowTong[i].ToString()) + getRowValue(row1[i].ToString());
                rowLuyke[i] = _luy_ke.ToString("#,###");
            }

            return kq;
        }
        #endregion
    }
}
