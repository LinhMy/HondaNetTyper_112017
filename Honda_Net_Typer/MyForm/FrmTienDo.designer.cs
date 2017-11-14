namespace Honda_Net_Typer.MyForm
{
    partial class FrmTienDo
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTienDo));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongSoHinh = new DevExpress.XtraEditors.LabelControl();
            this.ck_All = new DevExpress.XtraEditors.CheckEdit();
            this.btn_ChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_Batch = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.time_CheckHinhChuaNhap = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_All.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_Batch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lb_TongSoHinh);
            this.panelControl1.Controls.Add(this.ck_All);
            this.panelControl1.Controls.Add(this.btn_ChiTiet);
            this.panelControl1.Controls.Add(this.cbb_Batch);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1082, 82);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(920, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tổng số hình:";
            // 
            // lb_TongSoHinh
            // 
            this.lb_TongSoHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TongSoHinh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lb_TongSoHinh.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_TongSoHinh.Appearance.Options.UseFont = true;
            this.lb_TongSoHinh.Appearance.Options.UseForeColor = true;
            this.lb_TongSoHinh.Location = new System.Drawing.Point(1000, 55);
            this.lb_TongSoHinh.Name = "lb_TongSoHinh";
            this.lb_TongSoHinh.Size = new System.Drawing.Size(40, 19);
            this.lb_TongSoHinh.TabIndex = 6;
            this.lb_TongSoHinh.Text = "1000";
            // 
            // ck_All
            // 
            this.ck_All.Location = new System.Drawing.Point(525, 28);
            this.ck_All.Name = "ck_All";
            this.ck_All.Properties.Caption = "All";
            this.ck_All.Size = new System.Drawing.Size(31, 19);
            this.ck_All.TabIndex = 4;
            this.ck_All.CheckedChanged += new System.EventHandler(this.ck_All_CheckedChanged);
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Location = new System.Drawing.Point(571, 26);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btn_ChiTiet.TabIndex = 2;
            this.btn_ChiTiet.Text = "Detail";
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // cbb_Batch
            // 
            this.cbb_Batch.Location = new System.Drawing.Point(46, 27);
            this.cbb_Batch.Name = "cbb_Batch";
            this.cbb_Batch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_Batch.Properties.NullText = "No batch";
            this.cbb_Batch.Properties.UseReadOnlyAppearance = false;
            this.cbb_Batch.Size = new System.Drawing.Size(473, 20);
            this.cbb_Batch.TabIndex = 1;
            this.cbb_Batch.EditValueChanged += new System.EventHandler(this.cbb_Batch_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Batch:";
            // 
            // chartControl1
            // 
            this.chartControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartControl1.DataBindings = null;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 82);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Palette 1";
            this.chartControl1.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Silver, System.Drawing.Color.Silver),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(64))))), System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Green, System.Drawing.Color.Green)}));
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(1082, 596);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chartControl1_CustomDrawSeriesPoint);
            // 
            // time_CheckHinhChuaNhap
            // 
            this.time_CheckHinhChuaNhap.Enabled = true;
            this.time_CheckHinhChuaNhap.Interval = 2000;
            this.time_CheckHinhChuaNhap.Tick += new System.EventHandler(this.time_CheckHinhChuaNhap_Tick);
            // 
            // FrmTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 678);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTienDo";
            this.Text = "Progress";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TienDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_All.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_Batch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_ChiTiet;
        private DevExpress.XtraEditors.LookUpEdit cbb_Batch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.CheckEdit ck_All;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lb_TongSoHinh;
        private System.Windows.Forms.Timer time_CheckHinhChuaNhap;
    }
}