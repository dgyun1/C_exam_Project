namespace exam_program
{
    partial class Form11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.close = new System.Windows.Forms.Button();
            this.grade_sort = new System.Windows.Forms.Button();
            this.name_sort = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.next_quzi = new System.Windows.Forms.Button();
            this.quzi_num = new System.Windows.Forms.Label();
            this.rigth_rating = new System.Windows.Forms.Label();
            this.pie_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.back_quzi = new System.Windows.Forms.Button();
            this.save_dd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            //this.close.BackgroundImage = global::ttset.Properties.Resources.back_window;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Location = new System.Drawing.Point(1063, 677);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(98, 62);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button3_Click);
            // 
            // grade_sort
            // 
            //this.grade_sort.BackgroundImage = global::ttset.Properties.Resources._8638640;
            this.grade_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grade_sort.Location = new System.Drawing.Point(1027, 450);
            this.grade_sort.Name = "grade_sort";
            this.grade_sort.Size = new System.Drawing.Size(56, 54);
            this.grade_sort.TabIndex = 2;
            this.grade_sort.UseVisualStyleBackColor = true;
            this.grade_sort.Click += new System.EventHandler(this.button4_Click);
            // 
            // name_sort
            // 
            //this.name_sort.BackgroundImage = global::ttset.Properties.Resources._2769161;
            this.name_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.name_sort.Location = new System.Drawing.Point(1027, 390);
            this.name_sort.Name = "name_sort";
            this.name_sort.Size = new System.Drawing.Size(56, 54);
            this.name_sort.TabIndex = 3;
            this.name_sort.UseVisualStyleBackColor = true;
            this.name_sort.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(793, 330);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellErrorTextChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellErrorTextChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 348);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Grade";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1160, 401);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // next_quzi
            // 
            //this.next_quzi.BackgroundImage = global::ttset.Properties.Resources._20128464a3534d6d550c2d51dd86104d;
            this.next_quzi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next_quzi.Location = new System.Drawing.Point(1115, 297);
            this.next_quzi.Name = "next_quzi";
            this.next_quzi.Size = new System.Drawing.Size(46, 33);
            this.next_quzi.TabIndex = 7;
            this.next_quzi.UseVisualStyleBackColor = true;
            this.next_quzi.Click += new System.EventHandler(this.next_quzi_Click);
            // 
            // quzi_num
            // 
            this.quzi_num.AutoSize = true;
            this.quzi_num.BackColor = System.Drawing.Color.White;
            this.quzi_num.Location = new System.Drawing.Point(824, 315);
            this.quzi_num.Name = "quzi_num";
            this.quzi_num.Size = new System.Drawing.Size(39, 15);
            this.quzi_num.TabIndex = 8;
            this.quzi_num.Text = "label1";
            // 
            // rigth_rating
            // 
            this.rigth_rating.AutoSize = true;
            this.rigth_rating.BackColor = System.Drawing.Color.White;
            this.rigth_rating.Location = new System.Drawing.Point(824, 22);
            this.rigth_rating.Name = "rigth_rating";
            this.rigth_rating.Size = new System.Drawing.Size(39, 15);
            this.rigth_rating.TabIndex = 9;
            this.rigth_rating.Text = "label1";
            // 
            // pie_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.pie_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pie_chart.Legends.Add(legend2);
            this.pie_chart.Location = new System.Drawing.Point(811, 12);
            this.pie_chart.Name = "pie_chart";
            this.pie_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "rate";
            this.pie_chart.Series.Add(series2);
            this.pie_chart.Size = new System.Drawing.Size(361, 330);
            this.pie_chart.TabIndex = 6;
            this.pie_chart.Text = "chart2";
            // 
            // back_quzi
            // 
            //this.back_quzi.BackgroundImage = global::ttset.Properties.Resources._20128464a3534d6d550c2d51dd86104d2;
            this.back_quzi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_quzi.Location = new System.Drawing.Point(1063, 297);
            this.back_quzi.Name = "back_quzi";
            this.back_quzi.Size = new System.Drawing.Size(46, 33);
            this.back_quzi.TabIndex = 11;
            this.back_quzi.UseVisualStyleBackColor = true;
            this.back_quzi.Click += new System.EventHandler(this.back_quzi_Click);
            // 
            // save_dd
            // 
            //this.save_dd.BackgroundImage = global::ttset.Properties.Resources.save_as;
            this.save_dd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_dd.Location = new System.Drawing.Point(1027, 510);
            this.save_dd.Name = "save_dd";
            this.save_dd.Size = new System.Drawing.Size(56, 54);
            this.save_dd.TabIndex = 12;
            this.save_dd.UseVisualStyleBackColor = true;
            this.save_dd.Click += new System.EventHandler(this.save_dd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save_dd);
            this.Controls.Add(this.back_quzi);
            this.Controls.Add(this.rigth_rating);
            this.Controls.Add(this.quzi_num);
            this.Controls.Add(this.next_quzi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.name_sort);
            this.Controls.Add(this.grade_sort);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pie_chart);
            this.Controls.Add(this.chart1);
            this.Name = "Form11";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button grade_sort;
        private System.Windows.Forms.Button name_sort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button next_quzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quzi_num;
        private System.Windows.Forms.Label rigth_rating;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie_chart;
        private System.Windows.Forms.Button back_quzi;
        private System.Windows.Forms.Button save_dd;
        private System.Windows.Forms.TextBox textBox1;
    }
}