using System;
using System.Text;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Proфgram
    {
        static void Main(string[] args)
        {
            string s = "Hello world";
            Console.WriteLine("Count of 'l':");
            Console.WriteLine($"{s.WordCount('l')}");
            Console.WriteLine("Reverse:");
            Console.WriteLine($"{s.StringReverse()}\n");
            int[] arr = new int[] { 1, 2, 3, 4, 5, 3, 2, 1 };
            Console.WriteLine(" [1,2,3,4,5,3,2,1]");
            Console.WriteLine($"Arr int Count of '1':{arr.CountElem<int>(1)}");
            double[] arr3 = new double[] { 1, 2, 3, 4, 5, 3, 2, 1 };
            Console.WriteLine($"Arr double Count of '3': {arr3.CountElem<double>(3)} ");
            string[] arr2 = new string[] { "Bloha", "Krevetka", "Jaba", "Jaba", "Pinguin" };
            string str = "Krevetka";
            Console.WriteLine($"Arr string Count of 'Krevetka': {arr2.CountElem<string>(str)} ");
            char[] arr4 = new char[] { 'o', 'a', 'o', 'a', 'q', 'w', 'e', 'r' };
            char str1 = 'q';
            Console.WriteLine($"Arr char Count of 'q': {arr4.CountElem<char>(str1)} ");
            Console.Write($"DOUBLE ARRAY\n ");
            double[] arr6 = new double[] { 1, 2, 3, 4, 5, 3, 2, 1 };
            double[] arr7 = arr6.ArrUnique<double>();
            foreach (double i in arr7)
            {
                Console.Write($"{i} ");
            }
            Console.Write($"\n");
            Console.Write($"STRING ARRAY\n");
            string[] arr8 = new string[] { "Bloha", "Krevetka", "Jaba", "Jaba", "Pinguin" };
            string[] arr9 = arr8.ArrUnique<string>();
            foreach (string i in arr9)
            {
                Console.Write($"{i} ");
            }
        }
    }
    public static class StringExtension
    {
        public static int WordCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
        public static string StringReverse(this string str)
        {
            StringBuilder s = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s.Append(str[i]);
            }
            return s.ToString();
        }
    }
    public static class ArrayExtension
    {
        public class RequireClass<TypeArr> where TypeArr : class { }
        public static int CountElem<TypeArr>(this TypeArr[] arr, TypeArr elem)
        where TypeArr : struct
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(arr[i], elem))
                {
                    count++;
                }
            }
            return count;
        }
        public static int CountElem<TypeArr>(this TypeArr[] arr, TypeArr elem,
        RequireClass<TypeArr> ignore = null) where TypeArr : class
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(arr[i], elem))
                {
                    count++;
                }
            }
            return count;
        }
        public static TypeArr[] ArrUnique<TypeArr>(this TypeArr[] arr) where
        TypeArr : struct
        {
            List<TypeArr> list = new List<TypeArr>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (list.IndexOf(arr[i]) == -1)
                {
                    list.Add(arr[i]);
                }
            }
            TypeArr[] ArrUnique = new TypeArr[list.Count];
            for (int i = 0; i < ArrUnique.Length; i++)
            {
                ArrUnique[i] = list[i];
            }
            return ArrUnique;
        }
        public static TypeArr[] ArrUnique<TypeArr>(this TypeArr[] arr,
        RequireClass<TypeArr> ignore = null) where TypeArr : class
        {
            List<TypeArr> list = new List<TypeArr>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (list.IndexOf(arr[i]) == -1)
                {
                    list.Add(arr[i]);
                }
            }
            TypeArr[] ArrUnique = new TypeArr[list.Count];
            for (int i = 0; i < ArrUnique.Length; i++)
            {
                ArrUnique[i] = list[i];
            }
            return ArrUnique;
        }
    }
}