using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace exam_program
{
    public partial class Form6 : Form
    {
        string Conn = "Server=127.0.0.1;Database=exam;Uid=root;Pwd=0000;";

        public Form6()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void submit_data()
        {
            try//예외 처리
            {
                using (MySqlConnection conn = new MySqlConnection(Conn))
                {
                    conn.Open();
                    MySqlCommand msc1 = new MySqlCommand("insert into exam_submit(exam_problem, exam_answer1, exam_answer2," +
                        "exam_answer3,exam_answer4,exam_org_answer) values('" + exam_num1.Text + "','" + num1_1.Text + "','" +
                        num1_2.Text + "','" + num1_3.Text + "','" + num1_4.Text + "','" + int.Parse(comboBox1.SelectedItem.ToString()) + "')", conn);
                    msc1.ExecuteNonQuery();

                    MySqlCommand msc2 = new MySqlCommand("insert into exam_submit(exam_problem, exam_answer1, exam_answer2," +
                        "exam_answer3,exam_answer4,exam_org_answer) values('" + exam_num2.Text + "','" + num2_1.Text + "','" +
                        num2_2.Text + "','" + num2_3.Text + "','" + num2_4.Text + "','" + int.Parse(comboBox2.SelectedItem.ToString()) + "')", conn);
                    msc2.ExecuteNonQuery();

                    MySqlCommand msc3 = new MySqlCommand("insert into exam_submit(exam_problem, exam_answer1, exam_answer2," +
                        "exam_answer3,exam_answer4,exam_org_answer) values('" + exam_num3.Text + "','" + num3_1.Text + "','" +
                        num3_2.Text + "','" + num3_3.Text + "','" + num3_4.Text + "','" + int.Parse(comboBox3.SelectedItem.ToString()) + "')", conn);
                    msc3.ExecuteNonQuery();

                    MySqlCommand msc4 = new MySqlCommand("insert into exam_submit(exam_problem, exam_answer1, exam_answer2," +
                       "exam_answer3,exam_answer4,exam_org_answer) values('" + exam_num4.Text + "','" + num4_1.Text + "','" +
                       num4_2.Text + "','" + num4_3.Text + "','" + num4_4.Text + "','" + int.Parse(comboBox4.SelectedItem.ToString()) + "')", conn);
                    msc4.ExecuteNonQuery();

                    MySqlCommand msc5 = new MySqlCommand("insert into exam_submit(exam_problem, exam_answer1, exam_answer2," +
                       "exam_answer3,exam_answer4,exam_org_answer) values('" + exam_num5.Text + "','" + num5_1.Text + "','" +
                       num5_2.Text + "','" + num5_3.Text + "','" + num5_4.Text + "','" + int.Parse(comboBox7.SelectedItem.ToString()) + "')", conn);
                    msc5.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("모든 데이터를 입력해주세요.");
            }


        }

        private void delete_data()
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            string query_del = "delete from exam.exam_submit where exam_num";
            MySqlCommand command = new MySqlCommand(query_del, conn);
            MySqlDataReader myreader;
            try//예외 처리
            {
                conn.Open();

                myreader = command.ExecuteReader();
                MessageBox.Show("데이터가 삭제되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            submit_data();
            MessageBox.Show("문제가 제출되었습니다.");
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Close();
        }

        private void button_road_Click(object sender, EventArgs e)
        {
            int flag = 0;
            List<TextBox> textBoxes_exam = new List<TextBox>() { exam_num1, exam_num2, exam_num3, exam_num4, exam_num5 };
            List<TextBox> textBoxes_1 = new List<TextBox>() { num1_1, num2_1, num3_1, num4_1, num5_1 };
            List<TextBox> textBoxes_2 = new List<TextBox>() { num1_2, num2_2, num3_2, num4_2, num5_2 };
            List<TextBox> textBoxes_3 = new List<TextBox>() { num1_3, num2_3, num3_3, num4_3, num5_3 };
            List<TextBox> textBoxes_4 = new List<TextBox>() { num1_4, num2_4, num3_4, num4_4, num5_4 };
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Conn))
                {
                    conn.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM exam_submit");

                    MySqlCommand command = new MySqlCommand(selectQuery, conn);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        textBoxes_exam[flag].Text = table["exam_problem"].ToString();
                        textBoxes_1[flag].Text = table["exam_answer1"].ToString();
                        textBoxes_2[flag].Text = table["exam_answer2"].ToString();
                        textBoxes_3[flag].Text = table["exam_answer3"].ToString();
                        textBoxes_4[flag].Text = table["exam_answer4"].ToString();
                        flag++;
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            delete_data();

        }
        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                delete_data();
                submit_data();
            }
            catch (Exception exc)
            {
                MessageBox.Show("모든 데이터를 입력해주세요.");
                MessageBox.Show("데이터가 수정되었습니다.");
            }

        }
    }
}
