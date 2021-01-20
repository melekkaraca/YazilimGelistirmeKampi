using System;

namespace _9_GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Count);
            isimler.Add("Melek");
            Console.WriteLine(isimler.Count);
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
