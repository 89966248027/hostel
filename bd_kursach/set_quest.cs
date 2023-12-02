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
    public partial class set_quest : Form
    {
        string name_quest;
        public set_quest()
        {
            InitializeComponent();
            start();
        }
        private void start()
        {
            //вывод постояльцев
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получения кол-ва постояльцев
            int c = 0;
            string count = "SELECT idquest FROM quest";
            MySqlCommand comm = new MySqlCommand(count, connection);
            MySqlDataReader read_count = comm.ExecuteReader();
            while (read_count.Read())
                c++;
            read_count.Close();

            string[] name = new string[c];//имена

            //отправили запрос на получение фамилий и имен постояльцев
            string sql = "SELECT idquest, quest_lastname, quest_firstname FROM quest";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name[(int)reader[0] - 1] = reader[1].ToString() + " " + reader[2].ToString() + " " + reader[0].ToString();
            }
            reader.Close();
            connection.Close();

            //вывод список постояльцев
            box_quest.Items.Clear();
            box_quest.Items.AddRange(name);
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
        //Очистить
        private void bt_clear_Click(object sender, EventArgs e)
        {
            box_quest.Text = "";
            box_lastname.Text = "";
            box_firstname.Text = "";
            box_birthday.Value = DateTime.Today.AddYears(-18);
            box_birthday.MaxDate = DateTime.Today.AddYears(-18);
            box_phone.Text = "";
            bt_set.Text = "Добавить";
            bt_delete.Visible = false;
        }
        //Удалить
        private void bt_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //считываем id сотрудника
            string l_name = box_quest.Text;
            l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
            l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
            int id_quest = int.Parse(l_name);

            string add = "DELETE FROM `quest` WHERE (`idquest` = '" + id_quest + "')";
            MySqlCommand comm = new MySqlCommand(add, connection);
            comm.ExecuteNonQuery();
            string add1 = "DELETE FROM `reservation` WHERE (`idreservation` = '" + id_quest + "')";
            MySqlCommand comm1 = new MySqlCommand(add1, connection);
            comm1.ExecuteNonQuery();
            connection.Close();

            //очистить
            box_quest.Text = "";
            box_lastname.Text = "";
            box_firstname.Text = "";
            box_birthday.Value = DateTime.Today.AddYears(-18);
            box_birthday.MaxDate = DateTime.Today.AddYears(-18);
            box_phone.Text = "";
            bt_set.Text = "Добавить";
            bt_delete.Visible = false;

            start();
        }
        //добавить(изменить)
        private void bt_set_Click(object sender, EventArgs e)
        {
            if (box_lastname.Text != "" &&
                box_firstname.Text != "" &&
                box_phone.Text.Length == 11)
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
                connection.Open();

                //отправили запрос на получение кол-ва постояльцев
                string sql = "SELECT idquest FROM quest";
                int count = 1;
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                reader.Close();

                string date = box_birthday.Value.Year.ToString() + "-" + box_birthday.Value.Month.ToString() + "-" + box_birthday.Value.Day.ToString();
                string add = "";

                if (bt_set.Text == "Изменить")
                {
                    name_quest = box_quest.Text;
                    //изменяем
                    add = "update `quest` set `quest_lastname` = '" + box_lastname.Text + "', `quest_firstname` = '" + box_firstname.Text + "', `quest_birthday` = '" + date + "', `questcol` = '" + box_phone.Text + "')";    
                }
                else
                {
                    name_quest = box_lastname.Text + " " + box_firstname.Text + " " + count.ToString();
                    //добавляем
                    add = "insert into `quest` (`idquest`, `quest_lastname`, `quest_firstname`, `quest_birthday`, `questcol`) VALUES ('" + count + "', '" + box_lastname.Text + "', '" + box_firstname.Text + "', '" + date + "', '" + box_phone.Text + "')";
                    bt_set.Text = "Изменить";
                    bt_delete.Visible = true;
                }

                MySqlCommand comm = new MySqlCommand(add, connection);
                comm.ExecuteNonQuery();
                connection.Close();

                start();

                Hide();
                reservation f_reserv = new reservation();
                f_reserv.box_quest.Text = name_quest;
                f_reserv.ShowDialog();
                Close();
            }
            else
            {
                if (box_lastname.Text == "" ||
                box_firstname.Text == "" ||
                box_phone.Text == "")
                {
                    MessageBox.Show("Заполните все поля", "Ошибка");
                }
                else
                {
                    if (box_phone.Text.Length != 11)
                        MessageBox.Show("Проверьте номер телефона", "Ошибка");
                }
            }
        }
        //вывод данных на форму
        private void box_quest_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            string post = "";
            //считываем id постояльца
            string l_name = box_quest.Text;
            l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
            l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
            int quest = int.Parse(l_name);

            //отправили запрос на получение данных постояльцев
            string sql = "SELECT idquest, quest_lastname, quest_firstname, quest_birthday, questcol FROM quest";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (quest == (int)reader[0])
                {
                    box_lastname.Text = reader[1].ToString();
                    box_firstname.Text = reader[2].ToString();
                    box_birthday.Value = DateTime.Parse(reader[3].ToString());
                    box_phone.Text = reader[4].ToString();
                }
            }
            reader.Close();
            connection.Close();


            //Меняем кнопки
            bt_set.Text = "Изменить";
            bt_delete.Visible = true;
        }
    }
}
