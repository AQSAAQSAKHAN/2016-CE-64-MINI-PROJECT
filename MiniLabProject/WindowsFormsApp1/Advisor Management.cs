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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Advisor_Management : Form
    {
        string conString = "Data Source = LAPTOP-E7MPN3U3; Initial Catalog = ProjectA; Integrated Security = True";
        string function;
        public Advisor_Management()
        {
            InitializeComponent();
            Display();

        }
        private void Display()
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
        private void Update()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();


                string query = "SELECT Id FROM Advisor WHERE Salary = '" + salary.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int id = (Int32)cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE Advisor SET Salary = '" + salary.Text + "' WHERE Id = '" + id + "'";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Person SET FirstName = '" + firstName.Text + "', LastName = '" + lastName.Text + "' ,Email = ' " + email_Id.Text + "', Contact = '" + contact_no.Text + "', DateOfBirth = '" + dateTimePicker1.Value + "', Gender = '" + comboBox1.Text + "' WHERE Id = '" + id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated successfully!");
                con.Close();
            }
        }

        private void Advisor_Management_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            fyp f2 = new fyp();
            this.Hide();
            f2.Show();
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
        private void Insert()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string designation = "SELECT Id FROM LookUp WHERE Value = '" + comboBox2.Text + "' AND Category = 'DESIGNATION' ";
                    SqlCommand comnd = new SqlCommand(designation, con);
                    int des = (Int32)comnd.ExecuteScalar();

                    string gender = "SELECT Id FROM Lookup WHERE Value = '" + comboBox1.Text + "' AND Category = 'GENDER'";
                    SqlCommand cmd = new SqlCommand(gender, con);
                    int gender1 = (Int32)cmd.ExecuteScalar();
                    cmd.CommandText = String.Format("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender)VALUES('" + firstName.Text + "', '" + lastName.Text + "', '" + contact_no.Text + "', '" + email_Id.Text + "', '" + dateTimePicker1.Value + "' , '" + gender1 + "')");
                    cmd.ExecuteNonQuery();


                    //SDA.SelectCommand.ExecuteNonQuery();

                    string query = String.Format("SELECT Id FROM Person WHERE Email = '" + email_Id.Text + "'");
                    SqlCommand command = new SqlCommand(query, con);
                    int Id = (Int32)command.ExecuteScalar();


                    //command.CommandText = String.Format("SELECT Id FROM Person WHERE Email = '" + email_Id + "'");
                    //int Id = (Int32)command.ExecuteNonQuery();
                    string que = String.Format("INSERT INTO Advisor(Id, Salary , Designation)VALUES('" + Id + "','" + salary.Text + "' , '" + des + "')");
                    SqlCommand cmd1 = new SqlCommand(que, con);
                    cmd1.ExecuteNonQuery();
                    //SqlDataAdapter SDA1 = new SqlDataAdapter(que, c3);

                    //cmd1.ExecuteNonQuery();
                    MessageBox.Show("Entered");
                    Display();

                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                // dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                con.Open();

                string email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


                string query = "SELECT Id FROM Person WHERE Email = '" + email + "'";
                SqlCommand com = new SqlCommand(query, con);
                int Id = (Int32)com.ExecuteScalar();
                com.CommandText = "DELETE FROM Advisor WHERE Id = '" + Id + "'";
                com.ExecuteNonQuery();
                com.CommandText = "DELETE FROM Person WHERE Id = '" + Id + "'";
                com.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Data Deleted Sussecfully!");
                con.Close();

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            function = "update";
            int i;
            i = dataGridView1.SelectedCells[3].RowIndex;
            firstName.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            lastName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            salary.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            email_Id.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            contact_no.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
           // comboBox3.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            MessageBox.Show("Data updated successfully!");
        }

        private void AA_Click(object sender, EventArgs e)
        {
            Assign_Advisor aa = new Assign_Advisor();
            this.Hide();
            aa.Show();

        }

        private void designation_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            string name = "^[a-zA-Z]+$";
            if (Regex.IsMatch(firstName.Text, name))
            {
                errorProvider1.Clear();
                enter.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.firstName, "Please enter correct name");
                enter.Enabled = false;
                return;
            }
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            string name = "^[a-zA-Z]+$";
            if (Regex.IsMatch(lastName.Text, name))
            {
                errorProvider2.Clear();
                enter.Enabled = true;
            }
            else
            {
                errorProvider2.SetError(this.lastName, "Please enter correct name");
                enter.Enabled = false;
                return;
            }
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Id_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(email_Id.Text, pattern))
            {
                errorProvider3.Clear();
                enter.Enabled = true;
            }
            else
            {
                errorProvider3.SetError(this.email_Id, "Please enter valid email address");
                enter.Enabled = false;
                return;
            }
        }
    }
}
