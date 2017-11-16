using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;
using Honda_Net_Typer.MyClass;
using Honda_Net_Typer.Properties;

namespace Honda_Net_Typer.MyForm
{
    public partial class FrmCheckDeSo : XtraForm
    {
        //private bool _flag = false;
        public FrmCheckDeSo()
        {
            InitializeComponent();
        }

        private void ResetData()
        {
            uc_DeSo1.ResetData();
            uc_DeSo2.ResetData();
            lb_username1.Text = "";
            lb_username2.Text = "";
            ucPictureBox1.imageBox1.Image = null;
        }

        private void Compare_TextBox(TextEdit t1, TextEdit t2)
        {
            if (t1.Text.Length > 10) t1.BackColor = Color.Purple;
            if (t2.Text.Length > 10) t2.BackColor = Color.Purple;
            if (!string.IsNullOrEmpty(t1.Text) || !string.IsNullOrEmpty(t2.Text))
            {
                if (t1.Text != t2.Text)
                {
                    t1.BackColor = Color.PaleVioletRed;
                    t2.BackColor = Color.PaleVioletRed;
                }
            }
            else
            {
                t1.BackColor = Color.White;
                t1.ForeColor = Color.Black;
                t2.BackColor = Color.White;
                t2.ForeColor = Color.Black;
            }
        }
    
