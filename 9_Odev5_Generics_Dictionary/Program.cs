using System;
using System.Collections.Generic;

namespace _9_Odev5_Generics_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Melek");
            myDictionary.Add(2, "Dilek");
            myDictionary.Add(2, "abc");

           
        }
    }
}
