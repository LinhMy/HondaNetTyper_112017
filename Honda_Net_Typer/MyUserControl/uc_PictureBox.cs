using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Honda_Net_Typer.MyForm;
using Honda_Net_Typer.Properties;

namespace Honda_Net_Typer.MyUserControl
{
    public partial class uc_PictureBox : UserControl
    {
        public int iZoomMinimum = 10;
        public int iZoomMax = 500;
        public uc_PictureBox()
        {
            InitializeComponent();
        }
        public void AllowZoom(bool b)
        {
            imageBox1.AllowZoom = b;
        }
        public String LoadImage(String strURL, String strFileName, int iZoomValue)
        {
            try
            {

                PictureBox temp = new PictureBox();
                temp.Load(strURL);
                this.imageBox1.Image = temp.Image;

                imageBox1.SizeMode = ImageGlass.ImageBoxSizeMode.Normal;

                this.imageBox1.Image.Tag = strFileName;

                imageBox1.Zoom = iZoomValue;
                imageBox1.ZoomChanged += imageBox1_ZoomChanged;


            }
            catch (System.Exception)
            {

                return "Error";
            }
            

            return "Ok";
        }

        public void SetMinMaxValue(int min, int max)
        {
            this.iZoomMinimum = min;
            iZoomMax = max;
        }

        void imageBox1_ZoomChanged(object sender, EventArgs e)
        {
            if (imageBox1.Zoom < iZoomMinimum)
                imageBox1.Zoom = iZoomMinimum;
            if (imageBox1.Zoom > iZoomMax)
                imageBox1.Zoom = iZoomMax;
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {

            imageBox1.SizeMode = ImageGlass.ImageBoxSizeMode.Normal;
        }

        private void imageBox1_MouseHover(object sender, EventArgs e)
        {
            imageBox1.AllowZoom = true;
        }

        private void imageBox1_MouseLeave(object sender, EventArgs e)
        {
            imageBox1.AllowZoom = false;
        }

        private void btn_Xoaytrai_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
                return;
            Bitmap bmp = new Bitmap(imageBox1.Image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);
            imageBox1.Image  = bmp;
        }

        private void btn_Xoayphai_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
                return;
            Bitmap bmp = new Bitmap(imageBox1.Image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            imageBox1.Image = bmp;
        }

        private void btnChangeZom_Click(object sender, EventArgs e)
        {
            new FrmChangeZoom().ShowDialog();
            try
            {
                if (imageBox1.Image == null)
                    return;
                Bitmap bmap = new Bitmap(imageBox1.Image);
                Bitmap newmap = bmap.Clone(new Rectangle(0, 0, bmap.Width, bmap.Height), System.Drawing.Imaging.PixelFormat.DontCare);
                bmap.Dispose();
                imageBox1.Image = null;
                imageBox1.Image  = newmap;
                imageBox1.Zoom = Settings.Default.ZoomImage;
                imageBox1.ZoomChanged += imageBox1_ZoomChanged;
            }
            catch (Exception)
            {

            }
        }

        internal void btn_Xoaytrai_Click(object p1, object p2)
        {
            throw new NotImplementedException();
        }

        internal void btn_xoayphai_Click(object p1, object p2)
        {
            throw new NotImplementedException();
        }
    }
}
