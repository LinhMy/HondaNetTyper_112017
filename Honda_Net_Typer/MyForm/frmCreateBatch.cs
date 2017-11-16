using DevExpress.XtraEditors;
using Honda_Net_Typer.MyClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Honda_Net_Typer.MyForm
{
    public partial class FrmCreateBatch : XtraForm
    {
        private string[] _lFileNames;
        private int _soluonghinh;
        //private bool _multi;

        public FrmCreateBatch()
        {
            InitializeComponent();
        }

        private void frmCreateBatch_Load(object sender, EventArgs e)
        {
            txt_UserCreate.Text = Global.StrUsername;
            txt_DateCreate.Text = DateTime.Now.ToShortDateString() + @"  -  " + DateTime.Now.ToShortTimeString();
        }

        private void btn_BrowserImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_BatchName.Text))
            {
                MessageBox.Show(@"Vui lòng nhập tên Batch!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = @"All Types Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _lFileNames = dlg.FileNames;
                txt_ImagePath.Text = Path.GetDirectoryName(dlg.FileName);
            }
            _soluonghinh = 0;
            _soluonghinh = dlg.FileNames.Length;
            lb_SoLuongHinh.Text = dlg.FileNames.Length + @" files ";
        }

        private void btn_CreateBatch_Click(object sender, EventArgs e)
        {
            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = _lFileNames.Length;
            progressBarControl1.Properties.Minimum = 0;

            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Đang thực hiện upbatch, vui lòng thử lại sau!");
                return;
            }
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void UpLoadSingle()
        {
            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = _lFileNames.Length;
            progressBarControl1.Properties.Minimum = 0;

            var batch = (from w in Global.Db.tbl_Batches.Where(w => w.fBatchName == txt_BatchName.Text)
                         select w.fBatchName).FirstOrDefault();
            if (!string.IsNullOrEmpty(txt_ImagePath.Text))
            {
                if (string.IsNullOrEmpty(batch))
                {
                    var fBatch = new tbl_Batch
                    {
                        fBatchName = txt_BatchName.Text,
                        fUserCreate = txt_UserCreate.Text,
                        fDateCreate = DateTime.Now,
                        fPathPicture = txt_ImagePath.Text,
                      //  fLocation = txt_Location.Text+"\\"+txt_BatchName.Text+"\\",
                        fSoLuongAnh = _soluonghinh.ToString(),
                        // LoaiBatch = "Honda_Net_Typer",CongKhaiBatch = false
                        //LoaiBatch = rg_LoaiBatch.Properties.Items[rg_LoaiBatch.SelectedIndex].Description
                    };
                    Global.Db.tbl_Batches.InsertOnSubmit(fBatch);
                    Global.Db.SubmitChanges();}
                else
                {
                    MessageBox.Show(@"Trùng batch. Vui lòng làm lại");
                    return;
                }
            }
            else
            {
                MessageBox.Show(@"Chưa chọn ảnh!");
                return;
            }
            string temp = Global.StrPath + "\\" + txt_BatchName.Text;
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            else
            {
                MessageBox.Show(@"Đã tồn tại thư mục " + temp + " trên server. Vui lòng liên hệ IT");
                return;
            }
            foreach (string i in _lFileNames)
            {
                FileInfo fi = new FileInfo(i);
                tbl_Image tempImage = new tbl_Image
                {
                    fBatchName = txt_BatchName.Text,
                    IdImage = Path.GetFileName(fi.ToString()),
                    ReadImageDeSo = 0,
                    CheckedDeSo = 0,
                    TienDoDeSo = "Hình chưa nhập"
                };
                Global.Db.tbl_Images.InsertOnSubmit(tempImage);
                Global.Db.SubmitChanges();
                
                string des = temp + @"\" + Path.GetFileName(fi.ToString());


                fi.CopyTo(des);
                progressBarControl1.PerformStep();progressBarControl1.Update();
            }
            MessageBox.Show(@"Tạo Batch thành công!");
            progressBarControl1.EditValue = 0;
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
        }
        
        public void createFolder(string nameFolder)
        {
            string temp = Global.StrPath + "\\" + nameFolder;
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
        }
        public static string[] GetFilesFrom(string searchFolder, string[] filters, bool isRecursive)
        {
            List<string> filesFound = new List<string>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, $"*.{filter}", searchOption));
            }
            return filesFound.ToArray();
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSelectedFolder))
            {
                folderBrowserDialog1.SelectedPath = Properties.Settings.Default.LastSelectedFolder;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_PathFolder.Text = folderBrowserDialog1.SelectedPath;
                if (!string.IsNullOrEmpty(txt_PathFolder.Text))
                {
                    Properties.Settings.Default.LastSelectedFolder = txt_PathFolder.Text;
                    Properties.Settings.Default.Save();
                }

            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            
            UpLoadSingle();
        }

        private void txt_PathFolder_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PathFolder.Text))
            {
                //_multi = true;
                txt_BatchName.Enabled = false;
                txt_ImagePath.Enabled = false;
                btn_BrowserImage.Enabled = false;
            }
            else
            {
                txt_BatchName.Enabled = true;
                txt_ImagePath.Enabled = true;
                btn_BrowserImage.Enabled = true;
            }
        }

        private void txt_BatchName_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_BatchName.Text))
            {
                //_multi = false;
                txt_PathFolder.Enabled = false;
                btn_Browser.Enabled = false;
            }
            else
            {
                txt_PathFolder.Enabled = true;
                btn_Browser.Enabled = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //backgroundWorker1.CancelAsync();
        }
        
    }
}