
namespace bd_kursach
{
    partial class hostelNumber
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
            this.employers = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.box_data_to = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.box_data_from = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_number = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.box_price_to = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_price_from = new System.Windows.Forms.TextBox();
            this.box_single_bead = new System.Windows.Forms.NumericUpDown();
            this.box_double_bead = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.tableNumber = new System.Windows.Forms.TableLayoutPanel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.box_reserv = new System.Windows.Forms.ComboBox();
            this.box_extension = new System.Windows.Forms.ComboBox();
            this.box_type = new System.Windows.Forms.ComboBox();
            this.box_date = new System.Windows.Forms.CheckBox();
            this.employers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_single_bead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_double_bead)).BeginInit();
            this.SuspendLayout();
            // 
            // employers
            // 
            this.employers.AutoScroll = true;
            this.employers.Controls.Add(this.box_date);
            this.employers.Controls.Add(this.label4);
            this.employers.Controls.Add(this.box_data_to);
            this.employers.Controls.Add(this.label3);
            this.employers.Controls.Add(this.box_data_from);
            this.employers.Controls.Add(this.panel1);
            this.employers.Controls.Add(this.label2);
            this.employers.Controls.Add(this.box_price_to);
            this.employers.Controls.Add(this.label1);
            this.employers.Controls.Add(this.box_price_from);
            this.employers.Controls.Add(this.box_single_bead);
            this.employers.Controls.Add(this.box_double_bead);
            this.employers.Controls.Add(this.label47);
            this.employers.Controls.Add(this.label48);
            this.employers.Controls.Add(this.label49);
            this.employers.Controls.Add(this.label46);
            this.employers.Controls.Add(this.label45);
            this.employers.Controls.Add(this.label44);
            this.employers.Controls.Add(this.label43);
            this.employers.Controls.Add(this.tableNumber);
            this.employers.Controls.Add(this.bt_clear);
            this.employers.Controls.Add(this.box_reserv);
            this.employers.Controls.Add(this.box_extension);
            this.employers.Controls.Add(this.box_type);
            this.employers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employers.Location = new System.Drawing.Point(0, 0);
            this.employers.Name = "employers";
            this.employers.Size = new System.Drawing.Size(1440, 700);
            this.employers.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(373, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Дата выезда";
            // 
            // box_data_to
            // 
            this.box_data_to.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_data_to.Enabled = false;
            this.box_data_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_data_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.box_data_to.Location = new System.Drawing.Point(526, 63);
            this.box_data_to.MinDate = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.box_data_to.Name = "box_data_to";
            this.box_data_to.Size = new System.Drawing.Size(141, 27);
            this.box_data_to.TabIndex = 20;
            this.box_data_to.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.box_data_to.CloseUp += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дата заезда";
            // 
            // box_data_from
            // 
            this.box_data_from.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_data_from.Enabled = false;
            this.box_data_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_data_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.box_data_from.Location = new System.Drawing.Point(214, 63);
            this.box_data_from.MinDate = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.box_data_from.Name = "box_data_from";
            this.box_data_from.Size = new System.Drawing.Size(141, 27);
            this.box_data_from.TabIndex = 18;
            this.box_data_from.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.box_data_from.CloseUp += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_number);
            this.panel1.Controls.Add(this.bt_back);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 46);
            this.panel1.TabIndex = 2;
            // 
            // bt_number
            // 
            this.bt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_number.Location = new System.Drawing.Point(925, 3);
            this.bt_number.Name = "bt_number";
            this.bt_number.Size = new System.Drawing.Size(441, 38);
            this.bt_number.TabIndex = 19;
            this.bt_number.Text = "Добавить (изменить) номера";
            this.bt_number.UseVisualStyleBackColor = true;
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_back.Location = new System.Drawing.Point(13, 3);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(136, 38);
            this.bt_back.TabIndex = 18;
            this.bt_back.Text = "<< Назад";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "до";
            // 
            // box_price_to
            // 
            this.box_price_to.Location = new System.Drawing.Point(954, 145);
            this.box_price_to.Name = "box_price_to";
            this.box_price_to.Size = new System.Drawing.Size(152, 22);
            this.box_price_to.TabIndex = 16;
            this.box_price_to.TextChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            this.box_price_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(925, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "от";
            // 
            // box_price_from
            // 
            this.box_price_from.Location = new System.Drawing.Point(954, 116);
            this.box_price_from.Name = "box_price_from";
            this.box_price_from.Size = new System.Drawing.Size(152, 22);
            this.box_price_from.TabIndex = 14;
            this.box_price_from.TextChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            this.box_price_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // box_single_bead
            // 
            this.box_single_bead.Location = new System.Drawing.Point(495, 114);
            this.box_single_bead.Name = "box_single_bead";
            this.box_single_bead.Size = new System.Drawing.Size(107, 22);
            this.box_single_bead.TabIndex = 13;
            this.box_single_bead.ValueChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // box_double_bead
            // 
            this.box_double_bead.Location = new System.Drawing.Point(374, 115);
            this.box_double_bead.Name = "box_double_bead";
            this.box_double_bead.Size = new System.Drawing.Size(107, 22);
            this.box_double_bead.TabIndex = 12;
            this.box_double_bead.ValueChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label47.Location = new System.Drawing.Point(690, 191);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(122, 20);
            this.label47.TabIndex = 11;
            this.label47.Text = "Дополнения";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.Location = new System.Drawing.Point(985, 191);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(56, 20);
            this.label48.TabIndex = 11;
            this.label48.Text = "Цена";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label49.Location = new System.Drawing.Point(1165, 191);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(109, 20);
            this.label49.TabIndex = 11;
            this.label49.Text = "Занятость";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.Location = new System.Drawing.Point(491, 151);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(148, 60);
            this.label46.TabIndex = 11;
            this.label46.Text = "кол-во\r\nодноспальных \r\nкроватей";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.Location = new System.Drawing.Point(351, 151);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(144, 60);
            this.label45.TabIndex = 11;
            this.label45.Text = "кол-во \r\nдвухспальных \r\nкроватей";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.Location = new System.Drawing.Point(144, 191);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(116, 20);
            this.label44.TabIndex = 9;
            this.label44.Text = "Тип номера";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(28, 191);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(26, 20);
            this.label43.TabIndex = 7;
            this.label43.Text = "№";
            // 
            // tableNumber
            // 
            this.tableNumber.AutoSize = true;
            this.tableNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableNumber.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableNumber.ColumnCount = 8;
            this.tableNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableNumber.Location = new System.Drawing.Point(15, 210);
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.RowCount = 1;
            this.tableNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableNumber.Size = new System.Drawing.Size(1380, 44);
            this.tableNumber.TabIndex = 11;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(1209, 145);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(104, 31);
            this.bt_clear.TabIndex = 8;
            this.bt_clear.Text = "Очистить";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // box_reserv
            // 
            this.box_reserv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.box_reserv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.box_reserv.Enabled = false;
            this.box_reserv.FormattingEnabled = true;
            this.box_reserv.Items.AddRange(new object[] {
            "занятый",
            "свободный"});
            this.box_reserv.Location = new System.Drawing.Point(1125, 115);
            this.box_reserv.Name = "box_reserv";
            this.box_reserv.Size = new System.Drawing.Size(188, 24);
            this.box_reserv.Sorted = true;
            this.box_reserv.TabIndex = 6;
            this.box_reserv.SelectedIndexChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // box_extension
            // 
            this.box_extension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.box_extension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.box_extension.FormattingEnabled = true;
            this.box_extension.Location = new System.Drawing.Point(622, 114);
            this.box_extension.Name = "box_extension";
            this.box_extension.Size = new System.Drawing.Size(286, 24);
            this.box_extension.Sorted = true;
            this.box_extension.TabIndex = 3;
            this.box_extension.SelectedIndexChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // box_type
            // 
            this.box_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.box_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.box_type.FormattingEnabled = true;
            this.box_type.Location = new System.Drawing.Point(70, 114);
            this.box_type.Name = "box_type";
            this.box_type.Size = new System.Drawing.Size(297, 24);
            this.box_type.Sorted = true;
            this.box_type.TabIndex = 1;
            this.box_type.SelectedIndexChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // box_date
            // 
            this.box_date.AutoSize = true;
            this.box_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_date.Location = new System.Drawing.Point(32, 69);
            this.box_date.MinimumSize = new System.Drawing.Size(20, 20);
            this.box_date.Name = "box_date";
            this.box_date.Size = new System.Drawing.Size(20, 20);
            this.box_date.TabIndex = 22;
            this.box_date.UseVisualStyleBackColor = true;
            this.box_date.CheckedChanged += new System.EventHandler(this.box_date_CheckedChanged);
            // 
            // hostelNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 700);
            this.Controls.Add(this.employers);
            this.MaximizeBox = false;
            this.Name = "hostelNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Номера";
            this.employers.ResumeLayout(false);
            this.employers.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_single_bead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_double_bead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel employers;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TableLayoutPanel tableNumber;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.ComboBox box_reserv;
        private System.Windows.Forms.ComboBox box_extension;
        private System.Windows.Forms.ComboBox box_type;
        private System.Windows.Forms.NumericUpDown box_single_bead;
        private System.Windows.Forms.NumericUpDown box_double_bead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_price_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_price_from;
        private System.Windows.Forms.DateTimePicker box_data_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker box_data_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button bt_number;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.CheckBox box_date;
    }
}