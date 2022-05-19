namespace GD.FM.LIB 
{
    partial class ListviewJanus
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
            this.btnchon = new GD.FM.CONTROL.BUTTON();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKeySearch = new GD.FM.LIB.RegExTextBox();
            this.label1 = new GD.FM.CONTROL.LABEL();
            this.SuspendLayout();
            // 
            // btnchon
            // 
            this.btnchon.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnchon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnchon.BtnShape = GD.FM.CONTROL.emunType.BtnShape.Rectangle;
            this.btnchon.BtnStyle = GD.FM.CONTROL.emunType.XPStyle.Default;
            this.btnchon.Location = new System.Drawing.Point(1152, 548);
            this.btnchon.Margin = new System.Windows.Forms.Padding(4);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(87, 28);
            this.btnchon.TabIndex = 2;
            this.btnchon.Text = "&Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(11, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 499);
            this.panel1.TabIndex = 1;
            // 
            // txtKeySearch
            // 
            this.txtKeySearch.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeySearch.BannerText = null;
            this.txtKeySearch.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txtKeySearch.Location = new System.Drawing.Point(124, 13);
            this.txtKeySearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeySearch.Name = "txtKeySearch";
            this.txtKeySearch.Regular_Expression = null;
            this.txtKeySearch.Size = new System.Drawing.Size(443, 22);
            this.txtKeySearch.TabIndex = 0;
            this.txtKeySearch.TextChanged += new System.EventHandler(this.txtKeySearch_TextChanged);
            this.txtKeySearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtKeySearch_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 128;
            this.label1.Text = "Giá trị cần tìm";
            // 
            // ListviewJanus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeySearch);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListviewJanus";
            this.Text = "Listview";
            this.Load += new System.EventHandler(this.Listview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GD.FM.CONTROL.BUTTON btnchon;
        private System.Windows.Forms.Panel panel1;
        private RegExTextBox txtKeySearch;
        private CONTROL.LABEL label1;
    }
}