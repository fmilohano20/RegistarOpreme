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

    
    public partial class FrmLogin : Form
    {
        public static Employe user { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            user = EmployeRepository.GetEmploye(txtUsername.Text);
            
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
             
                if (user!=null & user.CheckPassword(txtPassword.Text))
                {
                    Hide();
                    FrmViewEquipment viewEquipment = new FrmViewEquipment();
                    viewEquipment.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRecordEquipment recordEquipment = new FrmRecordEquipment();
            recordEquipment.ShowDialog();
            Close();
        }
    }
}
