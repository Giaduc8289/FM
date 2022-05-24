using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Xml;
using System.Drawing;
using Janus.Data;
using Janus.Windows.GridEX;
using Janus.Windows.Common;
using SD.LLBLGen.Pro.ORMSupportClasses;
namespace GD.FM.LIB
{
    public class GRID_COMM
    {
        //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
        //DataTable dt111 = _TablecolumnManager.Clone();
        //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.FM.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");

        public static DataTable XmlString2DataSet(string xmlString)
        {
            //create a new DataSet that will hold our values
            DataSet quoteDataSet = null;

            //check if the xmlString is not blank
            if (String.IsNullOrEmpty(xmlString))
            {
                //stop the processing
                return quoteDataSet.Tables[0];
            }

            try
            {
                //create a StringReader object to read our xml string
                using (StringReader stringReader = new StringReader(xmlString))
                {
                    //initialize our DataSet
                    quoteDataSet = new DataSet();

                    //load the StringReader to our DataSet
                    quoteDataSet.ReadXml(stringReader);
                }
            }
            catch
            {
                //return null
                quoteDataSet = null;
            }

            //return the DataSet containing the stock information
            return quoteDataSet.Tables[0];
        }
        public static DataTable GET_DATA_CONFIGXML(string FormName)
        {
            DataTable DT = new DataTable();
            string Content = "";
            //try
            //{
            //    Content = GD.FM.DATA.SESSION_START.TABLECONFIG.Select(TableconfigFields.Frmname.Name + " ='" + FormName + "'").CopyToDataTable().Rows[0][TableconfigFields.Dataconfig.Name].ToString(); //GD.FM.LIB.TextFiles.ReadFile(GD.FM.LIB.PATH.ERP_PATH + @"\XMLCONFIG\" + FormName + ".xml");
            //}
            //catch { }
            if (string.IsNullOrEmpty(Content) == false) DT = XmlString2DataSet(Content);
            if (string.IsNullOrEmpty(Content))
            {
                Content = GD.FM.LIB.TextFiles.ReadFile(FormName);// (GD.FM.LIB.PATH.ERP_PATH + @"\XMLCONFIG\" + FormName + ".xml");
                DT = XmlString2DataSet(Content);
                //try
                //{
                //    TableconfigEntity _TableconfigEntity = new TableconfigEntity();
                //    TableconfigManager _TableconfigManager = new TableconfigManager();
                //    _TableconfigEntity.Frmname = _TableconfigEntity.Tablename = FormName;
                //    _TableconfigEntity.Dataconfig = Content;
                //    _TableconfigEntity.Madonvi = GD.FM.DATA.DMDONVI._Current.Madonvi;
                //    _TableconfigManager.Insert(_TableconfigEntity);
                //}
                //catch { }
                //DT = TBNet.Project.IO.ReadXMLTOW(GD.FM.LIB.PATH.ERP_PATH + @"\XMLCONFIG\" + FormName + ".xml");
            }
            return DT;
        }
        public static DataTable LOAD_GRID_SYS_TabPage(string FormName, Janus.Windows.GridEX.GridEX _GridEX, TabPage _TabPage, bool isEditRows)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    //CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                    //                          + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                    //                          + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                    //                          + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                    //                          + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                    //                          + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                    //                          + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                    //                          + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                    //                           + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                    //                          + "<Position>" + i + "</Position></Column" + i + ">"
                    //                          +"<Visible>FALSE</Visible>";

                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>S</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv.Table.Columns.Contains("Type") == true && dv[i]["Type"].ToString() == "D")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv.Table.Columns.Contains("Type") == true && dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    //CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                    //                            + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                    //                            + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                    //                            + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                    //                            + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                    //                            + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                    //                            + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                    //                            + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                    //                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                    //                            + "<Position>" + i + "</Position></Column" + i + ">";

                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            if (_TabPage != null)
            {
                _GridEX.Height = _TabPage.Height;
                _GridEX.Width = _TabPage.Width;
            }
            _GridEX.RecordNavigator = true;
            if (isEditRows)
            {
                _GridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            }
            else
            {
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.None;
            _GridEX.GroupByBoxVisible = false;
            if (_TabPage != null)
            {                
                _TabPage.Controls.Add(_GridEX);
            }
            return dttemplate;
        }

