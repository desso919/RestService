using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceInterfaces
{
    public interface IAllergyService
    {
         string getAllAllergies();

         Boolean AddNewAllergy(string allergy);

    }
}
