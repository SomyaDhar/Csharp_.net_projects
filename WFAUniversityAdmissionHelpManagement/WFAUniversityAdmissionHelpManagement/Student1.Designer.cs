namespace WFAUniversityAdmissionHelpManagement
{
    partial class Student1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student1));
            this.universityView1 = new System.Windows.Forms.DataGridView();
            this.universityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissiondeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuitionfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websitelink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.University = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnShow1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSscRoll = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHscRoll = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtSelectedUName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCallcentre = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvprofessors = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProfList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.universityView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofessors)).BeginInit();
            this.SuspendLayout();
            // 
            // universityView1
            // 
            this.universityView1.AllowUserToAddRows = false;
            this.universityView1.AllowUserToDeleteRows = false;
            this.universityView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.universityView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.universityView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.universityView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universityView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.universityName,
            this.ranking,
            this.location,
            this.admissionStart,
            this.admissiondeadline,
            this.examdate,
            this.tuitionfee,
            this.type,
            this.websitelink,
            this.University});
            this.universityView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.universityView1.Location = new System.Drawing.Point(0, 433);
            this.universityView1.Name = "universityView1";
            this.universityView1.ReadOnly = true;
            this.universityView1.RowTemplate.Height = 24;
            this.universityView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.universityView1.Size = new System.Drawing.Size(1183, 301);
            this.universityView1.TabIndex = 0;
            this.toolTip2.SetToolTip(this.universityView1, "Double click for select university");
            this.universityView1.DoubleClick += new System.EventHandler(this.universityView1_DoubleClick);
            // 
            // universityName
            // 
            this.universityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.universityName.DataPropertyName = "universityName";
            this.universityName.HeaderText = "University Name";
            this.universityName.Name = "universityName";
            this.universityName.ReadOnly = true;
            this.universityName.ToolTipText = "University";
            // 
            // ranking
            // 
            this.ranking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ranking.DataPropertyName = "ranking";
            this.ranking.HeaderText = "Ranking";
            this.ranking.Name = "ranking";
            this.ranking.ReadOnly = true;
            this.ranking.ToolTipText = "Ranking";
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.ToolTipText = "Division";
            // 
            // admissionStart
            // 
            this.admissionStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admissionStart.DataPropertyName = "admissionStart";
            this.admissionStart.HeaderText = "Admission Start";
            this.admissionStart.Name = "admissionStart";
            this.admissionStart.ReadOnly = true;
            this.admissionStart.ToolTipText = "Starting Apply ";
            // 
            // admissiondeadline
            // 
            this.admissiondeadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admissiondeadline.DataPropertyName = "admissiondeadline";
            this.admissiondeadline.HeaderText = "Deadline";
            this.admissiondeadline.Name = "admissiondeadline";
            this.admissiondeadline.ReadOnly = true;
            // 
            // examdate
            // 
            this.examdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.examdate.DataPropertyName = "examdate";
            this.examdate.HeaderText = "Exam Date";
            this.examdate.Name = "examdate";
            this.examdate.ReadOnly = true;
            this.examdate.ToolTipText = "Exam Date";
            // 
            // tuitionfee
            // 
            this.tuitionfee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tuitionfee.DataPropertyName = "tuitionfee";
            this.tuitionfee.HeaderText = "Tuition fee";
            this.tuitionfee.Name = "tuitionfee";
            this.tuitionfee.ReadOnly = true;
            this.tuitionfee.ToolTipText = "Tution Fee per credit";
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // websitelink
            // 
            this.websitelink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.websitelink.DataPropertyName = "websitelink";
            this.websitelink.HeaderText = "Website link";
            this.websitelink.Name = "websitelink";
            this.websitelink.ReadOnly = true;
            this.websitelink.ToolTipText = "Offical Website link";
            // 
            // University
            // 
            this.University.DataPropertyName = "University";
            this.University.HeaderText = "University";
            this.University.Name = "University";
            this.University.ReadOnly = true;
            this.University.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search ";
            this.toolTip1.SetToolTip(this.label1, "Please Search By Name");
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(104, 401);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 32);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Tag = "";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtSearch, "Please Search By Name");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(928, 387);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(216, 40);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = " Select";
            this.toolTip2.SetToolTip(this.btnselect, "click for Select University admission process");
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnShow1
            // 
            this.btnShow1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow1.Location = new System.Drawing.Point(706, 387);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(216, 40);
            this.btnShow1.TabIndex = 4;
            this.btnShow1.Text = "Show University List";
            this.toolTip2.SetToolTip(this.btnShow1, "Click here for Show Details of universities");
            this.btnShow1.UseVisualStyleBackColor = false;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Certificate Name";
            // 
            // txtCName
            // 
            this.txtCName.BackColor = System.Drawing.Color.White;
            this.txtCName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(212, 38);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(163, 27);
            this.txtCName.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtCName, "Enter info accordingly as your certificate");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = ">> Registration  for admission help  <<";
            // 
            // txtRegistration
            // 
            this.txtRegistration.BackColor = System.Drawing.Color.White;
            this.txtRegistration.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistration.Location = new System.Drawing.Point(212, 157);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(163, 27);
            this.txtRegistration.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtRegistration, "Enter info accordingly as your certificate");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registration No";
            // 
            // txtSscRoll
            // 
            this.txtSscRoll.BackColor = System.Drawing.Color.White;
            this.txtSscRoll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSscRoll.Location = new System.Drawing.Point(212, 119);
            this.txtSscRoll.Name = "txtSscRoll";
            this.txtSscRoll.Size = new System.Drawing.Size(163, 27);
            this.txtSscRoll.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtSscRoll, "Enter info accordingly as your certificate");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "SSC Roll";
            // 
            // txtHscRoll
            // 
            this.txtHscRoll.BackColor = System.Drawing.Color.White;
            this.txtHscRoll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHscRoll.Location = new System.Drawing.Point(212, 81);
            this.txtHscRoll.Name = "txtHscRoll";
            this.txtHscRoll.Size = new System.Drawing.Size(163, 27);
            this.txtHscRoll.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtHscRoll, "Enter info accordingly as your certificate");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "HSC Roll";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.White;
            this.txtMobile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(215, 272);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(163, 27);
            this.txtMobile.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtMobile, "Enter your mobile number");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mobile Number";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(212, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 27);
            this.txtEmail.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtEmail, "Enter your vaild email");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DodgerBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "BBA",
            "English",
            "Law"});
            this.cmbSubject.Location = new System.Drawing.Point(672, 161);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(183, 27);
            this.cmbSubject.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cmbSubject, "Select your Subject but make sure that this university have this subject form web" +
        "site link");
            // 
            // txtSelectedUName
            // 
            this.txtSelectedUName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedUName.Location = new System.Drawing.Point(672, 87);
            this.txtSelectedUName.Multiline = true;
            this.txtSelectedUName.Name = "txtSelectedUName";
            this.txtSelectedUName.ReadOnly = true;
            this.txtSelectedUName.Size = new System.Drawing.Size(206, 42);
            this.txtSelectedUName.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtSelectedUName, "please Select University from Display");
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(264, 323);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(233, 57);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "Apply";
            this.toolTip2.SetToolTip(this.btnApply, "Before click  give all information   then     Click for process your best admissi" +
        "on");
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(541, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Semester";
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.cmbSemester.Location = new System.Drawing.Point(672, 208);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(186, 27);
            this.cmbSemester.TabIndex = 23;
            this.toolTip1.SetToolTip(this.cmbSemester, "Select upcoming semester for admission");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(552, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Program";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(407, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "Selected University";
            this.toolTip2.SetToolTip(this.label11, "please Select University from Display");
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.White;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(212, 196);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(163, 27);
            this.cmbGender.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DodgerBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(87, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 30);
            this.label12.TabIndex = 27;
            this.label12.Text = "Gender";
            // 
            // btnCallcentre
            // 
            this.btnCallcentre.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCallcentre.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallcentre.Location = new System.Drawing.Point(939, 292);
            this.btnCallcentre.Name = "btnCallcentre";
            this.btnCallcentre.Size = new System.Drawing.Size(205, 75);
            this.btnCallcentre.TabIndex = 28;
            this.btnCallcentre.Text = "Call Centre";
            this.toolTip1.SetToolTip(this.btnCallcentre, "If you need any help for admission please call ");
            this.btnCallcentre.UseVisualStyleBackColor = false;
            this.btnCallcentre.Click += new System.EventHandler(this.btnCallcentre_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toolTip1.IsBalloon = true;
            // 
            // dgvprofessors
            // 
            this.dgvprofessors.AllowUserToAddRows = false;
            this.dgvprofessors.AllowUserToDeleteRows = false;
            this.dgvprofessors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvprofessors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvprofessors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvprofessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprofessors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvprofessors.Location = new System.Drawing.Point(0, 436);
            this.dgvprofessors.Name = "dgvprofessors";
            this.dgvprofessors.ReadOnly = true;
            this.dgvprofessors.RowTemplate.Height = 24;
            this.dgvprofessors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprofessors.Size = new System.Drawing.Size(1183, 298);
            this.dgvprofessors.TabIndex = 30;
            this.toolTip2.SetToolTip(this.dgvprofessors, "Double click for select university");
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Professors Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Professors Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Professors Name";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "University";
            this.dataGridViewTextBoxColumn1.HeaderText = "University";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "University";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.ToolTipText = "Email";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.ToolTipText = "Phone Number";
            // 
            // btnProfList
            // 
            this.btnProfList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProfList.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfList.Location = new System.Drawing.Point(952, 208);
            this.btnProfList.Name = "btnProfList";
            this.btnProfList.Size = new System.Drawing.Size(192, 71);
            this.btnProfList.TabIndex = 29;
            this.btnProfList.Text = "Show Professor List ";
            this.btnProfList.UseVisualStyleBackColor = false;
            this.btnProfList.Click += new System.EventHandler(this.btnProfList_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(519, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 57);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Student1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WFAUniversityAdmissionHelpManagement.Properties.Resources.PE9T2Y;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1183, 734);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvprofessors);
            this.Controls.Add(this.btnProfList);
            this.Controls.Add(this.btnCallcentre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtSelectedUName);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHscRoll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSscRoll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShow1);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.universityView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Student1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Admission Help Centre";
            ((System.ComponentModel.ISupportInitialize)(this.universityView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofessors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView universityView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSscRoll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHscRoll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtSelectedUName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCallcentre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnProfList;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiondeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn examdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuitionfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn websitelink;
        private System.Windows.Forms.DataGridViewTextBoxColumn University;
        private System.Windows.Forms.DataGridView dgvprofessors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnClear;
    }
}

