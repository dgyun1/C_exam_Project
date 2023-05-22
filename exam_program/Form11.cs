using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace exam_program
{
    public partial class Form11 : Form
    {
        //Form1 _f2;
        public Form11()
        {
            InitializeComponent();
            this.Text = "학생 성적";
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable table = new DataTable();
        public void Data_table_setting()
        {
            table.Columns.Clear();
            // column을 추가
            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("학점", typeof(string));
            table.Columns.Add("1번 정답", typeof(string));
            table.Columns.Add("2번 정답", typeof(string));
            table.Columns.Add("3번 정답", typeof(string));
            table.Columns.Add("4번 정답", typeof(string));
            table.Columns.Add("5번 정답", typeof(string));

            dataGridView1.DataSource = table;
        }

        List<Student> studentNameSortList;
        List<Student> studentNameSortList2;
        List<Student> list = new List<Student>();

        private void Form6_Load(object sender, EventArgs e)
        {
            data_load(ref list);
            Data_table_setting();
            table_add2(ref list, table);
            chart1_draw(); //바 그래프 그리는 함수
            result_rate(); //정답률
        }

        static void data_load(ref List<Student> aa)
        {
            using (MySqlConnection connection = new MySqlConnection("Server =127.0.0.1; Database=exam; Uid=root; Pwd=0000"))
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
                        aa.Add(new Student() { Name = str_tt, score = grade_db, num1_score = quzi_01, num2_score = quzi_02, num3_score = quzi_03, num4_score = quzi_04, num5_score = quzi_05 });
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터 불러오기 실패");
                }
            }
        }

        static void table_add2(ref List<Student> aa, DataTable bb) //테이블에 추가하는 함수 
        {
            bb.Clear();
            for (int i = 0; i < aa.Count; i++)
            {
                bb.Rows.Add($"{aa[i].Name}", $"{aa[i].score}", $"{aa[i].num1_score}", $"{aa[i].num2_score}", $"{aa[i].num3_score}", $"{aa[i].num4_score}", $"{aa[i].num5_score}");
            }
        }

        public void chart1_draw() //바 그래프 그리는 함수
        {
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            Random r = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                list[i].cc = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                if (i >= 1)
                {
                    if (list[i - 1].cc == list[i].cc)
                        continue;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                chart1.Series["Grade"].Points.AddXY($"{list[i].Name}", $"{list[i].score}");
                chart1.Series["Grade"].Points[i].Color = list[i].cc;
            }
        }

        int selet = 1;
        public void result_rate()
        {
            pie_chart.Series["rate"].Points.Clear();
            if (selet == 6)
                selet = 1;
            int quzi_01 = 0;
            int quzi_02 = 0;
            int quzi_03 = 0;
            int quzi_04 = 0;
            int quzi_05 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].num1_score == "o" || list[i].num1_score == "O")
                    quzi_01++;
                if (list[i].num2_score == "o" || list[i].num2_score == "O")
                    quzi_02++;
                if (list[i].num3_score == "o" || list[i].num3_score == "O")
                    quzi_03++;
                if (list[i].num4_score == "o" || list[i].num4_score == "O")
                    quzi_04++;
                if (list[i].num5_score == "o" || list[i].num5_score == "O")
                    quzi_05++;
            }
            result_pie(quzi_01, quzi_02, quzi_03, quzi_04, quzi_05, selet);
        }

        public void result_pie(int q1, int q2, int q3, int q4, int q5, int sel)
        {
            int rigth = 0;
            if (sel == 1)
            {
                rigth = q1;
                quzi_num.Text = "1번 문제";
            }
            else if (sel == 2)
            {
                rigth = q2;
                quzi_num.Text = "2번 문제";
            }
            else if (sel == 3)
            {
                rigth = q3;
                quzi_num.Text = "3번 문제";
            }
            else if (sel == 4)
            {
                rigth = q4;
                quzi_num.Text = "4번 문제";
            }
            else
            {
                rigth = q5;
                quzi_num.Text = "5번 문제";
            }

            int quzi_lenth = list.Count;
            double step_01 = Math.Round((double)rigth / quzi_lenth, 5);
            double step_02 = Math.Round((1.0 - step_01), 5);
            string rate_01 = (step_01 * 100).ToString() + "%";
            string rate_02 = (step_02 * 100).ToString() + "%";

            rigth_rating.Text = quzi_num.Text + "정답률" + " : " + rate_01;
            if ((q1 == 0 && sel == 1) || (q2 == 0 && sel == 2) || (q3 == 0 && sel == 3) || (q4 == 0 && sel == 4) || (q5 == 0 && sel == 5))
            {
                pie_chart.Series["rate"].Points.Add(step_01);
                pie_chart.Series["rate"].Points.Add(step_02);
                pie_chart.Series["rate"].Points[1].Label = rate_02;
                pie_chart.Series["rate"].Points[0].LegendText = "정답률";
                pie_chart.Series["rate"].Points[1].LegendText = "오답률";
            }
            else if ((q1 == list.Count && sel == 1) || (q2 == list.Count && sel == 2) || (q3 == list.Count && sel == 3) || (q4 == list.Count && sel == 4) || (q5 == list.Count && sel == 5))
            {
                pie_chart.Series["rate"].Points.Add(step_01);
                pie_chart.Series["rate"].Points.Add(step_02);
                pie_chart.Series["rate"].Points[0].Label = rate_01;
                pie_chart.Series["rate"].Points[0].LegendText = "정답률";
                pie_chart.Series["rate"].Points[1].LegendText = "오답률";
            }
            else
            {
                pie_chart.Series["rate"].Points.Add(step_01);
                pie_chart.Series["rate"].Points.Add(step_02);
                pie_chart.Series["rate"].Points[0].Label = rate_01;
                pie_chart.Series["rate"].Points[1].Label = rate_02;
                pie_chart.Series["rate"].Points[0].LegendText = "정답률";
                pie_chart.Series["rate"].Points[1].LegendText = "오답률";
            }
        }

        private void next_quzi_Click(object sender, EventArgs e)
        {
            selet++;
            result_rate();
        }

        private void back_quzi_Click(object sender, EventArgs e)
        {
            if (selet == 1)
                selet = 5;
            else
                selet--;
            result_rate();
        }

        int count_b4 = 0;
        int count_b5 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series["Grade"].Points.Clear();
            if (count_b4 % 2 == 0)
                studentNameSortList = list.OrderByDescending(x => x.score).ToList();
            else if (count_b4 % 2 == 1)
                studentNameSortList = list.OrderBy(x => x.score).ToList();
            int revers_draw = 0;
            for (int i = studentNameSortList.Count - 1; i >= 0; i--)
            {
                chart1.Series["Grade"].Points.AddXY($"{studentNameSortList[i].Name}", $"{studentNameSortList[i].score}");
                chart1.Series["Grade"].Points[revers_draw].Color = studentNameSortList[i].cc;
                revers_draw++;
            }
            table_add2(ref studentNameSortList, table);
            count_b4++;
            if (count_b4 == 2)
                count_b4 = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series["Grade"].Points.Clear();
            if (count_b5 % 2 == 0)
                studentNameSortList2 = list.OrderByDescending(x => x.score).ToList();
            else if (count_b5 % 2 == 1)
                studentNameSortList2 = list.OrderBy(x => x.score).ToList();
            int revers_draw = 0;
            for (int i = studentNameSortList2.Count - 1; i >= 0; i--)
            {
                chart1.Series["Grade"].Points.AddXY($"{studentNameSortList2[i].Name}", $"{studentNameSortList2[i].score}");
                chart1.Series["Grade"].Points[revers_draw].Color = studentNameSortList2[i].cc;
                revers_draw++;
            }
            table_add2(ref studentNameSortList2, table);
            count_b5++;
            if (count_b5 == 2)
                count_b5 = 0;
        }

        private void save_dd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string data_name = row.Cells[0].Value.ToString();
            string data_grade = row.Cells[1].Value.ToString();
            int.TryParse(data_grade, out int change_data_grade);
            string data_num1 = row.Cells[2].Value.ToString();
            string data_num2 = row.Cells[3].Value.ToString();
            string data_num3 = row.Cells[4].Value.ToString();
            string data_num4 = row.Cells[5].Value.ToString();
            string data_num5 = row.Cells[6].Value.ToString();

            using (MySqlConnection connection = new MySqlConnection("Server =127.0.0.1; Database=exam; Uid=root; Pwd=0000"))
            {
                string outQuery = string.Format($"update exam.score_data set name = '{data_name}', score = '{change_data_grade}', num1 = '{data_num1}', num2 = '{data_num2}', num3 = '{data_num3}', num4 = '{data_num4}', num5 = '{data_num5}' WHERE name = '{textBox1.Text}';");
                MySqlCommand command = new MySqlCommand(outQuery, connection);

                try //예외 처리
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("저장완료");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터 불러오기 실패");
                    this.Close();
                }
            }
            List<Student> list_change = new List<Student>();
            list = list_change;
            chart1.Series["Grade"].Points.Clear();
            data_load(ref list);
            Data_table_setting();
            table_add2(ref list, table);
            chart1_draw(); //바 그래프 그리는 함수
            result_rate(); //정답률
        }

        string save_name = null;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0]; //선택된 Row 값 가져옴.
            save_name = row.Cells[0].Value.ToString(); // row의 컬럼(Cells[0]) = name
            textBox1.Text = save_name;
        }
        string save_name2 = null;
        private void dataGridView1_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
