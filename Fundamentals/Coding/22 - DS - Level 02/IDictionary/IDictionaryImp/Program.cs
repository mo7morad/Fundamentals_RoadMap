using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleDictionaryDemo
{
    public class SimpleDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> _list = new List<KeyValuePair<TKey, TValue>>();

        public TValue this[TKey key]
        {
            get
            {
                foreach (var kvp in _list)
                {
                    if (Equals(kvp.Key, key))
                    {
                        return kvp.Value;
                    }
                }
                throw new KeyNotFoundException($"The given key '{key}' was not present in the dictionary.");
            }
            set
            {
                bool found = false;
                for (int i = 0; i < _list.Count; i++)
                {
                    if (Equals(_list[i].Key, key))
                    {
                        _list[i] = new KeyValuePair<TKey, TValue>(key, value);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    _list.Add(new KeyValuePair<TKey, TValue>(key, value));
                }
            }
        }

        public ICollection<TKey> Keys => _list.ConvertAll(kvp => kvp.Key);

        public ICollection<TValue> Values => _list.ConvertAll(kvp => kvp.Value);

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(TKey key, TValue value)
        {
            foreach (var kvp in _list)
            {
                if (Equals(kvp.Key, key))
                {
                    throw new ArgumentException("An element with the same key already exists.");
                }
            }
            _list.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return _list.Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            foreach (var kvp in _list)
            {
                if (Equals(kvp.Key, key))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public bool Remove(TKey key)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (Equals(_list[i].Key, key))
                {
                    _list.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return _list.Remove(item);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            foreach (var kvp in _list)
            {
                if (Equals(kvp.Key, key))
                {
                    value = kvp.Value;
                    return true;
                }
            }
            value = default;
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of SimpleDictionary
            var myDictionary = new SimpleDictionary<int, string>();

            // Adding elements to the dictionary
            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");
            myDictionary.Add(3, "Three");

            // Accessing an element by key
            Console.WriteLine($"Element with key 2: {myDictionary[2]}");

            // Updating an element by key
            myDictionary[2] = "Two Updated";
            Console.WriteLine($"Updated element with key 2: {myDictionary[2]}");

            // Iterating over the dictionary
            Console.WriteLine("\nIterating over the dictionary:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Demonstrate the ContainsKey and Remove functionality
            if (myDictionary.ContainsKey(3))
            {
                Console.WriteLine("\nContains key 3, removing...");
                myDictionary.Remove(3);
            }

            // Display the dictionary after removal
            Console.WriteLine("\nDictionary after removing key 3:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.ReadKey();

        }
    }

    
}
