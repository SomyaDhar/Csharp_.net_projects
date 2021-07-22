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
    public partial class Form1 : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from Student;";
            this.PopulateGridView(sql);
            this.AutoGenerateId();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql="select * from Student;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.DataSource = this.Ds.Tables[0];
        }
        
       
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string Sql = "select * from Student where UserName='"+this.txtSearch.Text+"';";
            this.PopulateGridView(this.Sql);

        }

        private void txtLetterSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Student where Name like '" + this.txtLetterSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Student where id = '" + this.txtId.Text + "'";
            this.Ds = this.Da.ExecuteQuery(this.Sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                this.Sql = @" update Student
                              set Name='" + this.txtName.Text + @"',
                              UserName='" + this.txtUName.Text + @"',
                              Point=" + this.txtGPoint.Text + @",
                              PreviousInstitution='" + this.txtPInst.Text + @"',
                              email='" + this.txtEmail.Text + @"',
                              password='" + this.txtPass.Text + @"'
                              where id='" + this.txtId.Text + @"';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
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
                this.Sql = @"insert into Student
                       values ('" + this.txtName.Text + "','" + this.txtUName.Text + "'," + this.txtGPoint.Text + ",'" + this.txtPInst.Text + "','" + this.txtEmail.Text + "','" + this.txtPass.Text + "','" + this.txtId.Text + "');";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Successfully Inserted");
                    this.AutoGenerateId();
                }
                else
                {
                    MessageBox.Show("Insertion failed");
                }
            }
            this.PopulateGridView();
            this.ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvDetails.CurrentRow.Cells["id"].Value.ToString();
            string uname = this.dgvDetails.CurrentRow.Cells["UserName"].Value.ToString();
            this.Sql = @"delete from Student
                       where id='" + id + "';";
            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show(uname + " has been deleted");
            }
            else
            {
                MessageBox.Show("Data deletion failed");
            }

            this.PopulateGridView();

        }
        private void ClearAll()
        {
            //this.txtId.ReadOnly = true;
            this.txtName.Clear();
            this.txtUName.Clear();
            this.txtGPoint.Clear();
            this.txtPInst.Clear();
            this.txtEmail.Clear();
            this.txtPass.Clear();
            this.txtId.Clear();
           
            
        }
       
        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = this.dgvDetails.CurrentRow.Cells["id"].Value.ToString();
            //this.txtName.Text = this.dgvDetails.CurrentRow.Cells["Name"].Value.ToString();
            this.txtUName.Text = this.dgvDetails.CurrentRow.Cells["UserName"].Value.ToString();
            this.txtGPoint.Text = this.dgvDetails.CurrentRow.Cells["Point"].Value.ToString();
            this.txtEmail.Text = this.dgvDetails.CurrentRow.Cells["email"].Value.ToString();
            this.txtPass.Text = this.dgvDetails.CurrentRow.Cells["password"].Value.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
            this.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
         Application.Exit();
        }
        public void AutoGenerateId()
        {
            this.Sql = "select * from Student order by id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[1]["id"].ToString();
            string[] str = id.Split('-');
            int number = Convert.ToInt32(str[1]);

            string newId = "s" + "-" + (++number).ToString();
            this.txtId.Text = newId;
            //string[] str1 = id.Split('s');
            //int val = Convert.ToInt32(str[1]);
            //string modId = newId + "s" + (++val).ToString("d2");
            //this.txtId.Text = modId;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

            Login fr = new Login();
            fr.Visible = true;
            this.Visible = false;
        }
       
    }
}
