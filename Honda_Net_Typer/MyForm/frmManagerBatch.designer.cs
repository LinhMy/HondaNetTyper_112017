namespace Honda_Net_Typer.MyForm
{
    partial class FrmManagerBatch
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions11 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagerBatch));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions12 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions13 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions14 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions15 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fBatchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fdatecreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fusercreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fPathPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fSoLuongAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.CongKhaiBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_DeleteSelectedBatch = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TaoBatch = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemButtonEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit5)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions11.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions11.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions11, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions12.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions12.Image")));
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions12, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit3});
            this.gridControl1.Size = new System.Drawing.Size(840, 376);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.SeaShell;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.SeaShell;
            this.gridView1.Appearance.FocusedRow.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.PeachPuff;
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.PeachPuff;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Linen;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Linen;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDBatch,
            this.fBatchName,
            this.fdatecreated,
            this.fusercreate,
            this.fPathPicture,
            this.fLocation,
            this.fSoLuongAnh,
            this.LoaiBatch,
            this.gridColumn8,
            this.CongKhaiBatch});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // IDBatch
            // 
            this.IDBatch.Caption = "ID Batch";
            this.IDBatch.FieldName = "id";
            this.IDBatch.Name = "IDBatch";
            this.IDBatch.Visible = true;
            this.IDBatch.VisibleIndex = 1;
            this.IDBatch.Width = 42;
            // 
            // fBatchName
            // 
            this.fBatchName.Caption = "Batch name";
            this.fBatchName.FieldName = "fBatchName";
            this.fBatchName.Name = "fBatchName";
            this.fBatchName.Visible = true;
            this.fBatchName.VisibleIndex = 2;
            this.fBatchName.Width = 109;
            // 
            // fdatecreated
            // 
            this.fdatecreated.Caption = "Date create";
            this.fdatecreated.FieldName = "fDateCreate";
            this.fdatecreated.Name = "fdatecreated";
            this.fdatecreated.Visible = true;
            this.fdatecreated.VisibleIndex = 3;
            this.fdatecreated.Width = 62;
            // 
            // fusercreate
            // 
            this.fusercreate.Caption = "User create";
            this.fusercreate.FieldName = "fUserCreate";
            this.fusercreate.Name = "fusercreate";
            this.fusercreate.Visible = true;
            this.fusercreate.VisibleIndex = 4;
            this.fusercreate.Width = 70;
            // 
            // fPathPicture
            // 
            this.fPathPicture.Caption = "Path Batch";
            this.fPathPicture.FieldName = "fPathPicture";
            this.fPathPicture.Name = "fPathPicture";
            this.fPathPicture.Visible = true;
            this.fPathPicture.VisibleIndex = 5;
            this.fPathPicture.Width = 81;
            // 
            // fLocation
            // 
            this.fLocation.Caption = "Path export in excel";
            this.fLocation.FieldName = "fLocation";
            this.fLocation.Name = "fLocation";
            this.fLocation.Width = 104;
            // 
            // fSoLuongAnh
            // 
            this.fSoLuongAnh.Caption = "Total image";
            this.fSoLuongAnh.FieldName = "fSoLuongAnh";
            this.fSoLuongAnh.Name = "fSoLuongAnh";
            this.fSoLuongAnh.Visible = true;
            this.fSoLuongAnh.VisibleIndex = 7;
            this.fSoLuongAnh.Width = 66;
            // 
            // LoaiBatch
            // 
            this.LoaiBatch.Caption = "Type";
            this.LoaiBatch.FieldName = "LoaiBatch";
            this.LoaiBatch.Name = "LoaiBatch";
            this.LoaiBatch.Width = 91;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Delete";
            this.gridColumn8.ColumnEdit = this.repositoryItemButtonEdit3;
            this.gridColumn8.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 54;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            editorButtonImageOptions13.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions13.Image")));
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions13, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit3_ButtonClick);
            // 
            // CongKhaiBatch
            // 
            this.CongKhaiBatch.Caption = "Public batch";
            this.CongKhaiBatch.FieldName = "CongKhaiBatch";
            this.CongKhaiBatch.Name = "CongKhaiBatch";
            this.CongKhaiBatch.Width = 92;
            // 
            // repositoryItemButtonEdit4
            // 
            this.repositoryItemButtonEdit4.AutoHeight = false;
            editorButtonImageOptions14.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions14.Image")));
            this.repositoryItemButtonEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions14, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit4.Name = "repositoryItemButtonEdit4";
            this.repositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_DeleteSelectedBatch);
            this.panelControl1.Controls.Add(this.btn_TaoBatch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 376);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(840, 65);
            this.panelControl1.TabIndex = 3;
            // 
            // btn_DeleteSelectedBatch
            // 
            this.btn_DeleteSelectedBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteSelectedBatch.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteSelectedBatch.Appearance.Options.UseFont = true;
            this.btn_DeleteSelectedBatch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteSelectedBatch.ImageOptions.Image")));
            this.btn_DeleteSelectedBatch.Location = new System.Drawing.Point(629, 7);
            this.btn_DeleteSelectedBatch.Name = "btn_DeleteSelectedBatch";
            this.btn_DeleteSelectedBatch.Size = new System.Drawing.Size(199, 54);
            this.btn_DeleteSelectedBatch.TabIndex = 2;
            this.btn_DeleteSelectedBatch.Text = "Delete seleted Batch";
            this.btn_DeleteSelectedBatch.Click += new System.EventHandler(this.btn_DeleteSelectedBatch_Click);
            // 
            // btn_TaoBatch
            // 
            this.btn_TaoBatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TaoBatch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TaoBatch.Appearance.Options.UseFont = true;
            this.btn_TaoBatch.Location = new System.Drawing.Point(351, 5);
            this.btn_TaoBatch.Name = "btn_TaoBatch";
            this.btn_TaoBatch.Size = new System.Drawing.Size(126, 55);
            this.btn_TaoBatch.TabIndex = 0;
            this.btn_TaoBatch.Text = "Create Batch";
            this.btn_TaoBatch.Click += new System.EventHandler(this.btn_TaoBatch_Click);
            // 
            // repositoryItemButtonEdit5
            // 
            this.repositoryItemButtonEdit5.AutoHeight = false;
            editorButtonImageOptions15.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions15.Image")));
            this.repositoryItemButtonEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions15, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit5.Name = "repositoryItemButtonEdit5";
            this.repositoryItemButtonEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // FrmManagerBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 441);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmManagerBatch";
            this.Text = "Manager Batch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManagerBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDBatch;
        private DevExpress.XtraGrid.Columns.GridColumn fBatchName;
        private DevExpress.XtraGrid.Columns.GridColumn fdatecreated;
        private DevExpress.XtraGrid.Columns.GridColumn fusercreate;
        private DevExpress.XtraGrid.Columns.GridColumn fPathPicture;
        private DevExpress.XtraGrid.Columns.GridColumn fLocation;
        private DevExpress.XtraGrid.Columns.GridColumn fSoLuongAnh;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiBatch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_TaoBatch;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit5;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteSelectedBatch;
        private DevExpress.XtraGrid.Columns.GridColumn CongKhaiBatch;
    }
}