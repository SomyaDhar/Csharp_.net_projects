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
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public bool d = false;
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from login;";
                this.Ds = this.Da.ExecuteQuery(sql);

                int count = 0;

                while (count < Ds.Tables[0].Rows.Count)
                {
                    if (this.txtUserName.Text == Ds.Tables[0].Rows[count][0].ToString() && this.txtPassword.Text == Ds.Tables[0].Rows[count][1].ToString())
                    {
                        MessageBox.Show("Login Successfully for " + Ds.Tables[0].Rows[count][0]);
                        this.d = true;
                        if (this.txtUserName.Text.Contains("A"))
                        {
                            Form1 obj = new Form1();
                            obj.Visible = true;
                            this.Visible = false;

                        }
                        else
                        {
                            Student1 f2 = new Student1();
                            f2.Visible = true;
                            this.Visible = false;
                        }
                       
                        break;

                    }

                    count++;
                }
                if (!d)
                {
                    MessageBox.Show("Login Invalid");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("This error has occured during login \n\n" + exc.Message);
            }
       

        }
        

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsignUp_Click(object sender, EventArgs e)
        {
            SignUp f2 = new SignUp();
            f2.Visible = true;
            this.Visible = false;

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
