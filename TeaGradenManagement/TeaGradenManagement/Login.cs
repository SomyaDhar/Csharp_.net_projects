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
                string sql = "select * from Glogin;";
                this.Ds = this.Da.ExecuteQuery(sql);

                int count = 0;

                while (count < Ds.Tables[0].Rows.Count)
                {
                    if (this.txtUserNam.Text == Ds.Tables[0].Rows[count][0].ToString() && this.txtPassword.Text == Ds.Tables[0].Rows[count][1].ToString())
                    {
                        MessageBox.Show("Login Successfully for " + Ds.Tables[0].Rows[count][0]);
                        this.d = true;

                        if (this.txtUserNam.Text.Contains("m"))
                        {
                            GardenManagement f2 = new GardenManagement();
                            f2.Visible = true;
                            this.Visible = false;

                        }
                        else
                        {
                            Product f8 = new Product();
                            f8.Visible = true;
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
