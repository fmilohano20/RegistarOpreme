using RegistarOpreme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data.SqlClient;

namespace RegistarOpreme.Repositories
{
    public class FinanceSourceRepository
    {
        
        public static FinanceSource GetFinanceSource(int id)
        {
            DB.SetConfiguration("fmilohano20_DB", "fmilohano20", "U^(q{5Oi"); // Important!
            FinanceSource financeSource = null;
            string sql = $"SELECT * FROM FinanceSources WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if(reader.HasRows)
            {
                reader.Read();
                financeSource = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();

            return financeSource;

        }
      
        public static List<FinanceSource> GetFinanceSources()
        {
            DB.SetConfiguration("fmilohano20_DB", "fmilohano20", "U^(q{5Oi"); // Important!
            List<FinanceSource> financeSources = new List<FinanceSource>();
            string sql = "SELECT * FROM FinanceSources";
            DB.OpenConnection();
            
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {   
               FinanceSource financeSource = CreateObject(reader);
               financeSources.Add(financeSource);
            }
            reader.Close();
            DB.CloseConnection();

            return financeSources;

        }
      

        private static FinanceSource CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string finance_type = reader["Finance_type"].ToString();
            float money = float.Parse(reader["Money"].ToString());

            var financeSource = new FinanceSource
            {
                Id = id,
                FinanceType = finance_type,
                Money = money
            };

            return financeSource;
        }
    }
}
