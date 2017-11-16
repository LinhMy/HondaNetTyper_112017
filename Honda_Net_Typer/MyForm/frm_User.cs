using DevExpress.XtraGrid.Views.Grid;
using Honda_Net_Typer.MyClass;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Honda_Net_Typer.MyForm
{
    public partial class frm_User : DevExpress.XtraEditors.XtraForm
    {
        public frm_User()
        {
            InitializeComponent();
        }

        public bool Cal(int width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
            return true;
        }

        private void LoadSttGridView(RowIndicatorCustomDrawEventArgs e, GridView dgv)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
            int width = Convert.ToInt32(size.Width) + 20;
            BeginInvoke(new MethodInvoker(delegate { Cal(width, dgv); }));
        }
        private void frm_User_Load(object sender, EventArgs e)
        {
            dgv_listuser.DataSource = Global.DbBpo.GetListUser();
            cbb_idrole.DataSource = Global.DbBpo.GetListRole();
            cbb_idrole.DisplayMember = "RoleName";
            cbb_idrole.ValueMember = "RoleID";
        }
        private void btn_suauser_Click(object sender, EventArgs e)
        {
            string roleid, nhanvien;
            nhanvien = txt_FullName.Text;
            roleid = cbb_idrole.SelectedValue != null ? cbb_idrole.SelectedValue.ToString() : "";

            if (!string.IsNullOrEmpty(roleid) && !string.IsNullOrEmpty(nhanvien) && !string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_password.Text))
            {
                DialogResult thongbao = MessageBox.Show(@"Bạn chắc chắn muốn sửa UserName '" + txt_username.Text + "'", @"Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (thongbao == DialogResult.Yes)
                {
                    Global.DbBpo.UpdateUsername_NEW(txt_username.Text, txt_password.Text,chk_LevelUser_Inexperience.Checked==true?true:false, roleid, nhanvien, "", Global.StrUsername, Global.StrIpAddress, Environment.MachineName, Environment.UserDomainName + @"\" + Environment.UserName);
                    frm_User_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show(@"Nhập đầy đủ thông tin trước khi lưu !");
            }
        }
        
        private void btn_themuser_Click(object sender, EventArgs e)
        {

            string roleid, nhanvien;
            int r;

            nhanvien = txt_FullName.Text;
            roleid = cbb_idrole.SelectedValue != null ? cbb_idrole.SelectedValue.ToString() : "";

            if (!string.IsNullOrEmpty(roleid)&&!string.IsNullOrEmpty(nhanvien)&& !string.IsNullOrEmpty(txt_username.Text)&&!string.IsNullOrEmpty(txt_password.Text))
            {
                r = Global.DbBpo.InsertUsername_New(txt_username.Text, txt_password.Text, chk_LevelUser_Inexperience.Checked == true ? true : false, roleid,nhanvien, "", Global.StrUsername, Global.StrIpAddress, Environment.MachineName, Environment.UserDomainName + @"\" + Environment.UserName);
                if (r == 0)
                {
                    MessageBox.Show("UserName đã tồn tại, Vui lòng nhập UserName khác !");
                }
                if (r == 1)
                {
                    MessageBox.Show("Đã thêm UserName '" + txt_username.Text + "' !");
                    frm_User_Load(sender, e);
                    txt_username.Text = "";
                    txt_FullName.Text = "";
                    txt_username.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin trước khi lưu !");
            }
        }

        private void btn_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string username = gridView1.GetFocusedRowCellValue("Username") != null ? gridView1.GetFocusedRowCellValue("Username").ToString() : "";
            DialogResult thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa UserName '" +username + "'", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                if(!string.IsNullOrEmpty(username))
                {
                    Global.DbBpo.DeleteUsername(username);
                    frm_User_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Username rỗng, không thể xóa!");
                }
            }
        }
    
        private void cbb_idrole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 3)
                e.Handled = true;
        }

        private void gridView1_RowCellDefaultAlignment(object sender, DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs e)
        {
            try
            {
                txt_username.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Username") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Username").ToString() : "";
                cbb_idrole.SelectedValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IDRole") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IDRole").ToString() : "";
                txt_FullName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FullName") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FullName").ToString() : "";
                txt_password.Text = "";
                chk_LevelUser_Inexperience.Checked=Convert.ToBoolean( gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NotGoodUser") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NotGoodUser").ToString() : "");
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            LoadSttGridView(e, gridView1);
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                string username = gridView1.GetFocusedRowCellValue("Username").ToString();
                if (e.Column.FieldName == "NotGoodUser")
                {
                    bool check = (bool)e.Value;
                    if (check)
                    {
                        Global.DbBpo.updateNotGoodUser_New(username, true, Global.StrUsername, Global.StrIpAddress, Environment.MachineName, Environment.UserDomainName + @"\" + Environment.UserName);
                    }
                    else
                    {
                        Global.DbBpo.updateNotGoodUser_New(username, false, Global.StrUsername, Global.StrIpAddress, Environment.MachineName, Environment.UserDomainName + @"\" + Environment.UserName);
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi : " + i);
            }
        }
    }
}