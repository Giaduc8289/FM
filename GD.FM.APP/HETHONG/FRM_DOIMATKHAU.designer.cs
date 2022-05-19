namespace GD.FM.APP.HETHONG
{
    partial class FRM_DOIMATKHAU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DOIMATKHAU));
            this.txt_username = new GD.FM.CONTROL.TEXTBOX();
            this.label1 = new GD.FM.CONTROL.LABEL();
            this.txt_password = new GD.FM.CONTROL.TEXTBOX();
            this.label2 = new GD.FM.CONTROL.LABEL();
            this.txt_newpassword = new GD.FM.CONTROL.TEXTBOX();
            this.label3 = new GD.FM.CONTROL.LABEL();
            this.txt_repassword = new GD.FM.CONTROL.TEXTBOX();
            this.label4 = new GD.FM.CONTROL.LABEL();
            this.btn_Thoat = new GD.FM.CONTROL.BUTTON();
            this.btn_LUULAI = new GD.FM.CONTROL.BUTTON();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.BannerText = null;
            this.txt_username.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_username.FormNametoShow = "";
            this.txt_username.Is_DateTime = false;
            this.txt_username.IsShowForm = false;
            this.txt_username.Location = new System.Drawing.Point(210, 34);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Regular_Expression = null;
            this.txt_username.Size = new System.Drawing.Size(192, 22);
            this.txt_username.TabIndex = 1;
            this.txt_username.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txt_password
            // 
            this.txt_password.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.BannerText = null;
            this.txt_password.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_password.FormNametoShow = "";
            this.txt_password.Is_DateTime = false;
            this.txt_password.IsShowForm = false;
            this.txt_password.Location = new System.Drawing.Point(210, 82);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Regular_Expression = null;
            this.txt_password.Size = new System.Drawing.Size(192, 22);
            this.txt_password.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpassword.BannerText = null;
            this.txt_newpassword.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_newpassword.FormNametoShow = "";
            this.txt_newpassword.Is_DateTime = false;
            this.txt_newpassword.IsShowForm = false;
            this.txt_newpassword.Location = new System.Drawing.Point(210, 124);
            this.txt_newpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '*';
            this.txt_newpassword.Regular_Expression = null;
            this.txt_newpassword.Size = new System.Drawing.Size(192, 22);
            this.txt_newpassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txt_repassword
            // 
            this.txt_repassword.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repassword.BannerText = null;
            this.txt_repassword.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_repassword.FormNametoShow = "";
            this.txt_repassword.Is_DateTime = false;
            this.txt_repassword.IsShowForm = false;
            this.txt_repassword.Location = new System.Drawing.Point(210, 172);
            this.txt_repassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_repassword.Name = "txt_repassword";
            this.txt_repassword.PasswordChar = '*';
            this.txt_repassword.Regular_Expression = null;
            this.txt_repassword.Size = new System.Drawing.Size(192, 22);
            this.txt_repassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.Location = new System.Drawing.Point(337, 226);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_LUULAI
            // 
            this.btn_LUULAI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_LUULAI.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_LUULAI.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btn_LUULAI.Location = new System.Drawing.Point(229, 226);
            this.btn_LUULAI.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LUULAI.Name = "btn_LUULAI";
            this.btn_LUULAI.Size = new System.Drawing.Size(100, 28);
            this.btn_LUULAI.TabIndex = 3;
            this.btn_LUULAI.Text = "Lưu lại";
            this.btn_LUULAI.UseVisualStyleBackColor = true;
            this.btn_LUULAI.Click += new System.EventHandler(this.btn_LUULAI_Click);
            // 
            // FRM_DOIMATKHAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 282);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LUULAI);
            this.Controls.Add(this.txt_repassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_DOIMATKHAU";
            this.Text = "FRM_DOIMATKHAU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error1;
        private CONTROL.TEXTBOX txt_username;
        private CONTROL.LABEL label1;
        private CONTROL.TEXTBOX txt_password;
        private CONTROL.LABEL label2;
        private CONTROL.TEXTBOX txt_newpassword;
        private CONTROL.LABEL label3;
        private CONTROL.TEXTBOX txt_repassword;
        private CONTROL.LABEL label4;
        private CONTROL.BUTTON btn_Thoat;
        private CONTROL.BUTTON btn_LUULAI;
    }
}