        public void LoadBatchMoi()
        {
            if (MessageBox.Show(@"Bạn có muốn chuyển qua Batch tiếp theo không?", @"Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Close();
            }
            else
            {
                btn_Luu_DeSo1.Visible = false;
                btn_Luu_DeSo2.Visible = false;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
                ResetData();
                cbb_Batch_Check.DataSource = (from w in Global.Db.GetBatNotFinishCheckerDeSo(Global.StrUsername) select w.fbatchname).ToList();
                cbb_Batch_Check.DisplayMember = "fBatchName";
                Global.StrBatch = cbb_Batch_Check.Text;
                var soloi = (from w in Global.Db.GetSoLoi_CheckDe(cbb_Batch_Check.Text) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" hình lỗi";
                btn_Start_Click(null, null);
                }
            }

        private void frm_Check_Load(object sender, EventArgs e)
        {
            try
            {
                cbb_Batch_Check.DataSource = (from w in Global.Db.GetBatNotFinishCheckerDeSo(Global.StrUsername) select w.fbatchname).ToList();
                cbb_Batch_Check.DisplayMember = "fBatchName";
                cbb_Batch_Check.Text = Global.StrBatch;
                var soloi = (from w in Global.Db.GetSoLoi_CheckDe(cbb_Batch_Check.Text) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" hình lỗi";
                btn_Luu_DeSo1.Visible = false;
                btn_Luu_DeSo2.Visible = false;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
                uc_DeSo1.Changed += uc_DeSo1_Changed;
                uc_DeSo2.Changed += uc_DeSo2_Changed;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error" + i);
            }
        }

        private void uc_DeSo1_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
            btn_SuaVaLuu_User2.Visible = false;

        }

        private void uc_DeSo2_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
            btn_SuaVaLuu_User1.Visible = false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                var nhap = (from w in Global.Db.tbl_Images where w.fBatchName == Global.StrBatch && w.ReadImageDeSo >= 2 select w.IdImage).Count();
                var sohinh = (from w in Global.Db.tbl_Images where w.fBatchName == Global.StrBatch select w.IdImage).Count();
                var check = (from w in Global.Db.tbl_MissImage_DeSos where w.fBatchName == Global.StrBatch && w.Submit == 0 select w.IdImage).Count();
                if (sohinh > nhap)
                {
                    MessageBox.Show(@"Chưa nhập xong!");
                    return;
                }
                if (check > 0)
                {
                    var listUser = (from w in Global.Db.tbl_MissImage_DeSos where w.fBatchName == Global.StrBatch && w.Submit == 0 select w.UserName).ToList();
                    string sss = "";
                    foreach (var item in listUser)
                    {
                        sss += item + "\r\n";
                    }

                    if (listUser.Count > 0)
                    {
                        MessageBox.Show("Danh sách User lấy về mà chưa nhập: \r\n" + sss);
                        return;
                    }
                }
                string temp = GetImage_DeSo();
                if (temp == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Hoàn thành Batch: '" + cbb_Batch_Check.Text + "'");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show(@"Không thể load hình!");
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
                btn_Start.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void Load_DeSo(string strBatch, string idimage)
        {
            try
            {
                var deso = (from w in Global.Db.tbl_DeSos
                            where w.fBatchName == strBatch && w.IdImage == idimage //orderby w.IdPhieu descending
                            select new
                            {
                                w.UserName,
                                w.Truong_01,
                                w.IdPhieu
                            } 
                            ).ToList();
                lb_username1.Text = deso[0].UserName;
                lb_username2.Text = deso[12].UserName;
                //load user 1
                uc_DeSo1.txt_Phieu1.Text = deso[0].Truong_01;
                uc_DeSo1.txt_Phieu2.Text = deso[1].Truong_01;
                uc_DeSo1.txt_Phieu3.Text = deso[2].Truong_01;
                uc_DeSo1.txt_Phieu4.Text = deso[3].Truong_01;
                uc_DeSo1.txt_Phieu5.Text = deso[4].Truong_01;
                uc_DeSo1.txt_Phieu6.Text = deso[5].Truong_01;
                uc_DeSo1.txt_Phieu7.Text = deso[6].Truong_01;
                uc_DeSo1.txt_Phieu8.Text = deso[7].Truong_01;
                uc_DeSo1.txt_Phieu9.Text = deso[8].Truong_01;
                uc_DeSo1.txt_Phieu10.Text = deso[9].Truong_01;
                uc_DeSo1.txt_Phieu11.Text = deso[10].Truong_01;
                uc_DeSo1.txt_Phieu12.Text = deso[11].Truong_01;
                ////load user 2
                uc_DeSo2.txt_Phieu1.Text = deso[12].Truong_01;
                uc_DeSo2.txt_Phieu2.Text = deso[13].Truong_01;
                uc_DeSo2.txt_Phieu3.Text = deso[14].Truong_01;
                uc_DeSo2.txt_Phieu4.Text = deso[15].Truong_01;
                uc_DeSo2.txt_Phieu5.Text = deso[16].Truong_01;
                uc_DeSo2.txt_Phieu6.Text = deso[17].Truong_01;
                uc_DeSo2.txt_Phieu7.Text = deso[18].Truong_01;
                uc_DeSo2.txt_Phieu8.Text = deso[19].Truong_01;
                uc_DeSo2.txt_Phieu9.Text = deso[20].Truong_01;
                uc_DeSo2.txt_Phieu10.Text = deso[21].Truong_01;
                uc_DeSo2.txt_Phieu11.Text = deso[22].Truong_01;
                uc_DeSo2.txt_Phieu12.Text = deso[23].Truong_01;
                ////Compare
                Compare_TextBox(uc_DeSo1.txt_Phieu1, uc_DeSo2.txt_Phieu1);
                Compare_TextBox(uc_DeSo1.txt_Phieu2, uc_DeSo2.txt_Phieu2);
                Compare_TextBox(uc_DeSo1.txt_Phieu3, uc_DeSo2.txt_Phieu3);
                Compare_TextBox(uc_DeSo1.txt_Phieu4, uc_DeSo2.txt_Phieu4);
                Compare_TextBox(uc_DeSo1.txt_Phieu5, uc_DeSo2.txt_Phieu5);
                Compare_TextBox(uc_DeSo1.txt_Phieu6, uc_DeSo2.txt_Phieu6);
                Compare_TextBox(uc_DeSo1.txt_Phieu7, uc_DeSo2.txt_Phieu7);
                Compare_TextBox(uc_DeSo1.txt_Phieu8, uc_DeSo2.txt_Phieu8);
                Compare_TextBox(uc_DeSo1.txt_Phieu9, uc_DeSo2.txt_Phieu9);
                Compare_TextBox(uc_DeSo1.txt_Phieu10, uc_DeSo2.txt_Phieu10);
                Compare_TextBox(uc_DeSo1.txt_Phieu11, uc_DeSo2.txt_Phieu11);
                Compare_TextBox(uc_DeSo1.txt_Phieu12, uc_DeSo2.txt_Phieu12);
                var soloi = (from w in Global.Db.GetSoLoi_CheckDe(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" hình lỗi";
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Lỗi load dữ liệu: " + i.Message);
            }
        }      
        private string GetImage_DeSo()
        {
            LockControl(true);
            var temp = (from w in Global.Db.tbl_MissCheck_DeSos where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0 select w.IdImage).FirstOrDefault();
            if (string.IsNullOrEmpty(temp))
            {
                var getFilename = (from w in Global.Db.GetImageCheck_DeSo(Global.StrBatch, Global.StrUsername) select w.Column1).FirstOrDefault();
                if (string.IsNullOrEmpty(getFilename))
                    return "NULL";
                lb_Image.Text = getFilename;
                ucPictureBox1.imageBox1.Image = null;
                if (ucPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename, Settings.Default.ZoomImage) == "Error")
                {
                    ucPictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            else
            {
                lb_Image.Text = temp;
                ucPictureBox1.imageBox1.Image = null;
                if (ucPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp, Settings.Default.ZoomImage) == "Error")
                {
                    ucPictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            timer1.Enabled = true;
            return "Ok";
        }

        private void btn_Luu_DeSo1_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                Global.Db.LuuDeSo(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername);
                ResetData();
                var soloi = (from w in Global.Db.GetSoLoi_CheckDe(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" hình lỗi";
                var version = (from w in Global.DbBpo.tbl_Versions where w.IDProject == Global.StrIdProject select w.IDVersion).FirstOrDefault();
                if (version != Global.Version)
                {
                    MessageBox.Show(@"Cập nhật Version mới!");
                    Process.Start(Global.UrlUpdateVersion);
                    Application.Exit();
                }
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Hoàn thành Batch '" + cbb_Batch_Check.Text + "'");
                    LoadBatchMoi();
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show(@"Không thể load hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error : " + i.Message);
            }
        }
        private void btn_Luu_DeSo2_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                Global.Db.LuuDeSo(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername);

                var soloi = (from w in Global.Db.GetSoLoi_CheckDe(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" hình lỗi";
                ResetData();
                var version = (from w in Global.DbBpo.tbl_Versions where w.IDProject == Global.StrIdProject select w.IDVersion).FirstOrDefault();
                if (version != Global.Version)
                {
                    MessageBox.Show(@"Cập nhật Version mới!");
                    Process.Start(Global.UrlUpdateVersion);
                    Application.Exit();
                }
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Hoàn thành Batch: '" + cbb_Batch_Check.Text + "'");
                    LoadBatchMoi();
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show(@"Không thể load hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error : " + i.Message);
            }
        }
        private void btn_SuaVaLuu_User1_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                uc_DeSo1.SuaVaLuu(lb_username1.Text, lb_username2.Text, lb_Image.Text);
                ResetData();
                var soloi = (from w in Global.Db.GetSoLoi_CheckDe(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" hình lỗi";
                var version = (from w in Global.DbBpo.tbl_Versions where w.IDProject == Global.StrIdProject select w.IDVersion).FirstOrDefault();
                if (version != Global.Version)
                {
                    MessageBox.Show(@"Cập nhật Version mới!");
                    Process.Start(Global.UrlUpdateVersion);
                    Application.Exit();
                }
                if (GetImage_DeSo() == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Hoàn thành Batch: '" + cbb_Batch_Check.Text + "'");
                    LoadBatchMoi();
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error : " + i.Message);
            }
        }

        private void btn_SuaVaLuu_User2_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                uc_DeSo2.SuaVaLuu(lb_username2.Text, lb_username1.Text, lb_Image.Text);
                ResetData();
                var soloi = (from w in Global.Db.GetSoLoi_CheckDe(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" hình lỗi";
                var version = (from w in Global.DbBpo.tbl_Versions where w.IDProject == Global.StrIdProject select w.IDVersion).FirstOrDefault();
                if (version != Global.Version)
                {
                    MessageBox.Show(@"Cập nhật Version mới!");
                    Process.Start(Global.UrlUpdateVersion);
                    Application.Exit();
                }
                if (GetImage_DeSo() == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Hoàn thành Batch: '" + cbb_Batch_Check.Text + "'");
                    LoadBatchMoi();
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Lỗi : " + i.Message);
            }
        }

        private void cbb_Batch_Check_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User1.Visible = false;
            btn_SuaVaLuu_User2.Visible = false;
            Global.StrBatch = cbb_Batch_Check.Text;
            var soloi = (from w in Global.Db.GetSoLoi_CheckDe(cbb_Batch_Check.Text) select w.Column1).FirstOrDefault();
            lb_Loi.Text = soloi + @" hình lỗi";
            ResetData();
            btn_Start.Visible = true;
        }

        private void FrmCheckDeSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.PageUp)
                ucPictureBox1.btn_Xoaytrai_Click(null, null);
            if (e.Control && e.KeyCode == Keys.PageDown)
                ucPictureBox1.btn_xoayphai_Click(null, null);
        }

        private void lb_Image_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb_Image.Text);
            XtraMessageBox.Show("Copy Success!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LockControl(false);
            timer1.Enabled = false;
        }
        private void LockControl(bool kt)
        {
            if (kt)
            {
                btn_Luu_DeSo1.Enabled = false;

                btn_Luu_DeSo2.Enabled = false;

            }
            else
            {
                btn_Luu_DeSo1.Enabled = true;
                btn_Luu_DeSo2.Enabled = true;
            }
        }

        
    }
}