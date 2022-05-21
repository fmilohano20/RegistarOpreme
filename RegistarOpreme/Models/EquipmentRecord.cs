using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistarOpreme.Models
{
    public class EquipmentRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string ProjectName { get; set; }

        public FinanceSource FinanceSource { get; set; }

        public string ProcessingDate { get; set; }            // maybe wrong LOOK OUT FOR DATA PARSING/CONVERSION

        public Employe Shopper { get; set; }

        public Employe Recipient { get; set; }
    }
}
