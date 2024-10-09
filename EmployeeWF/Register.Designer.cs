namespace EmployeeWF
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            signup_showPass = new CheckBox();
            signup_btn = new Button();
            signup_password = new TextBox();
            signup_username = new TextBox();
            exit = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            signup_login = new Button();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showPass.Location = new Point(659, 419);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(155, 26);
            signup_showPass.TabIndex = 17;
            signup_showPass.Text = "Show Password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPas_CheckedChanged;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(33, 8, 97);
            signup_btn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(519, 487);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(148, 65);
            signup_btn.TabIndex = 16;
            signup_btn.Text = "SIGN UP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_password
            // 
            signup_password.BorderStyle = BorderStyle.FixedSingle;
            signup_password.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_password.Location = new Point(519, 341);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(300, 41);
            signup_password.TabIndex = 15;
            // 
            // signup_username
            // 
            signup_username.BorderStyle = BorderStyle.FixedSingle;
            signup_username.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_username.Location = new Point(519, 236);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(300, 41);
            signup_username.TabIndex = 14;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(925, 9);
            exit.Name = "exit";
            exit.Size = new Size(22, 24);
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signup_login);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 641);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 123);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 248);
            label1.Name = "label1";
            label1.Size = new Size(328, 28);
            label1.TabIndex = 4;
            label1.Text = "Employee Management System";
            // 
            // signup_login
            // 
            signup_login.BackColor = Color.FromArgb(33, 8, 97);
            signup_login.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_login.ForeColor = Color.White;
            signup_login.Location = new Point(38, 568);
            signup_login.Name = "signup_login";
            signup_login.Size = new Size(256, 60);
            signup_login.TabIndex = 1;
            signup_login.Text = "SIGN IN";
            signup_login.UseVisualStyleBackColor = false;
            signup_login.Click += signup_login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 517);
            label5.Name = "label5";
            label5.Size = new Size(236, 25);
            label5.TabIndex = 0;
            label5.Text = "Already have an account ?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(422, 82);
            label6.Name = "label6";
            label6.Size = new Size(246, 36);
            label6.TabIndex = 18;
            label6.Text = "Register Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(519, 192);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 19;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(519, 299);
            label4.Name = "label4";
            label4.Size = new Size(101, 24);
            label4.TabIndex = 20;
            label4.Text = "Password:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(957, 641);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(signup_showPass);
            Controls.Add(signup_btn);
            Controls.Add(signup_password);
            Controls.Add(signup_username);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox signup_showPass;
        private Button signup_btn;
        private TextBox signup_password;
        private TextBox signup_username;
        private Label exit;
        private Panel panel1;
        private Button signup_login;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label3;
        private Label label4;
    }
}