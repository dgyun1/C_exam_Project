namespace exam_program
{
    partial class Form4
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
            this.select_pwd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(341, 167);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(185, 23);
            this.txtbox_name.TabIndex = 5;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::DongGyun.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(314, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 70);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "이름";
            // 
            // select_pwd
            // 
            this.select_pwd.BackColor = System.Drawing.Color.White;
            this.select_pwd.Location = new System.Drawing.Point(430, 213);
            this.select_pwd.Name = "select_pwd";
            this.select_pwd.Size = new System.Drawing.Size(75, 23);
            this.select_pwd.TabIndex = 8;
            this.select_pwd.Text = "검색";
            this.select_pwd.UseVisualStyleBackColor = false;
            this.select_pwd.Click += new System.EventHandler(this.select_pwd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "아이디";
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(341, 138);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(185, 23);
            this.txtbox_id.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(349, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_id);
            this.Controls.Add(this.select_pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbox_name);
            this.Name = "Form6";
            this.Text = "Form6";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.Button button1;
    }
}