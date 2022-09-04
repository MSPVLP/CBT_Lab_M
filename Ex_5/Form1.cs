using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Windows.Forms;

namespace Ex_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update Directory List box with changed drive letter
            dirListBox1.Path = driveListBox1.Drive;
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update File List Box with changed folder selection
            fileListBox1.Path = dirListBox1.get_DirList(dirListBox1.DirListIndex);
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update text boxes with folder and file name
            txt_foldername.Text = fileListBox1.Path;
            txt_filename.Text = fileListBox1.FileName;
            
            // Load the file in picture box
            pictureBox1.ImageLocation = fileListBox1.Path + "\\" + fileListBox1.FileName;
        }

        private void btn_select_folder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)                  // Check if user clicked cancel or OK
                txt_foldername.Text = fileListBox1.Path;    // Update Folder Name Textbox 
        }

        private void btn_select_file_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_filename.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

    }
}
