namespace GD.FM.CONTROL
{
    partial class setup
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
            this.SuspendLayout();
            // 
            // setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 253);
            this.Name = "setup";
            this.Text = "Sửa Hiển Thị Trên Lưới";
            this.Load += new System.EventHandler(this.setupviewgrid_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.setupviewgrid_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.myKeyUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}