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
    public partial class GardenManagement : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
       // private byte count;
        private string id;
        public GardenManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoGenerateId();
        }
        
        private void PopulateGridView(string sql = "select * from ClarkInfo;")
        {
            try
            {

                this.Ds = this.Da.ExecuteQuery(sql);

                this.dgvDetails.AutoGenerateColumns = false;
                this.dgvDetails.DataSource = this.Ds.Tables[0];
               
                  
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("This error has occured during data input or output \n\n" + exc.Message);
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from ClarkInfo where ClarkName like '%" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.Visible = true;
            this.Visible = false;
        }

        private void GardenManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.id = this.dgvDetails.CurrentRow.Cells["username"].Value.ToString();
                string uname = this.dgvDetails.CurrentRow.Cells["ClarkName"].Value.ToString();
                this.Sql = @"delete from ClarkInfo
                       where username='" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    this.Sql = @"delete from Glogin
                       where username='" + id + "';";

                    MessageBox.Show(uname + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Data deletion failed");
                }

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("This error has occured during Delete n\n" + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtName.Text == "" || txtPhoneN.Text == "" || txtpassword.Text == "" || txtAddress.Text == "" || txtsalary.Text == "" || txtHour.Text == "")
                {
                    MessageBox.Show("Please fill the correctly ");
                }
                else if (txtemail.Text.Contains("@") == false || txtemail.Text.Contains(".com") == false)
                {
                    MessageBox.Show("Give email correctlly");
                }

                else
                {

                    this.Sql = @"insert into ClarkInfo
                       values ('" + this.txtId.Text + "','" + this.txtpassword.Text + "','" + this.txtName.Text + "','" + this.cmbPosition.Text + "','" + this.txtAddress.Text + "','" + this.txtPhoneN.Text + "','" + this.txtemail.Text + "', '" + this.txtHour.Text + "'," + this.txtsalary.Text + ",'" + this.dtpJoin.Text + "','" + this.txtComment.Text + "');";

                    int num = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (num == 1)
                    {
                        this.Sql = @"insert into login
                       values ('" + this.txtId.Text + "','" + this.txtpassword.Text + "');";
                        num = this.Da.ExecuteUpdateQuery(this.Sql);

                        MessageBox.Show("Successfully  Regestered \n Thank you");
                        this.AutoGenerateId();

                    }
                    else
                    {
                        MessageBox.Show(" Registration failed");
                    }
                }
                

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during storing the data\n\n" + exc.Message);
            }

        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            try
            {
                this.id = this.dgvDetails.CurrentRow.Cells["username"].Value.ToString();
                this.Sql = @" update ClarkInfo set Comments='" + this.txtComment.Text + "' where username='" + id + "';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    this.PopulateGridView();
                    MessageBox.Show("Comments updated");
                }
                else
                {
                    MessageBox.Show("Comments update failed");
                }
               

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during commenting \n\n" + exc.Message);
            }
        }

        private void dgvDetails_DoubleClick(object sender, EventArgs e)
        {
            this.txtComment.Text = this.dgvDetails.CurrentRow.Cells["Comments"].Value.ToString();
            this.id = this.dgvDetails.CurrentRow.Cells["username"].Value.ToString();
        }
        public void AutoGenerateId()
        {
            this.Sql = "select * from Glogin order by UserID ;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[1]["UserID"].ToString();
            string[] str = id.Split('-');
            int number = Convert.ToInt32(str[1]);

            string newId = "c" + "-" + (++number).ToString();
            this.txtId.Text = newId;
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product f9 = new Product();
            f9.Visible = true;
            this.Visible = false;
        }

      //  private void button1_Click(object sender, EventArgs e)
        //{

        //}
         

       
    }
}
