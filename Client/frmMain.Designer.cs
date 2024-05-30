namespace Client
{
    partial class frmMain
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
            lblWelcome = new Label();
            dtpLotteryTrans = new DateTimePicker();
            btnViewLotteryTrans = new Button();
            grpLotteryTrans = new GroupBox();
            grvLotteryTrans = new DataGridView();
            grbUserTicket = new GroupBox();
            grvUserTicket = new DataGridView();
            dtpUserTicket = new DateTimePicker();
            btnViewUserTicket = new Button();
            splitContainerMain = new SplitContainer();
            cbbNextLottery = new ComboBox();
            lblNextLottery = new Label();
            btnGetNextLottery = new Button();
            lblNewNumber = new Label();
            btnSubmitNumber = new Button();
            txtNewNumber = new TextBox();
            lblLogout = new LinkLabel();
            grpLotteryTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvLotteryTrans).BeginInit();
            grbUserTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvUserTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Dock = DockStyle.Right;
            lblWelcome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.HotTrack;
            lblWelcome.Location = new Point(880, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(16, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "...";
            // 
            // dtpLotteryTrans
            // 
            dtpLotteryTrans.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpLotteryTrans.Location = new Point(15, 20);
            dtpLotteryTrans.Name = "dtpLotteryTrans";
            dtpLotteryTrans.Size = new Size(354, 23);
            dtpLotteryTrans.TabIndex = 2;
            // 
            // btnViewLotteryTrans
            // 
            btnViewLotteryTrans.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewLotteryTrans.Location = new Point(375, 18);
            btnViewLotteryTrans.Name = "btnViewLotteryTrans";
            btnViewLotteryTrans.Size = new Size(75, 26);
            btnViewLotteryTrans.TabIndex = 3;
            btnViewLotteryTrans.Text = "View";
            btnViewLotteryTrans.UseVisualStyleBackColor = true;
            btnViewLotteryTrans.Click += BtnViewLotteryTrans_Click;
            // 
            // grpLotteryTrans
            // 
            grpLotteryTrans.Controls.Add(grvLotteryTrans);
            grpLotteryTrans.Controls.Add(dtpLotteryTrans);
            grpLotteryTrans.Controls.Add(btnViewLotteryTrans);
            grpLotteryTrans.Dock = DockStyle.Fill;
            grpLotteryTrans.Location = new Point(0, 0);
            grpLotteryTrans.Name = "grpLotteryTrans";
            grpLotteryTrans.Size = new Size(463, 381);
            grpLotteryTrans.TabIndex = 5;
            grpLotteryTrans.TabStop = false;
            grpLotteryTrans.Text = "Past Lottery List";
            // 
            // grvLotteryTrans
            // 
            grvLotteryTrans.AllowUserToAddRows = false;
            grvLotteryTrans.AllowUserToDeleteRows = false;
            grvLotteryTrans.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvLotteryTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvLotteryTrans.Location = new Point(15, 50);
            grvLotteryTrans.MultiSelect = false;
            grvLotteryTrans.Name = "grvLotteryTrans";
            grvLotteryTrans.ReadOnly = true;
            grvLotteryTrans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvLotteryTrans.Size = new Size(433, 318);
            grvLotteryTrans.TabIndex = 6;
            // 
            // grbUserTicket
            // 
            grbUserTicket.Controls.Add(grvUserTicket);
            grbUserTicket.Controls.Add(dtpUserTicket);
            grbUserTicket.Controls.Add(btnViewUserTicket);
            grbUserTicket.Dock = DockStyle.Fill;
            grbUserTicket.Location = new Point(0, 0);
            grbUserTicket.Name = "grbUserTicket";
            grbUserTicket.Size = new Size(430, 381);
            grbUserTicket.TabIndex = 5;
            grbUserTicket.TabStop = false;
            grbUserTicket.Text = "User Ticket";
            // 
            // grvUserTicket
            // 
            grvUserTicket.AllowUserToAddRows = false;
            grvUserTicket.AllowUserToDeleteRows = false;
            grvUserTicket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvUserTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvUserTicket.Location = new Point(15, 50);
            grvUserTicket.MultiSelect = false;
            grvUserTicket.Name = "grvUserTicket";
            grvUserTicket.ReadOnly = true;
            grvUserTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvUserTicket.Size = new Size(400, 318);
            grvUserTicket.TabIndex = 6;
            // 
            // dtpUserTicket
            // 
            dtpUserTicket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpUserTicket.Location = new Point(15, 20);
            dtpUserTicket.Name = "dtpUserTicket";
            dtpUserTicket.Size = new Size(321, 23);
            dtpUserTicket.TabIndex = 2;
            // 
            // btnViewUserTicket
            // 
            btnViewUserTicket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewUserTicket.Location = new Point(342, 18);
            btnViewUserTicket.Name = "btnViewUserTicket";
            btnViewUserTicket.Size = new Size(75, 26);
            btnViewUserTicket.TabIndex = 3;
            btnViewUserTicket.Text = "View";
            btnViewUserTicket.UseVisualStyleBackColor = true;
            btnViewUserTicket.Click += BtnViewUserTicket_Click;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainerMain.Location = new Point(-1, 43);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(grbUserTicket);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(grpLotteryTrans);
            splitContainerMain.Size = new Size(897, 381);
            splitContainerMain.SplitterDistance = 430;
            splitContainerMain.TabIndex = 6;
            // 
            // cbbNextLottery
            // 
            cbbNextLottery.FormattingEnabled = true;
            cbbNextLottery.Location = new Point(280, 15);
            cbbNextLottery.Name = "cbbNextLottery";
            cbbNextLottery.Size = new Size(146, 23);
            cbbNextLottery.TabIndex = 7;
            // 
            // lblNextLottery
            // 
            lblNextLottery.AutoSize = true;
            lblNextLottery.Location = new Point(202, 17);
            lblNextLottery.Name = "lblNextLottery";
            lblNextLottery.Size = new Size(72, 15);
            lblNextLottery.TabIndex = 8;
            lblNextLottery.Text = "Next Lottery";
            // 
            // btnGetNextLottery
            // 
            btnGetNextLottery.Location = new Point(432, 12);
            btnGetNextLottery.Name = "btnGetNextLottery";
            btnGetNextLottery.Size = new Size(75, 27);
            btnGetNextLottery.TabIndex = 9;
            btnGetNextLottery.Text = "Refresh";
            btnGetNextLottery.UseVisualStyleBackColor = true;
            btnGetNextLottery.Click += BtnGetNextLottery_Click;
            // 
            // lblNewNumber
            // 
            lblNewNumber.AutoSize = true;
            lblNewNumber.Location = new Point(12, 17);
            lblNewNumber.Name = "lblNewNumber";
            lblNewNumber.Size = new Size(78, 15);
            lblNewNumber.TabIndex = 8;
            lblNewNumber.Text = "New Number";
            // 
            // btnSubmitNumber
            // 
            btnSubmitNumber.Location = new Point(513, 12);
            btnSubmitNumber.Name = "btnSubmitNumber";
            btnSubmitNumber.Size = new Size(75, 27);
            btnSubmitNumber.TabIndex = 9;
            btnSubmitNumber.Text = "Submit";
            btnSubmitNumber.UseVisualStyleBackColor = true;
            btnSubmitNumber.Click += BtnSubmitNumber_Click;
            // 
            // txtNewNumber
            // 
            txtNewNumber.Location = new Point(96, 14);
            txtNewNumber.Name = "txtNewNumber";
            txtNewNumber.Size = new Size(100, 23);
            txtNewNumber.TabIndex = 13;
            // 
            // lblLogout
            // 
            lblLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLogout.AutoSize = true;
            lblLogout.Location = new Point(839, 24);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(45, 15);
            lblLogout.TabIndex = 14;
            lblLogout.TabStop = true;
            lblLogout.Text = "Logout";
            lblLogout.LinkClicked += LblLogout_LinkClicked;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 423);
            Controls.Add(lblLogout);
            Controls.Add(txtNewNumber);
            Controls.Add(btnSubmitNumber);
            Controls.Add(btnGetNextLottery);
            Controls.Add(lblNewNumber);
            Controls.Add(lblNextLottery);
            Controls.Add(cbbNextLottery);
            Controls.Add(splitContainerMain);
            Controls.Add(lblWelcome);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooster Lottery";
            grpLotteryTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvLotteryTrans).EndInit();
            grbUserTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvUserTicket).EndInit();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private ListView lstViewLotteryTrans;
        private DateTimePicker dtpLotteryTrans;
        private Button btnViewLotteryTrans;
        private GroupBox grpLotteryTrans;
        private DataGridView grvLotteryTrans;
        private GroupBox grbUserTicket;
        private DataGridView grvUserTicket;
        private DateTimePicker dtpUserTicket;
        private Button btnViewUserTicket;
        private SplitContainer splitContainerMain;
        private ComboBox cbbNextLottery;
        private Label lblNextLottery;
        private Button btnGetNextLottery;
        private Label lblNewNumber;
        private Button btnSubmitNumber;
        private TextBox txtNewNumber;
        private LinkLabel lblLogout;
    }
}