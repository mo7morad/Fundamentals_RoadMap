using System;


class clsPerson
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    
  // Non Paramitarized Constructor
    public clsPerson()
    {
      Id = -1;
      Name = "Empty";
      Age= 0;
    }

    // Paramitarized Constructor
    public clsPerson(int Id, string Name, short Age)
    {
        this.Id = Id;
        this.Name = Name;
        this.Age = Age;
    }

}
internal class Program
{
    static void Main(string[] args)
    {

        clsPerson Person1 = new clsPerson(10, "Mohammed Abu-Hadhoud", 45);
        Console.WriteLine("ID:= {0}", Person1.Id);
        Console.WriteLine("Name:= {0}", Person1.Name);
        Console.WriteLine("Age:= {0}", Person1.Age);

        Console.ReadKey();


    }
}

