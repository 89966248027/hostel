using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_kursach
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        //Бронь
        private void reservation_Click(object sender, EventArgs e)
        {
            Hide();
            reservation f_reservation = new reservation();
            f_reservation.bt_pay.Text = "Изменить";
            f_reservation.bt_pay.Visible = false;
            f_reservation.ShowDialog();
            Close();
        }
        //Назад
        private void bt_back_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f_1 = new Form1();
            f_1.ShowDialog();
            Close();
        }
        //Сотруднику
        private void employer_Click(object sender, EventArgs e)
        {
            Hide();
            loginEmployer a = new loginEmployer();
            string b = a.set_login(1);
            a.open_empl(b);
            Close();
        }
        //Номера
        private void number_Click(object sender, EventArgs e)
        {
            Hide();
            loginEmployer a = new loginEmployer();
            string b = a.set_login(1);
            a.open_num(b);
            Close();
        }

        private void guest_Click(object sender, EventArgs e)
        {
            set_quest f_q = new set_quest();
            f_q.ShowDialog();
        }
        //изменить данные гостиницы
        private void bt_hostel_Click(object sender, EventArgs e)
        {
            if (bt_hostel.Text == "Изменить данные гостиницы")
            {
                employer.Enabled = false;
                number.Enabled = false;
                guest.Enabled = false;
                bt_back.Enabled = false;
                tb_hostelname.Enabled = true;
                tb_hosteladress.Enabled = true;
                tb_hostelphone.Enabled = true;
                tb_hostelemail.Enabled = true;
                bt_hostel.Text = "Сохранить";

                //отправка данных в бд
            }
            else
            {
                employer.Enabled = true;
                number.Enabled = true;
                guest.Enabled = true;
                bt_back.Enabled = true;
                tb_hostelname.Enabled = false;
                tb_hosteladress.Enabled = false;
                tb_hostelphone.Enabled = false;
                tb_hostelemail.Enabled = false;
                bt_hostel.Text = "Изменить данные гостиницы";
            }
        }
    }
}
