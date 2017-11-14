namespace Honda_Net_Typer.MyForm
{
    partial class FrmCreateBatch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_DateCreate = new DevExpress.XtraEditors.TextEdit();
            this.btn_CreateBatch = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BrowserImage = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ImagePath = new DevExpress.XtraEditors.TextEdit();
            this.txt_UserCreate = new DevExpress.XtraEditors.TextEdit();
            this.txt_BatchName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_SoFolder = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lb_SoLuongHinh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Location = new DevExpress.XtraEditors.TextEdit();
            this.txt_PathFolder = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Browser = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ImagePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PathFolder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txt_DateCreate
            // 
            this.txt_DateCreate.Location = new System.Drawing.Point(137, 265);
            this.txt_DateCreate.Name = "txt_DateCreate";
            this.txt_DateCreate.Properties.ReadOnly = true;
            this.txt_DateCreate.Size = new System.Drawing.Size(174, 20);
            this.txt_DateCreate.TabIndex = 60;
            // 
            // btn_CreateBatch
            // 
            this.btn_CreateBatch.Location = new System.Drawing.Point(221, 311);
            this.btn_CreateBatch.Name = "btn_CreateBatch";
            this.btn_CreateBatch.Size = new System.Drawing.Size(164, 44);
            this.btn_CreateBatch.TabIndex = 62;
            this.btn_CreateBatch.Text = "Create";
            this.btn_CreateBatch.Click += new System.EventHandler(this.btn_CreateBatch_Click);
            // 
            // btn_BrowserImage
            // 
            this.btn_BrowserImage.Location = new System.Drawing.Point(499, 73);
            this.btn_BrowserImage.Name = "btn_BrowserImage";
            this.btn_BrowserImage.Size = new System.Drawing.Size(85, 23);
            this.btn_BrowserImage.TabIndex = 61;
            this.btn_BrowserImage.Text = "Browser...";
            this.btn_BrowserImage.Click += new System.EventHandler(this.btn_BrowserImage_Click);
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Location = new System.Drawing.Point(137, 75);
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.Properties.ReadOnly = true;
            this.txt_ImagePath.Size = new System.Drawing.Size(356, 20);
            this.txt_ImagePath.TabIndex = 58;
            // 
            // txt_UserCreate
            // 
            this.txt_UserCreate.Location = new System.Drawing.Point(137, 221);
            this.txt_UserCreate.Name = "txt_UserCreate";
            this.txt_UserCreate.Properties.ReadOnly = true;
            this.txt_UserCreate.Size = new System.Drawing.Size(174, 20);
            this.txt_UserCreate.TabIndex = 57;
            // 
            // txt_BatchName
            // 
            this.txt_BatchName.Location = new System.Drawing.Point(137, 49);
            this.txt_BatchName.Name = "txt_BatchName";
            this.txt_BatchName.Size = new System.Drawing.Size(356, 20);
            this.txt_BatchName.TabIndex = 56;
            this.txt_BatchName.EditValueChanged += new System.EventHandler(this.txt_BatchName_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(63, 78);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 13);
            this.labelControl7.TabIndex = 54;
            this.labelControl7.Text = "Path Image:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(31, 269);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 13);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "Date create Batch:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 225);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 13);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "User create Batch:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 13);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "Batch Name (Single):";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(205, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(216, 25);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "CREATE NEW BATCH";
            // 
            // lbl_SoFolder
            // 
            this.lbl_SoFolder.Location = new System.Drawing.Point(63, 379);
            this.lbl_SoFolder.Name = "lbl_SoFolder";
            this.lbl_SoFolder.Size = new System.Drawing.Size(0, 13);
            this.lbl_SoFolder.TabIndex = 69;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 369);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(632, 27);
            this.progressBarControl1.TabIndex = 70;
            // 
            // lb_SoLuongHinh
            // 
            this.lb_SoLuongHinh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lb_SoLuongHinh.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_SoLuongHinh.Appearance.Options.UseFont = true;
            this.lb_SoLuongHinh.Appearance.Options.UseForeColor = true;
            this.lb_SoLuongHinh.Location = new System.Drawing.Point(137, 101);
            this.lb_SoLuongHinh.Name = "lb_SoLuongHinh";
            this.lb_SoLuongHinh.Size = new System.Drawing.Size(0, 19);
            this.lb_SoLuongHinh.TabIndex = 64;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(95, 173);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 50;
            this.labelControl4.Text = "Path:";
            this.labelControl4.Visible = false;

            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(137, 195);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Z:\\abc";
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(137, 169);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(356, 20);
            this.txt_Location.TabIndex = 59;
            this.txt_Location.Visible = false;
            // 
            // txt_PathFolder
            // 
            this.txt_PathFolder.Location = new System.Drawing.Point(137, 125);
            this.txt_PathFolder.Name = "txt_PathFolder";
            this.txt_PathFolder.Size = new System.Drawing.Size(356, 20);
            this.txt_PathFolder.TabIndex = 66;
            this.txt_PathFolder.Visible = false;
            this.txt_PathFolder.EditValueChanged += new System.EventHandler(this.txt_PathFolder_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(30, 128);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(101, 13);
            this.labelControl8.TabIndex = 65;
            this.labelControl8.Text = "Folder Batch (nhiều):";
            this.labelControl8.Visible = false;
            // 
            // btn_Browser
            // 
            this.btn_Browser.Location = new System.Drawing.Point(499, 123);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(85, 23);
            this.btn_Browser.TabIndex = 67;
            this.btn_Browser.Text = "Browser...";
            this.btn_Browser.Visible = false;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // FrmCreateBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 396);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.lbl_SoFolder);
            this.Controls.Add(this.btn_Browser);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txt_PathFolder);
            this.Controls.Add(this.txt_DateCreate);
            this.Controls.Add(this.lb_SoLuongHinh);
            this.Controls.Add(this.btn_CreateBatch);
            this.Controls.Add(this.btn_BrowserImage);
            this.Controls.Add(this.txt_ImagePath);
            this.Controls.Add(this.txt_UserCreate);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_BatchName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmCreateBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Batch";
            this.Load += new System.EventHandler(this.frmCreateBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ImagePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PathFolder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.TextEdit txt_DateCreate;
        private DevExpress.XtraEditors.SimpleButton btn_CreateBatch;
        private DevExpress.XtraEditors.SimpleButton btn_BrowserImage;
        private DevExpress.XtraEditors.TextEdit txt_ImagePath;
        private DevExpress.XtraEditors.TextEdit txt_UserCreate;
        private DevExpress.XtraEditors.TextEdit txt_BatchName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_SoFolder;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lb_SoLuongHinh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Location;
        private DevExpress.XtraEditors.TextEdit txt_PathFolder;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_Browser;
    }
}