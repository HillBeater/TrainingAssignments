using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConvertNumToWords
{
    internal class ConvertClass                          //525205
    {
        public int number;
        string lakh, thousand, hundred, ones;
        private static String[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static String[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public void ConvertToWord()
        {
            if (number >= 100000)
            {

                int rem = number % 100000;
                int lakhnum = rem *100000;
                
                int tempNum = number / 100000;
                lakh = words[tempNum];
                if(rem==0)
                {
                    Console.WriteLine(lakh + " Lakhs " + " Only.");
                }
               
                else
                {
                    tempNum = 0;
                    int rem1 = rem % 10000;
                    int rem2 = rem1 % 1000;
                    tempNum = (rem / 10000);
                    int tempNum2 = (rem1 / 1000);
                    if (tempNum == 0 || tempNum==1)
                    {
                        if (tempNum == 1)
                        {
                            tempNum2 = tempNum2 + 10;
                        }
                        thousand = words[tempNum2] + " Thousand ";
                    }
                    else if (tempNum2 == 0)
                    {
                        thousand = tens[tempNum] + " Thousand ";
                    }
                    else
                    {
                        thousand = tens[tempNum] + " " + words[tempNum2] + " Thousand ";
                    }
                    tempNum2 = 0;
                    rem = 0;
                    rem = rem2 % 100;
                    tempNum2 = (rem2 / 100);

                    hundred = words[tempNum2] + " Hundred ";
                    ones = words[rem];
                    Console.WriteLine(lakh + " Lakhs "  + thousand + hundred + ones + " Only.");
                }


            }
            else
            {
                if (number >= 1000 && number < 100000)
                {
                   
                        int rem1 = number % 10000;
                    
                    int rem2 = rem1 % 1000;
                    int tempNum = (number / 10000);
                    int tempNum2 = (rem1 / 1000);
                   
                    if (tempNum2 == 0)
                    {
                        thousand = tens[tempNum] + " Thousands ";
                    }
                    else
                    {
                        thousand = tens[tempNum] + " " + words[tempNum2] + " Thousands ";
                    }

                    if (rem2 == 0)
                    {
                        //Console.WriteLine(thousand + "Only.");
                    }
                    else
                    {
                        tempNum2 = 0;

                        int rem = rem2 % 100;
                        tempNum2 = (rem2 / 100);

                        hundred = words[tempNum2] + " Hundreds ";
                        ones = words[rem];
                        Console.WriteLine(thousand + hundred + ones + " Only.");
                    }



                }
                else
                {
                    if (number >= 100 && number < 1000)
                    {
                        int rem = number % 100;
                        int tempNum2 = (number / 100);
                        if(rem == 0)
                        { }
                        hundred = words[tempNum2] + " Hundred ";
                        ones = words[rem];
                        if (rem == 0)
                        {
                            //Console.WriteLine(hundred + "only");
                        }
                        else
                        {
                            tempNum2 = 0;
                            rem = number % 100;
                            tempNum2 = (number / 100);

                            hundred = words[tempNum2] + " Hundred ";
                            ones = words[rem];
                            Console.WriteLine(hundred + ones + " Only.");
                        }

                    }
                    else
                    {
                        if (number >= 10 && number < 100)
                        {
                            int rem = number % 10;
                            int tempNum2 = (number / 10);
                            if (rem == 0) { }
                            ones = tens[tempNum2];
                            if (rem == 0)
                            {
                                //Console.WriteLine(ones + " Only.");
                            }
                            else
                            {
                                tempNum2 = 0;
                                rem = number % 12;
                                tempNum2 = (number / 10);
                                ones = words[rem];
                            }
                        }
                    }

                }



            }

        }



    }
}
