namespace exam_program
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(195, 217);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 60);
            button1.TabIndex = 0;
            button1.Text = "시험 응시";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(495, 217);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 60);
            button2.TabIndex = 1;
            button2.Text = "성적 보기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Black;
            groupBox2.Location = new System.Drawing.Point(32, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(708, 3);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Location = new System.Drawing.Point(195, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(400, 76);
            button3.TabIndex = 27;
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(296, 159);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 19);
            label1.TabIndex = 29;
            label1.Text = "출제자님 환영합니다.";
            // 
            // Form7
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(784, 361);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form7";
            Text = "메뉴선택";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}
