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
    public partial class set_emloyer : Form
    {
        public set_emloyer()
        {
            InitializeComponent();
            start();
        }
        //заполнение сотрудников
        private void start()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получения кол-ва сотрудников
            int c = 0;
            string count = "SELECT idemployer FROM employer";
            MySqlCommand comm = new MySqlCommand(count, connection);
            MySqlDataReader read_count = comm.ExecuteReader();
            while (read_count.Read())
                c++;
            read_count.Close();

            string[] lastname = new string[c];//фамилии

            //отправили запрос на получение фамилий сотрудников
            string sql = "SELECT idemployer, employer_lastname, idpost FROM employer";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            int k = 0;
            while (reader.Read())
            {
                lastname[k] = reader[1].ToString() + " " + reader[0].ToString();
                k++;
            }
            reader.Close();

            //вывод список сотрудников
            box_empl.Items.Clear();
            box_empl.Items.AddRange(lastname);

            //отправили запрос на получения кол-ва должностей сотрудников
            int p = 0;
            string count_p = "SELECT idpost FROM post";
            MySqlCommand comm1 = new MySqlCommand(count_p, connection);
            MySqlDataReader read_count_p = comm1.ExecuteReader();
            while (read_count_p.Read())
                p++;
            read_count_p.Close();

            string[] post = new string[p];//должности

            //отправили запрос на получение должностей сотрудников
            string sql1 = "SELECT idpost, postname, idpost FROM post";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                post[(int)reader1[0] - 1] = reader1[1].ToString();
            }
            reader1.Close();
            connection.Close();

            //вывод список сотрудников
            box_post.Items.Clear();
            box_post.Items.AddRange(post);

            box_birthday.Value = DateTime.Today.AddYears(-18);
            box_birthday.MaxDate = DateTime.Today.AddYears(-18);
        }
        //Очистить
        private void bt_clear_Click(object sender, EventArgs e)
        {
            box_empl.Text = "";
            box_lastname.Text = "";
            box_firstname.Text = "";
            box_birthday.Value = DateTime.Today.AddYears(-18);
            box_birthday.MaxDate = DateTime.Today.AddYears(-18);
            box_status.Text = "работает";
            box_status.Items.Clear();
            box_phone.Text = "";
            box_post.Text = "";
            box_login.Text = "";
            box_password.Text = "";
            bt_set.Text = "Добавить";
            bt_delete.Visible = false;

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
        //вывод данных на форму
        private void box_empl_SelectedIndexChanged(object sender, EventArgs e)
        {
            box_status.Items.Clear();
            string[] mas = { "работает", "в отпуске", "в декрете", "на больничном" };
            box_status.Items.AddRange(mas);
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            string post = "";
            //считываем id сотрудника
            string l_name = box_empl.Text;
            l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
            int empl = int.Parse(l_name);

            //отправили запрос на получение данных сотрудников
            string sql = "SELECT idemployer, employer_lastname, employer_firstname, employer_birthday, employer_status, employercol, idpost FROM employer";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(empl == (int)reader[0])
                {
                    box_lastname.Text = reader[1].ToString();
                    box_firstname.Text = reader[2].ToString();
                    box_birthday.Value = DateTime.Parse(reader[3].ToString());
                    box_status.Text = reader[4].ToString();
                    box_phone.Text = reader[5].ToString();
                    post = reader[6].ToString();
                }
            }
            reader.Close();

            //отправили запрос на получение должности
            string sql1 = "SELECT idpost, postname FROM post";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                if (post == reader1[0].ToString())
                    box_post.Text = reader1[1].ToString();
            }
            reader1.Close();

            //отправили запрос на получение логина и пароля
            string sql2 = "SELECT idemployer, login, password_1 FROM authorization";
            MySqlCommand command2 = new MySqlCommand(sql2, connection);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                if (empl == (int)reader2[0])
                {
                    box_login.Text = reader2[1].ToString();
                    box_password.Text = reader2[2].ToString();
                }
            }
            reader2.Close();
            connection.Close();


            //Меняем кнопки
            bt_set.Text = "Изменить";
            bt_delete.Visible = true;
        }
        //добавить (изменить)
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
                MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
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

                //отправили запрос на получение id должности
                string sql1 = "SELECT idpost, postname FROM post";
                int id_post = 0;
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    if (box_post.Text == reader1[1].ToString())
                        id_post = (int)reader1[0];
                }
                reader1.Close();

                string date = box_birthday.Value.Year.ToString() + "-" + box_birthday.Value.Month.ToString() + "-" + box_birthday.Value.Day.ToString();
                string add = "";
                string add1 = "";

                if (bt_set.Text == "Изменить")
                {
                    //считываем id сотрудника
                    string l_name = box_empl.Text;
                    l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
                    int id_empl = int.Parse(l_name);

                    //изменяем
                    add = "update `employer` set `employer_lastname` = '" + box_lastname.Text + "', `employer_firstname` = '" + box_firstname.Text + "', `employer_birthday` = '" + date + "', `employer_status` = '" + box_status.Text + "', `employercol` = '" + box_phone.Text + "', `idpost` = '" + id_post + "' where(`idemployer` = '" + id_empl + "')";
                    add1 = "update `authorization` set `login` = '" + box_login.Text + "', `password_1` = '" + box_password.Text + "', `idpost` = '" + id_post + "' where(`idemployer` = '" + id_empl + "')";
                }
                else
                {
                    //добавляем
                    add = "insert into `employer` (`idemployer`, `idhostels`, `employer_lastname`, `employer_firstname`, `employer_birthday`, `employer_status`, `employercol`, `idpost`, `idschedule`) VALUES ('" + count + "', '1', '" + box_lastname.Text + "', '" + box_firstname.Text + "', '" + date + "', '" + box_status.Text + "', '" + box_phone.Text + "', '" + id_post + "', '0')";
                    add1 = "insert into `authorization` (`idauthorization`, `idemployer`, `login`, `password_1`, `idpost`) VALUES ('" + count + "', '" + count + "', '" + box_login.Text + "', '" + box_password.Text + "', '" + id_post + "')";
                    bt_set.Text = "Изменить";
                    bt_delete.Visible = true;
                }

                MySqlCommand comm1 = new MySqlCommand(add1, connection);
                comm1.ExecuteNonQuery();
                MySqlCommand comm = new MySqlCommand(add, connection);
                comm.ExecuteNonQuery();
                connection.Close();

                start();

                employer f_employer = new employer();
                f_employer.Show();
                f_employer.tabControl1.SelectedIndex = 1;
                f_employer.box();
            }
            else
            {
                if(box_lastname.Text == "" ||
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
                    if(box_phone.Text.Length != 11)
                        MessageBox.Show("Проверьте номер телефона", "Ошибка");
                    else
                    {
                        MessageBox.Show("Логин и пароль должны содержать не менее 8 символов", "Ошибка");
                    }
                }
            }
        }
        //удалить
        private void bt_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //считываем id сотрудника
            string l_name = box_empl.Text;
            l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
            int id_empl = int.Parse(l_name);

            string add = "DELETE FROM `employer` WHERE (`idemployer` = '" + id_empl + "')";
            MySqlCommand comm = new MySqlCommand(add, connection);
            comm.ExecuteNonQuery();
            string add1 = "DELETE FROM `authorization` WHERE (`idemployer` = '" + id_empl + "')";
            MySqlCommand comm1 = new MySqlCommand(add1, connection);
            comm1.ExecuteNonQuery();
            string add2 = "DELETE FROM `schedule` WHERE (`idemployer` = '" + id_empl + "')";
            MySqlCommand comm2 = new MySqlCommand(add2, connection);
            comm2.ExecuteNonQuery();
            connection.Close();

            //очистить
            box_empl.Text = "";
            box_lastname.Text = "";
            box_firstname.Text = "";
            box_birthday.Value = DateTime.Today.AddYears(-18);
            box_birthday.MaxDate = DateTime.Today.AddYears(-18);
            box_status.Text = "";
            box_phone.Text = "";
            box_post.Text = "";
            box_login.Text = "";
            box_password.Text = "";
            bt_set.Text = "Добавить";
            bt_delete.Visible = false;

            start();

            employer f_employer = new employer();
            f_employer.Show();
            f_employer.tabControl1.SelectedIndex = 1;
            f_employer.box();
        }
    }
}
