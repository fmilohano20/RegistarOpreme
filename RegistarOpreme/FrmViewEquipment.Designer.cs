namespace RegistarOpreme
{
    partial class FrmViewEquipment
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
            this.dgvEquipmentRecords = new System.Windows.Forms.DataGridView();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboFinanceSource = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipmentRecords
            // 
            this.dgvEquipmentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipmentRecords.Location = new System.Drawing.Point(12, 48);
            this.dgvEquipmentRecords.Name = "dgvEquipmentRecords";
            this.dgvEquipmentRecords.Size = new System.Drawing.Size(1101, 492);
            this.dgvEquipmentRecords.TabIndex = 0;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(12, 6);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(237, 36);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Evidentiraj";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Visible = false;
            this.btnRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(264, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Ažuriraj zapise";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(735, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(289, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboFinanceSource
            // 
            this.cboFinanceSource.FormattingEnabled = true;
            this.cboFinanceSource.Location = new System.Drawing.Point(516, 15);
            this.cboFinanceSource.Name = "cboFinanceSource";
            this.cboFinanceSource.Size = new System.Drawing.Size(213, 21);
            this.cboFinanceSource.TabIndex = 5;
            this.cboFinanceSource.SelectedIndexChanged += new System.EventHandler(this.cboFinanceSource_SelectedIndexChanged);
            // 
            // FrmViewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 552);
            this.Controls.Add(this.cboFinanceSource);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.dgvEquipmentRecords);
            this.Name = "FrmViewEquipment";
            this.Text = "Pregled evidencije opreme";
            this.Load += new System.EventHandler(this.FrmViewEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipmentRecords;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboFinanceSource;
    }
}