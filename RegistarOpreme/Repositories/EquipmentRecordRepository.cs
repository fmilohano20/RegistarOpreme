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
            DB.SetConfiguration("fmilohano20_DB", "fmilohano20", "U^(q{5Oi"); // Important!
            string sql = $"INSERT INTO EquipmentRecords (Name,Type,Description,Project_name,FinanceSource,Processing_date,Shopper,Recipient) VALUES ('{name}','{type}','{description}','{project}','{financeSource}','{processingDate}','{shopper}','{recipient}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<EquipmentRecord> GetEquipmentRecords()
        {
            DB.SetConfiguration("fmilohano20_DB", "fmilohano20", "U^(q{5Oi"); // Important!
            List<EquipmentRecord> equipmentRecords = new List<EquipmentRecord>();
            string sql = "SELECT * FROM EquipmentRecords";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                EquipmentRecord equipmentRecord = CreateObject(reader);
                equipmentRecords.Add(equipmentRecord);
            }
            reader.Close();
            DB.CloseConnection();

            return equipmentRecords;



        }

        private static EquipmentRecord CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string type = reader["Type"].ToString();
            string description = reader["Description"].ToString();
            string projectName = reader["Project_name"].ToString();
            FinanceSource finance_source = FinanceSourceRepository.GetFinanceSource(int.Parse(reader["FinanceSource"].ToString()));
            string processingDate = reader["Processing_date"].ToString();
            Employe shopper = EmployeRepository.GetEmploye(int.Parse(reader["Shopper"].ToString()));
            Employe recepient = EmployeRepository.GetEmploye(int.Parse(reader["Recipient"].ToString()));

            EquipmentRecord equipmentRecord = new EquipmentRecord
            {
                Id = id,
                Name = name,
                Type = type,
                Description = description,
                ProjectName = projectName,
                Finance_Source = finance_source,
                ProcessingDate = processingDate,
                Shopper = shopper,
                Recipient = recepient
            };
            return equipmentRecord;
        }
    }




   
}
