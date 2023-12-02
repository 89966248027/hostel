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
    public partial class reservation : Form
    {
        List<DateTime> datas = new List<DateTime>();
        int idquest;
        public reservation()
        {
            InitializeComponent();

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

            //вывод занятых дат
            int number = (int)box_number.Value;
            busy_dates(number);
        }

        //Назад
        private void bt_back_Click(object sender, EventArgs e)
        {
            Hide();
            loginEmployer a = new loginEmployer();
            string b = a.set_login(1);
            a.open_num(b);
            Close();
        }

        //Выбор занятых дат
        private void busy_dates(int num)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            datas.Clear();
            //отправили запрос на получения дат
            string sql = "SELECT idnumber, data_start, data_stop FROM reservation";
            MySqlCommand comm = new MySqlCommand(sql, connection);
            MySqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                if(int.Parse(read[0].ToString()) == num)
                {
                    DateTime date1 = DateTime.Parse(read[1].ToString());
                    DateTime date2 = DateTime.Parse(read[2].ToString());
                    while (date1 != date2)
                    {
                        datas.Add(date1);
                        date1 = date1.AddDays(1);
                    }
                    datas.Add(date2);
                }
            }
            read.Close();
            connection.Close();

            monthCalendar1.BoldedDates = datas.ToArray();
        }

        private void box_number_ValueChanged(object sender, EventArgs e)
        {
            busy_dates((int)box_number.Value);
        }
        //выбор дат бронирования
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            box_data_from.Value = monthCalendar1.SelectionStart.Date;
            box_data_to.Value = monthCalendar1.SelectionEnd.Date;
        }

        private void box_data_to_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = box_data_from.Value.Date;
            monthCalendar1.SelectionEnd = box_data_to.Value.Date;
        }
        //проверка выбранных дат
        private bool check_date()
        {
            bool flag = true;
            DateTime d = box_data_from.Value.Date;
            while (d != box_data_to.Value.Date)
            {
                for(int i = 0; i < datas.Count; i++)
                {
                    if (d == datas[i])
                    {
                        flag = false;
                        break;
                    }
                }
                d = d.AddDays(1);
            }
            return flag;
        }
        //оплатить
        private void bt_pay_Click(object sender, EventArgs e)
        {
            if(box_data_from.Value.Date <= box_data_to.Value.Date &&
                box_quest.Text != "")
            {
                string l_name = box_quest.Text;
                l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
                l_name = l_name.Substring(l_name.IndexOf(" ") + 1, l_name.Length - (l_name.IndexOf(" ") + 1));
                int idquest = int.Parse(l_name);
                bool f = check_date();
                if(f)
                {
                    //узнаем сумму за сутки
                    MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
                    connection.Open();

                    int idtype = 0;
                    string sql = "SELECT idnumber, idtype FROM number";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if((int)box_number.Value == int.Parse(reader[0].ToString()))
                        {
                            idtype = int.Parse(reader[1].ToString());
                        }
                    }
                    reader.Close();

                    int price = 0;
                    string sql1 = "SELECT idtype, price FROM type";
                    MySqlCommand command1 = new MySqlCommand(sql1, connection);
                    MySqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        if (idtype == int.Parse(reader1[0].ToString()))
                        {
                            price = int.Parse(reader1[1].ToString());
                        }
                    }
                    reader1.Close();

                    //добавляем бронь
                    //отправили запрос на получения кол-ва броней
                    int c = 1;
                    string count = "SELECT idreservation FROM reservation";
                    MySqlCommand comm1 = new MySqlCommand(count, connection);
                    MySqlDataReader read_count = comm1.ExecuteReader();
                    while (read_count.Read())
                        c++;
                    read_count.Close();

                    string add = "insert into `reservation` (`idreservation`, `idquest`, `idnumber`, `data_start`, `data_stop`, `idpay`) VALUES ('" + c + "', '" + idquest + "', '" + (int)box_number.Value + "', '" + box_data_from.Text + "', '" + box_data_to.Text + "', '+')";
                    MySqlCommand comm = new MySqlCommand(add, connection);
                    comm.ExecuteNonQuery();
                    connection.Close();

                    //кол-во дней
                    int day = 0;
                    DateTime d = box_data_from.Value.Date;
                    while (d != box_data_to.Value.Date)
                    {
                        day++;
                        d = d.AddDays(1);
                    }
                    day++;

                    MessageBox.Show("К оплате " + day * price + " рублей.", "Успешно!");
                }
                else
                {
                    MessageBox.Show("Выберите другие даты брониорвания");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка!");
            }
        }
        //добавить постояльца
        private void bt_addQuest_Click(object sender, EventArgs e)
        {
            Hide();
            set_quest f_q = new set_quest();
            f_q.ShowDialog();
            Close();
        }

        private void box_quest_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
