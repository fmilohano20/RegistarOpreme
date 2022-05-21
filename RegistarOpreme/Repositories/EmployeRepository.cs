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
    public class EmployeRepository
    {

        public static Employe GetEmploye(string username)
        {
            string sql = $"SELECT * FROM Employes WHERE Username = '{username}'"; 
            return FetchEmploye(sql);
        }
        public static Employe GetEmploye(int id)
        {
            string sql = $"SELECT * FROM Employes WHERE Id = '{id}'";
            return FetchEmploye(sql);
        }

        public static Employe FetchEmploye(string sql)
        {
            DB.SetConfiguration("fmilohano20_DB", "fmilohano20", "U^(q{5Oi");
            Employe employe = null;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {

                reader.Read();
                employe = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return employe;

        }

        public static List<Employe> GetEmployes()
        {
            DB.SetConfiguration("fmilohano20_DB", "fmilohano20", "U^(q{5Oi");
            List<Employe> employes = new List<Employe>();
            string sql = "SELECT * FROM Employes";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while(reader.Read())
            {
                Employe employe = CreateObject(reader);
                employes.Add(employe);
            }
            DB.CloseConnection();

            return employes;
        }

        private static Employe CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["First_name"].ToString();
            string lastName = reader["Last_name"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            string workplace = reader["Work_place"].ToString();

            var employe = new Employe
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
                WorkPlace = workplace
            };
            

            return employe;
        }
    }
}
