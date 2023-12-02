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
    public partial class schedule : Form
    {
        public int mounth = 0;
        public int year = 0;
        public schedule()
        {
            InitializeComponent();
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

            string[] idempl = new string[c];//id сотрудников
            string[] lastname = new string[c];//фамилии
            string[] post = new string[c];//должности

            // отправили запрос на получение должности сотрудников
            string sql = "SELECT idemployer, employer_lastname, idpost FROM employer";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idempl[(int)reader[0] - 1] = reader[0].ToString();
                lastname[(int)reader[0] - 1] = reader[1].ToString();
                post[(int)reader[0] - 1] = reader[2].ToString();
            }
            reader.Close();

            // отправили запрос на получение фамилий сотрудников
            string sql1 = "SELECT idpost, postname FROM post";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                for (int i = 0; i < c; i++)
                {
                    if (post[i] == reader1[0].ToString())
                        lastname[i] += " (" + reader1[1].ToString() + ") " + idempl[i];
                }
            }
            reader1.Close();

            connection.Close();
            //вывод список сотрудников
            box_empl.Items.Clear();
            box_empl.Items.AddRange(lastname);

            //настройка элементов
            DateTime today = DateTime.Today;//текущая дата
            t_date_to.Value = today;
            t_date_to.Value = today;
        }

        //выводим на форму данные
        private void box_empl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //включили элементы
            t_time_from.Enabled = true;
            t_time_do.Enabled = true;
            t_date_from.Enabled = true;
            t_date_to.Enabled = true;
            t_work_day.Enabled = true;
            t_week_day.Enabled = true;
            bt_set.Enabled = true;
            bt_set.Text = "Добавить";
            bt_delete.Visible = false;
            //настроили элементы
            DateTime today = DateTime.Today;//текущая дата
            t_time_from.Value = DateTime.Parse("09:00:00");
            t_time_do.Value = DateTime.Parse("17:00:00");
            t_date_from.Value = today;
            t_date_to.Value = today;
            t_date_to.MinDate = new DateTime(1900, 01, 01);
            t_date_from.MaxDate = new DateTime(9000, 01, 01);
            t_work_day.Value = 5;
            t_week_day.Value = 2;

            //считываем id сотрудника
            string l_name = box_empl.Text;
            l_name = l_name.Substring(l_name.IndexOf(")") + 2, l_name.Length - (l_name.IndexOf(")") + 2));
            int id_empl = int.Parse(l_name);

            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получение расписания сотрудника
            string sql1 = "SELECT idemployer, time_from, time_do, data_from, data_to, work_day, weekend_day FROM schedule";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            bool flag = false;//есть ли рассписание сотрудника
            while (reader1.Read())
            {
                if(id_empl == (int)reader1[0])
                {
                    t_time_from.Value = DateTime.Parse(reader1[1].ToString());
                    t_time_do.Value = DateTime.Parse(reader1[2].ToString());
                    t_date_from.Value = DateTime.Parse(reader1[3].ToString());
                    t_date_to.Value = DateTime.Parse(reader1[4].ToString());
                    t_work_day.Value = (int)reader1[5];
                    t_week_day.Value = (int)reader1[6];
                    bt_set.Text = "Изменить";
                    bt_delete.Visible = true;
                    flag = true;
                }
            }
            reader1.Close();
            connection.Close();
            if(flag)
            {
                bt_set.Text = "Изменить";
                bt_delete.Visible = true;
            }
            else
            {
                bt_set.Text = "Добавить";
                bt_delete.Visible = false;
            }    
        }
        //добавить (изменить)
        private void bt_set_Click(object sender, EventArgs e)
        {
            //считываем id сотрудника
            string l_name = box_empl.Text;
            l_name = l_name.Substring(l_name.IndexOf(")") + 2, l_name.Length - (l_name.IndexOf(")") + 2));
            int id_empl = int.Parse(l_name);

            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получение id расписания сотрудника
            string sql1 = "SELECT idemployer, idschedule FROM schedule";
            int count = 1;
            int id_sch = 0;
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                count++;
                if (id_empl == (int)reader1[0])
                    id_sch = (int)reader1[1];
            }
            reader1.Close();

            string date_f = t_date_from.Value.Year.ToString() + "-" + t_date_from.Value.Month.ToString() + "-" + t_date_from.Value.Day.ToString();
            string date_t = t_date_to.Value.Year.ToString() + "-" + t_date_to.Value.Month.ToString() + "-" + t_date_to.Value.Day.ToString();
            string add = "";
            string add1 = "";
            if(bt_set.Text == "Добавить")
            {
                //добавляем
                add = "insert into `schedule` (`idschedule`, `idemployer`, `time_from`, `time_do`, `data_from`, `data_to`, `work_day`, `weekend_day`) VALUES ('" + count + "', '" + id_empl + "', '" + t_time_from.Text + "', '" + t_time_do.Text + "', '" + date_f + "', '" + date_t + "', '" + t_work_day.Value + "', '" + t_week_day.Value + "')";
                add1 = "update `employer` set `idschedule` = '" + count + "' where(`idemployer` = '" + id_empl + "')";
                MySqlCommand comm1 = new MySqlCommand(add1, connection);
                comm1.ExecuteNonQuery();
                bt_set.Text = "Изменить";
                bt_delete.Visible = true;
            }   
            else
            {
                //изменяем
                add = "update `schedule` set `time_from` = '" + t_time_from.Text + "', `time_do` = '" + t_time_do.Text + "', `data_from` = '" + date_f + "', `data_to` = '" + date_t + "', `work_day` = '" + t_work_day.Value + "', `weekend_day` = '" + t_week_day.Value + "' where(`idschedule` = '" + id_sch + "')";
            }
            MySqlCommand comm = new MySqlCommand(add, connection);
            comm.ExecuteNonQuery();
            connection.Close();

            employer f_employer = new employer();
            f_employer.timing1(mounth, year);
            f_employer.Show();
        }
        //при изменении даты начала работы
        private void t_date_from_ValueChanged(object sender, EventArgs e)
        {
            t_date_to.MinDate = t_date_from.Value;
        }
        //при изменении даты окончания работы
        private void t_date_to_ValueChanged(object sender, EventArgs e)
        {
            t_date_from.MaxDate = t_date_to.Value;
        }
        //кнопка удалить
        private void bt_delete_Click(object sender, EventArgs e)
        {
            //считываем id сотрудника
            string l_name = box_empl.Text;
            l_name = l_name.Substring(l_name.IndexOf(")") + 2, l_name.Length - (l_name.IndexOf(")") + 2));
            int id_empl = int.Parse(l_name);

            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получение id расписания сотрудника
            string sql1 = "SELECT idemployer, idschedule FROM schedule";
            int count = 1;
            int id_sch = 0;
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                count++;
                if (id_empl == (int)reader1[0])
                    id_sch = (int)reader1[1];
            }
            reader1.Close();

            string add = "DELETE FROM `schedule` WHERE (`idschedule` = '" + id_sch + "')";

            MySqlCommand comm = new MySqlCommand(add, connection);
            comm.ExecuteNonQuery();
            string add1 = "update `employer` set `idschedule` = '0' where(`idemployer` = '" + id_empl + "')";
            MySqlCommand comm1 = new MySqlCommand(add1, connection);
            comm1.ExecuteNonQuery();
            connection.Close();

            bt_set.Text = "Добавить";
            bt_delete.Visible = false;

            employer f_employer = new employer();
            f_employer.timing1(mounth, year);
            f_employer.Show();
        }
    }
}
