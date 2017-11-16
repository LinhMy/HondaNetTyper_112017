using Honda_Net_Typer.MyClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Honda_Net_Typer.MyForm
{
    public partial class FrmExportExcel : DevExpress.XtraEditors.XtraForm
    {
        public FrmExportExcel()
        {
            InitializeComponent();
        }

        public DateTime date1, date2;
       // private int soloisausua = 0;
       // private int soloi = 0;

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_Batch.Text))
            {
                MessageBox.Show(@"Batch not selected.");
                return;
            }

            var result = Global.Db.InputFinish(cbb_Batch.Text);
            
            if (result == 1)
            {
                MessageBox.Show(@"This batch has not been imported yet. Please enter it first.");
                return;
            }
            var userMissimage = (from w in Global.Db.tbl_MissCheck_DeSos where w.fBatchName == cbb_Batch.Text && w.Submit == 0 select w.UserName).ToList();
            //(from w in Global.Db.UserMissImagecheck(cbb_Batch.Text) select w.UserName).ToList();
            string sss = "";
            foreach (var item in userMissimage)
            {
                sss += item + "\r\n";
            }

            if (userMissimage.Count > 0)
            {
                MessageBox.Show(@"The user took the picture but did not enter: \r\n" + sss);
                return;
            }

            //Kiểm tra check xong chưa
            var xyz = Global.Db.CheckerFinish(cbb_Batch.Text);
            if (xyz != 0)
            {
                MessageBox.Show(@"Not finished check or have user get but not check. Please check first");

                var u = (from w in Global.Db.tbl_MissCheck_DeSos where w.fBatchName == cbb_Batch.Text && w.Submit == 0 select w.UserName).ToList();
                string sssss = "";
                foreach (var item in u)
                {
                    sssss += item + "\r\n";
                }

                if (u.Count > 0)
                {
                    MessageBox.Show(@"Checker checklist to check but not check: \r\n" + sssss);
                }

                return;
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx");
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel.xlsx"), Properties.Resources.ExportExcel);
            }
            else
            {
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel.xlsx"), Properties.Resources.ExportExcel);
            }

            date1 = DateTime.Now;
            dataGridView1.DataSource = null;
           dataGridView1.DataSource = Global.Db.ExportExcel_New(cbb_Batch.Text);
            TableToExcel_SuaTiLeLoi(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx", dataGridView1);
            date2 = DateTime.Now;
            MessageBox.Show(@"Thời gian xuất : " + date1 + @"   -   " + date2);

        }

        private void frm_ExportExcel_Load(object sender, EventArgs e)
        {
            cbb_Batch.Items.Clear();
            var result = from w in Global.Db.tbl_Batches orderby w.fDateCreate select w.fBatchName;
            if (result.Count() > 0)
            {
                cbb_Batch.Items.AddRange(result.ToArray());
                cbb_Batch.DisplayMember = "fBatchName";
                cbb_Batch.ValueMember = "fBatchName";
                cbb_Batch.Text = Global.StrBatch;
            }
        }
        private string[] strTrans = null;
        public bool TableToExcel_SuaTiLeLoi(string strfilename, DataGridView dataGrid)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Worksheet wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 2;
                progressBarControl1.EditValue = 0;
                progressBarControl1.Properties.Step = 1;
                progressBarControl1.Properties.PercentView = true;
                progressBarControl1.Properties.Maximum = dataGrid.Rows.Count / 2;
                progressBarControl1.Properties.Minimum = 0;
                string temp = "";
                    for (int j = 0; j < dataGrid.RowCount; j += 1)
                    {
                    strTrans = null;
                    temp = dataGrid[0, j].Value + "";
                    strTrans = temp.Split('.');
                    wrksheet.Cells[h, 1] = strTrans[0];// cot 1
                    wrksheet.Cells[h, 2] = dataGrid[1, j].Value + "";     //cot 2
                    h++;
                    lb_SoDong.Text = (j+1) + @"/" + dataGrid.Rows.Count;
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }

                Microsoft.Office.Interop.Excel.Range rowHead = wrksheet.get_Range("A1", "B" + (h - 1));
                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog1.FileName = cbb_Batch.Text.Replace(@"\", "_") + "_Honda_Net_Type";
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
                Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    
       
       private void btnExportError_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(cbb_Batch.Text))
            //{
            //    MessageBox.Show(@"Batch not selected.");
            //    return;
            //}

            //var result = MyClass.Global.Db.InputFinish(cbb_Batch.Text);
            //if (result == 1)
            //{
            //    MessageBox.Show(@"This batch has not been imported yet. Please enter it first.");
            //    return;
            //}
            //var userMissimage = (from w in MyClass.Global.Db.UserMissImagecheck(cbb_Batch.Text) select w.UserName).ToList();
            //string sss = "";
            //foreach (var item in userMissimage)
            //{
            //    sss += item + "\r\n";
            //}

            //if (userMissimage.Count > 0)
            //{
            //    MessageBox.Show(@"The user took the picture but did not enter: \r\n" + sss);
            //    return;
            //}

            ////Kiểm tra check xong chưa
            //var xyz = MyClass.Global.Db.CheckerFinish(cbb_Batch.Text);
            //if (xyz != 0)
            //{
            //    MessageBox.Show(@"Not finished check or have user get but not check. Please check first");

            //    var u = (from w in MyClass.Global.Db.UserMissImagecheck(cbb_Batch.Text)
            //             select w.UserName).ToList();
            //    string sssss = "";
            //    foreach (var item in u)
            //    {
            //        sssss += item + "\r\n";
            //    }

            //    if (u.Count > 0)
            //    {
            //        MessageBox.Show(@"Checker checklist to check but not check: \r\n" + sssss);
            //    }

            //    return;
            }
        
    }

}