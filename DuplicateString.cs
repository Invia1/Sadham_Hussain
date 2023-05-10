using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicateString
{


    internal class person
    {
        int ID;  //private .
        string pname; //private .
        int age;


        personDetails details = new personDetails();

        public int PID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value; // value is temporary variables . is a keyword.
            }
        }

        public string PNAME
        {
            get
            {
                return pname;
            }
            set
            {
                pname = value;
            }
        }

        public int PAGE
        {
            get
            {
                return age;
            }
            set
            {
                age = value;

                if (age < 20)
                {

                    details.NotFit();
                }
                else
                {
                    details.schedule();
                }

            }

        }
    }

        class personDetails
        {
            public void schedule()

            {
                Console.WriteLine("wait for final call .");
                   
            }

            public  void NotFit()
            {
                Console.WriteLine("not Match");
            }


            public void personInfo()
            {
                person obj = new person();
                obj.PID = 101;  //set is used to access the variables .
             //   Console.WriteLine(obj.PID);

                obj.PNAME = "SADAHAM HUSSAIN";
             //  Console.WriteLine(obj.PNAME);  //set is used to access the variables .
                obj.PAGE = 21;
              // Console.WriteLine(obj.PAGE);
            }

        }
        class startup
        {
            public static void Main() 
            {

                var pdetails = new personDetails();

                pdetails.personInfo();
            Console.ReadLine();

            }
        }
}
