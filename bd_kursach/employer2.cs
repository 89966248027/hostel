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
    public partial class employer2 : Form
    {
        public employer2()
        {
            InitializeComponent();
            start();
        }
        
        private void start()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            ////отправили запрос на получения кол-ва должностей сотрудников
            //int p = 0;
            //string count_p = "SELECT idpost FROM post";
            //MySqlCommand comm1 = new MySqlCommand(count_p, connection);
            //MySqlDataReader read_count_p = comm1.ExecuteReader();
            //while (read_count_p.Read())
            //    p++;
            //read_count_p.Close();

            //string[] post = new string[p];//должности

            ////отправили запрос на получение должностей сотрудников
            //string sql1 = "SELECT idpost, postname, idpost FROM post";
            //MySqlCommand command1 = new MySqlCommand(sql1, connection);
            //MySqlDataReader reader1 = command1.ExecuteReader();
            //while (reader1.Read())
            //{
            //    post[(int)reader1[0] - 1] = reader1[1].ToString();
            //}
            //reader1.Close();
            //connection.Close();

            ////вывод список должностей сотрудников
            //box_post.Items.Clear();
            //box_post.Items.AddRange(post);

            box_birthday.Value = DateTime.Today.AddYears(-18);
            box_birthday.MaxDate = DateTime.Today.AddYears(-18);
        }
        //кнопка регистрации
        private void bt_set_Click(object sender, EventArgs e)
        {
            if (box_lastname.Text != "" &&
                box_firstname.Text != "" &&
                box_status.Text != "" &&
                box_phone.Text.Length == 11 &&
                box_post.Text != "" &&
                box_login.Text.Length >= 8 &&
                box_password.Text.Length >= 8)
            {
                MySqlConnection connection = new MySqlConnection("server=192.168.1.40;user=root;database=hostel;password=Katia_223;");
                connection.Open();

                //отправили запрос на получение кол-ва сотрудников
                string sql = "SELECT idemployer FROM employer";
                int count = 1;
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                reader.Close();

                ////отправили запрос на получение id должности
                //string sql1 = "SELECT idpost, postname FROM post";
                int id_post = 1;
                //MySqlCommand command1 = new MySqlCommand(sql1, connection);
                //MySqlDataReader reader1 = command1.ExecuteReader();
                //while (reader1.Read())
                //{
                //    if (box_post.Text == reader1[1].ToString())
                //        id_post = (int)reader1[0];
                //}
                //reader1.Close();

                //отправили запрос на получение кол-ва логинов
                string sql2 = "SELECT idauthorization FROM authorization";
                int count_log = 1;
                MySqlCommand command2 = new MySqlCommand(sql2, connection);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    count_log++;
                }
                reader2.Close();

                string date = box_birthday.Value.Year.ToString() + "-" + box_birthday.Value.Month.ToString() + "-" + box_birthday.Value.Day.ToString();
                
                //добавляем
                string add = "insert into `employer` (`idemployer`, `idhostels`, `employer_lastname`, `employer_firstname`, `employer_birthday`, `employer_status`, `employercol`, `idpost`, `idschedule`) VALUES ('" + count + "', '1', '" + box_lastname.Text + "', '" + box_firstname.Text + "', '" + date + "', 'работает', '" + box_phone.Text + "', '" + id_post + "', '0')";
                string add1 = "insert into `authorization` (`idauthorization`, `idemployer`, `login`, `password_1`, `idpost`) VALUES ('" + count + "', '" + count + "', '" + box_login.Text + "', '" + box_password.Text + "', '" + id_post + "')";
                  
                MySqlCommand comm1 = new MySqlCommand(add1, connection);
                comm1.ExecuteNonQuery();
                MySqlCommand comm = new MySqlCommand(add, connection);
                comm.ExecuteNonQuery();
                connection.Close();

                string login = box_login.Text;
                string password = box_password.Text;
                loginEmployer a = new loginEmployer();
                a.get_login(login, password);
                a.open_menu(login, password);
                Close();
            }
            else
            {
                if (box_lastname.Text == "" ||
                box_firstname.Text == "" ||
                box_status.Text == "" ||
                box_phone.Text == "" ||
                box_post.Text == "" ||
                box_login.Text == "" ||
                box_password.Text == "")
                {
                    MessageBox.Show("Заполните все поля", "Ошибка");
                }
                else
                {
                    if (box_phone.Text.Length != 11)
                        MessageBox.Show("Проверьте номер телефона", "Ошибка");
                    else
                    {
                        MessageBox.Show("Логин и пароль должны содержать не менее 8 символов", "Ошибка");
                    }
                }
            }
        }
        //ввод в строку определенных символов
        private void key_press(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            if (!(i == 8 || i == 127 || (i >= 1040 && i <= 1105)))
            {
                /* запрет ввода с клавиатуры, кроме Backspace, Delete и букв*/
                e.Handled = true;
            }
        }
        //ввод в строку определенных символов
        private void key_press1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            if (!(i == 8 || (i >= 48 && i <= 57) || i == 127))
            {
                /* запрет ввода с клавиатуры, кроме Backspace, Delete и цифр*/
                e.Handled = true;
            }
        }
        //ввод в строку определенных символов
        private void key_press2(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            e.Handled = true;
        }
        //кнопка Войти
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form1 f_1 = new Form1();
            f_1.ShowDialog();
            Close();
        }
    }
}
