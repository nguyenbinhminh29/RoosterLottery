using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientMonitoring
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private ILotteryClientService _lotteryService;

        public frmMain()
        {
            InitializeComponent();

            this._lotteryService = new LotteryClientService();
        }

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            deFromDate1.EditValue = DateTime.Now;
            deToDate1.EditValue = DateTime.Now;

            deFromDate2.EditValue = DateTime.Now.AddDays(-30);
            deToDate2.EditValue = DateTime.Now;

            chartControlNumber.Titles.Clear();
            chartControlNumber.Titles.Add(new ChartTitle() { Text = "Lottery Number" });

            chartControlUser.Titles.Clear();
            chartControlNumber.Titles.Add(new ChartTitle() { Text = "Lottery User" });

            LoadMonitoringNumber(DateTime.Now, DateTime.Now);
            LoadMonitoringUserTicket(DateTime.Now.AddDays(-30), DateTime.Now);
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

        private void BtnReload1_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMonitoringNumber(deFromDate1.DateTime, deToDate1.DateTime);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lottery Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReload2_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMonitoringUserTicket(deFromDate2.DateTime, deToDate2.DateTime);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lottery Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Methods

        private async void LoadMonitoringNumber(DateTime fromDate, DateTime toDate)
        {
            GenericResult res = await _lotteryService.GetMonitorNumber(fromDate, toDate);
            if (res != null)
            {
                if (res.Success && res.Data != null)
                {
                    List<LotteryChartsModel> chartsNumber = res.Data.ToString().DeserializeObject<List<LotteryChartsModel>>();

                    chartControlNumber.Series.Clear();

                    Series series1 = new("Lottery Number", ViewType.Pie);
                    series1.DataSource = chartsNumber;
                    series1.ArgumentDataMember = "Argument";
                    series1.ValueDataMembers.AddRange(["Value"]);

                    chartControlNumber.Series.Add(series1);

                    series1.Label.TextPattern = "{VP:p0} (Number {V:.##})";
                    series1.LegendTextPattern = "Number {A}";

                    ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
                    ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

                    PieSeriesView myView = (PieSeriesView)series1.View;
                    myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
                        DataFilterCondition.GreaterThanOrEqual, 9));
                    myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                        DataFilterCondition.NotEqual, "Others"));
                    myView.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.UseFilters;
                    myView.ExplodedDistancePercentage = 30;
                    myView.RuntimeExploding = true;

                    //chartControlNumber.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
                }
            }
        }

        private async void LoadMonitoringUserTicket(DateTime fromDate, DateTime toDate)
        {
            GenericResult res = await _lotteryService.GetMonitorUserTicket(fromDate, toDate);
            if (res != null)
            {
                if (res.Success && res.Data != null)
                {
                    List<List<LotteryChartsModel>> chartsUsers = res.Data.ToString().DeserializeObject<List<List<LotteryChartsModel>>>();

                    chartControlUser.Series.Clear();

                    if (chartsUsers.Count > 0)
                    {
                        foreach (List<LotteryChartsModel> chartItem in chartsUsers)
                        {
                            if (chartItem == null || chartItem.Count <= 0)
                            {
                                continue;
                            }

                            Series series1 = new(chartItem.FirstOrDefault().Name, ViewType.Line);
                            foreach (LotteryChartsModel item in chartItem)
                            {
                                series1.Points.Add(new SeriesPoint(item.Argument, item.Value));
                            }

                            chartControlUser.Series.Add(series1);

                            series1.ArgumentScaleType = ScaleType.Auto;

                            //((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                            //((LineSeriesView)series1.View).LineMarkerOptions.Size = 20;
                            //((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                            //((LineSeriesView)series1.View).LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash;

                            
                        }
                    }

                    //((XYDiagram)chartControlUser.Diagram).AxisY.Interlaced = true;
                    //((XYDiagram)chartControlUser.Diagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60);
                    //((XYDiagram)chartControlUser.Diagram).AxisX.NumericScaleOptions.AutoGrid = false;
                    //((XYDiagram)chartControlUser.Diagram).AxisX.NumericScaleOptions.GridSpacing = 1;

                    //chartControlUser.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
                }
            }
        }

        #endregion


    }
}