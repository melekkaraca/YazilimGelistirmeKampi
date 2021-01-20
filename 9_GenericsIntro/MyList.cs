using System;
using System.Collections.Generic;
using System.Text;

namespace _9_GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList() //Constructor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //veriler kaybolmasın diye geçici bir array e aktarıyoruz
            items = new T[items.Length + 1]; //yeni eklenen eleman için yer açıyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // geçici arraydekileri asıl array e geri ver
            }
            items[items.Length - 1] = item; //eleman sayısının -1 i son index i verir
        }
        public int Count { get { return items.Length; } }
    }
}