        public static DataTable LOAD_GRID_TabPage_Fomat(string FormName, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Tab.UITabPage _TabPage, bool isEditRows)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">"
                                              + "<Visible>FALSE</Visible>";
                }
                if (dv[i]["Type"].ToString() == "D")                
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                                + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                                + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                                + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                                + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                                + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                                + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                 + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            if (_TabPage != null)
            {
                _GridEX.Height = _TabPage.Height;
                _GridEX.Width = _TabPage.Width;
            }            
            _GridEX.RecordNavigator = true;
            if (isEditRows)
            {
                _GridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            }
            else
            {
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.None;
            _GridEX.GroupByBoxVisible = false;
            if (_TabPage != null)
            {
                _TabPage.AutoScroll = true;
                _TabPage.Controls.Add(_GridEX);
            }            
            return dttemplate;
        }

        public static DataTable LOAD_GRID_UIPanel_Format_C(string xmlfile, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(xmlfile);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;

            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString().Trim().Equals("2"))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position>"
                                              + "<Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("Tamung"))
                {
                    CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>Chọn</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + 20 + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">";
                }
                if (dv.Table.Columns.Contains("Type")==true && dv[i]["Type"].ToString() == "D")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<EditType>CalendarCombo</EditType>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv.Table.Columns.Contains("Type") == true && dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                                + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                                + "<Format>" + dv[i]["Format"].ToString() + "</Format>"
                                                + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                                + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                                + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                                + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                 + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }

        public static DataTable LOAD_GRID_UIPanel(string FormName, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Dock.UIPanelInnerContainer _Panel)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>S</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = CCollection + "<Column" + 0 + " ID='C'>"
                                               + "<AllowGroup>" + "False" + "</AllowGroup>"
                                               + "<Caption>Chọn</Caption>"
                                               + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                               + "<Key>" + "Chon" + "</Key>"
                                               + "<Position>" + "0" + "</Position>"
                                               + "<Width>" + 20 + "</Width>"
                                               + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                               + "</Column" + 0 + ">";
                }
                if (dv[i]["name"].ToString() == "Ngaychungtu" || dv[i]["name"].ToString() == "Ngayhachtoan"
                    || dv[i]["name"].ToString() == "Ngaydat" || dv[i]["name"].ToString() == "Ngaygiao" 
                    || dv[i]["name"].ToString() == "Ngayphatsinh" || dv[i]["name"].ToString() == "Ngayapdung"
                    || dv[i]["name"].ToString() == "Ngaydieuchinh" || dv[i]["name"].ToString() == "Ngaygiaodieuchinh"
                    || dv[i]["name"].ToString() == "Chotngaygiao" || dv[i]["name"].ToString() == "Ngaytra"
                    || dv[i]["name"].ToString() == "Ngayhethanpo" || dv[i]["name"].ToString() == "Ngaymarket"
                    || dv[i]["name"].ToString() == "Ngaychay" || dv[i]["name"].ToString() == "Ngay"
                    || dv[i]["name"].ToString() == "Ngayha" || dv[i]["name"].ToString() == "Ngaynhap"
                    || dv[i]["name"].ToString() == "Ngayhoanthanh" || dv[i]["name"].ToString() == "Ngaycuoink"
                    || dv[i]["name"].ToString() == "Ngaytrang" || dv[i]["name"].ToString() == "Ngayin1"
                    || dv[i]["name"].ToString() == "Ngayin2" || dv[i]["name"].ToString() == "Ngayxuat"
                    || dv[i]["name"].ToString() == "Ngayhopdong" || dv[i]["name"].ToString() == "Ngaythongquan"
                    || dv[i]["name"].ToString() == "Ngayhoadon" || dv[i]["name"].ToString() == "Ngayctkt")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yyyy</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["name"].ToString() == "Sotien"
                    || dv[i]["name"].ToString() == "Soluong" || dv[i]["name"].ToString() == "Tongsoluong"
                    || dv[i]["name"].ToString() == "Soluongdieuchinh"
                    || dv[i]["name"].ToString() == "Tien" || dv[i]["name"].ToString() == "TienNsnn"
                    || dv[i]["name"].ToString() == "Dutoan" || dv[i]["name"].ToString() == "DutoanNsnn"
                    || dv[i]["name"].ToString() == "Dutoanbosung" || dv[i]["name"].ToString() == "DutoanbosungNsnn"
                    || dv[i]["name"].ToString() == "Dutoanhuy" || dv[i]["name"].ToString() == "DutoanhuyNsnn"
                    || dv[i]["name"].ToString() == "Dunoluongdau" || dv[i]["name"].ToString() == "Ducoluongdau"
                    || dv[i]["name"].ToString() == "Dunodauky" || dv[i]["name"].ToString() == "Ducodauky"
                    || dv[i]["name"].ToString() == "Luykenoluong" || dv[i]["name"].ToString() == "Luykecoluong"
                    || dv[i]["name"].ToString() == "Luykeno" || dv[i]["name"].ToString() == "Luykeco"
                    || dv[i]["name"].ToString() == "Luykenotukhoidau" || dv[i]["name"].ToString() == "Luykecotukhoidau"
                    || dv[i]["name"].ToString() == "DunoNsnn" || dv[i]["name"].ToString() == "DucoNsnn"
                    || dv[i]["name"].ToString() == "LuykenoNsnn" || dv[i]["name"].ToString() == "LuykecoNsnn"
                    || dv[i]["name"].ToString() == "Phatsinhno" || dv[i]["name"].ToString() == "Phatsinhco"
                    || dv[i]["name"].ToString() == "Phatsinhnoluong" || dv[i]["name"].ToString() == "Phatsinhcoluong"
                    || dv[i]["name"].ToString() == "PhatsinhnoNsnn" || dv[i]["name"].ToString() == "PhatsinhcoNsnn"
                    || dv[i]["name"].ToString() == "Thu" || dv[i]["name"].ToString() == "Chi"
                    || dv[i]["name"].ToString() == "Tiennopthue" || dv[i]["name"].ToString() == "Tienthanhtoandvh"
                    || dv[i]["name"].ToString() == "Dorong" || dv[i]["name"].ToString() == "Trongluong"
                    || dv[i]["name"].ToString() == "Congsuat" || dv[i]["name"].ToString() == "Ca"
                    || dv[i]["name"].ToString() == "Lanha" || dv[i]["name"].ToString() == "Sodau"
                    || dv[i]["name"].ToString() == "Socuoi"
                    || dv[i]["name"].ToString() == "Chieudai" || dv[i]["name"].ToString() == "Luong"
                    || dv[i]["name"].ToString() == "Songaytruluisoi" || dv[i]["name"].ToString() == "Songaytruluidet"
                    || dv[i]["name"].ToString() == "Trongluongphoi" || dv[i]["name"].ToString() == "TrongluongkhongPE"
                    || dv[i]["name"].ToString() == "Tongtrongluong" || dv[i]["name"].ToString() == "Chieudaicat"
                    || dv[i]["name"].ToString() == "Khoiluongsoi" || dv[i]["name"].ToString() == "Khoiluongmanh"
                    || dv[i]["name"].ToString() == "Soluong" || dv[i]["name"].ToString() == "Trangthai"
                    || dv[i]["name"].ToString() == "Klsoihoanthanh" || dv[i]["name"].ToString() == "Klmanhhoanthanh"
                    || dv[i]["name"].ToString() == "Kldukien" || dv[i]["name"].ToString() == "Tongnhucausoi"
                    || dv[i]["name"].ToString() == "Catrong" || dv[i]["name"].ToString() == "Congsuattrong"
                    || dv[i]["name"].ToString() == "Chieudaixuat" || dv[i]["name"].ToString() == "Khoiluongxuat"
                    || dv[i]["name"].ToString() == "Cong" || dv[i]["name"].ToString() == "Congthaykho"
                    || dv[i]["name"].ToString() == "Thanhtien" 
                    || dv[i]["name"].ToString() == "Soluongconlai" || dv[i]["name"].ToString() == "Khoiluongconlai"
                    || dv[i]["name"].ToString() == "Tongsonhapkho" || dv[i]["name"].ToString() == "Tongsohieuchinh"
                    || dv[i]["name"].ToString() == "Soluonghieuchinh" || dv[i]["name"].ToString() == "Soluongtinhluong"
                    || dv[i]["name"].ToString() == "Soluongchuatinhluong" || dv[i]["name"].ToString() == "Sometchuain"
                    || dv[i]["name"].ToString() == "Sosanpham1" || dv[i]["name"].ToString() == "Sosanpham2"
                    || dv[i]["name"].ToString() == "Somet1" || dv[i]["name"].ToString() == "Somet2"
                    || dv[i]["name"].ToString() == "Soluongdat" || dv[i]["name"].ToString() == "Soluongdagiao"
                    || dv[i]["name"].ToString() == "Soluonggiao" || dv[i]["name"].ToString() == "Soluongtralai"
                    || dv[i]["name"].ToString() == "Soluongconlai" || dv[i]["name"].ToString() == "Chotsoluong"
                    || dv[i]["name"].ToString() == "Congsuatsoi" || dv[i]["name"].ToString() == "Congsuatdet"
                    || dv[i]["name"].ToString() == "Congsuattrang" || dv[i]["name"].ToString() == "Congsuatin"
                    || dv[i]["name"].ToString() == "Congsuatlechsuon" || dv[i]["name"].ToString() == "Congsuatcat"
                    || dv[i]["name"].ToString() == "Congsuatmay" || dv[i]["name"].ToString() == "Congsuatlong"
                    || dv[i]["name"].ToString() == "Congsuatvien" || dv[i]["name"].ToString() == "Congsuatdongkien"
                    || dv[i]["name"].ToString() == "Hieusuatsoi" || dv[i]["name"].ToString() == "Hieusuatdet"
                    || dv[i]["name"].ToString() == "Hieusuattrang" || dv[i]["name"].ToString() == "Hieusuatin"
                    || dv[i]["name"].ToString() == "Hieusuatlechsuon" || dv[i]["name"].ToString() == "Hieusuatcat"
                    || dv[i]["name"].ToString() == "Hieusuatmay" || dv[i]["name"].ToString() == "Hieusuatlong"
                    || dv[i]["name"].ToString() == "Hieusuatvien" || dv[i]["name"].ToString() == "Hieusuatdongkien"
                    || dv[i]["name"].ToString() == "Sanluongsoi" || dv[i]["name"].ToString() == "Sanluongdet"
                    || dv[i]["name"].ToString() == "Sanluongtrang" || dv[i]["name"].ToString() == "Sanluongin"
                    || dv[i]["name"].ToString() == "Sanluonglechsuon" || dv[i]["name"].ToString() == "Sanluongcat"
                    || dv[i]["name"].ToString() == "Sanluongmay" || dv[i]["name"].ToString() == "Sanluonglong"
                    || dv[i]["name"].ToString() == "Sanluongvien" || dv[i]["name"].ToString() == "Sanluongdongkien"
                    || dv[i]["name"].ToString() == "Trongluongbao" || dv[i]["name"].ToString() == "Trongluongpe"
                    || dv[i]["name"].ToString() == "Loinhuantheocai" || dv[i]["name"].ToString() == "Loinhuantheokg"
                    || dv[i]["name"].ToString() == "Sanluongtoida" || dv[i]["name"].ToString() == "Tygia"
                    || dv[i]["name"].ToString() == "Sanluong" || dv[i]["name"].ToString() == "Kichthuoctang"
                    || dv[i]["name"].ToString() == "Sokien" || dv[i]["name"].ToString() == "Sothutuxep"
                    || dv[i]["name"].ToString() == "Thanhtienvnd" || dv[i]["name"].ToString() == "Thanhtienusd"
                    || dv[i]["name"].ToString() == "Tientamung")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (dv[i]["name"].ToString() == "Tylehaomon" || dv[i]["name"].ToString() == "Khoiluong"
                    || dv[i]["name"].ToString() == "Sokg" || dv[i]["name"].ToString() == "Sokgdukien"
                    || dv[i]["name"].ToString() == "Doben" || dv[i]["name"].ToString() == "Dodandai"
                    || dv[i]["name"].ToString() == "Phantramcongsuatnhamay"
                    || dv[i]["name"].ToString() == "Tang" || dv[i]["name"].ToString() == "Giam"
                    || dv[i]["name"].ToString() == "Dongia" 
                    || dv[i]["name"].ToString() == "Dongiabaochuavat" || dv[i]["name"].ToString() == "Dongiapechuavat"
                    || dv[i]["name"].ToString() == "Dongiatongchuavat" || dv[i]["name"].ToString() == "Dongiatongcovat"
                    || dv[i]["name"].ToString() == "Dongiabaocovat" || dv[i]["name"].ToString() == "Dongiapecovat"
                    || dv[i]["name"].ToString() == "Giavon" || dv[i]["name"].ToString() == "Dongiadieuchinh"
                    || dv[i]["name"].ToString() == "Gia" || dv[i]["name"].ToString() == "Giahientai"
                    || dv[i]["name"].ToString() == "Chiphitheokg" || dv[i]["name"].ToString() == "Chiphitheocai"
                    || dv[i]["name"].ToString() == "Chiphinguyenlieucai" || dv[i]["name"].ToString() == "Chiphigiacongcai"
                    || dv[i]["name"].ToString() == "Chiphichungcai" || dv[i]["name"].ToString() == "Chiphibanhangcai"
                    || dv[i]["name"].ToString() == "Giavontheocai" || dv[i]["name"].ToString() == "Giavontheokg"
                    || dv[i]["name"].ToString() == "Giabantheocai" || dv[i]["name"].ToString() == "Giabantheokg"
                    || dv[i]["name"].ToString() == "Chiphinguyenlieukg" || dv[i]["name"].ToString() == "Chiphigiacongkg"
                    || dv[i]["name"].ToString() == "Chiphichungkg" || dv[i]["name"].ToString() == "Chiphibanhangkg"
                    || dv[i]["name"].ToString() == "ChiphinguyenlieuPE" || dv[i]["name"].ToString() == "ChiphigiacongPE"
                    || dv[i]["name"].ToString() == "Chiphitong" || dv[i]["name"].ToString() == "Tongchiphitheocai"
                    || dv[i]["name"].ToString() == "Khoiluongphe" || dv[i]["name"].ToString() == "Tylephantram")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + "#,##0.00" + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (dv[i]["name"].ToString() == "Somet" )
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + "#,###" + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;

            _GridEX.GroupByBoxInfoText = "Nhóm dữ liệu theo cột";
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }
        public static DataTable LOAD_GRID_UIPanel(string FormName, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.FM.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>S</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>Chọn</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + 20 + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">";
                }
                if (dv[i]["name"].ToString() == "Ngaychungtu" || dv[i]["name"].ToString() == "Ngayhachtoan"
                    || dv[i]["name"].ToString() == "Ngaydat" || dv[i]["name"].ToString() == "Ngaygiao"
                    || dv[i]["name"].ToString() == "Ngayphatsinh" || dv[i]["name"].ToString() == "Ngayapdung"
                    || dv[i]["name"].ToString() == "Ngaydieuchinh" || dv[i]["name"].ToString() == "Ngaygiaodieuchinh"
                    || dv[i]["name"].ToString() == "Chotngaygiao" || dv[i]["name"].ToString() == "Ngaytra"
                    || dv[i]["name"].ToString() == "Ngayhethanpo" || dv[i]["name"].ToString() == "Ngaymarket"
                    || dv[i]["name"].ToString() == "Ngaychay" || dv[i]["name"].ToString() == "Ngay"
                    || dv[i]["name"].ToString() == "Ngayha" || dv[i]["name"].ToString() == "Ngaynhap"
                    || dv[i]["name"].ToString() == "Ngayhoanthanh" || dv[i]["name"].ToString() == "Ngaycuoink"
                    || dv[i]["name"].ToString() == "Ngaytrang" || dv[i]["name"].ToString() == "Ngayin1"
                    || dv[i]["name"].ToString() == "Ngayin2" || dv[i]["name"].ToString() == "Ngayxuat"
                    || dv[i]["name"].ToString() == "Ngayhopdong" || dv[i]["name"].ToString() == "Ngaythongquan"
                    || dv[i]["name"].ToString() == "Ngayhoadon" || dv[i]["name"].ToString() == "Ngayctkt")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yyyy</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["name"].ToString() == "Sotien"
                    || dv[i]["name"].ToString() == "Soluong" || dv[i]["name"].ToString() == "Tongsoluong"
                    || dv[i]["name"].ToString() == "Soluongdieuchinh"
                    || dv[i]["name"].ToString() == "Tien" || dv[i]["name"].ToString() == "TienNsnn"
                    || dv[i]["name"].ToString() == "Dutoan" || dv[i]["name"].ToString() == "DutoanNsnn"
                    || dv[i]["name"].ToString() == "Dutoanbosung" || dv[i]["name"].ToString() == "DutoanbosungNsnn"
                    || dv[i]["name"].ToString() == "Dutoanhuy" || dv[i]["name"].ToString() == "DutoanhuyNsnn"
                    || dv[i]["name"].ToString() == "Dunoluongdau" || dv[i]["name"].ToString() == "Ducoluongdau"
                    || dv[i]["name"].ToString() == "Dunodauky" || dv[i]["name"].ToString() == "Ducodauky"
                    || dv[i]["name"].ToString() == "Luykenoluong" || dv[i]["name"].ToString() == "Luykecoluong"
                    || dv[i]["name"].ToString() == "Luykeno" || dv[i]["name"].ToString() == "Luykeco"
                    || dv[i]["name"].ToString() == "Luykenotukhoidau" || dv[i]["name"].ToString() == "Luykecotukhoidau"
                    || dv[i]["name"].ToString() == "DunoNsnn" || dv[i]["name"].ToString() == "DucoNsnn"
                    || dv[i]["name"].ToString() == "LuykenoNsnn" || dv[i]["name"].ToString() == "LuykecoNsnn"
                    || dv[i]["name"].ToString() == "Phatsinhno" || dv[i]["name"].ToString() == "Phatsinhco"
                    || dv[i]["name"].ToString() == "Phatsinhnoluong" || dv[i]["name"].ToString() == "Phatsinhcoluong"
                    || dv[i]["name"].ToString() == "PhatsinhnoNsnn" || dv[i]["name"].ToString() == "PhatsinhcoNsnn"
                    || dv[i]["name"].ToString() == "Thu" || dv[i]["name"].ToString() == "Chi"
                    || dv[i]["name"].ToString() == "Tiennopthue" || dv[i]["name"].ToString() == "Tienthanhtoandvh"
                    || dv[i]["name"].ToString() == "Dorong" || dv[i]["name"].ToString() == "Trongluong"
                    || dv[i]["name"].ToString() == "Congsuat" || dv[i]["name"].ToString() == "Ca"
                    || dv[i]["name"].ToString() == "Lanha" || dv[i]["name"].ToString() == "Sodau"
                    || dv[i]["name"].ToString() == "Socuoi"
                    || dv[i]["name"].ToString() == "Chieudai" || dv[i]["name"].ToString() == "Luong"
                    || dv[i]["name"].ToString() == "Songaytruluisoi" || dv[i]["name"].ToString() == "Songaytruluidet"
                    || dv[i]["name"].ToString() == "Trongluongphoi" || dv[i]["name"].ToString() == "TrongluongkhongPE"
                    || dv[i]["name"].ToString() == "Tongtrongluong" || dv[i]["name"].ToString() == "Chieudaicat"
                    || dv[i]["name"].ToString() == "Khoiluongsoi" || dv[i]["name"].ToString() == "Khoiluongmanh"
                    || dv[i]["name"].ToString() == "Soluong" || dv[i]["name"].ToString() == "Trangthai"
                    || dv[i]["name"].ToString() == "Klsoihoanthanh" || dv[i]["name"].ToString() == "Klmanhhoanthanh"
                    || dv[i]["name"].ToString() == "Kldukien" || dv[i]["name"].ToString() == "Tongnhucausoi"
                    || dv[i]["name"].ToString() == "Catrong" || dv[i]["name"].ToString() == "Congsuattrong"
                    || dv[i]["name"].ToString() == "Chieudaixuat" || dv[i]["name"].ToString() == "Khoiluongxuat"
                    || dv[i]["name"].ToString() == "Cong" || dv[i]["name"].ToString() == "Congthaykho"
                    || dv[i]["name"].ToString() == "Thanhtien"
                    || dv[i]["name"].ToString() == "Soluongconlai" || dv[i]["name"].ToString() == "Khoiluongconlai"
                    || dv[i]["name"].ToString() == "Tongsonhapkho" || dv[i]["name"].ToString() == "Tongsohieuchinh"
                    || dv[i]["name"].ToString() == "Soluonghieuchinh" || dv[i]["name"].ToString() == "Soluongtinhluong"
                    || dv[i]["name"].ToString() == "Soluongchuatinhluong" || dv[i]["name"].ToString() == "Sometchuain"
                    || dv[i]["name"].ToString() == "Sosanpham1" || dv[i]["name"].ToString() == "Sosanpham2"
                    || dv[i]["name"].ToString() == "Somet1" || dv[i]["name"].ToString() == "Somet2"
                    || dv[i]["name"].ToString() == "Soluongdat" || dv[i]["name"].ToString() == "Soluongdagiao"
                    || dv[i]["name"].ToString() == "Soluonggiao" || dv[i]["name"].ToString() == "Soluongtralai"
                    || dv[i]["name"].ToString() == "Soluongconlai" || dv[i]["name"].ToString() == "Chotsoluong"
                    || dv[i]["name"].ToString() == "Congsuatsoi" || dv[i]["name"].ToString() == "Congsuatdet"
                    || dv[i]["name"].ToString() == "Congsuattrang" || dv[i]["name"].ToString() == "Congsuatin"
                    || dv[i]["name"].ToString() == "Congsuatlechsuon" || dv[i]["name"].ToString() == "Congsuatcat"
                    || dv[i]["name"].ToString() == "Congsuatmay" || dv[i]["name"].ToString() == "Congsuatlong"
                    || dv[i]["name"].ToString() == "Congsuatvien" || dv[i]["name"].ToString() == "Congsuatdongkien"
                    || dv[i]["name"].ToString() == "Hieusuatsoi" || dv[i]["name"].ToString() == "Hieusuatdet"
                    || dv[i]["name"].ToString() == "Hieusuattrang" || dv[i]["name"].ToString() == "Hieusuatin"
                    || dv[i]["name"].ToString() == "Hieusuatlechsuon" || dv[i]["name"].ToString() == "Hieusuatcat"
                    || dv[i]["name"].ToString() == "Hieusuatmay" || dv[i]["name"].ToString() == "Hieusuatlong"
                    || dv[i]["name"].ToString() == "Hieusuatvien" || dv[i]["name"].ToString() == "Hieusuatdongkien"
                    || dv[i]["name"].ToString() == "Sanluongsoi" || dv[i]["name"].ToString() == "Sanluongdet"
                    || dv[i]["name"].ToString() == "Sanluongtrang" || dv[i]["name"].ToString() == "Sanluongin"
                    || dv[i]["name"].ToString() == "Sanluonglechsuon" || dv[i]["name"].ToString() == "Sanluongcat"
                    || dv[i]["name"].ToString() == "Sanluongmay" || dv[i]["name"].ToString() == "Sanluonglong"
                    || dv[i]["name"].ToString() == "Sanluongvien" || dv[i]["name"].ToString() == "Sanluongdongkien"
                    || dv[i]["name"].ToString() == "Trongluongbao" || dv[i]["name"].ToString() == "Trongluongpe"
                    || dv[i]["name"].ToString() == "Loinhuantheocai" || dv[i]["name"].ToString() == "Loinhuantheokg"
                    || dv[i]["name"].ToString() == "Sanluongtoida" || dv[i]["name"].ToString() == "Tygia"
                    || dv[i]["name"].ToString() == "Sanluong" || dv[i]["name"].ToString() == "Kichthuoctang"
                    || dv[i]["name"].ToString() == "Sokien" || dv[i]["name"].ToString() == "Sothutuxep"
                    || dv[i]["name"].ToString() == "Thanhtienvnd" || dv[i]["name"].ToString() == "Thanhtienusd"
                    || dv[i]["name"].ToString() == "Tientamung")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (dv[i]["name"].ToString() == "Tylehaomon" || dv[i]["name"].ToString() == "Khoiluong"
                    || dv[i]["name"].ToString() == "Sokg" || dv[i]["name"].ToString() == "Sokgdukien"
                    || dv[i]["name"].ToString() == "Doben" || dv[i]["name"].ToString() == "Dodandai"
                    || dv[i]["name"].ToString() == "Phantramcongsuatnhamay"
                    || dv[i]["name"].ToString() == "Tang" || dv[i]["name"].ToString() == "Giam"
                    || dv[i]["name"].ToString() == "Dongia"
                    || dv[i]["name"].ToString() == "Dongiabaochuavat" || dv[i]["name"].ToString() == "Dongiapechuavat"
                    || dv[i]["name"].ToString() == "Dongiatongchuavat" || dv[i]["name"].ToString() == "Dongiatongcovat"
                    || dv[i]["name"].ToString() == "Dongiabaocovat" || dv[i]["name"].ToString() == "Dongiapecovat"
                    || dv[i]["name"].ToString() == "Giavon" || dv[i]["name"].ToString() == "Dongiadieuchinh"
                    || dv[i]["name"].ToString() == "Gia" || dv[i]["name"].ToString() == "Giahientai"
                    || dv[i]["name"].ToString() == "Chiphitheokg" || dv[i]["name"].ToString() == "Chiphitheocai"
                    || dv[i]["name"].ToString() == "Chiphinguyenlieucai" || dv[i]["name"].ToString() == "Chiphigiacongcai"
                    || dv[i]["name"].ToString() == "Chiphichungcai" || dv[i]["name"].ToString() == "Chiphibanhangcai"
                    || dv[i]["name"].ToString() == "Giavontheocai" || dv[i]["name"].ToString() == "Giavontheokg"
                    || dv[i]["name"].ToString() == "Giabantheocai" || dv[i]["name"].ToString() == "Giabantheokg"
                    || dv[i]["name"].ToString() == "Chiphinguyenlieukg" || dv[i]["name"].ToString() == "Chiphigiacongkg"
                    || dv[i]["name"].ToString() == "Chiphichungkg" || dv[i]["name"].ToString() == "Chiphibanhangkg"
                    || dv[i]["name"].ToString() == "ChiphinguyenlieuPE" || dv[i]["name"].ToString() == "ChiphigiacongPE"
                    || dv[i]["name"].ToString() == "Chiphitong" || dv[i]["name"].ToString() == "Tongchiphitheocai"
                    || dv[i]["name"].ToString() == "Khoiluongphe" || dv[i]["name"].ToString() == "Tylephantram")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + "#,##0.00" + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (dv[i]["name"].ToString() == "Somet")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + "#,###" + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                              + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;

            _GridEX.GroupByBoxInfoText = "Nhóm dữ liệu theo cột";
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }
        public static DataTable LOAD_GRID_UIPanel_C(string FormName, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>Chọn</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + 20 + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">";
                }

                if (dv[i]["name"].ToString().Trim().Equals("Ngayphatsinh") || dv[i]["name"].ToString().Trim().Equals("Ngaytao")
                    || dv[i]["name"].ToString().Trim().Equals("Ngayhachtoan")
                    || dv[i]["name"].ToString().Trim().Equals("Ngaybatdau") || dv[i]["name"].ToString().Trim().Equals("Ngayketthuc")
                    || dv[i]["name"].ToString().Trim().Equals("Datebegin") || dv[i]["name"].ToString().Trim().Equals("Datefinish"))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>dd/MM/yyyy</FormatString>"
                                             + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("TTiencovat") || dv[i]["name"].ToString().Trim().Equals("TTienchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Ttiencovat") || dv[i]["name"].ToString().Trim().Equals("Ttienchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabinhquancovat") || dv[i]["name"].ToString().Trim().Equals("Giabinhquanchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giamuacovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat") || dv[i]["name"].ToString().Trim().Equals("Giabanbuonchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabanbuoncovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlecovat")
                    )
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>#,##0.0000</FormatString>"
                                             + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("Soluong") || dv[i]["name"].ToString().Trim().Equals("Tongsoluong") || dv[i]["name"].ToString().Trim().Equals("SL_TON_NHAN")
                    || dv[i]["name"].ToString() == "Dongiabaochuavat" || dv[i]["name"].ToString() == "Dongiapechuavat" || dv[i]["name"].ToString() == "Dongiatongchuavat"
                    || dv[i]["name"].ToString() == "Dongiabaocovat" || dv[i]["name"].ToString() == "Dongiapecovat" || dv[i]["name"].ToString() == "Dongiatongcovat"
                    || dv[i]["name"].ToString().Trim().Equals("SL_TON_XUAT") || dv[i]["name"].ToString().Trim().Equals("Sltontoida") || dv[i]["name"].ToString().Trim().Equals("Sltontoithieu"))
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>#,##0</FormatString>"
                                             + "<CellStyle><BackColor>128,128,255</BackColor><ForeColor>Yellow</ForeColor><FontBold>True</FontBold><FontItalic>True</FontItalic><TextAlignment>Center</TextAlignment></CellStyle>"
                                             + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }


            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }
        public static DataTable LOAD_GRID_TabPage(string FormName, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Tab.UITabPage _TabPage, bool isEditRows)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.FM.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);

            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["FORMAT"].ToString() + "</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">";
                }
                else if (dv[i]["name"].ToString() == "Ngayhachtoan" || dv[i]["name"].ToString() == "Ngayhoadon" || dv[i]["name"].ToString() == "Ngayctkt")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>dd/MM/yyyy</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else if (dv[i]["name"].ToString() == "Sotien")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                } if (dv.Table.Columns.Contains("Type") == true && dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<FilterRowComparison>Contains</FilterRowComparison>"
                                               + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            if (_TabPage != null)
            {
                _GridEX.Height = _TabPage.Height;
                _GridEX.Width = _TabPage.Width;
            }            
            _GridEX.RecordNavigator = true;
            if (isEditRows)
            {
                _GridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            }
            else
            {
                _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.None;
            _GridEX.GroupByBoxVisible = false;
            if (_TabPage != null)
            {
                _TabPage.AutoScroll = true;
                _TabPage.Controls.Add(_GridEX);
            }            
            return dttemplate;
        }

        public static DataTable LOAD_GRID_Panel(string FormName, DataGridView _DataGridView, System.Windows.Forms.Panel _Panel)
        {
            _DataGridView.Columns.Clear();
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            for (int i = 0; i < dttemplate.Rows.Count; i++)
            {
                DataGridViewTextBoxColumn Colum = new DataGridViewTextBoxColumn();
                Colum.Name = dttemplate.Rows[i]["name"].ToString();
                Colum.HeaderText = dttemplate.Rows[i]["headerText"].ToString();
                Colum.DataPropertyName = dttemplate.Rows[i]["name"].ToString();
                if (dttemplate.Rows[i]["value"].ToString().Trim().Equals("0") || dttemplate.Rows[i]["value"].ToString().Trim().Equals("2"))
                {
                    Colum.Visible = false;
                }
                Colum.Width = int.Parse(dttemplate.Rows[i]["Width"].ToString());
                _DataGridView.Columns.Add(Colum);
                _DataGridView.AutoGenerateColumns = false;
                _DataGridView.AutoSize = true;
                _DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                _DataGridView.AllowUserToAddRows = false;
                _DataGridView.ReadOnly = true;
                _DataGridView.Location = new System.Drawing.Point(22, 42);
                _DataGridView.Size = new System.Drawing.Size(905, 368);

                _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            string strtest = string.Empty;
            for (int j = 0; j < _DataGridView.Columns.Count; j++)
            {
                for (int k = 0; k < dttemplate.Rows.Count; k++)
                {
                    if (_DataGridView.Columns[j].Name == dttemplate.Rows[k]["name"].ToString())
                    {
                        try
                        {
                            _DataGridView.Columns[j].DisplayIndex = int.Parse(dttemplate.Rows[k]["Thutu"].ToString());
                            break;
                        }
                        catch { }
                    }
                }
            }
            _DataGridView.Refresh();
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_DataGridView);
            return dttemplate;
        }

        public static DataTable LOAD_GRID_Panel_CHECK(string FormName, DataGridView _DataGridView, System.Windows.Forms.Panel _Panel)
        {
            _DataGridView.Columns.Clear();
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataGridViewCheckBoxColumn Checkcolume = new DataGridViewCheckBoxColumn();
            Checkcolume.Name = "C";
            Checkcolume.HeaderText = "Chọn";
            Checkcolume.Width = 40;
            Checkcolume.ValueType=typeof(bool);
            //Checkcolume.ThreeState = true;
            //Checkcolume.TrueValue = true;
            _DataGridView.Columns.Add(Checkcolume);
            for (int i = 0; i < dttemplate.Rows.Count; i++)
            {
                DataGridViewTextBoxColumn Colum = new DataGridViewTextBoxColumn();
                Colum.Name = dttemplate.Rows[i]["name"].ToString();
                Colum.HeaderText = dttemplate.Rows[i]["headerText"].ToString();
                Colum.DataPropertyName = dttemplate.Rows[i]["name"].ToString();
                if (dttemplate.Rows[i]["value"].ToString().Trim().Equals("0") || dttemplate.Rows[i]["value"].ToString().Trim().Equals("2"))
                {
                    Colum.Visible = false;
                }
                Colum.Width = int.Parse(dttemplate.Rows[i]["Width"].ToString());
                _DataGridView.Columns.Add(Colum);
                _DataGridView.AutoGenerateColumns = false;
                _DataGridView.AutoSize = true;
                _DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                _DataGridView.AllowUserToAddRows = false;
                _DataGridView.ReadOnly = true;
                _DataGridView.Location = new System.Drawing.Point(22, 42);
                _DataGridView.Size = new System.Drawing.Size(905, 368);

                _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            string strtest = string.Empty;
            for (int j = 0; j < _DataGridView.Columns.Count; j++)
            {
                for (int k = 0; k < dttemplate.Rows.Count; k++)
                {
                    if (_DataGridView.Columns[j].Name == dttemplate.Rows[k]["name"].ToString())
                    {
                        try
                        {
                            _DataGridView.Columns[j].DisplayIndex = int.Parse(dttemplate.Rows[k]["Thutu"].ToString());
                            break;
                        }
                        catch { }
                    }
                }
            }
            _DataGridView.Refresh();
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_DataGridView);
            return dttemplate;
        }

        public static void Create_GRID_CONIG(DataTable dt, string filename)
        {
            DataTable dtemp = new DataTable("viewgrid");
            dtemp.Columns.Add("value", typeof(String));
            dtemp.Columns.Add("name", typeof(String));
            dtemp.Columns.Add("headerText");
            dtemp.Columns.Add("BackColor");
            dtemp.Columns.Add("SelectionBackColor");
            dtemp.Columns.Add("Width");
            dtemp.Columns.Add("Thutu");
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                DataRow r = dtemp.NewRow();
                r["value"] = "1";
                r["name"] = dt.Columns[j].ColumnName;
                r["headerText"] = dt.Columns[j].ColumnName;
                r["BackColor"] = "0";
                r["SelectionBackColor"] = "0";
                r["Width"] = "100";
                r["Thutu"] = "100";
                dtemp.Rows.Add(r);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dtemp);
            IO.GenXML(filename, ds);

        }

        public static void Create_GRID_CONIG_DATA_DM(DataTable dt, string filename, string[] fieldsList)
        {
            DataTable dtemp = new DataTable("viewgrid");
            dtemp.Columns.Add("value", typeof(String));
            dtemp.Columns.Add("name", typeof(String));
            dtemp.Columns.Add("headerText");
            dtemp.Columns.Add("BackColor");
            dtemp.Columns.Add("SelectionBackColor");
            dtemp.Columns.Add("Width");
            dtemp.Columns.Add("Thutu");
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                DataRow r = dtemp.NewRow();
                r["value"] = "1";
                r["name"] = dt.Rows[j][fieldsList[0]];
                r["headerText"] = fieldsList.Length > 1 ? dt.Rows[j][fieldsList[1]] : dt.Rows[j][fieldsList[0]];
                r["BackColor"] = "0";
                r["SelectionBackColor"] = "0";
                r["Width"] = fieldsList.Length > 2 && !string.IsNullOrEmpty(dt.Rows[j][fieldsList[2]].ToString()) && Convert.ToInt32(dt.Rows[j][fieldsList[2]].ToString()) > 0 ? dt.Rows[j][fieldsList[2]] : "100";
                r["Thutu"] = "100";
                dtemp.Rows.Add(r);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dtemp);
            IO.GenXML(filename, ds);
        }

        public static void Create_GRID_CONIG_Fomat(DataTable dt, string filename)
        {
            DataTable dtemp = new DataTable("viewgrid");
            dtemp.Columns.Add("value", typeof(String));
            dtemp.Columns.Add("name", typeof(String));
            dtemp.Columns.Add("headerText");
            dtemp.Columns.Add("BackColor");
            dtemp.Columns.Add("SelectionBackColor");
            dtemp.Columns.Add("Width");
            dtemp.Columns.Add("Thutu");
            dtemp.Columns.Add("Type");
            dtemp.Columns.Add("Format");
            dtemp.Columns.Add("TextAlignment");
            dtemp.Columns.Add("FontBold");
            dtemp.Columns.Add("ForeColor");
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                DataRow r = dtemp.NewRow();
                r["value"] = "1";
                r["name"] = dt.Columns[j].ColumnName;
                r["headerText"] = dt.Columns[j].ColumnName;
                r["BackColor"] = "0";
                r["SelectionBackColor"] = "0";
                r["Width"] = "100";
                r["Thutu"] = "100";
                r["Type"] = "S";
                r["Format"] = "0";
                r["TextAlignment"] = "Near";
                r["FontBold"] = "False";
                r["ForeColor"] = "Black";
                dtemp.Rows.Add(r);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dtemp);
            IO.GenXML(GD.FM.LIB.PATH.ERP_PATH + @"\XMLCONFIG\" + filename + ".xml", ds);
        }

        public static DataTable LOAD_GRID_Panel_CHECK(string FormName, DataGridView _DataGridView, Janus.Windows.UI.Tab.UITabPage _TabPage)
        {
            _DataGridView.Columns.Clear();
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataGridViewCheckBoxColumn Checkcolume = new DataGridViewCheckBoxColumn();            
            Checkcolume.Name = "C";
            Checkcolume.HeaderText = "Chọn";            
            Checkcolume.Width = 40;            
            Checkcolume.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _DataGridView.Columns.Add(Checkcolume);            
            for (int i = 0; i < dttemplate.Rows.Count; i++)
            {
                DataGridViewTextBoxColumn Colum = new DataGridViewTextBoxColumn();
                Colum.Name = dttemplate.Rows[i]["name"].ToString();
                Colum.HeaderText = dttemplate.Rows[i]["headerText"].ToString();
                Colum.DataPropertyName = dttemplate.Rows[i]["name"].ToString();
                if (dttemplate.Rows[i]["value"].ToString().Trim().Equals("0") || dttemplate.Rows[i]["value"].ToString().Trim().Equals("2"))
                {
                    Colum.Visible = false;
                }
                Colum.Width = int.Parse(dttemplate.Rows[i]["Width"].ToString());
                _DataGridView.Columns.Add(Colum);
                _DataGridView.AutoGenerateColumns = false;
                _DataGridView.AutoSize = true;
                _DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                _DataGridView.AllowUserToAddRows = false;
                //_DataGridView.ReadOnly = true;
                _DataGridView.Location = new System.Drawing.Point(22, 42);
                _DataGridView.Size = new System.Drawing.Size(905, 368);
                _DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;                                
            }
            string strtest = string.Empty;
            for (int j = 0; j < _DataGridView.Columns.Count; j++)
            {
                for (int k = 0; k < dttemplate.Rows.Count; k++)
                {
                    if (_DataGridView.Columns[j].Name == dttemplate.Rows[k]["name"].ToString())
                    {
                        try
                        {
                            _DataGridView.Columns[j].DisplayIndex = int.Parse(dttemplate.Rows[k]["Thutu"].ToString());
                            break;
                        }
                        catch { }
                    }
                }
            }
            _DataGridView.Refresh();
            _TabPage.Controls.Add(_DataGridView);
            return dttemplate;
        }

        public static DataTable LOAD_GRID_UIPanel_Format(string FormName, Janus.Windows.GridEX.GridEX _GridEX, Janus.Windows.UI.Dock.UIPanelInnerContainer _Panel)
        {
            //DmkhachhangManager _TablecolumnManager = new DmkhachhangManager();
            //DataTable dt111 = _TablecolumnManager.Clone();
            //GD.FM.LIB.GRID_COMM.Create_GRID_CONIG(dt111, GD.FM.LIB.PATH.ERP_PATH + @"\XMLCONFIG\FRM_DMKHACHHANG.xml");

            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1' OR value='2'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["value"].ToString() == "2")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position><Visible>FALSE</Visible></Column" + i + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">";
                }
                if (dv[i]["Type"].ToString() == "D")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                              + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                if (dv[i]["Type"].ToString() == "N")
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                              + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                              + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                              + "<FormatString>" + STATIC_PARAM.FormatNumber_Grid + "</FormatString>"
                                              + "<TextAlignment>Far</TextAlignment>"
                                              + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                              + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                              + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                              + "<Position>" + i + "</Position></Column" + i + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + i + " ID='" + dv[i]["name"].ToString() + "'>"
                                                + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                                + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                                + "<FormatString>" + dv[i]["Format"].ToString() + "</FormatString>"
                                                + "<TextAlignment>" + dv[i]["TextAlignment"].ToString() + "</TextAlignment>"
                                                + "<CellStyle><ForeColor>" + dv[i]["ForeColor"].ToString() + "</ForeColor>"
                                                + "<FontBold>" + dv[i]["FontBold"].ToString() + "</FontBold></CellStyle>"
                                                + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                                 + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                                + "<Position>" + i + "</Position></Column" + i + ">";
                }
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            // _GridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection='true'>" +
            //"<Column0 ID='ID'><Caption>ID</Caption><DataMember>ID</DataMember><Key>ID</Key><Position>0</Position></Column0>"
            //+ "<Column1 ID='Name'><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position>1</Position></Column1></Columns>"
            //+ "<GroupCondition ID='' /></RootTable></GridEXLayoutData>";

            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            //_GridEX.AllowAddNew = InheritableBoolean.False;
            //_GridEX.AllowEdit = InheritableBoolean.True;
            //_GridEX.AllowDelete = InheritableBoolean.False;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            _Panel.AutoScroll = true;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;
        }

        public static DataTable LOAD_JGRID_ROWSELECT_CHECK(string FormName, Janus.Windows.GridEX.GridEX _GridEX, System.Windows.Forms.Panel _Panel,bool check)
        {
            DataTable dttemplate = GET_DATA_CONFIGXML(FormName);
            try
            {
                dttemplate = dttemplate.Select("value='1'").CopyToDataTable();
            }
            catch { }
            DataView dv = dttemplate.DefaultView;
            string BeginLayout = "<GridEXLayoutData><RootTable><Columns Collection='true'>";
            string EndLayout = "</Columns><GroupCondition ID='' /></RootTable></GridEXLayoutData>";
            string CCollection = string.Empty;
            bool ischeck = false;
            int j = 0;
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["name"].ToString().Trim().Equals("C"))
                {
                    if (check)
                    {
                        ischeck = true;
                        CCollection = "<Column" + 0 + " ID='C'>"
                                                       + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                       + "<Caption>Chọn</Caption>"
                                                       + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                       + "<Key>" + "Chon" + "</Key>"
                                                       + "<Position>" + "0" + "</Position>"
                                                       + "<Width>" + 20 + "</Width>"
                                                       + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                       + "</Column" + 0 + ">";
                    }                    
                }
                if (!check)
                { j = i; }
                else { j = i; j++; }
                if (dv[i]["name"].ToString().Trim().Equals("Ngayphatsinh") || dv[i]["name"].ToString().Trim().Equals("Ngaytao")
                    || dv[i]["name"].ToString().Trim().Equals("Ngayhachtoan")
                    || dv[i]["name"].ToString().Trim().Equals("Ngaybatdau") || dv[i]["name"].ToString().Trim().Equals("Ngayketthuc")
                    || dv[i]["name"].ToString().Trim().Equals("Datebegin") || dv[i]["name"].ToString().Trim().Equals("Datefinish"))
                {
                    CCollection = CCollection + "<Column" + j + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>dd/MM/yyyy</FormatString>"
                                             + "<Position>" + j + "</Position></Column" + j + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("TTiencovat") || dv[i]["name"].ToString().Trim().Equals("TTienchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Ttiencovat") || dv[i]["name"].ToString().Trim().Equals("Ttienchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabinhquancovat") || dv[i]["name"].ToString().Trim().Equals("Giabinhquanchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giamuacovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabanlechuavat") || dv[i]["name"].ToString().Trim().Equals("Giabanbuonchuavat")
                    || dv[i]["name"].ToString().Trim().Equals("Giabanbuoncovat") || dv[i]["name"].ToString().Trim().Equals("Giabanlecovat")
                    )
                {
                    CCollection = CCollection + "<Column" + j + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>#,##0.0000</FormatString>"
                                             + "<Position>" + j + "</Position></Column" + j + ">";
                }
                if (dv[i]["name"].ToString().Trim().Equals("Soluong") || dv[i]["name"].ToString().Trim().Equals("Tongsoluong") || dv[i]["name"].ToString().Trim().Equals("SL_TON_NHAN")
               || dv[i]["name"].ToString().Trim().Equals("SL_TON_XUAT") || dv[i]["name"].ToString().Trim().Equals("Sltontoida") || dv[i]["name"].ToString().Trim().Equals("Sltontoithieu"))
                {
                    CCollection = CCollection + "<Column" + j + " ID='" + dv[i]["name"].ToString() + "'>"
                                             + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                             + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                             + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                             + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                             + "<FormatString>#,##0</FormatString>"
                                             + "<CellStyle><BackColor>128,128,255</BackColor><ForeColor>Yellow</ForeColor><FontBold>True</FontBold><FontItalic>True</FontItalic><TextAlignment>Center</TextAlignment></CellStyle>"
                                             + "<Position>" + j + "</Position></Column" + j + ">";
                }
                else
                {
                    CCollection = CCollection + "<Column" + j + " ID='" + dv[i]["name"].ToString() + "'>"
                                               + "<Caption>" + dv[i]["headerText"].ToString() + "</Caption>"
                                               + "<DataMember>" + dv[i]["name"].ToString() + "</DataMember>"
                                               + "<Key>" + dv[i]["name"].ToString() + "</Key>"
                                               + "<Width>" + dv[i]["Width"].ToString() + "</Width>"
                                               + "<Position>" + j + "</Position></Column" + j + ">";
                }                                

            }
            if (check && !ischeck) 
            {
                CCollection = "<Column" + 0 + " ID='C'>"
                                                   + "<AllowGroup>" + "False" + "</AllowGroup>"
                                                   + "<Caption>Chọn</Caption>"
                                                   + "<ColumnType>" + "CheckBox" + "</ColumnType>"
                                                   + "<Key>" + "Chon" + "</Key>"
                                                   + "<Position>" + "0" + "</Position>"
                                                   + "<Width>" + 20 + "</Width>"
                                                   + "<ActAsSelector>" + "True" + "</ActAsSelector>"
                                                   + "</Column" + 0 + ">" + CCollection;
            }
            string layout = BeginLayout + CCollection + EndLayout;
            GridEXLayout _GridEXLayout = new GridEXLayout();
            _GridEXLayout.LayoutString = layout;
            _GridEX.DesignTimeLayout = _GridEXLayout;
            _GridEX.Height = _Panel.Height;
            _GridEX.Width = _Panel.Width;
            _GridEX.RecordNavigator = true;
            _GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            _GridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            _GridEX.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            _GridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            _GridEX.FilterRowButtonStyle = FilterRowButtonStyle.None;
            _GridEX.FilterMode = FilterMode.Automatic;
            _Panel.Controls.Add(_GridEX);
            return dttemplate;        
        }
    }
}
