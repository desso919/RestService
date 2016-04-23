﻿using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceInterfaces
{
    public interface IPatientService
    {
        string GetPatient(long patient_id);

        string GetPatientByUsernameAndPassword(string username, string password);

        string GetPatientByEGNAndPassword(string egn, string password);
    }
}
