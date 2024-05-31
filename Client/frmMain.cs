using RL.Application.Extensions;
using RL.Application.Implements;
using RL.Application.Interfaces;
using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmMain : Form
    {
        private UserModel UserLogin = null;

        private ILotteryClientService _lotteryService;
        private IUserClientService _userService;

        public frmMain()
        {
            InitializeComponent();

            this._lotteryService = new LotteryClientService();
            this._userService = new UserClientService();
        }

        public frmMain(UserModel user)
        {
            InitializeComponent();

            this.UserLogin = user;
            this._lotteryService = new LotteryClientService();
            this._userService = new UserClientService();
        }

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (UserLogin != null)
            {
                lblWelcome.Text = $"Welcome {UserLogin.Name} !";
            }

            try
            {
                LoadUserTicket(DateTime.Now);
                LoadLotteryTrans(DateTime.Now);
                LoadNextLottery();
            }
            catch (Exception ex) { }

            txtNewNumber.Focus();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }

            base.OnClosing(e);
        }

        private void BtnViewLotteryTrans_Click(object sender, EventArgs e)
        {
            try
            {
                LoadLotteryTrans(dtpLotteryTrans.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lottery Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnViewUserTicket_Click(object sender, EventArgs e)
        {
            try
            {
                LoadUserTicket(dtpUserTicket.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lottery Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGetNextLottery_Click(object sender, EventArgs e)
        {
            try
            {
                LoadNextLottery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lottery Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSubmitNumber_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to submit new number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(txtNewNumber.Text.Trim()) || !int.TryParse(txtNewNumber.Text.Trim(), out int newNumber))
                {
                    MessageBox.Show("New number must be an integer!", "Lottery Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewNumber.Focus();
                    return;
                }

                string period = string.Empty;
                if (cbbNextLottery.SelectedItem != null && cbbNextLottery.SelectedItem is LotteryModel lotterySelect)
                {
                    period = lotterySelect.OpeningPeriod;
                }

                GenericResult result = await _userService.SubmitUserTicket(UserLogin.PhoneNo, newNumber, period);
                if (result != null)
                {
                    if (result.Success)
                    {
                        LoadUserTicket(DateTime.Now);

                        txtNewNumber.Text = "";
                        txtNewNumber.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Submit ticket failed: " + result.Message, "Lottery Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lottery Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do you want logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                this.Hide();
                Login login = new();
                login.Show();
            }
        }

        #endregion

        #region Methods

        private async void LoadLotteryTrans(DateTime openDate)
        {
            grvLotteryTrans.DataSource = null;
            GenericResult res = await _lotteryService.GetLotteryTransactions(openDate);
            if (res != null)
            {
                if (res.Success && res.Data != null)
                {
                    List<LotteryModel> lotteryTrans = res.Data.ToString().DeserializeObject<List<LotteryModel>>();
                    grvLotteryTrans.DataSource = lotteryTrans;
                }
            }

        }

        private async void LoadUserTicket(DateTime purchaseDate)
        {
            grvUserTicket.DataSource = null;
            GenericResult res = await _userService.GetUserTicket(UserLogin.PhoneNo, purchaseDate);
            if (res != null)
            {
                if (res.Success && res.Data != null)
                {
                    List<UserTicketModel> lotteryTrans = res.Data.ToString().DeserializeObject<List<UserTicketModel>>();
                    grvUserTicket.DataSource = lotteryTrans;
                }
            }

        }

        private async void LoadNextLottery()
        {
            GenericResult res = await _lotteryService.GetNextLotteryPeriod();
            if (res != null)
            {
                if (res.Success && res.Data != null)
                {
                    List<LotteryModel> nextLotterys = res.Data.ToString().DeserializeObject<List<LotteryModel>>();
                    cbbNextLottery.DataSource = nextLotterys;
                    cbbNextLottery.DisplayMember = nameof(LotteryModel.OpeningPeriod);
                    cbbNextLottery.ValueMember = nameof(LotteryModel.OpeningPeriod);
                }
            }
        }

        #endregion

    }
}
