class personDetails
{


    string pname;

    public void changeName(string n)
    {
        pname = n;
        var name = "Rajeev";
       // name = "Vikaas";
        Console.WriteLine(name);
    }
    
    public static void Main()
    {
        var obj =new personDetails();   // aliasing of a  classname .
        obj.pname = "deepaaakkkk";

        

        Console.WriteLine("First time Name = "+ obj.pname);

        obj.changeName("Deepaak Sir");
        Console.WriteLine(obj.pname );

    }
}