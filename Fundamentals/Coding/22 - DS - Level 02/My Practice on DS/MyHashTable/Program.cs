using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        // First Attempt ^_^
        public class MyHashTable<TKey, TValue>
        {
            static private short _capacity = 10;
            private object[] myHashTableArray = new object[_capacity];

            private short _myHashingFunction(TKey key)
            {
                short _index = 0;
                foreach (char character in key.ToString())
                {
                    _index += (short)character;
                }
                _index = (short)(_index % _capacity);
                return _index;
            }

            public void Add(TKey key, TValue value)
            {
                myHashTableArray[_myHashingFunction(key)] = value;
            }

            public object GetValue(TKey key)
            {
                short _valIndex = 0;
                _valIndex = _myHashingFunction(key);
                return myHashTableArray[_valIndex];
            }

            public void Remove(TKey key)
            {
                short _valIndex = 0;
                _valIndex = _myHashingFunction(key);
                myHashTableArray[_valIndex] = null;
            }
            public short GetIndex(TKey key)
            {
                return _myHashingFunction(key);
            }

            public void DisplayIndexAndValue()
            {
                for (short i = 0; i < _capacity; i++)
                {
                    if (myHashTableArray[i] != null)
                    {
                        Console.WriteLine($"Index: {i}, Value: {myHashTableArray[i]}");
                    }
                }
            }
        }

        // Second Attempt ^_^

        public class MyHashTable2<TKey, TValue>
        {
            private const int _capacity = 10;
            private List<KeyValuePair<TKey, TValue>>[] table;

            public MyHashTable2()
            {
                table = new List<KeyValuePair<TKey, TValue>>[_capacity];
                for (int i = 0; i < _capacity; i++)
                {
                    table[i] = new List<KeyValuePair<TKey, TValue>>();
                }
            }

            private int Hash(TKey key) => Math.Abs(key.GetHashCode()) % _capacity;

            public void Add(TKey key, TValue value)
            {
                int index = Hash(key);
                var bucket = table[index];

                // Collision handling Code
                for (int i = 0; i < bucket.Count; i++)
                {
                    if (bucket[i].Key.Equals(key))
                    {
                        bucket[i] = new KeyValuePair<TKey, TValue>(key, value); // Update existing
                        return;
                    }
                }

                bucket.Add(new KeyValuePair<TKey, TValue>(key, value)); // Insert new
            }

            public TValue GetValue(TKey key)
            {
                int index = Hash(key);
                var bucket = table[index];
                foreach (var kvp in bucket)
                {
                    if (kvp.Key.Equals(key))
                        return kvp.Value;
                }
                throw new KeyNotFoundException($"Key '{key}' not found.");
            }

            public void Remove(TKey key)
            {
                int index = Hash(key);
                var bucket = table[index];
                bucket.RemoveAll(kvp => kvp.Key.Equals(key));
            }

            public void Display()
            {
                for (int i = 0; i < _capacity; i++)
                {
                    Console.Write($"Index {i}: ");
                    foreach (var kvp in table[i])
                    {
                        Console.Write($"[{kvp.Key}, {kvp.Value}] ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public class HashTableWithBucket<TKey, TValue>
        {
            private static int _capacity = 20;
            private Bucket[] _entries;
            private struct Bucket
            {
                public TKey key;
                public TValue value;
                public int hashCode;
            }
            public HashTableWithBucket()
            {
                _entries = new Bucket[_capacity];
            }

            private int Hash(TKey key) => Math.Abs(key.GetHashCode()) % _capacity;

            public void Add(TKey key, TValue value)
            {
                int hashCode = Hash(key);
                _entries[hashCode].key = key;
                _entries[hashCode].value = value;
                _entries[hashCode].hashCode = hashCode;
            }

            public void DisplayAll()
            {
                foreach (Bucket item in _entries)
                {
                    if(item.key != null)
                    {
                        Console.WriteLine($"Key: {item.key}, value: {item.value}");
                    }

                }
            }
        }    


        public static void Main()
        {
            MyHashTable<string, int> trailHashTable = new MyHashTable<string, int>();
            trailHashTable.Add("Morad", 1);
            trailHashTable.Add("Mohamed", 2);
            trailHashTable.Add("Omar", 3);
            trailHashTable.Add("Manga", 4);
            trailHashTable.Add("Ali", 5);
            trailHashTable.Add("Esra", 6);

            Console.Write("The value for key: Esra Is: ");
            Console.WriteLine(trailHashTable.GetValue("Esra"));
            Console.WriteLine($"And the index of the Esra element is: {trailHashTable.GetIndex("Esra")} ");

            trailHashTable.DisplayIndexAndValue();

            // -------------------------------------------------

            Console.WriteLine("\n===== Testing MyHashTable2 (with Chaining) =====");

            MyHashTable2<string, string> hashTable2 = new MyHashTable2<string, string>();

            hashTable2.Add("Morad", "Student");
            hashTable2.Add("Ali", "Developer");
            hashTable2.Add("Omar", "Designer");
            hashTable2.Add("Laila", "Doctor");
            hashTable2.Add("Nada", "Nurse");

            // Collision test
            hashTable2.Add("Aa", "First");  // These two often collide due to .NET GetHashCode quirk
            hashTable2.Add("BB", "Second");

            // Test: Update existing key
            hashTable2.Add("Ali", "Architect"); // Should overwrite "Developer"

            // Getting the values
            Console.WriteLine($"\nValue for 'Morad': {hashTable2.GetValue("Morad")}");
            Console.WriteLine($"Value for 'Ali': {hashTable2.GetValue("Ali")}");
            Console.WriteLine($"Value for 'Aa': {hashTable2.GetValue("Aa")}");
            Console.WriteLine($"Value for 'BB': {hashTable2.GetValue("BB")}");

            hashTable2.Remove("Nada");
            Console.WriteLine("Removed 'Nada'");
            

            Console.WriteLine("\nFinal HashTable2 contents:");
            hashTable2.Display();

            // ---------------------------------------

            HashTableWithBucket<string, string> myHashBucket = new HashTableWithBucket<string, string>();

            myHashBucket.Add("Morad", "Student");
            myHashBucket.Add("Ali", "Developer");
            myHashBucket.Add("Omar", "Designer");
            myHashBucket.Add("Laila", "Doctor");
            myHashBucket.Add("Nada", "Nurse");

            Console.WriteLine("My Hashtable Bucket Elements: ");
            myHashBucket.DisplayAll();

            Dictionary<string, string> myDict = new Dictionary<string, string>();

            myDict.Add("Morad", "Student");
            myDict.Add("Ali", "Developer");
            myDict.Add("Omar", "Designer");
            myDict.Add("Laila", "Doctor");
            myDict.Add("Nada", "Nurse");

            foreach (var item in myDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
