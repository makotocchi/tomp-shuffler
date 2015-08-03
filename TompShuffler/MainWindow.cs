using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TompShuffler
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btShuffle_Click(object sender, EventArgs e)
        {
            FileShuffler.shuffle(txtTr3Folder.Text);
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            txtTr3Folder.Text = folderBrowser.SelectedPath;
        }
    }
}
