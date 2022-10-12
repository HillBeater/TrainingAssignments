using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInWords
{
     class ConvertWord
    {
        public int hours;
        public int minutes;

        public void ConvertToWord()
        {
            string[] numbersInWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", " twenty-one", "Twenty-two", "Twenty-three", "Twenty-four", "Twenty-five", "Twenty-six", "Twenty-seven", "Twenty-eight", "Twenty-nine", "Thirty" };

            if (minutes == 0)
            {
                Console.WriteLine(hours + ":" + minutes + "-> " + numbersInWord[hours] + " o' clock ");
            }
            else if (minutes == 1)
            {
                Console.WriteLine(hours + ":" + minutes + "-> " + "one minute past " + numbersInWord[hours]);
            }
            else if (minutes == 15)
            {
                Console.WriteLine(hours + ":" + minutes + "-> " + "quarter past " + numbersInWord[hours]);
            }
            else if (minutes == 30)
            {
                Console.WriteLine(hours + ":" + minutes + "-> " + "half past " + numbersInWord[hours]);
            }
            else if (minutes == 45)
            {
                Console.WriteLine(hours + ":" + minutes + "-> " + "quarter to " + numbersInWord[(hours % 12) + 1]);
            }
            else if (minutes == 59)
            {
                Console.WriteLine(hours + ":" + minutes + "-> " + "one minute to " + numbersInWord[(hours % 12) + 1]);
            }
            else if (minutes <= 30)
            {
                Console.WriteLine(hours + ":" + minutes + "-> " + numbersInWord[minutes] + " minutes past " + numbersInWord[hours]);
            }
            else if (minutes > 30)
            {
                Console.WriteLine(hours + ":" + minutes + "-> " + numbersInWord[60 - minutes] + " minutes to " + numbersInWord[(hours % 12) + 1]);
            }
        }

        
    }
  
}
