using System;
namespace Properties
{
    class person
    {
        string name;
        int empId;

        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public int EMPid
        {
            get
            {
                return empId;
            }

            set
            {
                empId = value;
            }
        }
        class company
        {
            public void display()
            {
                person obj = new person();
                obj.NAME = "ITS MAhiii";
                obj.empId = 30007;

                Console.WriteLine("NAME of the Employee = " + obj.NAME + "\n "+ "ID of the Employee is = " + obj.empId);

            }

        }
        class super
        {
            public static void Main()
            {
                company obj = new company();
                obj.display();

            }

        }

    }
}
     