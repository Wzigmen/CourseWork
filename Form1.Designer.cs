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
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBoxJ = new System.Windows.Forms.CheckBox();
			this.checkBoxM = new System.Windows.Forms.CheckBox();
			this.textBoxPatronymic = new System.Windows.Forms.TextBox();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
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
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.cjdis = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxRegion = new System.Windows.Forms.ComboBox();
			this.comboBoxStrana = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.label10 = new System.Windows.Forms.Label();
			this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboBoxPloshad = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBoxComment = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBoxAllHuman = new System.Windows.Forms.TextBox();
			this.tabControl.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.panelGeneral.SuspendLayout();
			this.tabPersonal.SuspendLayout();
			this.panelPersonal.SuspendLayout();
			this.tabSpecial.SuspendLayout();
			this.panelSpecial.SuspendLayout();
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
			this.panelGeneral.Controls.Add(this.comboBoxStrana);
			this.panelGeneral.Controls.Add(this.comboBoxRegion);
			this.panelGeneral.Controls.Add(this.label8);
			this.panelGeneral.Controls.Add(this.label7);
			this.panelGeneral.Controls.Add(this.cjdis);
			this.panelGeneral.Controls.Add(this.dateTimePicker);
			this.panelGeneral.Controls.Add(this.label6);
			this.panelGeneral.Controls.Add(this.textBoxPhone);
			this.panelGeneral.Controls.Add(this.label5);
			this.panelGeneral.Controls.Add(this.label4);
			this.panelGeneral.Controls.Add(this.checkBoxJ);
			this.panelGeneral.Controls.Add(this.checkBoxM);
			this.panelGeneral.Controls.Add(this.textBoxPatronymic);
			this.panelGeneral.Controls.Add(this.textBoxFirstName);
			this.panelGeneral.Controls.Add(this.textBoxLastName);
			this.panelGeneral.Controls.Add(this.label3);
			this.panelGeneral.Controls.Add(this.label2);
			this.panelGeneral.Controls.Add(this.label1);
			this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelGeneral.Location = new System.Drawing.Point(0, 0);
			this.panelGeneral.Name = "panelGeneral";
			this.panelGeneral.Size = new System.Drawing.Size(835, 371);
			this.panelGeneral.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(264, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "+7";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(292, 46);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(153, 22);
			this.textBoxPhone.TabIndex = 10;
			this.textBoxPhone.Text = "_***_***_**_**";
			this.textBoxPhone.Click += new System.EventHandler(this.textBox4_Click);
			this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
			this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(289, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Номер телефона";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Пол";
			// 
			// checkBoxJ
			// 
			this.checkBoxJ.AutoSize = true;
			this.checkBoxJ.Location = new System.Drawing.Point(71, 266);
			this.checkBoxJ.Name = "checkBoxJ";
			this.checkBoxJ.Size = new System.Drawing.Size(42, 20);
			this.checkBoxJ.TabIndex = 7;
			this.checkBoxJ.Text = "Ж";
			this.checkBoxJ.UseVisualStyleBackColor = true;
			this.checkBoxJ.CheckedChanged += new System.EventHandler(this.checkBoxJ_CheckedChanged);
			// 
			// checkBoxM
			// 
			this.checkBoxM.AutoSize = true;
			this.checkBoxM.Location = new System.Drawing.Point(22, 266);
			this.checkBoxM.Name = "checkBoxM";
			this.checkBoxM.Size = new System.Drawing.Size(40, 20);
			this.checkBoxM.TabIndex = 6;
			this.checkBoxM.Text = "М";
			this.checkBoxM.UseVisualStyleBackColor = true;
			this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
			// 
			// textBoxPatronymic
			// 
			this.textBoxPatronymic.Location = new System.Drawing.Point(22, 191);
			this.textBoxPatronymic.Name = "textBoxPatronymic";
			this.textBoxPatronymic.Size = new System.Drawing.Size(153, 22);
			this.textBoxPatronymic.TabIndex = 5;
			this.textBoxPatronymic.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(22, 116);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(153, 22);
			this.textBoxFirstName.TabIndex = 4;
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(22, 46);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(153, 22);
			this.textBoxLastName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Отчество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Фамилия";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя";
			// 
			// tabPersonal
			// 
			this.tabPersonal.Controls.Add(this.panelPersonal);
			this.tabPersonal.Location = new System.Drawing.Point(4, 25);
			this.tabPersonal.Name = "tabPersonal";
			this.tabPersonal.Size = new System.Drawing.Size(835, 371);
			this.tabPersonal.TabIndex = 1;
			this.tabPersonal.Text = "Personal";
			// 
			// panelPersonal
			// 
			this.panelPersonal.Controls.Add(this.checkedListBox3);
			this.panelPersonal.Controls.Add(this.label11);
			this.panelPersonal.Controls.Add(this.checkedListBox2);
			this.panelPersonal.Controls.Add(this.label10);
			this.panelPersonal.Controls.Add(this.checkedListBox1);
			this.panelPersonal.Controls.Add(this.label9);
			this.panelPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPersonal.Location = new System.Drawing.Point(0, 0);
			this.panelPersonal.Name = "panelPersonal";
			this.panelPersonal.Size = new System.Drawing.Size(835, 371);
			this.panelPersonal.TabIndex = 0;
			// 
			// tabSpecial
			// 
			this.tabSpecial.Controls.Add(this.panelSpecial);
			this.tabSpecial.Location = new System.Drawing.Point(4, 25);
			this.tabSpecial.Name = "tabSpecial";
			this.tabSpecial.Size = new System.Drawing.Size(835, 371);
			this.tabSpecial.TabIndex = 2;
			this.tabSpecial.Text = "Special";
			// 
			// panelSpecial
			// 
			this.panelSpecial.Controls.Add(this.textBoxAllHuman);
			this.panelSpecial.Controls.Add(this.label14);
			this.panelSpecial.Controls.Add(this.textBoxComment);
			this.panelSpecial.Controls.Add(this.label13);
			this.panelSpecial.Controls.Add(this.comboBoxPloshad);
			this.panelSpecial.Controls.Add(this.label12);
			this.panelSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSpecial.Location = new System.Drawing.Point(0, 0);
			this.panelSpecial.Name = "panelSpecial";
			this.panelSpecial.Size = new System.Drawing.Size(835, 371);
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
			this.fileMenu.Size = new System.Drawing.Size(59, 24);
			this.fileMenu.Text = "Файл";
			// 
			// loadMenuItem
			// 
			this.loadMenuItem.Name = "loadMenuItem";
			this.loadMenuItem.Size = new System.Drawing.Size(134, 26);
			this.loadMenuItem.Text = "Load...";
			// 
			// saveMenuItem
			// 
			this.saveMenuItem.Name = "saveMenuItem";
			this.saveMenuItem.Size = new System.Drawing.Size(134, 26);
			this.saveMenuItem.Text = "Save...";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(134, 26);
			this.exitMenuItem.Text = "Exit";
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(118, 24);
			this.helpMenu.Text = "О программе";
			this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(224, 26);
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
			this.btnSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(447, 461);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 5;
			this.btnLoad.Text = "Load";
			this.btnLoad.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimePicker.Location = new System.Drawing.Point(292, 116);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dateTimePicker.Size = new System.Drawing.Size(174, 22);
			this.dateTimePicker.TabIndex = 11;
			// 
			// cjdis
			// 
			this.cjdis.AutoSize = true;
			this.cjdis.Location = new System.Drawing.Point(289, 97);
			this.cjdis.Name = "cjdis";
			this.cjdis.Size = new System.Drawing.Size(39, 16);
			this.cjdis.TabIndex = 12;
			this.cjdis.Text = "Дата";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(289, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "Регион";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(467, 169);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 16);
			this.label8.TabIndex = 16;
			this.label8.Text = "Страна";
			// 
			// comboBoxRegion
			// 
			this.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.comboBoxRegion.FormattingEnabled = true;
			this.comboBoxRegion.Items.AddRange(new object[] {
            "Москва",
            "Нижний Новгород",
            "Санкт-Питербург"});
			this.comboBoxRegion.Location = new System.Drawing.Point(292, 188);
			this.comboBoxRegion.Name = "comboBoxRegion";
			this.comboBoxRegion.Size = new System.Drawing.Size(121, 102);
			this.comboBoxRegion.Sorted = true;
			this.comboBoxRegion.TabIndex = 17;
			// 
			// comboBoxStrana
			// 
			this.comboBoxStrana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.comboBoxStrana.FormattingEnabled = true;
			this.comboBoxStrana.Items.AddRange(new object[] {
            "Россия",
            "Беларусь",
            "Китай"});
			this.comboBoxStrana.Location = new System.Drawing.Point(470, 188);
			this.comboBoxStrana.Name = "comboBoxStrana";
			this.comboBoxStrana.Size = new System.Drawing.Size(121, 102);
			this.comboBoxStrana.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(21, 29);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(233, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "Какой тип жилья рассматриваете?";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Комната",
            "Студия",
            "Однакомнатная квартира",
            "Двухкомнатная квартира",
            "Три и более комнат",
            "Апартаменты",
            "Земельный участок",
            "Дом"});
			this.checkedListBox1.Location = new System.Drawing.Point(24, 48);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(302, 140);
			this.checkedListBox1.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(21, 204);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(184, 16);
			this.label10.TabIndex = 2;
			this.label10.Text = "Ваше семейное положение";
			// 
			// checkedListBox2
			// 
			this.checkedListBox2.FormattingEnabled = true;
			this.checkedListBox2.Items.AddRange(new object[] {
            "Холост",
            "В браке",
            "Имею несовершеннолетних детей"});
			this.checkedListBox2.Location = new System.Drawing.Point(24, 224);
			this.checkedListBox2.Name = "checkedListBox2";
			this.checkedListBox2.Size = new System.Drawing.Size(302, 55);
			this.checkedListBox2.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(392, 29);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 16);
			this.label11.TabIndex = 4;
			this.label11.Text = "Цель покупки";
			// 
			// checkedListBox3
			// 
			this.checkedListBox3.FormattingEnabled = true;
			this.checkedListBox3.Items.AddRange(new object[] {
            "Для проживания",
            "Для инвестиции и сбережения",
            "Помогаю другому человеку"});
			this.checkedListBox3.Location = new System.Drawing.Point(395, 48);
			this.checkedListBox3.Name = "checkedListBox3";
			this.checkedListBox3.Size = new System.Drawing.Size(302, 55);
			this.checkedListBox3.TabIndex = 5;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(21, 28);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(184, 16);
			this.label12.TabIndex = 0;
			this.label12.Text = "Общая площадь помещения";
			// 
			// comboBoxPloshad
			// 
			this.comboBoxPloshad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.comboBoxPloshad.FormattingEnabled = true;
			this.comboBoxPloshad.Items.AddRange(new object[] {
            "30 кв.м",
            "40 кв.м",
            "50 кв.м",
            "1000 кв.м"});
			this.comboBoxPloshad.Location = new System.Drawing.Point(24, 47);
			this.comboBoxPloshad.Name = "comboBoxPloshad";
			this.comboBoxPloshad.Size = new System.Drawing.Size(121, 104);
			this.comboBoxPloshad.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(330, 28);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(192, 16);
			this.label13.TabIndex = 2;
			this.label13.Text = "Напишите Ваши дополнения";
			// 
			// textBoxComment
			// 
			this.textBoxComment.Location = new System.Drawing.Point(333, 47);
			this.textBoxComment.Multiline = true;
			this.textBoxComment.Name = "textBoxComment";
			this.textBoxComment.Size = new System.Drawing.Size(368, 147);
			this.textBoxComment.TabIndex = 3;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(21, 165);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(152, 16);
			this.label14.TabIndex = 4;
			this.label14.Text = "Колличество жильцов";
			// 
			// textBoxAllHuman
			// 
			this.textBoxAllHuman.Location = new System.Drawing.Point(24, 185);
			this.textBoxAllHuman.Name = "textBoxAllHuman";
			this.textBoxAllHuman.Size = new System.Drawing.Size(100, 22);
			this.textBoxAllHuman.TabIndex = 5;
			this.textBoxAllHuman.TextChanged += new System.EventHandler(this.textBoxAllHuman_TextChanged);
			this.textBoxAllHuman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAllHuman_KeyPress);
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
			this.Text = "Анкета Квартиры";
			this.tabControl.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.panelGeneral.ResumeLayout(false);
			this.panelGeneral.PerformLayout();
			this.tabPersonal.ResumeLayout(false);
			this.panelPersonal.ResumeLayout(false);
			this.panelPersonal.PerformLayout();
			this.tabSpecial.ResumeLayout(false);
			this.panelSpecial.ResumeLayout(false);
			this.panelSpecial.PerformLayout();
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
		private System.Windows.Forms.TextBox textBoxPatronymic;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxJ;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label cjdis;
		private System.Windows.Forms.ComboBox comboBoxStrana;
		private System.Windows.Forms.ComboBox comboBoxRegion;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckedListBox checkedListBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckedListBox checkedListBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBoxPloshad;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBoxAllHuman;
	}
}

