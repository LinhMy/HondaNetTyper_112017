using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using LibraryLogin;
using Honda_Net_Typer.Properties;
using Honda_Net_Typer.MyClass;
using Honda_Net_Typer.MyForm;

namespace Honda_Net_Typer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle(Settings.Default.ApplicationSkinName);
            bool temp;
                do
              {
                temp = false;
                Frm_Login a = new Frm_Login();
                a.lb_programName.Text = @"           Honda_Net_Typer Project";
                a.lb_vision.Text = @"Version :";
                a.grb_1.Text = @"Information PC";
                a.lb_machine.Text = @"PC name:";
                a.lb_user_window.Text = @"Account window: ";
                a.lb_ip.Text = @"Address IP :";
                a.grb_2.Text = @"Login account information";
                a.lb_username.Text = @"User Name:";
                a.lb_password.Text = @"Password:";
                a.lb_role.Text = @"Role";
                a.lb_date.Text = @"Date: ";
                a.lb_time.Text = @"Time: ";
                a.lb_batchno.Text = @"BatchName: ";
                a.btn_thoat.Text = @"Exit";
                a.chb_hienthi.Text = @"Show";
                a.chb_luu.Text = @"Save";
                a.lb_version.Text = Global.Version;
                a.UrlUpdateVersion = Global.UrlUpdateVersion;
                a.LoginEvent += a_LoginEvent;
                a.ButtonLoginEven += a_ButtonLoginEven;
                if (a.ShowDialog() == DialogResult.OK)
                {
                    Global.StrMachine = a.StrMachine;
                    Global.StrUserWindow = a.StrUserWindow;
                    Global.StrIpAddress = a.StrIpAddress;
                    Global.StrUsername = a.StrUserName;
                    Global.StrBatch = a.StrBatch;
                    Global.StrRole = a.StrRole;
                    Global.StrToken = a.Token;
                    FrmMain f = new FrmMain();
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        f.Close();
                        temp = true;
                    }
                }
            } while (temp);
        }

    private static void a_ButtonLoginEven(int iLogin, string strMachine, string strUserWindow, string strIpAddress, string strUsername, string password, string strBatch, string strRole, string strToken, ref bool loginOk)
        {
            if (iLogin == 1)
            {
                //Kiểm tra Token
                bool has = Global.DbBpo.tbl_TokenLogins.Any(w => w.UserName == strUsername && w.IDProject == Global.StrIdProject);
                if (has)
                {
                    var token = (from w in Global.DbBpo.tbl_TokenLogins where w.UserName == strUsername && w.IDProject == Global.StrIdProject select w.Token).FirstOrDefault();
                    if (token == "")
                    {
                        Global.DbBpo.updateToken(strUsername, Global.StrIdProject, strToken);
                        Global.DbBpo.InsertLoginTime_new(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress, strToken, Global.StrIdProject);
                        loginOk = true;
                    }
                    else
                    {
                        if (MessageBox.Show(@"This user has logged in on another machine. Would you like to continue signing in?", @"Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Global.DbBpo.updateToken(strUsername, Global.StrIdProject, strToken);
                            Global.DbBpo.InsertLoginTime_new(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress, strToken, Global.StrIdProject);
                            loginOk = true;
                        }
                        else
                        {
                            loginOk = false;
                        }
                    }
                }
                else
                {
                    var token = new tbl_TokenLogin();
                    token.UserName = strUsername;
                    token.IDProject = Global.StrIdProject;
                    token.Token = "";
                    token.DateLogin = DateTime.Now; Global.DbBpo.tbl_TokenLogins.InsertOnSubmit(token);
                    Global.DbBpo.SubmitChanges();
                    loginOk = true;
                    Global.DbBpo.updateToken(strUsername, Global.StrIdProject, strToken);
                    Global.DbBpo.InsertLoginTime_new(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress, strToken, Global.StrIdProject);
                }
            }
        }

        private static void a_LoginEvent(string username, string password, ref string strVersion, ref int iKiemtraLogin, ref string role, ref ComboBox cbb)
        {
            try
            {
                iKiemtraLogin = Global.DbBpo.KiemTraLogin(username, password);
                strVersion = (from w in Global.DbBpo.tbl_Versions where w.IDProject == Global.StrIdProject select w.IDVersion).FirstOrDefault();
                role = (from w in Global.DbBpo.tbl_Users where w.Username == username select w.IDRole).FirstOrDefault();
                if (!string.IsNullOrEmpty(role))
                    role = role.ToUpper();
                if (iKiemtraLogin == 1 && role == "ADMIN")
                {
                    cbb.DataSource = Global.Db.GetBatch();
                    cbb.DisplayMember = "fBatchName";
                }
                else if (iKiemtraLogin == 1 && role == "DESO")
                {

                    cbb.DataSource = Global.Db.GetBatNotFinishDeSo(username);
                    cbb.DisplayMember = "fBatchName";

                }
                else if (iKiemtraLogin == 1 && role == "CHECKERDESO")
                {
                    cbb.DataSource = Global.Db.GetBatNotFinishCheckerDeSo(username);
                    cbb.DisplayMember = "fBatchName";
                }
            }
            catch (Exception e){
                MessageBox.Show(@"Error connecting to server, please check your connection Internet" + e.Message);
            }
        }
    }
    }
