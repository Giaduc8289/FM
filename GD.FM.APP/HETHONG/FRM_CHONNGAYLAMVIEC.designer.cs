namespace GD.FM.APP.HETHONG
{
    partial class FRM_CHONNGAYLAMVIEC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CHONNGAYLAMVIEC));
            this.label3 = new GD.FM.CONTROL.LABEL();
            this.btn_Thoat = new GD.FM.CONTROL.BUTTON();
            this.btnOK = new GD.FM.CONTROL.BUTTON();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblNameSoftware = new System.Windows.Forms.Label();
            this.txt_NGAYLAMVIEC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày làm việc";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(317, 114);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(115, 36);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btnOK
            // 
            this.btnOK.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOK.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btnOK.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(161, 114);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(132, 36);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&Chọn";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(4, 166);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 16);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "label4";
            // 
            // lblNameSoftware
            // 
            this.lblNameSoftware.AutoSize = true;
            this.lblNameSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSoftware.ForeColor = System.Drawing.Color.Black;
            this.lblNameSoftware.Location = new System.Drawing.Point(44, 11);
            this.lblNameSoftware.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameSoftware.Name = "lblNameSoftware";
            this.lblNameSoftware.Size = new System.Drawing.Size(66, 24);
            this.lblNameSoftware.TabIndex = 8;
            this.lblNameSoftware.Text = "label4";
            // 
            // txt_NGAYLAMVIEC
            // 
            this.txt_NGAYLAMVIEC.Location = new System.Drawing.Point(163, 63);
            this.txt_NGAYLAMVIEC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NGAYLAMVIEC.Mask = "00/00/0000";
            this.txt_NGAYLAMVIEC.Name = "txt_NGAYLAMVIEC";
            this.txt_NGAYLAMVIEC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NGAYLAMVIEC.Size = new System.Drawing.Size(175, 22);
            this.txt_NGAYLAMVIEC.TabIndex = 2;
            this.txt_NGAYLAMVIEC.ValidatingType = typeof(System.DateTime);
            // 
            // FRM_CHONNGAYLAMVIEC
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(544, 198);
            this.Controls.Add(this.txt_NGAYLAMVIEC);
            this.Controls.Add(this.lblNameSoftware);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CHONNGAYLAMVIEC";
            this.Text = "Chọn ngày làm việc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GD.FM.CONTROL.BUTTON btnOK;
        private GD.FM.CONTROL.BUTTON btn_Thoat;
        private GD.FM.CONTROL.LABEL label3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblNameSoftware;
        private System.Windows.Forms.MaskedTextBox txt_NGAYLAMVIEC;
    }
}