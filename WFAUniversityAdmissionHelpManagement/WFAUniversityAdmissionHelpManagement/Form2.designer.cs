namespace WFAUniversityAdmissionHelpManagement
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.universityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissiondeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutionfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websitelink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUniName = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.dtpAdStart = new System.Windows.Forms.DateTimePicker();
            this.dtpAdEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpExm = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.universityName,
            this.ranking,
            this.location,
            this.admissionStart,
            this.admissiondeadline,
            this.examdate,
            this.tutionfee,
            this.type,
            this.websitelink});
            this.dgvInfo.Location = new System.Drawing.Point(4, 295);
            this.dgvInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(908, 318);
            this.dgvInfo.TabIndex = 0;
            // 
            // universityName
            // 
            this.universityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.universityName.DataPropertyName = "universityName";
            this.universityName.HeaderText = "University Name";
            this.universityName.Name = "universityName";
            this.universityName.ReadOnly = true;
            // 
            // ranking
            // 
            this.ranking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ranking.DataPropertyName = "ranking";
            this.ranking.HeaderText = "Ranking";
            this.ranking.Name = "ranking";
            this.ranking.ReadOnly = true;
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // admissionStart
            // 
            this.admissionStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admissionStart.DataPropertyName = "admissionStart";
            this.admissionStart.HeaderText = "Admission Start";
            this.admissionStart.Name = "admissionStart";
            this.admissionStart.ReadOnly = true;
            // 
            // admissiondeadline
            // 
            this.admissiondeadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admissiondeadline.DataPropertyName = "admissiondeadline";
            this.admissiondeadline.HeaderText = "Admission Deadline";
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
            // 
            // tutionfee
            // 
            this.tutionfee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tutionfee.DataPropertyName = "tutionfee";
            this.tutionfee.HeaderText = "Tution fee";
            this.tutionfee.Name = "tutionfee";
            this.tutionfee.ReadOnly = true;
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
            this.websitelink.HeaderText = "Website Link";
            this.websitelink.Name = "websitelink";
            this.websitelink.ReadOnly = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(764, 251);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(148, 37);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Show";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(764, 207);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "University Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Admission Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Admission end";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Exam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tution fee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Type";
            // 
            // txtUniName
            // 
            this.txtUniName.Location = new System.Drawing.Point(209, 17);
            this.txtUniName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUniName.Name = "txtUniName";
            this.txtUniName.Size = new System.Drawing.Size(132, 22);
            this.txtUniName.TabIndex = 12;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(209, 55);
            this.txtRank.Margin = new System.Windows.Forms.Padding(4);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(132, 22);
            this.txtRank.TabIndex = 13;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(209, 94);
            this.txtLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(132, 22);
            this.txtLoc.TabIndex = 14;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(595, 12);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(132, 22);
            this.txtFee.TabIndex = 18;
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(595, 89);
            this.txtWeb.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(132, 22);
            this.txtWeb.TabIndex = 20;
            // 
            // dtpAdStart
            // 
            this.dtpAdStart.CustomFormat = "yyyy/MM/dd";
            this.dtpAdStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdStart.Location = new System.Drawing.Point(209, 126);
            this.dtpAdStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAdStart.Name = "dtpAdStart";
            this.dtpAdStart.Size = new System.Drawing.Size(251, 22);
            this.dtpAdStart.TabIndex = 21;
            // 
            // dtpAdEnd
            // 
            this.dtpAdEnd.CustomFormat = "yyyy/MM/dd";
            this.dtpAdEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdEnd.Location = new System.Drawing.Point(209, 161);
            this.dtpAdEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAdEnd.Name = "dtpAdEnd";
            this.dtpAdEnd.Size = new System.Drawing.Size(251, 22);
            this.dtpAdEnd.TabIndex = 22;
            // 
            // dtpExm
            // 
            this.dtpExm.CustomFormat = "yyyy/MM/dd";
            this.dtpExm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExm.Location = new System.Drawing.Point(209, 193);
            this.dtpExm.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExm.Name = "dtpExm";
            this.dtpExm.Size = new System.Drawing.Size(251, 22);
            this.dtpExm.TabIndex = 23;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.cmbType.Location = new System.Drawing.Point(595, 44);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 24);
            this.cmbType.TabIndex = 24;
            // 
            // btnAlter
            // 
            this.btnAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.Location = new System.Drawing.Point(764, 170);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(148, 28);
            this.btnAlter.TabIndex = 25;
            this.btnAlter.Text = "Remove";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(229, 256);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(125, 28);
            this.btnFind.TabIndex = 26;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(71, 260);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(132, 22);
            this.txtFind.TabIndex = 27;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(527, 251);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(143, 28);
            this.btnPrev.TabIndex = 28;
            this.btnPrev.Text = "Student Info";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(810, 11);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(91, 45);
            this.btnlogout.TabIndex = 35;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 610);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dtpExm);
            this.Controls.Add(this.dtpAdEnd);
            this.Controls.Add(this.dtpAdStart);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtUniName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgvInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUniName;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.DateTimePicker dtpAdStart;
        private System.Windows.Forms.DateTimePicker dtpAdEnd;
        private System.Windows.Forms.DateTimePicker dtpExm;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiondeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn examdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutionfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn websitelink;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnlogout;
    }
}