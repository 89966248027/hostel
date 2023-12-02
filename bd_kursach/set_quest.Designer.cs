
namespace bd_kursach
{
    partial class set_quest
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
            this.bt_set = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.box_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_birthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.box_firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.box_quest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_set
            // 
            this.bt_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_set.Location = new System.Drawing.Point(387, 273);
            this.bt_set.Name = "bt_set";
            this.bt_set.Size = new System.Drawing.Size(109, 34);
            this.bt_set.TabIndex = 46;
            this.bt_set.Text = "Добавить";
            this.bt_set.UseVisualStyleBackColor = true;
            this.bt_set.Click += new System.EventHandler(this.bt_set_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_delete.Location = new System.Drawing.Point(15, 273);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(109, 34);
            this.bt_delete.TabIndex = 45;
            this.bt_delete.Text = "Удалить";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Visible = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // box_phone
            // 
            this.box_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_phone.Location = new System.Drawing.Point(165, 218);
            this.box_phone.MaxLength = 11;
            this.box_phone.Name = "box_phone";
            this.box_phone.Size = new System.Drawing.Size(331, 27);
            this.box_phone.TabIndex = 42;
            this.box_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Телефон";
            // 
            // box_birthday
            // 
            this.box_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.box_birthday.Location = new System.Drawing.Point(165, 175);
            this.box_birthday.MaxDate = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            this.box_birthday.Name = "box_birthday";
            this.box_birthday.Size = new System.Drawing.Size(200, 27);
            this.box_birthday.TabIndex = 38;
            this.box_birthday.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "День рождения";
            // 
            // box_firstname
            // 
            this.box_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_firstname.Location = new System.Drawing.Point(165, 135);
            this.box_firstname.Name = "box_firstname";
            this.box_firstname.Size = new System.Drawing.Size(331, 27);
            this.box_firstname.TabIndex = 36;
            this.box_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Имя";
            // 
            // box_lastname
            // 
            this.box_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_lastname.Location = new System.Drawing.Point(165, 93);
            this.box_lastname.Name = "box_lastname";
            this.box_lastname.Size = new System.Drawing.Size(331, 27);
            this.box_lastname.TabIndex = 34;
            this.box_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Фамилия";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(392, 46);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(104, 31);
            this.bt_clear.TabIndex = 32;
            this.bt_clear.Text = "Очистить";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // box_quest
            // 
            this.box_quest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.box_quest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.box_quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_quest.FormattingEnabled = true;
            this.box_quest.Location = new System.Drawing.Point(117, 12);
            this.box_quest.Name = "box_quest";
            this.box_quest.Size = new System.Drawing.Size(379, 28);
            this.box_quest.Sorted = true;
            this.box_quest.TabIndex = 31;
            this.box_quest.SelectedIndexChanged += new System.EventHandler(this.box_quest_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Постоялец";
            // 
            // set_quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 326);
            this.Controls.Add(this.bt_set);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.box_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_firstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.box_quest);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "set_quest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить(изменить) данные постояльца";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_set;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox box_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker box_birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.ComboBox box_quest;
        private System.Windows.Forms.Label label1;
    }
}