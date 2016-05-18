using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientProfile.Models
{
    public class Medication
    {
        public int IdMedication { get; set; }
        public string MedicationName { get; set; }
        public int MedicationPrice { get; set; }
        public string MedicationDescription { get; set; }
    }
}