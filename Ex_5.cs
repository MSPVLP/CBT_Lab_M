using System;

using System.Windows.Forms;

namespace PartA
{
    public partial class Ex_5 : Form
    {
        public Ex_5()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox1.Path = driveListBox1.Drive;
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_foldername.Text = fileListBox1.Path;
            txt_foldername.Text = dirListBox1.Path;
            txt_filename.Text = (fileListBox1.FileName);
        }
    }
}
