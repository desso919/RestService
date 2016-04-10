using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Doctor
    {
        public long DoctorId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string Specialization { get; set; }


        public void Map(Hospital.Database.Doctor other)
        {
            DoctorId = other.doctor_id;
            FirstName = other.first_name;
            SecondName = other.second_name;
            LastName = other.last_name;
            Specialization = other.specialization;
        }
    }
}
