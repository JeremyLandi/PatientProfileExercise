﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientProfile.Models
{
    public class AilmentPerscription
    {
        public int IdAilmentPerscription { get; set; }
        public int IdAilment { get; set; }
        public int IdPatientProfile { get; set; }
    }
}