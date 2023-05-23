using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Health.InterFace;
using Health.Model;
using Health.UI;

namespace Health.Class
{
   public class normalMedicine : Interface1                    //class normal Medicine for oPd students .
    {
        
        Patient obj = new Patient();                          //Object of the Pateint .
        List<Patient> list = new List<Patient>();            //using list  from pateint class to hold the patient data.

        public int addpatient(Patient patient)             //addPateint is a method  to add a patient in list .
        {
            list.Add(patient);
            return 1;
        }



        public List<Patient> display()
        {
            if (list.Count > 0)    //list count of Pateint
            {
                foreach (Patient pat in list)       //using For Each loop for Each Pateint  details add.
                {
                    Console.WriteLine("Patient ID:" + pat.PatientID);
                    Console.WriteLine("Patient First Name:" + pat.FirstName);
                    Console.WriteLine("Patient Last Name:" + pat.LastName);
                    Console.WriteLine("Patient Contact number:" + pat.ContactNo);
                    Console.WriteLine("Patient Age:" + pat.Age);
                    Console.WriteLine("Patient Address:" + pat.Address);
                    Console.WriteLine("Patient AadharNo:" + pat.AdharNo);
                    Console.WriteLine("Patient Speciality:" + pat.Speciality);
                    Console.WriteLine();
                }

            }

            else        //else Part  if there is no data available in the List Of the Pateint.
            {
                Console.WriteLine("No data");
            }
            return list;
        }

        public void updatepatient(int id)               //Method to Update the Data .
        {
            List<Patient> list = display();

            foreach (Patient pat in list)               // For each data fro  Patient List .
            {
                if (pat.PatientID == id)
                {
                    Console.WriteLine("First Name");
                    pat.FirstName = Console.ReadLine();
                    Console.WriteLine("Last Name");
                    pat.LastName = Console.ReadLine();
                    Console.WriteLine("Contact Number");
                    pat.ContactNo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("age");
                    pat.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Gender");
                    pat.Gender = Console.ReadLine();
                    Console.WriteLine("Adhar No");
                    pat.AdharNo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Address");
                    pat.Address = Console.ReadLine();
                    Console.WriteLine("Consultant");
                    pat.Speciality = Console.ReadLine();

                }
            }

        }

    }

    class Surgeon : Interface1              //class for Surgeon case
    {
        Patient obj = new Patient();
        List<Patient> list = new List<Patient>();

        public int addpatient(Patient patient)      //adding a Pateint in pateint list
        {
            list.Add(patient);
            return 1;
        }



        public List<Patient> display()
        {
            if (list.Count > 0)
            {
                foreach (Patient pat in list)
                {
                    Console.WriteLine("Patient ID:" + pat.PatientID);
                    Console.WriteLine("Patient First Name:" + pat.FirstName);
                    Console.WriteLine("Patient Last Name:" + pat.LastName);
                    Console.WriteLine("Patient Contact number:" + pat.ContactNo);
                    Console.WriteLine("Patient Age:" + pat.Age);
                    Console.WriteLine("Patient Address:" + pat.Address);
                    Console.WriteLine("Patient AadharNo:" + pat.AdharNo);
                    Console.WriteLine("Patient Speciality:" + pat.Speciality);
                    Console.WriteLine();
                }


            }

            else
            {
                Console.WriteLine("No data");
            }
            return list;
        }
        public void updatepatient(int id)  //Methdod to update the List 
        {
            List<Patient> list = display();

            foreach (Patient pat in list)
            {
                if (pat.PatientID == id)
                {
                    Console.WriteLine("First Name");
                    pat.FirstName = Console.ReadLine();
                    Console.WriteLine("First Name");
                    pat.LastName = Console.ReadLine();
                    Console.WriteLine("Contact Number");
                    pat.ContactNo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("age");
                    pat.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Gender");
                    pat.Gender = Console.ReadLine();
                    Console.WriteLine("Adhar No");
                    pat.AdharNo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Address");
                    pat.Address = Console.ReadLine();
                    Console.WriteLine("Consultant");
                    pat.Speciality = Console.ReadLine();

                }
            }

        }

    }

    class Ortho : Interface1
    {
        Patient obj = new Patient();
        List<Patient> list = new List<Patient>();

        public int addpatient(Patient patient)
        {
            list.Add(patient);
            return 1;
        }



        public List<Patient> display()
        {
            if (list.Count > 0)
            {
                foreach (Patient pat in list)
                {
                    Console.WriteLine("Patient ID:" + pat.PatientID);
                    Console.WriteLine("Patient First Name:" + pat.FirstName);
                    Console.WriteLine("Patient Last Name:" + pat.LastName);
                    Console.WriteLine("Patient Contact number:" + pat.ContactNo);
                    Console.WriteLine("Patient Age:" + pat.Age);
                    Console.WriteLine("Patient Age:" + pat.Gender);
                    Console.WriteLine("Patient Address:" + pat.Address);
                    Console.WriteLine("Patient AadharNo:" + pat.AdharNo);
                    Console.WriteLine("Patient Speciality:" + pat.Speciality);
                    Console.WriteLine();
                }


            }

            else
            {
                Console.WriteLine("No data");
            }
            return list;
        }

        public void updatepatient(int id)
        {
            List<Patient> list = display();

            foreach (Patient pat in list)
            {
                if (pat.PatientID == id)
                {
                    Console.WriteLine("First Name");
                    pat.FirstName = Console.ReadLine();
                    Console.WriteLine("First Name");
                    pat.LastName = Console.ReadLine();
                    Console.WriteLine("Contact Number");
                    pat.ContactNo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("age");
                    pat.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Gender");
                    pat.Gender = Console.ReadLine();
                    Console.WriteLine("Adhar No");
                    pat.AdharNo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Address");
                    pat.Address = Console.ReadLine();
                    Console.WriteLine("Consultant");
                    pat.Speciality = Console.ReadLine();

                }
            }

        }

    }
}

