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
            var recipient = EmployeRepository.GetEmployes(); ;
            cboShopper.DataSource = shopper;
            cboRecipient.DataSource = recipient;
            
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            var financesource = cboFinanceSource.SelectedIndex;
            var shopper = cboShopper.SelectedIndex;
            var recipient = cboRecipient.SelectedIndex;
            
        }
    }
}
