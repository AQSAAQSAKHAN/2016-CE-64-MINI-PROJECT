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
    public partial class Project_Management : Form
    {
        string conString = "Data Source = LAPTOP-E7MPN3U3; Initial Catalog = ProjectA; Integrated Security = True";
        string function;
        public Project_Management()
        {
            InitializeComponent();
            Display();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            fyp f = new fyp();
            this.Hide();
            f.Show();
        }

        private void Project_Management_Load(object sender, EventArgs e)
        {
           
        }
        private void Insert()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = String.Format("INSERT INTO Project(Description ,Title)VALUES('" + description.Text + "', '" + title.Text + "')");
                string query1 = String.Format("INSERT INTO ProjectAdvisor()");
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                Display();
                MessageBox.Show("Data Entered");

                con.Close();
            }
        }
        private void Display()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                dataGridView1.AllowUserToAddRows = false;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter("SELECT * FROM Project", con);
                DataTable dataTable = new DataTable();
                sdr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                // dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                con.Open();

                string description = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


                string query = "SELECT Id FROM Project WHERE Description = '" + description + "'";
                SqlCommand com = new SqlCommand(query, con);
                int Id = (Int32)com.ExecuteScalar();
                com.CommandText = "DELETE FROM Project WHERE Id = '" + Id + "'";
                com.ExecuteNonQuery();

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Data Deleted Sussecfully!");
                con.Close();

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();


                string query = "SELECT Id FROM Project WHERE Title = '" + title.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int id = (Int32)cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE Project SET Description = '" + description.Text + "' WHERE Id = '" + id + "'";
                cmd.ExecuteNonQuery();


                MessageBox.Show("Data Updated successfully!");
                con.Close();
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (function == "update")
            {
                Update();
                Display();
            }
            else
            {
                Insert();
            }
            function = "add";
        }

        private void APA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assign_Project ap = new Assign_Project();
            this.Hide();
            ap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                

                string Pid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string Gid = "SELECT Id FROM Project WHERE Id = '" + Pid + "'";
                SqlCommand cmd1 = new SqlCommand(Gid, con);
                int p_id = (Int32)cmd1.ExecuteScalar();
                string addStudent = "SELECT Id FROM [Group]";
                SqlCommand cmd = new SqlCommand(addStudent, con);
                int Getid = (Int32)cmd.ExecuteScalar();
                string qury = string.Format("INSERT INTO GroupProject(ProjectId,GroupId , AssignmentDate)VALUES('" + p_id + "', '" + Getid + "', '" + DateTime.Now + "')");
                SqlCommand sqlCommand = new SqlCommand(qury, con);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Project Assigned");
                con.Close();
            }
        }
        private void Display2()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                dataGridView1.AllowUserToAddRows = false;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter("SELECT * FROM GroupProject", con);
                DataTable dataTable = new DataTable();
                sdr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }

        private void APA_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display2();
        }
    }
}
