namespace WindowsFormsApp1
{
    partial class Evaluation
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
            this.marks = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.evGroup = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exit.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(508, 457);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 36);
            this.exit.TabIndex = 24;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.update.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(1121, 457);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(97, 34);
            this.update.TabIndex = 23;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.AntiqueWhite;
            this.del.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(1015, 458);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(100, 34);
            this.del.TabIndex = 22;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.enter.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(614, 457);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 36);
            this.enter.TabIndex = 21;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(894, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 281);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // weightage
            // 
            this.weightage.Location = new System.Drawing.Point(517, 293);
            this.weightage.Name = "weightage";
            this.weightage.Size = new System.Drawing.Size(197, 22);
            this.weightage.TabIndex = 19;
            this.weightage.TextChanged += new System.EventHandler(this.weightage_TextChanged);
            // 
            // marks
            // 
            this.marks.Location = new System.Drawing.Point(517, 230);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(197, 22);
            this.marks.TabIndex = 18;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(517, 160);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 22);
            this.name.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(330, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(330, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Weightage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(330, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Marks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia Pro Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(576, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Evaluation Management";
            // 
            // evGroup
            // 
            this.evGroup.ActiveLinkColor = System.Drawing.Color.Red;
            this.evGroup.AutoSize = true;
            this.evGroup.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evGroup.Location = new System.Drawing.Point(334, 368);
            this.evGroup.Name = "evGroup";
            this.evGroup.Size = new System.Drawing.Size(130, 23);
            this.evGroup.TabIndex = 25;
            this.evGroup.TabStop = true;
            this.evGroup.Text = "Evaluate Group";
            this.evGroup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.evGroup_LinkClicked);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1546, 630);
            this.Controls.Add(this.evGroup);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.del);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.weightage);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
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
        private System.Windows.Forms.TextBox marks;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel evGroup;
    }
}