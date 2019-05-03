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
    public partial class fyp : Form
    {
        public fyp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ma_Click(object sender, EventArgs e)
        {
           

        }

        private void ms_Click(object sender, EventArgs e)
        {
            Student_Management sm = new Student_Management();
            this.Hide();
            sm.Show();
        }

        private void mp_Click(object sender, EventArgs e)
        {
            Project_Management pm = new Project_Management();
            this.Hide();
            pm.Show();
        }

        private void me_Click(object sender, EventArgs e)
        {
            Evaluation eve = new Evaluation();
            this.Hide();
            eve.Show();
        }

        private void ma_Click_1(object sender, EventArgs e)
        {
            Advisor_Management ma = new Advisor_Management();
            this.Hide();
            ma.Show();
        }
    }
}
