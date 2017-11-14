using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Honda_Net_Typer.MyClass;

namespace Honda_Net_Typer.MyUserControl
{  public delegate void AllTextChange(object sender, EventArgs e);
    public partial class Uc_DeSo : UserControl
    {
           public event AllTextChange Changed;
            public Uc_DeSo()
        {
            InitializeComponent();
        }
        private void txt_Phieu1_EditValueChanged(object sender, EventArgs e)
        {

            if (((TextEdit)sender).Text.Length > 10)
                ((TextEdit)sender).BackColor = Color.Red;
            else if (((TextEdit)sender).Text.Length <= 10)
                    {
                ((TextEdit)sender).BackColor = Color.White; }
            Changed?.Invoke(sender, e);
        }
        public void ResetData()
        {
            txt_Phieu1.Focus();
            txt_Phieu1.Text = "";
            txt_Phieu2.Text = "";
            txt_Phieu3.Text = "";
            txt_Phieu4.Text = "";
            txt_Phieu5.Text = "";
            txt_Phieu6.Text = "";
            txt_Phieu7.Text = "";
            txt_Phieu8.Text = "";
            txt_Phieu9.Text = "";
            txt_Phieu10.Text =txt_Phieu11.Text= txt_Phieu12.Text= "";
        }
        public void SaveData(string idImage)
        {
            Global.Db.Insert_Data_DeSo(idImage, Global.StrBatch, Global.StrUsername,
                txt_Phieu1.Text, txt_Phieu2.Text, txt_Phieu3.Text,
                txt_Phieu4.Text, txt_Phieu5.Text, txt_Phieu6.Text,
                txt_Phieu7.Text, txt_Phieu8.Text, txt_Phieu9.Text, txt_Phieu10.Text, txt_Phieu11.Text, txt_Phieu12.Text      
            );
        }
        public void SuaVaLuu(string usersaiit, string usersainhieu, string idimage)
        {
            Global.Db.SuaVaLuu(usersaiit, usersainhieu, idimage, Global.StrBatch, Global.StrUsername,
                txt_Phieu1.Text,
                txt_Phieu2.Text,
                txt_Phieu3.Text,
                txt_Phieu4.Text,
                txt_Phieu5.Text,
                txt_Phieu6.Text,
                txt_Phieu7.Text,
                txt_Phieu8.Text,
                txt_Phieu9.Text,
                txt_Phieu10.Text,
                txt_Phieu11.Text,
                txt_Phieu12.Text              
                );
        }
        public bool IsEmpty()
        {

            if (string.IsNullOrEmpty(this.txt_Phieu1.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu2.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu3.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu4.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu5.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu6.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu7.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu8.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu9.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu11.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu12.Text) &&
                string.IsNullOrEmpty(this.txt_Phieu10.Text))
            {
                return true;
            }
            return false;

        }

        private void txt_Phieu1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down ||e.KeyCode ==Keys.Enter)
            {
                txt_Phieu2.Focus();
            }
//             else if (e.KeyCode == Keys.Right)
//             {
//                 txt_Phieu7.Focus();
//             }
        }

        private void txt_Phieu2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu3.Focus();
            }
//             else if (e.KeyCode == Keys.Right)
//             {
//                 txt_Phieu8.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu1.Focus();
            }
        }

        private void txt_Phieu3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu4.Focus();
            }
//             else if (e.KeyCode == Keys.Right)
//             {
//                 txt_Phieu9.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu2.Focus();
            }
        }

        private void txt_Phieu4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu5.Focus();
            }
//             else if (e.KeyCode == Keys.Right)
//             {
//                 txt_Phieu10.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu3.Focus();
            }
        }

        private void txt_Phieu5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu6.Focus();
            }
//             else if (e.KeyCode == Keys.Right)
//             {
//                 txt_Phieu11.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu4.Focus();
            }
        }

        private void txt_Phieu6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu7.Focus();
            }
//             else if (e.KeyCode == Keys.Right)
//             {
//                 txt_Phieu12.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu5.Focus();
            }
        }

        private void txt_Phieu7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu8.Focus();
            }
//             else if (e.KeyCode == Keys.Left)
//             {
//                 txt_Phieu1.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu6.Focus();
            }
        }

        private void txt_Phieu8_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu9.Focus();
            }
//             else if (e.KeyCode == Keys.Left)
//             {
//                 txt_Phieu2.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu7.Focus();
            }

        }

        private void txt_Phieu9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu10.Focus();
            }
//             else if (e.KeyCode == Keys.Left)
//             {
//                 txt_Phieu3.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu8.Focus();
            }
        }

        private void txt_Phieu10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu11.Focus();
            }
//             else if (e.KeyCode == Keys.Left)
//             {
//                 txt_Phieu4.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu9.Focus();
            }
        }

        private void txt_Phieu11_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Phieu12.Focus();
            }
//             else if (e.KeyCode == Keys.Left)
//             {
//                 txt_Phieu5.Focus();
//             }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu10.Focus();
            }
        }

        private void txt_Phieu12_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Left)
            {
                txt_Phieu6.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_Phieu11.Focus();
            }
        }
    }
}
