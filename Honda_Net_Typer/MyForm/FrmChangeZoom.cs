using DevExpress.XtraEditors;
using Honda_Net_Typer.Properties;
using System;
using System.Windows.Forms;

namespace Honda_Net_Typer.MyForm{
    public partial class FrmChangeZoom : XtraForm
    {
        public FrmChangeZoom()
        {
            InitializeComponent();
        }

        private void frm_ChangeZoom_Load(object sender, EventArgs e)
        {
            trackBarControl1.EditValue = Settings.Default.ZoomImage;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Settings.Default.ZoomImage = Convert.ToInt32(trackBarControl1.EditValue);
            Settings.Default.Save();
            Close();
        }
    }
}