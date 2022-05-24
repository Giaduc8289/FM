namespace GD.FM.APP.BAOCAO
{
    partial class FRM_PHANTICHDULIEUXNK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PHANTICHDULIEUXNK));
            this.btn_IN = new GD.FM.CONTROL.BUTTON();
            this.btn_THOAT = new GD.FM.CONTROL.BUTTON();
            this.txt_DENNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new GD.FM.CONTROL.LABEL();
            this.txt_TUNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new GD.FM.CONTROL.LABEL();
            this.txt_TENQUOCGIA = new GD.FM.CONTROL.TEXTBOX();
            this.txt_MAQUOCGIA = new GD.FM.CONTROL.TEXTBOX();
            this.label11 = new GD.FM.CONTROL.LABEL();
            this.txt_TENCANG = new GD.FM.CONTROL.TEXTBOX();
            this.txt_MACANG = new GD.FM.CONTROL.TEXTBOX();
            this.label2 = new GD.FM.CONTROL.LABEL();
            this.SuspendLayout();
            // 
            // btn_IN
            // 
            this.btn_IN.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_IN.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_IN.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btn_IN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_IN.Location = new System.Drawing.Point(127, 189);
            this.btn_IN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_IN.Name = "btn_IN";
            this.btn_IN.Size = new System.Drawing.Size(100, 28);
            this.btn_IN.TabIndex = 6;
            this.btn_IN.Text = "&In";
            this.btn_IN.UseVisualStyleBackColor = true;
            this.btn_IN.Click += new System.EventHandler(this.btn_IN_Click);
            // 
            // btn_THOAT
            // 
            this.btn_THOAT.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THOAT.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THOAT.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btn_THOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_THOAT.Location = new System.Drawing.Point(235, 189);
            this.btn_THOAT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(100, 28);
            this.btn_THOAT.TabIndex = 7;
            this.btn_THOAT.Text = "&Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // txt_DENNGAY
            // 
            this.txt_DENNGAY.Location = new System.Drawing.Point(339, 42);
            this.txt_DENNGAY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DENNGAY.Mask = "00/00/0000";
            this.txt_DENNGAY.Name = "txt_DENNGAY";
            this.txt_DENNGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DENNGAY.Size = new System.Drawing.Size(97, 22);
            this.txt_DENNGAY.TabIndex = 1;
            this.txt_DENNGAY.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 172;
            this.label1.Text = "Đến ngày";
            // 
            // txt_TUNGAY
            // 
            this.txt_TUNGAY.Location = new System.Drawing.Point(108, 42);
            this.txt_TUNGAY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TUNGAY.Mask = "00/00/0000";
            this.txt_TUNGAY.Name = "txt_TUNGAY";
            this.txt_TUNGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TUNGAY.Size = new System.Drawing.Size(97, 22);
            this.txt_TUNGAY.TabIndex = 0;
            this.txt_TUNGAY.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 171;
            this.label3.Text = "Từ ngày";
            // 
            // txt_TENQUOCGIA
            // 
            this.txt_TENQUOCGIA.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENQUOCGIA.BannerText = null;
            this.txt_TENQUOCGIA.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENQUOCGIA.FormNametoShow = "";
            this.txt_TENQUOCGIA.Is_DateTime = false;
            this.txt_TENQUOCGIA.IsShowForm = false;
            this.txt_TENQUOCGIA.Location = new System.Drawing.Point(213, 84);
            this.txt_TENQUOCGIA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TENQUOCGIA.Name = "txt_TENQUOCGIA";
            this.txt_TENQUOCGIA.ReadOnly = true;
            this.txt_TENQUOCGIA.Regular_Expression = null;
            this.txt_TENQUOCGIA.Size = new System.Drawing.Size(223, 22);
            this.txt_TENQUOCGIA.TabIndex = 3;
            this.txt_TENQUOCGIA.TabStop = false;
            // 
            // txt_MAQUOCGIA
            // 
            this.txt_MAQUOCGIA.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAQUOCGIA.BannerText = null;
            this.txt_MAQUOCGIA.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAQUOCGIA.FormNametoShow = "";
            this.txt_MAQUOCGIA.Is_DateTime = false;
            this.txt_MAQUOCGIA.IsShowForm = false;
            this.txt_MAQUOCGIA.Location = new System.Drawing.Point(108, 84);
            this.txt_MAQUOCGIA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MAQUOCGIA.Name = "txt_MAQUOCGIA";
            this.txt_MAQUOCGIA.Regular_Expression = null;
            this.txt_MAQUOCGIA.Size = new System.Drawing.Size(96, 22);
            this.txt_MAQUOCGIA.TabIndex = 2;
            this.txt_MAQUOCGIA.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAQUOCGIA_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 175;
            this.label11.Text = "Quốc gia";
            // 
            // txt_TENCANG
            // 
            this.txt_TENCANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENCANG.BannerText = null;
            this.txt_TENCANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENCANG.FormNametoShow = "";
            this.txt_TENCANG.Is_DateTime = false;
            this.txt_TENCANG.IsShowForm = false;
            this.txt_TENCANG.Location = new System.Drawing.Point(213, 126);
            this.txt_TENCANG.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TENCANG.Name = "txt_TENCANG";
            this.txt_TENCANG.ReadOnly = true;
            this.txt_TENCANG.Regular_Expression = null;
            this.txt_TENCANG.Size = new System.Drawing.Size(223, 22);
            this.txt_TENCANG.TabIndex = 5;
            this.txt_TENCANG.TabStop = false;
            // 
            // txt_MACANG
            // 
            this.txt_MACANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MACANG.BannerText = null;
            this.txt_MACANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MACANG.FormNametoShow = "";
            this.txt_MACANG.Is_DateTime = false;
            this.txt_MACANG.IsShowForm = false;
            this.txt_MACANG.Location = new System.Drawing.Point(108, 126);
            this.txt_MACANG.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MACANG.Name = "txt_MACANG";
            this.txt_MACANG.Regular_Expression = null;
            this.txt_MACANG.Size = new System.Drawing.Size(96, 22);
            this.txt_MACANG.TabIndex = 4;
            this.txt_MACANG.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MACANG_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 178;
            this.label2.Text = "Cảng đến";
            // 
            // FRM_PHANTICHDULIEUXNK
            // 
            this.AcceptButton = this.btn_IN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_THOAT;
            this.ClientSize = new System.Drawing.Size(459, 239);
            this.Controls.Add(this.txt_TENCANG);
            this.Controls.Add(this.txt_MACANG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TENQUOCGIA);
            this.Controls.Add(this.txt_MAQUOCGIA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_DENNGAY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TUNGAY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_IN);
            this.Controls.Add(this.btn_THOAT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_PHANTICHDULIEUXNK";
            this.Text = "FRM_PHANTICHDULIEUXNK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CONTROL.BUTTON btn_IN;
        private CONTROL.BUTTON btn_THOAT;
        private System.Windows.Forms.MaskedTextBox txt_DENNGAY;
        private CONTROL.LABEL label1;
        private System.Windows.Forms.MaskedTextBox txt_TUNGAY;
        private CONTROL.LABEL label3;
        private CONTROL.TEXTBOX txt_TENQUOCGIA;
        private CONTROL.TEXTBOX txt_MAQUOCGIA;
        private CONTROL.LABEL label11;
        private CONTROL.TEXTBOX txt_TENCANG;
        private CONTROL.TEXTBOX txt_MACANG;
        private CONTROL.LABEL label2;
    }
}