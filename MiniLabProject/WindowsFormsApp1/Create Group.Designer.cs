namespace WindowsFormsApp1
{
    partial class Create_Group
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.asp = new System.Windows.Forms.Button();
            this.assign = new System.Windows.Forms.Button();
            this.advisor_assign = new System.Windows.Forms.Button();
            this.evg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(818, 333);
            this.dataGridView1.TabIndex = 4;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Insert.Font = new System.Drawing.Font("Georgia Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.Black;
            this.Insert.Location = new System.Drawing.Point(218, 548);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(116, 41);
            this.Insert.TabIndex = 9;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.AntiqueWhite;
            this.del.Font = new System.Drawing.Font("Georgia Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.ForeColor = System.Drawing.Color.Black;
            this.del.Location = new System.Drawing.Point(350, 548);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(116, 41);
            this.del.TabIndex = 10;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.update.Font = new System.Drawing.Font("Georgia Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(482, 548);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(116, 41);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "FYP Groups";
            // 
            // asp
            // 
            this.asp.BackColor = System.Drawing.Color.AntiqueWhite;
            this.asp.Font = new System.Drawing.Font("Georgia Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asp.ForeColor = System.Drawing.Color.Black;
            this.asp.Location = new System.Drawing.Point(12, 97);
            this.asp.Name = "asp";
            this.asp.Size = new System.Drawing.Size(200, 66);
            this.asp.TabIndex = 13;
            this.asp.Text = "Assign Project";
            this.asp.UseVisualStyleBackColor = false;
            this.asp.Click += new System.EventHandler(this.asp_Click);
            // 
            // assign
            // 
            this.assign.BackColor = System.Drawing.Color.AntiqueWhite;
            this.assign.Font = new System.Drawing.Font("Georgia Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign.ForeColor = System.Drawing.Color.Black;
            this.assign.Location = new System.Drawing.Point(423, 97);
            this.assign.Name = "assign";
            this.assign.Size = new System.Drawing.Size(204, 66);
            this.assign.TabIndex = 14;
            this.assign.Text = "Assignment";
            this.assign.UseVisualStyleBackColor = false;
            this.assign.Click += new System.EventHandler(this.button2_Click);
            // 
            // advisor_assign
            // 
            this.advisor_assign.BackColor = System.Drawing.Color.AntiqueWhite;
            this.advisor_assign.Font = new System.Drawing.Font("Georgia Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisor_assign.ForeColor = System.Drawing.Color.Black;
            this.advisor_assign.Location = new System.Drawing.Point(218, 97);
            this.advisor_assign.Name = "advisor_assign";
            this.advisor_assign.Size = new System.Drawing.Size(199, 66);
            this.advisor_assign.TabIndex = 15;
            this.advisor_assign.Text = "Assign Advisor";
            this.advisor_assign.UseVisualStyleBackColor = false;
            this.advisor_assign.Click += new System.EventHandler(this.advisor_assign_Click);
            // 
            // evg
            // 
            this.evg.BackColor = System.Drawing.Color.AntiqueWhite;
            this.evg.Font = new System.Drawing.Font("Georgia Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evg.ForeColor = System.Drawing.Color.Black;
            this.evg.Location = new System.Drawing.Point(633, 97);
            this.evg.Name = "evg";
            this.evg.Size = new System.Drawing.Size(199, 66);
            this.evg.TabIndex = 16;
            this.evg.Text = "Evaluate Group";
            this.evg.UseVisualStyleBackColor = false;
            this.evg.Click += new System.EventHandler(this.evg_Click);
            // 
            // Create_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(844, 628);
            this.Controls.Add(this.evg);
            this.Controls.Add(this.advisor_assign);
            this.Controls.Add(this.assign);
            this.Controls.Add(this.asp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.del);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia Pro Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Create_Group";
            this.Text = "Create_Group";
            this.Load += new System.EventHandler(this.Create_Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button asp;
        private System.Windows.Forms.Button assign;
        private System.Windows.Forms.Button advisor_assign;
        private System.Windows.Forms.Button evg;
    }
}