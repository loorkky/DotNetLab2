using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ExtendedDictionary<int, string, string> dict = new
            ExtendedDictionary<int, string, string>();
            dict.Add(1, "Anton", "Gnom");
            dict.Add(2, "Anton", "Pos");
            dict.Add(3, "Anton", "Fartuk");
            dict.Add(1, "Stus", "Ilya");
            dict.Add(4, "Anton", "Muzik");
            dict.Add(5, "Ivan", "Ugar");
            dict.Print();
            Console.WriteLine("-------------------------");
            dict.Remove(5);
            dict.Print();
            Console.WriteLine("-------------------------");
            dict.ExistKey(4);
            dict.ExistKey(5);
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Dict count of elements: {dict.Count()}");
            Console.WriteLine("--------------------------");
            dict.ExistValues("Anton", "Fartuk");
            dict.ExistValues("Anton", "Boss");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"dict[4] = {dict[4].value1} - {dict[4].value2}");
            Console.WriteLine("--------------------------");

            foreach (var i in dict)
            {
                Console.WriteLine($"Key: {i.key}--{i.value1}--{i.value2}");
            }
            Console.WriteLine("==========================");
            ExtendedDictionary<int, string, double> dict2 = new
            ExtendedDictionary<int, string, double>();
            dict2.Add(1, "Anton", 1);
            dict2.Add(2, "Anton", 1);
            dict2.Add(3, "Anton", 1);
            dict2.Add(1, "Stus", 1);
            dict2.Add(4, "Dmitry", 1);
            dict2.Add(5, "Anton", 1);
            dict2.Print();
            Console.WriteLine("--------------------------");
            dict2.Remove(5);
            dict2.Print();
            Console.WriteLine("--------------------------");
            dict2.ExistKey(4);
            dict2.ExistKey(5);
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Dict count of elements: {dict2.Count()}");
            Console.WriteLine("--------------------------");
            dict2.ExistValues("Anton", 1);
            dict2.ExistValues("Anton", 7);
            Console.WriteLine("--------------------------");
            Console.WriteLine($"dict[4] = {dict2[4].value1} - {dict2[4].value2}");
            foreach (var i in dict2)
            {
                Console.WriteLine($"Key: {i.key}--{i.value1}--{i.value2}");
            }
        }
    }
}