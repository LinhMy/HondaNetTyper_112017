using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Honda_Net_Typer.MyClass;

namespace Honda_Net_Typer.MyForm
{
    public partial class frm_ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void frm_ChangePassword_Load(object sender, EventArgs e)
        {
            //btn_ShowPassCu.MouseUp += Btn_ShowPassCu_MouseUp;
            //btn_ShowPassCu.MouseDown += Btn_ShowPassCu_MouseDown;
            //btn_ShowPassMoi.MouseUp += Btn_ShowPassMoi_MouseUp;
            //btn_ShowPassMoi.MouseDown += Btn_ShowPassMoi_MouseDown;
            //btn_ShowPassNhapLai.MouseUp += Btn_ShowPassNhapLai_MouseUp;
            //btn_ShowPassNhapLai.MouseDown += Btn_ShowPassNhapLai_MouseDown;
        }
        
        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            var passcu = (from w in Global.DbBpo.tbl_Users where w.Username == Global.StrUsername select w.Password).FirstOrDefault();
            if (string.IsNullOrEmpty(txt_PassCu.Text))
            {
                lb_ThongBao.Text = "* Bạn vui lòng nhập password cũ";
            }
            else
            {
                if (txt_PassCu.Text != passcu)
                {
                    lb_ThongBao.Text = "* Bạn nhập sai password cũ!";
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_PassMoi.Text))
                    {
                        lb_ThongBao.Text = "* Bạn không được để trống password mới!";
                    }
                    else
                    {
                        if (txt_PassMoi.Text != txt_PassNhapLai.Text)
                        {
                            lb_ThongBao.Text = "* Bạn nhập 2 lần password mới không giống nhau!";
                        }
                        else
                        {
                            if (Global.DbBpo.UpdatePassword(Global.StrUsername, txt_PassCu.Text, txt_PassMoi.Text) == 0)
                            {
                                lb_ThongBao.Text = "* Bạn đã đổi password thành công!";
                            }
                            txt_PassCu.Text = "";
                            txt_PassMoi.Text = "";
                            txt_PassNhapLai.Text = "";
                        }
                    }

                }
            }
        }
    }
}