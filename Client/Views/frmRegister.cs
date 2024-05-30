using RL.Application.Extensions;
using RL.Application.Implements;
using RL.Application.Interfaces;
using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Views
{
    public partial class frmRegister : Form
    {
        private IUserClientService _userService;

        public frmRegister()
        {
            InitializeComponent();

            this._userService = new UserClientService();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Owner?.Show();
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    MessageBox.Show("Please input your name!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPhoneNo.Text.Trim()))
                {
                    MessageBox.Show("Please input your phone!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtPhoneNo.Focus();
                    return;
                }

                //if (!CheckPhone(txtPhoneNo.Text.Trim()))
                //{
                //    MessageBox.Show("Incorrect telephone number!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //    txtPhoneNo.Focus();
                //    return;
                //}

                DisableCreen();

                GenericResult result = await _userService.CreateUser(txtName.Text.Trim(), dtpBirthDay.Value, txtPhoneNo.Text.Trim());
                if (result != null)
                {
                    if (result.Success)
                    {
                        MessageBox.Show(result.Message, "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UserModel? user = result.Data.ToString().DeserializeObject<UserModel>();

                        this.Hide();
                        frmMain frmMain = new(user);
                        frmMain.Show();
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Register fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Register error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Enabled = false;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnRegister_Click(sender, e);
        }

        private void DisableCreen()
        {
            txtName.Enabled = false;
            dtpBirthDay.Enabled = false;
            txtPhoneNo.Enabled = false;
            btnRegister.Enabled = false;
        }

        private void EnableCreen()
        {
            txtName.Enabled = true;
            dtpBirthDay.Enabled = true;
            txtPhoneNo.Enabled = true;
            btnRegister.Enabled = true;
        }

        //private bool CheckPhone(string no)
        //{
        //    var expr = new Regex(@"^(\+[0-9]{9})$");
        //    if (expr.IsMatch(no))
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
    }
}
