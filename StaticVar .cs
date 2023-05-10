using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StaticVar
    {
        const string Company = "Invia pvt. ltd";

        readonly int Id;
        string Ename;
        double Salary;

        //static string Address;
        //static readonly string Policies;

        public StaticVar(int id, string ename, double sal)
        {
            this.Id = id;
            this.Ename = ename;
            this .Salary = sal;

        }

        public void disp()
        {
            Console.WriteLine("Company Name : " + Company+ "\n" + "Employee ID : " + Id + "\n " + "Employee Name : " + Ename + "Employee Salary : " + Salary);

        }

        public static void Main(string[] args)
        {
            StaticVar obj = new StaticVar(101, "Sadham", 2000);
            obj.disp();
        }




    }
}

