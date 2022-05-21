using DBLayer;
using RegistarOpreme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistarOpreme.Repositories
{
    public class EquipmentRecordRepository
    {
        public static void CreateRecord(EquipmentRecord eq)
        {
            string sql = $"INSERT INTO EquipmentRecords (Name,Type,Description,Project_name,FinanceSource,Processing_date,Shopper,Recipient) VALUES ({eq.Name},{eq.Type} , {eq.Description}, {eq.ProjectName},{eq.FinanceSource},{eq.ProcessingDate}, {eq.Shopper} , {eq.Recipient}  )";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            
        }
    }
}
