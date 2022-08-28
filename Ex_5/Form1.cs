using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_foldername.Text = fileListBox1.Path;
            txt_foldername.Text = dirListBox1.Path;
            txt_filename.Text = (fileListBox1.FileName);

            pictureBox1.ImageLocation = dirListBox1.Path + "\\" + fileListBox1.FileName;
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox1.Path = driveListBox1.Drive;
        }
        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
        }

        private void btn_select_folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txt_foldername.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btn_select_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txt_filename.Text = openFileDialog1.FileName;
        }
    }
}
