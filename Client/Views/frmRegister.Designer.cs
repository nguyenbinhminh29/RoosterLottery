namespace Client.Views
{
    partial class frmRegister
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
            txtName = new TextBox();
            lblName = new Label();
            lblBirthday = new Label();
            lblPhoneNo = new Label();
            txtPhoneNo = new TextBox();
            dtpBirthDay = new DateTimePicker();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(81, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(12, 52);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(51, 15);
            lblBirthday.TabIndex = 1;
            lblBirthday.Text = "Birthday";
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.Location = new Point(12, 78);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(63, 15);
            lblPhoneNo.TabIndex = 1;
            lblPhoneNo.Text = "Phone No.";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(81, 75);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(213, 23);
            txtPhoneNo.TabIndex = 2;
            txtPhoneNo.KeyPress += TextBox1_KeyPress;
            // 
            // dtpBirthDay
            // 
            dtpBirthDay.CustomFormat = "dd/MM/yyyy";
            dtpBirthDay.Location = new Point(81, 46);
            dtpBirthDay.Name = "dtpBirthDay";
            dtpBirthDay.Size = new Size(213, 23);
            dtpBirthDay.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(101, 116);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 30);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 160);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthDay);
            Controls.Add(lblPhoneNo);
            Controls.Add(lblBirthday);
            Controls.Add(lblName);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblBirthday;
        private Label lblPhoneNo;
        private TextBox txtPhoneNo;
        private DateTimePicker dtpBirthDay;
        private Button btnRegister;
    }
}