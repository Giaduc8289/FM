namespace GD.FM.APP.HETHONG
{
    partial class FRM_SAOLUU
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
            this.label2 = new GD.FM.CONTROL.LABEL();
            this.btnChapnhan = new GD.FM.CONTROL.BUTTON();
            this.btnThoat = new GD.FM.CONTROL.BUTTON();
            this.btnChonduongdan = new GD.FM.CONTROL.BUTTON();
            this.txt_THUMUC = new GD.FM.CONTROL.TEXTBOX();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tệp sao lưu";
            // 
            // btnChapnhan
            // 
            this.btnChapnhan.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnChapnhan.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btnChapnhan.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btnChapnhan.Location = new System.Drawing.Point(152, 91);
            this.btnChapnhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChapnhan.Name = "btnChapnhan";
            this.btnChapnhan.Size = new System.Drawing.Size(100, 28);
            this.btnChapnhan.TabIndex = 2;
            this.btnChapnhan.Text = "Sao lưu";
            this.btnChapnhan.UseVisualStyleBackColor = true;
            this.btnChapnhan.Click += new System.EventHandler(this.btnChapnhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnThoat.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btnThoat.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btnThoat.Location = new System.Drawing.Point(273, 91);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChonduongdan
            // 
            this.btnChonduongdan.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnChonduongdan.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btnChonduongdan.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btnChonduongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonduongdan.Location = new System.Drawing.Point(484, 36);
            this.btnChonduongdan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChonduongdan.Name = "btnChonduongdan";
            this.btnChonduongdan.Size = new System.Drawing.Size(32, 28);
            this.btnChonduongdan.TabIndex = 1;
            this.btnChonduongdan.Text = "...";
            this.btnChonduongdan.UseVisualStyleBackColor = true;
            this.btnChonduongdan.Click += new System.EventHandler(this.btnChonduongdan_Click);
            // 
            // txt_THUMUC
            // 
            this.txt_THUMUC.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_THUMUC.BannerText = null;
            this.txt_THUMUC.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_THUMUC.FormNametoShow = "";
            this.txt_THUMUC.Is_DateTime = false;
            this.txt_THUMUC.IsShowForm = false;
            this.txt_THUMUC.Location = new System.Drawing.Point(125, 38);
            this.txt_THUMUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_THUMUC.Name = "txt_THUMUC";
            this.txt_THUMUC.Regular_Expression = null;
            this.txt_THUMUC.Size = new System.Drawing.Size(349, 22);
            this.txt_THUMUC.TabIndex = 0;
            // 
            // FRM_SAOLUU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 139);
            this.Controls.Add(this.txt_THUMUC);
            this.Controls.Add(this.btnChonduongdan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChapnhan);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FRM_SAOLUU";
            this.Text = "Sao lưu dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GD.FM.CONTROL.LABEL label2;
        private GD.FM.CONTROL.BUTTON btnChapnhan;
        private GD.FM.CONTROL.BUTTON btnThoat;
        private GD.FM.CONTROL.BUTTON btnChonduongdan;
        private GD.FM.CONTROL.TEXTBOX txt_THUMUC;
    }
}