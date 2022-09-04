using System;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ex_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //CONNECTION OBJECT
        SqlConnection con = new SqlConnection();
        // COMMAND OBJECT
        SqlCommand cmd = new SqlCommand();
        string sql;
        private void rdb_Edit_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Rno.Visible = true;
            txt_rno.Visible = false;
            btn_save.Text = "Update";
            clear();
            LoadData();
        }
        private void rdb_add_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Rno.Visible = false;
            txt_rno.Visible = true;
            btn_save.Text = "Save";
            clear(); 
        } 
        private void rdb_delete_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Rno.Visible = true;
            txt_rno.Visible = false;
            btn_save.Text = "Delete";
            clear();
            LoadData();
        }
        private void rdb_select_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Rno.Visible = false;
            txt_rno.Visible = true;
            rdb_add.Checked = false;
            btn_save.Text = "Add";
            BindData();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            int x;
            connect();
            switch (btn_save.Text)
            {
                case "Save":
                    sql = "insert into student_master(student_rno,student_name,dept_name,address,mobile_no)values(@rno,@stuname,@dept,@address,@mobileno)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@rno", SqlDbType.Int).Value = txt_rno.Text;
                    cmd.Parameters.Add("@stuname", SqlDbType.VarChar).Value = txt_stuname.Text;
                    cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = cmb_deptname.SelectedItem.ToString();
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txt_address.Text;
                    cmd.Parameters.Add("@mobileno", SqlDbType.VarChar).Value = txt_mobile.Text;
                      x = cmd.ExecuteNonQuery();
                    if (x == 1)
                        MessageBox.Show("Students Data Inserted");
                    else
                        MessageBox.Show("Students Data Not Inserted");
                    con.Close();
                    clear();
                    break;
                case "Update":
                    sql = "update student_master set student_name=@stuname,dept_name=@dept,address=@address,mobile_no=@mobileno where student_rno=@rno";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@rno", SqlDbType.VarChar).Value = cmb_Rno.SelectedItem.ToString();
                    cmd.Parameters.Add("@stuname", SqlDbType.VarChar).Value = txt_stuname.Text;
                    cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = cmb_deptname.SelectedItem.ToString();
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txt_address.Text;
                    cmd.Parameters.Add("@mobileno", SqlDbType.VarChar).Value = txt_mobile.Text;
                    x = cmd.ExecuteNonQuery();
                    if (x == 1)
                        MessageBox.Show("Students Data Update");
                    else
                        MessageBox.Show("Students Data Not Updated");
                    con.Close();
                    clear();
                    break;
                case "Delete":
                    sql = "delete from student_master where student_rno=@rno";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@rno", SqlDbType.VarChar).Value = cmb_Rno.SelectedItem.ToString();
                    
                    x = cmd.ExecuteNonQuery();
                    if (x == 1)
                        MessageBox.Show("Selected Student Data Deleted");
                    else
                        MessageBox.Show("Selected Student Data Not Deleted");
                    con.Close();
                    clear();
                    LoadData();
                    break;

            }
            BindData();
        }
        public void connect()
        {
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\CBT_LabCode\\CBT_Lab_N\\Ex_9\\student_details_db.mdf;Integrated Security=True";
            con.Open();
        }
        public void clear()
        {
            txt_rno.Clear();
            txt_stuname.Clear();
            txt_address.Clear();
            txt_mobile.Clear();
            cmb_Rno.Text = "";
            cmb_deptname.Text = "";
        }
        public void BindData()
        {
            // Call connect function 
            connect(); 
            cmd.Connection = con;
            cmd.CommandText = "select * from student_master ";
            DataSet ds = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter();
            ada.SelectCommand = cmd;
            ada.Fill(ds, "student_master");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "student_master";
            con.Close();
        }
        public void LoadData()
        {
            connect();
            cmd.Connection = con;
            cmd.CommandText = "select * from student_master ";
            cmb_Rno.Items.Clear();
            //EXECUTION OF ADO
            SqlDataReader dr = null;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_Rno.Items.Add((dr.GetInt32(0)));
            }
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void cmb_Rno_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect();
            cmd.Connection = con;
            cmd.CommandText = "select * from student_master where student_rno = '" + cmb_Rno.SelectedItem.ToString() + "'";
            SqlDataReader dr = null;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_stuname.Text = dr.GetString(1);
                cmb_deptname.Text = dr.GetString(2);
                txt_address.Text = dr.GetString(3);
                txt_mobile.Text = dr.GetString(4);
            }
            con.Close();
        }
    }
}
