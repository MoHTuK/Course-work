namespace Course_work
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataBaseInfo = new System.Windows.Forms.DataGridView();
            this.NumberOfSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOOfSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoutryOfSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KindOfSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceOfSportsman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfSportsmanNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlaceOfSportsmanNummericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.PrizeListButton = new System.Windows.Forms.Button();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.KindOfSportComboBox = new System.Windows.Forms.ComboBox();
            this.CountryPrizeButton = new System.Windows.Forms.Button();
            this.InfoMedalButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DowanloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSportsmanNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceOfSportsmanNummericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBaseInfo
            // 
            this.DataBaseInfo.AllowUserToAddRows = false;
            this.DataBaseInfo.AllowUserToDeleteRows = false;
            this.DataBaseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfSportsman,
            this.FIOOfSportsman,
            this.CoutryOfSportsman,
            this.KindOfSport,
            this.PlaceOfSportsman});
            this.DataBaseInfo.Location = new System.Drawing.Point(284, 12);
            this.DataBaseInfo.Name = "DataBaseInfo";
            this.DataBaseInfo.ReadOnly = true;
            this.DataBaseInfo.RowHeadersVisible = false;
            this.DataBaseInfo.Size = new System.Drawing.Size(606, 243);
            this.DataBaseInfo.TabIndex = 0;
            // 
            // NumberOfSportsman
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.NumberOfSportsman.DefaultCellStyle = dataGridViewCellStyle2;
            this.NumberOfSportsman.HeaderText = "№ Учасника";
            this.NumberOfSportsman.Name = "NumberOfSportsman";
            this.NumberOfSportsman.ReadOnly = true;
            this.NumberOfSportsman.Width = 60;
            // 
            // FIOOfSportsman
            // 
            this.FIOOfSportsman.HeaderText = "ФИО";
            this.FIOOfSportsman.Name = "FIOOfSportsman";
            this.FIOOfSportsman.ReadOnly = true;
            this.FIOOfSportsman.Width = 200;
            // 
            // CoutryOfSportsman
            // 
            this.CoutryOfSportsman.HeaderText = "Страна";
            this.CoutryOfSportsman.Name = "CoutryOfSportsman";
            this.CoutryOfSportsman.ReadOnly = true;
            this.CoutryOfSportsman.Width = 150;
            // 
            // KindOfSport
            // 
            this.KindOfSport.HeaderText = "Вид спорта";
            this.KindOfSport.Name = "KindOfSport";
            this.KindOfSport.ReadOnly = true;
            // 
            // PlaceOfSportsman
            // 
            this.PlaceOfSportsman.HeaderText = "Место";
            this.PlaceOfSportsman.Name = "PlaceOfSportsman";
            this.PlaceOfSportsman.ReadOnly = true;
            // 
            // NumberOfSportsmanNumericUpDown
            // 
            this.NumberOfSportsmanNumericUpDown.Location = new System.Drawing.Point(192, 25);
            this.NumberOfSportsmanNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumberOfSportsmanNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfSportsmanNumericUpDown.Name = "NumberOfSportsmanNumericUpDown";
            this.NumberOfSportsmanNumericUpDown.Size = new System.Drawing.Size(86, 20);
            this.NumberOfSportsmanNumericUpDown.TabIndex = 1;
            this.NumberOfSportsmanNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "№ Учасника";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(133, 51);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(145, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(133, 77);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(145, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(133, 103);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(145, 20);
            this.PatronymicTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Страна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Вид Спорта";
            // 
            // PlaceOfSportsmanNummericUpDown
            // 
            this.PlaceOfSportsmanNummericUpDown.Location = new System.Drawing.Point(192, 181);
            this.PlaceOfSportsmanNummericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlaceOfSportsmanNummericUpDown.Name = "PlaceOfSportsmanNummericUpDown";
            this.PlaceOfSportsmanNummericUpDown.Size = new System.Drawing.Size(86, 20);
            this.PlaceOfSportsmanNummericUpDown.TabIndex = 13;
            this.PlaceOfSportsmanNummericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Занятое место";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(15, 217);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(218, 38);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Добавить в список";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButton.Location = new System.Drawing.Point(815, 261);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 40);
            this.DelButton.TabIndex = 16;
            this.DelButton.Text = "Удалить Учасника";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // PrizeListButton
            // 
            this.PrizeListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrizeListButton.Location = new System.Drawing.Point(284, 261);
            this.PrizeListButton.Name = "PrizeListButton";
            this.PrizeListButton.Size = new System.Drawing.Size(75, 40);
            this.PrizeListButton.TabIndex = 17;
            this.PrizeListButton.Text = "Список призеров";
            this.PrizeListButton.UseVisualStyleBackColor = true;
            this.PrizeListButton.Click += new System.EventHandler(this.PrizeListButton_Click);
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountryComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CountryComboBox.Items.AddRange(new object[] {
            "Австралия",
            "Австрия",
            "Азербайджан",
            "Албания",
            "Алжир",
            "Ангола ",
            "Андорра",
            "Антигуа и Барбуда",
            "Аргентина",
            "Армения",
            "Афганистан",
            "Багамские Острова",
            "Бангладеш",
            "Барбадос",
            "Бахрейн",
            "Белоруссия",
            "Белиз",
            "Бельгия",
            "Бенин",
            "Болгария",
            "Боливия",
            "Босния и Герцеговина",
            "Ботсвана",
            "Бразилия",
            "Бруней",
            "Буркина-Фасо",
            "Бурунди",
            "Бутан",
            "Вануату",
            "Великобритания",
            "Венгрия",
            "Венесуэла",
            "Восточный Тимор",
            "Вьетнам",
            "Габон",
            "Гаити",
            "Гайана",
            "Гамбия",
            "Гана",
            "Гватемала",
            "Гвинея",
            "Гвинея-Бисау",
            "Германия",
            "Гондурас",
            "Гренада",
            "Греция",
            "Грузия",
            "Дания",
            "Джибути",
            "Доминика",
            "Доминиканская Республика",
            "Египет",
            "Замбия",
            "Зимбабве",
            "Израиль",
            "Индия",
            "Индонезия",
            "Иордания",
            "Ирак",
            "Иран",
            "Ирландия",
            "Исландия",
            "Испания",
            "Италия",
            "Йемен",
            "Кабо-Верде",
            "Казахстан",
            "Камбоджа",
            "Камерун",
            "Канада",
            "Катар",
            "Кения",
            "Кипр",
            "Киргизия",
            "Кирибати",
            "Китай",
            "Колумбия",
            "Коморы",
            "Республика Конго",
            "Демократическая Республика Конго",
            "КНДР",
            "Республика Корея",
            "Коста-Рика",
            "Кот-д’Ивуар",
            "Куба",
            "Кувейт",
            "Лаос",
            "Латвия",
            "Лесото",
            "Либерия",
            "Ливан",
            "Ливия",
            "Литва",
            "Лихтенштейн",
            "Люксембург",
            "Маврикий",
            "Мавритания",
            "Мадагаскар",
            "Малави",
            "Малайзия",
            "Мали",
            "Мальдивы",
            "Мальта",
            "Марокко",
            "Маршалловы Острова",
            "Мексика",
            "Мозамбик",
            "Молдавия",
            "Монако",
            "Монголия",
            "Мьянма",
            "Намибия",
            "Науру",
            "Непал",
            "Нигер",
            "Нигерия",
            "Нидерланды",
            "Никарагуа",
            "Новая Зеландия",
            "Норвегия",
            "ОАЭ",
            "Оман",
            "Пакистан",
            "Палау",
            "Панама",
            "Папуа — Новая Гвинея",
            "Парагвай",
            "Перу",
            "Польша",
            "Португалия",
            "Россия",
            "Руанда",
            "Румыния",
            "Сальвадор",
            "Самоа",
            "Сан-Марино",
            "Сан-Томе и Принсипи",
            "Саудовская Аравия",
            "Северная Македония",
            "Сейшельские Острова",
            "Сенегал",
            "Сент-Винсент и Гренадины",
            "Сент-Китс и Невис",
            "Сент-Люсия",
            "Сербия",
            "Сингапур",
            "Сирия",
            "Словакия",
            "Словения",
            "США",
            "Соломоновы Острова",
            "Сомали",
            "Судан",
            "Суринам",
            "Сьерра-Леоне",
            "Таджикистан",
            "Таиланд",
            "Танзания",
            "Того",
            "Тонга",
            "Тринидад и Тобаго",
            "Тувалу",
            "Тунис",
            "Туркмения",
            "Турция",
            "Уганда",
            "Узбекистан",
            "Украина",
            "Уругвай",
            "Федеративные Штаты Микронезии",
            "Фиджи",
            "Филиппины",
            "Финляндия",
            "Франция",
            "Хорватия",
            "Центральноафриканская Республика",
            "Чад",
            "Черногория",
            "Чехия",
            "Чили",
            "Швейцария",
            "Швеция",
            "Шри-Ланка",
            "Эквадор",
            "Экваториальная Гвинея",
            "Эритрея",
            "Эсватини",
            "Эстония",
            "Эфиопия",
            "ЮАР",
            "Южный Судан",
            "Ямайка",
            "Япония"});
            this.CountryComboBox.Location = new System.Drawing.Point(112, 128);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(166, 21);
            this.CountryComboBox.TabIndex = 18;
            // 
            // KindOfSportComboBox
            // 
            this.KindOfSportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindOfSportComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KindOfSportComboBox.FormattingEnabled = true;
            this.KindOfSportComboBox.Items.AddRange(new object[] {
            "Бадминтон",
            "Баскетбол",
            "Бейсбол",
            "Бокс",
            "Борьба вольная",
            "Борьба греко-римская",
            "Велосипедный спорт",
            "Водное поло",
            "Волейбол",
            "Волейбол пляжный",
            "Гандбол",
            "Гимнастика спортивная",
            "Гимнастика художественная",
            "Гребля академическая",
            "Гребля на байдарках и каноэ",
            "Гребной слалом на байдарках и каноэ",
            "Дзюдо",
            "Конный спорт",
            "Легкая атлетика",
            "Парусный спорт",
            "Плавание",
            "Плавание синхронное",
            "Прыжки в воду",
            "Прыжки на батуте",
            "Современное пятиборье",
            "Стрельба из лука",
            "Стрельба пулевая",
            "Стрельба стендовая",
            "Таэквондо",
            "Теннис",
            "Теннис настольный",
            "Триатлон",
            "Тяжелая атлетика",
            "Фехтование",
            "Футбол",
            "Хоккей на траве",
            "Биатлон",
            "Горнолыжный спорт",
            "Керлинг",
            "Конькобежный спорт",
            "Лыжные гонки",
            "Лыжное двоеборье",
            "Прыжки на лыжах с трамплина",
            "Сноуборд",
            "Фигурное катание на коньках",
            "Фристайл",
            "Хоккей",
            "Шорт-трек"});
            this.KindOfSportComboBox.Location = new System.Drawing.Point(112, 154);
            this.KindOfSportComboBox.Name = "KindOfSportComboBox";
            this.KindOfSportComboBox.Size = new System.Drawing.Size(166, 21);
            this.KindOfSportComboBox.TabIndex = 19;
            // 
            // CountryPrizeButton
            // 
            this.CountryPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryPrizeButton.Location = new System.Drawing.Point(734, 261);
            this.CountryPrizeButton.Name = "CountryPrizeButton";
            this.CountryPrizeButton.Size = new System.Drawing.Size(75, 40);
            this.CountryPrizeButton.TabIndex = 20;
            this.CountryPrizeButton.Text = "Призеры Странны";
            this.CountryPrizeButton.UseVisualStyleBackColor = true;
            this.CountryPrizeButton.Click += new System.EventHandler(this.CountryPrizeButton_Click);
            // 
            // InfoMedalButton
            // 
            this.InfoMedalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoMedalButton.Location = new System.Drawing.Point(365, 261);
            this.InfoMedalButton.Name = "InfoMedalButton";
            this.InfoMedalButton.Size = new System.Drawing.Size(91, 40);
            this.InfoMedalButton.TabIndex = 21;
            this.InfoMedalButton.Text = "Информация о медалях";
            this.InfoMedalButton.UseVisualStyleBackColor = true;
            this.InfoMedalButton.Click += new System.EventHandler(this.InfoMedalButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(463, 261);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(265, 177);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(15, 299);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 52);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Сохранить базу данных";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DowanloadButton
            // 
            this.DowanloadButton.Location = new System.Drawing.Point(138, 299);
            this.DowanloadButton.Name = "DowanloadButton";
            this.DowanloadButton.Size = new System.Drawing.Size(95, 52);
            this.DowanloadButton.TabIndex = 24;
            this.DowanloadButton.Text = "Загрузить базу данных";
            this.DowanloadButton.UseVisualStyleBackColor = true;
            this.DowanloadButton.Click += new System.EventHandler(this.DowanloadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.DowanloadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.InfoMedalButton);
            this.Controls.Add(this.CountryPrizeButton);
            this.Controls.Add(this.KindOfSportComboBox);
            this.Controls.Add(this.CountryComboBox);
            this.Controls.Add(this.PrizeListButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlaceOfSportsmanNummericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfSportsmanNumericUpDown);
            this.Controls.Add(this.DataBaseInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSportsmanNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceOfSportsmanNummericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBaseInfo;
        private System.Windows.Forms.NumericUpDown NumberOfSportsmanNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PlaceOfSportsmanNummericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button PrizeListButton;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.ComboBox KindOfSportComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOOfSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoutryOfSportsman;
        private System.Windows.Forms.DataGridViewTextBoxColumn KindOfSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceOfSportsman;
        private System.Windows.Forms.Button CountryPrizeButton;
        private System.Windows.Forms.Button InfoMedalButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DowanloadButton;
    }
}

