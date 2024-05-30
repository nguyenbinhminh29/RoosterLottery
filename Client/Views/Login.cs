using Client.Services;
using Client.Views;
using RL.Application.Extensions;
using RL.Application.Implements;
using RL.Application.Interfaces;
using RL.Data.Models;
using System.ComponentModel;
using System.Xml.Linq;

namespace Client
{
    public partial class Login : Form
    {
        private IUserClientService _userService;

        public Login()
        {
            InitializeComponent();

            this._userService = new UserClientService();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txtPhoneNo.Focus();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();

            base.OnClosing(e);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new();
            register.Show(this);
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPhoneNo.Text))
                {
                    MessageBox.Show("Please enter the phone number!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtPhoneNo.Focus();
                    return;
                }

                DisableCreen();

                GenericResult result = await this._userService.UserLoginByPhone(txtPhoneNo.Text);
                if (result != null)
                {
                    if (result.Success)
                    {
                        UserModel? user = result.Data.ToString().DeserializeObject<UserModel>();

                        this.Hide();
                        frmMain frmMain = new(user);
                        frmMain.Show();
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                EnableCreen();
            }
        }

        private void TxtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnLogin_Click(sender, e);
        }

        private void DisableCreen()
        {
            txtPhoneNo.Enabled = false;
            btnLogin.Enabled = false;
            btnRegister.Enabled = false;
        }

        private void EnableCreen()
        {
            txtPhoneNo.Enabled = true;
            btnLogin.Enabled = true;
            btnRegister.Enabled = true;
        }
    }
}
