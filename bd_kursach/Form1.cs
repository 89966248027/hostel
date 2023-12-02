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

namespace bd_kursach
{
    public partial class Form1 : Form
    {
        public static string l;
        public Form1()
        {
            InitializeComponent();
        }
        //кнопка "Войти"
        private void bt_start_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_password.Text;
            loginEmployer a = new loginEmployer();
            a.get_login(login, password);
            a.open_menu(login, password);
            Close();
        }
        //кнопка регистрации
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            employer2 f_1 = new employer2();
            f_1.ShowDialog();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
