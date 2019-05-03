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
    public partial class Evaluation : Form
    {
        string conString = "Data Source = LAPTOP-E7MPN3U3; Initial Catalog = ProjectA; Integrated Security = True";
        string function;
        public Evaluation()
        {
            InitializeComponent();
            Display();
        }
        private void Insert()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = String.Format("INSERT INTO Evaluation(Name,TotalMarks,TotalWeightage)VALUES('" + name.Text + "', '" + marks.Text + "', '" + weightage.Text + "')");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entered");
                Display();
                con.Close();

            }
        }
        private void Display()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                dataGridView1.AllowUserToAddRows = false;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter("SELECT * FROM Evaluation", con);
                DataTable dataTable = new DataTable();
                sdr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }

        }

        private void weightage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void evGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assign_Project ap = new Assign_Project();
            this.Hide();
            ap.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            fyp f = new fyp();
            this.Hide();
            f.Show();
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
        private void Update()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();


                string query = "SELECT Id FROM Evaluation WHERE Name = '" + name.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int id = (Int32)cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE Evaluation SET TotalMarks = '" + marks.Text + "' WHERE Id = '" + id + "'";
                cmd.ExecuteNonQuery();


                //  MessageBox.Show("Data Updated successfully!");
                con.Close();
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                // dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                con.Open();

                string marks = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


                string query = "SELECT Id FROM Evaluation WHERE TotalMarks = '" + marks + "'";
                SqlCommand com = new SqlCommand(query, con);
                int Id = (Int32)com.ExecuteScalar();
                com.CommandText = "DELETE FROM Evaluation WHERE Id = '" + Id + "'";
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
            name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            marks.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            weightage.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            MessageBox.Show("Data updated successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
