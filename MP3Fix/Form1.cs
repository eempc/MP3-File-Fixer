using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MP3Fix {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            PopulateTreeView(@"D:\Music");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void button1_Click(object sender, EventArgs e) {
            //PopUpForm();
            int index = listView1.SelectedIndices[0];
            textBox1.Text = index.ToString();
        }

        public void PopUpForm() {
            var form = new FormPopUp();
            form.Show(this);
        }

        public void PopulateTreeView(string folderPath) {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(folderPath);
            if (info.Exists) {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        public void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo) {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs) {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                //aNode.ImageIndex = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0) GetDirectories(subSubDirs, aNode);
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        // This List is in case I need to use it in future
        List<MusicFile> musicList = new List<MusicFile>();

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            ClearEverything();

            TreeNode newSelected = e.Node;
            DirectoryInfo nodeDirInfo = (DirectoryInfo) newSelected.Tag;

            foreach (FileInfo file in nodeDirInfo.GetFiles()) {
                if (file.Extension == ".mp3") {
                    musicList.Add(new MusicFile(file.DirectoryName + "\\" + file.ToString())); // Adding to the List in case I need to use it in future
                    //textBox1.AppendText(file.DirectoryName + "\\" + file + "\r\n");
                }        
            }
            //listView1.AutoResizeColumn(ColumnHeaderAutoResizeStyle.HeaderSize);
            PopulateListView();         
        }

        public void PopulateListView() {
            // Do a check for path length to ensure the folder is in the right format
            
            foreach (MusicFile file in musicList) {
                ListViewItem newItem = new ListViewItem(file.filePath, 1);
                newItem.SubItems.Add(file.album);
                newItem.SubItems.Add(file.artist);
                newItem.SubItems.Add(file.trackNo.ToString("00"));
                newItem.SubItems.Add(file.title);
                newItem.SubItems.Add(file.OutputFileName(" - ", ".mp3"));
                listView1.Items.Add(newItem);
            }            
        }

        public void ClearEverything() {
            listView1.Items.Clear();
            musicList.Clear();

            textBoxAlbum.Text = "";
            textBoxArtist.Text = "";
            textBoxManualTitle.Text = "";

            Control[] groupBoxes = new Control[] { groupBoxAlbum, groupBoxArtist, groupBoxOther, groupBoxTitle };

            foreach (Control groupBox in groupBoxes) {
                foreach (Control control in groupBox.Controls) {
                    if (control is RadioButton) {
                        RadioButton radio = (RadioButton) control;
                        radio.Checked = false;
                    }
                }
            }
        }

        private void titleUpdateButton_Click(object sender, EventArgs e) {
            UpdateOutputColumn();
        }

        public void UpdateOutputColumn() {
            foreach (ListViewItem item in listView1.Items)
                item.SubItems[5].Text = Path.GetDirectoryName(item.SubItems[0].Text) + "\\" + item.SubItems[2].Text + textBoxDelimiter.Text + item.SubItems[3].Text + textBoxDelimiter.Text + item.SubItems[4].Text + ".mp3";
        }

        public string RemoveDigits(string str) {
            return Regex.Replace(str, @"\d", "");
        }

        private void buttonWriteChanges_Click(object sender, EventArgs e) {
            for (int i = 0; i < musicList.Count; i++) {
                string newArtist = listView1.Items[i].SubItems[2].Text;
                string newAlbum = listView1.Items[i].SubItems[1].Text;
                string newTrack = listView1.Items[i].SubItems[3].Text;
                string newTitle = listView1.Items[i].SubItems[4].Text;
                string newFilePath = listView1.Items[i].SubItems[5].Text;
                musicList[i].WriteChanges(newArtist, newTrack, newTitle, newFilePath, newAlbum);
            }
        }

        public void ChangeColumn(int column, string str) {
            foreach (ListViewItem item in listView1.Items) {
                item.SubItems[column].Text = str;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e) {
            textBoxManualTitle.Text = listView1.SelectedItems[0].SubItems[4].Text;
            if (!string.IsNullOrEmpty(listView1.SelectedItems[0].SubItems[3].Text)) {
                textBoxTrack.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
            //textBox1.Text = sender.ToString();
        }

        // Title

        private void radioTitleUseTag_Click(object sender, EventArgs e) {
            // As long as the listview remains in order this can be used
            for (int i = 0; i < musicList.Count; i++) {
                listView1.Items[i].SubItems[4].Text = musicList[i].title; 
            }
            UpdateOutputColumn();
        }

        private void radioTitleExtrapolate_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in listView1.Items) {
                string fullPath = item.SubItems[0].Text;
                string artist = fullPath.Split('\\')[2];
                string fileName = Path.GetFileNameWithoutExtension(fullPath);
                string result = RemoveDigits(fileName.Replace(artist, "").Replace("-","").Replace("."," ").Replace("_"," ")).Trim();
                item.SubItems[4].Text = result;
            }
            UpdateOutputColumn();
        }

        private void textBoxManualTitle_TextChanged(object sender, EventArgs e) {
            listView1.SelectedItems[0].SubItems[4].Text = textBoxManualTitle.Text;
            UpdateOutputColumn();
        }


        private void textBoxManualTitle_KeyPress(object sender, KeyPressEventArgs e) {
            // Nope I cannot do this bit. I want to change the SelectedItem to the next one
            int index = listView1.SelectedIndices[0];
            if (e.KeyChar == 13) {

            }
        }

        // Album

        private void radioAlbumUseTag_Click(object sender, EventArgs e) {
            for (int i = 0; i < musicList.Count; i++) {
                listView1.Items[i].SubItems[1].Text = musicList[i].album;
            }
            UpdateOutputColumn();
        }

        private void radioAlbumUseFolder_Click(object sender, EventArgs e) {
            string fullPath = listView1.Items[0].SubItems[0].Text;
            string album = fullPath.Split('\\')[3];

            foreach (ListViewItem item in listView1.Items) {
                item.SubItems[1].Text = album;
            }
            UpdateOutputColumn();
        }

        private void radioAlbumUseCustom_Click(object sender, EventArgs e) {
            this.ActiveControl = textBoxAlbum;
            if (!string.IsNullOrEmpty(textBoxAlbum.Text)) {
                ChangeColumn(1, textBoxAlbum.Text);
            }
            UpdateOutputColumn();
        }

        private void textBoxAlbum_Click(object sender, EventArgs e) {
            radioAlbumUseCustom.Checked = true;
        }

        private void textBoxAlbum_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13)
                ChangeColumn(1, textBoxAlbum.Text);
            UpdateOutputColumn();
        }

        // Artist

        private void radioArtistUseTag_Click(object sender, EventArgs e) {
            for (int i = 0; i < musicList.Count; i++) {
                listView1.Items[i].SubItems[2].Text = musicList[i].artist;
            }
            UpdateOutputColumn();
        }

        private void radioArtistUseFolder_Click(object sender, EventArgs e) {
            string fullPath = listView1.Items[0].SubItems[0].Text;
            string album = fullPath.Split('\\')[2];

            foreach (ListViewItem item in listView1.Items) {
                item.SubItems[2].Text = album;
            }
            UpdateOutputColumn();
        }

        private void radioArtistUseVarious_Click(object sender, EventArgs e) {
            ChangeColumn(2, "Various");
        }

        private void radioArtistUseCustom_Click(object sender, EventArgs e) {
            ActiveControl = textBoxArtist;
            if (!string.IsNullOrEmpty(textBoxArtist.Text)) {
                ChangeColumn(2, textBoxArtist.Text);
            }
            UpdateOutputColumn();
        }

        private void textBoxArtist_Click(object sender, EventArgs e) {
            radioArtistUseCustom.Checked = true;
        }

        private void textBoxArtist_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13)             
                ChangeColumn(2, textBoxArtist.Text);
            UpdateOutputColumn();
        }

        // Track

        private void radioUseTagTrack_Click(object sender, EventArgs e) {
            for (int i = 0; i < musicList.Count; i++) {
                listView1.Items[i].SubItems[3].Text = musicList[i].trackNo.ToString("00");
            }
            UpdateOutputColumn();
        }

        private void radioExtrapolateTrack_Click(object sender, EventArgs e) {
            for (int i = 0; i < musicList.Count; i++) {
                string x = "";
                foreach (char c in Path.GetFileNameWithoutExtension(musicList[i].filePath))
                    if (char.IsDigit(c) && x.Length <= 2) x += c;
                listView1.Items[i].SubItems[3].Text = x;              
            }
            UpdateOutputColumn();
        }

        private void textBoxTrack_Click(object sender, EventArgs e) {
            
        }

        private void textBoxTrack_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(textBoxTrack.Text, out int n))
                listView1.SelectedItems[0].SubItems[3].Text = textBoxTrack.Text;
            UpdateOutputColumn();
        }
    }
}
