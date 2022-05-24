using RegistarOpreme.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistarOpreme.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string WorkPlace { get; set; }

       public override string ToString()
        {
            return FirstName +" "+LastName;
        }

        public bool CheckPassword(string password)
        { 
            return Password == password;
        }

        public bool CheckAuthority(string workpalce)
        { 
            if(workpalce == "CIP")
                return true;
            else
                return false;
        }

        public void RecordData(string name, string type,string project, string description,int financeSource, int shopper, int recipient,int id)
        {
            string processingDate = DateTime.Now.ToString();
            if (id>0)
                EquipmentRecordRepository.UpdateRecord(name, type, project, description, financeSource, shopper, recipient, processingDate,id);
            else
                EquipmentRecordRepository.CreateRecord(name, type, project, description, financeSource, shopper, recipient,processingDate);

        }

        public void DeleteData(int id)
        {

            EquipmentRecordRepository.DeleteRecord(id);
        }

        
    }
}
