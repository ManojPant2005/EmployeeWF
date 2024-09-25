namespace EmployeeWF
{
    partial class Department
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
            addEmployee1 = new AddEmployee();
            SuspendLayout();
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(149, 145);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(1094, 692);
            addEmployee1.TabIndex = 0;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addEmployee1);
            Name = "Department";
            Size = new Size(1080, 732);
            ResumeLayout(false);
        }

        #endregion

        private AddEmployee addEmployee1;
    }
}
