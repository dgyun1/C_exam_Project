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
using static System.Formats.Asn1.AsnWriter;

namespace exam_program
{

    public partial class Form8 : Form
    {
        static string constr = "Server =127.0.0.1; Database=exam;Uid=root;Pwd=0000";
        static string constr1 = "Server =127.0.0.1; Database=exam;Uid=root;Pwd=0000";

        static MySqlConnection connection = new MySqlConnection(constr);
        static MySqlConnection connection1 = new MySqlConnection(constr1);

        List<RadioButton> radioButton_1;
        List<RadioButton> radioButton_2;
        List<RadioButton> radioButton_3;
        List<RadioButton> radioButton_4;

        List<int> string_answer;

        public Form8()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            label21.Text = Program.name + "님 환영합니다";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] str_spl;
            str_spl = textBox2.Text.Split(',');
            string insertQuery = string.Format("INSERT INTO exam_submit(exam_problem,exam_answer1,exam_answer2,exam_answer3,exam_answer4,exam_org_answer) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", str_spl[0], str_spl[1], str_spl[2], str_spl[3], str_spl[4], str_spl[5]);

            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//예외 처리
            {

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    textBox1.Text = "인서트 성공";
                }
                else
                {
                    textBox1.Text = "인서트 실패";
                }

            }
            catch (Exception ex)
            {
                textBox1.Text = "실패";
                MessageBox.Show(ex.ToString());
            }
            textBox2.Text = "";
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM exam.exam_submit";
            MySqlCommand command = new MySqlCommand(Query, connection);

            List<string> string_first = new List<string>();
            List<string> string_second = new List<string>();
            List<string> string_third = new List<string>();
            List<string> string_fourth = new List<string>();
            List<string> string_text = new List<string>();
            string_answer = new List<int>();

            List<TextBox> textBox = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5 };

            radioButton_1 = new List<RadioButton>() { first1_1, first1_2, first1_3, first1_4, first1_5 };
            radioButton_2 = new List<RadioButton>() { sec2_1, sec2_2, sec2_3, sec2_4, sec2_5 };
            radioButton_3 = new List<RadioButton>() { th3_1, th3_2, th3_3, th3_4, th3_5 };
            radioButton_4 = new List<RadioButton>() { four4_1, four4_2, four4_3, four4_4, four4_5 };

            int count = 0;
            try//예외 처리
            {
                connection.Open();
                MySqlDataReader MyReader = command.ExecuteReader();
                while (MyReader.Read())
                {
                    string s_text = MyReader.GetString("exam_problem");
                   
                    string s_first = MyReader.GetString("exam_answer1");
                    string s_second = MyReader.GetString("exam_answer2");
                    string s_third = MyReader.GetString("exam_answer3");
                    string s_fourth = MyReader.GetString("exam_answer4");
                    int s_answer = MyReader.GetInt32("exam_org_answer");

                    string_text.Add(s_text);
                    string_first.Add(s_first);
                    string_second.Add(s_second);
                    string_third.Add(s_third);
                    string_fourth.Add(s_fourth);

                    string_answer.Add(s_answer);

                    textBox[count].Text = string_text[count];
                    radioButton_1[count].Text = string_first[count];
                    radioButton_2[count].Text = string_second[count];
                    radioButton_3[count].Text = string_third[count];
                    radioButton_4[count].Text = string_fourth[count];
                    count++;
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "실패";
                MessageBox.Show(ex.ToString());
            }

        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            string query_del = "delete from test_score.student_score where no";
            MySqlCommand command = new MySqlCommand(query_del, connection);
            MySqlDataReader myreader;
            try//예외 처리
            {
                connection.Open();

                myreader= command.ExecuteReader();
                MessageBox.Show("삭제됨");
            }
            catch (Exception ex)
            {
                textBox1.Text = "실패";
                MessageBox.Show(ex.ToString());
            }
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    if (radioButton_1 == null || radioButton_2 == null || radioButton_3 == null || radioButton_4 == null)
                    {
                        MessageBox.Show("문제를 받아오지 않았습니다.");
                        break;
                    }
                    else if (radioButton_1[i].Checked)
                        Program.list[i] = 1;
                    else if (radioButton_2[i].Checked)
                        Program.list[i] = 2;
                    else if (radioButton_3[i].Checked)
                        Program.list[i] = 3;
                    else if (radioButton_4[i].Checked)
                        Program.list[i] = 4;
                    else
                        Program.list[i] = 0;
                }

                for (int j = 0; j < 5; j++)
                {
                    if (Program.list[j] == 0 )
                    {
                        MessageBox.Show("체크 안 한 항목이 있습니다.");
                        break;
                    }
                    else if (string_answer[j] == Program.list[j])
                    {
                        Program.count.Add("O");
                        Program.score += 20;
                    }
                    else
                        Program.count.Add("X");
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("체크 안 한 항목이 있습니다.");
            }

            try
            {
                string insertQuery = string.Format("INSERT INTO score_data(name,score,num1,num2,num3,num4,num5,answer1,answer2,answer3,answer4,answer5) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                    Program.name,Program.score, Program.count[0], Program.count[1], Program.count[2], Program.count[3], Program.count[4], Program.list[0], Program.list[1], Program.list[2], Program.list[3], Program.list[4]);
                MySqlCommand command = new MySqlCommand(insertQuery, connection1);
                connection1.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    using (MySqlConnection connection = new MySqlConnection("Server =127.0.0.1; Database=exam;Uid=root;Pwd=0000"))
                    {
                        //string outQuery = string.Format("update test_score.student_score");
                        string outQuery = string.Format($"update exam.member set flag = 1 WHERE name = '{Program.name}';");
                        MySqlCommand command1 = new MySqlCommand(outQuery, connection);            
                        connection.Open();
                        MySqlDataReader reader = command1.ExecuteReader();    
                    }
                    MessageBox.Show("제출 완료했습니다.");
                    this.Hide();
                    Form9 form9 = new Form9();
                    form9.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("실패");
                }
            }
            catch (Exception ex)
            {

            }
        }
    }



}
