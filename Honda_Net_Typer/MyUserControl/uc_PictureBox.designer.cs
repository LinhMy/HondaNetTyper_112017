namespace Honda_Net_Typer.MyUserControl
{
    partial class uc_PictureBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnChangeZom = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoayphai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoaytrai = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.imageBox1 = new ImageGlass.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeZom
            // 
            this.btnChangeZom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangeZom.Location = new System.Drawing.Point(510, 6);
            this.btnChangeZom.Name = "btnChangeZom";
            this.btnChangeZom.Size = new System.Drawing.Size(75, 29);
            this.btnChangeZom.TabIndex = 3;
            this.btnChangeZom.Text = "Change Zoom";
            this.btnChangeZom.Click += new System.EventHandler(this.btnChangeZom_Click);
            // 
            // btn_Xoayphai
            // 
            this.btn_Xoayphai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Xoayphai.Location = new System.Drawing.Point(429, 6);
            this.btn_Xoayphai.Name = "btn_Xoayphai";
            this.btn_Xoayphai.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoayphai.TabIndex = 2;
            this.btn_Xoayphai.Text = "Xoay phải";
            this.btn_Xoayphai.ToolTip = "(Ctrl+ ->)";
            this.btn_Xoayphai.Click += new System.EventHandler(this.btn_Xoayphai_Click);
            // 
            // btn_Xoaytrai
            // 
            this.btn_Xoaytrai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Xoaytrai.Location = new System.Drawing.Point(348, 6);
            this.btn_Xoaytrai.Name = "btn_Xoaytrai";
            this.btn_Xoaytrai.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoaytrai.TabIndex = 1;
            this.btn_Xoaytrai.Text = "Xoay trái";
            this.btn_Xoaytrai.ToolTip = "(Ctrl+ <-)";
            this.btn_Xoaytrai.Click += new System.EventHandler(this.btn_Xoaytrai_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Xoayphai);
            this.panelControl1.Controls.Add(this.btnChangeZom);
            this.panelControl1.Controls.Add(this.btn_Xoaytrai);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 544);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(935, 40);
            this.panelControl1.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.imageBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(935, 544);
            this.panelControl2.TabIndex = 5;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.GridColor = System.Drawing.Color.White;
            this.imageBox1.HorizontalScrollBarStyle = ImageGlass.ImageBoxScrollBarStyle.Hide;
            this.imageBox1.Location = new System.Drawing.Point(2, 2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(931, 540);
            this.imageBox1.TabIndex = 1;
            this.imageBox1.VerticalScrollBarStyle = ImageGlass.ImageBoxScrollBarStyle.Hide;
            this.imageBox1.MouseLeave += new System.EventHandler(this.imageBox1_MouseLeave);
            this.imageBox1.MouseHover += new System.EventHandler(this.imageBox1_MouseHover);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            // 
            // uc_PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "uc_PictureBox";
            this.Size = new System.Drawing.Size(935, 584);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnChangeZom;
        public DevExpress.XtraEditors.SimpleButton btn_Xoayphai;
        public DevExpress.XtraEditors.SimpleButton btn_Xoaytrai;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public ImageGlass.ImageBox imageBox1;
    }
}
