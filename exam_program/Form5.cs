using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_program
{
    public partial class Form5 : Form
    {

        string Conn = "Server=127.0.0.1;Database=exam;Uid=root;Pwd=0000;";

        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form1 = new Form6();
            form1.ShowDialog();
            this.Close();
        }

        class Student
        {
            public string Name { get; set; }
            public int score { get; set; }
            public string num1_score { get; set; }
            public string num2_score { get; set; }
            public string num3_score { get; set; }
            public string num4_score { get; set; }
            public string num5_score { get; set; }
            public Color cc { get; set; }
        }
        List<Student> list = new List<Student>();
        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=exam;Uid=root;Pwd=0000"))
            {
                string outQuery = string.Format("SELECT * FROM exam.score_data");
                MySqlCommand command = new MySqlCommand(outQuery, connection);
                try //예외 처리
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string str_tt = reader.GetString("name");
                        int grade_db = reader.GetInt32("score");
                        string quzi_01 = reader.GetString("num1");
                        string quzi_02 = reader.GetString("num2");
                        string quzi_03 = reader.GetString("num3");
                        string quzi_04 = reader.GetString("num4");
                        string quzi_05 = reader.GetString("num5");
                        list.Add(new Student() { Name = str_tt, score = grade_db, num1_score = quzi_01, num2_score = quzi_02, num3_score = quzi_03, num4_score = quzi_04, num5_score = quzi_05 });
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                }
            }
            if (list.Count != 0)
            {
                this.Hide();
                Form11 form11 = new Form11();
                form11.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("시험본 학생이 없습니다.");
            }
        }
    }
}
