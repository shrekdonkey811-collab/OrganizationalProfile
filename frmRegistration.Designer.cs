namespace OrganizationalProfile
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            cbPrograms = new ComboBox();
            cbGender = new ComboBox();
            txtContactNo = new TextBox();
            datePickerBirthday = new DateTimePicker();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label = new Label();
            mi = new Label();
            txt = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(122, 77);
            txtStudentNo.Margin = new Padding(4, 5, 4, 5);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(194, 31);
            txtStudentNo.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(122, 118);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(194, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(122, 176);
            txtAge.Margin = new Padding(4, 5, 4, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(141, 31);
            txtAge.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(444, 120);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(203, 31);
            txtFirstName.TabIndex = 3;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(702, 118);
            txtMiddleInitial.Margin = new Padding(4, 5, 4, 5);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(115, 31);
            txtMiddleInitial.TabIndex = 4;
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(443, 75);
            cbPrograms.Margin = new Padding(4, 5, 4, 5);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(374, 33);
            cbPrograms.TabIndex = 5;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(443, 176);
            cbGender.Margin = new Padding(4, 5, 4, 5);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(141, 33);
            cbGender.TabIndex = 6;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(550, 237);
            txtContactNo.Margin = new Padding(4, 5, 4, 5);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(185, 31);
            txtContactNo.TabIndex = 7;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(122, 235);
            datePickerBirthday.Margin = new Padding(4, 5, 4, 5);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(284, 31);
            datePickerBirthday.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(343, 300);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(139, 48);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 10;
            label1.Text = "Student No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 11;
            label2.Text = "Program";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 12;
            label3.Text = "Last Name";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(343, 124);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(97, 25);
            label.TabIndex = 13;
            label.Text = "First Name";
            // 
            // mi
            // 
            mi.AutoSize = true;
            mi.Location = new Point(655, 126);
            mi.Margin = new Padding(4, 0, 4, 0);
            mi.Name = "mi";
            mi.Size = new Size(41, 25);
            mi.TabIndex = 14;
            mi.Text = "M.I.";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(70, 184);
            txt.Margin = new Padding(4, 0, 4, 0);
            txt.Name = "txt";
            txt.Size = new Size(44, 25);
            txt.TabIndex = 15;
            txt.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 184);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 16;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 237);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 17;
            label8.Text = "Birthday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(443, 243);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 18;
            label9.Text = "Contact No.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(5, 6);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(236, 54);
            label10.TabIndex = 19;
            label10.Text = "Registration";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 373);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt);
            Controls.Add(mi);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(txtContactNo);
            Controls.Add(cbGender);
            Controls.Add(cbPrograms);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistration";
            Text = "Form1";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private ComboBox cbPrograms;
        private ComboBox cbGender;
        private TextBox txtContactNo;
        private DateTimePicker datePickerBirthday;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label;
        private Label mi;
        private Label txt;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
