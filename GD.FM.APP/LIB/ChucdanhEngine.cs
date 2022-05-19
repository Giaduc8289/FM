using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace GD.FM.APP.LIB
{
    class ChucdanhEngine
    {
        private void AddRow(string ma_hieu, string tieude, string gia_tri, DataTable dt)
        {
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            row[0] = ma_hieu;
            row[1] = tieude;
            row[2] = gia_tri;
        }

        private string GetGiatri(string ma_hieu)
        {
            string strSQL = "select Giatri from Thamso where Mahieu='" + ma_hieu + "'";
            object obj = DataFactory.ExecuteScalar(strSQL);
            if (obj != null) return obj.ToString();

            return "";
        }

         public DataTable AddRow_ChucDanh(DataTable dt, string mahieu, string tieude, string giatri) {
             DataTable newdt = new DataTable();
             newdt = dt.Copy();
             DataRow row = newdt.NewRow();
             row["Mahieu"] = mahieu; row["Tieude"] = tieude; row["Giatri"] = giatri;
             newdt.Rows.Add(row); 
             return newdt; 
              
         }

        /// <summary>
        /// formatInfo
        /// A1, A2 : Thu truong Don vi Ho ten / chuc danh
        /// B1, B2 : Ke toan truong Ho ten / chuc danh
        /// C1, C2 : Nguoi lap bieu / Nguoi ghi so
        /// D : Thu kho / thu quy
        /// E2 : ho ten ke toan
        /// H1, H2, H3 : Tinh / Huyen / Xa
        /// </summary>
        /// <param name="formatInfo"></param>
        /// <returns>data table</returns>
        public DataTable Load_ChucDanh(string formatInfo)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mahieu", typeof(string)));
            dt.Columns.Add(new DataColumn("Tieude", typeof(string)));
            dt.Columns.Add(new DataColumn("Giatri", typeof(string)));

            char[] fm = formatInfo.ToUpper().ToCharArray();
            for (int i = 0; i < fm.Length; i++)
            {
                switch (fm[i])
                {
                    case 'A':
                        AddRow("A1", "Chức danh thủ trưởng đơn vị", GetGiatri("M_TTDV"), dt);
                        AddRow("A2", "Họ tên thủ trưởng", GetGiatri("M_TEN_TTDV"), dt);
                        break;
                    case 'B':
                        AddRow("B1", "Chức danh Kế toán trưởng", GetGiatri("M_KTT"), dt);
                        AddRow("B2", "Họ tên Kế toán trưởng", GetGiatri("M_Ten_KTT"), dt);
                        break;
                    case 'C': // lap bieu , ghi so
                        AddRow("C1", "Họ tên người lập biểu", "", dt);
                        AddRow("C2", "Họ tên người Ghi sổ", "", dt);
                        break;
                    case 'D':
                        AddRow("D", "Họ tên thủ quỹ / thủ kho", GetGiatri("M_TEN_TQUY"), dt);
                        break;
                    case 'E':
                        AddRow("E2", "Họ tên Kế toán", GetGiatri("M_Ten_NLB"), dt);
                        break;

                    case 'H': // tinh huyen xa
                        AddRow("H1", "Tên Tỉnh, Thành phố", GetGiatri("M_TINH"), dt);
                        AddRow("H2", "Tên quận, huyện", GetGiatri("M_TEN_CQ1"), dt);
                        AddRow("H3", "Tên xã, phường", GetGiatri("M_TEN_CQ2"), dt);

                        break;
                }
            }

            return dt;
        }

        /// <summary>
        /// A1 : Chuc danh Thu truong Don vi
        /// A2 : Ho ten Thu truong Don vi
        /// B1 : Chuc danh ke toan truong
        /// B2 : Ho ten Ke toan truong
        /// C : Ho ten nguoi lap bieu
        /// D : Ho ten thu kho / thu quy
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ma_hieu"></param>
        /// <returns></returns>
        public string Giatri_grid(DataTable dt, string ma_hieu)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ma = dt.Rows[i]["Mahieu"].ToString();
                if (ma == ma_hieu) return dt.Rows[i]["Giatri"].ToString();
            }
            return "";
        }
    }
}
