namespace Ex_9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_stuname = new System.Windows.Forms.TextBox();
            this.txt_rno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmb_deptname = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_select = new System.Windows.Forms.RadioButton();
            this.rdb_delete = new System.Windows.Forms.RadioButton();
            this.rdb_Edit = new System.Windows.Forms.RadioButton();
            this.rdb_add = new System.Windows.Forms.RadioButton();
            this.cmb_Rno = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mobile
            // 
            this.txt_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile.Location = new System.Drawing.Point(268, 430);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(174, 27);
            this.txt_mobile.TabIndex = 14;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(268, 340);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(267, 68);
            this.txt_address.TabIndex = 12;
            // 
            // txt_stuname
            // 
            this.txt_stuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stuname.Location = new System.Drawing.Point(268, 230);
            this.txt_stuname.Name = "txt_stuname";
            this.txt_stuname.Size = new System.Drawing.Size(267, 27);
            this.txt_stuname.TabIndex = 9;
            // 
            // txt_rno
            // 
            this.txt_rno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rno.Location = new System.Drawing.Point(268, 183);
            this.txt_rno.Name = "txt_rno";
            this.txt_rno.Size = new System.Drawing.Size(174, 27);
            this.txt_rno.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mobile No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student Roll No";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(219, 498);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 32);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_deptname
            // 
            this.cmb_deptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_deptname.FormattingEnabled = true;
            this.cmb_deptname.Items.AddRange(new object[] {
            "Information Technology",
            "Computer Engineering",
            "Electronics and Communication Engineering",
            "Electrical and Electronics Engineering",
            "Mechanical Engineering",
            "Automobile Engineering",
            "Civil Engineering"});
            this.cmb_deptname.Location = new System.Drawing.Point(268, 284);
            this.cmb_deptname.Name = "cmb_deptname";
            this.cmb_deptname.Size = new System.Drawing.Size(267, 28);
            this.cmb_deptname.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_select);
            this.groupBox1.Controls.Add(this.rdb_delete);
            this.groupBox1.Controls.Add(this.rdb_Edit);
            this.groupBox1.Controls.Add(this.rdb_add);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 101);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADO.Net Operations";
            // 
            // rdb_select
            // 
            this.rdb_select.AutoSize = true;
            this.rdb_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_select.Location = new System.Drawing.Point(649, 55);
            this.rdb_select.Name = "rdb_select";
            this.rdb_select.Size = new System.Drawing.Size(203, 29);
            this.rdb_select.TabIndex = 24;
            this.rdb_select.Text = "Load Students Data";
            this.rdb_select.UseVisualStyleBackColor = true;
            this.rdb_select.CheckedChanged += new System.EventHandler(this.rdb_select_CheckedChanged);
            // 
            // rdb_delete
            // 
            this.rdb_delete.AutoSize = true;
            this.rdb_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_delete.Location = new System.Drawing.Point(355, 55);
            this.rdb_delete.Name = "rdb_delete";
            this.rdb_delete.Size = new System.Drawing.Size(86, 29);
            this.rdb_delete.TabIndex = 23;
            this.rdb_delete.Text = "Delete";
            this.rdb_delete.UseVisualStyleBackColor = true;
            this.rdb_delete.CheckedChanged += new System.EventHandler(this.rdb_delete_CheckedChanged);
            // 
            // rdb_Edit
            // 
            this.rdb_Edit.AutoSize = true;
            this.rdb_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Edit.Location = new System.Drawing.Point(196, 55);
            this.rdb_Edit.Name = "rdb_Edit";
            this.rdb_Edit.Size = new System.Drawing.Size(63, 29);
            this.rdb_Edit.TabIndex = 22;
            this.rdb_Edit.Text = "Edit";
            this.rdb_Edit.UseVisualStyleBackColor = true;
            this.rdb_Edit.CheckedChanged += new System.EventHandler(this.rdb_Edit_CheckedChanged);
            // 
            // rdb_add
            // 
            this.rdb_add.AutoSize = true;
            this.rdb_add.Checked = true;
            this.rdb_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_add.Location = new System.Drawing.Point(21, 55);
            this.rdb_add.Name = "rdb_add";
            this.rdb_add.Size = new System.Drawing.Size(66, 29);
            this.rdb_add.TabIndex = 21;
            this.rdb_add.TabStop = true;
            this.rdb_add.Text = "Add";
            this.rdb_add.UseVisualStyleBackColor = true;
            this.rdb_add.CheckedChanged += new System.EventHandler(this.rdb_add_CheckedChanged);
            // 
            // cmb_Rno
            // 
            this.cmb_Rno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Rno.FormattingEnabled = true;
            this.cmb_Rno.Items.AddRange(new object[] {
            "123",
            "456",
            "789",
            "879",
            "999",
            "000"});
            this.cmb_Rno.Location = new System.Drawing.Point(268, 183);
            this.cmb_Rno.Name = "cmb_Rno";
            this.cmb_Rno.Size = new System.Drawing.Size(267, 28);
            this.cmb_Rno.TabIndex = 22;
            this.cmb_Rno.Visible = false;
            this.cmb_Rno.SelectedIndexChanged += new System.EventHandler(this.cmb_Rno_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(568, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 292);
            this.dataGridView1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_rno);
            this.Controls.Add(this.cmb_Rno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_stuname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_deptname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_stuname;
        private System.Windows.Forms.TextBox txt_rno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmb_deptname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_delete;
        private System.Windows.Forms.RadioButton rdb_Edit;
        private System.Windows.Forms.RadioButton rdb_add;
        private System.Windows.Forms.RadioButton rdb_select;
        private System.Windows.Forms.ComboBox cmb_Rno;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

