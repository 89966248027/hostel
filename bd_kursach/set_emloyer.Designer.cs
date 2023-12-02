
namespace bd_kursach
{
    partial class set_emloyer
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
            this.box_empl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.box_lastname = new System.Windows.Forms.TextBox();
            this.box_firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box_birthday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.box_status = new System.Windows.Forms.ComboBox();
            this.box_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_post = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_set = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.box_login = new System.Windows.Forms.TextBox();
            this.box_password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_empl
            // 
            this.box_empl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.box_empl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.box_empl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_empl.FormattingEnabled = true;
            this.box_empl.Location = new System.Drawing.Point(119, 12);
            this.box_empl.Name = "box_empl";
            this.box_empl.Size = new System.Drawing.Size(379, 28);
            this.box_empl.Sorted = true;
            this.box_empl.TabIndex = 4;
            this.box_empl.SelectedIndexChanged += new System.EventHandler(this.box_empl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сотрудник";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(394, 46);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(104, 31);
            this.bt_clear.TabIndex = 9;
            this.bt_clear.Text = "Очистить";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // box_lastname
            // 
            this.box_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_lastname.Location = new System.Drawing.Point(167, 93);
            this.box_lastname.Name = "box_lastname";
            this.box_lastname.Size = new System.Drawing.Size(331, 27);
            this.box_lastname.TabIndex = 11;
            this.box_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // box_firstname
            // 
            this.box_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_firstname.Location = new System.Drawing.Point(167, 135);
            this.box_firstname.Name = "box_firstname";
            this.box_firstname.Size = new System.Drawing.Size(331, 27);
            this.box_firstname.TabIndex = 13;
            this.box_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "День рождения";
            // 
            // box_birthday
            // 
            this.box_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.box_birthday.Location = new System.Drawing.Point(167, 175);
            this.box_birthday.MaxDate = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            this.box_birthday.Name = "box_birthday";
            this.box_birthday.Size = new System.Drawing.Size(200, 27);
            this.box_birthday.TabIndex = 15;
            this.box_birthday.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Статус";
            // 
            // box_status
            // 
            this.box_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_status.FormattingEnabled = true;
            this.box_status.Location = new System.Drawing.Point(167, 218);
            this.box_status.Name = "box_status";
            this.box_status.Size = new System.Drawing.Size(331, 28);
            this.box_status.TabIndex = 17;
            this.box_status.Text = "работает";
            this.box_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press2);
            // 
            // box_phone
            // 
            this.box_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_phone.Location = new System.Drawing.Point(167, 262);
            this.box_phone.MaxLength = 11;
            this.box_phone.Name = "box_phone";
            this.box_phone.Size = new System.Drawing.Size(331, 27);
            this.box_phone.TabIndex = 19;
            this.box_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Телефон";
            // 
            // box_post
            // 
            this.box_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_post.FormattingEnabled = true;
            this.box_post.Location = new System.Drawing.Point(167, 304);
            this.box_post.Name = "box_post";
            this.box_post.Size = new System.Drawing.Size(331, 28);
            this.box_post.TabIndex = 21;
            this.box_post.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Должность";
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_delete.Location = new System.Drawing.Point(17, 424);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(109, 34);
            this.bt_delete.TabIndex = 22;
            this.bt_delete.Text = "Удалить";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Visible = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_set
            // 
            this.bt_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_set.Location = new System.Drawing.Point(389, 424);
            this.bt_set.Name = "bt_set";
            this.bt_set.Size = new System.Drawing.Size(109, 34);
            this.bt_set.TabIndex = 23;
            this.bt_set.Text = "Добавить";
            this.bt_set.UseVisualStyleBackColor = true;
            this.bt_set.Click += new System.EventHandler(this.bt_set_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Логин";
            // 
            // box_login
            // 
            this.box_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_login.Location = new System.Drawing.Point(78, 361);
            this.box_login.Name = "box_login";
            this.box_login.Size = new System.Drawing.Size(173, 27);
            this.box_login.TabIndex = 25;
            // 
            // box_password
            // 
            this.box_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_password.Location = new System.Drawing.Point(335, 361);
            this.box_password.Name = "box_password";
            this.box_password.Size = new System.Drawing.Size(173, 27);
            this.box_password.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(257, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Пароль";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(86, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "не менее 8 символов";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(353, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "не менее 8 символов";
            // 
            // set_emloyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 470);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.box_password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.box_login);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_set);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.box_post);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_firstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.box_empl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "set_emloyer";
            this.Text = "Добавить (изменить) сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box_empl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_lastname;
        private System.Windows.Forms.TextBox box_firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker box_birthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox box_status;
        private System.Windows.Forms.TextBox box_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox box_post;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_set;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox box_login;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}