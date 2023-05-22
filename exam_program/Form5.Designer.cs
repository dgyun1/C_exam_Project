namespace exam_program
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Location = new System.Drawing.Point(191, 19);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(400, 76);
            button3.TabIndex = 21;
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(295, 155);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 19);
            label1.TabIndex = 22;
            label1.Text = "출제자님 환영합니다.";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.WhiteSmoke;
            button1.Location = new System.Drawing.Point(189, 239);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 32);
            button1.TabIndex = 23;
            button1.Text = "문제 관리";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.WhiteSmoke;
            button2.Location = new System.Drawing.Point(474, 239);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(115, 32);
            button2.TabIndex = 24;
            button2.Text = "성적 보기";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(179, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(419, 60);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Black;
            groupBox2.Location = new System.Drawing.Point(41, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(708, 3);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(784, 361);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}