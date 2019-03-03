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
            DirectoryInfo nodeDirInfo = (DirectoryInfo) newSelected.Tag;

            foreach (FileInfo file in nodeDirInfo.GetFiles()) {
                if (file.Extension == ".mp3") {
                    musicList.Add(new MusicFile(file.DirectoryName + file.ToString())); // Adding to the List in case I need to use it in future
                    textBox1.AppendText(file.DirectoryName + "\\" + file + "\r\n");
                }        

            }

            foreach (MusicFile file in musicList) {
                
                
            }

            PopulateListView();
        }

        public void PopulateListView() {
            foreach (MusicFile file in musicList) {
                ListViewItem newItem = new ListViewItem(file.FilePath());
                listView1.Items.Add(newItem);
            }
        }
    }
}
