using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bd_kursach
{
    class loginEmployer
    {
        public static string l, p;
        public static int num;
        public static int idquest;

        //передать номер и id постояльца
        public void set_num(int n, int id)
        {
            num = n;
            idquest = id;
        }
        //забрать номер или id постояльца
        public int get_num(int type)
        {
            if (type == 1)
                return num;
            else return idquest;
        }

        //передать логин и пароль
        public void get_login(string login, string password)
        {
            l = login;
            p = password;
        }
        //забрать логин и пароль
        public string set_login(int type)
        {
            if (type == 1)
                return l;
            else return p;
        }
        //открыть номера
        public void open_num(string login)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос
            string sql = "SELECT login, idpost FROM authorization";
            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                if (login == reader[0].ToString())
                {
                    i = int.Parse(reader[1].ToString());
                    hostelNumber f_num = new hostelNumber();
                    if (i > 1)//не директор
                    {
                        f_num.bt_number.Visible = false;
                    }
                    else
                    {
                        f_num.bt_number.Visible = true;
                    }
                    f_num.ShowDialog();
                }
            }
            reader.Close();
            connection.Close();
        }
        //открыть сотрудники
        public void open_empl(string login)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос
            string sql = "SELECT login, idpost FROM authorization";
            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                if (login == reader[0].ToString())
                {
                    i = int.Parse(reader[1].ToString());
                    employer f_empl = new employer();
                    if (i > 1)//не директор
                    {
                        f_empl.tabControl1.TabPages.RemoveAt(1);
                        f_empl.bt_sched.Visible = false;
                    }
                    else
                    {
                        f_empl.employers.Visible = true;
                        f_empl.bt_sched.Visible = true;
                    }
                    f_empl.ShowDialog();
                }
            }
            reader.Close();
            connection.Close();
        }

        //открыть меню
        public void open_menu(string login, string password)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();
            menu f_menu = new menu();
            string sql1 = "SELECT name, adress, phone, email FROM help";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);

            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                f_menu.tb_hostelname.Text = reader1[0].ToString();
                f_menu.tb_hosteladress.Text = reader1[1].ToString();
                f_menu.tb_hostelphone.Text = reader1[2].ToString();
                f_menu.tb_hostelemail.Text = reader1[3].ToString();
            }
            reader1.Close();

            //отправили запрос
            string sql = "SELECT login, password_1, idpost FROM authorization";
            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                if (login == reader[0].ToString())
                {
                    if (password == reader[1].ToString())
                    {
                        i = int.Parse(reader[2].ToString());
                        
                        if (i >= 1)//директор
                        {
                            if (i >= 2)//администратор
                            {
                                f_menu.bt_hostel.Visible = false;
                                if (i >= 3)//уборщик
                                {
                                    f_menu.guest.Enabled = false;
                                    f_menu.label3.Visible = false;
                                    if (i > 3)//другие
                                    {
                                        f_menu.number.Enabled = false;
                                        f_menu.label4.Visible = false;
                                    }
                                }
                            }
                            f_menu.ShowDialog();
                        }
                    }
                }
            }
            if (i == 0)
                MessageBox.Show("Ошибка авторизации!\nПроверьте правильность логина и пароля", "Ошибка!");
            reader.Close();
            connection.Close();
        }
    }
}
