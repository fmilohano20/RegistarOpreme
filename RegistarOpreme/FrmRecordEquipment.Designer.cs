namespace RegistarOpreme
{
    partial class FrmRecordEquipment
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquipmentType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipmentDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFinanceSource = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboShopper = new System.Windows.Forms.ComboBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(16, 386);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(156, 78);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Odustani";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(192, 386);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(156, 78);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Evidentiraj";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv opreme:";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(128, 13);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(220, 20);
            this.txtEquipmentName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip opreme:";
            this.label2.UseWaitCursor = true;
            // 
            // txtEquipmentType
            // 
            this.txtEquipmentType.Location = new System.Drawing.Point(128, 46);
            this.txtEquipmentType.Name = "txtEquipmentType";
            this.txtEquipmentType.Size = new System.Drawing.Size(220, 20);
            this.txtEquipmentType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis:";
            this.label3.UseWaitCursor = true;
            // 
            // txtEquipmentDescription
            // 
            this.txtEquipmentDescription.Location = new System.Drawing.Point(63, 126);
            this.txtEquipmentDescription.Multiline = true;
            this.txtEquipmentDescription.Name = "txtEquipmentDescription";
            this.txtEquipmentDescription.Size = new System.Drawing.Size(285, 107);
            this.txtEquipmentDescription.TabIndex = 7;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(128, 89);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(220, 20);
            this.txtProjectName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Naziv projekta:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Izvor financiranja:";
            this.label5.UseWaitCursor = true;
            // 
            // cboFinanceSource
            // 
            this.cboFinanceSource.FormattingEnabled = true;
            this.cboFinanceSource.Location = new System.Drawing.Point(150, 252);
            this.cboFinanceSource.Name = "cboFinanceSource";
            this.cboFinanceSource.Size = new System.Drawing.Size(198, 21);
            this.cboFinanceSource.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Naručitelj:";
            this.label7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zaprimatelj";
            this.label8.UseWaitCursor = true;
            // 
            // cboShopper
            // 
            this.cboShopper.FormattingEnabled = true;
            this.cboShopper.Location = new System.Drawing.Point(128, 291);
            this.cboShopper.Name = "cboShopper";
            this.cboShopper.Size = new System.Drawing.Size(220, 21);
            this.cboShopper.TabIndex = 18;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(128, 333);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.ReadOnly = true;
            this.txtRecipient.Size = new System.Drawing.Size(220, 20);
            this.txtRecipient.TabIndex = 19;
            // 
            // FrmRecordEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 503);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.cboShopper);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboFinanceSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEquipmentDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEquipmentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnQuit);
            this.Name = "FrmRecordEquipment";
            this.Text = "Evidnetiranje opreme";
            this.Load += new System.EventHandler(this.FrmEvidentiranjeOpreme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipmentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquipmentDescription;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFinanceSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboShopper;
        private System.Windows.Forms.TextBox txtRecipient;
    }
}

