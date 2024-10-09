namespace EmployeeWF
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            salary_clearBtn = new Button();
            salary_updateBtn = new Button();
            salary_salary = new TextBox();
            label5 = new Label();
            salary_position = new TextBox();
            label4 = new Label();
            salary_name = new TextBox();
            label3 = new Label();
            salary_employeeID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(salary_clearBtn);
            panel1.Controls.Add(salary_updateBtn);
            panel1.Controls.Add(salary_salary);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(salary_position);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(salary_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(salary_employeeID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 650);
            panel1.TabIndex = 0;
            // 
            // salary_clearBtn
            // 
            salary_clearBtn.BackColor = Color.FromArgb(33, 8, 97);
            salary_clearBtn.Cursor = Cursors.Hand;
            salary_clearBtn.FlatAppearance.BorderSize = 0;
            salary_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 8, 97);
            salary_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            salary_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            salary_clearBtn.FlatStyle = FlatStyle.Flat;
            salary_clearBtn.Font = new Font("Tahoma", 10.8F);
            salary_clearBtn.ForeColor = Color.White;
            salary_clearBtn.Location = new Point(143, 390);
            salary_clearBtn.Name = "salary_clearBtn";
            salary_clearBtn.Size = new Size(100, 40);
            salary_clearBtn.TabIndex = 14;
            salary_clearBtn.Text = "Clear";
            salary_clearBtn.UseVisualStyleBackColor = false;
            salary_clearBtn.Click += salary_clearBtn_Click_1;
            // 
            // salary_updateBtn
            // 
            salary_updateBtn.BackColor = Color.FromArgb(33, 8, 97);
            salary_updateBtn.Cursor = Cursors.Hand;
            salary_updateBtn.FlatAppearance.BorderSize = 0;
            salary_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 8, 97);
            salary_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            salary_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            salary_updateBtn.FlatStyle = FlatStyle.Flat;
            salary_updateBtn.Font = new Font("Tahoma", 10.8F);
            salary_updateBtn.ForeColor = Color.White;
            salary_updateBtn.Location = new Point(20, 390);
            salary_updateBtn.Name = "salary_updateBtn";
            salary_updateBtn.Size = new Size(100, 40);
            salary_updateBtn.TabIndex = 12;
            salary_updateBtn.Text = "Update";
            salary_updateBtn.UseVisualStyleBackColor = false;
            salary_updateBtn.Click += salary_updateBtn_Click_1;
            // 
            // salary_salary
            // 
            salary_salary.BorderStyle = BorderStyle.FixedSingle;
            salary_salary.Location = new Point(20, 324);
            salary_salary.Multiline = true;
            salary_salary.Name = "salary_salary";
            salary_salary.Size = new Size(223, 34);
            salary_salary.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 290);
            label5.Name = "label5";
            label5.Size = new Size(63, 22);
            label5.TabIndex = 8;
            label5.Text = "Salary:";
            // 
            // salary_position
            // 
            salary_position.BorderStyle = BorderStyle.FixedSingle;
            salary_position.Location = new Point(20, 239);
            salary_position.Multiline = true;
            salary_position.Name = "salary_position";
            salary_position.Size = new Size(223, 34);
            salary_position.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 202);
            label4.Name = "label4";
            label4.Size = new Size(78, 22);
            label4.TabIndex = 6;
            label4.Text = "Position:";
            // 
            // salary_name
            // 
            salary_name.BorderStyle = BorderStyle.FixedSingle;
            salary_name.Location = new Point(20, 147);
            salary_name.Multiline = true;
            salary_name.Name = "salary_name";
            salary_name.Size = new Size(223, 34);
            salary_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 113);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 4;
            label3.Text = "Full Name:";
            // 
            // salary_employeeID
            // 
            salary_employeeID.BorderStyle = BorderStyle.FixedSingle;
            salary_employeeID.Location = new Point(20, 60);
            salary_employeeID.Multiline = true;
            salary_employeeID.Name = "salary_employeeID";
            salary_employeeID.Size = new Size(223, 34);
            salary_employeeID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 35);
            label2.Name = "label2";
            label2.Size = new Size(117, 22);
            label2.TabIndex = 2;
            label2.Text = "Employee ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(299, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 650);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(865, 579);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salary";
            Size = new Size(1194, 667);
            Load += Salary_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox salary_salary;
        private Label label5;
        private TextBox salary_position;
        private Label label4;
        private TextBox salary_name;
        private Label label3;
        private TextBox salary_employeeID;
        private Label label2;
        private Button salary_clearBtn;
        private Button button2;
        private Button salary_updateBtn;
        private Button addEmployee_addBtn_Click;
    }
}
