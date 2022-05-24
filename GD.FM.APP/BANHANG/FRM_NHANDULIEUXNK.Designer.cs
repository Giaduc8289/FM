namespace GD.FM.APP.BANHANG
{
    partial class FRM_NHANDULIEUXNK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NHANDULIEUXNK));
            this.btn_CHAPNHAN = new GD.FM.CONTROL.BUTTON();
            this.btn_THOAT = new GD.FM.CONTROL.BUTTON();
            this.label1 = new GD.FM.CONTROL.LABEL();
            this.txt_PATH = new GD.FM.CONTROL.TEXTBOX();
            this.btn_CHON = new GD.FM.CONTROL.BUTTON();
            this.SuspendLayout();
            // 
            // btn_CHAPNHAN
            // 
            this.btn_CHAPNHAN.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_CHAPNHAN.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_CHAPNHAN.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btn_CHAPNHAN.Location = new System.Drawing.Point(117, 113);
            this.btn_CHAPNHAN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CHAPNHAN.Name = "btn_CHAPNHAN";
            this.btn_CHAPNHAN.Size = new System.Drawing.Size(100, 28);
            this.btn_CHAPNHAN.TabIndex = 2;
            this.btn_CHAPNHAN.Text = "&Chấp nhận";
            this.btn_CHAPNHAN.UseVisualStyleBackColor = true;
            this.btn_CHAPNHAN.Click += new System.EventHandler(this.btn_CHAPNHAN_Click);
            // 
            // btn_THOAT
            // 
            this.btn_THOAT.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THOAT.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THOAT.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btn_THOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_THOAT.Location = new System.Drawing.Point(255, 113);
            this.btn_THOAT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(100, 28);
            this.btn_THOAT.TabIndex = 3;
            this.btn_THOAT.Text = "&Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 163;
            this.label1.Text = "File dữ liệu";
            // 
            // txt_PATH
            // 
            this.txt_PATH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PATH.BannerText = null;
            this.txt_PATH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_PATH.FormNametoShow = "";
            this.txt_PATH.Is_DateTime = false;
            this.txt_PATH.IsShowForm = false;
            this.txt_PATH.Location = new System.Drawing.Point(95, 58);
            this.txt_PATH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PATH.Name = "txt_PATH";
            this.txt_PATH.Regular_Expression = null;
            this.txt_PATH.Size = new System.Drawing.Size(285, 22);
            this.txt_PATH.TabIndex = 164;
            // 
            // btn_CHON
            // 
            this.btn_CHON.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_CHON.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_CHON.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btn_CHON.Location = new System.Drawing.Point(389, 55);
            this.btn_CHON.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CHON.Name = "btn_CHON";
            this.btn_CHON.Size = new System.Drawing.Size(36, 28);
            this.btn_CHON.TabIndex = 165;
            this.btn_CHON.Text = "...";
            this.btn_CHON.UseVisualStyleBackColor = true;
            this.btn_CHON.Click += new System.EventHandler(this.btn_CHON_Click);
            // 
            // FRM_NHANDULIEUXNK
            // 
            this.AcceptButton = this.btn_CHAPNHAN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_THOAT;
            this.ClientSize = new System.Drawing.Size(434, 176);
            this.Controls.Add(this.btn_CHON);
            this.Controls.Add(this.txt_PATH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CHAPNHAN);
            this.Controls.Add(this.btn_THOAT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_NHANDULIEUXNK";
            this.Text = "Nhận dữ liệu xuất nhập khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CONTROL.BUTTON btn_CHAPNHAN;
        private CONTROL.BUTTON btn_THOAT;
        //private System.Windows.Forms.MaskedTextBox txt_NGAYNHAP;
        private CONTROL.LABEL label1;
        private CONTROL.TEXTBOX txt_PATH;
        private CONTROL.BUTTON btn_CHON;
    }
}