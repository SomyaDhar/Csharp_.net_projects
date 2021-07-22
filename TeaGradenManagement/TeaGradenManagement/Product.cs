using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaGradenManagement
{
    public partial class Product : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public int value;
        public int price1=0;
        public int total;
        public int value1;



        public Product()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView1();
        }

       

        private void PopulateGridView1(string sql = "select * from Product;")
        {
            try
            {

                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvDetails1.AutoGenerateColumns = false;
                this.dgvDetails1.DataSource = this.Ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("This error has occured during populate data input or output \n\n" + exc.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtPName.Text == "" || txtPrice.Text == "" || txtType.Text == "" )
                {
                    MessageBox.Show("Please fill the correctly ");
                }
               

                else
                {

                    this.Sql =@"insert into Product
                       values('" + this.txtPName.Text + "'," + this.txtPrice.Text + "," + this.txtQuantity.Text + ",'" + this.txtType.Text + "');";

                    int num = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (num == 1)
                    {                      

                        MessageBox.Show("Successfully ADDED \n Thank you");
                    }
                    else
                    {
                        MessageBox.Show(" add failed");
                    }
                }
                 this.PopulateGridView1();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during storing the ADD data\n\n" + exc.Message);
            }

        }

        private void dgvDetails1_DoubleClick(object sender, EventArgs e)
        {

            this.txtPName.Text = this.dgvDetails1.CurrentRow.Cells["ProductName"].Value.ToString();
            this.txtPrice.Text = this.dgvDetails1.CurrentRow.Cells["Price"].Value.ToString();
            this.txtType.Text = this.dgvDetails1.CurrentRow.Cells["TeaType"].Value.ToString();
        }



        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            this.value = Convert.ToInt32(this.txtQuantity.Text);
            this.price1 = Convert.ToInt32(this.dgvDetails1.CurrentRow.Cells["Price"].Value.ToString());
            this.total = value * price1;
           // this.textBox5 = this.total.ToString();
            this.textBox5.Text = this.total.ToString();





        }


        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {

                string sql1 = "select * from Balance;";
                DataTable dt = this.Da.ExecuteQueryTable(sql1);
                string id = dt.Rows[0][0].ToString();
                // this.textBox4.Text = id;
                this.value1 = Convert.ToInt32(id);

                this.value1 = value1 + total;

                string id1 = value1.ToString();
                this.textBox4.Text = id1;

                this.Sql = @"insert into Balance
                         values ('" + this.textBox4.Text + "');";

                int num = this.Da.ExecuteUpdateQuery(this.Sql);
                if (num == 1)
                {

                    MessageBox.Show("Successfully sell \n Thank you");
                }
                else
                {
                    MessageBox.Show(" sell failed");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error \n\n" + exc.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from Balance;";
            DataTable dt = this.Da.ExecuteQueryTable(sql1);
            string id = dt.Rows[0][0].ToString();
            this.textBox4.Text = id;

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtPName.Clear();
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
            this.txtType.Clear();
            this.textBox5.Clear();
        }

    }
}
