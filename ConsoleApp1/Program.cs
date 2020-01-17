using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new List<int> { 23, 24, 25 };
            myArray.Add(26);
            myArray.Remove(24);
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
            string myStringFunction(string yourString)
            {
                string ThisString = yourString.Replace("NAME", "EDWIN")
                                                .ToLower();
                return ThisString;
            }
            Console.WriteLine(myStringFunction("I AM NAME, NAME IS IMPORTANT IN LIFE NAME ME."));
        }
    }
}
