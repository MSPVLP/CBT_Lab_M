using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ex_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        //CONNECTION OBJECT
        SqlConnection db_con = new SqlConnection();
        
        SqlCommand cmd = new SqlCommand();
        

        SqlDataAdapter ado_adapter = new SqlDataAdapter();
        DataSet grid_ds = new DataSet();
        SqlCommand grid_select_cmd = new SqlCommand();
        string grid_select_sql = "SELECT [id], [roll_no], [stud_name], [dept_name], [address], [mobile_no] FROM students;";

        SqlCommand add_cmd = new SqlCommand();
        string add_sql = "INSERT INTO students (roll_no,stud_name,dept_name,address,mobile_no) VALUES (@rno,@name,@dept,@addr,@mob)";
        SqlParameter par_add_rno = new SqlParameter("@rno", SqlDbType.Int);
        SqlParameter par_add_name = new SqlParameter("@name", SqlDbType.VarChar, 50);
        SqlParameter par_add_dept = new SqlParameter("@dept", SqlDbType.VarChar, 50);
        SqlParameter par_add_addr = new SqlParameter("@addr", SqlDbType.VarChar, 150);
        SqlParameter par_add_mob = new SqlParameter("@mob", SqlDbType.VarChar, 10);

        SqlCommand load_student_cmd = new SqlCommand();
        string load_student_sql = "SELECT * FROM students WHERE id=@id";
        SqlParameter par_load_id = new SqlParameter("@id", SqlDbType.Int);

        SqlCommand insert_cmd = new SqlCommand();
        string insert_sql = "UPDATE students SET roll_no=@rno, stud_name=@stud_name,dept_name=@dept,address=@addr,mobile_no=@mob WHERE id=@id";
        SqlParameter par_edit_id = new SqlParameter("@id", SqlDbType.Int);
        SqlParameter par_edit_rno = new SqlParameter("@rno", SqlDbType.Int);
        SqlParameter par_edit_name = new SqlParameter("@stud_name", SqlDbType.VarChar, 50);
        SqlParameter par_edit_dept = new SqlParameter("@dept", SqlDbType.VarChar, 50);
        SqlParameter par_edit_addr = new SqlParameter("@addr", SqlDbType.VarChar, 150);
        SqlParameter par_edit_mob = new SqlParameter("@mob", SqlDbType.VarChar, 10);

        SqlCommand delete_cmd = new SqlCommand();
        string del_sql = "DELETE FROM students WHERE id=@id;";
        SqlParameter par_del_id = new SqlParameter("@id", SqlDbType.Int);

        public void init_db()
        {
            openFileDialog1.ShowDialog();
            db_con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + openFileDialog1.FileName + @";Integrated Security=True;Integrated Security=True";
            db_con.Open();

            grid_select_cmd.Connection = db_con;
            grid_select_cmd.CommandText = grid_select_sql;
            ado_adapter.SelectCommand = grid_select_cmd;
            ado_adapter.Fill(grid_ds, "students");
           
            dataGridView1.DataSource = grid_ds;
            dataGridView1.DataMember = "students";

            add_cmd.Connection = db_con;
            add_cmd.CommandText = add_sql;
            add_cmd.Parameters.Add(par_add_rno);
            add_cmd.Parameters.Add(par_add_name);
            add_cmd.Parameters.Add(par_add_dept);
            add_cmd.Parameters.Add(par_add_addr);
            add_cmd.Parameters.Add(par_add_mob);

            load_student_cmd.Connection = db_con;
            load_student_cmd.CommandText = load_student_sql;
            load_student_cmd.Parameters.Add(par_load_id);

            insert_cmd.Connection = db_con;
            insert_cmd.CommandText = insert_sql;
            insert_cmd.Parameters.Add(par_edit_id);
            insert_cmd.Parameters.Add(par_edit_rno);
            insert_cmd.Parameters.Add(par_edit_name);
            insert_cmd.Parameters.Add(par_edit_dept);
            insert_cmd.Parameters.Add(par_edit_addr);
            insert_cmd.Parameters.Add(par_edit_mob);

            delete_cmd.Connection = db_con;
            delete_cmd.CommandText = del_sql;
            //ado_adapter.DeleteCommand = delete_cmd;
            delete_cmd.Parameters.Add(par_del_id);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init_db();
        }

        public void clear()
        {
            txt_id.Clear();
            txt_rno.Clear();
            txt_name.Clear();
            txt_address.Clear();
            txt_mobile.Clear();
            cmb_deptname.Text = "";
            lbl_Operation.Text = "";
        }

        public void RefreshGridData()
        {
            grid_ds.Clear();
            ado_adapter.Fill(grid_ds, "students");
        }

        private int get_grid_selected_id()
        {
            // Check if a row is selected in the grid. 
            if (dataGridView1.CurrentRow != null)
            {   // Load ID from row selected in dataGridView1
                return (int)dataGridView1.CurrentRow.Cells[0].Value;

            }
            else
                return 0;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            RefreshGridData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clear();
            lbl_Operation.Text = "Add";
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int id_to_edit = get_grid_selected_id();

            if (dataGridView1.CurrentRow != null)
            {   

                MessageBox.Show("Editing student ID " + id_to_edit.ToString());
                lbl_Operation.Text = "Edit";
                int id = (int) dataGridView1.CurrentRow.Cells[0].Value;
                int rno = (int) dataGridView1.CurrentRow.Cells[1].Value;
                string stud_name = (string)dataGridView1.CurrentRow.Cells[2].Value;
                string dept = (string)dataGridView1.CurrentRow.Cells[3].Value;
                string addr = (string)dataGridView1.CurrentRow.Cells[4].Value;
                string mob = (string)dataGridView1.CurrentRow.Cells[5].Value;
                
                txt_id.Text = id.ToString();
                txt_rno.Text = rno.ToString();  
                txt_name.Text = stud_name;
                cmb_deptname.Text = dept;
                txt_address.Text = addr;
                txt_mobile.Text = mob;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int result = 0;
            switch (lbl_Operation.Text)
            {
                case "Add":
                    if (String.IsNullOrEmpty(txt_rno.Text) | String.IsNullOrEmpty(txt_name.Text)
                        | String.IsNullOrEmpty(txt_address.Text) | String.IsNullOrEmpty(txt_mobile.Text) | cmb_deptname.SelectedItem is null)
                    {
                        MessageBox.Show("Enter all details");
                        return;
                    }
                    else
                    {
                        par_add_rno.Value = txt_rno.Text;
                        par_add_name.Value = txt_name.Text;
                        par_add_dept.Value = cmb_deptname.SelectedItem.ToString();
                        par_add_addr.Value = txt_address.Text;
                        par_add_mob.Value = txt_mobile.Text;
                        result = add_cmd.ExecuteNonQuery();
                    }
                    break;

                case "Edit":
                    par_edit_id.Value = txt_id.Text;
                    par_edit_rno.Value = txt_rno.Text;
                    par_edit_name.Value = txt_name.Text;
                    par_edit_dept.Value = cmb_deptname.SelectedItem.ToString();
                    par_edit_addr.Value = txt_address.Text;
                    par_edit_mob.Value = txt_mobile.Text;
                    result = insert_cmd.ExecuteNonQuery();
                    break;
            }

            if (result == -1)
                MessageBox.Show("Error occured.");
            else
            {
                MessageBox.Show(result.ToString() + " records affected.");
                clear();
                RefreshGridData();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id_to_del = get_grid_selected_id();

            if (id_to_del != 0)
            {   
                // Confirm with user if he wants to delete
                string message = "Are you sure you want to delete student ID " + id_to_del.ToString() + " ?";
                DialogResult choice = MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    par_del_id.Value = id_to_del;
                    int result = delete_cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted " + result.ToString() + " record.");
                    clear();
                }
            }
            else MessageBox.Show("No Records selected.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db_con.Close();
        }

    }
}
