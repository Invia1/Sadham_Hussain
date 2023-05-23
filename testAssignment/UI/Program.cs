﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Health.Class;
using Health.InterFace;
using Health.Model;

namespace Health.UI
{
    public class Program
    {
        public static void Main()                              //Main  method of a Programme
        {
            Interface1 detail = new normalMedicine();         //obj of the class normalMedicine in the  class  Folder
            Interface1 detail1 = new Surgeon();              // obj of the class surgeon in the  class  Folder
            Interface1 detail2 = new Ortho();               //obj of the class Ortho in the  class  Folder
            int a;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Press 1 for O.P.D");
                Console.WriteLine("Press 2 for Surgeon");
                Console.WriteLine("Press 3 for Ortho");
                Console.WriteLine("------------------------------------------------");

                Console.WriteLine("Enter Your Treatment Choice....");
                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Press 1 For Registration for O.P.D..");
                            Console.WriteLine("Press 2 For Patient list of O.P.D...");
                            Console.WriteLine("Press 3 for Update Patient List of O.P.D");
                            Console.WriteLine("-----------------------------------------");
                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();
                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientID = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.FirstName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.LastName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.ContactNo = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.Gender = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.Age = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.Address = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.AdharNo = Convert.ToDouble(Console.ReadLine());



                                    detail.addpatient(obj);
                                    break;


                                case 2:
                                    detail.display();
                                    break;

                                case 3:
                                    Console.WriteLine(" enter Paitent  Id for Update Data ");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    detail.updatepatient(id);
                                    break;



                                default:
                                    Console.WriteLine("Enter UR valid  Choice . ");
                                    break;


                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("1 For Add Patient of Dental..");
                            Console.WriteLine("2 For Display Patient list of Dental..");
                            Console.WriteLine("3 for Update Patient List of Dental");
                            Console.WriteLine("----------------------------------------------------------");

                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();
                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientID = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.FirstName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.LastName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.ContactNo = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.Gender = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.Age = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.Address = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.AdharNo = Convert.ToDouble(Console.ReadLine());

                                    detail1.addpatient(obj);
                                    break;
                                case 2:
                                    detail1.display();
                                    break;

                                case 3:
                                    Console.WriteLine("To update te  the patient please enter Registration id");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    detail.updatepatient(id);
                                    break;
                                default:
                                    Console.WriteLine("Enter valid choice ");
                                    break;


                            }

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Enter 1 For Add Patient of Ortho..");
                            Console.WriteLine("Enter 2 For Display Patient list of Ortho..");
                            Console.WriteLine("Press 3 for Update Patient List of Ortho");
                            Console.WriteLine("---------------------------------------------------");

                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();
                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientID = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.FirstName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.LastName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.ContactNo = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.Gender = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.Age = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.Address = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.AdharNo = Convert.ToDouble(Console.ReadLine());


                                    detail2.addpatient(obj);
                                    break;
                                case 2:
                                    detail2.display();
                                    break;

                                case 3:
                                    Console.WriteLine("To update te  the patient please enter Registration id");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    detail.updatepatient(id);
                                    break;

                                default:
                                    Console.WriteLine("Enter valid choice ");
                                    break;
                            }
                            break;
                        }


                }

            }
            string ch;   
            Console.WriteLine("Do you want to Continue ? Enter 'Y' for Yes...Otherwise Press 'N'");
            ch = Console.ReadLine();
            if (ch == "Y" || ch == "y")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
        }
    }

}