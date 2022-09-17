using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Windows.Forms;

namespace Ex_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        
        // Declare variables required for ADO.NET 
        SqlConnection db_con;
        SqlDataAdapter ado_adapter;
        DataSet grid_ds;

        SqlCommand grid_select_cmd, insertcmd, update_cmd, delete_cmd;

        SqlParameter par_insert_rno, par_insert_name, par_insert_dept, par_insert_addr, par_insert_mob;
        SqlParameter par_update_id, par_update_rno, par_update_name, par_update_dept, par_update_addr, par_update_mob;
        SqlParameter par_del_id;

        // User defined function init_db() : Initialises database connection string db_con and other sql objects
        public void init_db_connection()
        {
            db_con = new SqlConnection();
            db_con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\student_details_db.mdf" + @";Integrated Security=True;Integrated Security=True";

            db_con.Open();

            grid_select_cmd = new SqlCommand();
            grid_select_cmd.Connection = db_con;
            grid_select_cmd.CommandText = "SELECT [id], [roll_no], [stud_name], [dept_name], [address], [mobile_no] FROM students;";
           
            ado_adapter = new SqlDataAdapter();
            ado_adapter.SelectCommand = grid_select_cmd;
            
            grid_ds = new DataSet();
            ado_adapter.Fill(grid_ds, "students");
            
            dataGridView1.DataSource = grid_ds;
            dataGridView1.DataMember = "students";
            
            insertcmd = new SqlCommand();
            insertcmd.Connection = db_con;
            insertcmd.CommandText = "INSERT INTO students (roll_no,stud_name,dept_name,address,mobile_no) VALUES (@rno,@name,@dept,@addr,@mob)";
            par_insert_rno = new SqlParameter("@rno", SqlDbType.Int);
            par_insert_name = new SqlParameter("@name", SqlDbType.VarChar, 50);
            par_insert_dept = new SqlParameter("@dept", SqlDbType.VarChar, 50);
            par_insert_addr = new SqlParameter("@addr", SqlDbType.VarChar, 150);
            par_insert_mob = new SqlParameter("@mob", SqlDbType.VarChar, 10);
            insertcmd.Parameters.Add(par_insert_rno);
            insertcmd.Parameters.Add(par_insert_name);
            insertcmd.Parameters.Add(par_insert_dept);
            insertcmd.Parameters.Add(par_insert_addr);
            insertcmd.Parameters.Add(par_insert_mob);

            update_cmd = new SqlCommand();
            update_cmd.Connection = db_con;
            update_cmd.CommandText = "UPDATE students SET roll_no=@rno, stud_name=@stud_name,dept_name=@dept,address=@addr,mobile_no=@mob WHERE id=@id";
            par_update_id = new SqlParameter("@id", SqlDbType.Int);
            par_update_rno = new SqlParameter("@rno", SqlDbType.Int);
            par_update_name = new SqlParameter("@stud_name", SqlDbType.VarChar, 50);
            par_update_dept = new SqlParameter("@dept", SqlDbType.VarChar, 50);
            par_update_addr = new SqlParameter("@addr", SqlDbType.VarChar, 150);
            par_update_mob = new SqlParameter("@mob", SqlDbType.VarChar, 10);
            update_cmd.Parameters.Add(par_update_id);
            update_cmd.Parameters.Add(par_update_rno);
            update_cmd.Parameters.Add(par_update_name);
            update_cmd.Parameters.Add(par_update_dept);
            update_cmd.Parameters.Add(par_update_addr);
            update_cmd.Parameters.Add(par_update_mob);

            delete_cmd = new SqlCommand();
            delete_cmd.Connection = db_con;
            delete_cmd.CommandText = "DELETE FROM students WHERE id=@id;";
            par_del_id = new SqlParameter("@id", SqlDbType.Int);
            delete_cmd.Parameters.Add(par_del_id);
        }

        // User defined function RefreshGridData(): Clears datagridview1's DataSet and fills with new data using ADO SqlDataAdapter
        public void RefreshGridData()
        {
            grid_ds.Clear();
            ado_adapter.Fill(grid_ds, "students");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init_db_connection();
            groupBox_Inputs.Visible = false;
            RefreshGridData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_rno.Clear();
            txt_name.Clear();
            txt_address.Clear();
            txt_mobile.Clear();
            cmb_deptname.SelectedItem = null;
            lbl_Operation.Text = "";
            lbl_Operation.Text = "Add";
            groupBox_Inputs.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {   
                lbl_Operation.Text = "Edit";
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                int rno = (int)dataGridView1.CurrentRow.Cells[1].Value;
                txt_id.Text = id.ToString();
                txt_rno.Text = rno.ToString();  
                txt_name.Text = (string)dataGridView1.CurrentRow.Cells[2].Value; 
                cmb_deptname.Text = (string)dataGridView1.CurrentRow.Cells[3].Value; 
                txt_address.Text = (string)dataGridView1.CurrentRow.Cells[4].Value;
                txt_mobile.Text = (string)dataGridView1.CurrentRow.Cells[5].Value;

                groupBox_Inputs.Visible = true;
            }
            else MessageBox.Show("No Records selected.");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_rno.Text) | String.IsNullOrEmpty(txt_name.Text)
                        | String.IsNullOrEmpty(txt_address.Text) | String.IsNullOrEmpty(txt_mobile.Text) | cmb_deptname.SelectedItem is null)
            {
                MessageBox.Show("Enter all details.");
                return;
            }
            else if (!txt_rno.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter only numbers for Roll No.");
                return;
            }

            int result = 0;

            switch (lbl_Operation.Text)
            {
                case "Add":
                    {
                        par_insert_rno.Value = txt_rno.Text;
                        par_insert_name.Value = txt_name.Text;
                        par_insert_dept.Value = cmb_deptname.SelectedItem.ToString();
                        par_insert_addr.Value = txt_address.Text;
                        par_insert_mob.Value = txt_mobile.Text;
                        result = insertcmd.ExecuteNonQuery();
                    }
                    break;

                case "Edit":
                    par_update_id.Value = txt_id.Text;
                    par_update_rno.Value = txt_rno.Text;
                    par_update_name.Value = txt_name.Text;
                    par_update_dept.Value = cmb_deptname.SelectedItem.ToString();
                    par_update_addr.Value = txt_address.Text;
                    par_update_mob.Value = txt_mobile.Text;
                    result = update_cmd.ExecuteNonQuery();
                    break;
            }

            if (result == -1)
                MessageBox.Show("Error occured.");
            else
            {
                MessageBox.Show(result.ToString() + " records affected.");
                groupBox_Inputs.Visible = false;
                RefreshGridData();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id_to_del = 0;

            if (dataGridView1.CurrentRow != null)               // Check if a row is selected in the grid. 
                id_to_del = (int)dataGridView1.CurrentRow.Cells[0].Value; // Load ID from selected row
            else
            {
                MessageBox.Show("No Records selected.");
                return;
            }
            // Confirm with user if he wants to delete
            string message = "Are you sure you want to delete student ID " + id_to_del.ToString() + " ?";
            DialogResult choice = MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                par_del_id.Value = id_to_del;
                int result = delete_cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted " + result.ToString() + " record.");
                groupBox_Inputs.Visible = false;
                RefreshGridData();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db_con.Close();
        }
    }
}
