namespace GD.FM.CONTROL
{
    partial class toolmenufrm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnsetupview = new GD.FM.CONTROL.BUTTON();
            this.btnThoat = new GD.FM.CONTROL.BUTTON();
            this.btnIn = new GD.FM.CONTROL.BUTTON();
            this.btnTimKiem = new GD.FM.CONTROL.BUTTON();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtKeySearch = new GD.FM.CONTROL.TEXTBOX();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsetupview
            // 
            this.btnsetupview.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnsetupview.Location = new System.Drawing.Point(597, 3);
            this.btnsetupview.Name = "btnsetupview";
            this.btnsetupview.Size = new System.Drawing.Size(60, 23);
            this.btnsetupview.TabIndex = 4;
            this.btnsetupview.Text = "H.thị";
            this.toolTip1.SetToolTip(this.btnsetupview, "Cài đặt hiển thị cột");
            this.btnsetupview.UseVisualStyleBackColor = true;
            this.btnsetupview.Visible = false;
            this.btnsetupview.Click += new System.EventHandler(this.btnsetupview_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnThoat.Location = new System.Drawing.Point(531, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(60, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Th&oát";
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnIn.Location = new System.Drawing.Point(465, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(60, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.toolTip1.SetToolTip(this.btnIn, "In ấn");
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnTimKiem.Location = new System.Drawing.Point(399, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(60, 23);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm";
            this.toolTip1.SetToolTip(this.btnTimKiem, "Tìm kiếm");
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnTimKiem, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKeySearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDenNgay, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDenNgay, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpTuNgay, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTuNgay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTuKhoa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIn, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnsetupview, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThoat, 8, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 32);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtKeySearch
            // 
            this.txtKeySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeySearch.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeySearch.BannerText = null;
            this.txtKeySearch.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txtKeySearch.Location = new System.Drawing.Point(56, 6);
            this.txtKeySearch.Name = "txtKeySearch";
            this.txtKeySearch.Regular_Expression = null;
            this.txtKeySearch.Size = new System.Drawing.Size(90, 20);
            this.txtKeySearch.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtKeySearch, "Từ khóa tìm kiếm");
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(305, 6);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(88, 20);
            this.dtpDenNgay.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dtpDenNgay, "Đến ngày");
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(269, 9);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(30, 13);
            this.lblDenNgay.TabIndex = 19;
            this.lblDenNgay.Text = "Đến:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(181, 6);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(82, 20);
            this.dtpTuNgay.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dtpTuNgay, "Từ ngày");
            this.dtpTuNgay.Value = new System.DateTime(2007, 11, 13, 0, 43, 0, 0);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(152, 9);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(23, 13);
            this.lblTuNgay.TabIndex = 22;
            this.lblTuNgay.Text = "Từ:";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location = new System.Drawing.Point(3, 9);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(47, 13);
            this.lblTuKhoa.TabIndex = 20;
            this.lblTuKhoa.Text = "Từ khóa";
            // 
            // toolmenufrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "toolmenufrm";
            this.Size = new System.Drawing.Size(704, 32);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GD.FM.CONTROL.BUTTON btnsetupview;
        private GD.FM.CONTROL.BUTTON btnThoat;
        private GD.FM.CONTROL.BUTTON btnIn;
        private GD.FM.CONTROL.BUTTON btnTimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private GD.FM.CONTROL.TEXTBOX txtKeySearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
