using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceInterfaces
{
    public interface IDoctorService
    {
        List<Doctor> getDoctor(string doctor_id);
    }
}
