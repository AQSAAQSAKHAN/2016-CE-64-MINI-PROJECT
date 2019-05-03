namespace WindowsFormsApp1
{
    partial class Student_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Exit = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.enter = new System.Windows.Forms.Button();
            this.email_Id = new System.Windows.Forms.TextBox();
            this.contact_no = new System.Windows.Forms.TextBox();
            this.regNum = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Reg_No = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.Student_info = new System.Windows.Forms.Label();
            this.cg = new System.Windows.Forms.Button();
            this.sg = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Exit.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(463, 495);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 37);
            this.Exit.TabIndex = 41;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.update.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(914, 495);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 37);
            this.update.TabIndex = 40;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.AntiqueWhite;
            this.del.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(824, 495);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(84, 37);
            this.del.TabIndex = 39;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(741, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 301);
            this.dataGridView1.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(463, 288);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox1.Location = new System.Drawing.Point(463, 409);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.enter.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(563, 495);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 37);
            this.enter.TabIndex = 35;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // email_Id
            // 
            this.email_Id.Location = new System.Drawing.Point(463, 368);
            this.email_Id.Name = "email_Id";
            this.email_Id.Size = new System.Drawing.Size(200, 22);
            this.email_Id.TabIndex = 34;
            this.email_Id.TextChanged += new System.EventHandler(this.email_Id_TextChanged);
            // 
            // contact_no
            // 
            this.contact_no.Location = new System.Drawing.Point(463, 325);
            this.contact_no.Name = "contact_no";
            this.contact_no.Size = new System.Drawing.Size(200, 22);
            this.contact_no.TabIndex = 33;
            // 
            // regNum
            // 
            this.regNum.Location = new System.Drawing.Point(463, 249);
            this.regNum.Name = "regNum";
            this.regNum.Size = new System.Drawing.Size(200, 22);
            this.regNum.TabIndex = 32;
            this.regNum.TextChanged += new System.EventHandler(this.regNum_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(463, 210);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(200, 22);
            this.lastName.TabIndex = 31;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(463, 174);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(200, 22);
            this.firstName.TabIndex = 30;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gender.Location = new System.Drawing.Point(180, 394);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(71, 24);
            this.gender.TabIndex = 29;
            this.gender.Text = "Gender";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contact.Location = new System.Drawing.Point(180, 322);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(72, 24);
            this.contact.TabIndex = 28;
            this.contact.Text = "Contact\r\n";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.email.Location = new System.Drawing.Point(180, 355);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 24);
            this.email.TabIndex = 27;
            this.email.Text = "Email";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.last_name.Location = new System.Drawing.Point(180, 210);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(93, 23);
            this.last_name.TabIndex = 26;
            this.last_name.Text = "Last Name";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DOB.Location = new System.Drawing.Point(180, 286);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(113, 24);
            this.DOB.TabIndex = 25;
            this.DOB.Text = "Date of Birth";
            // 
            // Reg_No
            // 
            this.Reg_No.AutoSize = true;
            this.Reg_No.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reg_No.Location = new System.Drawing.Point(180, 246);
            this.Reg_No.Name = "Reg_No";
            this.Reg_No.Size = new System.Drawing.Size(180, 24);
            this.Reg_No.TabIndex = 24;
            this.Reg_No.Text = "Registration Number\r\n";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.first_name.Location = new System.Drawing.Point(180, 174);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(100, 24);
            this.first_name.TabIndex = 23;
            this.first_name.Text = "First Name";
            // 
            // Student_info
            // 
            this.Student_info.AutoSize = true;
            this.Student_info.Font = new System.Drawing.Font("Georgia Pro Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Student_info.Location = new System.Drawing.Point(456, 54);
            this.Student_info.Name = "Student_info";
            this.Student_info.Size = new System.Drawing.Size(290, 38);
            this.Student_info.TabIndex = 22;
            this.Student_info.Text = "Student Information";
            this.Student_info.Click += new System.EventHandler(this.Student_info_Click);
            // 
            // cg
            // 
            this.cg.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cg.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cg.Location = new System.Drawing.Point(1006, 495);
            this.cg.Name = "cg";
            this.cg.Size = new System.Drawing.Size(142, 37);
            this.cg.TabIndex = 43;
            this.cg.Text = "Create Group";
            this.cg.UseVisualStyleBackColor = false;
            this.cg.Click += new System.EventHandler(this.cg_Click);
            // 
            // sg
            // 
            this.sg.AutoSize = true;
            this.sg.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg.Location = new System.Drawing.Point(180, 451);
            this.sg.Name = "sg";
            this.sg.Size = new System.Drawing.Size(103, 24);
            this.sg.TabIndex = 45;
            this.sg.TabStop = true;
            this.sg.Text = "See Groups";
            this.sg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sg_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1154, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 46;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1457, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sg);
            this.Controls.Add(this.cg);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.email_Id);
            this.Controls.Add(this.contact_no);
            this.Controls.Add(this.regNum);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.email);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Reg_No);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.Student_info);
            this.Name = "Student_Management";
            this.Text = "Student_Management";
            this.Load += new System.EventHandler(this.Student_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox email_Id;
        private System.Windows.Forms.TextBox contact_no;
        private System.Windows.Forms.TextBox regNum;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Reg_No;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label Student_info;
        private System.Windows.Forms.Button cg;
        private System.Windows.Forms.LinkLabel sg;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button button1;
    }
}