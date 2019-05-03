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
    public partial class Create_Group : Form
    {
        string conString = "Data Source = LAPTOP-E7MPN3U3; Initial Catalog = ProjectA; Integrated Security = True";
        string function;
        int Id;
        public Create_Group()
        {
            InitializeComponent();
            
        }

        private void createGroup_Click(object sender, EventArgs e)
        {

        }
        
        private void Create_Group_Load(object sender, EventArgs e)
        {
            Display();
        }
       
     
        private void Display()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                dataGridView1.AllowUserToAddRows = false;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter("SELECT * FROM GroupStudent", con);
                DataTable dataTable = new DataTable();
                sdr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }

        }
        
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void add_Click(object sender, EventArgs e)
        {
           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Student_Management s = new Student_Management();
            this.Hide();
            s.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string Gid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


                string query = "SELECT Id FROM GroupStudent WHERE GroupId = '" + Gid + "'";
                SqlCommand com = new SqlCommand(query, con);
                int Id = (Int32)com.ExecuteScalar();
                com.CommandText = "DELETE FROM GroupStudent WHERE GroupId = '" + Id + "'";
                com.ExecuteNonQuery();
               // com.CommandText = "DELETE FROM Person WHERE Id = '" + Id + "'";
               // com.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Data Deleted Sussecfully!");
                con.Close();
            }
        }

        private void asp_Click(object sender, EventArgs e)
        {
            Project_Management pm = new Project_Management();
            this.Hide();
            pm.Show();
        }

        private void advisor_assign_Click(object sender, EventArgs e)
        {
            Advisor_Management am = new Advisor_Management();
            this.Hide();
            am.Show();
        }

        private void evg_Click(object sender, EventArgs e)
        {
            Evaluation ev = new Evaluation();
            this.Hide();
            ev.Show();
        }
    }
}
