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
    public partial class Form9 : Form
    {
        /*string Conn = "Server=127.0.0.1;Database=exam;Uid=root;Pwd=0000;";
        List<int> answer_org = new List<int>();

        int flag = 0;*/
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
