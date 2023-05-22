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
/*using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;*/

namespace exam_program
{
    public partial class Form10 : Form
    {
        
        static string constr = "Server =127.0.0.1; Database=exam;Uid=root;Pwd=0000";
        static MySqlConnection connection = new MySqlConnection(constr);
        List<int> string_answer;
        List<RadioButton> radioButton_1;
        List<RadioButton> radioButton_2;
        List<RadioButton> radioButton_3;
        List<RadioButton> radioButton_4;
        public Form10()
        {

            InitializeComponent();
            label2.Text = Program.score.ToString() + " 점";
            label1.Text = Program.name + "님의 점수입니다.";
            string Query = "SELECT * FROM exam.exam_submit";
            MySqlCommand command = new MySqlCommand(Query, connection);

            List<string> string_first = new List<string>();
            List<string> string_second = new List<string>();
            List<string> string_third = new List<string>();
            List<string> string_fourth = new List<string>();
            List<string> string_text = new List<string>();
            string_answer = new List<int>();

            List<TextBox> textBox = new List<TextBox>() { textBox6, textBox2, textBox3, textBox4, textBox5 };

            radioButton_1 = new List<RadioButton>() { first1_1, first1_2, first1_3, first1_4, first1_5 };
            radioButton_2 = new List<RadioButton>() { sec2_1, sec2_2, sec2_3, sec2_4, sec2_5 };
            radioButton_3 = new List<RadioButton>() { th3_1, th3_2, th3_3, th3_4, th3_5 };
            radioButton_4 = new List<RadioButton>() { four4_1, four4_2, four4_3, four4_4, four4_5 };

            List<RadioButton> radioButton_num1 = new List<RadioButton>() { first1_1, sec2_1, th3_1, four4_1 };
            List<RadioButton> radioButton_num2 = new List<RadioButton>() { first1_2, sec2_2, th3_2, four4_2 };
            List<RadioButton> radioButton_num3 = new List<RadioButton>() { first1_3, sec2_3, th3_3, four4_3 }; ;
            List<RadioButton> radioButton_num4 = new List<RadioButton>() { first1_4, sec2_4, th3_4, four4_4 }; ;
            List<RadioButton> radioButton_num5 = new List<RadioButton>() { first1_5, sec2_5, th3_5, four4_5 }; ;
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
                connection.Close();
                //for (int j = 0; j < string_text.Count; j++)
                //{
                //    textBox1.Text += string_text[j] + string_first[j] + string_second[j] + string_third[j] + string_fourth[j];
                //    textBox1.Text += "         ";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            radioButton_num1[Program.list[0] - 1].Checked = true;
            radioButton_num2[Program.list[1] - 1].Checked = true;
            radioButton_num3[Program.list[2] - 1].Checked = true;
            radioButton_num4[Program.list[3] - 1].Checked = true;
            radioButton_num5[Program.list[4] - 1].Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.score = 0;
            Program.flag = 1;
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
