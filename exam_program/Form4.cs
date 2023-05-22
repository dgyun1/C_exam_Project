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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void select_pwd_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=exam;Uid=root;Pwd=0000;");
            // SQL 서버와 연결
            // Server = localhost : 로컬 호스트(내 컴퓨터) 서버와 연결

            MySqlCommand command = new MySqlCommand();
            // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
            // MySQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
            // 위 정보를 command 변수에 저장한다.

            command.Connection = connection; // DB에 연결

            int login_status = 0;
            // 로그인 상태 변수 선언, 비로그인 상태는 0

            command.CommandText = "SELECT * FROM Member "; // 쿼리문 작성

            connection.Open();
            // SQL 서버 연결

            MySqlDataReader member = command.ExecuteReader(); // 쿼리문 실행


            string login = txtbox_name.Text;
            // 문자열 login 변수는 txtbox_name의 텍스트값
            string loginid = txtbox_id.Text;
            // 문자열 loginid 변수는 txtbox_id의 텍스트 값

            while (member.Read()) // 전부 다 읽어 옴

            {

                if (login == (string)member["name"] && loginid == (string)member["id"])
                {
                    login_status = 1;
                    // 해당 변수 상태를 1로 바꾼다.
                    break;
                }

            }
            if (login_status == 1)
            {
                
                // 여기서 부터 원하는 데이터를 받아와서 처리
                string tempName = (string)member["name"];
               tempName = txtbox_name.Text;
                string tempID = (string)member["id"];
                tempID= txtbox_id.Text;
                string tempPwd = (string)member["pwd"];
                string tempPWD = command.CommandText;
                command.CommandText = "select *from member name,id,pwd"; 

                MessageBox.Show("이름 : " + tempName + "\n" + "아이디 : " + tempID + "\n" + "비밀번호 : " + tempPwd);

            }
            else
            {
                MessageBox.Show("입력하신 회원정보가 없습니다.");

            }
            // MySQL 서버 연결 종료
            connection.Close();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1= new Form1();
            form1.ShowDialog();
        }
    }
}
