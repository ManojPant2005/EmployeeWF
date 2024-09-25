namespace EmployeeWF
{
    partial class AddEmployee
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
            label1 = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            addemployee_status = new Label();
            label6 = new Label();
            addEmployee_department = new ComboBox();
            addEmployee_clearbtn = new Button();
            addEmployee_deletebtn = new Button();
            addEmployee_updatebtn = new Button();
            addEmployee_addbtn = new Button();
            addEmployee_importbtn = new Button();
            pictureBox1 = new PictureBox();
            addEmployee_phone = new TextBox();
            label5 = new Label();
            addEmployee_fullname = new TextBox();
            addEmployee_id = new TextBox();
            label4 = new Label();
            addEmployee_gender = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee's Data";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(addemployee_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addEmployee_department);
            panel2.Controls.Add(addEmployee_clearbtn);
            panel2.Controls.Add(addEmployee_deletebtn);
            panel2.Controls.Add(addEmployee_updatebtn);
            panel2.Controls.Add(addEmployee_addbtn);
            panel2.Controls.Add(addEmployee_importbtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(addEmployee_phone);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addEmployee_fullname);
            panel2.Controls.Add(addEmployee_id);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addEmployee_gender);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 260);
            panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBox1.Location = new Point(517, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 17;
            // 
            // addemployee_status
            // 
            addemployee_status.AutoSize = true;
            addemployee_status.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addemployee_status.Location = new Point(393, 126);
            addemployee_status.Name = "addemployee_status";
            addemployee_status.Size = new Size(57, 21);
            addemployee_status.TabIndex = 16;
            addemployee_status.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(393, 78);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 15;
            label6.Text = "Department";
            // 
            // addEmployee_department
            // 
            addEmployee_department.FormattingEnabled = true;
            addEmployee_department.Items.AddRange(new object[] { "IT", "Sales", "Development", "Senior", "Junior", "Fresher", "HR", "Manager", "Client", "Tester", "QA", "Network" });
            addEmployee_department.Location = new Point(517, 72);
            addEmployee_department.Name = "addEmployee_department";
            addEmployee_department.Size = new Size(182, 28);
            addEmployee_department.TabIndex = 14;
            // 
            // addEmployee_clearbtn
            // 
            addEmployee_clearbtn.BackColor = Color.FromArgb(33, 8, 97);
            addEmployee_clearbtn.Cursor = Cursors.Hand;
            addEmployee_clearbtn.FlatAppearance.BorderSize = 0;
            addEmployee_clearbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_clearbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_clearbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_clearbtn.FlatStyle = FlatStyle.Flat;
            addEmployee_clearbtn.Font = new Font("Tahoma", 10.8F);
            addEmployee_clearbtn.ForeColor = Color.White;
            addEmployee_clearbtn.Location = new Point(505, 207);
            addEmployee_clearbtn.Name = "addEmployee_clearbtn";
            addEmployee_clearbtn.Size = new Size(100, 40);
            addEmployee_clearbtn.TabIndex = 13;
            addEmployee_clearbtn.Text = "Clear";
            addEmployee_clearbtn.UseVisualStyleBackColor = false;
            addEmployee_clearbtn.Click += addEmployee_clearbtn_Click;
            // 
            // addEmployee_deletebtn
            // 
            addEmployee_deletebtn.BackColor = Color.FromArgb(33, 8, 97);
            addEmployee_deletebtn.Cursor = Cursors.Hand;
            addEmployee_deletebtn.FlatAppearance.BorderSize = 0;
            addEmployee_deletebtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_deletebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_deletebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_deletebtn.FlatStyle = FlatStyle.Flat;
            addEmployee_deletebtn.Font = new Font("Tahoma", 10.8F);
            addEmployee_deletebtn.ForeColor = Color.White;
            addEmployee_deletebtn.Location = new Point(379, 207);
            addEmployee_deletebtn.Name = "addEmployee_deletebtn";
            addEmployee_deletebtn.Size = new Size(100, 40);
            addEmployee_deletebtn.TabIndex = 12;
            addEmployee_deletebtn.Text = "Delete";
            addEmployee_deletebtn.UseVisualStyleBackColor = false;
            // 
            // addEmployee_updatebtn
            // 
            addEmployee_updatebtn.BackColor = Color.FromArgb(33, 8, 97);
            addEmployee_updatebtn.Cursor = Cursors.Hand;
            addEmployee_updatebtn.FlatAppearance.BorderSize = 0;
            addEmployee_updatebtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_updatebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_updatebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_updatebtn.FlatStyle = FlatStyle.Flat;
            addEmployee_updatebtn.Font = new Font("Tahoma", 10.8F);
            addEmployee_updatebtn.ForeColor = Color.White;
            addEmployee_updatebtn.Location = new Point(249, 207);
            addEmployee_updatebtn.Name = "addEmployee_updatebtn";
            addEmployee_updatebtn.Size = new Size(100, 40);
            addEmployee_updatebtn.TabIndex = 11;
            addEmployee_updatebtn.Text = "Update";
            addEmployee_updatebtn.UseVisualStyleBackColor = false;
            addEmployee_updatebtn.Click += addEmployee_updatebtn_Click;
            // 
            // addEmployee_addbtn
            // 
            addEmployee_addbtn.BackColor = Color.FromArgb(33, 8, 97);
            addEmployee_addbtn.Cursor = Cursors.Hand;
            addEmployee_addbtn.FlatAppearance.BorderSize = 0;
            addEmployee_addbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_addbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_addbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            addEmployee_addbtn.FlatStyle = FlatStyle.Flat;
            addEmployee_addbtn.Font = new Font("Tahoma", 10.8F);
            addEmployee_addbtn.ForeColor = Color.White;
            addEmployee_addbtn.Location = new Point(122, 207);
            addEmployee_addbtn.Name = "addEmployee_addbtn";
            addEmployee_addbtn.Size = new Size(100, 40);
            addEmployee_addbtn.TabIndex = 10;
            addEmployee_addbtn.Text = "Add";
            addEmployee_addbtn.UseVisualStyleBackColor = false;
            addEmployee_addbtn.Click += addEmployee_addbtn_Click;
            // 
            // addEmployee_importbtn
            // 
            addEmployee_importbtn.BackColor = Color.FromArgb(33, 8, 97);
            addEmployee_importbtn.Cursor = Cursors.Hand;
            addEmployee_importbtn.FlatStyle = FlatStyle.Flat;
            addEmployee_importbtn.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployee_importbtn.ForeColor = SystemColors.ButtonHighlight;
            addEmployee_importbtn.Location = new Point(725, 126);
            addEmployee_importbtn.Name = "addEmployee_importbtn";
            addEmployee_importbtn.Size = new Size(100, 34);
            addEmployee_importbtn.TabIndex = 9;
            addEmployee_importbtn.Text = "Import ";
            addEmployee_importbtn.UseVisualStyleBackColor = false;
            addEmployee_importbtn.Click += addEmployee_importbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(725, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // addEmployee_phone
            // 
            addEmployee_phone.Location = new Point(517, 27);
            addEmployee_phone.Name = "addEmployee_phone";
            addEmployee_phone.Size = new Size(182, 27);
            addEmployee_phone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(393, 29);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 6;
            label5.Text = "Phone Number";
            // 
            // addEmployee_fullname
            // 
            addEmployee_fullname.Location = new Point(146, 72);
            addEmployee_fullname.Name = "addEmployee_fullname";
            addEmployee_fullname.Size = new Size(227, 27);
            addEmployee_fullname.TabIndex = 5;
            // 
            // addEmployee_id
            // 
            addEmployee_id.Location = new Point(146, 33);
            addEmployee_id.Name = "addEmployee_id";
            addEmployee_id.Size = new Size(227, 27);
            addEmployee_id.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 125);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // addEmployee_gender
            // 
            addEmployee_gender.FormattingEnabled = true;
            addEmployee_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            addEmployee_gender.Location = new Point(146, 125);
            addEmployee_gender.Name = "addEmployee_gender";
            addEmployee_gender.Size = new Size(227, 28);
            addEmployee_gender.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 78);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 1;
            label3.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 33);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 0;
            label2.Text = "Employee ID";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(848, 200);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "AddEmployee";
            Size = new Size(875, 554);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel2;
        private TextBox addEmployee_fullname;
        private TextBox addEmployee_id;
        private Label label4;
        private ComboBox addEmployee_gender;
        private Label label3;
        private Label label2;
        private Button addEmployee_importbtn;
        private PictureBox pictureBox1;
        private TextBox addEmployee_phone;
        private Label label5;
        private Button addEmployee_clearbtn;
        private Button addEmployee_deletebtn;
        private Button addEmployee_updatebtn;
        private Button addEmployee_addbtn;
        private Label label6;
        private ComboBox addEmployee_department;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label addemployee_status;
    }
}
