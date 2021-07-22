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
    public partial class Student1 : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private byte count;
        public Student1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.dgvprofessors.Visible = false;

             this.PopulateGridView();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {

            this.txtSelectedUName.Text = this.universityView1.CurrentRow.Cells["universityName"].Value.ToString();
            //string sql = "select * from Student";
            //this.Ds = this.Da.ExecuteQuery(sql);
            //this.universityView1.DataSource = this.Ds.Tables[0];

        }
        private void PopulateGridView(string sql = "select * from AdmissionInfo;")
        {
            try
            {

                this.Ds = this.Da.ExecuteQuery(sql);


                if (count == 2)
                {
                    this.dgvprofessors.AutoGenerateColumns = false;
                    this.dgvprofessors.DataSource = this.Ds.Tables[0];
                    count = 0;
                }
                else
                {
                    this.universityView1.AutoGenerateColumns = false;
                    this.universityView1.DataSource = this.Ds.Tables[0];
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("This error has occured during data input or output \n\n" + exc.Message);
            }

            
        
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            try
            {



                // string sql = "select * from AdmissionInfo;";
                this.dgvprofessors.Visible = false;
                this.universityView1.Visible = true;
                this.btnselect.Visible = true;
                this.txtSearch.Visible = true;


                this.count = 0;
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("This error has occured during data showing \n\n" + exc.Message);
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from AdmissionInfo where universityName like '%" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            try
            {


                 this.Sql = @"insert into RegistrationInfo
                       values ('" + this.txtCName.Text + "','" + this.txtHscRoll.Text + "','" + this.txtSscRoll.Text + "','" + this.txtRegistration.Text + "','" + this.cmbGender.Text + "','" + this.txtEmail.Text + "','" + this.txtMobile.Text + "','" + this.txtSelectedUName.Text + "','" + this.cmbSubject.Text + "','" + this.cmbSemester.Text + "');";
                 int num = this.Da.ExecuteUpdateQuery(this.Sql);
                if (num == 1)
                {
                    MessageBox.Show("Successfully  Regestered \n Thank you");
                }
                else
                {
                    MessageBox.Show(" Registration failed");
                 }
                    this.PopulateGridView();
             }
               catch (Exception exc)
                {
                     MessageBox.Show("An error has occured during storing the data\n\n" + exc.Message);
                }
          }


        private void universityView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtSelectedUName.Text = this.universityView1.CurrentRow.Cells["universityName"].Value.ToString();
        }

        private void btnCallcentre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" To Call in our call centre \n please dial any of  this number : \n Number 1 : 01776152731 \n Number 2 : 01914818279 \n You can also call via imo or whastsapp    \n Please noted your call may be recorded ");

        }

        private void btnProfList_Click(object sender, EventArgs e)
        {
            this.count = 2;
            string sql = "select * from dbProfessors;";
            this.universityView1.Visible = false;
            this.btnselect.Visible = false;
            this.txtSearch.Visible = false;
            this.dgvprofessors.Visible = true;
  

            this.PopulateGridView(sql);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSelectedUName.Clear();

            this.cmbSubject.SelectedIndex = -1;
           // this.cmbSubject.SelectedItem = null;
            this.cmbSemester.SelectedItem = null;
            this.cmbGender.SelectedIndex = -1; ;
         
            this.txtCName.Clear();
            this.txtHscRoll.Clear();
            this.txtSscRoll.Clear();
            this.txtRegistration.Clear();        
            this.txtEmail.Clear();
            this.txtMobile.Clear();
            this.txtSearch.Clear();
          

        }

        
    }
}
