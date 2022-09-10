namespace Ex_3
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
            this.txt_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_memory = new System.Windows.Forms.Button();
            this.btn_recall = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_memory_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(21, 34);
            this.txt_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(422, 44);
            this.txt_result.TabIndex = 0;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumEvent);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(124, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumEvent);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(230, 418);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumEvent);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(21, 315);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 65);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumEvent);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(124, 315);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumEvent);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(230, 315);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 65);
            this.button6.TabIndex = 4;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumEvent);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(18, 214);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 65);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumEvent);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(124, 214);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 65);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumEvent);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(230, 214);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 65);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumEvent);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(21, 520);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 65);
            this.button10.TabIndex = 12;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(369, 214);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(76, 65);
            this.btn_plus.TabIndex = 11;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.OperatorsEvent);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(369, 315);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(76, 65);
            this.btn_minus.TabIndex = 10;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.OperatorsEvent);
            // 
            // btn_multi
            // 
            this.btn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(369, 418);
            this.btn_multi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(76, 65);
            this.btn_multi.TabIndex = 15;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.OperatorsEvent);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(369, 520);
            this.btn_div.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(76, 65);
            this.btn_div.TabIndex = 14;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.OperatorsEvent);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(124, 520);
            this.btn_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(182, 65);
            this.btn_result.TabIndex = 13;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_memory
            // 
            this.btn_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_memory.Location = new System.Drawing.Point(21, 125);
            this.btn_memory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_memory.Name = "btn_memory";
            this.btn_memory.Size = new System.Drawing.Size(76, 65);
            this.btn_memory.TabIndex = 16;
            this.btn_memory.Text = "M+";
            this.btn_memory.UseVisualStyleBackColor = true;
            this.btn_memory.Click += new System.EventHandler(this.btn_memory_Click);
            // 
            // btn_recall
            // 
            this.btn_recall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_recall.Location = new System.Drawing.Point(124, 125);
            this.btn_recall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_recall.Name = "btn_recall";
            this.btn_recall.Size = new System.Drawing.Size(76, 65);
            this.btn_recall.TabIndex = 17;
            this.btn_recall.Text = "MR";
            this.btn_recall.UseVisualStyleBackColor = true;
            this.btn_recall.Click += new System.EventHandler(this.btn_recall_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clear.Location = new System.Drawing.Point(369, 125);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 65);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_memory_clear
            // 
            this.btn_memory_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_memory_clear.Location = new System.Drawing.Point(230, 125);
            this.btn_memory_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_memory_clear.Name = "btn_memory_clear";
            this.btn_memory_clear.Size = new System.Drawing.Size(76, 65);
            this.btn_memory_clear.TabIndex = 19;
            this.btn_memory_clear.Text = "MC";
            this.btn_memory_clear.UseVisualStyleBackColor = true;
            this.btn_memory_clear.Click += new System.EventHandler(this.btn_memory_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 602);
            this.Controls.Add(this.btn_memory_clear);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_recall);
            this.Controls.Add(this.btn_memory);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator with Memory & Recall - Ex 3 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_memory;
        private System.Windows.Forms.Button btn_recall;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_memory_clear;
    }
}

