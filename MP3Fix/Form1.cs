using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MP3Fix {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            PopulateTreeView(@"D:\Music");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void button1_Click(object sender, EventArgs e) {
            PopUpForm();
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
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            musicList.Clear();
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
                ListViewItem newItem = new ListViewItem(file.FilePath(), 1);
                newItem.SubItems.Add(file.Album());
                newItem.SubItems.Add(file.Artist());
                newItem.SubItems.Add(file.Track().ToString("00"));
                newItem.SubItems.Add(file.Title());
                newItem.SubItems.Add(file.OutputFileName(" - ", ".mp3"));
                listView1.Items.Add(newItem);
            }            
        }

        private void titleUpdateButton_Click(object sender, EventArgs e) {
            UpdateAlbumColumn();
            UpdateArtistColumn();
            UpdateTrackColumn();
            UpdateTitleColumn();
        }

        public void UpdateArtistColumn() {

        }

        public void UpdateAlbumColumn() {

        }

        public void UpdateTitleColumn() {

        }

        public void UpdateTrackColumn() {

        }

        public void UpdateOutputColumn() {

        }

        private void radioTitleUseTag_Click(object sender, EventArgs e) {
            // As long as the listview remains in order this can be used
            for (int i = 0; i < musicList.Count; i++) {
                listView1.Items[i].SubItems[4].Text = musicList[i].Title(); 
            }
        }

        private void radioTitleExtrapolate_Click(object sender, EventArgs e) {

        }
    }
}
