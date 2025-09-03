using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionExample
{
    using System;
    using System.Collections;

   
    public class SimpleCollection<T> : ICollection<T>
    {
        private List<T> items = new List<T>();


        public int Count => items.Count;


        public bool IsReadOnly => false;


        public void Add(T item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }


        public bool Remove(T item)
        {
            return items.Remove(item);
        }


        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleCollection<string> shoppingCart = new SimpleCollection<string>();
            shoppingCart.Add("Apple");
            shoppingCart.Add("Banana");
            shoppingCart.Add("Carrot");


            Console.WriteLine($"Items in cart: {shoppingCart.Count}");

            if (shoppingCart.Contains("Banana"))
            {
                shoppingCart.Remove("Banana");
                Console.WriteLine("Banana removed from the cart.");
            }


            Console.WriteLine("Final items in the cart:");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
