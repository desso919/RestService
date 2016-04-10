using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceInterfaces
{
    public interface IClinicService
    {
        List<HospitalModel> getHospital(string hospital_id);
    }
}
