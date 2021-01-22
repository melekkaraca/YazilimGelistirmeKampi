using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_Odev5_Generics_Dictionary
{
    public class MyDictionary<TKey, TValue>
    {
        KeyValuePair<TKey, TValue>[] items;
        public MyDictionary()
        {
            items = new KeyValuePair<TKey, TValue>[0];
        }
        public void Add(TKey key, TValue value)
        {
            if (items.Select(x=>x.Key).Contains(key) == false)
            {
                KeyValuePair<TKey, TValue>[] tempTuples = items;
                items = new KeyValuePair<TKey, TValue>[items.Length + 1];
                for (int i = 0; i < tempTuples.Length; i++)
                {
                    items[i] = tempTuples[i];
                }
                items[items.Length - 1] = KeyValuePair.Create(key, value);
            }
        }
        //public int Count { get { return items.Length; } }
    }
}
