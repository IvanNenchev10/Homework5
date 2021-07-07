using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication138
{
    class Program
    {
        static string CreateString(string text)
        {
            Console.WriteLine("Enter text:");
            text = Console.ReadLine();
            return text;
        }
        static string[] Split(string[] array,string text)
        {
            array = text.Split(' ',',');
            return array;
        }
        static void Print(string[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
        }
        static void Main()
        {
            string[] array = null;
            string text = null;
            text = CreateString(text);
            array = Split(array, text);
            Print(array);
            
        }
    }
}
