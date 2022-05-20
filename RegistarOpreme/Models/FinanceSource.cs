using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistarOpreme.Models
{
    public class FinanceSource
    {
        public int Id { get; set; }
        public string FinanceType { get; set; }

        public float Money { get; set; }
        public override string ToString()
        {
            return FinanceType;
        }

 
    }

    
}
