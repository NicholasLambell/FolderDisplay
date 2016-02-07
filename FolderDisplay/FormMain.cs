using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FolderDisplay {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        #region Misc Methods
        private void ProcessTVArgs(string[] items) {
            if (items != null && items.Length > 0) {
                tvFiles.BeginUpdate();
                foreach (string item in items) {
                    tvFiles.Nodes.Add(GetAsNode(item));
                }
                tvFiles.EndUpdate();
            }
        }

        private TreeNode GetAsNode(string item, bool rootItem = true) {
            TreeNode node = null;

            if (!String.IsNullOrEmpty(item)) {
                node = new TreeNode(rootItem ? item : new DirectoryInfo(item).Name);

                if (Directory.Exists(item)) {
                    string[] subDirs = Directory.GetDirectories(item);
                    string[] dirFiles = Directory.GetFiles(item);

                    if (subDirs.Length > 0 || dirFiles.Length > 0) {
                        foreach (string dir in subDirs) {
                            node.Nodes.Add(GetAsNode(dir, false));
                        }

                        foreach (string dirFile in dirFiles) {
                            node.Nodes.Add(new FileInfo(dirFile).Name);
                        }
                    } else {
                        node.Nodes.Add("Empty").NodeFont = new Font(this.Font, FontStyle.Italic);
                    }
                }
            }
            return node;
        }

        #endregion Misc Methods

        #region GUI Event Handlers
        #region Buttons
        private void btnShowArgs_Click(object sender, EventArgs e) {
            //Get start arguments
            string[] args = Environment.GetCommandLineArgs();

            //Join args array entries with double new line character
            string message = String.Join("\n\n", args);

            //Display message box
            MessageBox.Show(message, "Start Arguments");
        }

        private void btnClearTV_Click(object sender, EventArgs e) {
            tvFiles.BeginUpdate();
            tvFiles.Nodes.Clear();
            tvFiles.EndUpdate();
        }

        #endregion Buttons

        #region Tree View
        private void tvFiles_DragDrop(object sender, DragEventArgs e) {
            //Get the list of arguments from the items dropped on the tree view
            string[] dropArgs = (string[])e.Data.GetData(DataFormats.FileDrop);

            //Process the arguments
            ProcessTVArgs(dropArgs);
        }

        private void tvFiles_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        #endregion Tree View

        #endregion GUI Event Handlers
    }
}