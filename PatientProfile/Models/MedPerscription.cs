﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientProfile.Models
{
    public class MedPerscription
    {
        public int IdMedPerscription { get; set; }
        public int IdMedication { get; set; }
        public int IdPatientProfile { get; set; }
    }
}