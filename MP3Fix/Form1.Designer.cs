namespace MP3Fix {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.radioExtrapolateTrack = new System.Windows.Forms.RadioButton();
            this.radioUseTagTrack = new System.Windows.Forms.RadioButton();
            this.delimiterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAlbum = new System.Windows.Forms.GroupBox();
            this.textBoxCustomAlbum = new System.Windows.Forms.TextBox();
            this.radioAlbumUseCustom = new System.Windows.Forms.RadioButton();
            this.radioAlbumNoChange = new System.Windows.Forms.RadioButton();
            this.radioAlbumUseFolder = new System.Windows.Forms.RadioButton();
            this.checkBoxAlbumCapitals = new System.Windows.Forms.CheckBox();
            this.radioAlbumUseTag = new System.Windows.Forms.RadioButton();
            this.titleUpdateButton = new System.Windows.Forms.Button();
            this.groupBoxArtist = new System.Windows.Forms.GroupBox();
            this.textBoxCustomArtist = new System.Windows.Forms.TextBox();
            this.radioArtistUseCustom = new System.Windows.Forms.RadioButton();
            this.radioArtistNoChange = new System.Windows.Forms.RadioButton();
            this.checkBoxArtistCapitals = new System.Windows.Forms.CheckBox();
            this.radioArtistUseVarious = new System.Windows.Forms.RadioButton();
            this.radioArtistUseTag = new System.Windows.Forms.RadioButton();
            this.radioArtistUseFolder = new System.Windows.Forms.RadioButton();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.radioTitleNoChange = new System.Windows.Forms.RadioButton();
            this.checkBoxTitleCapitals = new System.Windows.Forms.CheckBox();
            this.radioTitleExtrapolate = new System.Windows.Forms.RadioButton();
            this.radioTitleUseTag = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            this.groupBoxAlbum.SuspendLayout();
            this.groupBoxArtist.SuspendLayout();
            this.groupBoxTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1198, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOther);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxAlbum);
            this.splitContainer1.Panel2.Controls.Add(this.titleUpdateButton);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxArtist);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxTitle);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1198, 551);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(5, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(279, 541);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxOther.Controls.Add(this.radioExtrapolateTrack);
            this.groupBoxOther.Controls.Add(this.radioUseTagTrack);
            this.groupBoxOther.Controls.Add(this.delimiterTextBox);
            this.groupBoxOther.Controls.Add(this.label1);
            this.groupBoxOther.Location = new System.Drawing.Point(410, 220);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(127, 124);
            this.groupBoxOther.TabIndex = 6;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "Other Controls";
            // 
            // radioExtrapolateTrack
            // 
            this.radioExtrapolateTrack.AutoSize = true;
            this.radioExtrapolateTrack.Location = new System.Drawing.Point(17, 42);
            this.radioExtrapolateTrack.Name = "radioExtrapolateTrack";
            this.radioExtrapolateTrack.Size = new System.Drawing.Size(105, 17);
            this.radioExtrapolateTrack.TabIndex = 3;
            this.radioExtrapolateTrack.TabStop = true;
            this.radioExtrapolateTrack.Text = "Extrapolate track";
            this.radioExtrapolateTrack.UseVisualStyleBackColor = true;
            // 
            // radioUseTagTrack
            // 
            this.radioUseTagTrack.AutoSize = true;
            this.radioUseTagTrack.Location = new System.Drawing.Point(17, 19);
            this.radioUseTagTrack.Name = "radioUseTagTrack";
            this.radioUseTagTrack.Size = new System.Drawing.Size(91, 17);
            this.radioUseTagTrack.TabIndex = 2;
            this.radioUseTagTrack.TabStop = true;
            this.radioUseTagTrack.Text = "Use ID3 track";
            this.radioUseTagTrack.UseVisualStyleBackColor = true;
            // 
            // delimiterTextBox
            // 
            this.delimiterTextBox.Location = new System.Drawing.Point(61, 89);
            this.delimiterTextBox.Name = "delimiterTextBox";
            this.delimiterTextBox.Size = new System.Drawing.Size(51, 20);
            this.delimiterTextBox.TabIndex = 1;
            this.delimiterTextBox.Text = " - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delimiter";
            // 
            // groupBoxAlbum
            // 
            this.groupBoxAlbum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxAlbum.Controls.Add(this.textBoxCustomAlbum);
            this.groupBoxAlbum.Controls.Add(this.radioAlbumUseCustom);
            this.groupBoxAlbum.Controls.Add(this.radioAlbumNoChange);
            this.groupBoxAlbum.Controls.Add(this.radioAlbumUseFolder);
            this.groupBoxAlbum.Controls.Add(this.checkBoxAlbumCapitals);
            this.groupBoxAlbum.Controls.Add(this.radioAlbumUseTag);
            this.groupBoxAlbum.Location = new System.Drawing.Point(143, 220);
            this.groupBoxAlbum.Name = "groupBoxAlbum";
            this.groupBoxAlbum.Size = new System.Drawing.Size(127, 167);
            this.groupBoxAlbum.TabIndex = 5;
            this.groupBoxAlbum.TabStop = false;
            this.groupBoxAlbum.Text = "Album Controls";
            // 
            // textBoxCustomAlbum
            // 
            this.textBoxCustomAlbum.Location = new System.Drawing.Point(17, 115);
            this.textBoxCustomAlbum.Name = "textBoxCustomAlbum";
            this.textBoxCustomAlbum.Size = new System.Drawing.Size(95, 20);
            this.textBoxCustomAlbum.TabIndex = 7;
            // 
            // radioAlbumUseCustom
            // 
            this.radioAlbumUseCustom.AutoSize = true;
            this.radioAlbumUseCustom.Location = new System.Drawing.Point(17, 90);
            this.radioAlbumUseCustom.Name = "radioAlbumUseCustom";
            this.radioAlbumUseCustom.Size = new System.Drawing.Size(81, 17);
            this.radioAlbumUseCustom.TabIndex = 6;
            this.radioAlbumUseCustom.TabStop = true;
            this.radioAlbumUseCustom.Text = "Use custom";
            this.radioAlbumUseCustom.UseVisualStyleBackColor = true;
            // 
            // radioAlbumNoChange
            // 
            this.radioAlbumNoChange.AutoSize = true;
            this.radioAlbumNoChange.Location = new System.Drawing.Point(17, 66);
            this.radioAlbumNoChange.Name = "radioAlbumNoChange";
            this.radioAlbumNoChange.Size = new System.Drawing.Size(78, 17);
            this.radioAlbumNoChange.TabIndex = 5;
            this.radioAlbumNoChange.TabStop = true;
            this.radioAlbumNoChange.Text = "No change";
            this.radioAlbumNoChange.UseVisualStyleBackColor = true;
            // 
            // radioAlbumUseFolder
            // 
            this.radioAlbumUseFolder.AutoSize = true;
            this.radioAlbumUseFolder.Location = new System.Drawing.Point(17, 43);
            this.radioAlbumUseFolder.Name = "radioAlbumUseFolder";
            this.radioAlbumUseFolder.Size = new System.Drawing.Size(104, 17);
            this.radioAlbumUseFolder.TabIndex = 2;
            this.radioAlbumUseFolder.TabStop = true;
            this.radioAlbumUseFolder.Text = "Use folder album";
            this.radioAlbumUseFolder.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlbumCapitals
            // 
            this.checkBoxAlbumCapitals.AutoSize = true;
            this.checkBoxAlbumCapitals.Location = new System.Drawing.Point(17, 139);
            this.checkBoxAlbumCapitals.Name = "checkBoxAlbumCapitals";
            this.checkBoxAlbumCapitals.Size = new System.Drawing.Size(78, 17);
            this.checkBoxAlbumCapitals.TabIndex = 1;
            this.checkBoxAlbumCapitals.Text = "Fix capitals";
            this.checkBoxAlbumCapitals.UseVisualStyleBackColor = true;
            // 
            // radioAlbumUseTag
            // 
            this.radioAlbumUseTag.AutoSize = true;
            this.radioAlbumUseTag.Location = new System.Drawing.Point(17, 19);
            this.radioAlbumUseTag.Name = "radioAlbumUseTag";
            this.radioAlbumUseTag.Size = new System.Drawing.Size(95, 17);
            this.radioAlbumUseTag.TabIndex = 0;
            this.radioAlbumUseTag.TabStop = true;
            this.radioAlbumUseTag.Text = "Use ID3 album";
            this.radioAlbumUseTag.UseVisualStyleBackColor = true;
            // 
            // titleUpdateButton
            // 
            this.titleUpdateButton.Location = new System.Drawing.Point(143, 495);
            this.titleUpdateButton.Name = "titleUpdateButton";
            this.titleUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.titleUpdateButton.TabIndex = 2;
            this.titleUpdateButton.Text = "Update";
            this.titleUpdateButton.UseVisualStyleBackColor = true;
            this.titleUpdateButton.Click += new System.EventHandler(this.titleUpdateButton_Click);
            // 
            // groupBoxArtist
            // 
            this.groupBoxArtist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxArtist.Controls.Add(this.textBoxCustomArtist);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseCustom);
            this.groupBoxArtist.Controls.Add(this.radioArtistNoChange);
            this.groupBoxArtist.Controls.Add(this.checkBoxArtistCapitals);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseVarious);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseTag);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseFolder);
            this.groupBoxArtist.Location = new System.Drawing.Point(276, 220);
            this.groupBoxArtist.Name = "groupBoxArtist";
            this.groupBoxArtist.Size = new System.Drawing.Size(128, 192);
            this.groupBoxArtist.TabIndex = 4;
            this.groupBoxArtist.TabStop = false;
            this.groupBoxArtist.Text = "Artist Controls";
            // 
            // textBoxCustomArtist
            // 
            this.textBoxCustomArtist.Location = new System.Drawing.Point(17, 137);
            this.textBoxCustomArtist.Name = "textBoxCustomArtist";
            this.textBoxCustomArtist.Size = new System.Drawing.Size(95, 20);
            this.textBoxCustomArtist.TabIndex = 8;
            // 
            // radioArtistUseCustom
            // 
            this.radioArtistUseCustom.AutoSize = true;
            this.radioArtistUseCustom.Location = new System.Drawing.Point(17, 113);
            this.radioArtistUseCustom.Name = "radioArtistUseCustom";
            this.radioArtistUseCustom.Size = new System.Drawing.Size(81, 17);
            this.radioArtistUseCustom.TabIndex = 8;
            this.radioArtistUseCustom.TabStop = true;
            this.radioArtistUseCustom.Text = "Use custom";
            this.radioArtistUseCustom.UseVisualStyleBackColor = true;
            // 
            // radioArtistNoChange
            // 
            this.radioArtistNoChange.AutoSize = true;
            this.radioArtistNoChange.Location = new System.Drawing.Point(17, 89);
            this.radioArtistNoChange.Name = "radioArtistNoChange";
            this.radioArtistNoChange.Size = new System.Drawing.Size(78, 17);
            this.radioArtistNoChange.TabIndex = 5;
            this.radioArtistNoChange.TabStop = true;
            this.radioArtistNoChange.Text = "No change";
            this.radioArtistNoChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxArtistCapitals
            // 
            this.checkBoxArtistCapitals.AutoSize = true;
            this.checkBoxArtistCapitals.Location = new System.Drawing.Point(17, 163);
            this.checkBoxArtistCapitals.Name = "checkBoxArtistCapitals";
            this.checkBoxArtistCapitals.Size = new System.Drawing.Size(78, 17);
            this.checkBoxArtistCapitals.TabIndex = 4;
            this.checkBoxArtistCapitals.Text = "Fix capitals";
            this.checkBoxArtistCapitals.UseVisualStyleBackColor = true;
            // 
            // radioArtistUseVarious
            // 
            this.radioArtistUseVarious.AutoSize = true;
            this.radioArtistUseVarious.Location = new System.Drawing.Point(17, 66);
            this.radioArtistUseVarious.Name = "radioArtistUseVarious";
            this.radioArtistUseVarious.Size = new System.Drawing.Size(81, 17);
            this.radioArtistUseVarious.TabIndex = 2;
            this.radioArtistUseVarious.TabStop = true;
            this.radioArtistUseVarious.Text = "Use various";
            this.radioArtistUseVarious.UseVisualStyleBackColor = true;
            // 
            // radioArtistUseTag
            // 
            this.radioArtistUseTag.AutoSize = true;
            this.radioArtistUseTag.Location = new System.Drawing.Point(17, 19);
            this.radioArtistUseTag.Name = "radioArtistUseTag";
            this.radioArtistUseTag.Size = new System.Drawing.Size(89, 17);
            this.radioArtistUseTag.TabIndex = 1;
            this.radioArtistUseTag.TabStop = true;
            this.radioArtistUseTag.Text = "Use ID3 artist";
            this.radioArtistUseTag.UseVisualStyleBackColor = true;
            // 
            // radioArtistUseFolder
            // 
            this.radioArtistUseFolder.AutoSize = true;
            this.radioArtistUseFolder.Location = new System.Drawing.Point(17, 42);
            this.radioArtistUseFolder.Name = "radioArtistUseFolder";
            this.radioArtistUseFolder.Size = new System.Drawing.Size(98, 17);
            this.radioArtistUseFolder.TabIndex = 0;
            this.radioArtistUseFolder.TabStop = true;
            this.radioArtistUseFolder.Text = "Use folder artist";
            this.radioArtistUseFolder.UseVisualStyleBackColor = true;
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxTitle.Controls.Add(this.radioTitleNoChange);
            this.groupBoxTitle.Controls.Add(this.checkBoxTitleCapitals);
            this.groupBoxTitle.Controls.Add(this.radioTitleExtrapolate);
            this.groupBoxTitle.Controls.Add(this.radioTitleUseTag);
            this.groupBoxTitle.Location = new System.Drawing.Point(8, 219);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(128, 139);
            this.groupBoxTitle.TabIndex = 3;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Title Controls";
            // 
            // radioTitleNoChange
            // 
            this.radioTitleNoChange.AutoSize = true;
            this.radioTitleNoChange.Location = new System.Drawing.Point(17, 67);
            this.radioTitleNoChange.Name = "radioTitleNoChange";
            this.radioTitleNoChange.Size = new System.Drawing.Size(78, 17);
            this.radioTitleNoChange.TabIndex = 4;
            this.radioTitleNoChange.TabStop = true;
            this.radioTitleNoChange.Text = "No change";
            this.radioTitleNoChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxTitleCapitals
            // 
            this.checkBoxTitleCapitals.AutoSize = true;
            this.checkBoxTitleCapitals.Location = new System.Drawing.Point(18, 93);
            this.checkBoxTitleCapitals.Name = "checkBoxTitleCapitals";
            this.checkBoxTitleCapitals.Size = new System.Drawing.Size(79, 17);
            this.checkBoxTitleCapitals.TabIndex = 3;
            this.checkBoxTitleCapitals.Text = "Fix Capitals";
            this.checkBoxTitleCapitals.UseVisualStyleBackColor = true;
            // 
            // radioTitleExtrapolate
            // 
            this.radioTitleExtrapolate.AutoSize = true;
            this.radioTitleExtrapolate.Location = new System.Drawing.Point(18, 44);
            this.radioTitleExtrapolate.Name = "radioTitleExtrapolate";
            this.radioTitleExtrapolate.Size = new System.Drawing.Size(97, 17);
            this.radioTitleExtrapolate.TabIndex = 1;
            this.radioTitleExtrapolate.TabStop = true;
            this.radioTitleExtrapolate.Text = "Extrapolate title";
            this.radioTitleExtrapolate.UseVisualStyleBackColor = true;
            this.radioTitleExtrapolate.Click += new System.EventHandler(this.radioTitleExtrapolate_Click);
            // 
            // radioTitleUseTag
            // 
            this.radioTitleUseTag.AutoSize = true;
            this.radioTitleUseTag.Location = new System.Drawing.Point(18, 20);
            this.radioTitleUseTag.Name = "radioTitleUseTag";
            this.radioTitleUseTag.Size = new System.Drawing.Size(83, 17);
            this.radioTitleUseTag.TabIndex = 0;
            this.radioTitleUseTag.TabStop = true;
            this.radioTitleUseTag.Text = "Use ID3 title";
            this.radioTitleUseTag.UseVisualStyleBackColor = true;
            this.radioTitleUseTag.Click += new System.EventHandler(this.radioTitleUseTag_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(558, 335);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 167);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Location = new System.Drawing.Point(5, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(895, 208);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Album";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Artist";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Track";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Title";
            this.columnHeader5.Width = 171;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Output";
            this.columnHeader6.Width = 268;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 597);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MP3 File Fixer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxOther.PerformLayout();
            this.groupBoxAlbum.ResumeLayout(false);
            this.groupBoxAlbum.PerformLayout();
            this.groupBoxArtist.ResumeLayout(false);
            this.groupBoxArtist.PerformLayout();
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxTitle;
        private System.Windows.Forms.RadioButton radioTitleExtrapolate;
        private System.Windows.Forms.RadioButton radioTitleUseTag;
        private System.Windows.Forms.CheckBox checkBoxTitleCapitals;
        private System.Windows.Forms.Button titleUpdateButton;
        private System.Windows.Forms.GroupBox groupBoxArtist;
        private System.Windows.Forms.RadioButton radioArtistUseTag;
        private System.Windows.Forms.RadioButton radioArtistUseFolder;
        private System.Windows.Forms.RadioButton radioArtistUseVarious;
        private System.Windows.Forms.GroupBox groupBoxAlbum;
        private System.Windows.Forms.RadioButton radioAlbumUseTag;
        private System.Windows.Forms.CheckBox checkBoxArtistCapitals;
        private System.Windows.Forms.CheckBox checkBoxAlbumCapitals;
        private System.Windows.Forms.RadioButton radioAlbumUseFolder;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.TextBox delimiterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioUseTagTrack;
        private System.Windows.Forms.RadioButton radioTitleNoChange;
        private System.Windows.Forms.RadioButton radioAlbumNoChange;
        private System.Windows.Forms.RadioButton radioArtistNoChange;
        private System.Windows.Forms.RadioButton radioExtrapolateTrack;
        private System.Windows.Forms.TextBox textBoxCustomAlbum;
        private System.Windows.Forms.RadioButton radioAlbumUseCustom;
        private System.Windows.Forms.RadioButton radioArtistUseCustom;
        private System.Windows.Forms.TextBox textBoxCustomArtist;
    }
}

