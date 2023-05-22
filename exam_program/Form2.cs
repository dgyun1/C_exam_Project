using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // MySQL 사용을 위한 참조문
using Org.BouncyCastle.Crypto.Tls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace exam_program
{
    public partial class Form2 : Form
    {
        bool check_flag = false;
        string id = "ABC";
        string pw = "123";
        public Form2()
        {
            InitializeComponent();
           
        }

        private void btn_newmember_Click(object sender, EventArgs e)
        {
            if (check_flag == false)
            {
                MessageBox.Show("아이디 중복검사를 확인해주세요");
            }
            else
            {

                try
                {

                    MySqlConnection connection = new MySqlConnection("Server= 127.0.0.1;Database=exam;Uid=root;Pwd=0000;");
                    // SQL 서버와 연결
                    // Server = localhost : 로컬 호스트(내 컴퓨터) 서버와 연결

                    connection.Open();
                    // SQL 서버 연결

                    string insertQuery = "INSERT INTO Member (name, id, pwd, flag) VALUES ('" + txtbox_name.Text + "', '" + txtbox_id.Text + "', '" + txtbox_pwd.Text + "',0);";
                    // 문자열 inserTquery 변수 선언
                    // MySQL에 전송할 명령어를 입력한다.
                    // 실제로 MySQL에 전송될 명령어는 "" 사이의 값
                    // dbtest 스키마의 Member  테이블에 값을 추가하기 위한 변수

                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
                    // MySQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
                    // 위 정보를 command 변수에 저장한다.

                    if (txtbox_id.Text == id && txtbox_pwd.Text == pw)
                    {
                        MessageBox.Show("출제자 계정으로는 회원가입 할 수 없습니다.");

                    }
                    else if (txtbox_id.Text == string.Empty || txtbox_name.Text == string.Empty || txtbox_pwd.Text == string.Empty || txtbox_pwd2.Text == string.Empty)
                    {
                        MessageBox.Show("회원정보를 모두 입력하세요");
                    }
                    else if (txtbox_pwd.Text != txtbox_pwd2.Text)
                    {
                        MessageBox.Show("비밀번호 입력이 일치하지 않습니다.");
                    }
                    else if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(txtbox_name.Text + "님 회원가입 완료, 사용할 아이디는 " + txtbox_id.Text + "입니다.");
                        // 정상 회원가입 안내 메시지박스를 띄운다.
                        connection.Close();
                        // SQL 연결을 끊는다.
                        Close();
                        // Form2를 닫는다. (Form1의 로그인 창으로 돌아가기 위함)
                    }

                    else
                    // 아니라면,
                    {
                        MessageBox.Show("비정상 입력 정보, 재확인 요망");
                        // 오류 메시지 박스를 띄운다.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // 예외값 발생 시 해당 정보와 관련된 메시지 박스를 띄운다.
                }
                this.Hide();
                Form1 form1= new Form1();
                form1.ShowDialog();
            }
        }


        // btn_check 버튼 클릭 시
        private void btn_check_Click(object sender, EventArgs e)
        {
            check_flag = true;

            // MySQL 연결을 위한 connection 객체 생성
            // MySqlConnection 클래스 괄호 안의 내용은, 본인의 MySQL 서버 상황에 맞는 값을 삽입 요망
            MySqlConnection connection = new MySqlConnection("Server =127.0.0.1;Database=exam;Uid=root;Pwd=0000;");

            // 앞서 생성한 connection 객체를 통해 MySQL 서버 연결 유지
            connection.Open();

            // MySQL로 보낼 쿼리문인 문자열 Query 변수 선언
            // dbtest 테이블에 txtbox_name 이름으로 검색했을 때, 나오는 결과값 개수를 cnt 변수로 세도록 한다.
            string Query = "SELECT *, COUNT(*) as cnt FROM exam.Member WHERE id='" + txtbox_id.Text + "';";

            // MySQL로 쿼리문을 보내기 위해 command 객체 생성 후 쿼리문 전달
            MySqlCommand command = new MySqlCommand(Query,connection);

            // 받아온 결과값을 reader 객체에 저장
            MySqlDataReader reader = command.ExecuteReader();
                 
            try
            {
                while (reader.Read())
                {
                    if (txtbox_id.Text == id)
                    {
                        MessageBox.Show("이미 등록된 아이디 입니다.");
                    }
                    else if (txtbox_id.Text == string.Empty)
                    {
                        MessageBox.Show("아이디를 입력하세요");

                    }

                    // 받아온 reader 객체의 값 중, cnt 칼럼의 값이 0이 아니라면
                    // -> cnt 칼럼의 값이 0이 아니란 의미는?
                    // --> txtbox_name에 입력된 텍스트값이 이미 Member 테이블에 기등록되어 있다는 뜻
                    else if (reader["cnt"].ToString() != "0")
                    {
                        // 기등록된 정보입니다. 메시지 박스 출력
                        MessageBox.Show("이미 등록된 아이디 입니다.");
                    }
                   
                    // 받아온  reader 객체의 값 중, cnt 칼럼의 값이 0이 맞다면
                    // -> cnt 칼럼의 값이 0이란 의미는?
                    // --> txtbox_name에 입렫된 텍스트값이 Member 테이블에 미등록되어 있다는 뜻
                    else  
                    {
                        // 등록되지 않은 정보입니다. 메시지 박스 출력
                        MessageBox.Show("사용 가능한 아이디 입니다.");
                    }
                    
                }
                
               


                
            }
            
            catch (Exception ex)
            {
                // 오류 발생 시 오류로그 출력
                MessageBox.Show("오류로그: "+ex.Message.ToString());
            }
            // MySQL 서버 연결 종료
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
