namespace WindowsFormsApp1
{
    partial class Assign_Advisor
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
            this.button2 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(819, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 45);
            this.button2.TabIndex = 34;
            this.button2.Text = "Display Advisor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exit.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(306, 497);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(104, 45);
            this.exit.TabIndex = 32;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(627, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 280);
            this.dataGridView1.TabIndex = 29;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.enter.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(426, 497);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(101, 45);
            this.enter.TabIndex = 28;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia Pro Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(446, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 43);
            this.label1.TabIndex = 23;
            this.label1.Text = "AssignAdvisor";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.comboBox3.Location = new System.Drawing.Point(279, 309);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(248, 24);
            this.comboBox3.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia Pro Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(150, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 51;
            this.label10.Text = "Advisor";
            // 
            // Assign_Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1202, 622);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label1);
            this.Name = "Assign_Advisor";
            this.Text = "Assign_Advisor";
            this.Load += new System.EventHandler(this.Assign_Advisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
    }
}