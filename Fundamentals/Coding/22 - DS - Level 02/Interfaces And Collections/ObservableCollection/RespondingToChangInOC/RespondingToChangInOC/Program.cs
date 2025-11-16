using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        // Creating an ObservableCollection
        ObservableCollection<string> Items = new ObservableCollection<string>();
        // Subscribing to the CollectionChanged event
        Items.CollectionChanged += Items_CollectionChanged;

        // Modifying the ObservableCollection
        Items.Add("Item 1");
        Items.Add("Item 2");
        Items.Add("Item 3");

        Items.RemoveAt(1);
        Items.Insert(0, "New Item");
        Items[1] = "Replaced Item"; // Replace action
        Items.Move(0, 2); // Move action
        /*
         Explaining the .Move
         The first parameter (0) specifies the index of the item you want to move.
        The second parameter (2) specifies the index to which you want to move the item.
        In this specific case, Items.Move(0, 2); 
        means you are moving the item at index 0 (the first item) to index 2 in the collection. 
        After this operation, the item originally at index 0 will be inserted at index 2,
        and the other items will be shifted accordingly.
         */

        // Printing the Final Collection
        Console.WriteLine("\nFinal Collection:");
        foreach (var item in Items)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }

    // CollectionChanged Event Handler
    static void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        Console.WriteLine("\nCollection Changed:");
        Console.WriteLine(e.Action);
        // Handling Collection Changes
        switch (e.Action)
        {
            case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                Console.WriteLine("Added:");
                foreach (var newItem in e.NewItems)
                {
                    Console.WriteLine("- " + newItem);
                }
                break;

            case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                Console.WriteLine("Removed:");
                foreach (var oldItem in e.OldItems)
                {
                    Console.WriteLine("- " + oldItem);
                }
                break;

            case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                Console.WriteLine("Replaced:");
                foreach (var oldItem in e.OldItems)
                {
                    Console.WriteLine("- " + oldItem);
                }
                Console.WriteLine("With:");
                foreach (var newItem in e.NewItems)
                {
                    Console.WriteLine("- " + newItem);
                }
                break;

            case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                Console.WriteLine("Moved:");
                Console.WriteLine($"- From index {e.OldStartingIndex} to index {e.NewStartingIndex}");
                break;
        }
    }
}
