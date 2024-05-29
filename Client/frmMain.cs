using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmMain : Form
    {
        private UserModel UserLogin = null;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(UserModel user)
        {
            InitializeComponent();

            this.UserLogin = user;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (UserLogin != null)
            {
                lblWelcome.Text = UserLogin.Name;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }

            base.OnClosing(e);

            base.OnClosing(e);
        }
    }
}
