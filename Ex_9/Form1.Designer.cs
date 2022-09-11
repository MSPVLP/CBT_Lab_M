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
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.rdb_A = new System.Windows.Forms.RadioButton();
            this.rdb_B = new System.Windows.Forms.RadioButton();
            this.rdb_C = new System.Windows.Forms.RadioButton();
            this.rdb_D = new System.Windows.Forms.RadioButton();
            this.txt_question_no = new System.Windows.Forms.TextBox();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.btn_next_question = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(300, 28);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(79, 34);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // rdb_A
            // 
            this.rdb_A.AutoSize = true;
            this.rdb_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_A.Location = new System.Drawing.Point(107, 199);
            this.rdb_A.Name = "rdb_A";
            this.rdb_A.Size = new System.Drawing.Size(107, 29);
            this.rdb_A.TabIndex = 1;
            this.rdb_A.TabStop = true;
            this.rdb_A.Text = "Option A";
            this.rdb_A.UseVisualStyleBackColor = true;
            // 
            // rdb_B
            // 
            this.rdb_B.AutoSize = true;
            this.rdb_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_B.Location = new System.Drawing.Point(107, 242);
            this.rdb_B.Name = "rdb_B";
            this.rdb_B.Size = new System.Drawing.Size(106, 29);
            this.rdb_B.TabIndex = 2;
            this.rdb_B.TabStop = true;
            this.rdb_B.Text = "Option B";
            this.rdb_B.UseVisualStyleBackColor = true;
            // 
            // rdb_C
            // 
            this.rdb_C.AutoSize = true;
            this.rdb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_C.Location = new System.Drawing.Point(107, 286);
            this.rdb_C.Name = "rdb_C";
            this.rdb_C.Size = new System.Drawing.Size(108, 29);
            this.rdb_C.TabIndex = 3;
            this.rdb_C.TabStop = true;
            this.rdb_C.Text = "Option C";
            this.rdb_C.UseVisualStyleBackColor = true;
            // 
            // rdb_D
            // 
            this.rdb_D.AutoSize = true;
            this.rdb_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_D.Location = new System.Drawing.Point(106, 333);
            this.rdb_D.Name = "rdb_D";
            this.rdb_D.Size = new System.Drawing.Size(107, 29);
            this.rdb_D.TabIndex = 4;
            this.rdb_D.TabStop = true;
            this.rdb_D.Text = "Option D";
            this.rdb_D.UseVisualStyleBackColor = true;
            // 
            // txt_question_no
            // 
            this.txt_question_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_question_no.Location = new System.Drawing.Point(63, 117);
            this.txt_question_no.Name = "txt_question_no";
            this.txt_question_no.ReadOnly = true;
            this.txt_question_no.Size = new System.Drawing.Size(60, 29);
            this.txt_question_no.TabIndex = 5;
            // 
            // txt_question
            // 
            this.txt_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_question.Location = new System.Drawing.Point(107, 152);
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(548, 29);
            this.txt_question.TabIndex = 6;
            // 
            // txt_score
            // 
            this.txt_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score.Location = new System.Drawing.Point(533, 412);
            this.txt_score.Multiline = true;
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(132, 60);
            this.txt_score.TabIndex = 7;
            this.txt_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_next_question
            // 
            this.btn_next_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next_question.Location = new System.Drawing.Point(270, 406);
            this.btn_next_question.Name = "btn_next_question";
            this.btn_next_question.Size = new System.Drawing.Size(87, 40);
            this.btn_next_question.TabIndex = 8;
            this.btn_next_question.Text = "Next";
            this.btn_next_question.UseVisualStyleBackColor = true;
            this.btn_next_question.Visible = false;
            this.btn_next_question.Click += new System.EventHandler(this.btn_next_question_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_time
            // 
            this.txt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.Location = new System.Drawing.Point(484, 57);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(171, 29);
            this.txt_time.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Q.No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.btn_next_question);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.txt_question_no);
            this.Controls.Add(this.rdb_D);
            this.Controls.Add(this.rdb_C);
            this.Controls.Add(this.rdb_B);
            this.Controls.Add(this.rdb_A);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.RadioButton rdb_A;
        private System.Windows.Forms.RadioButton rdb_B;
        private System.Windows.Forms.RadioButton rdb_C;
        private System.Windows.Forms.RadioButton rdb_D;
        private System.Windows.Forms.TextBox txt_question_no;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Button btn_next_question;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

