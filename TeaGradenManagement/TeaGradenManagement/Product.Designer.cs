namespace TeaGradenManagement
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.dgvDetails1 = new System.Windows.Forms.DataGridView();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetails1
            // 
            this.dgvDetails1.AllowUserToAddRows = false;
            this.dgvDetails1.AllowUserToDeleteRows = false;
            this.dgvDetails1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Price,
            this.Quantity,
            this.TeaType});
            this.dgvDetails1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetails1.Location = new System.Drawing.Point(0, 422);
            this.dgvDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetails1.Name = "dgvDetails1";
            this.dgvDetails1.ReadOnly = true;
            this.dgvDetails1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails1.Size = new System.Drawing.Size(1012, 293);
            this.dgvDetails1.TabIndex = 36;
            this.dgvDetails1.DoubleClick += new System.EventHandler(this.dgvDetails1_DoubleClick);
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(160, 32);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(193, 22);
            this.txtPName.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Product Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(160, 84);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(193, 22);
            this.txtPrice.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Price (Kg)";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(160, 148);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(193, 22);
            this.txtQuantity.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Quantity";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(160, 206);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(193, 22);
            this.txtType.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tea Type";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(603, 34);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 22);
            this.textBox4.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Balance";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 257);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(193, 22);
            this.textBox5.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "Total price";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(465, 306);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(164, 47);
            this.btnSell.TabIndex = 77;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(297, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 47);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Product Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price (KG)";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.ToolTipText = "Price (KG)";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TeaType
            // 
            this.TeaType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeaType.DataPropertyName = "TeaType";
            this.TeaType.HeaderText = "Tea Type";
            this.TeaType.Name = "TeaType";
            this.TeaType.ReadOnly = true;
            // 
            // btnCalcu
            // 
            this.btnCalcu.Location = new System.Drawing.Point(97, 306);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(159, 47);
            this.btnCalcu.TabIndex = 79;
            this.btnCalcu.Text = "Calculate";
            this.btnCalcu.UseVisualStyleBackColor = true;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 38);
            this.button1.TabIndex = 80;
            this.button1.Text = "total balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(853, 7);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(159, 45);
            this.btnlogout.TabIndex = 81;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(691, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 52);
            this.button2.TabIndex = 82;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 715);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Product";
            this.Text = "Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Product_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails1;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaType;
        private System.Windows.Forms.Button btnCalcu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button2;
    }
}