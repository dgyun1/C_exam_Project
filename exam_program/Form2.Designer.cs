namespace exam_program
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.txtbox_pwd = new System.Windows.Forms.TextBox();
            this.txtbox_pwd2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_newmember = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(367, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입";
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::DongGyun.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(286, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 70);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(299, 181);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(215, 23);
            this.txtbox_name.TabIndex = 2;
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(299, 231);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(215, 23);
            this.txtbox_id.TabIndex = 3;
            // 
            // txtbox_pwd
            // 
            this.txtbox_pwd.Location = new System.Drawing.Point(299, 282);
            this.txtbox_pwd.Name = "txtbox_pwd";
            this.txtbox_pwd.PasswordChar = '*';
            this.txtbox_pwd.Size = new System.Drawing.Size(215, 23);
            this.txtbox_pwd.TabIndex = 4;
            // 
            // txtbox_pwd2
            // 
            this.txtbox_pwd2.Location = new System.Drawing.Point(298, 332);
            this.txtbox_pwd2.Name = "txtbox_pwd2";
            this.txtbox_pwd2.PasswordChar = '*';
            this.txtbox_pwd2.Size = new System.Drawing.Size(215, 23);
            this.txtbox_pwd2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "아이디";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "비밀번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "비밀번호 재확인";
            // 
            // btn_newmember
            // 
            this.btn_newmember.BackColor = System.Drawing.Color.White;
            this.btn_newmember.Location = new System.Drawing.Point(341, 377);
            this.btn_newmember.Name = "btn_newmember";
            this.btn_newmember.Size = new System.Drawing.Size(128, 31);
            this.btn_newmember.TabIndex = 10;
            this.btn_newmember.Text = "가입하기";
            this.btn_newmember.UseVisualStyleBackColor = false;
            this.btn_newmember.Click += new System.EventHandler(this.btn_newmember_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.White;
            this.btn_check.Location = new System.Drawing.Point(520, 230);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 11;
            this.btn_check.Text = "중복검사";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(341, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_newmember);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_pwd2);
            this.Controls.Add(this.txtbox_pwd);
            this.Controls.Add(this.txtbox_id);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.TextBox txtbox_pwd;
        private System.Windows.Forms.TextBox txtbox_pwd2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_newmember;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button button1;
    }
}