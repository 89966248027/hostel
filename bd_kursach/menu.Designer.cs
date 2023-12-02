
namespace bd_kursach
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.guest = new System.Windows.Forms.Button();
            this.employer = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Button();
            this.bt_hostel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_hostelname = new System.Windows.Forms.TextBox();
            this.tb_hosteladress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_hostelphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_hostelemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(527, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Постояльцы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Номера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(58, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сотруднику";
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_back.Location = new System.Drawing.Point(15, 370);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(167, 58);
            this.bt_back.TabIndex = 15;
            this.bt_back.Text = "<< Назад";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // guest
            // 
            this.guest.Image = global::bd_kursach.Properties.Resources.гость1;
            this.guest.Location = new System.Drawing.Point(497, 83);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(208, 253);
            this.guest.TabIndex = 21;
            this.guest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guest.UseVisualStyleBackColor = true;
            this.guest.Click += new System.EventHandler(this.guest_Click);
            // 
            // employer
            // 
            this.employer.Image = global::bd_kursach.Properties.Resources.сотрудники1;
            this.employer.Location = new System.Drawing.Point(15, 83);
            this.employer.Name = "employer";
            this.employer.Size = new System.Drawing.Size(208, 253);
            this.employer.TabIndex = 20;
            this.employer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.employer.UseVisualStyleBackColor = true;
            this.employer.Click += new System.EventHandler(this.employer_Click);
            // 
            // number
            // 
            this.number.Image = global::bd_kursach.Properties.Resources.номер1;
            this.number.Location = new System.Drawing.Point(256, 83);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(208, 253);
            this.number.TabIndex = 18;
            this.number.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.number.UseVisualStyleBackColor = true;
            this.number.Click += new System.EventHandler(this.number_Click);
            // 
            // bt_hostel
            // 
            this.bt_hostel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_hostel.Location = new System.Drawing.Point(470, 370);
            this.bt_hostel.Name = "bt_hostel";
            this.bt_hostel.Size = new System.Drawing.Size(235, 58);
            this.bt_hostel.TabIndex = 22;
            this.bt_hostel.Text = "Изменить данные гостиницы";
            this.bt_hostel.UseVisualStyleBackColor = true;
            this.bt_hostel.Click += new System.EventHandler(this.bt_hostel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Название гостиницы";
            // 
            // tb_hostelname
            // 
            this.tb_hostelname.Enabled = false;
            this.tb_hostelname.Location = new System.Drawing.Point(167, 13);
            this.tb_hostelname.Name = "tb_hostelname";
            this.tb_hostelname.Size = new System.Drawing.Size(191, 22);
            this.tb_hostelname.TabIndex = 24;
            // 
            // tb_hosteladress
            // 
            this.tb_hosteladress.Enabled = false;
            this.tb_hosteladress.Location = new System.Drawing.Point(167, 41);
            this.tb_hosteladress.Name = "tb_hosteladress";
            this.tb_hosteladress.Size = new System.Drawing.Size(191, 22);
            this.tb_hosteladress.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Адрес гостиницы";
            // 
            // tb_hostelphone
            // 
            this.tb_hostelphone.Enabled = false;
            this.tb_hostelphone.Location = new System.Drawing.Point(514, 13);
            this.tb_hostelphone.Name = "tb_hostelphone";
            this.tb_hostelphone.Size = new System.Drawing.Size(191, 22);
            this.tb_hostelphone.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Телефон";
            // 
            // tb_hostelemail
            // 
            this.tb_hostelemail.Enabled = false;
            this.tb_hostelemail.Location = new System.Drawing.Point(514, 41);
            this.tb_hostelemail.Name = "tb_hostelemail";
            this.tb_hostelemail.Size = new System.Drawing.Size(191, 22);
            this.tb_hostelemail.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Email";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 447);
            this.Controls.Add(this.tb_hostelemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_hostelphone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_hosteladress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_hostelname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_hostel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number);
            this.Controls.Add(this.bt_back);
            this.MaximizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_back;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button number;
        public System.Windows.Forms.Button employer;
        public System.Windows.Forms.Button guest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button bt_hostel;
        public System.Windows.Forms.TextBox tb_hostelname;
        public System.Windows.Forms.TextBox tb_hosteladress;
        public System.Windows.Forms.TextBox tb_hostelphone;
        public System.Windows.Forms.TextBox tb_hostelemail;
    }
}