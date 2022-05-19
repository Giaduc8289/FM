using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NumberFormats = System.Globalization.CultureInfo;
using System.Collections;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace TBNet.Forms.Control
{
    public partial class TextBoxNumber : TBNet.RegExTextBox
    {

        public TextBoxNumber()
        {
            InitializeComponent();
            this.TextAlign = HorizontalAlignment.Right;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Text = "";
            this.Font = new System.Drawing.Font(DefaFont, DefaSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size = new System.Drawing.Size(100, 20);
            this.ContextMenu = new ContextMenu();
            this.LostFocus += new EventHandler(TextBoxNumber_LostFocus);
        }

        void TextBoxNumber_LostFocus(object sender, EventArgs e)
        {
            if (this.SelectionStart > 0)
            {
                this.SelectionStart = 0;
            }
        }

        #region Properties

        #region CODE DESIGN BY THEM NGUYEN VAN

        #region default
        char cDel = '@';
        private bool m_blAllowSoAm = false;
        public bool AllowSoAm
        { 
            get {return m_blAllowSoAm;}
            set{m_blAllowSoAm = value;}
        }
        /// <summary>
        /// dinh dang so thap phan vd :0.00 0.000
        /// </summary>
        private static string strfm = "";
        /// <summary>
        /// /////String formate for textBox
        /// </summary>
        private String m_Formate = "0";// + mstrTPhanUser + strfm ;
        /// <summary>
        /// ///ki tu phan cach giua phan nguyen va thap phan
        /// </summary>
        private static string m_Thapphan = NumberFormats.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
        /// <summary>
        /// ///ki tu phan cach giua cac Group
        /// </summary>
        private static string m_Group = NumberFormats.CurrentUICulture.NumberFormat.NumberGroupSeparator;
        /// <summary>
        /// ///////So ki tu trong moi Group
        /// </summary>
        private NumofGroup m_iNumGroup = NumofGroup.s3;
        /// <summary>
        /// Set MaxLeng of Number for textBox
        /// </summary>
        private OverDecimal maxLength = OverDecimal.s17;
        private String PathFileConfig = "confnb.resx";
        /// <summary>
        /// qui dinh so chu so dang sau dau thap phan
        /// </summary>
        private ApterDecimal iNumOfDigitAfterDecimal = ApterDecimal.s0;
        /// <summary>
        /// /bien luu tru gia tri truoc khi thay doi(text change xay ra)
        /// </summary>
        string strOldValue = "";
        /// <summary>
        /// cho phep tu dong lam tron so hay khong
        /// </summary>
        private bool blAllowRound = false;
        /// <summary>
        /// = true : is Decimal
        /// </summary>
        private bool blIsDecimal = false;
        /// <summary>
        /// == false --> da dc lam tron roi len khong cho lam tron nua
        /// </summary>
        private bool blIsArounded = false;
        // private string strlanguag = "vn";
       // private bool blAllowReadFile = true;
        private bool blAlowWrite = false;
        private ReadPropertiesTextNumBer _ReadPro = new ReadPropertiesTextNumBer();
        #endregion

        #region User define
        /// <summary>
        /// ki tu phan cach do nguoi dung dinh nghia
        /// </summary>
        private string mstrGroupUser = CUtil.m_strSepaNumber;
        /// <summary>
        /// ki tu phan cach giua cac nhom do nguoi dung dinh nghia
        /// </summary>
        private string mstrTPhanUser = CUtil.m_strDecimal;
        /// <summary>
        /// cho biet so co chap nhan thap phan hay khong
        /// </summary>
        private bool isTP;
        /// <summary>
        /// so lon nhat 
        /// </summary>
        private StringBuilder strmax = new StringBuilder("0");
        private bool isSerpare = true;
        #endregion

        #region Public Properties
        public bool IsShowMessage = true;
        public bool _blAlowWrite
        {
            get
            {
                return blAlowWrite;
            }
            set
            {
                blAlowWrite = value;
                                
            }
        }
        [Browsable(false),DefaultValue(true)]
        public bool _isSerpare
        {
            get
            {
                return isSerpare;
            }
            set
            {
                isSerpare = value;

            }
        }
      
        /// <summary>
        /// Cho phep tu dong lam tron so
        /// </summary>
        public bool _AllowCelling
        {
            get
            {
                return blAllowRound;
            }
            set
            {
                blAllowRound = value;
                             
            }
        }
        /// <summary>
        /// ki tu thap phan tren may local
        /// </summary>
        public string _DigitDecimalLocal
        {
            get
            {
                return m_Thapphan;
            }

        }
        /// <summary>
        /// is decimal or other
        /// </summary>
        public bool _IsDecimal
        {
            get
            {
                 return blIsDecimal;
            }
            set
            {
                blIsDecimal = value;
                CreateStringFormat();
            }
        }
        /// <summary>
        /// So ki tu sau dau thap phan
        /// </summary>
        public ApterDecimal _NumOfAfterDigitDecimal
        {
            get
            {
                return iNumOfDigitAfterDecimal;

            }
            set
            {
                iNumOfDigitAfterDecimal = value;
                CreateStringFormat();
             
            }

        }

        /// <summary>
        /// Duong dan den file congig
        /// </summary>
        [Browsable(false)]
        public String _SetPathFileConfig
        {
            get
            {
                return PathFileConfig;

            }
            set
            {
                
            }
        }

        /// <summary>
        /// Maxlength of TextBox
        /// </summary>
        public OverDecimal _MaxLength
        {
            get
            {
                return maxLength;
            }
            set
            {
                 maxLength = value;
                 CreateStringFormat();
                
            }
        }
        public object Value
        {
            get
            {
                return GetValues();
            }
            set
            {
                if ((value != null) && !value.ToString().Trim().Equals(""))
                {
                    double db = double.Parse(value.ToString());
                    try
                    {
                        if (double.Parse(this.strmax.ToString()) <= db)
                        {
                            if(IsShowMessage)
                                MessageBox.Show(str_msgLagerMaxvalues);

                            return;
                        }
                    }
                    catch { }
                    string str = db.ToString();
                    if (blIsDecimal == false)
                    {
                        if (str.IndexOf(m_Thapphan) != -1)
                        {
                            str = str.Substring(0, str.IndexOf(m_Thapphan));
                        }
                    }
                    string strdecimal = "";
                    string nguyen = "";
                    if (blIsDecimal && str.IndexOf(m_Thapphan) != -1)
                    {
                        strdecimal = str.Substring(str.IndexOf(m_Thapphan));
                        strdecimal = strdecimal.Replace(m_Thapphan, mstrTPhanUser);
                        nguyen = str.Substring(0, str.IndexOf(m_Thapphan));
                    }
                    else
                    {
                        if (str.IndexOf(m_Thapphan) != -1)
                        {
                            nguyen = str.Substring(0, str.IndexOf(m_Thapphan));
                        }
                        else
                        {
                            nguyen = str;
                        }
                    }
                    int iNumOfDigitGroup = ConvertStringToArray(nguyen, m_Group);
                    //xoa het cac ki tu phan cach di
                    String strNum = nguyen;
                    if (strNum.Trim().Length == 0)
                    {
                        this.Text = "";
                        return;
                    }
                    if (_isSerpare)
                    {
                        strNum = strNum.Replace(m_Group, "");
                    }
                    int icur = 0;
                    NoDu(strNum, ref icur, ref iNumOfDigitGroup);
                    if (strdecimal != "")
                    {
                        string strtem = this.Text;
                        if(strtem.Contains(mstrTPhanUser))
                        {
                            strtem = strtem.Substring(0,strtem.IndexOf(mstrTPhanUser));
                        }
                        //string kq1 = strtem + strdecimal;
                        int num = _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal);
                        strdecimal = strdecimal.Substring(1);
                        if (strdecimal.Length > num)
                        {
                            ChexAround(ref strdecimal, strdecimal.Length);
                        }
                        while (strdecimal.Length < num)
                        {
                            strdecimal += "0";
                        }
                        this.Text = strtem +mstrTPhanUser+ strdecimal;
                    }
                    else
                    {
                        if (blIsDecimal && (this.iNumOfDigitAfterDecimal != ApterDecimal.s0))
                        {
                            string kq = this.Text + mstrTPhanUser + strfm;
                            this.Text = kq;
                        }
                    }
                    // blChange = false;//neu khong cho chay qua ham text change thi se phai viet them ham lam tron so trong truong hop la so thap phan
                    // this.Text = str;
                }
            }
        }

        private object GetValues()
        {
            if (this.Text != null && this.Text != "")
            {
                string str = "";
                /*
                if (_isSerpare)
                {
                    str = this.Text.Replace(mstrGroupUser, m_Group).Replace(mstrTPhanUser, m_Thapphan);
                }
                else
                {
                    str = gets;
                }
                 */
                str = ReplaceSotheoHeThong(this.Text);
                return double.Parse(str);
                
            }
            else
            {
                return 0;
            }
        }
        public String _Fomaters
        {
            get
            {
                return m_Formate;
            }

        }
        public NumofGroup _NumOfGroup
        {
            get
            {
                return m_iNumGroup;
            }
            set
            {
                m_iNumGroup = value;
              
            }

        }
        [Browsable(false)]
        public Char _GroupSeperate
        {
            get
            {
                return Char.Parse(mstrGroupUser);
            }
            set
            {
               // mstrGroupUser = value + "";
                
            }
        }
        [Browsable(false)]
        public Char _DecimalSeperate
        {
            get
            {
                return Char.Parse(mstrTPhanUser);
            }
            set
            {
               // mstrTPhanUser = value + "";
               
            }
        }
        #region MESSAGE +++++++++++++++++++++++++++++++++++++++++++++++++++
        private string str_msgLagerDecimal = "Số nhập vào vượt qúa giá trị của số thập phân !";
        private string str_msgLagerMaxvalues = "Số nhập vào vượt qúa giá trị lớn nhất qui định !";
        private string str_msgMustDecimal = "Số nhập vào phải là một số thập phân !";
        private string str_msgNotAround = "Không thể làm tròn giá trị !";
        private string str_msgErroFileResx = "Lỗi file confnb.resx !";
        /// <summary>
        /// Số nhập vào vượt qúa giá trị của số thập phân !
        /// </summary>
        public string msgLagerDecimal
        {
            set
            {
                str_msgLagerDecimal = value;

            }
        }
        /// <summary>
        /// Lỗi file confnb.resx
        /// </summary>
        public string msgErroFileResx
        {
            set
            {
                str_msgErroFileResx = value;

            }
        }
        /// <summary>
        /// Số nhập vào lớn hơn giá trị lớn nhất được qui định !
        /// </summary>
        public String msgLagerMaxvalues
        {
            set
            {
                str_msgLagerMaxvalues = value;

            }
        }
        /// <summary>
        /// Số nhập vào phải là một số thập phân !
        /// </summary>
        public string msgMustDecimal
        {
            set
            {
                str_msgMustDecimal = value;

            }
        }
        /// <summary>
        /// Không thể làm tròn giá trị !
        /// </summary>
        public string msgNotAround
        {
            set
            {
                str_msgLagerDecimal = value;

            }
        }
        #endregion


        #endregion

        #endregion

        #region CODE DESIGN BY TUAN
        private string app;
        string DefaFont = "Time New Roman";
        int DefaSize = 9;
        int currentHeight;
        int currentWidth;
        int newSize;
        string newFont;
        public int NewSize
        {
            get { return newSize; }
            set { newSize = value; }
        }

        public string NewFont
        {
            get { return newFont; }
            set { newFont = value; }
        }

        public int currHeight
        {
            get { return currentHeight; }
            set { currentHeight = value; }
        }

        public int currWidth
        {
            get { return currentWidth; }
            set { currentWidth = value; }
        }
        XmlNode currentNode;
        public string app1
        {
            get { return app; }
            set { app = value; }
        }

        public override bool Multiline
        {
            get
            {
                return base.Multiline;
            }
            set
            {
                base.Multiline = value;
            }
        }

        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
            }
        }
        #endregion

        #endregion
       

        #region CODE DESIGN BY THEM NGUYEN VAN

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }
        // kiem tra gia tri sau khi dc Copy Pase
        private bool CheckCopyPase()
        {
            StringBuilder str = new StringBuilder(this.Text);
            str.Replace(mstrGroupUser, "");
            str.Replace(mstrTPhanUser, m_Thapphan);
            try
            {
                decimal num1 = decimal.Parse(str.ToString());
                decimal num2 = decimal.Parse(strmax.ToString().Replace(mstrTPhanUser, m_Thapphan));
                if (num1 >= num2)
                {
                    //MessageBox.Show("Value is too Lager for Max value");
                    if (IsShowMessage)
                    {
                        MessageBox.Show(str_msgLagerMaxvalues);
                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (OverflowException)
            {
                ///MessageBox.Show("Value is too Lager for a Decimal");
                MessageBox.Show(str_msgLagerDecimal);
                return false;
            }
            catch (FormatException)
            {
                // MessageBox.Show("Value phai la so.Neu la Decimal thi chi chua mot dau thap phan ");
                MessageBox.Show(str_msgMustDecimal);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool blChange = true;
        public static string ReplaceSotheoHeThong(string so)
        {
            if (so.Trim() == "")
            {
                return "0";
            }
         //   m_Group =  NumberFormats.CurrentUICulture.NumberFormat.NumberGroupSeparator;
          //  m_Thapphan = NumberFormats.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            String tem = "~1~";
            so = so.Replace(CUtil.m_strSepaNumber, tem);
            so = so.Replace(CUtil.m_strDecimal, m_Thapphan);
            if (m_Group == m_Thapphan)
            {
                so = so.Replace(tem, "");
            }
            else
                so = so.Replace(tem, m_Group);
            if (so.StartsWith(m_Group))
            {
                so = so.Substring(m_Group.Length);
            }
            return so;
        }
        protected override void OnTextChanged(EventArgs e)
        {

            //if (blChange == false)
            //{
            //    blChange = true;
            //    return;
            //}
          // String luu trong Clipboard
            if (this.Text == "-" && this.AllowSoAm == true)
                return;
            String txtClipBoard = "";
            //tim vi tri con tro
            int ICur = this.SelectionStart;
            if (ICur == 0 && this.Text.IndexOf(mstrTPhanUser) < 0 && _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) > 0 && blIsDecimal == true)
            {
                blChange = false;
                CUtil.removeSepaNumber(this.Text);
                this.Text = (this.Text == "") ? "0" + mstrTPhanUser + strfm : this.Text + mstrTPhanUser + strfm;
                               
            }
            
            try
            {
                //txtClipBoard = Clipboard.GetText();
                //if (txtClipBoard != null && txtClipBoard != "" && this.Text.IndexOf(txtClipBoard) != -1)
                //{
                //    if (CheckCopyPase() == false)
                //    {
                //        this.Text = strOldValue;
                //        this.SelectionLength = ICur;
                //        return;
                //    }
                //}
                String txt = this.Text;
                if (txt != "")
                {
                    if (_isSerpare)
                    {
                       // txt = txt.Replace(mstrGroupUser, m_Group);
                       /// txt = txt.Replace(mstrTPhanUser, m_Thapphan);
                        txt = ReplaceSotheoHeThong(txt);
                        if (txt == "-")
                        {
                            txt += strdefault();
                            this.Text = txt;
                        }
                        decimal.Parse(txt);
                    }
                    else
                    {
                        txt = txt.Replace(mstrTPhanUser, m_Thapphan);
                        decimal.Parse(txt);
                        
                    }
                }
            }
            catch (OverflowException)
            {
                ///MessageBox.Show("Value is too Lager for a Decimal");
                MessageBox.Show(str_msgLagerDecimal);
                this.Text = strOldValue;
                return;
            }
            catch(Exception)
            {
                blChange = false;
                this.Text = strOldValue;
                this.SelectionLength = ICur;
                return;
            }
            string current = ReplaceSotheoHeThong(this.Text);
            current = current.Replace(m_Group,"");
            if (current.IndexOf(m_Thapphan) != -1)
            {
                current = current.Substring(0, current.IndexOf(m_Thapphan));
            }
            if (current.Length > _ReadPro.GetNumOverDecimal(maxLength))
            {
                if ((double)this.Value >= double.Parse(strmax.ToString()))
                {
                    if (IsShowMessage)
                    {
                        MessageBox.Show(str_msgLagerMaxvalues);
                    }
                    blChange = false;
                    this.Text = strOldValue;
                    return;
                }
            }
            //if (this.Text == "" && _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) == 0)
            if (this.Text == "" && blIsDecimal == false)
            {
                return;
            }
            if(blIsDecimal == false)
            {
                if (this.Text.Contains(m_Thapphan))
                {
                    //this.Text = this.Text.Substring(0, this.Text.IndexOf(m_Thapphan));
                }
            }
            if (_isSerpare == true)
            {
                mstrGroupUser = (mstrGroupUser == " ") ? " " : mstrGroupUser;
            }
            else 
            {
                mstrGroupUser = "";
            }
            mstrTPhanUser = (mstrTPhanUser == " ") ? "." : mstrTPhanUser;
            if (strOldValue != "")
            {
                if (this.Text.Length < strOldValue.Length)
                {
                    if (this.Text.Length == 1)
                    {
                        blChange = false;
                        this.Text += (_ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) > 0 && blIsDecimal == true) ? mstrTPhanUser + strfm : "";
                    }
                    else
                    {
                        try
                        {
                            char chOle = strOldValue[ICur];
                            if (chOle.ToString() == mstrTPhanUser)
                            {
                                blChange = false;
                                this.Text = strOldValue;
                                if (cDel == '+')
                                {
                                    ICur++;
                                }
                                else if (cDel == '-')
                                {
                                    //ICur++;
                                }
                                // ICur++;
                            }
                            if (chOle.ToString() == mstrGroupUser)
                            {
                                try
                                {
                                    if (cDel == '+')
                                    {
                                        this.Text = this.Text.Remove(ICur, 1);
                                    }
                                    else if (cDel == '-')
                                    {
                                        this.Text = this.Text.Remove(ICur - 1, 1);
                                    }
                                }
                                catch { }
                            }
                        }
                        catch
                        { }
                    }

                }
                else
                {
                    if (strOldValue == "0" + mstrTPhanUser + strfm && ICur == 1)
                    {
                        blChange = false;
                        this.Text = this.Text.Substring(0, 1) + this.Text.Substring(this.Text.IndexOf(mstrTPhanUser));
                    }
                }

            }
            //Validata digit current is number ?
            try
            {
                /// loi cut khi text ="" chua sủa
                try
                {
                    String str = this.Text.Substring(((ICur == 0) ? 0 : ICur - 1), 1);
                    if (str == mstrTPhanUser)
                    {
                        int iNum = ConvertStringToArray(this.Text, mstrTPhanUser);
                        if (iNum > 1)
                        {
                            blChange = false;
                            this.Text = this.Text.Remove(((ICur == 0) ? 0 : ICur - 1), 1);
                            //this.SelectionStart = ICur - 1;
                            try
                            {
                                this.SelectionStart = this.Text.IndexOf(mstrTPhanUser) + 1;
                            }
                            catch { }
                            return;
                        }
                    }
                }
                catch { }
                    if (CheckLengDigitNumberOfTextBox(ICur) == false)
                    {
                        if (this.Text.IndexOf(txtClipBoard) != -1 && this.Text.IndexOf(txtClipBoard) + txtClipBoard.Length == ICur)
                        {
                            blChange = false;
                            this.Text = this.Text.Remove(((ICur == 0) ? 0 : ICur - 1), Clipboard.GetText().Length);
                        }
                        else
                        {
                            blChange = false;
                            this.Text = this.Text.Remove(((ICur == 0) ? 0 : ICur - 1), 1);
                        }
                        try
                        {
                            this.SelectionStart = ICur - 1;
                        }
                        catch { }
                        return;
                    }

                    if (isTP == true && this.Text.IndexOf(mstrTPhanUser) == -1)
                    {
                        String str1 = this.Text + mstrTPhanUser + strfm;
                        int iCurentLengTP = str1.Substring(str1.IndexOf(mstrTPhanUser)).Length;
                        if (iCurentLengTP < _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal))
                        {
                            for (int y = 0; y < _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) - iCurentLengTP; y++)
                            {
                                str1 += "0";
                            }
                        }
                        this.Text = str1;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Text = "";
            }
            //////////////////////////////////////////////////////
            try
            {
                //get number of digit group
                int iNumOfDigitGroup = ConvertStringToArray(this.Text, mstrGroupUser);
                //xoa het cac ki tu phan cach di
                String strNum = this.Text.Trim();
                if (strNum.Trim().Length == 0)
                {
                    this.Text = "";
                    return;
                }
                if (_isSerpare)
                {
                    strNum = strNum.Replace(mstrGroupUser, "");
                }
                
                NoDu(strNum, ref ICur, ref iNumOfDigitGroup);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (blIsDecimal == false)
            {
                
                if (this.Text.Contains(mstrTPhanUser))
                {
                    this.Text = this.Text.Substring(0, this.Text.IndexOf(mstrTPhanUser));
                }
             
            }
            base.OnTextChanged(e);
        }

        private void NoDu(String strNum, ref int iCur, ref int iNumOfDigitGroup)
        {

            String strValue = "";
            bool isam = false;
            if (AllowSoAm && strNum.IndexOf("-") != -1)
            {
                isam = true;
                strNum = strNum.Substring(strNum.IndexOf("-")+1);
            }
            int indexOfTP = strNum.IndexOf(mstrTPhanUser);
            //khong co so thap phan
            if (indexOfTP == -1)
            {
                strValue = CutString(strNum);
            }
            //co so thap phan
            else
            {
                String strNg = strNum.Substring(0, indexOfTP);
                String strTP = "";
                if (strNg == "" && strTP == "")
                {
                    strValue = "0" + mstrTPhanUser;
                    blChange = false;
                    this.Text = strValue;
                    try
                    {
                        this.SelectionStart = 2;
                    }
                    catch { }
                    return;

                }
                //neu strNg = "" thi them so khong vao;//chua lam
                if (strNg == "")
                {
                    strNg = "0";

                }
                strTP = strNum.Substring(indexOfTP + GetLengthOfString(mstrTPhanUser));
                int lengtp = strTP.Length;
                if (lengtp < _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal))
                {
                    for (int i = 0; i < _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) - lengtp; i++)
                    {
                        strTP += "0";
                    }
                }
                int iNumDu_Ng = strNg.Length %_ReadPro.GetNumofGroup(m_iNumGroup);
                //lam tron so
                if (ChexAround(ref strTP, iCur) == true)
                {
                    bool isNguyen = false;
                    strNg = AroundNumber(strNg, ref isNguyen, true, 1);

                }
                //------------
                if (strNg.StartsWith("0") && strNg.Length > 1 && iCur > 1)
                    iCur--;
                strNg = CutString(strNg);

                ///////////////////// Coong lai cac gia tri phan nguyen va tp de ra ke qua
                // strValue = (strBuTP == "") ? strNg + mstrTPhanUser + strTP : strNg + mstrGroupUser + strBuTP + mstrTPhanUser + strTP;
                strValue = strNg + mstrTPhanUser + strTP;
            }

            /// gan lai values cho texBox
            if (blIsDecimal == false)
            {
                if (strValue.EndsWith(mstrTPhanUser) == true)
                {
                    strValue = strValue.Substring(0, strValue.Length-1);
                }
              //  if (strValue.Contains(mstrTPhanUser))
                //{
                    //strValue = strValue.Substring(0, strValue.Length - 1);
                //}
            }
            if (isam)
            {
                strValue = "-" + strValue;
            }
            blChange = false;
            this.Text = strValue;//ConvertStringNumberToFormatedGroupUser(strValue);
            int iNumOfDigitGroup_New = ConvertStringToArray(this.Text, mstrGroupUser);
            //if (cDel == '+' || cDel == '-')
            //{
            //    iCur += 1;
            //}
            
            if (_isSerpare)
            {
                try
                {
                    this.SelectionStart = (iCur + (iNumOfDigitGroup_New - iNumOfDigitGroup)) * GetLengthOfString(mstrGroupUser);
                }
                catch { }
            }
            else
            {
                try
                {
                    this.SelectionStart = iCur + (iNumOfDigitGroup_New - iNumOfDigitGroup);
                }
                catch { }
            }
            strOldValue = this.Text;
            if (this.Text == "0" + mstrTPhanUser + strfm && iCur ==0)
            {
                this.SelectionStart = 0;
            }

        }
        private bool ChexAround(ref String Src, int iCur)
        {
            bool flag = false;
            if (Src.Length > _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) && iCur == this.Text.Length)
            {
                int numLast = int.Parse(Src.Substring(Src.Length - 1, 1));

                if (numLast >= 5)
                {
                    Src = AroundNumber(Src.Substring(0, Src.Length - 1), ref flag, false, 1);
                }
                else
                {
                    Src = AroundNumber(Src.Substring(0, Src.Length - 1), ref flag, false, 0);

                }
            }
            else
            {
                if (Src.Length > _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal))
                {
                    Src = Src.Substring(0, _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal));
                    blIsArounded = false;
                }
            }
            return flag;

        }

        /// <summary>
        /// ///
        /// </summary>
        /// <param name="str"></param>
        /// <param name="iNho">neu == true tuc la co so nho cho phan nguyen (dang kiem tra phan thap phan)</param>
        /// <param name="isNg"></param>
        /// <param name="nho"></param>
        /// <returns></returns>
        private String AroundNumber(String str, ref bool iNho, bool isNg, int nho)
        {
            //kiem tra neu khong cho phep tu dong lam tron
            if (blAllowRound == false && isNg == false)
            {
                if (str.Length > _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal))
                {
                    str = str.Substring(0, _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal));
                }
                return str;
            }
            str = str.Replace(mstrGroupUser, "");
            //kiem tra xem so cuoi cung co lon hon 10 khong thi moi chuyen sang phan nguyen 
            int inum1 = 0;
            StringBuilder Values = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (i + 1 >= _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) || (i >= 0 && nho > 0))
                {
                    int inum = Int32.Parse(str.Substring(i, 1));
                    inum += nho;
                    inum1 = inum;
                    if (inum >= 5)
                    {
                        if (i > 0)
                        {
                            if (inum < 10 && (i < _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) || isNg == true))
                            {
                                nho = 0;
                            }
                            else
                            {
                                nho = 1;
                            }
                            inum = (inum > 9) ? inum % 10 : inum;
                        }
                        else if (i == 0)
                        {
                            if (inum >= 10)
                            {
                                inum = (inum > 9) ? inum % 10 : inum;
                                nho = 1;
                            }
                            else
                            {
                                nho = 0;
                            }
                        }

                    }
                    else
                    {
                        nho = 0;
                    }
                    Values.Append(inum.ToString());
                }
                else
                {
                    Values.Append(str[i].ToString());
                }

            }
            if (inum1 < 10 && iNho == false)
            {
                nho = 0;
            }
            if (nho > 0)
            {
                //lam tron du mot
                iNho = true;
                //neu hien tai la chuoi nguyen thi cong so nho vao
                if (isNg == true)
                {
                    Values.Append("1");
                }
            }
            char[] chs = Values.ToString().ToCharArray();
            Values.Remove(0, Values.Length);
            for (int i = chs.Length - 1; i >= 0; i--)
            {
                Values.Append(chs[i].ToString());
            }
            return Values.ToString();
        }
        /// <summary>
        /// false --> khong cho nhap them
        /// </summary>
        /// <returns></returns>
        private Boolean CheckLengDigitNumberOfTextBox(int iCur)
        {
            Boolean flag = true;
            String Src = this.Text.Trim();
            if (AllowSoAm && Src.IndexOf("-") != -1)
            {
                Src = Src.Substring(Src.IndexOf("-") + 1);
            }
            int iDigitOfTP = Src.IndexOf(mstrTPhanUser);
            if (iDigitOfTP != -1)
            {
                if (iCur > iDigitOfTP)
                {
                    String strTP = Src.Substring(iDigitOfTP + (mstrTPhanUser.Length));
                    String strNg = Src.Substring(0, iDigitOfTP);
                    if (strTP.Length > _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) || Src.Substring(0, iDigitOfTP).Replace(mstrGroupUser, "").Length >= _ReadPro.GetNumOverDecimal(maxLength))
                    {
                        //this.Text = Src.Substring(0, iDigitOfTP+mstrTPhanUser.Length + _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal));
                        //lam tron so
                        if (blIsArounded == false)//neu chua dc lam tron thi lam tron
                        {
                            if (ChexAround(ref strTP, iCur) == true)
                            {
                                bool isNguyen = false;
                                strNg = AroundNumber(strNg, ref isNguyen, true, 1);

                            }
                            flag = true;
                            //  this.Text = strNg + mstrTPhanUser + strTP;
                            SetTextAfterAround(strNg, strTP);
                            if (iCur > this.Text.Length)
                            {
                                blIsArounded = true;
                            }

                        }
                        else //da dc lam tron roi
                        {
                            //neu con tro o sau cuoi cung cua xau thi khong lam tron nua
                            if (iCur > strNg.Length + mstrTPhanUser.Length + _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal))
                            {
                                strTP = strTP.Substring(0, _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal));
                            }
                            else //neu con tro khong phai o cuoi dong thi tiep tuc lam tron
                            {
                                blIsArounded = false;
                                CheckLengDigitNumberOfTextBox(iCur);
                            }
                            // this.Text = strNg + mstrTPhanUser + strTP;
                            SetTextAfterAround(strNg, strTP);
                        }
                    }
                }
                else
                {
                    Src = Src.Replace(mstrGroupUser, "");
                    iDigitOfTP = Src.IndexOf(mstrTPhanUser);
                    //if (iDigitOfTP > (_ReadPro.GetNumOverDecimal(maxLength) - _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal)))
                    if (iDigitOfTP > _ReadPro.GetNumOverDecimal(maxLength))
                    {
                        flag = false;
                    }

                }
            }
            else
            {
                /*
                if (_isSerpare)
                {
                    Src = Src.Replace(mstrGroupUser, "");
                    
                }
                Src = Src.Replace(mstrTPhanUser, "");
                */
                Src = ReplaceSotheoHeThong(this.Text);
                Src = Src.Replace(m_Group, "");
                if (Src.IndexOf(m_Thapphan) != -1)
                {
                    Src = Src.Substring(0, Src.IndexOf(m_Thapphan));
                }
                if (AllowSoAm && Src.IndexOf("-") != -1)
                {
                    Src = Src.Substring(Src.IndexOf("-") + 1);
                }
                return (Src.Length > _ReadPro.GetNumOverDecimal(maxLength)) ? false : true;
            }
            return flag;

        }
        /// <summary>
        /// kiem tra xem neu sau khi lam tron so ma truong du lieu vuot qua kick thuoc thi thong bao loi
        /// </summary>
        /// <param name="strNg"></param>
        /// <param name="strTP"></param>
        private void SetTextAfterAround(String strNg, String strTP)
        {
            StringBuilder strBd = new StringBuilder(strNg + mstrTPhanUser + strTP);
            strBd.Replace(mstrGroupUser, "");
            if (strBd.ToString() == strmax.ToString())
            {
                this.Text = strOldValue;
                //MessageBox.Show("Khong the lam tron du lieu nay");
                MessageBox.Show(str_msgNotAround);
                return;
            }
            else
            {
                this.Text = strBd.ToString();

            }
        }
        /// <summary>
        /// cat string along formated
        /// </summary>
        /// <param name="Src"></param>
        /// <returns></returns>
        private String CutString(String Src)
        {
            if (_isSerpare)
            {
                Src = Src.Replace(mstrGroupUser, "");
            }
            //StringBuilder Src = new StringBuilder(Src.Replace(mstrGroupUser, ""));
            while (Src.StartsWith("00"))
            {
                Src = Src.Substring(1);
                //Src.Remove(0, 1);
            }
            String[] arrGroup = new string[Src.Length / _ReadPro.GetNumofGroup(m_iNumGroup)];
            int iDu = Src.Length % _ReadPro.GetNumofGroup(m_iNumGroup);
            string strDu = Src.Substring(0, iDu);
            Src = Src.Substring(iDu);
            //Src.Remove(0, iDu);
            for (int i = 0; i < arrGroup.Length; i++)
            {
                arrGroup[i] = Src.Substring(0, _ReadPro.GetNumofGroup(m_iNumGroup));
                Src = Src.Substring(_ReadPro.GetNumofGroup(m_iNumGroup));
            }
            Src = "";
            for (int y = 0; y < arrGroup.Length; y++)
            {
                if (_isSerpare == true)
                {
                    Src += arrGroup[y].ToString() + mstrGroupUser;
                }
                else
                {
                    Src += arrGroup[y].ToString();
                }
            }
            if (Src.EndsWith(mstrGroupUser))
            {
                Src = Src.Substring(0, Src.Length - mstrGroupUser.Length);
            }
            if (strDu != "")
            {
                Src = (Src == "") ? strDu : strDu + mstrGroupUser + Src;
            }
            if (Src.Length > 1)
            {
                if (Src.StartsWith("0"))
                {
                    Src = Src.Substring(1);
                }
            }
            return Src;
        }
        //get count of a string child  in parent 
        private int ConvertStringToArray(String strSrc, String strSeparator)
        {
            String[] arr = strSrc.Split(new String[] { strSeparator }, StringSplitOptions.None);
            return arr.Length - 1;
        }
        private int GetLengthOfString(String strSrc)
        {
            return strSrc.Length;
        }
        private string strdefault()
        {
            string strdefault = "0";
            if (isTP && iNumOfDigitAfterDecimal != ApterDecimal.s0)
            {
                strdefault += mstrTPhanUser;
                for (int i = 0; i < _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal); i++)
                {
                    strfm += "0";
                    strdefault += "0";
                }
                
            }
            return strdefault;
            
        }
        public bool _blSetDefault = true;
        /// <summary>
        /// create StringFormated for textbox
        /// </summary>
        protected internal void CreateStringFormat()
        {
            strfm = "";
            mstrTPhanUser = (mstrTPhanUser == "") ? "." : mstrTPhanUser;
            mstrGroupUser = (mstrGroupUser == "") ? " " : mstrGroupUser;
            
            for (int i = 0; i < _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal); i++)
            {
                strfm += "0";
            }
            if (_ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) == 0 || _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) < 0 || blIsDecimal == false)
            {
                isTP = false;
                this.blChange = false;
                if (_blSetDefault)
                {
                   // this.Text = "";
                    if (this.Text != null)
                    {
                        int index1 = this.Text.IndexOf(mstrTPhanUser);
                        if (index1 != -1)
                        {
                            this.Text = this.Text.Substring(0,index1);
                        }
                        else
                        {
                            this.Text = "";
                        }
                    }
                    else
                    {
                        this.Text = "";
                    }
                }
            }
            else
            {
                isTP = true;
                blChange = true;
                if (_blSetDefault)
                {
                    m_Formate = "0" + mstrTPhanUser + strfm;
                    if (this.Text != null)
                    {
                        int index1 = this.Text.IndexOf(mstrTPhanUser);
                        if (index1 != -1)
                        {
                            this.Text = this.Text + strfm;
                        }
                        else
                        {
                            this.Text = "0" + mstrTPhanUser + strfm;
                        }
                    }
                    else
                    {
                        this.Text = "0" + mstrTPhanUser + strfm;
                    }

                }
            }
            //mstrTPhanUser = (mstrTPhanUser == "") ? "." : mstrTPhanUser;
            //mstrGroupUser = (mstrGroupUser == "") ? " " : mstrGroupUser;
             
            strOldValue = this.Text;

            strmax.Remove(0, strmax.Length);
            strmax.Append("1");
            ////////
            for (int i = 0; i < _ReadPro.GetNumOverDecimal(maxLength) + (blIsDecimal == true ? _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) : 0); i++)
            // for (int i = 0; i < _ReadPro.GetNumOverDecimal(maxLength); i++)
            {
                strmax.Append("0");
            }
            try
            {
                if (_ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) > 0 && blIsDecimal == true)//_ReadPro.GetNumOverDecimal(maxLength) - _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal)
                {
                    strmax.Append("0");
                    // strmax.Replace("0", mstrTPhanUser, _ReadPro.GetNumOverDecimal(maxLength) - _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal)+1, 1);
                    /// them ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    strmax.Replace("0", mstrTPhanUser, _ReadPro.GetNumOverDecimal(maxLength) + 1, 1);
                    /// het
                }

            }
            catch { }

        }
        /// <summary>
        /// check xem khi nao user an phim del va dich left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {

            if (((int)e.KeyValue) == 46)
            {
                cDel = '+';
                //MessageBox.Show(((int)e.KeyValue).ToString());
            }
            else if (((int)e.KeyValue) == 8)
            {
                cDel = '-';
                //MessageBox.Show(((int)e.KeyValue).ToString());
            }
            else
            {
                cDel = '@';
            }
            base.OnKeyDown(e);
        }
        private bool checkValidLengOfText(String values)
        {
            bool flag = true;
            values = values.Replace(mstrGroupUser, "");
            decimal dmax = decimal.Parse(strmax.ToString().Replace(mstrTPhanUser, m_Thapphan));
            decimal dCurrent = 0;

            try
            {
                dCurrent = decimal.Parse((values.Replace(mstrTPhanUser, m_Thapphan)).Replace(mstrGroupUser, ""));
            }
            catch { }
            if (values.Length > _ReadPro.GetNumOverDecimal(maxLength) || dCurrent >= dmax)
            {
                if (_ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal) > 0)
                {
                    // if (values.IndexOf(mstrTPhanUser) < 0 || (values.Substring(0, values.IndexOf(mstrTPhanUser)).Length > (_ReadPro.GetNumOverDecimal(maxLength) - _ReadPro.GetNumApterDecimal(iNumOfDigitAfterDecimal))))
                    if (values.IndexOf(mstrTPhanUser) < 0 || (values.Substring(0, values.IndexOf(mstrTPhanUser)).Length > _ReadPro.GetNumOverDecimal(maxLength)))
                    {
                        flag = false;
                    }

                }
                else
                {
                    flag = false;
                }

            }
            if (flag == false)
            {
                //MessageBox.Show("Invalid Properties ! No too Max");
                if (IsShowMessage)
                {
                    MessageBox.Show(str_msgLagerMaxvalues);
                }
            }
            return flag;
        }
        //public new event KeyPressEventHandler KeyPress;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
           
                if (m_blAllowSoAm)
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != 45)
                {
                    char ch = e.KeyChar;
                    //if (ch == Convert.ToChar(mstrTPhanUser))
                    if (ch == '.')
                    {
                        string txt = this.Text;
                        int index = txt.IndexOf(mstrTPhanUser);
                        if (index != -1)
                        {
                            this.SelectionStart = index + 1;
                        }
                    }
                    e.Handled = true;
                }
            }
            else
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    char ch = e.KeyChar;
                    //if (ch == Convert.ToChar(mstrTPhanUser))
                    if (ch == '.')
                    {
                        string txt = this.Text;
                        int index = txt.IndexOf(mstrTPhanUser);
                        if (index != -1)
                        {
                            this.SelectionStart = index + 1;
                        }
                    }
                    e.Handled = true;
                }
            }
           
        }
        #endregion

     
        #region Method Design By Tuan
        //Kiem tra va tao file xml
        private void WriteXML()
        {
            string filename;
            filename = app1;

            try
            {
                //pick whatever filename with .xml extension               

                XmlDocument xmlDoc = new XmlDocument();

                try
                {
                    xmlDoc.Load(filename);

                    //su dung bien flag de kiem tra su ton tai cua node TextDefault
                    bool flag;
                    flag = false;

                    //duyet qua tat ca cac child node 
                    for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                    {
                        if (xmlDoc.DocumentElement.ChildNodes[i].Name == "TextDefault")
                        {
                            flag = true;
                        }
                    }

                    //neu chua co TextDefault tao mot node TextDefault
                    if (!flag)
                    {
                        xmlDoc.Load(filename);
                        XmlNode root = xmlDoc.DocumentElement;
                        XmlElement TextDefault = xmlDoc.CreateElement("TextDefault");
                        root.AppendChild(TextDefault);
                        TextDefault.SetAttribute("DefaFont", "Time New Roman");
                        TextDefault.SetAttribute("DefaSize", "9");

                        xmlDoc.Save(filename);
                    }


                    //Neu da co, kiem tra newFont va newSize 
                    DataSet dataSetLabel = new DataSet();
                    dataSetLabel.ReadXml(filename);
                    DataRow[] dataRowLabel = dataSetLabel.Tables["TextDefault"].Select();

                    if ((NewFont != null) && (NewSize != 0))
                    {
                        xmlDoc.Load(filename);

                        //load currentnode
                        XmlNode root = xmlDoc.DocumentElement;

                        for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                        {
                            if (xmlDoc.DocumentElement.ChildNodes[i].Name == "TextDefault")
                            {
                                currentNode = xmlDoc.DocumentElement.ChildNodes[i];
                            }
                        }

                        //create a new node
                        XmlElement TextDefault = xmlDoc.CreateElement("TextDefault");
                        root.AppendChild(TextDefault);
                        TextDefault.SetAttribute("DefaFont", NewFont);
                        TextDefault.SetAttribute("DefaSize", Convert.ToString(newSize));

                        //Ghi de len node cu
                        xmlDoc.DocumentElement.ReplaceChild(TextDefault, currentNode);

                        xmlDoc.Save(filename);
                    }
                }
                //neu file xml khong ton tai tao file moi
                catch (System.IO.FileNotFoundException)
                {
                    //if file is not found, create a new xml file
                    XmlTextWriter xmlWriter = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
                    xmlWriter.Formatting = Formatting.Indented;
                    xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
                    xmlWriter.WriteStartElement("Root");
                    //If WriteProcessingInstruction is used as above,
                    //Do not use WriteEndElement() here
                    //xmlWriter.WriteEndElement();
                    //it will cause the &ltRoot></Root> to be &ltRoot />
                    xmlWriter.Close();
                    xmlDoc.Load(filename);
                    XmlNode root = xmlDoc.DocumentElement;
                    XmlElement TextDefault = xmlDoc.CreateElement("TextDefault");
                    root.AppendChild(TextDefault);
                    TextDefault.SetAttribute("DefaFont", "Time New Roman");
                    TextDefault.SetAttribute("DefaSize", "9");

                    xmlDoc.Save(filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh();
            //MessageBox.Show(this.currentHeight + "," + this.currentWidth);
        }
        private void refresh()
        {
            string filename;
            filename = app1;
            DataSet dataSet = new DataSet();
            //dataSet.ReadXmlSchema(schema);
            dataSet.ReadXml(app1);
            this.currHeight = this.Size.Height;
            this.currWidth = this.Size.Width;
            DataRow[] dataRow = dataSet.Tables["TextDefault"].Select();


            foreach (DataRow dr in dataRow)
            {
                DefaFont = dr["DefaFont"].ToString();
                DefaSize = Convert.ToInt32(dr["DefaSize"].ToString());
            }
            //  this.SuspendLayout();

            this.Font = new System.Drawing.Font(DefaFont, DefaSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size = new System.Drawing.Size(this.currWidth, this.currHeight);
            this.ResumeLayout(false);
            this.AutoSize = false;
            //this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;            
            //this.textBox1.Size = new Size(this.Size.Width, this.Size.Height);
            //MessageBox.Show(Convert.ToString(this.textBox1.Size.Height));
        }

        //Tao mot ham getValue de lay du lieu cho control
        public void getValue(string fileName)
        {
            app1 = fileName;
            WriteXML();
        }

        public void getValue(string fileName, string Font, int Size)
        {
            app1 = fileName;
            NewFont = Font;
            NewSize = Size;
            WriteXML();
        }

        public void getValue(string Font, int Size)
        {
            NewFont = Font;
            NewSize = Size;
            WriteXML();
        }

        #endregion
    }

    public class ReadPropertiesTextNumBer
    {
       #region +++++++
        public int GetNumApterDecimal(ApterDecimal type)
        {
            int value = 0;
            switch (type)
            {
                case ApterDecimal.s0:
                    value = 0;
                    break;
                case ApterDecimal.s1:
                    value = 1;
                    break;
                case ApterDecimal.s2:
                    value = 2;
                    break;
                case ApterDecimal.s3:
                    value = 3;
                    break;
                case ApterDecimal.s4:
                    value = 4;
                    break;
                case ApterDecimal.s5:
                    value = 5;
                    break;
                case ApterDecimal.s6:
                    value = 6;
                    break;
                case ApterDecimal.s7:
                    value = 7;
                    break;
                case ApterDecimal.s8:
                    value = 8;
                    break;
                case ApterDecimal.s9:
                    value = 9;
                    break;
                case ApterDecimal.s10:
                    value = 10;
                    break;
            }
            return value;
        }
        public int GetNumOverDecimal(OverDecimal type)
        {
            int value = 1;
            switch (type)
            {
                case OverDecimal.s1:
                    value = 1;
                    break;
                case OverDecimal.s2:
                    value = 2;
                    break;
                case OverDecimal.s3:
                    value = 3;
                    break;
                case OverDecimal.s4:
                    value = 4;
                    break;
                case OverDecimal.s5:
                    value = 5;
                    break;
                case OverDecimal.s6:
                    value = 6;
                    break;
                case OverDecimal.s7:
                    value = 7;
                    break;
                case OverDecimal.s8:
                    value = 8;
                    break;
                case OverDecimal.s9:
                    value = 9;
                    break;
                case OverDecimal.s10:
                    value = 10;
                    break;
                case OverDecimal.s11:
                    value = 11;
                    break;
                case OverDecimal.s12:
                    value = 12;
                    break;
                case OverDecimal.s13:
                    value = 13;
                    break;
                case OverDecimal.s14:
                    value = 14;
                    break;
                case OverDecimal.s15:
                    value = 15;
                    break;
                case OverDecimal.s16:
                    value = 16;
                    break;
                case OverDecimal.s17:
                    value = 17;
                    break;
                case OverDecimal.s18:
                    value = 18;
                    break;
                case OverDecimal.s19:
                    value = 19;
                    break;
                case OverDecimal.s20:
                    value = 20;
                    break;
            }
            return value;
        }
        public int GetNumofGroup(NumofGroup type)
        {
            int value = 1;
            switch (type)
            {
                case NumofGroup.s3:
                    value = 3;
                    break;
                case NumofGroup.s4:
                    value = 4;
                    break;
                case NumofGroup.s5:
                    value = 5;
                    break;
                case NumofGroup.s6:
                    value = 6;
                    break;

            }
            return value;
        }
        #endregion
    }

    #region ENUM
    public enum ApterDecimal
    {
        s0,
        s1,
        s2,
        s3,
        s4,
        s5,
        s6,
        s7,
        s8,  
        s9,
        s10
    }
    public enum OverDecimal
    {
        s1,
        s2,
        s3,
        s4,
        s5,
        s6,
        s7,
        s8,  
        s9,
        s10,
        s11,
        s12,
        s13,
        s14,
        s15,
        s16,
        s17,
        s18,
        s19,
        s20
        
    }
    public enum NumofGroup
    {
        s3,
        s4,
        s5,
        s6

    }
    #endregion
}
