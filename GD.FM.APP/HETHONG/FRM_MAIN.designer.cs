namespace GD.FM.APP.HETHONG
{
    partial class FRM_MAIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel_MENU = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiStatusBar2 = new Janus.Windows.UI.StatusBar.UIStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanelManager1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            this.uiPanel0.Id = new System.Guid("f6525ea3-c95b-4586-a4ab-3e8216b6e3be");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("f6525ea3-c95b-4586-a4ab-3e8216b6e3be"), Janus.Windows.UI.Dock.PanelDockStyle.Top, new System.Drawing.Size(1277, 34), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("f6525ea3-c95b-4586-a4ab-3e8216b6e3be"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.AllowResize = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.ContainerPanel;
            this.uiPanel0.InnerContainer = this.uiPanel_MENU;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Margin = new System.Windows.Forms.Padding(6);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(1277, 34);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Menu";
            // 
            // uiPanel_MENU
            // 
            this.uiPanel_MENU.BackColor = global::GD.FM.APP.Properties.Settings.Default.MenuColor;
            this.uiPanel_MENU.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::GD.FM.APP.Properties.Settings.Default, "MenuColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uiPanel_MENU.Location = new System.Drawing.Point(1, 1);
            this.uiPanel_MENU.Margin = new System.Windows.Forms.Padding(6);
            this.uiPanel_MENU.Name = "uiPanel_MENU";
            this.uiPanel_MENU.Size = new System.Drawing.Size(1275, 28);
            this.uiPanel_MENU.TabIndex = 0;
            // 
            // uiStatusBar2
            // 
            this.uiStatusBar2.Location = new System.Drawing.Point(0, 642);
            this.uiStatusBar2.Margin = new System.Windows.Forms.Padding(4);
            this.uiStatusBar2.Name = "uiStatusBar2";
            this.uiStatusBar2.Size = new System.Drawing.Size(1283, 33);
            this.uiStatusBar2.TabIndex = 9;
            this.uiStatusBar2.Tag = "Admin";
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.uiStatusBar2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_MAIN";
            this.Text = "PHẦN MỀM KINH DOANH HẠT NHỰA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_MAIN_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel_MENU;

        private Janus.Windows.UI.StatusBar.UIStatusBar uiStatusBar2;
    }
}