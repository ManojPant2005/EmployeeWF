namespace EmployeeWF
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            label2 = new Label();
            exit = new Label();
            panel2 = new Panel();
            department_btn = new Button();
            label1 = new Label();
            logout_btn = new Button();
            addemployee_btn = new Button();
            dashboard_btn = new Button();
            greet_user = new Label();
            pictureBox1 = new PictureBox();
            department1 = new Department();
            addEmployee1 = new AddEmployee();
            dashboard1 = new Dashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 8, 97);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 46);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(11, 10);
            label2.Name = "label2";
            label2.Size = new Size(293, 24);
            label2.TabIndex = 1;
            label2.Text = "Employee Management System";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ButtonHighlight;
            exit.Location = new Point(1066, 9);
            exit.Name = "exit";
            exit.Size = new Size(22, 22);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 8, 97);
            panel2.Controls.Add(department_btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(addemployee_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(greet_user);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 554);
            panel2.TabIndex = 1;
            // 
            // department_btn
            // 
            department_btn.BackColor = Color.FromArgb(33, 8, 97);
            department_btn.Cursor = Cursors.Hand;
            department_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            department_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            department_btn.FlatStyle = FlatStyle.Flat;
            department_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            department_btn.ForeColor = SystemColors.ButtonHighlight;
            department_btn.Location = new Point(12, 338);
            department_btn.Name = "department_btn";
            department_btn.Size = new Size(189, 46);
            department_btn.TabIndex = 6;
            department_btn.Text = "DEPARTMENT";
            department_btn.UseVisualStyleBackColor = false;
            department_btn.Click += department_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(77, 505);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 5;
            label1.Text = "Sign Out";
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.ForeColor = SystemColors.ControlLightLight;
            logout_btn.Image = (Image)resources.GetObject("logout_btn.Image");
            logout_btn.ImageAlign = ContentAlignment.MiddleLeft;
            logout_btn.Location = new Point(36, 500);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(35, 35);
            logout_btn.TabIndex = 4;
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // addemployee_btn
            // 
            addemployee_btn.BackColor = Color.FromArgb(33, 8, 97);
            addemployee_btn.Cursor = Cursors.Hand;
            addemployee_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            addemployee_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            addemployee_btn.FlatStyle = FlatStyle.Flat;
            addemployee_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addemployee_btn.ForeColor = SystemColors.ButtonHighlight;
            addemployee_btn.Location = new Point(12, 269);
            addemployee_btn.Name = "addemployee_btn";
            addemployee_btn.Size = new Size(189, 46);
            addemployee_btn.TabIndex = 3;
            addemployee_btn.Text = "ADD EMPLOYEE";
            addemployee_btn.UseVisualStyleBackColor = false;
            addemployee_btn.Click += addemployee_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(33, 8, 97);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = SystemColors.ButtonHighlight;
            dashboard_btn.Location = new Point(12, 199);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(189, 46);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // greet_user
            // 
            greet_user.AutoSize = true;
            greet_user.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greet_user.ForeColor = SystemColors.ButtonHighlight;
            greet_user.Location = new Point(36, 149);
            greet_user.Name = "greet_user";
            greet_user.Size = new Size(138, 24);
            greet_user.TabIndex = 1;
            greet_user.Text = "Welcome User";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 554);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // department1
            // 
            department1.Location = new Point(221, 43);
            department1.Name = "department1";
            department1.Size = new Size(879, 554);
            department1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(221, 43);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(879, 554);
            addEmployee1.TabIndex = 3;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(221, 43);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(876, 557);
            dashboard1.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1100, 600);
            Controls.Add(dashboard1);
            Controls.Add(addEmployee1);
            Controls.Add(department1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Panel panel2;
        private Label greet_user;
        private PictureBox pictureBox1;
        private Button dashboard_btn;
        private Button addemployee_btn;
        private Button logout_btn;
        private Label label1;
        private Button department_btn;
        private Department department1;
        private AddEmployee addEmployee1;
        private Dashboard dashboard1;
    }
}