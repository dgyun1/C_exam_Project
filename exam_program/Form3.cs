using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;



namespace exam_program
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1;Database=exam;Uid=root;Pwd=0000;");
            // SQL 서버와 연결
            // Server = localhost : 로컬 호스트(내 컴퓨터) 서버와 연결

            MySqlCommand command = new MySqlCommand();
            // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
            // MySQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
            // 위 정보를 command 변수에 저장한다.

            command.Connection = connection; // DB에 연결
            
            int login_status = 0;
            // 로그인 상태 변수 선언, 비로그인 상태는 0

            string login = txtbox_name.Text;
            // 문자열 loginid 변수는 txtbox_id의 텍스트 값

            command.CommandText = "select name,id FRom member"; // 쿼리문 작성
           
            connection.Open();
            // SQL 서버 연결

            MySqlDataReader member = command.ExecuteReader(); // 쿼리문 실행

            while (member.Read()) // 전부 다 읽어 옴
            {
             
                if (login == (string)member["name"])
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

                
                    
                MessageBox.Show("이름 : " + tempName + "\n" + "아이디 : " + tempID);

                }
                else 
                {
                    MessageBox.Show("입력하신 회원정보가 없습니다.");

                }
            // MySQL 서버 연결 종료
            connection.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 showform6 = new Form4();
            showform6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
