using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertClass convertClass = new ConvertClass();

            Console.WriteLine("Enter Number ");
            convertClass.number = int.Parse(Console.ReadLine());

            convertClass.ConvertToWord();

            Console.ReadLine(); 
        }
    }
}
