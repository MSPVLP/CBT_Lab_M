namespace Ex_5
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_foldername = new System.Windows.Forms.TextBox();
            this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.driveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.btn_select_folder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_select_file = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(266, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "Folder and File Control ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selected File:";
            // 
            // txt_filename
            // 
            this.txt_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filename.Location = new System.Drawing.Point(37, 520);
            this.txt_filename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(674, 35);
            this.txt_filename.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selected Folder:";
            // 
            // txt_foldername
            // 
            this.txt_foldername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foldername.Location = new System.Drawing.Point(37, 420);
            this.txt_foldername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_foldername.Name = "txt_foldername";
            this.txt_foldername.Size = new System.Drawing.Size(674, 35);
            this.txt_foldername.TabIndex = 9;
            // 
            // dirListBox1
            // 
            this.dirListBox1.FormattingEnabled = true;
            this.dirListBox1.IntegralHeight = false;
            this.dirListBox1.Location = new System.Drawing.Point(37, 136);
            this.dirListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dirListBox1.Name = "dirListBox1";
            this.dirListBox1.Size = new System.Drawing.Size(356, 225);
            this.dirListBox1.TabIndex = 13;
            this.dirListBox1.SelectedIndexChanged += new System.EventHandler(this.dirListBox1_SelectedIndexChanged);
            // 
            // driveListBox1
            // 
            this.driveListBox1.FormattingEnabled = true;
            this.driveListBox1.Location = new System.Drawing.Point(37, 99);
            this.driveListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.driveListBox1.Name = "driveListBox1";
            this.driveListBox1.Size = new System.Drawing.Size(356, 27);
            this.driveListBox1.TabIndex = 14;
            this.driveListBox1.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
            // 
            // fileListBox1
            // 
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.Location = new System.Drawing.Point(413, 99);
            this.fileListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Pattern = "*.*";
            this.fileListBox1.Size = new System.Drawing.Size(298, 264);
            this.fileListBox1.TabIndex = 15;
            this.fileListBox1.SelectedIndexChanged += new System.EventHandler(this.fileListBox1_SelectedIndexChanged);
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_folder.Location = new System.Drawing.Point(735, 421);
            this.btn_select_folder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(176, 35);
            this.btn_select_folder.TabIndex = 16;
            this.btn_select_folder.Text = "Select Folder...";
            this.btn_select_folder.UseVisualStyleBackColor = true;
            this.btn_select_folder.Click += new System.EventHandler(this.btn_select_folder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 646);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 366);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_select_file
            // 
            this.btn_select_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_file.Location = new System.Drawing.Point(735, 520);
            this.btn_select_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_select_file.Name = "btn_select_file";
            this.btn_select_file.Size = new System.Drawing.Size(176, 35);
            this.btn_select_file.TabIndex = 18;
            this.btn_select_file.Text = "Select File...";
            this.btn_select_file.UseVisualStyleBackColor = true;
            this.btn_select_file.Click += new System.EventHandler(this.btn_select_file_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 612);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Picture:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 1091);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_select_file);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_select_folder);
            this.Controls.Add(this.fileListBox1);
            this.Controls.Add(this.driveListBox1);
            this.Controls.Add(this.dirListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_foldername);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Folder and File Control  - Ex 5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_foldername;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
        private System.Windows.Forms.Button btn_select_folder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_select_file;
        private System.Windows.Forms.Label label3;
    }
}

