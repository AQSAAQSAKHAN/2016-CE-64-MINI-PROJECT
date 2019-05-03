using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Assign_Advisor : Form
    {
        string conString = "Data Source = LAPTOP-E7MPN3U3; Initial Catalog = ProjectA; Integrated Security = True";
        public Assign_Advisor()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string advisor = "SELECT Id FROM LookUp WHERE Value = '" + comboBox3.Text + "' AND CATEGORY = 'ADVISOR_ROLE'";
                    SqlCommand cmn = new SqlCommand(advisor, con);
                    int advisor_role = (Int32)cmn.ExecuteScalar();


                    string email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    string Gid = "SELECT Id FROM Advisor WHERE Email = '" + email + "'";
                    SqlCommand cmd1 = new SqlCommand(Gid, con);
                    int p_id = (Int32)cmd1.ExecuteScalar();
                    string assignProject = "SELECT Id FROM [Project]";
                    SqlCommand cmd = new SqlCommand(assignProject, con);
                    int Getid = (Int32)cmd.ExecuteScalar();
                    string qury = string.Format("INSERT INTO ProjectAdvisor(AdvisorId,ProjectId , AdvisorRole , AssignmentDate)VALUES('" + p_id + "', '" + Getid + "','" + advisor_role + "', '" + DateTime.Now + "')");
                    SqlCommand sqlCommand = new SqlCommand(qury, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Advisor Assigned");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        
        }
        

        private void Assign_Advisor_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                dataGridView1.AllowUserToAddRows = false;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter("SELECT FirstName,LastName, Salary, Designation,Email,Contact,Gender , DateOfBirth FROM Person JOIN Advisor ON Person.Id = Advisor.Id", con);
                DataTable dataTable = new DataTable();
                sdr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }
        private void Display2()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                dataGridView1.AllowUserToAddRows = false;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter("SELECT * FROM ProjectAdvisor", con);
                DataTable dataTable = new DataTable();
                sdr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display2();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Advisor_Management am = new Advisor_Management();
            this.Hide();
            am.Show();
        }
    }
}
