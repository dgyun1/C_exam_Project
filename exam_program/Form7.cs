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
    public partial class Form7 : Form
    {
        int i = 0;
        public Form7()
        {
            InitializeComponent();
            label1.Text = Program.name + " 님 환영합니다";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.flag == 1)
            {
                MessageBox.Show("시험에 이미 응시하여 성적확인만 가능합니다");
            }
            else
            {
                this.Hide();
                Form8 form8 = new Form8();
                form8.ShowDialog();
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Program.flag == 0)
            {
                MessageBox.Show("시험에 응시하지 않아 성적을 볼수 없습니다.");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection("Server =127.0.0.1; Database=exam; Uid=root; Pwd=0000;");
                connection.Open();
                string selectQuery1 = "select score,answer1,answer2,answer3,answer4,answer5 FRom score_data WHERE name ='" + Program.name + "' ";
                MySqlCommand Selectcommand1 = new MySqlCommand(selectQuery1, connection); // 여기부터ㅓ`~~~
                MySqlDataReader userAccount1 = Selectcommand1.ExecuteReader();
                
                while (userAccount1.Read())
                {
                    Program.score = userAccount1.GetInt32("score");
                    Program.list[0] = userAccount1.GetInt32("answer1");
                    Program.list[1] = userAccount1.GetInt32("answer2");
                    Program.list[2] = userAccount1.GetInt32("answer3");
                    Program.list[3] = userAccount1.GetInt32("answer4");
                    Program.list[4] = userAccount1.GetInt32("answer5");
                }
                connection.Close();
                this.Hide();
                Form10 form10 = new Form10();
                form10.ShowDialog();
                this.Close();
            }
        }
    }
}
