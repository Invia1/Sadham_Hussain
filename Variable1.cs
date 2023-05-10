using System;
class Person
{
    readonly int Id;
    double salary;
    string name;
    static string address;
    static readonly int lwp;

    const int eyear = 1999;

    public Person(int id, string n, double s)
    {         //local variables .  function k parameters ka variables.

        this.Id = id;
        this.name = n;
        this.salary = s;
    }

    public void ChangeDetails(string n, double s)
    {
        this.name = n;
        this.salary = s;

    }

    public void display()
    {
        Console.WriteLine(Id + " " + name + " " + salary);
    }
    public static void Main()
    {
        person obj = new person(101, "Sadham", 10000); //Parameterised contsructor.
        obj.display();
        obj.ChangeDetails("Mahiii", 20000);
        obj.display();

        person obj1 = new person(102, "Ayush", 7000);
        obj1.display();
        // obj1.ChangeDetails("dePak",50000);




    }
}