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

        public FinanceSource Finance_Source { get; set; }

        public string ProcessingDate { get; set; }            

        public Employe Shopper { get; set; }

        public Employe Recipient { get; set; }


        public override string ToString()
        {
            return Id + " " + Name + " " + Type;
        }
    }
}
