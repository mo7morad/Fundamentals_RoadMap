using System;
using System.Collections;
using System.Collections.Generic;


namespace IListImplementation
{
    using System;

    public class SimpleList<T> : IList<T>
    {
        private List<T> _items = new List<T>();


        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }


        public int Count => _items.Count;
        public bool IsReadOnly => false;

        public void Add(T item) => _items.Add(item);
        public void Clear() => _items.Clear();
        public bool Contains(T item) => _items.Contains(item);
        public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
        public int IndexOf(T item) => _items.IndexOf(item);
        public void Insert(int index, T item) => _items.Insert(index, item);
        public bool Remove(T item) => _items.Remove(item);
        public void RemoveAt(int index) => _items.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();
    }


    class Program
    {
        static void Main(string[] args)
        {
            SimpleList<string> myList = new SimpleList<string>();
            myList.Add("First");
            myList.Add("Second");
            myList.Insert(1, "Inserted");


            Console.WriteLine("List after adding and inserting:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }


            myList.RemoveAt(1); // Removes "Inserted"
            myList[0] = "Updated First"; // Update the first item


            Console.WriteLine("\nList after removing and updating:");
            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < myList.Count; i++)
            {

                Console.WriteLine(myList[i]);

            }

            Console.ReadKey();

        }
    }

}
