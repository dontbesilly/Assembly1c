namespace Assembly
{
    partial class MainForm
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
            this.btnGo = new System.Windows.Forms.Button();
            this.clbRoute = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAssembly = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbEmptyBase = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbDemoBase = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbMainBase = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbNameMainForUpload = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNameDemoForUpload = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPreviousRelease = new System.Windows.Forms.TextBox();
            this.tbRelease = new System.Windows.Forms.TextBox();
            this.tbRootFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFolderForTest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbServerLicense = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlatform = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDeleteBase = new System.Windows.Forms.Button();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.btnAddBase = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRepositoryBase = new System.Windows.Forms.CheckBox();
            this.tbRepositoryPass = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbRepositoryUser = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbRepository = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbServerBase = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbBaseFolder = new System.Windows.Forms.TextBox();
            this.tbBaseUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbPatternUpdate = new System.Windows.Forms.TextBox();
            this.tbPatternFull = new System.Windows.Forms.TextBox();
            this.tbResultUpdate = new System.Windows.Forms.TextBox();
            this.tbResultFull = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbPatterns = new System.Windows.Forms.TextBox();
            this.tbDelivery = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbPackage = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbArchive = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDeleteAssembly = new System.Windows.Forms.Button();
            this.btnAddAssembly = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 682);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(411, 33);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Начать сборку";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // clbRoute
            // 
            this.clbRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbRoute.FormattingEnabled = true;
            this.clbRoute.Location = new System.Drawing.Point(7, 46);
            this.clbRoute.Margin = new System.Windows.Forms.Padding(4);
            this.clbRoute.Name = "clbRoute";
            this.clbRoute.Size = new System.Drawing.Size(657, 424);
            this.clbRoute.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сборка";
            // 
            // cbAssembly
            // 
            this.cbAssembly.FormattingEnabled = true;
            this.cbAssembly.Location = new System.Drawing.Point(83, 10);
            this.cbAssembly.Name = "cbAssembly";
            this.cbAssembly.Size = new System.Drawing.Size(201, 27);
            this.cbAssembly.TabIndex = 3;
            this.cbAssembly.SelectedIndexChanged += new System.EventHandler(this.cbAssembly_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 164);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 511);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUncheckAll);
            this.tabPage1.Controls.Add(this.btnCheckAll);
            this.tabPage1.Controls.Add(this.clbRoute);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Маршрут";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(135, 6);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(85, 33);
            this.btnUncheckAll.TabIndex = 3;
            this.btnUncheckAll.Text = "Снять все";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(7, 7);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(122, 32);
            this.btnCheckAll.TabIndex = 2;
            this.btnCheckAll.Text = "Установить все";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbEmptyBase);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.cbDemoBase);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.cbMainBase);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbNameMainForUpload);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbNameDemoForUpload);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbRootFolder);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbPlatform);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Атрибуты сборки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbEmptyBase
            // 
            this.cbEmptyBase.FormattingEnabled = true;
            this.cbEmptyBase.Location = new System.Drawing.Point(232, 162);
            this.cbEmptyBase.Name = "cbEmptyBase";
            this.cbEmptyBase.Size = new System.Drawing.Size(323, 27);
            this.cbEmptyBase.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 19);
            this.label18.TabIndex = 18;
            this.label18.Text = "Пустая база";
            // 
            // cbDemoBase
            // 
            this.cbDemoBase.FormattingEnabled = true;
            this.cbDemoBase.Location = new System.Drawing.Point(232, 123);
            this.cbDemoBase.Name = "cbDemoBase";
            this.cbDemoBase.Size = new System.Drawing.Size(323, 27);
            this.cbDemoBase.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 19);
            this.label17.TabIndex = 16;
            this.label17.Text = "Демонстрационная база";
            // 
            // cbMainBase
            // 
            this.cbMainBase.FormattingEnabled = true;
            this.cbMainBase.Location = new System.Drawing.Point(232, 84);
            this.cbMainBase.Name = "cbMainBase";
            this.cbMainBase.Size = new System.Drawing.Size(323, 27);
            this.cbMainBase.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 38);
            this.label16.TabIndex = 14;
            this.label16.Text = "Основная база \r\n(не идет в поставку)";
            // 
            // tbNameMainForUpload
            // 
            this.tbNameMainForUpload.Location = new System.Drawing.Point(232, 250);
            this.tbNameMainForUpload.Name = "tbNameMainForUpload";
            this.tbNameMainForUpload.Size = new System.Drawing.Size(323, 26);
            this.tbNameMainForUpload.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 38);
            this.label8.TabIndex = 12;
            this.label8.Text = "Имя основной базы\r\nдля загрузки";
            // 
            // tbNameDemoForUpload
            // 
            this.tbNameDemoForUpload.Location = new System.Drawing.Point(232, 204);
            this.tbNameDemoForUpload.Name = "tbNameDemoForUpload";
            this.tbNameDemoForUpload.Size = new System.Drawing.Size(323, 26);
            this.tbNameDemoForUpload.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 38);
            this.label7.TabIndex = 10;
            this.label7.Text = "Имя демонстрационной базы\r\nдля загрузки";
            // 
            // tbPreviousRelease
            // 
            this.tbPreviousRelease.Location = new System.Drawing.Point(278, 73);
            this.tbPreviousRelease.Multiline = true;
            this.tbPreviousRelease.Name = "tbPreviousRelease";
            this.tbPreviousRelease.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPreviousRelease.Size = new System.Drawing.Size(409, 74);
            this.tbPreviousRelease.TabIndex = 9;
            // 
            // tbRelease
            // 
            this.tbRelease.Location = new System.Drawing.Point(16, 73);
            this.tbRelease.Name = "tbRelease";
            this.tbRelease.Size = new System.Drawing.Size(243, 26);
            this.tbRelease.TabIndex = 8;
            // 
            // tbRootFolder
            // 
            this.tbRootFolder.Location = new System.Drawing.Point(232, 43);
            this.tbRootFolder.Name = "tbRootFolder";
            this.tbRootFolder.Size = new System.Drawing.Size(323, 26);
            this.tbRootFolder.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Предыдущие релизы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер релиза";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFolderForTest);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbPrefix);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbServerLicense);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Необязательные поля";
            // 
            // tbFolderForTest
            // 
            this.tbFolderForTest.Location = new System.Drawing.Point(114, 80);
            this.tbFolderForTest.Name = "tbFolderForTest";
            this.tbFolderForTest.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbFolderForTest.Size = new System.Drawing.Size(537, 26);
            this.tbFolderForTest.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 38);
            this.label10.TabIndex = 7;
            this.label10.Text = "Каталог\r\nтестирования";
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(373, 31);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(141, 26);
            this.tbPrefix.TabIndex = 6;
            this.tbPrefix.Text = "_";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Префикс";
            // 
            // tbServerLicense
            // 
            this.tbServerLicense.Location = new System.Drawing.Point(140, 31);
            this.tbServerLicense.Name = "tbServerLicense";
            this.tbServerLicense.Size = new System.Drawing.Size(141, 26);
            this.tbServerLicense.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сервер лицензий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Корневой каталог сборки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Полный путь до платформы";
            // 
            // tbPlatform
            // 
            this.tbPlatform.Location = new System.Drawing.Point(232, 6);
            this.tbPlatform.Name = "tbPlatform";
            this.tbPlatform.Size = new System.Drawing.Size(323, 26);
            this.tbPlatform.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDeleteBase);
            this.tabPage4.Controls.Add(this.cbBase);
            this.tabPage4.Controls.Add(this.btnAddBase);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(671, 479);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Базы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBase
            // 
            this.btnDeleteBase.Location = new System.Drawing.Point(311, 62);
            this.btnDeleteBase.Name = "btnDeleteBase";
            this.btnDeleteBase.Size = new System.Drawing.Size(110, 28);
            this.btnDeleteBase.TabIndex = 14;
            this.btnDeleteBase.Text = "Удалить";
            this.btnDeleteBase.UseVisualStyleBackColor = true;
            this.btnDeleteBase.Click += new System.EventHandler(this.btnDeleteBase_Click);
            // 
            // cbBase
            // 
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Location = new System.Drawing.Point(103, 15);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(318, 27);
            this.cbBase.TabIndex = 13;
            this.cbBase.SelectedIndexChanged += new System.EventHandler(this.cbBase_SelectedIndexChanged);
            // 
            // btnAddBase
            // 
            this.btnAddBase.Location = new System.Drawing.Point(21, 62);
            this.btnAddBase.Name = "btnAddBase";
            this.btnAddBase.Size = new System.Drawing.Size(284, 26);
            this.btnAddBase.TabIndex = 12;
            this.btnAddBase.Text = "Добавить/перезаписать базу";
            this.btnAddBase.UseVisualStyleBackColor = true;
            this.btnAddBase.Click += new System.EventHandler(this.btnAddBase_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbRepositoryBase);
            this.groupBox3.Controls.Add(this.tbRepositoryPass);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.tbRepositoryUser);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbRepository);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(11, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 177);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Хранилище (если подключена)";
            // 
            // cbRepositoryBase
            // 
            this.cbRepositoryBase.AutoSize = true;
            this.cbRepositoryBase.Location = new System.Drawing.Point(192, 25);
            this.cbRepositoryBase.Name = "cbRepositoryBase";
            this.cbRepositoryBase.Size = new System.Drawing.Size(202, 23);
            this.cbRepositoryBase.TabIndex = 15;
            this.cbRepositoryBase.Text = "Подключена к хранилищу";
            this.cbRepositoryBase.UseVisualStyleBackColor = true;
            // 
            // tbRepositoryPass
            // 
            this.tbRepositoryPass.Location = new System.Drawing.Point(192, 136);
            this.tbRepositoryPass.Name = "tbRepositoryPass";
            this.tbRepositoryPass.Size = new System.Drawing.Size(460, 26);
            this.tbRepositoryPass.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 19);
            this.label19.TabIndex = 13;
            this.label19.Text = "Пароль пользователя";
            // 
            // tbRepositoryUser
            // 
            this.tbRepositoryUser.Location = new System.Drawing.Point(192, 92);
            this.tbRepositoryUser.Name = "tbRepositoryUser";
            this.tbRepositoryUser.Size = new System.Drawing.Size(460, 26);
            this.tbRepositoryUser.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 38);
            this.label15.TabIndex = 11;
            this.label15.Text = "Пользователь\r\nхранилища";
            // 
            // tbRepository
            // 
            this.tbRepository.Location = new System.Drawing.Point(192, 57);
            this.tbRepository.Name = "tbRepository";
            this.tbRepository.Size = new System.Drawing.Size(460, 26);
            this.tbRepository.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 19);
            this.label14.TabIndex = 9;
            this.label14.Text = "Адрес хранилища";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbServerBase);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbBaseFolder);
            this.groupBox2.Controls.Add(this.tbBaseUser);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(11, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основные настройки базы";
            // 
            // cbServerBase
            // 
            this.cbServerBase.AutoSize = true;
            this.cbServerBase.Location = new System.Drawing.Point(147, 25);
            this.cbServerBase.Name = "cbServerBase";
            this.cbServerBase.Size = new System.Drawing.Size(100, 23);
            this.cbServerBase.TabIndex = 8;
            this.cbServerBase.Text = "Серверная";
            this.cbServerBase.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Путь до базы";
            // 
            // tbBaseFolder
            // 
            this.tbBaseFolder.Location = new System.Drawing.Point(147, 61);
            this.tbBaseFolder.Name = "tbBaseFolder";
            this.tbBaseFolder.Size = new System.Drawing.Size(505, 26);
            this.tbBaseFolder.TabIndex = 5;
            // 
            // tbBaseUser
            // 
            this.tbBaseUser.Location = new System.Drawing.Point(147, 93);
            this.tbBaseUser.Name = "tbBaseUser";
            this.tbBaseUser.Size = new System.Drawing.Size(505, 26);
            this.tbBaseUser.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Пользователь";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Имя базы";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbPatternUpdate);
            this.tabPage3.Controls.Add(this.tbPatternFull);
            this.tabPage3.Controls.Add(this.tbResultUpdate);
            this.tabPage3.Controls.Add(this.tbResultFull);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.tbPatterns);
            this.tabPage3.Controls.Add(this.tbDelivery);
            this.tabPage3.Controls.Add(this.tbResult);
            this.tabPage3.Controls.Add(this.tbPackage);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.tbArchive);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Шаблон папок";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbPatternUpdate
            // 
            this.tbPatternUpdate.Location = new System.Drawing.Point(174, 354);
            this.tbPatternUpdate.Name = "tbPatternUpdate";
            this.tbPatternUpdate.Size = new System.Drawing.Size(298, 26);
            this.tbPatternUpdate.TabIndex = 19;
            // 
            // tbPatternFull
            // 
            this.tbPatternFull.Location = new System.Drawing.Point(174, 318);
            this.tbPatternFull.Name = "tbPatternFull";
            this.tbPatternFull.Size = new System.Drawing.Size(298, 26);
            this.tbPatternFull.TabIndex = 18;
            // 
            // tbResultUpdate
            // 
            this.tbResultUpdate.Location = new System.Drawing.Point(174, 202);
            this.tbResultUpdate.Name = "tbResultUpdate";
            this.tbResultUpdate.Size = new System.Drawing.Size(298, 26);
            this.tbResultUpdate.TabIndex = 17;
            // 
            // tbResultFull
            // 
            this.tbResultFull.Location = new System.Drawing.Point(174, 162);
            this.tbResultFull.Name = "tbResultFull";
            this.tbResultFull.Size = new System.Drawing.Size(298, 26);
            this.tbResultFull.TabIndex = 16;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 357);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(149, 19);
            this.label29.TabIndex = 15;
            this.label29.Text = "Шаблон обновление";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 321);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(122, 19);
            this.label28.TabIndex = 14;
            this.label28.Text = "Шаблон полный";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 205);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(157, 19);
            this.label27.TabIndex = 13;
            this.label27.Text = "Результат обновление";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 165);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(130, 19);
            this.label26.TabIndex = 12;
            this.label26.Text = "Результат полный";
            // 
            // tbPatterns
            // 
            this.tbPatterns.Location = new System.Drawing.Point(174, 277);
            this.tbPatterns.Name = "tbPatterns";
            this.tbPatterns.Size = new System.Drawing.Size(298, 26);
            this.tbPatterns.TabIndex = 11;
            // 
            // tbDelivery
            // 
            this.tbDelivery.Location = new System.Drawing.Point(174, 239);
            this.tbDelivery.Name = "tbDelivery";
            this.tbDelivery.Size = new System.Drawing.Size(298, 26);
            this.tbDelivery.TabIndex = 10;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(174, 114);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(298, 26);
            this.tbResult.TabIndex = 9;
            // 
            // tbPackage
            // 
            this.tbPackage.Location = new System.Drawing.Point(174, 64);
            this.tbPackage.Name = "tbPackage";
            this.tbPackage.Size = new System.Drawing.Size(298, 26);
            this.tbPackage.TabIndex = 8;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 280);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 19);
            this.label25.TabIndex = 7;
            this.label25.Text = "Шаблоны";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 242);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 19);
            this.label24.TabIndex = 6;
            this.label24.Text = "Файлы поставки";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 117);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 19);
            this.label23.TabIndex = 5;
            this.label23.Text = "Результат";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(152, 19);
            this.label22.TabIndex = 4;
            this.label22.Text = "Комплекты поставки";
            // 
            // tbArchive
            // 
            this.tbArchive.Location = new System.Drawing.Point(174, 17);
            this.tbArchive.Name = "tbArchive";
            this.tbArchive.Size = new System.Drawing.Size(298, 26);
            this.tbArchive.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Архив .cf файлов";
            // 
            // btnDeleteAssembly
            // 
            this.btnDeleteAssembly.Location = new System.Drawing.Point(438, 9);
            this.btnDeleteAssembly.Name = "btnDeleteAssembly";
            this.btnDeleteAssembly.Size = new System.Drawing.Size(90, 26);
            this.btnDeleteAssembly.TabIndex = 8;
            this.btnDeleteAssembly.Text = "Удалить";
            this.btnDeleteAssembly.UseVisualStyleBackColor = true;
            this.btnDeleteAssembly.Click += new System.EventHandler(this.btnDeleteAssembly_Click);
            // 
            // btnAddAssembly
            // 
            this.btnAddAssembly.Location = new System.Drawing.Point(290, 9);
            this.btnAddAssembly.Name = "btnAddAssembly";
            this.btnAddAssembly.Size = new System.Drawing.Size(142, 27);
            this.btnAddAssembly.TabIndex = 5;
            this.btnAddAssembly.Text = "Сохранить сборку";
            this.btnAddAssembly.UseVisualStyleBackColor = true;
            this.btnAddAssembly.Click += new System.EventHandler(this.btnAddAssembly_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 728);
            this.Controls.Add(this.btnDeleteAssembly);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbAssembly);
            this.Controls.Add(this.btnAddAssembly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRelease);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPreviousRelease);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сборка релизов 1С";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckedListBox clbRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAssembly;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlatform;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameMainForUpload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNameDemoForUpload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPreviousRelease;
        private System.Windows.Forms.TextBox tbRelease;
        private System.Windows.Forms.TextBox tbRootFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFolderForTest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbServerLicense;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbRepositoryUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbRepository;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbBaseFolder;
        private System.Windows.Forms.TextBox tbBaseUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddAssembly;
        private System.Windows.Forms.Button btnDeleteAssembly;
        private System.Windows.Forms.Button btnAddBase;
        private System.Windows.Forms.ComboBox cbEmptyBase;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbDemoBase;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbMainBase;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRepositoryPass;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbRepositoryBase;
        private System.Windows.Forms.CheckBox cbServerBase;
        private System.Windows.Forms.Button btnDeleteBase;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.TextBox tbArchive;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbPatternUpdate;
        private System.Windows.Forms.TextBox tbPatternFull;
        private System.Windows.Forms.TextBox tbResultUpdate;
        private System.Windows.Forms.TextBox tbResultFull;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbPatterns;
        private System.Windows.Forms.TextBox tbDelivery;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbPackage;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
    }
}

