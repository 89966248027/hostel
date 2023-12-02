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
    public partial class hostelNumber : Form
    {
        public hostelNumber()
        {
            InitializeComponent();
            box();
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
        //Очистить
        private void bt_clear_Click(object sender, EventArgs e)
        {
            box_date.Checked = false;
            box_data_from.Value = DateTime.Today;
            box_data_to.Value = DateTime.Today;
            box_type.Text = "";
            box_single_bead.Value = 0;
            box_double_bead.Value = 0;
            box_extension.Text = "";
            box_price_from.Text = "";
            box_price_to.Text = "";
            box_reserv.Text = "";
            box();
        }
        //получение кол-ва номеров
        private int count_num()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();
            //отправили запрос на получения кол-ва сотрудников
            int c = 0;
            string count = "SELECT idnumber FROM number";
            MySqlCommand comm = new MySqlCommand(count, connection);
            MySqlDataReader read_count = comm.ExecuteReader();
            while (read_count.Read())
                c++;
            read_count.Close();
            connection.Close();

            return c;
        }
        //заполнение боксов
        private void box()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hostel;password=Katia_223;");
            connection.Open();

            //отправили запрос на получения кол-ва номеров
            int c = count_num();

            int[] num = new int[c];//номера
            string[] type = new string[c];//тип
            int[] double_bead = new int[c];//двухспальные кровати
            int[] single_bead = new int[c];//односпальные кровати
            string[] extension = new string[c];//дополнения
            int[] price = new int[c];//цена
            string[] reserv = new string[c];
            string[] data_from = new string[c];
            string[] data_to = new string[c];
            int maxsingle = 0;
            int maxdouble = 0;

            // отправили запрос на получение данных номеров
            string sql = "SELECT idnumber, idtype, idextension FROM number";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                num[(int)reader[0] - 1] = (int)reader[0];
                type[(int)reader[0] - 1] = reader[1].ToString();
                extension[(int)reader[0] - 1] = reader[2].ToString();
            }
            reader.Close();

            // отправили запрос на получение типа номера
            string sql1 = "SELECT idtype, typename, single_bead, double_bead, price FROM type";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                for (int i = 0; i < c; i++)
                {
                    if (type[i] == reader1[0].ToString())
                    {
                        type[i] = reader1[1].ToString();
                        single_bead[i] = (int)reader1[2];
                        if (single_bead[i] > maxsingle)
                            maxsingle = single_bead[i];
                        double_bead[i] = (int)reader1[3];
                        if (double_bead[i] > maxdouble)
                            maxdouble = double_bead[i];
                        price[i] = (int)reader1[4];
                    }
                }
            }
            reader1.Close();

            // отправили запрос на получение дополнения номера
            string sql2 = "SELECT idextension, extensionname FROM extension";
            MySqlCommand command2 = new MySqlCommand(sql2, connection);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                for (int i = 0; i < c; i++)
                {
                    if (extension[i] == reader2[0].ToString())
                        extension[i] = reader2[1].ToString();
                }
            }
            reader2.Close();

            //отправили запрос на получение дат заезда и выезда
            string sql3 = "SELECT idnumber, data_start, data_stop FROM reservation";
            MySqlCommand command3 = new MySqlCommand(sql3, connection);
            MySqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                for (int i = 0; i < c; i++)
                {
                    if (num[i] == (int)reader3[0])
                    {
                        DateTime date = DateTime.Parse(reader3[1].ToString());
                        data_from[i] = date.ToString("d");
                        date = DateTime.Parse(reader3[2].ToString());
                        data_to[i] = date.ToString("d");
                    }
                }
            }
            reader3.Close();
            connection.Close();

            //очищаем
            box_type.Items.Clear();
            box_extension.Items.Clear();

            //выводим
            box_type.Items.AddRange(type.Distinct().ToArray());
            box_extension.Items.AddRange(extension.Distinct().ToArray());
            box_single_bead.Maximum = maxsingle;
            box_double_bead.Maximum = maxdouble;

            tableNumber.Controls.Clear();
            tableNumber.RowCount = 0;
            //выводим соттрудников в таблицу
            if (box_date.Checked == false &&
                box_type.Text == "" &&
                box_single_bead.Value == 0 &&
                box_double_bead.Value == 0 &&
                box_extension.Text == "" &&
                box_price_from.Text == "" &&
                box_price_to.Text == "")
            {
                Control[] controls = new Control[c * 8];
                for (int i = 0; i < c * 8; i += 8)
                {
                    controls[i] = new Label() { Text = num[i / 8].ToString(), AutoSize = true };
                    controls[i + 1] = new Label() { Text = type[i / 8], AutoSize = true };
                    controls[i + 2] = new Label() { Text = double_bead[i / 8].ToString() };
                    controls[i + 3] = new Label() { Text = single_bead[i / 8].ToString() };
                    controls[i + 4] = new Label() { Text = extension[i / 8], AutoSize = true };
                    controls[i + 5] = new Label() { Text = price[i / 8].ToString(), AutoSize = true };
                    controls[i + 6] = new Button() { Text = "Забронировать", AutoSize = true, Name = ("button" + (i / 8).ToString()) };
                    controls[i + 7] = new Label() { Text = "" };
                }
                tableNumber.Controls.AddRange(controls);
            }
            else
            {
                int k = c;
                int[] number = new int[c];
                for (int i = 0; i < k; i++)
                    number[i] = i;

                if (box_type.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_type.Text == type[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_double_bead.Value != 0)
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_double_bead.Value == double_bead[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_single_bead.Value != 0)
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_single_bead.Value == single_bead[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_extension.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_extension.Text == extension[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_price_from.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (int.Parse(box_price_from.Text) <= price[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_price_to.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (int.Parse(box_price_to.Text) >= price[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                if (box_date.Checked)
                {
                    for (int i = 0; i < c; i++)
                    {
                        if(data_from[number[i]] != null && data_to[number[i]] != null)
                        {
                            if (box_data_from.Value.Date >= DateTime.Parse(data_to[number[i]].ToString()) && box_data_to.Value.Date <= DateTime.Parse(data_from[number[i]].ToString()))
                                reserv[i] = "занятый";
                            else
                                reserv[i] = "свободный";
                        }
                        else
                            reserv[i] = "свободный";
                    }
                }

                if (box_reserv.Text != "")
                {
                    int j = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (box_reserv.Text == reserv[number[i]])
                        {
                            number[j] = number[i];
                            j++;
                        }
                        else k--;
                    }
                }
                c = k;

                //Выводим
                Control[] controls = new Control[c * 8];
                for (int i = 0; i < c * 8; i += 8)
                {
                    controls[i] = new Label() { Text = num[number[i / 8]].ToString(), AutoSize = true };
                    controls[i + 1] = new Label() { Text = type[number[i / 8]], AutoSize = true };
                    controls[i + 2] = new Label() { Text = double_bead[number[i / 8]].ToString() };
                    controls[i + 3] = new Label() { Text = single_bead[number[i / 8]].ToString() };
                    controls[i + 4] = new Label() { Text = extension[number[i / 8]], AutoSize = true };
                    controls[i + 5] = new Label() { Text = price[number[i / 8]].ToString(), AutoSize = true };
                    if(reserv[number[i / 8]] == "занятый")
                    {
                        controls[i + 6] = new Label() { Text = "занятый", AutoSize = true};
                        controls[i + 7] = new Button() { Text = "+", Name = ("button" + (number[i / 8]).ToString()) };
                    }
                    else
                    {
                        controls[i + 6] = new Button() { Text = "Забронировать", AutoSize = true, Name = ("button" + (number[i / 8]).ToString()) };
                        controls[i + 7] = new Label() { Text = "" };
                    }
                }
                tableNumber.Controls.AddRange(controls);
            }
            int kol = count_num();
            for (int i = 0; i < kol; i++)
            {
                foreach (Control a in tableNumber.Controls)
                {
                    if (a.Name == "button" + i.ToString())
                    {
                        a.Click += new System.EventHandler(button_Click);
                    }
                }
            }
        }
        //забронировать
        private void button_Click(object sender, EventArgs e)
        {
            string number = "";
            string text = "";
            int kol = count_num();
            foreach (Control a in tableNumber.Controls)
                if (a == sender)
                {
                    number = a.Name.ToString();
                    text = a.Text;
                }

            number = number.Replace("button", "");
            Hide();
            reservation f_reserv = new reservation();
            f_reserv.box_number.Maximum = count_num();
            f_reserv.box_number.Value = int.Parse(number) + 1;
            if (text == "Забронировать" && box_date.Checked)
            {
                f_reserv.box_data_from.Value = box_data_from.Value.Date;
                f_reserv.box_data_to.Value = box_data_to.Value.Date;
            }
            f_reserv.ShowDialog();
            Close();
        }
        private void box_SelectedIndexChanged(object sender, EventArgs e)
        {
            box();
        }
        //ввод в строку определенных символов
        private void key_press(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            if (!(i == 8 || (i >= 48 && i <= 57) || i == 127))
            {
                /* запрет ввода с клавиатуры, кроме Backspace, Delete и цифр*/
                e.Handled = true;
            }
        }

        private void box_date_CheckedChanged(object sender, EventArgs e)
        {
            box_data_from.Enabled = box_date.Checked;
            box_data_to.Enabled = box_date.Checked;
            box_reserv.Enabled = box_date.Checked;
        }
    }
}
