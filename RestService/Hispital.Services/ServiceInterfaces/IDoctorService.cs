﻿using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceInterfaces
{
    public interface IDoctorService
    {
        string GetDoctor(long doctor_id);

        string GetDoctorsByHospitalId(long hospital_id);

        string GetAllDoctors();
    }
}
