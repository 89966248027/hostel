
namespace bd_kursach
{
    partial class reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.box_quest = new System.Windows.Forms.ComboBox();
            this.bt_addQuest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.box_number = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.box_data_to = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.box_data_from = new System.Windows.Forms.DateTimePicker();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_pay = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.box_number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Постоялец";
            // 
            // box_quest
            // 
            this.box_quest.FormattingEnabled = true;
            this.box_quest.Location = new System.Drawing.Point(129, 20);
            this.box_quest.Name = "box_quest";
            this.box_quest.Size = new System.Drawing.Size(254, 24);
            this.box_quest.TabIndex = 1;
            this.box_quest.SelectedIndexChanged += new System.EventHandler(this.box_quest_SelectedIndexChanged);
            // 
            // bt_addQuest
            // 
            this.bt_addQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_addQuest.Location = new System.Drawing.Point(402, 14);
            this.bt_addQuest.Name = "bt_addQuest";
            this.bt_addQuest.Size = new System.Drawing.Size(140, 33);
            this.bt_addQuest.TabIndex = 2;
            this.bt_addQuest.Text = "Добавить";
            this.bt_addQuest.UseVisualStyleBackColor = true;
            this.bt_addQuest.Click += new System.EventHandler(this.bt_addQuest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер";
            // 
            // box_number
            // 
            this.box_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_number.Location = new System.Drawing.Point(171, 69);
            this.box_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.box_number.Name = "box_number";
            this.box_number.Size = new System.Drawing.Size(112, 27);
            this.box_number.TabIndex = 4;
            this.box_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.box_number.ValueChanged += new System.EventHandler(this.box_number_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дата выезда";
            // 
            // box_data_to
            // 
            this.box_data_to.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_data_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_data_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.box_data_to.Location = new System.Drawing.Point(171, 166);
            this.box_data_to.MinDate = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.box_data_to.Name = "box_data_to";
            this.box_data_to.Size = new System.Drawing.Size(141, 27);
            this.box_data_to.TabIndex = 24;
            this.box_data_to.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.box_data_to.ValueChanged += new System.EventHandler(this.box_data_to_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дата заезда";
            // 
            // box_data_from
            // 
            this.box_data_from.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_data_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_data_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.box_data_from.Location = new System.Drawing.Point(171, 114);
            this.box_data_from.MinDate = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.box_data_from.Name = "box_data_from";
            this.box_data_from.Size = new System.Drawing.Size(141, 27);
            this.box_data_from.TabIndex = 22;
            this.box_data_from.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.box_data_from.ValueChanged += new System.EventHandler(this.box_data_to_ValueChanged);
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_back.Location = new System.Drawing.Point(20, 444);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(136, 38);
            this.bt_back.TabIndex = 26;
            this.bt_back.Text = "<< Назад";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_pay
            // 
            this.bt_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_pay.Location = new System.Drawing.Point(383, 444);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(159, 38);
            this.bt_pay.TabIndex = 27;
            this.bt_pay.Text = "Оплатить";
            this.bt_pay.UseVisualStyleBackColor = true;
            this.bt_pay.Click += new System.EventHandler(this.bt_pay_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.monthCalendar1.Location = new System.Drawing.Point(171, 205);
            this.monthCalendar1.MaxSelectionCount = 100;
            this.monthCalendar1.MinDate = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 28;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 494);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bt_pay);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_data_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_data_from);
            this.Controls.Add(this.box_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_addQuest);
            this.Controls.Add(this.box_quest);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронь";
            ((System.ComponentModel.ISupportInitialize)(this.box_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_addQuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_back;
        public System.Windows.Forms.NumericUpDown box_number;
        public System.Windows.Forms.DateTimePicker box_data_to;
        public System.Windows.Forms.DateTimePicker box_data_from;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        public System.Windows.Forms.ComboBox box_quest;
        public System.Windows.Forms.Button bt_pay;
    }
}