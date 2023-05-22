namespace exam_program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.txtbox_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_newmember = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(450, 394);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(206, 23);
            this.txtbox_id.TabIndex = 0;
            // 
            // txtbox_pwd
            // 
            this.txtbox_pwd.Location = new System.Drawing.Point(450, 439);
            this.txtbox_pwd.Name = "txtbox_pwd";
            this.txtbox_pwd.PasswordChar = '*';
            this.txtbox_pwd.Size = new System.Drawing.Size(206, 23);
            this.txtbox_pwd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 231);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(415, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "아이디 찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(507, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "비밀번호 찾기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_newmember
            // 
            this.btn_newmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newmember.Location = new System.Drawing.Point(609, 537);
            this.btn_newmember.Name = "btn_newmember";
            this.btn_newmember.Size = new System.Drawing.Size(86, 23);
            this.btn_newmember.TabIndex = 9;
            this.btn_newmember.Text = "회원가입";
            this.btn_newmember.UseVisualStyleBackColor = true;
            this.btn_newmember.Click += new System.EventHandler(this.btn_newmember_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(472, 480);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(162, 42);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(662, 441);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "비밀번호 보이기";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 729);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_newmember);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_pwd);
            this.Controls.Add(this.txtbox_id);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.TextBox txtbox_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_newmember;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
