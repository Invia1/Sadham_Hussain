using Health.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Health.Model;
using Health.Class;

namespace Health.InterFace
{
     interface Interface1   //Using Interface .
    {
        int addpatient(Patient temp);
        List<Patient> display(); 

        void updatepatient(int id);  //Abstact method for update  the pateint list.


    }
}