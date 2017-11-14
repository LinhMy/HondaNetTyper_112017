namespace Honda_Net_Typer.MyForm
{
    partial class FrmExportExcel
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExportError = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Export = new System.Windows.Forms.Button();
            this.cbb_Batch = new System.Windows.Forms.ComboBox();
            this.lb_SoDong = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExportError);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Export);
            this.panelControl1.Controls.Add(this.cbb_Batch);
            this.panelControl1.Controls.Add(this.lb_SoDong);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1038, 61);
            this.panelControl1.TabIndex = 10;
            // 
            // btnExportError
            // 
            this.btnExportError.Location = new System.Drawing.Point(810, 22);
            this.btnExportError.Name = "btnExportError";
            this.btnExportError.Size = new System.Drawing.Size(84, 23);
            this.btnExportError.TabIndex = 7;
            this.btnExportError.Text = "Export Error";
            this.btnExportError.UseVisualStyleBackColor = true;
            this.btnExportError.Visible = false;
            this.btnExportError.Click += new System.EventHandler(this.btnExportError_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Batch:";
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(701, 22);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(99, 23);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // cbb_Batch
            // 
            this.cbb_Batch.FormattingEnabled = true;
            this.cbb_Batch.Location = new System.Drawing.Point(42, 24);
            this.cbb_Batch.Name = "cbb_Batch";
            this.cbb_Batch.Size = new System.Drawing.Size(653, 21);
            this.cbb_Batch.TabIndex = 0;
            // 
            // lb_SoDong
            // 
            this.lb_SoDong.AutoSize = true;
            this.lb_SoDong.Location = new System.Drawing.Point(911, 27);
            this.lb_SoDong.Name = "lb_SoDong";
            this.lb_SoDong.Size = new System.Drawing.Size(19, 13);
            this.lb_SoDong.TabIndex = 5;
            this.lb_SoDong.Text = "...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 589);
            this.dataGridView1.TabIndex = 9;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 61);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.ShowProgressInTaskBar = true;
            this.progressBarControl1.Size = new System.Drawing.Size(1038, 27);
            this.progressBarControl1.TabIndex = 11;
            // 
            // FrmExportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 677);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmExportExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ExportExcel";
            this.Load += new System.EventHandler(this.frm_ExportExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.ComboBox cbb_Batch;
        private System.Windows.Forms.Label lb_SoDong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Button btnExportError;
    }
}