namespace exam_program
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            groupBox2 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Black;
            groupBox2.Location = new System.Drawing.Point(38, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(708, 3);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.WhiteSmoke;
            button2.Location = new System.Drawing.Point(471, 233);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(115, 32);
            button2.TabIndex = 28;
            button2.Text = "성적 보기";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.WhiteSmoke;
            button1.Location = new System.Drawing.Point(186, 233);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 32);
            button1.TabIndex = 27;
            button1.Text = "로그아웃";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(176, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(419, 60);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Location = new System.Drawing.Point(195, 13);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(400, 76);
            button3.TabIndex = 31;
            button3.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(784, 361);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Name = "Form9";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}