namespace TeaGradenManagement
{
    partial class GardenManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GardenManagement));
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClarkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.dtpJoin = new System.Windows.Forms.DateTimePicker();
            this.btnProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(899, 1);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(159, 45);
            this.btnlogout.TabIndex = 57;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(879, 420);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 28);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(0, 420);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.btnSearch, "Please search by Name");
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(452, 423);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(152, 28);
            this.btnShow.TabIndex = 36;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.ClarkName,
            this.Position,
            this.Address,
            this.PhoneNumber,
            this.Email,
            this.WorkingTime,
            this.Salary,
            this.JoinDate,
            this.Comments});
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetails.Location = new System.Drawing.Point(0, 456);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1070, 293);
            this.dgvDetails.TabIndex = 35;
            this.dgvDetails.DoubleClick += new System.EventHandler(this.dgvDetails_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(110, 420);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 32);
            this.txtSearch.TabIndex = 58;
            this.txtSearch.Tag = "";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtSearch, "Please search by Name");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "ID";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.ToolTipText = "This is id ";
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // ClarkName
            // 
            this.ClarkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClarkName.DataPropertyName = "ClarkName";
            this.ClarkName.HeaderText = "Name";
            this.ClarkName.Name = "ClarkName";
            this.ClarkName.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.ToolTipText = "Position";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.ToolTipText = "Address";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // WorkingTime
            // 
            this.WorkingTime.DataPropertyName = "WorkingTime";
            this.WorkingTime.HeaderText = "Working Time";
            this.WorkingTime.Name = "WorkingTime";
            this.WorkingTime.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // JoinDate
            // 
            this.JoinDate.DataPropertyName = "JoinDate";
            this.JoinDate.HeaderText = "Join Date";
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(146, 16);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(193, 22);
            this.txtId.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Clark ID";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(146, 61);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '#';
            this.txtpassword.Size = new System.Drawing.Size(193, 22);
            this.txtpassword.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Clark Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Position";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(146, 194);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 22);
            this.txtAddress.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Address";
            // 
            // txtPhoneN
            // 
            this.txtPhoneN.Location = new System.Drawing.Point(146, 238);
            this.txtPhoneN.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneN.Name = "txtPhoneN";
            this.txtPhoneN.Size = new System.Drawing.Size(193, 22);
            this.txtPhoneN.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Phone  Number";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(147, 284);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(193, 22);
            this.txtemail.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Email";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(147, 329);
            this.txtHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(193, 22);
            this.txtHour.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "Working Hour";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(488, 24);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(193, 22);
            this.txtsalary.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(387, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(373, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 77;
            this.label10.Text = "Join Date";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(865, 239);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(193, 49);
            this.txtComment.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(759, 249);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 79;
            this.label11.Text = "Comment";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(433, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 63);
            this.btnAdd.TabIndex = 81;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(865, 295);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(193, 39);
            this.btnComment.TabIndex = 82;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Clerk",
            "Asssitant clerk ",
            "Assisnent manager"});
            this.cmbPosition.Location = new System.Drawing.Point(146, 146);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(194, 27);
            this.cmbPosition.TabIndex = 83;
            this.toolTip1.SetToolTip(this.cmbPosition, "Select your Subject but make sure that this university have this subject form web" +
        "site link");
            // 
            // dtpJoin
            // 
            this.dtpJoin.CustomFormat = "yyyy/MM/dd";
            this.dtpJoin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoin.Location = new System.Drawing.Point(488, 73);
            this.dtpJoin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(193, 22);
            this.dtpJoin.TabIndex = 84;
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(865, 143);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(177, 30);
            this.btnProduct.TabIndex = 85;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(433, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 86;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GardenManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.dtpJoin);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GardenManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GardenManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GardenManagement_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClarkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.DateTimePicker dtpJoin;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button button1;
    }
}