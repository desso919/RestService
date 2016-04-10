using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Databse;

namespace Hospital.Models
{
    public class Patient
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime BirhtDate { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1} {2}", FirstName, SecondName, LastName); }
        }

        public void Map(Hospital.Databse.Patient other) {
            Id = other.patient_id;
            Username = other.username;
            FirstName = other.first_name;
            SecondName = other.second_name;
            LastName = other.last_name;
            Age = other.age;
            BirhtDate = other.birth_date.Value;
        }

    }

}
