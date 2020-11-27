﻿using System.Collections.Generic;
using Hospital.Models;

namespace Hospital.Interfaces
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAllDoctor{ get; }
        //IEnumerable<Doctor> GetDoctorOnSale { get; set; }
        Doctor GetDoctorById(int doctorId);
    }
}