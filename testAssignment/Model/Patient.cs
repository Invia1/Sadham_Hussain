﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.Model
{
    public class Patient { // Patient class for  Pateint  Details .
   

        public int PatientID { get; set; }              //P id Props for Pateint
        public string FirstName { get; set; }           //P Name Props for Pateint
        public string LastName { get; set; }
        public double ContactNo { get; set; }           //P contact Props for Pateint
        public int Age { get; set; } = 0;               //P Age Props for Pateint

        public string Gender { get; set; }              //P gender  Props for Pateint
        public double AdharNo { get; set; }             //P Adhar  Props for Pateint

        public string Address { get; set; }             //P Address Props for Pateint

        public string Speciality { get; set; }

    }
}