namespace CourseWork
{
	partial class Form1
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.panelGeneral = new System.Windows.Forms.Panel();
			this.tabPersonal = new System.Windows.Forms.TabPage();
			this.panelPersonal = new System.Windows.Forms.Panel();
			this.tabSpecial = new System.Windows.Forms.TabPage();
			this.panelSpecial = new System.Windows.Forms.Panel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolSave = new System.Windows.Forms.ToolStripButton();
			this.toolLoad = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.tabPersonal.SuspendLayout();
			this.tabSpecial.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabGeneral);
			this.tabControl.Controls.Add(this.tabPersonal);
			this.tabControl.Controls.Add(this.tabSpecial);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl.Location = new System.Drawing.Point(0, 55);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(843, 400);
			this.tabControl.TabIndex = 0;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.panelGeneral);
			this.tabGeneral.Location = new System.Drawing.Point(4, 25);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Size = new System.Drawing.Size(835, 371);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			// 
			// panelGeneral
			// 
			this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelGeneral.Location = new System.Drawing.Point(0, 0);
			this.panelGeneral.Name = "panelGeneral";
			this.panelGeneral.Size = new System.Drawing.Size(835, 371);
			this.panelGeneral.TabIndex = 0;
			// 
			// tabPersonal
			// 
			this.tabPersonal.Controls.Add(this.panelPersonal);
			this.tabPersonal.Location = new System.Drawing.Point(4, 25);
			this.tabPersonal.Name = "tabPersonal";
			this.tabPersonal.Size = new System.Drawing.Size(792, 371);
			this.tabPersonal.TabIndex = 1;
			this.tabPersonal.Text = "Personal";
			// 
			// panelPersonal
			// 
			this.panelPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPersonal.Location = new System.Drawing.Point(0, 0);
			this.panelPersonal.Name = "panelPersonal";
			this.panelPersonal.Size = new System.Drawing.Size(792, 371);
			this.panelPersonal.TabIndex = 0;
			// 
			// tabSpecial
			// 
			this.tabSpecial.Controls.Add(this.panelSpecial);
			this.tabSpecial.Location = new System.Drawing.Point(4, 25);
			this.tabSpecial.Name = "tabSpecial";
			this.tabSpecial.Size = new System.Drawing.Size(792, 371);
			this.tabSpecial.TabIndex = 2;
			this.tabSpecial.Text = "Special";
			// 
			// panelSpecial
			// 
			this.panelSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSpecial.Location = new System.Drawing.Point(0, 0);
			this.panelSpecial.Name = "panelSpecial";
			this.panelSpecial.Size = new System.Drawing.Size(792, 371);
			this.panelSpecial.TabIndex = 0;
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
			this.menuStrip.Location = new System.Drawing.Point(0, 27);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(843, 28);
			this.menuStrip.TabIndex = 1;
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenuItem,
            this.saveMenuItem,
            this.exitMenuItem});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(46, 24);
			this.fileMenu.Text = "File";
			// 
			// loadMenuItem
			// 
			this.loadMenuItem.Name = "loadMenuItem";
			this.loadMenuItem.Size = new System.Drawing.Size(224, 26);
			this.loadMenuItem.Text = "Load...";
			// 
			// saveMenuItem
			// 
			this.saveMenuItem.Name = "saveMenuItem";
			this.saveMenuItem.Size = new System.Drawing.Size(224, 26);
			this.saveMenuItem.Text = "Save...";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(224, 26);
			this.exitMenuItem.Text = "Exit";
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(55, 24);
			this.helpMenu.Text = "Help";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(133, 26);
			this.aboutMenuItem.Text = "About";
			// 
			// toolStrip
			// 
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolLoad});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(843, 27);
			this.toolStrip.TabIndex = 2;
			// 
			// toolSave
			// 
			this.toolSave.Name = "toolSave";
			this.toolSave.Size = new System.Drawing.Size(44, 24);
			this.toolSave.Text = "Save";
			this.toolSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolLoad
			// 
			this.toolLoad.Name = "toolLoad";
			this.toolLoad.Size = new System.Drawing.Size(46, 24);
			this.toolLoad.Text = "Load";
			this.toolLoad.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 494);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(843, 26);
			this.statusStrip.TabIndex = 3;
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(50, 20);
			this.statusLabel.Text = "Ready";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(304, 461);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(447, 461);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 5;
			this.btnLoad.Text = "Load";
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(843, 520);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Form1";
			this.Text = "House Data Management";
			this.tabControl.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabPersonal.ResumeLayout(false);
			this.tabSpecial.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.TabPage tabPersonal;
		private System.Windows.Forms.TabPage tabSpecial;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.ToolStripButton toolSave;
		private System.Windows.Forms.ToolStripButton toolLoad;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenu;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Panel panelGeneral;
		private System.Windows.Forms.Panel panelPersonal;
		private System.Windows.Forms.Panel panelSpecial;
	}
}

