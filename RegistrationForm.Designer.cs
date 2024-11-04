namespace SkillsInternationalSchool
{
    partial class RegistrationForm
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
            groupBoxStudentRegistration = new GroupBox();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnRegister = new Button();
            groupBoxParentDetails = new GroupBox();
            txtContactNo = new TextBox();
            lblContactNo = new Label();
            txtNic = new TextBox();
            lblNic = new Label();
            txtParentName = new TextBox();
            lblParentName = new Label();
            groupBoxContactDetails = new GroupBox();
            txtHomePhone = new TextBox();
            lblHomePhone = new Label();
            txtMobilePhone = new TextBox();
            lblMobilePhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            groupBoxBasicDetails = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lblGender = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblDateOfBirth = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            cbRegNo = new ComboBox();
            lblRegNo = new Label();
            lblTitle = new Label();
            linkExit = new LinkLabel();
            linkLogout = new LinkLabel();
            groupBoxStudentRegistration.SuspendLayout();
            groupBoxParentDetails.SuspendLayout();
            groupBoxContactDetails.SuspendLayout();
            groupBoxBasicDetails.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxStudentRegistration
            // 
            groupBoxStudentRegistration.Controls.Add(btnDelete);
            groupBoxStudentRegistration.Controls.Add(btnClear);
            groupBoxStudentRegistration.Controls.Add(btnUpdate);
            groupBoxStudentRegistration.Controls.Add(btnRegister);
            groupBoxStudentRegistration.Controls.Add(groupBoxParentDetails);
            groupBoxStudentRegistration.Controls.Add(groupBoxContactDetails);
            groupBoxStudentRegistration.Controls.Add(groupBoxBasicDetails);
            groupBoxStudentRegistration.Controls.Add(lblTitle);
            groupBoxStudentRegistration.Location = new Point(40, 28);
            groupBoxStudentRegistration.Name = "groupBoxStudentRegistration";
            groupBoxStudentRegistration.Size = new Size(797, 896);
            groupBoxStudentRegistration.TabIndex = 0;
            groupBoxStudentRegistration.TabStop = false;
            groupBoxStudentRegistration.Text = "Student Registration";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(632, 835);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(507, 835);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(184, 835);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(48, 835);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // groupBoxParentDetails
            // 
            groupBoxParentDetails.Controls.Add(txtContactNo);
            groupBoxParentDetails.Controls.Add(lblContactNo);
            groupBoxParentDetails.Controls.Add(txtNic);
            groupBoxParentDetails.Controls.Add(lblNic);
            groupBoxParentDetails.Controls.Add(txtParentName);
            groupBoxParentDetails.Controls.Add(lblParentName);
            groupBoxParentDetails.Location = new Point(51, 615);
            groupBoxParentDetails.Name = "groupBoxParentDetails";
            groupBoxParentDetails.Size = new Size(705, 202);
            groupBoxParentDetails.TabIndex = 3;
            groupBoxParentDetails.TabStop = false;
            groupBoxParentDetails.Text = "Parent Details";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(130, 128);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(401, 27);
            txtContactNo.TabIndex = 5;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(27, 135);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(84, 20);
            lblContactNo.TabIndex = 4;
            lblContactNo.Text = "Contact No";
            // 
            // txtNic
            // 
            txtNic.Location = new Point(130, 75);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(401, 27);
            txtNic.TabIndex = 3;
            // 
            // lblNic
            // 
            lblNic.AutoSize = true;
            lblNic.Location = new Point(27, 82);
            lblNic.Name = "lblNic";
            lblNic.Size = new Size(33, 20);
            lblNic.TabIndex = 2;
            lblNic.Text = "NIC";
            // 
            // txtParentName
            // 
            txtParentName.Location = new Point(133, 27);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(400, 27);
            txtParentName.TabIndex = 1;
            // 
            // lblParentName
            // 
            lblParentName.AutoSize = true;
            lblParentName.Location = new Point(26, 34);
            lblParentName.Name = "lblParentName";
            lblParentName.Size = new Size(94, 20);
            lblParentName.TabIndex = 0;
            lblParentName.Text = "Parent Name";
            // 
            // groupBoxContactDetails
            // 
            groupBoxContactDetails.Controls.Add(txtHomePhone);
            groupBoxContactDetails.Controls.Add(lblHomePhone);
            groupBoxContactDetails.Controls.Add(txtMobilePhone);
            groupBoxContactDetails.Controls.Add(lblMobilePhone);
            groupBoxContactDetails.Controls.Add(txtEmail);
            groupBoxContactDetails.Controls.Add(lblEmail);
            groupBoxContactDetails.Controls.Add(txtAddress);
            groupBoxContactDetails.Controls.Add(lblAddress);
            groupBoxContactDetails.Location = new Point(50, 363);
            groupBoxContactDetails.Name = "groupBoxContactDetails";
            groupBoxContactDetails.Size = new Size(703, 231);
            groupBoxContactDetails.TabIndex = 2;
            groupBoxContactDetails.TabStop = false;
            groupBoxContactDetails.Text = "Contact Details";
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(131, 177);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(403, 27);
            txtHomePhone.TabIndex = 7;
            // 
            // lblHomePhone
            // 
            lblHomePhone.AutoSize = true;
            lblHomePhone.Location = new Point(23, 184);
            lblHomePhone.Name = "lblHomePhone";
            lblHomePhone.Size = new Size(95, 20);
            lblHomePhone.TabIndex = 6;
            lblHomePhone.Text = "Home Phone";
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(131, 121);
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(401, 27);
            txtMobilePhone.TabIndex = 5;
            // 
            // lblMobilePhone
            // 
            lblMobilePhone.AutoSize = true;
            lblMobilePhone.Location = new Point(15, 128);
            lblMobilePhone.Name = "lblMobilePhone";
            lblMobilePhone.Size = new Size(101, 20);
            lblMobilePhone.TabIndex = 4;
            lblMobilePhone.Text = "Mobile Phone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(403, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 83);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(131, 30);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(401, 28);
            txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(15, 38);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address";
            // 
            // groupBoxBasicDetails
            // 
            groupBoxBasicDetails.Controls.Add(rbFemale);
            groupBoxBasicDetails.Controls.Add(rbMale);
            groupBoxBasicDetails.Controls.Add(lblGender);
            groupBoxBasicDetails.Controls.Add(dtpDateOfBirth);
            groupBoxBasicDetails.Controls.Add(lblDateOfBirth);
            groupBoxBasicDetails.Controls.Add(txtLastName);
            groupBoxBasicDetails.Controls.Add(lblLastName);
            groupBoxBasicDetails.Controls.Add(txtFirstName);
            groupBoxBasicDetails.Controls.Add(lblFirstName);
            groupBoxBasicDetails.Controls.Add(cbRegNo);
            groupBoxBasicDetails.Controls.Add(lblRegNo);
            groupBoxBasicDetails.Location = new Point(48, 77);
            groupBoxBasicDetails.Name = "groupBoxBasicDetails";
            groupBoxBasicDetails.Size = new Size(699, 269);
            groupBoxBasicDetails.TabIndex = 1;
            groupBoxBasicDetails.TabStop = false;
            groupBoxBasicDetails.Text = "Basic Details";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(250, 216);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 10;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(133, 216);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 9;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(17, 220);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 8;
            lblGender.Text = "Gender";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(133, 164);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(403, 27);
            dtpDateOfBirth.TabIndex = 7;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(17, 171);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(94, 20);
            lblDateOfBirth.TabIndex = 6;
            lblDateOfBirth.Text = "Date of Birth";
            lblDateOfBirth.Click += lblDateOfBirth_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(133, 123);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(401, 27);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(17, 130);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(133, 81);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(403, 27);
            txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(17, 88);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // cbRegNo
            // 
            cbRegNo.FormattingEnabled = true;
            cbRegNo.Location = new Point(133, 39);
            cbRegNo.Name = "cbRegNo";
            cbRegNo.Size = new Size(158, 28);
            cbRegNo.TabIndex = 1;
            // 
            // lblRegNo
            // 
            lblRegNo.AutoSize = true;
            lblRegNo.Location = new Point(17, 47);
            lblRegNo.Name = "lblRegNo";
            lblRegNo.Size = new Size(59, 20);
            lblRegNo.TabIndex = 0;
            lblRegNo.Text = "Reg No";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F);
            lblTitle.Location = new Point(254, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Skills International";
            // 
            // linkExit
            // 
            linkExit.AutoSize = true;
            linkExit.Location = new Point(804, 944);
            linkExit.Name = "linkExit";
            linkExit.Size = new Size(33, 20);
            linkExit.TabIndex = 1;
            linkExit.TabStop = true;
            linkExit.Text = "Exit";
            linkExit.LinkClicked += linkExit_LinkClicked;
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.Location = new Point(12, 5);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(56, 20);
            linkLogout.TabIndex = 2;
            linkLogout.TabStop = true;
            linkLogout.Text = "Logout";
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 973);
            Controls.Add(linkLogout);
            Controls.Add(linkExit);
            Controls.Add(groupBoxStudentRegistration);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            groupBoxStudentRegistration.ResumeLayout(false);
            groupBoxStudentRegistration.PerformLayout();
            groupBoxParentDetails.ResumeLayout(false);
            groupBoxParentDetails.PerformLayout();
            groupBoxContactDetails.ResumeLayout(false);
            groupBoxContactDetails.PerformLayout();
            groupBoxBasicDetails.ResumeLayout(false);
            groupBoxBasicDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxStudentRegistration;
        private Label lblTitle;
        private GroupBox groupBoxBasicDetails;
        private Label lblFirstName;
        private ComboBox cbRegNo;
        private Label lblRegNo;
        private Label lblDateOfBirth;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private DateTimePicker dtpDateOfBirth;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lblGender;
        private GroupBox groupBoxContactDetails;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblHomePhone;
        private TextBox txtMobilePhone;
        private Label lblMobilePhone;
        private GroupBox groupBoxParentDetails;
        private TextBox txtParentName;
        private Label lblParentName;
        private TextBox txtHomePhone;
        private TextBox txtContactNo;
        private Label lblContactNo;
        private TextBox txtNic;
        private Label lblNic;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnRegister;
        private LinkLabel linkExit;
        private LinkLabel linkLogout;
    }
}