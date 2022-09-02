using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdb_Edit_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Rno.Visible = true;
            txt_rno.Visible = false;
            btn_save.Text = "Update";
        }

        private void rdb_add_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Rno.Visible = false;
            txt_rno.Visible = true;
            btn_save.Text = "Save";
            
        } 
        private void rdb_delete_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Rno.Visible = true;
            txt_rno.Visible = false;
            btn_save.Text = "Delete";
        }

        private void rdb_select_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Rno.Visible = false;
            txt_rno.Visible = true;
            rdb_add.Checked = true;
            btn_save.Text = "Add";
        }
    }
}
