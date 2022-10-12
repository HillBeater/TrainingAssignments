using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            
            str = Console.ReadLine();

            int length = str.Length; //Length of string      subStr=f   result=f taa i

            string resultStr = string.Empty;

            string subStr = null;

            for (int i = 0; i < length; i++)
            {
                char cha= str[i];

                if (i == 0)
                {
                    subStr = subStr + str[i];
                }
                else if (cha == ' ')
                {
                    resultStr = subStr + ' ' + resultStr;
                    subStr = null;
                }
                else if(i == length - 1)
                {
                    subStr = subStr + str[i];
                    resultStr = subStr + ' ' + resultStr; 
                }
                else
                {
                    subStr = subStr + str[i];
                }

            }
            Console.WriteLine(resultStr);
            Console.ReadLine();
        }
        
    }
}
