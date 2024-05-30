namespace Client
{
    partial class Login
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
            btnLogin = new Button();
            txtPhoneNo = new TextBox();
            lblPhoneNo = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(229, 20);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(81, 24);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(142, 23);
            txtPhoneNo.TabIndex = 1;
            txtPhoneNo.Text = "0123456789";
            txtPhoneNo.KeyPress += TxtPhoneNo_KeyPress;
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.Location = new Point(12, 28);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(63, 15);
            lblPhoneNo.TabIndex = 2;
            lblPhoneNo.Text = "Phone No.";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(319, 20);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(84, 30);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 75);
            Controls.Add(lblPhoneNo);
            Controls.Add(txtPhoneNo);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooster Lottery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPhoneNo;
        private Label lblPhoneNo;
        private Button btnRegister;
    }
}
