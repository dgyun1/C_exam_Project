namespace exam_program
{
    partial class Form3
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
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select_id = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(413, 167);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(200, 23);
            this.txtbox_name.TabIndex = 0;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::DongGyun.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(386, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 70);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름";
            // 
            // select_id
            // 
            this.select_id.BackColor = System.Drawing.Color.White;
            this.select_id.Location = new System.Drawing.Point(538, 212);
            this.select_id.Name = "select_id";
            this.select_id.Size = new System.Drawing.Size(75, 23);
            this.select_id.TabIndex = 3;
            this.select_id.Text = "검색";
            this.select_id.UseVisualStyleBackColor = false;
            this.select_id.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(413, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "비밀번호 찾기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(472, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "로그인";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.select_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbox_name);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_id;
        private System.Windows.Forms.Button button1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button button2;
    }
}