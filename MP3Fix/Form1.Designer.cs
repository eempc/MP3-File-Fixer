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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.radioTitleUseTag = new System.Windows.Forms.RadioButton();
            this.radioTitleExtrapolate = new System.Windows.Forms.RadioButton();
            this.titleUpdateButton = new System.Windows.Forms.Button();
            this.checkBoxTitleCapitals = new System.Windows.Forms.CheckBox();
            this.groupBoxArtist = new System.Windows.Forms.GroupBox();
            this.radioArtistUseFolder = new System.Windows.Forms.RadioButton();
            this.radioArtistUseTag = new System.Windows.Forms.RadioButton();
            this.radioArtistUseVarious = new System.Windows.Forms.RadioButton();
            this.groupBoxAlbum = new System.Windows.Forms.GroupBox();
            this.radioAlbumUseTag = new System.Windows.Forms.RadioButton();
            this.checkBoxArtistCapitals = new System.Windows.Forms.CheckBox();
            this.checkBoxAlbumCapitals = new System.Windows.Forms.CheckBox();
            this.radioAlbumUseFolder = new System.Windows.Forms.RadioButton();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delimiterTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxTitle.SuspendLayout();
            this.groupBoxArtist.SuspendLayout();
            this.groupBoxAlbum.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1159, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOutput);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxAlbum);
            this.splitContainer1.Panel2.Controls.Add(this.titleUpdateButton);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxArtist);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxTitle);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1159, 531);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(5, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(270, 521);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
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
            this.listView1.Size = new System.Drawing.Size(865, 208);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
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
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(781, 335);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 133);
            this.textBox1.TabIndex = 1;
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
            // groupBoxTitle
            // 
            this.groupBoxTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // 
            // titleUpdateButton
            // 
            this.titleUpdateButton.Location = new System.Drawing.Point(102, 495);
            this.titleUpdateButton.Name = "titleUpdateButton";
            this.titleUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.titleUpdateButton.TabIndex = 2;
            this.titleUpdateButton.Text = "Update";
            this.titleUpdateButton.UseVisualStyleBackColor = true;
            this.titleUpdateButton.Click += new System.EventHandler(this.titleUpdateButton_Click);
            // 
            // checkBoxTitleCapitals
            // 
            this.checkBoxTitleCapitals.AutoSize = true;
            this.checkBoxTitleCapitals.Location = new System.Drawing.Point(18, 67);
            this.checkBoxTitleCapitals.Name = "checkBoxTitleCapitals";
            this.checkBoxTitleCapitals.Size = new System.Drawing.Size(79, 17);
            this.checkBoxTitleCapitals.TabIndex = 3;
            this.checkBoxTitleCapitals.Text = "Fix Capitals";
            this.checkBoxTitleCapitals.UseVisualStyleBackColor = true;
            // 
            // groupBoxArtist
            // 
            this.groupBoxArtist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxArtist.Controls.Add(this.checkBoxArtistCapitals);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseVarious);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseTag);
            this.groupBoxArtist.Controls.Add(this.radioArtistUseFolder);
            this.groupBoxArtist.Location = new System.Drawing.Point(8, 364);
            this.groupBoxArtist.Name = "groupBoxArtist";
            this.groupBoxArtist.Size = new System.Drawing.Size(128, 125);
            this.groupBoxArtist.TabIndex = 4;
            this.groupBoxArtist.TabStop = false;
            this.groupBoxArtist.Text = "Artist Controls";
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
            // groupBoxAlbum
            // 
            this.groupBoxAlbum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxAlbum.Controls.Add(this.radioAlbumUseFolder);
            this.groupBoxAlbum.Controls.Add(this.checkBoxAlbumCapitals);
            this.groupBoxAlbum.Controls.Add(this.radioAlbumUseTag);
            this.groupBoxAlbum.Location = new System.Drawing.Point(143, 220);
            this.groupBoxAlbum.Name = "groupBoxAlbum";
            this.groupBoxAlbum.Size = new System.Drawing.Size(127, 138);
            this.groupBoxAlbum.TabIndex = 5;
            this.groupBoxAlbum.TabStop = false;
            this.groupBoxAlbum.Text = "Album Controls";
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
            // checkBoxArtistCapitals
            // 
            this.checkBoxArtistCapitals.AutoSize = true;
            this.checkBoxArtistCapitals.Location = new System.Drawing.Point(17, 90);
            this.checkBoxArtistCapitals.Name = "checkBoxArtistCapitals";
            this.checkBoxArtistCapitals.Size = new System.Drawing.Size(78, 17);
            this.checkBoxArtistCapitals.TabIndex = 4;
            this.checkBoxArtistCapitals.Text = "Fix capitals";
            this.checkBoxArtistCapitals.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlbumCapitals
            // 
            this.checkBoxAlbumCapitals.AutoSize = true;
            this.checkBoxAlbumCapitals.Location = new System.Drawing.Point(17, 66);
            this.checkBoxAlbumCapitals.Name = "checkBoxAlbumCapitals";
            this.checkBoxAlbumCapitals.Size = new System.Drawing.Size(78, 17);
            this.checkBoxAlbumCapitals.TabIndex = 1;
            this.checkBoxAlbumCapitals.Text = "Fix capitals";
            this.checkBoxAlbumCapitals.UseVisualStyleBackColor = true;
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
            // groupBoxOutput
            // 
            this.groupBoxOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxOutput.Controls.Add(this.delimiterTextBox);
            this.groupBoxOutput.Controls.Add(this.label1);
            this.groupBoxOutput.Location = new System.Drawing.Point(143, 365);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(127, 124);
            this.groupBoxOutput.TabIndex = 6;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "File Name Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delimiter";
            // 
            // delimiterTextBox
            // 
            this.delimiterTextBox.Location = new System.Drawing.Point(61, 20);
            this.delimiterTextBox.Name = "delimiterTextBox";
            this.delimiterTextBox.Size = new System.Drawing.Size(51, 20);
            this.delimiterTextBox.TabIndex = 1;
            this.delimiterTextBox.Text = " - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 577);
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
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            this.groupBoxArtist.ResumeLayout(false);
            this.groupBoxArtist.PerformLayout();
            this.groupBoxAlbum.ResumeLayout(false);
            this.groupBoxAlbum.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox delimiterTextBox;
        private System.Windows.Forms.Label label1;
    }
}

