namespace SkillsInternationalSchool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            groupBoxLogin = new GroupBox();
            btnExit = new Button();
            btnLogin = new Button();
            btnClear = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 230);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.AccessibleName = "groupBoxLogin";
            groupBoxLogin.Controls.Add(btnExit);
            groupBoxLogin.Controls.Add(btnLogin);
            groupBoxLogin.Controls.Add(btnClear);
            groupBoxLogin.Controls.Add(txtPassword);
            groupBoxLogin.Controls.Add(txtUsername);
            groupBoxLogin.Controls.Add(lblPassword);
            groupBoxLogin.Controls.Add(lblUsername);
            groupBoxLogin.Controls.Add(lblTitle);
            groupBoxLogin.Location = new Point(70, 270);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(844, 336);
            groupBoxLogin.TabIndex = 1;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Login";
            groupBoxLogin.Enter += groupBox1_Enter;
            // 
            // btnExit
            // 
            btnExit.AccessibleName = "btnExit";
            btnExit.Location = new Point(36, 289);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(471, 232);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(174, 232);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 31);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(282, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(264, 98);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(283, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(148, 157);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(148, 97);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F);
            lblTitle.Location = new Point(302, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Skills International";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 630);
            Controls.Add(groupBoxLogin);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBoxLogin;
        private Label lblTitle;
        private Label lblUsername;
        private Button btnClear;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Button btnExit;
        private Button btnLogin;
    }
}
