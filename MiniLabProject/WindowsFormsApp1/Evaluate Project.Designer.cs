namespace WindowsFormsApp1
{
    partial class Assign_Project
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
            this.enter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.weightage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exit.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(290, 447);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 36);
            this.exit.TabIndex = 37;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.update.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(816, 449);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(97, 34);
            this.update.TabIndex = 36;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.AntiqueWhite;
            this.del.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(679, 450);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(131, 34);
            this.del.TabIndex = 35;
            this.del.Text = "View Groups";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.enter.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(396, 447);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 36);
            this.enter.TabIndex = 34;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(589, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 281);
            this.dataGridView1.TabIndex = 33;
            // 
            // weightage
            // 
            this.weightage.Location = new System.Drawing.Point(299, 256);
            this.weightage.Name = "weightage";
            this.weightage.Size = new System.Drawing.Size(197, 22);
            this.weightage.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(112, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Obtained Marks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia Pro Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(345, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 43);
            this.label1.TabIndex = 26;
            this.label1.Text = "Evaluate Group";
            // 
            // Assign_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 570);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.del);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.weightage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Assign_Project";
            this.Text = "Assign_Project";
            this.Load += new System.EventHandler(this.Assign_Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox weightage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}