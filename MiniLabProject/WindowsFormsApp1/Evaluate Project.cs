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
    public partial class Assign_Project : Form
    {
        string conString = "Data Source = LAPTOP-E7MPN3U3; Initial Catalog = ProjectA; Integrated Security = True";
        public Assign_Project()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                dataGridView1.AllowUserToAddRows = false;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter("SELECT * FROM GroupEvaluation", con);
                DataTable dataTable = new DataTable();
                sdr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }

        private void Assign_Project_Load(object sender, EventArgs e)
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

        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();


                    string ev_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string eval = "SELECT Id FROM Evaluation WHERE Id = '" + ev_id + "'";
                    SqlCommand cmd1 = new SqlCommand(eval, con);
                    int eval_id = (Int32)cmd1.ExecuteScalar();
                    string addStudent = "SELECT Id FROM [Group]";
                    SqlCommand cmd = new SqlCommand(addStudent, con);
                    int Getid = (Int32)cmd.ExecuteScalar();
                    string qury = string.Format("INSERT INTO GroupEvaluation(GroupId , EvaluationId, ObtainedMarks, EvaluationDate)VALUES('" + Getid + "', '" + eval_id + "','" + weightage.Text + "' , '" + DateTime.Now + "')");
                    SqlCommand sqlCommand = new SqlCommand(qury, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Group Evaluated");
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
