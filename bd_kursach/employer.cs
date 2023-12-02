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
    public partial class employer : Form
    {
        int m, y; //месяц и год
        bool flag = true;
        public employer()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;//текущая дата
            m = today.Month;
            y = today.Year;
            set_date(today.Day, today.Month, today.Year);
            timing1(today.Month, today.Year);
        }
        //вывод календаря
        private void set_date(int day, int month, int year) 
        {
            DateTime today = DateTime.Today;//текущая дата
            DateTime todayValue = new DateTime(today.Year, today.Month, 1);//начало месяца
            int today_week_day = (int)todayValue.DayOfWeek;//день недели
            if (today_week_day == 0)
                today_week_day = 7;//вс = 0, поэтому присваеваем ему 7 день недели
            if (month == today.Month && year == today.Year)
                flag = true;
            else
                flag = false;

            DateTime dateValue = new DateTime(year, month, 1);//начало месяца
            int numbersOfDay = System.DateTime.DaysInMonth(year, month);//кол-во дней в текущем месяце
            int y = year;
            int m = month;
            if (month == 1)
            {
                y--;
                m = 13;
            }  
            int numbersOfDay1 = System.DateTime.DaysInMonth(y, m - 1);//кол-во дней в прошлом месяце
            int week_day = (int)dateValue.DayOfWeek;//день недели
            if (week_day == 0)
                week_day = 7;//вс = 0, поэтому присваеваем ему 7 день недели
            l_month.Text = set_month(month) + " " + year.ToString();
            //подсвечиваем сегодняшнюю дату
            Color color = new Color();
            int num = today.Day + today_week_day - 1;
            switch (flag)
            {
                case true: color = Color.LightCyan; break;
                case false: color = Color.White; break;
            }

            foreach (Panel panel in tableLayoutPanel1.Controls)
            {
                //подсвечиваем сегодняшнюю дату
                if (panel.Name == "panel" + num.ToString())
                    panel.BackColor = color;

                foreach (Label a in panel.Controls)
                {
                    //числа прошлого месяца
                    for(int i = 1; i < week_day; i++)
                    {
                        if(a.Name == "label" + i.ToString())
                        {
                            a.Text = (numbersOfDay1 - week_day + 1 + i).ToString();
                            a.ForeColor = Color.DarkGray;
                        }
                    }
                    //основные числа месяца
                    int dif = week_day - 1; //разность
                    for (int i = week_day; i < week_day + numbersOfDay; i++)
                    {
                        if (a.Name == "label" + i.ToString())
                        {
                            a.Text = (i - dif).ToString();
                            a.ForeColor = Color.Black;
                        }
                    }
                    //числа следующего месяца
                    for (int i = week_day + numbersOfDay; i < 43; i++)
                    {
                        if (a.Name == "label" + i.ToString())
                        {
                            a.Text = (i -(week_day + numbersOfDay - 1)).ToString();
                            a.ForeColor = Color.DarkGray;
                        }
                    }
                } 
            }
                  
        }
        //возвращает название месяца
        private string set_month(int m)
        {
            string month = "";
            switch (m)
            {
                case 1: month = "Январь"; break;
                case 2: month = "Февраль"; break;
                case 3: month = "Март"; break;
                case 4: month = "Апрель"; break;
                case 5: month = "Май"; break;
                case 6: month = "Июнь"; break;
                case 7: month = "Июль"; break;
                case 8: month = "Август"; break;
                case 9: month = "Сентябрь"; break;
                case 10: month = "Октябрь"; break;
                case 11: month = "Ноябрь"; break;
                case 12: month = "Декабрь"; break;
            }
            return month;
        }

        //рассписание
        public void timing1(int month, int year)
        {
            loginEmployer a = new loginEmployer();
            string login = a.set_login(1);//узнали логин

            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получение id сотрудника
            string sql = "SELECT login, idpost FROM authorization";
            int id_post = 0;
            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (login == reader[0].ToString())
                    id_post = (int)reader[1];
            }
            reader.Close();
            connection.Close();
            clear_label();
            timing(month, year, false);
            if (id_post == 1)
            {
                timing(month, year, true);
            }
        }

        //вывешиваем рассписание сотрудника
        private void timing(int month, int year, bool pos)
        { 
            if (!pos)
            {
                loginEmployer a = new loginEmployer();
                string login = a.set_login(1);//узнали логин

                MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
                connection.Open();

                //отправили запрос на получение id сотрудника
                string sql = "SELECT login, idemployer FROM authorization";
                int id_empl = 0;
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (login == reader[0].ToString())
                        id_empl = (int)reader[1];
                }
                reader.Close();

                //отправили запрос на получение расписания сотрудника
                string sql1 = "SELECT idemployer, time_from, time_do, data_from, data_to FROM schedule";
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                string time1 = "";
                string time2 = "";
                string data1 = "";
                string data2 = "";
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    if (id_empl == (int)reader1[0])
                    {
                        time1 = reader1[1].ToString();
                        time2 = reader1[2].ToString();
                        data1 = reader1[3].ToString();
                        data2 = reader1[4].ToString();

                        DateTime data_from = DateTime.Parse(data1);
                        DateTime data_to = DateTime.Parse(data2);
                        DateTime time_from = DateTime.Parse(time1);
                        DateTime time_to = DateTime.Parse(time2);
                        time_to = time_from.AddHours(8);

                        //выводим на форму
                        DateTime date = new DateTime(year, month, 1);
                        DateTime dateF = new DateTime(data_from.Year, data_from.Month, 1);
                        DateTime dataT = new DateTime(data_to.Year, data_to.Month, System.DateTime.DaysInMonth(data_to.Year, data_to.Month));
                        if (dateF <= date && date <= dataT)
                        {
                            int week_day1 = (int)date.DayOfWeek;//день недели первого числа месяца
                            if (week_day1 == 0)
                                week_day1 = 7;
                            int week_day = (int)data_from.DayOfWeek;//день недели начала работы
                            if (week_day == 0)
                                week_day = 7;

                            if (month == data_from.Month && year == data_from.Year)//первый месяц работы
                            {
                                foreach (Panel panel in tableLayoutPanel1.Controls)
                                    foreach (Label label in panel.Controls)
                                    {
                                        for (int i = data_from.Day + week_day1 - 1; i < 43; i += 7)
                                        {
                                            int d = 1;
                                            int day = i;
                                            while (d <= 5)
                                            {
                                                if (label.Name == "label1_" + day.ToString())
                                                    label.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + "\n";
                                                day++;
                                                d++;
                                            }
                                        }
                                    }
                            }
                            else
                            {
                                if (week_day >= 4)//ставим на прошлый месяц
                                {
                                    label1_1.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + "\n";
                                    if (week_day >= 5)
                                    {
                                        label1_2.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + "\n";
                                        if (week_day >= 6)
                                        {
                                            label1_3.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + "\n";
                                            if (week_day == 7)
                                                label1_4.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + "\n";
                                        }
                                    }
                                }

                                if (month == data_to.Month && year == data_to.Year)//последний месяц работы
                                {
                                    foreach (Panel panel in tableLayoutPanel1.Controls)
                                        foreach (Label label in panel.Controls)
                                        {
                                            for (int i = week_day; i < data_to.Day + week_day1 - 1; i += 7)
                                            {
                                                int d = 1;
                                                int day = i;
                                                while (d <= 5 && day < data_to.Day + week_day1 - 1)
                                                {
                                                    if (label.Name == "label1_" + day.ToString())
                                                        label.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + "\n";
                                                    day++;
                                                    d++;
                                                }
                                            }
                                        }
                                }
                                else
                                {
                                    foreach (Panel panel in tableLayoutPanel1.Controls)
                                        foreach (Label label in panel.Controls)
                                        {
                                            for (int i = week_day; i < 43; i += 7)
                                            {
                                                int d = 1;
                                                int day = i;
                                                while (d <= 5)
                                                {
                                                    if (label.Name == "label1_" + day.ToString())
                                                        label.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + "\n";
                                                    day++;
                                                    d++;
                                                }
                                            }
                                        }
                                }
                            }
                        }
                    }
                }
                reader1.Close();
                connection.Close();
            }
            else
            {
                loginEmployer a = new loginEmployer();
                string login = a.set_login(1);//узнали логин
                string[] lastname = new string[10000];//фамилия сотрудника
                string[] log = new string[10000];//логин сотрудника

                MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
                connection.Open();

                //отправили запрос на получение фамилии сотрудника
                string sql2 = "SELECT idemployer, employer_lastname FROM employer";
                MySqlCommand command2 = new MySqlCommand(sql2, connection);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    lastname[(int)reader2[0] - 1] = reader2[1].ToString();
                }
                reader2.Close();

                //отправили запрос на получение id сотрудника
                string sql = "SELECT login, idemployer FROM authorization";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    log[(int)reader[1]] = reader[0].ToString();  
                }
                reader.Close();

                //отправили запрос на получение расписания сотрудника
                string sql1 = "SELECT idemployer, time_from, data_from, data_to FROM schedule";
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                string time = "";
                string data1 = "";
                string data2 = "";
                MySqlDataReader reader1 = command1.ExecuteReader();
                int r = 1;
                while (reader1.Read())
                {
                    while (r != (int)reader1[0])
                        r++;
                    if (log[r] != login)
                    {
                        if (r == (int)reader1[0])
                        {
                            time = reader1[1].ToString();
                            data1 = reader1[2].ToString();
                            data2 = reader1[3].ToString();

                            DateTime data_from = DateTime.Parse(data1);
                            DateTime data_to = DateTime.Parse(data2);
                            DateTime time_from = DateTime.Parse(time);
                            DateTime time_to = new DateTime();
                            time_to = time_from.AddHours(8);

                            //выводим на форму
                            DateTime date = new DateTime(year, month, 1);
                            DateTime dateF = new DateTime(data_from.Year, data_from.Month, 1);
                            DateTime dataT = new DateTime(data_to.Year, data_to.Month, System.DateTime.DaysInMonth(data_to.Year, data_to.Month));
                            if (dateF <= date && date <= dataT)
                            {
                                int week_day1 = (int)date.DayOfWeek;//день недели первого числа месяца
                                if (week_day1 == 0)
                                    week_day1 = 7;
                                int week_day = (int)data_from.DayOfWeek;//день недели начала работы
                                if (week_day == 0)
                                    week_day = 7;

                                if (month == data_from.Month && year == data_from.Year)//первый месяц работы
                                {
                                    foreach (Panel panel in tableLayoutPanel1.Controls)
                                        foreach (Label label in panel.Controls)
                                        {
                                            for (int i = data_from.Day + week_day1 - 1; i < 43; i += 7)
                                            {
                                                int d = 1;
                                                int day = i;
                                                while (d <= 5)
                                                {
                                                    if (label.Name == "label1_" + day.ToString())
                                                        label.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + " " +
                                                            lastname[r] + "\n";
                                                    day++;
                                                    d++;
                                                }
                                            }
                                        }
                                }
                                else
                                {
                                    if (week_day >= 4)//ставим на прошлый месяц
                                    {
                                        label1_1.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + " " +
                                                            lastname[r] + "\n";
                                        if (week_day >= 5)
                                        {
                                            label1_2.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + " " +
                                                            lastname[r] + "\n";
                                            if (week_day >= 6)
                                            {
                                                label1_3.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + " " +
                                                            lastname[r] + "\n";
                                                if (week_day == 7)
                                                    label1_4.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + " " +
                                                            lastname[r] + "\n";
                                            }
                                        }
                                    }

                                    if (month == data_to.Month && year == data_to.Year)//последний месяц работы
                                    {
                                        foreach (Panel panel in tableLayoutPanel1.Controls)
                                            foreach (Label label in panel.Controls)
                                            {
                                                for (int i = week_day; i < data_to.Day + week_day1 - 1; i += 7)
                                                {
                                                    int d = 1;
                                                    int day = i;
                                                    while (d <= 5 && day < data_to.Day + week_day1 - 1)
                                                    {
                                                        if (label.Name == "label1_" + day.ToString())
                                                            label.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + " " +
                                                            lastname[r] + "\n";
                                                        day++;
                                                        d++;
                                                    }
                                                }
                                            }
                                    }
                                    else
                                    {
                                        foreach (Panel panel in tableLayoutPanel1.Controls)
                                            foreach (Label label in panel.Controls)
                                            {
                                                for (int i = week_day; i < 43; i += 7)
                                                {
                                                    int d = 1;
                                                    int day = i;
                                                    while (d <= 5)
                                                    {
                                                        if (label.Name == "label1_" + day.ToString())
                                                            label.Text += time_from.ToString("HH:mm") + "-" + time_to.ToString("HH:mm") + " " +
                                                            lastname[r] + "\n";
                                                        day++;
                                                        d++;
                                                    }
                                                }
                                            }
                                    }
                                }
                            }
                        }
                    }
                }
                reader1.Close();
                connection.Close();
            }
        }

        //очистка рассписания
        private void clear_label()
        {
            foreach (Panel panel in tableLayoutPanel1.Controls)
                foreach (Label a in panel.Controls)
                {
                    for(int i = 1; i < 43; i++)
                    {
                        if (a.Name == "label1_" + i.ToString())
                            a.Text = "";
                    }
                }
        }

        //Назад
        private void bt_back_Click(object sender, EventArgs e)
        {
            Hide();
            loginEmployer a = new loginEmployer();
            string login = a.set_login(1);
            string password = a.set_login(2);
            a.open_menu(login, password);
            Close();
        }
        //кнопка сегодня
        private void bt_today_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;//текущая дата
            m = today.Month;
            y = today.Year;
            set_date(today.Day, m, y);
            timing1(m, y);
        }
        //вперед
        private void bt2_Click(object sender, EventArgs e)
        {
            m = m + 1;
            if (m > 12)
            {
                m = 1;
                y = y + 1;
            }
            set_date(1, m, y);
            timing1(m, y);
        }

        //назад
        private void bt1_Click(object sender, EventArgs e)
        {
            m = m - 1;
            if(m < 1)
            {
                m = 12;
                y = y - 1;
            }
            set_date(1, m, y);
            timing1(m, y);
        }

        //добавить рассписание (сотрудника)
        private void bt_sched_Click(object sender, EventArgs e)
        {
            if (bt_sched.Text == "Добавить (изменить) рассписание сотрудника")
            {
                schedule f_schedule = new schedule();
                f_schedule.mounth = m;
                f_schedule.year = y;
                f_schedule.ShowDialog();
            }
            else
            {
                set_emloyer f_setEmpl = new set_emloyer();
                f_setEmpl.ShowDialog();
            }
        }

        //при переключении страниц
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                bt_sched.Text = "Добавить (изменить) рассписание сотрудника";
            else
            {
                bt_sched.Text = "Добавить (изменить) данные сотрудника";
                box();
            }
        }

        //получение кол-ва сотрудников
        private int count_empl()
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
            connection.Close();

            return c;
        }
        //очистить боксы
        private void bt_clear_Click(object sender, EventArgs e)
        {
            box_lastname.Text = "";
            box_firstname.Text = "";
            box_birthday.Text = "";
            box_status.Text = "";
            box_phone.Text = "";
            box_post.Text = "";
            box_sch.Text = "";
            box();
        }

        //заполнение боксов
        public void box()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получения кол-ва сотрудников
            int c = count_empl();

            string[] lastname = new string[c];//фамилии
            string[] firstname = new string[c];//имена
            string[] birthday = new string[c];//дни рождения
            string[] status = new string[c];//статусы
            string[] phone = new string[c];//телефоны
            string[] post = new string[c];//должности
            string[] sch = new string[c];//графики

            // отправили запрос на получение данных сотрудников
            string sql = "SELECT idemployer, employer_lastname, employer_firstname, employer_birthday, employer_status, employercol, idpost, idschedule FROM employer";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lastname[(int)reader[0] - 1] = reader[1].ToString();
                firstname[(int)reader[0] - 1] = reader[2].ToString();
                DateTime date = DateTime.Parse(reader[3].ToString());
                birthday[(int)reader[0] - 1] = date.ToString("d");
                status[(int)reader[0] -1] = reader[4].ToString();
                phone[(int)reader[0] - 1] = reader[5].ToString();
                post[(int)reader[0] - 1] = reader[6].ToString();
                if (reader[7].ToString() == "0")
                    sch[(int)reader[0] - 1] = "нет";
                else
                    sch[(int)reader[0] - 1] = "есть";
            }
            reader.Close();

            // отправили запрос на получение должности сотрудников
            string sql1 = "SELECT idpost, postname FROM post";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                for (int i = 0; i < c; i++)
                {
                    if (post[i] == reader1[0].ToString())
                        post[i] = reader1[1].ToString();
                }
            }
            reader1.Close();
            connection.Close();

            //очищаем
            box_lastname.Items.Clear();
            box_firstname.Items.Clear();
            box_birthday.Items.Clear();
            box_status.Items.Clear();
            box_phone.Items.Clear();
            box_post.Items.Clear();
            box_sch.Items.Clear();

            //выводим
            box_lastname.Items.AddRange(lastname.Distinct().ToArray());
            box_firstname.Items.AddRange(firstname.Distinct().ToArray());
            box_birthday.Items.AddRange(birthday.Distinct().ToArray());
            box_status.Items.AddRange(status.Distinct().ToArray());
            box_phone.Items.AddRange(phone.Distinct().ToArray());
            box_post.Items.AddRange(post.Distinct().ToArray());
            box_sch.Items.AddRange(sch.Distinct().ToArray());

            tableEmpl.Controls.Clear();
            tableEmpl.RowCount = 0;
            //выводим соттрудников в таблицу
            if (box_lastname.Text == "" && 
                box_firstname.Text == "" && 
                box_birthday.Text == "" && 
                box_status.Text == "" && 
                box_phone.Text == "" && 
                box_post.Text == "" && 
                box_sch.Text == "")
            {
                for (int i = 0; i < c; i++)
                    table(i);
            }
            else
            {
                int k = c;
                int[] number = new int[c];
                for (int i = 0; i < k; i++)
                    number[i] = i;

                if(box_lastname.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_lastname.Text == lastname[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_firstname.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_firstname.Text == firstname[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_birthday.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_birthday.Text == birthday[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_status.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_status.Text == status[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_phone.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_phone.Text == phone[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_post.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_post.Text == post[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_sch.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_sch.Text == sch[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }

                for (int i = 0; i < k; i++)
                {
                    table(number[i]);
                }
            }
        }

        private void box_lastname_SelectedIndexChanged(object sender, EventArgs e)
        {
            box();
        }

        //добавление строки в таблицу 
        private void table(int i)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получения кол-ва сотрудников
            int c = count_empl();

            string[] lastname = new string[c];//фамилии
            string[] firstname = new string[c];//имена
            string[] birthday = new string[c];//дни рождения
            string[] status = new string[c];//статусы
            string[] phone = new string[c];//телефоны
            string[] post = new string[c];//должности
            string[] sch = new string[c];//графики

            // отправили запрос на получение данных сотрудников
            string sql = "SELECT idemployer, employer_lastname, employer_firstname, employer_birthday, employer_status, employercol, idpost, idschedule FROM employer";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lastname[(int)reader[0] - 1] = reader[1].ToString();
                firstname[(int)reader[0] - 1] = reader[2].ToString();
                DateTime date = DateTime.Parse(reader[3].ToString());
                birthday[(int)reader[0] - 1] = date.ToString("d");
                status[(int)reader[0] - 1] = reader[4].ToString();
                phone[(int)reader[0] - 1] = reader[5].ToString();
                post[(int)reader[0] - 1] = reader[6].ToString();
                if (reader[7].ToString() == "0")
                    sch[(int)reader[0] - 1] = "нет";
                else
                    sch[(int)reader[0] - 1] = "есть";
            }
            reader.Close();

            // отправили запрос на получение должности сотрудников
            string sql1 = "SELECT idpost, postname FROM post";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                for (int j = 0; j < c; j++)
                {
                    if (post[j] == reader1[0].ToString())
                        post[j] = reader1[1].ToString();
                }
            }
            reader1.Close();
            connection.Close();

            tableEmpl.RowCount = tableEmpl.RowCount + 1;
            tableEmpl.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableEmpl.Controls.Add(new Label() { Text = lastname[i] }, 0, tableEmpl.RowCount - 1);
            tableEmpl.Controls.Add(new Label() { Text = firstname[i] }, 1, tableEmpl.RowCount - 1);
            tableEmpl.Controls.Add(new Label() { Text = birthday[i] }, 2, tableEmpl.RowCount - 1);
            tableEmpl.Controls.Add(new Label() { Text = status[i] }, 3, tableEmpl.RowCount - 1);
            tableEmpl.Controls.Add(new Label() { Text = phone[i] }, 4, tableEmpl.RowCount - 1);
            tableEmpl.Controls.Add(new Label() { Text = post[i] }, 5, tableEmpl.RowCount - 1);
            tableEmpl.Controls.Add(new Label() { Text = sch[i] }, 6, tableEmpl.RowCount - 1);
        }
    }
}
