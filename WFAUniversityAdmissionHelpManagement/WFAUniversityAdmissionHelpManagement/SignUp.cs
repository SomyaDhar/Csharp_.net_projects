using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAUniversityAdmissionHelpManagement
{
    public partial class SignUp : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public SignUp()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill the mandatory field");
                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password is not matching");
                }
                else
                {
                    this.Sql = @"insert into regiInfo
                       values ('" + this.txtFullName.Text + "','" + this.txtUserName.Text + "','" + this.txtEmail.Text + "','" + this.txtPrevInstitution.Text + "'," + this.txtTotalPoint.Text + ",'" + this.txtPassword.Text + "','" + this.txtConfirmPassword.Text + "');";
                    int num = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (num == 1)
                    {
                        MessageBox.Show("Successfully  Regestered \n Thank you");

                        this.Sql = @"insert into login
                       values ('" + this.txtUserName.Text + "','" + this.txtPassword.Text + "');";
                         num = this.Da.ExecuteUpdateQuery(this.Sql);

                      //   Student1 f2 = new Student1();
                        // f2.Visible = true;
                        // this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(" Registration failed");
                    }
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during storing the data\n\n" + exc.Message);
            }

        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            Login fr = new Login();
            fr.Visible = true;
            this.Visible = false;
        }

    }
}
