using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;


namespace WindowsFormsApp1
{
    public partial class Student_Management : Form
    {
        string conString = "Data Source = LAPTOP-E7MPN3U3; Initial Catalog = ProjectA; Integrated Security = True";
        string function;
        int Id;
        private string filename;

        public Student_Management()
        {
            InitializeComponent();
            Display();
        }
      

         
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Student_info_Click(object sender, EventArgs e)
        {

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

            SqlConnection c1 = new SqlConnection(conString);
            SqlConnection c2 = new SqlConnection(conString);
            SqlConnection c3 = new SqlConnection(conString);
            c1.Open();
            c2.Open();
            c3.Open();

            string gender = "SELECT Id FROM LookUp WHERE Value = '" + comboBox1.Text + "' AND Category = 'GENDER'";
            SqlCommand cmd = new SqlCommand(gender, c2);
            int gender1 = (Int32)cmd.ExecuteScalar();
            cmd.CommandText = String.Format("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender)VALUES('" + firstName.Text + "', '" + lastName.Text + "', '" + contact_no.Text + "', '" + email_Id.Text + "', '" + dateTimePicker1.Value + "' , '" + gender1 + "')");
            cmd.ExecuteNonQuery();


            //SDA.SelectCommand.ExecuteNonQuery();

            string query = String.Format("SELECT Id FROM Person WHERE Email = '" + email_Id.Text + "'");
            SqlCommand command = new SqlCommand(query, c1);
            int Id = (Int32)command.ExecuteScalar();


            //command.CommandText = String.Format("SELECT Id FROM Person WHERE Email = '" + email_Id + "'");
            //int Id = (Int32)command.ExecuteNonQuery();
            string que = String.Format("INSERT INTO Student(Id, RegistrationNo)VALUES('" + Id + "','" + regNum.Text + "')");
            SqlCommand cmd1 = new SqlCommand(que, c3);
            cmd1.ExecuteNonQuery();
            //SqlDataAdapter SDA1 = new SqlDataAdapter(que, c3);

            //cmd1.ExecuteNonQuery();
            MessageBox.Show("Entered");
            Display();
            c1.Close();
            c2.Close();
            c3.Close();
        }


     
        private void Display()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                dataGridView1.AllowUserToAddRows = false;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter("SELECT FirstName,LastName, RegistrationNo, DateOfBirth,Contact,Email,Gender FROM Person JOIN Student ON Person.Id = Student.Id", con);
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


                string query = "SELECT Id FROM Student WHERE RegistrationNo = '" + regNum.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE Student SET RegistrationNo = '" + regNum.Text + "' WHERE Id = '" + Id + "'";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Person SET FirstName = '" + firstName.Text + "', LastName = '" + lastName.Text + "' ,Email = ' " + email_Id.Text + "', Contact = '" + contact_no.Text + "', DateOfBirth = '" + dateTimePicker1.Value + "', Gender = '" + comboBox1.Text + "' WHERE Id = '" + Id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated successfully!");
                con.Close();
            }
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            fyp f2 = new fyp();
            this.Hide();
            f2.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                // dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                con.Open();

                string email = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


                string query = "SELECT Id FROM Person WHERE Email = '" + email + "'";
                SqlCommand com = new SqlCommand(query, con);
                int Id = (Int32)com.ExecuteScalar();
                com.CommandText = "DELETE FROM Student WHERE Id = '" + Id + "'";
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
            try
            {
                function = "update";


                int i;
                i = dataGridView1.SelectedRows[0].Index;
                firstName.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                lastName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                regNum.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                email_Id.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                contact_no.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                
                comboBox1.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
       

        private void cg_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    //  string que = "SELECT Id FROM Project";

                    //SqlCommand com1 = new SqlCommand(que, con);
                    //int id = (Int32)com1.ExecuteScalar();
                    string checkStatus = "SELECT Id FROM LookUp WHERE VALUE = 'InActive' AND Category = 'STATUS'";
                    SqlCommand command = new SqlCommand(checkStatus, con);
                    int status = (Int32)command.ExecuteScalar();

                    string query = string.Format("INSERT INTO [Group](Created_On)VALUES('" + DateTime.Now + "')");
                    SqlCommand com = new SqlCommand(query, con);
                    com.ExecuteNonQuery();
                    string rollNum = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string Sid = "SELECT Id FROM Student WHERE RegistrationNo = '" + rollNum + "'";
                    SqlCommand cmd1 = new SqlCommand(Sid, con);
                    int S_id = (Int32)cmd1.ExecuteScalar();
                    string addStudent = "SELECT Id FROM [Group]";
                    SqlCommand cmd = new SqlCommand(addStudent, con);
                    int Gid = (Int32)cmd.ExecuteScalar();
                    string qury = string.Format("INSERT INTO GroupStudent(GroupId, StudentId , AssignmentDate, Status)VALUES('" + Gid + "', '" + S_id + "', '" + DateTime.Now + "','" + status + "' )");
                    SqlCommand sqlCommand = new SqlCommand(qury, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Group Created");
                    con.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void sg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create_Group cg = new Create_Group();
            this.Hide();
            cg.Show();
        }

        private void Student_Management_Load(object sender, EventArgs e)
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
                errorProvider2.SetError(this.firstName, "Please enter correct name");
                enter.Enabled = false;
                return;
            }
        }

        private void regNum_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\d{4}(-[A-Z][A-Z])(-\d{3})"; 

            
            if (Regex.IsMatch(regNum.Text, pattern))
            {
                errorProvider3.Clear();
                enter.Enabled = true;

            }
            else
            {

                errorProvider3.SetError(this.regNum, "Please enter correct Registration Number");
                enter.Enabled = false;
                return;
            }
        }

        private void email_Id_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(email_Id.Text, pattern))
            {
                errorProvider4.Clear();
                enter.Enabled = true;
            }
            else
            {
                errorProvider4.SetError(this.email_Id, "Please enter correct email");
                enter.Enabled = false;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportgridtopdf(dataGridView1, "download");
        }
        public void exportgridtopdf(DataGridView dataGridView, String fileName)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dataGridView.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach(DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240,240,240);
                pdfPTable.AddCell(cell);
            }
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new iTextSharp.text.Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialogue = new SaveFileDialog();
            savefiledialogue.FileName = fileName;
            savefiledialogue.DefaultExt = ".pdf";
            if(savefiledialogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                }
            }

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }

    
}
