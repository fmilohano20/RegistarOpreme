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
        
        private List<EquipmentRecord> equipmentRecords;
        private EquipmentRecord cheat = new EquipmentRecord();
        private bool Update_bool { get; set; } 
        
        public FrmRecordEquipment(bool update)
        {
            InitializeComponent();
            if (update)
            {
                cboSelectedItem.Visible = true;
                lblUpdateData.Visible = true;
                Update_bool = true;
                btnDelete.Visible = true;
            }
            else
            {
                cboSelectedItem.Visible = false;
                lblUpdateData.Visible = false;

            }

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
            equipmentRecords = EquipmentRecordRepository.GetEquipmentRecords();
            cheat.Name = "--Odaberi--";
            equipmentRecords.Insert(0, cheat);
            cboSelectedItem.DataSource = equipmentRecords;
            clearInput();
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
            if(financesource==0 || shopper==0 || type =="" || description=="" || name=="")
            {
                Console.WriteLine(financesource + " " + shopper + " " + type + "" + description + " " + name);
                MessageBox.Show("Obavezna polja nisu ispunjena!", "Krivi unos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (Update_bool)
                {
                    user.RecordData(name, type, project, description, financesource, shopper, recipient, cboSelectedItem.SelectedIndex);
                    MessageBox.Show("Uspiješano ažuriranje podataka!", "Ažuriranje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    user.RecordData(name, type, project, description, financesource, shopper, recipient, 0);
                    MessageBox.Show("Uspiješan unos!", "Unos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            
            
            
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
            Hide();
            FrmViewEquipment frmViewEquipment = new FrmViewEquipment();
            frmViewEquipment.ShowDialog();
            Close();
        }

        private void cboSelectedItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if(cboSelectedItem.SelectedIndex != 0)
            {
                EquipmentRecord current = equipmentRecords[cboSelectedItem.SelectedIndex];
                txtEquipmentName.Text = current.Name;
                txtEquipmentType.Text = current.Type;
                txtProjectName.Text = current.ProjectName;
                txtEquipmentDescription.Text = current.Description;

                cboFinanceSource.SelectedIndex = current.Finance_Source.Id;
                cboShopper.SelectedIndex = current.Shopper.Id;
                Update_bool = true;
            }
            else
            {   
                clearInput();
                Update_bool = false;
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmLogin.user.DeleteData(equipmentRecords[cboSelectedItem.SelectedIndex].Id);
            equipmentRecords = EquipmentRecordRepository.GetEquipmentRecords();
            cboSelectedItem.DataSource = equipmentRecords;
            MessageBox.Show("Uspiješano brisanje!", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (equipmentRecords==null)
            {
                Close();
            }

            
        }
    }
}
