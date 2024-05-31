namespace ClientMonitoring
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
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            chartControlNumber = new DevExpress.XtraCharts.ChartControl();
            chartControlUser = new DevExpress.XtraCharts.ChartControl();
            btnReload1 = new DevExpress.XtraEditors.SimpleButton();
            deFromDate1 = new DevExpress.XtraEditors.DateEdit();
            lblFromDate1 = new Label();
            deToDate1 = new DevExpress.XtraEditors.DateEdit();
            lblToDate1 = new Label();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            lblToDate2 = new Label();
            lblFromDate2 = new Label();
            deFromDate2 = new DevExpress.XtraEditors.DateEdit();
            deToDate2 = new DevExpress.XtraEditors.DateEdit();
            btnReload2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)chartControlNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pieSeriesView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControlUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineSeriesView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineSeriesView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deFromDate1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deFromDate1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deToDate1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deToDate1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deFromDate2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deFromDate2.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deToDate2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deToDate2.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // chartControlNumber
            // 
            chartControlNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartControlNumber.Legend.LegendID = -1;
            chartControlNumber.Location = new Point(12, 58);
            chartControlNumber.Name = "chartControlNumber";
            series4.Name = "SeriesLotteryNum";
            series4.SeriesID = 3;
            series4.View = pieSeriesView2;
            chartControlNumber.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series4
    };
            chartControlNumber.Size = new Size(610, 472);
            chartControlNumber.TabIndex = 0;
            // 
            // chartControlUser
            // 
            chartControlUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            chartControlUser.Diagram = xyDiagram2;
            chartControlUser.Legend.LegendID = -1;
            chartControlUser.Location = new Point(11, 58);
            chartControlUser.Name = "chartControlUser";
            series5.Name = "Series 1";
            series5.SeriesID = 0;
            series5.View = lineSeriesView3;
            series6.Name = "Series 2";
            series6.SeriesID = 1;
            series6.View = lineSeriesView4;
            chartControlUser.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series5,
    series6
    };
            chartControlUser.Size = new Size(608, 472);
            chartControlUser.TabIndex = 1;
            // 
            // btnReload1
            // 
            btnReload1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnReload1.ImageOptions.SvgImage");
            btnReload1.Location = new Point(221, 7);
            btnReload1.Name = "btnReload1";
            btnReload1.Size = new Size(128, 45);
            btnReload1.TabIndex = 2;
            btnReload1.Text = "Reload";
            btnReload1.Click += BtnReload1_Click;
            // 
            // deFromDate1
            // 
            deFromDate1.EditValue = null;
            deFromDate1.Location = new Point(72, 6);
            deFromDate1.Name = "deFromDate1";
            deFromDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deFromDate1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deFromDate1.Size = new Size(143, 20);
            deFromDate1.TabIndex = 3;
            // 
            // lblFromDate1
            // 
            lblFromDate1.AutoSize = true;
            lblFromDate1.Location = new Point(12, 9);
            lblFromDate1.Name = "lblFromDate1";
            lblFromDate1.Size = new Size(54, 13);
            lblFromDate1.TabIndex = 4;
            lblFromDate1.Text = "FromDate";
            // 
            // deToDate1
            // 
            deToDate1.EditValue = null;
            deToDate1.Location = new Point(72, 32);
            deToDate1.Name = "deToDate1";
            deToDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deToDate1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deToDate1.Size = new Size(143, 20);
            deToDate1.TabIndex = 3;
            // 
            // lblToDate1
            // 
            lblToDate1.AutoSize = true;
            lblToDate1.Location = new Point(12, 35);
            lblToDate1.Name = "lblToDate1";
            lblToDate1.Size = new Size(45, 13);
            lblToDate1.TabIndex = 4;
            lblToDate1.Text = "To Date";
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            splitContainerControl1.Location = new Point(0, 0);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(chartControlNumber);
            splitContainerControl1.Panel1.Controls.Add(lblToDate1);
            splitContainerControl1.Panel1.Controls.Add(lblFromDate1);
            splitContainerControl1.Panel1.Controls.Add(deToDate1);
            splitContainerControl1.Panel1.Controls.Add(btnReload1);
            splitContainerControl1.Panel1.Controls.Add(deFromDate1);
            splitContainerControl1.Panel1.MinSize = 100;
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(chartControlUser);
            splitContainerControl1.Panel2.Controls.Add(lblToDate2);
            splitContainerControl1.Panel2.Controls.Add(lblFromDate2);
            splitContainerControl1.Panel2.Controls.Add(deFromDate2);
            splitContainerControl1.Panel2.Controls.Add(deToDate2);
            splitContainerControl1.Panel2.Controls.Add(btnReload2);
            splitContainerControl1.Panel2.MinSize = 100;
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1273, 542);
            splitContainerControl1.SplitterPosition = 632;
            splitContainerControl1.TabIndex = 5;
            // 
            // lblToDate2
            // 
            lblToDate2.AutoSize = true;
            lblToDate2.Location = new Point(11, 35);
            lblToDate2.Name = "lblToDate2";
            lblToDate2.Size = new Size(45, 13);
            lblToDate2.TabIndex = 4;
            lblToDate2.Text = "To Date";
            // 
            // lblFromDate2
            // 
            lblFromDate2.AutoSize = true;
            lblFromDate2.Location = new Point(11, 9);
            lblFromDate2.Name = "lblFromDate2";
            lblFromDate2.Size = new Size(54, 13);
            lblFromDate2.TabIndex = 4;
            lblFromDate2.Text = "FromDate";
            // 
            // deFromDate2
            // 
            deFromDate2.EditValue = null;
            deFromDate2.Location = new Point(71, 6);
            deFromDate2.Name = "deFromDate2";
            deFromDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deFromDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deFromDate2.Size = new Size(143, 20);
            deFromDate2.TabIndex = 3;
            // 
            // deToDate2
            // 
            deToDate2.EditValue = null;
            deToDate2.Location = new Point(71, 32);
            deToDate2.Name = "deToDate2";
            deToDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deToDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deToDate2.Size = new Size(143, 20);
            deToDate2.TabIndex = 3;
            // 
            // btnReload2
            // 
            btnReload2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnReload2.ImageOptions.SvgImage");
            btnReload2.Location = new Point(220, 7);
            btnReload2.Name = "btnReload2";
            btnReload2.Size = new Size(128, 45);
            btnReload2.TabIndex = 2;
            btnReload2.Text = "Reload";
            btnReload2.Click += BtnReload2_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 542);
            Controls.Add(splitContainerControl1);
            MinimumSize = new Size(1024, 320);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lottery Monitoring";
            ((System.ComponentModel.ISupportInitialize)pieSeriesView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)series4).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControlNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineSeriesView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)series5).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineSeriesView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)series6).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControlUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)deFromDate1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deFromDate1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deToDate1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deToDate1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)deFromDate2.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deFromDate2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deToDate2.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deToDate2.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControlNumber;
        private DevExpress.XtraCharts.ChartControl chartControlUser;
        private DevExpress.XtraEditors.SimpleButton btnReload1;
        private DevExpress.XtraEditors.DateEdit deFromDate1;
        private Label lblFromDate1;
        private DevExpress.XtraEditors.DateEdit deToDate1;
        private Label lblToDate1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Label lblToDate2;
        private Label lblFromDate2;
        private DevExpress.XtraEditors.DateEdit deFromDate2;
        private DevExpress.XtraEditors.DateEdit deToDate2;
        private DevExpress.XtraEditors.SimpleButton btnReload2;
    }
}