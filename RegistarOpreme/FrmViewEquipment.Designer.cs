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
            // FrmViewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 552);
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
    }
}