using DBLayer;
using RegistarOpreme.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistarOpreme.Repositories
{
    public class EquipmentRecordRepository
    {
        public static void CreateRecord(string name, string type, string project, string description, int financeSource, int shopper, int recipient,string processingDate)
        {
            string sql = $"INSERT INTO EquipmentRecords (Name,Type,Description,Project_name,FinanceSource,Processing_date,Shopper,Recipient) VALUES ('{name}','{type}','{description}','{project}','{financeSource}','{processingDate}','{shopper}','{recipient}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }


   
}
