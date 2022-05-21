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
    public partial class FrmRecordEquipment : Form
    {   
        
        public FrmRecordEquipment()
        {
            InitializeComponent();
        }

        private void FrmEvidentiranjeOpreme_Load(object sender, EventArgs e)
        {
            var financeSources =  FinanceSourceRepository.GetFinanceSources();
            cboFinanceSource.DataSource = financeSources;
            var shopper = EmployeRepository.GetEmployes();
            cboShopper.DataSource = shopper;
            if(FrmLogin.user!=null)                                                             //remove
                txtRecipient.Text = FrmLogin.user.FirstName + " " + FrmLogin.user.LastName;
            cboFinanceSource.Text = "--Odaberi--";
            cboShopper.Text = "--Odaberi--";

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Employe user = FrmLogin.user;
            int financesource = cboFinanceSource.SelectedIndex;
            int shopper = cboShopper.SelectedIndex;
            int recipient = user.Id;
            string name = txtEquipmentName.Text;
            string type = txtEquipmentType.Text;
            string project = txtProjectName.Text;
            string description = txtEquipmentDescription.Text;
            user.RecordData(name,type,project,description,financesource,shopper,recipient);
            
            MessageBox.Show("Uspiješan unos!", "Unos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInput();
        }

        private void clearInput()
        {   
            txtEquipmentName.Text = "";
            txtEquipmentType.Text = "";
            txtProjectName.Text="";
            txtEquipmentDescription.Text="";
            cboFinanceSource.Text = "--Odaberi--";
            cboShopper.Text = "--Odaberi--";


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            clearInput();
            Close();
        }
    }
}
