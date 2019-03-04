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
            this.buttonWriteChanges = new System.Windows.Forms.Button();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.radioExtrapolateTrack = new System.Windows.Forms.RadioButton();
            this.radioUseTagTrack = new System.Windows.Forms.RadioButton();
            this.textBoxDelimiter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAlbum = new System.Windows.Forms.GroupBox();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.radioAlbumUseCustom = new System.Windows.Forms.RadioButton();
            this.radioAlbumUseFolder = new System.Windows.Forms.RadioButton();
            this.radioAlbumUseTag = new System.Windows.Forms.RadioButton();
            this.titleUpdateButton = new System.Windows.Forms.Button();
            this.groupBoxArtist = new System.Windows.Forms.GroupBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.radioArtistUseCustom = new System.Windows.Forms.RadioButton();
            this.radioArtistUseVarious = new System.Windows.Forms.RadioButton();
            this.radioArtistUseTag = new System.Windows.Forms.RadioButton();
            this.radioArtistUseFolder = new System.Windows.Forms.RadioButton();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.labelManualTitle = new System.Windows.Forms.Label();
            this.textBoxManualTitle = new System.Windows.Forms.TextBox();
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
            this.textBoxTrack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
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
            this.splitContainer1.Panel2.Controls.Add(this.buttonWriteChanges);
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
            // buttonWriteChanges
            // 
            this.buttonWriteChanges.Location = new System.Drawing.Point(577, 445);
            this.buttonWriteChanges.Name = "buttonWriteChanges";
            this.buttonWriteChanges.Size = new System.Drawing.Size(75, 41);
            this.buttonWriteChanges.TabIndex = 7;
            this.buttonWriteChanges.Text = "Write Changes";
            this.buttonWriteChanges.UseVisualStyleBackColor = true;
            this.buttonWriteChanges.Click += new System.EventHandler(this.buttonWriteChanges_Click);
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxOther.Controls.Add(this.label2);
            this.groupBoxOther.Controls.Add(this.textBoxTrack);
            this.groupBoxOther.Controls.Add(this.radioExtrapolateTrack);
            this.groupBoxOther.Controls.Add(this.radioUseTagTrack);
            this.groupBoxOther.Controls.Add(this.textBoxDelimiter);
            this.groupBoxOther.Controls.Add(this.label1);
            this.groupBoxOther.Location = new System.Drawing.Point(406, 343);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(127, 203);
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
            this.radioExtrapolateTrack.Click += new System.EventHandler(this.radioExtrapolateTrack_Click);
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
            this.radioUseTagTrack.Click += new System.EventHandler(this.radioUseTagTrack_Click);
            // 
            // textBoxDelimiter
            // 
            this.textBoxDelimiter.Location = new System.Drawing.Point(39, 170);
            this.textBoxDelimiter.Name = "textBoxDelimiter";
            this.textBoxDelimiter.Size = new System.Drawing.Size(51, 20);
            this.textBoxDelimiter.TabIndex = 1;
            this.textBoxDelimiter.Text = " - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delimiter";
            // 
            // groupBoxAlbum
            // 
            this.groupBoxAlbum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxAlbum.Controls.Add(this.textBoxAlbum);
            this.groupBoxAlbum.Controls.Add(this.radioAlbumUseCustom);
            this.groupBoxAlbum.Controls.Add(this.radioAlbumUseFolder);
            this.groupBoxAlbum.Controls.Add(this.radioAlbumUseTag);
            this.groupBoxAlbum.Location = new System.Drawing.Point(139, 343);
            this.groupBoxAlbum.Name = "groupBoxAlbum";
            this.groupBoxAlbum.Size = new System.Drawing.Size(127, 203);
            this.groupBoxAlbum.TabIndex = 5;
            this.groupBoxAlbum.TabStop = false;
            this.groupBoxAlbum.Text = "Album Controls";
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(17, 115);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(95, 20);
            this.textBoxAlbum.TabIndex = 7;
            this.textBoxAlbum.Click += new System.EventHandler(this.textBoxAlbum_Click);
            this.textBoxAlbum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlbum_KeyPress);
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
            this.radioAlbumUseCustom.Click += new System.EventHandler(this.radioAlbumUseCustom_Click);
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
            this.radioAlbumUseFolder.Click += new System.EventHandler(this.radioAlbumUseFolder_Click);
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
            this.radioAlbumUseTag.Click += new System.EventHandler(this.radioAlbumUseTag_Click);
            // 
            // titleUpdateButton
            // 
            this.titleUpdateButton.Location = new System.Drawing.Point(809, 373);
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
            this.groupBoxArtist.Controls.Add(this.textBoxArtist);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseCustom);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseVarious);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseTag);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseFolder);
            this.groupBoxArtist.Location = new System.Drawing.Point(272, 343);
            this.groupBoxArtist.Name = "groupBoxArtist";
            this.groupBoxArtist.Size = new System.Drawing.Size(128, 203);
            this.groupBoxArtist.TabIndex = 4;
            this.groupBoxArtist.TabStop = false;
            this.groupBoxArtist.Text = "Artist Controls";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(17, 137);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(95, 20);
            this.textBoxArtist.TabIndex = 8;
            this.textBoxArtist.Click += new System.EventHandler(this.textBoxArtist_Click);
            this.textBoxArtist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxArtist_KeyPress);
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
            this.radioArtistUseCustom.Click += new System.EventHandler(this.radioArtistUseCustom_Click);
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
            this.radioArtistUseVarious.Click += new System.EventHandler(this.radioArtistUseVarious_Click);
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
            this.radioArtistUseTag.Click += new System.EventHandler(this.radioArtistUseTag_Click);
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
            this.radioArtistUseFolder.Click += new System.EventHandler(this.radioArtistUseFolder_Click);
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxTitle.Controls.Add(this.labelManualTitle);
            this.groupBoxTitle.Controls.Add(this.textBoxManualTitle);
            this.groupBoxTitle.Controls.Add(this.radioTitleExtrapolate);
            this.groupBoxTitle.Controls.Add(this.radioTitleUseTag);
            this.groupBoxTitle.Location = new System.Drawing.Point(5, 343);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(128, 203);
            this.groupBoxTitle.TabIndex = 3;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Title Controls";
            // 
            // labelManualTitle
            // 
            this.labelManualTitle.AutoSize = true;
            this.labelManualTitle.Location = new System.Drawing.Point(15, 122);
            this.labelManualTitle.Name = "labelManualTitle";
            this.labelManualTitle.Size = new System.Drawing.Size(99, 13);
            this.labelManualTitle.TabIndex = 5;
            this.labelManualTitle.Text = "Single Title Change";
            // 
            // textBoxManualTitle
            // 
            this.textBoxManualTitle.Location = new System.Drawing.Point(15, 138);
            this.textBoxManualTitle.Name = "textBoxManualTitle";
            this.textBoxManualTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxManualTitle.TabIndex = 0;
            this.textBoxManualTitle.TextChanged += new System.EventHandler(this.textBoxManualTitle_TextChanged);
            this.textBoxManualTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxManualTitle_KeyPress);
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
            this.button1.Location = new System.Drawing.Point(728, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(738, 420);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 123);
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
            this.listView1.Size = new System.Drawing.Size(895, 332);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
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
            // textBoxTrack
            // 
            this.textBoxTrack.Location = new System.Drawing.Point(39, 106);
            this.textBoxTrack.Name = "textBoxTrack";
            this.textBoxTrack.Size = new System.Drawing.Size(51, 20);
            this.textBoxTrack.TabIndex = 4;
            this.textBoxTrack.Click += new System.EventHandler(this.textBoxTrack_Click);
            this.textBoxTrack.TextChanged += new System.EventHandler(this.textBoxTrack_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Single track change";
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
        private System.Windows.Forms.Button titleUpdateButton;
        private System.Windows.Forms.GroupBox groupBoxArtist;
        private System.Windows.Forms.RadioButton radioArtistUseTag;
        private System.Windows.Forms.RadioButton radioArtistUseFolder;
        private System.Windows.Forms.RadioButton radioArtistUseVarious;
        private System.Windows.Forms.GroupBox groupBoxAlbum;
        private System.Windows.Forms.RadioButton radioAlbumUseTag;
        private System.Windows.Forms.RadioButton radioAlbumUseFolder;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.TextBox textBoxDelimiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioUseTagTrack;
        private System.Windows.Forms.RadioButton radioExtrapolateTrack;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.RadioButton radioAlbumUseCustom;
        private System.Windows.Forms.RadioButton radioArtistUseCustom;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.TextBox textBoxManualTitle;
        private System.Windows.Forms.Label labelManualTitle;
        private System.Windows.Forms.Button buttonWriteChanges;
        private System.Windows.Forms.TextBox textBoxTrack;
        private System.Windows.Forms.Label label2;
    }
}

