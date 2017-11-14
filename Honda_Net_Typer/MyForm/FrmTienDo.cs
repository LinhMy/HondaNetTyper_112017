using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Honda_Net_Typer.MyClass;
using System;
using System.Linq;
using Series = DevExpress.XtraCharts.Series;

namespace Honda_Net_Typer.MyForm
{public partial class FrmTienDo : XtraForm
    {
        public FrmTienDo()
        {
            InitializeComponent();
        }

        private void frm_TienDo_Load(object sender, EventArgs e)
        {
        var fBatchName = (from w in Global.Db.tbl_Batches orderby w.id select new { w.fBatchName }).ToList();
        cbb_Batch.Properties.DataSource = fBatchName;
        cbb_Batch.Properties.DisplayMember = "fBatchName";
        cbb_Batch.Properties.ValueMember = "fBatchName";
        cbb_Batch.Text = Global.StrBatch;

    }

        private void ThongKe()
        {
            try
            {
                chartControl1.DataSource = null;
                chartControl1.Series.Clear();
                if (ck_All.Checked)
                {
                    lb_TongSoHinh.Text = (from w in Global.Db.tbl_Images select w.IdImage).Count() + "";
                    chartControl1.DataSource = Global.Db.ThongKeTienDo_All();
                }
                else{lb_TongSoHinh.Text = (from w in Global.Db.tbl_Images where w.fBatchName == cbb_Batch.Text select w.IdImage).Count() + "";
                    chartControl1.DataSource = Global.Db.ThongKeTienDo(cbb_Batch.Text);
                }
                Series series1 = new Series("Series1", DevExpress.XtraCharts.ViewType.Pie);
                series1.ArgumentScaleType = ScaleType.Qualitative;
                series1.ArgumentDataMember = "name";
                series1.ValueScaleType = ScaleType.Numerical;
                series1.ValueDataMembers.AddRange("soluong");
                chartControl1.Series.Add(series1);
                ((PiePointOptions) series1.Label.PointOptions).PointView = PointView.ArgumentAndValues;
                chartControl1.PaletteName = "Palette 1";
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void cbb_Batch_EditValueChanged(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            var frm = new FrmChiTietTienDo() { lb_fBatchName = { Text = ck_All.Checked ? "All" : cbb_Batch.Text } };
            frm.ShowDialog();
        }

        private void ck_All_CheckedChanged(object sender, EventArgs e)
        {
            cbb_Batch.Enabled = !ck_All.Checked;
            ThongKe();
        }

        private void chartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            string argument = e.SeriesPoint.Argument;
            var pointValue = e.SeriesPoint.Values[0];

            // You can get the argument text using e.SeriesPoint.Argument
            // Set the label text of your point
            if (argument == "Hình chưa nhập")
            {
                e.LabelText = "Hình chưa nhập: " + pointValue + " hình";
            }
            else if (argument == "Hình đang nhập")
            {
                e.LabelText = "Hình đang nhập: " + pointValue + " hình";}
            else if (argument == "Hình chờ check")
            {
                e.LabelText = "Hình chờ check: " + pointValue + " hình";
            }
            else if (argument == "Hình đang check")
            {
                e.LabelText = "Hình đang check: " + pointValue + " hình";
            }
            else if (argument == "Hình hoàn thành")
            {
                e.LabelText = "Hình hoàn thành: " + pointValue + " hình";
            }
        }

        private void time_CheckHinhChuaNhap_Tick(object sender, EventArgs e)
        {
            if (cbb_Batch.Text == "No batch")
                return; }
    }
}