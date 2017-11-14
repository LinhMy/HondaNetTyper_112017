using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Honda_Net_Typer.MyClass;

namespace Honda_Net_Typer.MyForm
{
    public partial class FrmManagerBatch : DevExpress.XtraEditors.XtraForm
    {
        public FrmManagerBatch()
        {
            InitializeComponent();
        }

        private void frmManagerBatch_Load(object sender, EventArgs e)
        {
            RefreshBatch();
        }

        private void btn_TaoBatch_Click(object sender, EventArgs e)
        {
            new FrmCreateBatch().ShowDialog();
            RefreshBatch();
        }

        private void RefreshBatch()
        {
            var temp = from var in Global.Db.tbl_Batches orderby var.fDateCreate select var;
            gridControl1.DataSource = temp;
        }

        private void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fbatchname = gridView1.GetFocusedRowCellValue("fBatchName").ToString();
            string temp = Global.StrPath + "\\" + fbatchname;
            if (MessageBox.Show(@"You definitely want to delete the batch: " + fbatchname + @"?", @"Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Global.Db.XoaBatch(fbatchname);
                    Directory.Delete(temp, true);
                    RefreshBatch();
                    MessageBox.Show(@"Deleted batch successfully!");
                }
                catch (Exception)
                {
                    RefreshBatch();
                    MessageBox.Show(@"Delete batch error!");
                }
            }
            
        }

        private void btn_DeleteSelectedBatch_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = "";
            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                i += 1;
                string fbatchname = gridView1.GetRowCellValue(rowHandle, "fBatchName").ToString();
                s += fbatchname + "\n";
            }
            if (i <= 0)
            {
                MessageBox.Show("You have not selected batch. Please select batch before delete!");
                return;
            }
            if (MessageBox.Show("You want delete " + i + " batch:\n" + s, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                string fbatchname = gridView1.GetRowCellValue(rowHandle, "fBatchName").ToString();
                string temp = Global.StrPath + "\\" + fbatchname;
                Global.Db.XoaBatch(fbatchname);
                Directory.Delete(temp, true);
            }
            RefreshBatch();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //string batchname = gridView1.GetFocusedRowCellValue("fBatchName") + "";
            //if (e.Column.FieldName == "CongKhaiBatch")
            //{
            //    bool check = (bool)e.Value;
            //    if (check)
            //    {
            //        var batch = (from w in Global.Db.tbl_Batches where w.fBatchName == batchname select w).Single();
            //        batch.CongKhaiBatch = true;
            //        Global.Db.SubmitChanges();
                    
            //    }
            //    else
            //    {
            //        var batch = (from w in Global.Db.tbl_Batches where w.fBatchName == batchname select w).Single();
            //        batch.CongKhaiBatch = false;
            //        Global.Db.SubmitChanges();
            //        }
            //}

            //RefreshBatch();
            //int rowHandle = gridView1.LocateByValue("fBatchName", batchname);
            //if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            //    gridView1.FocusedRowHandle = rowHandle;
        }
    }
}