using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Allergy
    {
        public long AllergyId { get; set; }
        public string AllergyName { get; set; }

        public void Map(Hospital.Database.Allergy other)
        {
            AllergyId = other.allergy_id;
            AllergyName = other.allergy1;
        }
    }
}
