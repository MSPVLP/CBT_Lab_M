namespace LP4_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_click_to_add = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_current_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_month = new System.Windows.Forms.Button();
            this.btn_add_year = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Operations";
            // 
            // btn_click_to_add
            // 
            this.btn_click_to_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_click_to_add.Location = new System.Drawing.Point(155, 184);
            this.btn_click_to_add.Name = "btn_click_to_add";
            this.btn_click_to_add.Size = new System.Drawing.Size(164, 30);
            this.btn_click_to_add.TabIndex = 1;
            this.btn_click_to_add.Text = "Click to add days";
            this.btn_click_to_add.UseVisualStyleBackColor = true;
            this.btn_click_to_add.Click += new System.EventHandler(this.btn_click_to_add_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(219, 70);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 29);
            this.txt_input.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Date";
            // 
            // txt_current_date
            // 
            this.txt_current_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_current_date.Location = new System.Drawing.Point(137, 22);
            this.txt_current_date.Name = "txt_current_date";
            this.txt_current_date.Size = new System.Drawing.Size(182, 29);
            this.txt_current_date.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Numeric Input";
            // 
            // btn_add_month
            // 
            this.btn_add_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_month.Location = new System.Drawing.Point(155, 230);
            this.btn_add_month.Name = "btn_add_month";
            this.btn_add_month.Size = new System.Drawing.Size(164, 30);
            this.btn_add_month.TabIndex = 6;
            this.btn_add_month.Text = "Click to add months";
            this.btn_add_month.UseVisualStyleBackColor = true;
            this.btn_add_month.Click += new System.EventHandler(this.btn_add_month_Click);
            // 
            // btn_add_year
            // 
            this.btn_add_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_year.Location = new System.Drawing.Point(155, 276);
            this.btn_add_year.Name = "btn_add_year";
            this.btn_add_year.Size = new System.Drawing.Size(164, 30);
            this.btn_add_year.TabIndex = 7;
            this.btn_add_year.Text = "Click to add years";
            this.btn_add_year.UseVisualStyleBackColor = true;
            this.btn_add_year.Click += new System.EventHandler(this.btn_add_year_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 329);
            this.Controls.Add(this.btn_add_year);
            this.Controls.Add(this.btn_add_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_current_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_click_to_add);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_click_to_add;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_current_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_month;
        private System.Windows.Forms.Button btn_add_year;
    }
}

