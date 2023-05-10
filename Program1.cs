using System;
namespace Variables
{

    class Variables
    {

        readonly int Id;
        string Name;
        double Salary;

        // static string Address;
        // static readonly string Policies;

        const int Year= 2022;

        public Variables(int id, string name, double sal)
        {
            this.Id = id;
             this.Name = name;
            this.Salary = sal;
        }

        public void display () {

            Console.WriteLine("Employee id : " + Id + "\n" + "Employee Name :" + Name + "\n" + "Salary is : " + Salary + "\n" + "Year of Joining : " + Year);

        }

       public static void Main() {

            Variables obj = new Variables(101, "Sadham Hussain", 10000);
            obj.display();
        
        }
     }
}