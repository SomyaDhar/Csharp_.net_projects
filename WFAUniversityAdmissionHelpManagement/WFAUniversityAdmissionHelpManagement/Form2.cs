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
    public partial class Form2 : Form
    {
        private Form1 Frm1 { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql2 { get; set; }
        public Form2()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql2 = "select * from AdmissionInfo;";
            this.PopulateGridView2(sql2);
        }
        public Form2(Form1 frm1):this()
        {
            this.Frm1 = frm1;
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView2();
        }
        private void PopulateGridView2(string sql2 = "select * from AdmissionInfo;")
        {
            this.Ds = this.Da.ExecuteQuery(sql2);
            this.dgvInfo.AutoGenerateColumns = false;
            this.dgvInfo.DataSource = this.Ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Sql2 = "select * from AdmissionInfo where universityName = '" + this.txtUniName.Text + "'";
            this.Ds = this.Da.ExecuteQuery(this.Sql2);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                this.Sql2 = @" update AdmissionInfo
                              set ranking=" + this.txtRank.Text + @",
                              location='" + this.txtLoc.Text + @"',
                              admissionStart= '" + this.dtpAdStart.Text + @"',
                              admissiondeadline='" + this.dtpAdEnd.Text + @"',
                              examdate='" + this.dtpExm.Text + @"',
                              tutionfee=" + this.txtFee.Text + @",
                              type='"+this.cmbType.Text+ @"',
                              websitelink='"+this.txtWeb.Text+@"'
                              where universityName='" + this.txtUniName.Text + @"';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql2);
                if (count == 1)
                {
                    MessageBox.Show("Data updated");
                }
                else
                {
                    MessageBox.Show("Data update failed");
                }
            }
            else
            {
                this.Sql2 = @"insert into AdmissionInfo
                       values ('" + this.txtUniName.Text + "'," + this.txtRank.Text + ",'" + this.txtLoc.Text + "','" + this.dtpAdStart.Text + "','" + this.dtpAdEnd.Text + "','"+this.dtpExm.Text+"'," + this.txtFee.Text + ",'" + this.cmbType.Text + "','"+this.txtWeb.Text+"');";
                int count = this.Da.ExecuteUpdateQuery(this.Sql2);
                if (count == 1)
                {
                    MessageBox.Show("Successfully Inserted");
                    //this.AutoGenerateId();
                }
                else
                {
                    MessageBox.Show("Insertion failed");
                }
            }
            this.PopulateGridView2();
            this.ClearAll2();
        }
        private void btnAlter_Click(object sender, EventArgs e)
        {
            string uniName = this.dgvInfo.CurrentRow.Cells["universityName"].Value.ToString();
            this.Sql2 = @"delete from AdmissionInfo where universityName='"+uniName+"'";
            int count = this.Da.ExecuteUpdateQuery(this.Sql2);
            if (count == 1)
            {
                MessageBox.Show(uniName + " has been deleted");
            }
            else
            {
                MessageBox.Show("Data deletion failed");
            }

            this.PopulateGridView2();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            this.Sql2 = "select * from AdmissionInfo where universityName like '" + this.txtFind.Text + "%';";
            this.PopulateGridView2(this.Sql2);
        }
        private void ClearAll2()
        {
            this.txtUniName.Clear();
            this.txtRank.Clear();
            this.txtLoc.Clear();
            this.dtpAdStart.Text="";
            this.dtpAdEnd.Text="";
            this.dtpExm.Text="";
            this.txtFee.Clear();
            this.cmbType.SelectedIndex=-1;
            this.txtWeb.Clear();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 s = new Form1();
            s.AutoGenerateId();
            s.Visible = true;
     


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

            Login fr = new Login();
            fr.Visible = true;
            this.Visible = false;
        }

       

       
       
    }
}
