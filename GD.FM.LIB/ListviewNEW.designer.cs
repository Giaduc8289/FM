namespace GD.FM.LIB 
{
    partial class ListviewNEW
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
            this.txtKeySearch = new RegExTextBox();
            this.btnTimKiem = new GD.FM.CONTROL.BUTTON();
            this.txttenfiled = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combofiled = new MultiColumnComboBox();
            this.SuspendLayout();
            // 
            // btnchon
            // 
            this.btnchon.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnchon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnchon.Location = new System.Drawing.Point(864, 445);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(65, 23);
            this.btnchon.TabIndex = 36;
            this.btnchon.Text = "&Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 412);
            this.panel1.TabIndex = 34;
            // 
            // txtKeySearch
            // 
            this.txtKeySearch.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeySearch.BannerText = null;
            this.txtKeySearch.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txtKeySearch.Location = new System.Drawing.Point(9, 7);
            this.txtKeySearch.Name = "txtKeySearch";
            this.txtKeySearch.Regular_Expression = null;
            this.txtKeySearch.Size = new System.Drawing.Size(333, 20);
            this.txtKeySearch.TabIndex = 1;
            this.txtKeySearch.TextChanged += new System.EventHandler(this.txtKeySearch_TextChanged);
            this.txtKeySearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtKeySearch_Validating);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnTimKiem.Location = new System.Drawing.Point(723, 8);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 21);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txttenfiled
            // 
            this.txttenfiled.Location = new System.Drawing.Point(479, 6);
            this.txttenfiled.Name = "txttenfiled";
            this.txttenfiled.ReadOnly = true;
            this.txttenfiled.Size = new System.Drawing.Size(102, 20);
            this.txttenfiled.TabIndex = 126;
            this.txttenfiled.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "Cột";
            // 
            // combofiled
            // 
            this.combofiled.AutoComplete = true;
            this.combofiled.AutoDropdown = false;
            this.combofiled.BackColorEven = System.Drawing.Color.White;
            this.combofiled.BackColorOdd = System.Drawing.Color.White;
            this.combofiled.ColumnNames = "";
            this.combofiled.ColumnWidthDefault = 75;
            this.combofiled.ColumnWidths = "";
            this.combofiled.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combofiled.FormattingEnabled = true;
            this.combofiled.LinkedColumnIndex = 0;
            this.combofiled.LinkedTextBox = null;
            this.combofiled.Location = new System.Drawing.Point(389, 6);
            this.combofiled.Name = "combofiled";
            this.combofiled.Size = new System.Drawing.Size(89, 21);
            this.combofiled.TabIndex = 125;
            // 
            // ListviewNEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 477);
            this.Controls.Add(this.txttenfiled);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.combofiled);
            this.Controls.Add(this.txtKeySearch);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.panel1);
            this.Name = "ListviewNEW";
            this.Text = "Listview";
            this.Load += new System.EventHandler(this.Listview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GD.FM.CONTROL.BUTTON btnchon;
        private System.Windows.Forms.Panel panel1;
        private RegExTextBox txtKeySearch;
        private GD.FM.CONTROL.BUTTON btnTimKiem;
        private System.Windows.Forms.TextBox txttenfiled;
        private System.Windows.Forms.Label label6;
        private MultiColumnComboBox combofiled;
    }
}