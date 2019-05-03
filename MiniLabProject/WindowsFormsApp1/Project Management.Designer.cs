namespace WindowsFormsApp1
{
    partial class Project_Management
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
            this.exit = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enter = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exit.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(338, 483);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(104, 45);
            this.exit.TabIndex = 19;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.update.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(843, 483);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 45);
            this.update.TabIndex = 18;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.AntiqueWhite;
            this.del.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(736, 483);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(101, 45);
            this.del.TabIndex = 17;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(736, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 280);
            this.dataGridView1.TabIndex = 16;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.enter.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(458, 483);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(101, 45);
            this.enter.TabIndex = 15;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(338, 291);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(221, 22);
            this.title.TabIndex = 14;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(338, 226);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(221, 22);
            this.description.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(150, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(150, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descritiption";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia Pro Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(488, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Project Management";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(935, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Assign Project ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1086, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "Display Assignment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Project_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1413, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.title);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Project_Management";
            this.Text = "Project_Management";
            this.Load += new System.EventHandler(this.Project_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}