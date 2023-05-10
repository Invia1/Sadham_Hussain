class person
{
    static string officialAdress;
    static readonly int lwp;


    static person()
    {
    officialAdress="Lajpat Nagar";

        lwp = 2;

    }
    public static void Main()
    {
        Console.WriteLine(officialAdress);
        Console.WriteLine(lwp);

       // lwp =4;
        officialAdress = "Noida ";

        Console.WriteLine(lwp + " " +officialAdress);

    }


}