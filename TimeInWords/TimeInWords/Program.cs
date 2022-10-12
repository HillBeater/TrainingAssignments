using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ConvertWord is a Class
            ConvertWord convertWord = new ConvertWord();    

            Console.WriteLine("Enter the Hours Between 1 To 12");
            convertWord.hours = int.Parse (Console.ReadLine());

            Console.WriteLine("Enter the Minutes Between 0 to 60");
            convertWord.minutes = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(convertWord.hours > 0 && convertWord.hours <= 12 && convertWord.minutes >= 0 && convertWord.minutes <= 60)
            {
                convertWord.ConvertToWord();
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
            Console.ReadLine();
        }
    }
}
