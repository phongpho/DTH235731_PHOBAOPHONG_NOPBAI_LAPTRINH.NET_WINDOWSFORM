using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_Bai_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string rootPath = folderBrowserDialog1.SelectedPath;
                LoadDirectory(rootPath);
            }
        }
        private void LoadDirectory(string path)
        {
            DirectoryInfo rootDir = new DirectoryInfo(path);
            TreeNode rootNode = new TreeNode(rootDir.Name)
            {
                Tag = rootDir.FullName
            };
            treeViewFolder.Nodes.Add(rootNode);
            LoadSubDirectories(rootDir, rootNode);
        }

        private void LoadSubDirectories(DirectoryInfo dir, TreeNode node)
        {
            try
            {
                foreach (var subDir in dir.GetDirectories())
                {
                    TreeNode subNode = new TreeNode(subDir.Name)
                    {
                        Tag = subDir.FullName
                    };
                    node.Nodes.Add(subNode);
                    LoadSubDirectories(subDir, subNode);
                }
            }
            catch { /* Bỏ qua lỗi quyền truy cập */ }
        }

        private void treeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedPath = e.Node.Tag.ToString();
            ShowImages(selectedPath);
        }

        private void ShowImages(string folderPath)
        {
            flowLayoutPanelImages.Controls.Clear();

            string[] imageFiles = Directory.GetFiles(folderPath, "*.*")
                .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                         || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                         || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                         || f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            foreach (string file in imageFiles)
            {
                PictureBox pb = new PictureBox
                {
                    Image = Image.FromFile(file),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 100,
                    Height = 100,
                    Margin = new Padding(5),
                    Tag = file,
                    Cursor = Cursors.Hand
                };
                pb.Click += Pb_Click;
                flowLayoutPanelImages.Controls.Add(pb);
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null && pb.Tag != null)
            {
                string filePath = pb.Tag.ToString();
                pictureBoxPreview.Image = Image.FromFile(filePath);
            }
        }
    }
}
