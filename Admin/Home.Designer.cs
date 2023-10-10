namespace Admin
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CourseTab = new System.Windows.Forms.TabPage();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTrainer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDayOfWeek = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GridViewCourse = new System.Windows.Forms.DataGridView();
            this.TrainerTab = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhoneTrainer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkGenderTrainer = new System.Windows.Forms.CheckBox();
            this.txtSearchTrainer = new System.Windows.Forms.TextBox();
            this.btnSearchTrainer = new System.Windows.Forms.Button();
            this.GridViewTrainer = new System.Windows.Forms.DataGridView();
            this.dateTrainer = new System.Windows.Forms.DateTimePicker();
            this.txtNameTrainer = new System.Windows.Forms.TextBox();
            this.txtIDTrainer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateTrainer = new System.Windows.Forms.Button();
            this.btnClearTrainer = new System.Windows.Forms.Button();
            this.btnAddTrainer = new System.Windows.Forms.Button();
            this.AccountTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchAcc = new System.Windows.Forms.TextBox();
            this.btnSearchAcc = new System.Windows.Forms.Button();
            this.GridViewAccount = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.CourseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCourse)).BeginInit();
            this.TrainerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTrainer)).BeginInit();
            this.AccountTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CourseTab);
            this.tabControl1.Controls.Add(this.TrainerTab);
            this.tabControl1.Controls.Add(this.AccountTab);
            this.tabControl1.Location = new System.Drawing.Point(-2, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1487, 757);
            this.tabControl1.TabIndex = 1;
            // 
            // CourseTab
            // 
            this.CourseTab.Controls.Add(this.dateEnd);
            this.CourseTab.Controls.Add(this.dateStart);
            this.CourseTab.Controls.Add(this.label6);
            this.CourseTab.Controls.Add(this.label5);
            this.CourseTab.Controls.Add(this.comboTrainer);
            this.CourseTab.Controls.Add(this.label4);
            this.CourseTab.Controls.Add(this.comboDayOfWeek);
            this.CourseTab.Controls.Add(this.txtName);
            this.CourseTab.Controls.Add(this.txtID);
            this.CourseTab.Controls.Add(this.label3);
            this.CourseTab.Controls.Add(this.label2);
            this.CourseTab.Controls.Add(this.label1);
            this.CourseTab.Controls.Add(this.txtSearch);
            this.CourseTab.Controls.Add(this.btnUpdate);
            this.CourseTab.Controls.Add(this.btnClear);
            this.CourseTab.Controls.Add(this.btnAdd);
            this.CourseTab.Controls.Add(this.btnSearch);
            this.CourseTab.Controls.Add(this.GridViewCourse);
            this.CourseTab.Location = new System.Drawing.Point(4, 29);
            this.CourseTab.Name = "CourseTab";
            this.CourseTab.Padding = new System.Windows.Forms.Padding(3);
            this.CourseTab.Size = new System.Drawing.Size(1479, 724);
            this.CourseTab.TabIndex = 0;
            this.CourseTab.Text = "Course";
            this.CourseTab.UseVisualStyleBackColor = true;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(568, 140);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(250, 27);
            this.dateEnd.TabIndex = 19;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(182, 137);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(250, 27);
            this.dateStart.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(462, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(881, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Trainer";
            // 
            // comboTrainer
            // 
            this.comboTrainer.FormattingEnabled = true;
            this.comboTrainer.Location = new System.Drawing.Point(987, 135);
            this.comboTrainer.Name = "comboTrainer";
            this.comboTrainer.Size = new System.Drawing.Size(223, 28);
            this.comboTrainer.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start Time";
            // 
            // comboDayOfWeek
            // 
            this.comboDayOfWeek.FormattingEnabled = true;
            this.comboDayOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday ",
            "Thursday ",
            "Friday ",
            "Saturday",
            "Sunday"});
            this.comboDayOfWeek.Location = new System.Drawing.Point(987, 54);
            this.comboDayOfWeek.Name = "comboDayOfWeek";
            this.comboDayOfWeek.Size = new System.Drawing.Size(223, 28);
            this.comboDayOfWeek.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(568, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 27);
            this.txtName.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(182, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(242, 27);
            this.txtID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(862, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Day of week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(475, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(737, 297);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 27);
            this.txtSearch.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(900, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(705, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(475, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(963, 297);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GridViewCourse
            // 
            this.GridViewCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewCourse.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewCourse.Location = new System.Drawing.Point(3, 346);
            this.GridViewCourse.Name = "GridViewCourse";
            this.GridViewCourse.RowHeadersWidth = 51;
            this.GridViewCourse.RowTemplate.Height = 29;
            this.GridViewCourse.Size = new System.Drawing.Size(1470, 378);
            this.GridViewCourse.TabIndex = 0;
            this.GridViewCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCourse_CellContentClick);
            // 
            // TrainerTab
            // 
            this.TrainerTab.Controls.Add(this.label12);
            this.TrainerTab.Controls.Add(this.txtPhoneTrainer);
            this.TrainerTab.Controls.Add(this.label11);
            this.TrainerTab.Controls.Add(this.checkGenderTrainer);
            this.TrainerTab.Controls.Add(this.txtSearchTrainer);
            this.TrainerTab.Controls.Add(this.btnSearchTrainer);
            this.TrainerTab.Controls.Add(this.GridViewTrainer);
            this.TrainerTab.Controls.Add(this.dateTrainer);
            this.TrainerTab.Controls.Add(this.txtNameTrainer);
            this.TrainerTab.Controls.Add(this.txtIDTrainer);
            this.TrainerTab.Controls.Add(this.label10);
            this.TrainerTab.Controls.Add(this.label9);
            this.TrainerTab.Controls.Add(this.label8);
            this.TrainerTab.Controls.Add(this.label7);
            this.TrainerTab.Controls.Add(this.btnUpdateTrainer);
            this.TrainerTab.Controls.Add(this.btnClearTrainer);
            this.TrainerTab.Controls.Add(this.btnAddTrainer);
            this.TrainerTab.Location = new System.Drawing.Point(4, 29);
            this.TrainerTab.Name = "TrainerTab";
            this.TrainerTab.Padding = new System.Windows.Forms.Padding(3);
            this.TrainerTab.Size = new System.Drawing.Size(1479, 724);
            this.TrainerTab.TabIndex = 1;
            this.TrainerTab.Text = "Trainer";
            this.TrainerTab.UseVisualStyleBackColor = true;
            this.TrainerTab.Click += new System.EventHandler(this.TrainerTab_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(615, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Nhập ID để tìm kiếm..";
            // 
            // txtPhoneTrainer
            // 
            this.txtPhoneTrainer.Location = new System.Drawing.Point(1182, 80);
            this.txtPhoneTrainer.Name = "txtPhoneTrainer";
            this.txtPhoneTrainer.Size = new System.Drawing.Size(184, 27);
            this.txtPhoneTrainer.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1108, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Phone";
            // 
            // checkGenderTrainer
            // 
            this.checkGenderTrainer.AutoSize = true;
            this.checkGenderTrainer.Location = new System.Drawing.Point(646, 86);
            this.checkGenderTrainer.Name = "checkGenderTrainer";
            this.checkGenderTrainer.Size = new System.Drawing.Size(90, 24);
            this.checkGenderTrainer.TabIndex = 14;
            this.checkGenderTrainer.Text = "Female? ";
            this.checkGenderTrainer.UseVisualStyleBackColor = true;
            this.checkGenderTrainer.CheckedChanged += new System.EventHandler(this.checkGenderTrainer_CheckedChanged);
            // 
            // txtSearchTrainer
            // 
            this.txtSearchTrainer.Location = new System.Drawing.Point(775, 308);
            this.txtSearchTrainer.Name = "txtSearchTrainer";
            this.txtSearchTrainer.Size = new System.Drawing.Size(155, 27);
            this.txtSearchTrainer.TabIndex = 13;
            // 
            // btnSearchTrainer
            // 
            this.btnSearchTrainer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchTrainer.Location = new System.Drawing.Point(935, 306);
            this.btnSearchTrainer.Name = "btnSearchTrainer";
            this.btnSearchTrainer.Size = new System.Drawing.Size(94, 29);
            this.btnSearchTrainer.TabIndex = 12;
            this.btnSearchTrainer.Text = "Search";
            this.btnSearchTrainer.UseVisualStyleBackColor = true;
            this.btnSearchTrainer.Click += new System.EventHandler(this.btnSearchTrainer_Click);
            // 
            // GridViewTrainer
            // 
            this.GridViewTrainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewTrainer.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewTrainer.Location = new System.Drawing.Point(-4, 341);
            this.GridViewTrainer.Name = "GridViewTrainer";
            this.GridViewTrainer.RowHeadersWidth = 51;
            this.GridViewTrainer.Size = new System.Drawing.Size(1483, 387);
            this.GridViewTrainer.TabIndex = 11;
            this.GridViewTrainer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewTrainer_CellContentClick);
            // 
            // dateTrainer
            // 
            this.dateTrainer.Location = new System.Drawing.Point(831, 81);
            this.dateTrainer.Name = "dateTrainer";
            this.dateTrainer.Size = new System.Drawing.Size(250, 27);
            this.dateTrainer.TabIndex = 10;
            // 
            // txtNameTrainer
            // 
            this.txtNameTrainer.Location = new System.Drawing.Point(330, 84);
            this.txtNameTrainer.Name = "txtNameTrainer";
            this.txtNameTrainer.Size = new System.Drawing.Size(225, 27);
            this.txtNameTrainer.TabIndex = 8;
            // 
            // txtIDTrainer
            // 
            this.txtIDTrainer.Location = new System.Drawing.Point(63, 84);
            this.txtIDTrainer.Name = "txtIDTrainer";
            this.txtIDTrainer.Size = new System.Drawing.Size(170, 27);
            this.txtIDTrainer.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(775, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(572, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(260, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID";
            // 
            // btnUpdateTrainer
            // 
            this.btnUpdateTrainer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateTrainer.Location = new System.Drawing.Point(935, 188);
            this.btnUpdateTrainer.Name = "btnUpdateTrainer";
            this.btnUpdateTrainer.Size = new System.Drawing.Size(94, 29);
            this.btnUpdateTrainer.TabIndex = 2;
            this.btnUpdateTrainer.Text = "UPDATE";
            this.btnUpdateTrainer.UseVisualStyleBackColor = true;
            this.btnUpdateTrainer.Click += new System.EventHandler(this.btnUpdateTrainer_Click);
            // 
            // btnClearTrainer
            // 
            this.btnClearTrainer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearTrainer.Location = new System.Drawing.Point(693, 188);
            this.btnClearTrainer.Name = "btnClearTrainer";
            this.btnClearTrainer.Size = new System.Drawing.Size(94, 29);
            this.btnClearTrainer.TabIndex = 1;
            this.btnClearTrainer.Text = "CLEAR";
            this.btnClearTrainer.UseVisualStyleBackColor = true;
            this.btnClearTrainer.Click += new System.EventHandler(this.btnClearTrainer_Click);
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTrainer.Location = new System.Drawing.Point(471, 188);
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.Size = new System.Drawing.Size(94, 29);
            this.btnAddTrainer.TabIndex = 0;
            this.btnAddTrainer.Text = "ADD";
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // AccountTab
            // 
            this.AccountTab.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AccountTab.Controls.Add(this.label13);
            this.AccountTab.Controls.Add(this.txtSearchAcc);
            this.AccountTab.Controls.Add(this.btnSearchAcc);
            this.AccountTab.Controls.Add(this.GridViewAccount);
            this.AccountTab.Location = new System.Drawing.Point(4, 29);
            this.AccountTab.Name = "AccountTab";
            this.AccountTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountTab.Size = new System.Drawing.Size(1479, 724);
            this.AccountTab.TabIndex = 2;
            this.AccountTab.Text = "Account";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(478, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nhập ID để tim kiếm";
            // 
            // txtSearchAcc
            // 
            this.txtSearchAcc.Location = new System.Drawing.Point(649, 13);
            this.txtSearchAcc.Name = "txtSearchAcc";
            this.txtSearchAcc.Size = new System.Drawing.Size(202, 27);
            this.txtSearchAcc.TabIndex = 2;
            // 
            // btnSearchAcc
            // 
            this.btnSearchAcc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchAcc.Location = new System.Drawing.Point(867, 11);
            this.btnSearchAcc.Name = "btnSearchAcc";
            this.btnSearchAcc.Size = new System.Drawing.Size(94, 29);
            this.btnSearchAcc.TabIndex = 1;
            this.btnSearchAcc.Text = "Search";
            this.btnSearchAcc.UseVisualStyleBackColor = true;
            this.btnSearchAcc.Click += new System.EventHandler(this.btnSearchAcc_Click);
            // 
            // GridViewAccount
            // 
            this.GridViewAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewAccount.Location = new System.Drawing.Point(3, 49);
            this.GridViewAccount.Name = "GridViewAccount";
            this.GridViewAccount.RowHeadersWidth = 51;
            this.GridViewAccount.RowTemplate.Height = 29;
            this.GridViewAccount.Size = new System.Drawing.Size(1473, 672);
            this.GridViewAccount.TabIndex = 0;
            this.GridViewAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAccount_CellContentClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.CourseTab.ResumeLayout(false);
            this.CourseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCourse)).EndInit();
            this.TrainerTab.ResumeLayout(false);
            this.TrainerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTrainer)).EndInit();
            this.AccountTab.ResumeLayout(false);
            this.AccountTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage TrainerTab;
        private TabPage AccountTab;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker StartPick;
        private TabPage CourseTab;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboDayOfWeek;
        private TextBox txtName;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnAdd;
        private Button btnSearch;
        private DataGridView GridViewCourse;
        private ComboBox comboTrainer;
        private DateTimePicker dateTrainer;
        private TextBox txtNameTrainer;
        private TextBox txtIDTrainer;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnUpdateTrainer;
        private Button btnClearTrainer;
        private Button btnAddTrainer;
        private DataGridView GridViewTrainer;
        private TextBox txtSearchTrainer;
        private Button btnSearchTrainer;
        private TextBox txtPhoneTrainer;
        private Label label11;
        private CheckBox checkGenderTrainer;
        private DataGridView GridViewAccount;
        private Label label12;
        private Label label13;
        private TextBox txtSearchAcc;
        private Button btnSearchAcc;
    }
}