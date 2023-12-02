
namespace bd_kursach
{
    partial class schedule
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
            this.box_empl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_time_from = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_date_to = new System.Windows.Forms.DateTimePicker();
            this.t_date_from = new System.Windows.Forms.DateTimePicker();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_set = new System.Windows.Forms.Button();
            this.t_time_do = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_work_day = new System.Windows.Forms.NumericUpDown();
            this.t_week_day = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.t_work_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_week_day)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            // 
            // box_empl
            // 
            this.box_empl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.box_empl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.box_empl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_empl.FormattingEnabled = true;
            this.box_empl.Location = new System.Drawing.Point(119, 10);
            this.box_empl.Name = "box_empl";
            this.box_empl.Size = new System.Drawing.Size(379, 28);
            this.box_empl.Sorted = true;
            this.box_empl.TabIndex = 2;
            this.box_empl.SelectedIndexChanged += new System.EventHandler(this.box_empl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начало рабочего дня";
            // 
            // t_time_from
            // 
            this.t_time_from.Enabled = false;
            this.t_time_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_time_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.t_time_from.Location = new System.Drawing.Point(249, 88);
            this.t_time_from.Name = "t_time_from";
            this.t_time_from.ShowUpDown = true;
            this.t_time_from.Size = new System.Drawing.Size(145, 27);
            this.t_time_from.TabIndex = 4;
            this.t_time_from.Value = new System.DateTime(2022, 5, 3, 9, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата начала работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата окончания работы";
            // 
            // t_date_to
            // 
            this.t_date_to.Enabled = false;
            this.t_date_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.t_date_to.Location = new System.Drawing.Point(249, 235);
            this.t_date_to.MinDate = new System.DateTime(1775, 1, 1, 0, 0, 0, 0);
            this.t_date_to.Name = "t_date_to";
            this.t_date_to.Size = new System.Drawing.Size(198, 27);
            this.t_date_to.TabIndex = 7;
            this.t_date_to.ValueChanged += new System.EventHandler(this.t_date_to_ValueChanged);
            // 
            // t_date_from
            // 
            this.t_date_from.Enabled = false;
            this.t_date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.t_date_from.Location = new System.Drawing.Point(248, 191);
            this.t_date_from.MinDate = new System.DateTime(1775, 1, 1, 0, 0, 0, 0);
            this.t_date_from.Name = "t_date_from";
            this.t_date_from.Size = new System.Drawing.Size(198, 27);
            this.t_date_from.TabIndex = 8;
            this.t_date_from.ValueChanged += new System.EventHandler(this.t_date_from_ValueChanged);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_delete.Location = new System.Drawing.Point(16, 413);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(109, 34);
            this.bt_delete.TabIndex = 9;
            this.bt_delete.Text = "Удалить";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Visible = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_set
            // 
            this.bt_set.Enabled = false;
            this.bt_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_set.Location = new System.Drawing.Point(337, 413);
            this.bt_set.Name = "bt_set";
            this.bt_set.Size = new System.Drawing.Size(109, 34);
            this.bt_set.TabIndex = 10;
            this.bt_set.Text = "Добавить";
            this.bt_set.UseVisualStyleBackColor = true;
            this.bt_set.Click += new System.EventHandler(this.bt_set_Click);
            // 
            // t_time_do
            // 
            this.t_time_do.Enabled = false;
            this.t_time_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_time_do.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.t_time_do.Location = new System.Drawing.Point(249, 131);
            this.t_time_do.Name = "t_time_do";
            this.t_time_do.ShowUpDown = true;
            this.t_time_do.Size = new System.Drawing.Size(145, 27);
            this.t_time_do.TabIndex = 12;
            this.t_time_do.Value = new System.DateTime(2022, 5, 3, 17, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Конец рабочего дня";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во рабочих дней подряд";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кол-во выходных дней подряд";
            // 
            // t_work_day
            // 
            this.t_work_day.Enabled = false;
            this.t_work_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_work_day.Location = new System.Drawing.Point(308, 304);
            this.t_work_day.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.t_work_day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.t_work_day.Name = "t_work_day";
            this.t_work_day.Size = new System.Drawing.Size(120, 27);
            this.t_work_day.TabIndex = 15;
            this.t_work_day.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // t_week_day
            // 
            this.t_week_day.Enabled = false;
            this.t_week_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_week_day.Location = new System.Drawing.Point(308, 346);
            this.t_week_day.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.t_week_day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.t_week_day.Name = "t_week_day";
            this.t_week_day.Size = new System.Drawing.Size(120, 27);
            this.t_week_day.TabIndex = 16;
            this.t_week_day.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 459);
            this.Controls.Add(this.t_week_day);
            this.Controls.Add(this.t_work_day);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_time_do);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_set);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.t_date_from);
            this.Controls.Add(this.t_date_to);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_time_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_empl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "schedule";
            this.Text = "Добавить (изменить) рассписание сотруднику";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.t_work_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_week_day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_empl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker t_time_from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker t_date_to;
        private System.Windows.Forms.DateTimePicker t_date_from;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_set;
        private System.Windows.Forms.DateTimePicker t_time_do;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown t_work_day;
        private System.Windows.Forms.NumericUpDown t_week_day;
    }
}