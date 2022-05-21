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

        public static Employe GetEmploye(int id)
        {
            Employe employe = null;
            string sql = $"SELECT * FROM Employes WHERE {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if(reader.HasRows)
            {
                reader.Read();
                employe = CreateObject(reader);
                DB.CloseConnection();
            }



            return employe;

        }

        public static List<Employe> GetEmployes()
        {
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

            Employe employe = new Employe
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
