using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // SQL 연동을 위한 using

namespace exam_program
{
    public partial class Form1 : Form
    {
             string id = "ABC";
             string pw = "123";

        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection connection = new MySqlConnection("Server =127.0.0.1; Database=exam; Uid=root; Pwd=0000;");
                // SQL 서버와 연결
                // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
                // Database = 스키마 이름
                // Uid = DB 로그인 아이디
                // Pwd = DB 로그인 비밀번호

                connection.Open();
                // SQL 서버 연결

                int login_status = 0;
                // 로그인 상태 변수 선언, 비로그인 상태는 0

                string loginid = txtbox_id.Text;
                // 문자열 loginid 변수는 txtbox_id의 텍스트 값

                string loginpwd = txtbox_pwd.Text;
                // 문자열 loginpwd 변수는 txtbox_pwd의 텍스트 값

                string selectQuery = "SELECT * FROM Member WHERE id = \'" + loginid + "\' ";
                
                // 문자열 selectQuery 변수 선언
                // MySQL에 전송할 명령어를 입력한다.
                // 실제로 MySQL에 전송될 명령어는 "" 사이의 값.
                // dbtest 스키마의 Member 테이블 값을 읽기 위해 변수 선언

                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);
                // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
                // MySQL에 selectQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
                // 위 정보를 Selectcomman 변수에 저장한다.

                MySqlDataReader userAccount = Selectcommand.ExecuteReader();
                // MySqlDataReader은 입력값을 받기 위함
                // Selectcommand 변수에 ExecuteReader() 객체를 통해 입력값을 받고,
                // 해당 정보를 userAccount 변수에 저장한다.

                while (userAccount.Read())
                    // userAccount가 Read 되고 있을 동안
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["pwd"])
                        // 만약 loginid 변수의 값이 Member 테이블 값의 id 정보와
                        // loginpwd 변수의 값이 Member 테이블 값의 pwd 정보와 일치한다면
                    {
                        login_status = 1;
                        // 해당 변수 상태를 1로 바꾼다.
                    }
                    else if (loginid != (string)userAccount["id"] && loginpwd == (string)userAccount["pwd"])
                    {
                        login_status = 2;
                    }

                    else if (loginid == (string)userAccount["id"] && loginpwd != (string)userAccount["pwd"])
                    {
                        login_status = 2;
                    }

                }
                connection.Close();
                // MySQL과 연결을 끊는다.
               

                if (txtbox_id.Text == id && txtbox_pwd.Text == pw)
                {
                    MessageBox.Show("출제자 계정으로 로그인 되었습니다.");
                    this.Hide();
                    Form5 form5 = new Form5();
                    form5.ShowDialog();
                    this.Close();
                }
                else if (login_status == 1)
                    // 만약 해당 변수 상태가 1이라면,
                {
                    connection.Open();
                    string selectQuery1 = "select name,flag FRom member WHERE id = \'" + loginid + "\' ";
                    MySqlCommand Selectcommand1 = new MySqlCommand(selectQuery1, connection); // 여기부터ㅓ`~~~
                    MySqlDataReader userAccount1 = Selectcommand1.ExecuteReader();
                    
                    while (userAccount1.Read())
                    {
                        Program.name = (string)userAccount1["name"];
                        Program.flag = (int)userAccount1["flag"];
                    }
                    connection.Close();
                    MessageBox.Show("응시자 계정으로 로그인 되었습니다.\n"+Program.name+"님 환영합니다.");
                    // 로그인 완료 메시지박스를 띄운다.
                    this.Hide();
                    Form7 form7 = new Form7();
                    form7.ShowDialog();
                    this.Close();

                }
                else if (login_status == 2)
                    
                {
                    MessageBox.Show("아이디 또는 비밀번호를 잘못 입력했습니다. \n 입력하신 내용을 다시 확인해 주세요");
                }
                
                else
                    // 아니라면,
                    MessageBox.Show("회원정보가 없습니다.");
                    // 오류 메시지 박스를 띄운다.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // 예외값 발생 시 해당 정보와 관련된 메시지 박스를 띄운다.
            }
        }

        private void btn_newmember_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
            {
                txtbox_pwd.PasswordChar = '*';
            }
            else
                txtbox_pwd.PasswordChar = default(char);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Close();
        }
    }
}
