namespace Honda_Net_Typer.MyForm
{
    partial class FrmNangSuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNangSuat));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_EndDay = new System.Windows.Forms.DateTimePicker();
            this.dtp_FirstDay = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc_NangSuat = new DevExpress.XtraGrid.GridControl();
            this.dgv_Loai1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NangSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Controls.Add(this.dtp_EndDay);
            this.panelControl1.Controls.Add(this.dtp_FirstDay);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(929, 88);
            this.panelControl1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(600, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(56, 74);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // dtp_EndDay
            // 
            this.dtp_EndDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_EndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDay.Location = new System.Drawing.Point(278, 50);
            this.dtp_EndDay.Name = "dtp_EndDay";
            this.dtp_EndDay.Size = new System.Drawing.Size(143, 21);
            this.dtp_EndDay.TabIndex = 4;
            this.dtp_EndDay.ValueChanged += new System.EventHandler(this.dtp_EndDay_ValueChanged);
            // 
            // dtp_FirstDay
            // 
            this.dtp_FirstDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_FirstDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FirstDay.Location = new System.Drawing.Point(278, 18);
            this.dtp_FirstDay.Name = "dtp_FirstDay";
            this.dtp_FirstDay.Size = new System.Drawing.Size(143, 21);
            this.dtp_FirstDay.TabIndex = 4;
            this.dtp_FirstDay.ValueChanged += new System.EventHandler(this.dtp_FirstDay_ValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(439, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 45);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Export Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(235, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "to date:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(225, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "From day:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gc_NangSuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 559);
            this.panel1.TabIndex = 3;
            // 
            // gc_NangSuat
            // 
            this.gc_NangSuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NangSuat.Location = new System.Drawing.Point(0, 0);
            this.gc_NangSuat.MainView = this.dgv_Loai1;
            this.gc_NangSuat.Name = "gc_NangSuat";
            this.gc_NangSuat.Size = new System.Drawing.Size(929, 559);
            this.gc_NangSuat.TabIndex = 4;
            this.gc_NangSuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Loai1});
            // 
            // dgv_Loai1
            // 
            this.dgv_Loai1.Appearance.OddRow.BackColor = System.Drawing.Color.SeaShell;
            this.dgv_Loai1.Appearance.OddRow.BackColor2 = System.Drawing.Color.SeaShell;
            this.dgv_Loai1.Appearance.OddRow.Options.UseBackColor = true;
            this.dgv_Loai1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7});
            this.dgv_Loai1.GridControl = this.gc_NangSuat;
            this.dgv_Loai1.Name = "dgv_Loai1";
            this.dgv_Loai1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Loai1.OptionsBehavior.Editable = false;
            this.dgv_Loai1.OptionsFind.AlwaysVisible = true;
            this.dgv_Loai1.OptionsView.EnableAppearanceOddRow = true;
            this.dgv_Loai1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "UserName";
            this.gridColumn1.FieldName = "UserName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 149;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Personnel name";
            this.gridColumn2.FieldName = "FullName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 132;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Total row do";
            this.gridColumn6.FieldName = "SoPhieuNhap";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 138;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Correct row";
            this.gridColumn3.FieldName = "PhieuDung";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 122;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Wrong row";
            this.gridColumn4.FieldName = "PhieuSai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 120;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "Time (h)";
            this.gridColumn5.FieldName = "ThoiGian";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 117;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Performance (%)";
            this.gridColumn7.FieldName = "HieuSuat";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 127;
            // 
            // FrmNangSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNangSuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productivity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_NangSuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_NangSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtp_EndDay;
        private System.Windows.Forms.DateTimePicker dtp_FirstDay;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gc_NangSuat;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Loai1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}