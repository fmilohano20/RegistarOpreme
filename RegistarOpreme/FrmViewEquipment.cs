using RegistarOpreme.Models;
using RegistarOpreme.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistarOpreme
{
    public partial class FrmViewEquipment : Form
    {   
        public List<FinanceSource> financeSources { get; set; }
        public FrmViewEquipment()
        {
            InitializeComponent();
            Employe user = FrmLogin.user;
            if(user.CheckAuthority(user.WorkPlace))
            {
                btnRecord.Visible = true;
                btnUpdate.Visible = true;
            }
        }

        private void FrmViewEquipment_Load(object sender, EventArgs e)
        {
            var equipmentRecords = EquipmentRecordRepository.GetEquipmentRecords();
            financeSources = FinanceSourceRepository.GetFinanceSources();
            dgvEquipmentRecords.DataSource = equipmentRecords;
            cboFinanceSource.DataSource = financeSources;
            dgvEquipmentRecords.Columns["Id"].DisplayIndex = 0;
            dgvEquipmentRecords.Columns["Name"].DisplayIndex = 1;
            dgvEquipmentRecords.Columns["Type"].DisplayIndex = 2;
            dgvEquipmentRecords.Columns["Description"].DisplayIndex =3;
            dgvEquipmentRecords.Columns["ProjectName"].DisplayIndex = 4;
            dgvEquipmentRecords.Columns["Finance_Source"].DisplayIndex = 5;
            dgvEquipmentRecords.Columns["ProcessingDate"].DisplayIndex = 6;
            dgvEquipmentRecords.Columns["Shopper"].DisplayIndex = 7;
            dgvEquipmentRecords.Columns["Recipient"].DisplayIndex = 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Hide();
            FrmRecordEquipment frmRecordEquipment = new FrmRecordEquipment(false);
            frmRecordEquipment.ShowDialog();
            Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRecordEquipment frmRecordEquipment = new FrmRecordEquipment(true);
            frmRecordEquipment.ShowDialog();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var equipmentRecords = EquipmentRecordRepository.GetEquipmentByFinanceSource(((FinanceSource)cboFinanceSource.SelectedItem).Id);
            dgvEquipmentRecords.DataSource = equipmentRecords;
        }

        private void cboFinanceSource_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
