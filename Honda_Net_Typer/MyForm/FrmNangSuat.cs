using Honda_Net_Typer.MyClass;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Honda_Net_Typer.MyForm
{
    public partial class FrmNangSuat : DevExpress.XtraEditors.XtraForm
    {
        private DateTime _firstDateTime;
        private DateTime _lastDateTime;

        public FrmNangSuat()
        {
            InitializeComponent();
        }

        private void frm_NangSuat_Load(object sender, EventArgs e)
        {
            string firstdate = dtp_FirstDay.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string lastdate = dtp_EndDay.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            _firstDateTime = DateTime.Parse(firstdate);
            _lastDateTime = DateTime.Parse(lastdate);
            LoadDataGrid(_firstDateTime, _lastDateTime);
        }

        private void LoadDataGrid(DateTime tuNgay, DateTime denNgay)
        {
            gc_NangSuat.DataSource = dataGridView1.DataSource = Global.Db.NangSuatDeSo(tuNgay, denNgay);
        }

        private void dtp_FirstDay_ValueChanged(object sender, EventArgs e)
        {
            string firstdate = dtp_FirstDay.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string lastdate = dtp_EndDay.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            _firstDateTime = DateTime.Parse(firstdate);
            _lastDateTime = DateTime.Parse(lastdate);
            gc_NangSuat.DataSource = null;
            dataGridView1.DataSource = null;
            if (_firstDateTime >= _lastDateTime)
            {
                MessageBox.Show(@"Ngày bắt đầu phải nhỏ hơn ngày kết thúc!");
            }
            else
            {
                LoadDataGrid(_firstDateTime, _lastDateTime);
            }
        }

        private void dtp_EndDay_ValueChanged(object sender, EventArgs e)
        {
            string firstdate = dtp_FirstDay.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string lastdate = dtp_EndDay.Value.ToString("yyyy-MM-dd") + " 23:59:59";

            _firstDateTime = DateTime.Parse(firstdate);
            _lastDateTime = DateTime.Parse(lastdate);
            gc_NangSuat.DataSource = null;
            dataGridView1.DataSource = null;
            if (_firstDateTime > _lastDateTime)
            {
                MessageBox.Show(@"Ngày kết thúc phải lớn hơn ngày bắt đầu!");
            }
            else
            {
                LoadDataGrid(_firstDateTime, _lastDateTime);
            }
        }

        public bool TableToExcel(string strfilename)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Worksheet wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 1;
                for(int i=0;i<dataGridView1.RowCount;i++)
                {
                    wrksheet.Cells[h + 2, 1] = h;
                    wrksheet.Cells[h + 2, 2] = dataGridView1.Rows[i].Cells[0].Value + "";
                    wrksheet.Cells[h + 2, 3] = dataGridView1.Rows[i].Cells[1].Value + "";
                    wrksheet.Cells[h + 2, 4] = dataGridView1.Rows[i].Cells[2].Value + "";
                    wrksheet.Cells[h + 2, 5] = dataGridView1.Rows[i].Cells[3].Value + "";
                    wrksheet.Cells[h + 2, 6] = dataGridView1.Rows[i].Cells[4].Value + "";
                    wrksheet.Cells[h + 2, 7] = dataGridView1.Rows[i].Cells[5].Value + "";
                    wrksheet.Cells[h + 2, 8] = dataGridView1.Rows[i].Cells[6].Value + "";

                    h++;
                }

                string savePath;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = @"Save Excel Files";
                saveFileDialog1.Filter = @"Excel files (*.xls)|*.xls";
                saveFileDialog1.FileName = "NangSuat_Honda_Net_Typer_" + dtp_FirstDay.Value.Day + "-" + dtp_EndDay.Value.Day;

                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    app.Quit();
                }
                else
                {
                    MessageBox.Show(@"Error exporting excel!");
                    return false;
                }
                if (savePath != null) Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xlsx"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xlsx");
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Productivity.xlsx"), Properties.Resources.Productivity);
            }
            else
            {
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Productivity.xlsx"), Properties.Resources.Productivity);
            }
            TableToExcel(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xlsx");
        }

      
    }
}