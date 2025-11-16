using System;
using System.Collections.ObjectModel;


class Program
{
    static void Main()
    {
        // Creating an ObservableCollection of strings
        ObservableCollection<string> names = new ObservableCollection<string>();


        // Adding items to the collection
        names.Add("Alice");
        names.Add("Bob");
        names.Add("James");
        names.Add("Jack");



        // Displaying items
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();
    }
}