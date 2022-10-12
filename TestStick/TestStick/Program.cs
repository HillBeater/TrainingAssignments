using System;
namespace pattern
{
    class sticks
    {
        static void Main(string[] args)
        {
            int size, i, small;
            Console.WriteLine("Enter size of array:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] stick_count = new int[10];
            int[] small_collect = new int[10];
            //suppose max array is 10
            int zero = 0;
            int j = 0;
            int count;
            while (zero != size)
            {
                zero = 0;
                if (arr[0] != 0)
                {
                    small = arr[0];
                }
                else
                {
                    small = int.MaxValue;
                }
                //To get the count
                for (i = 0; i < size; i++)
                {
                    if (small > arr[i] && arr[i] != 0)
                    {
                        small = arr[i];
                    }
                }
                count = 0;
                //Deduct the small from each non zero element
                for (i = 0; i < size; i++)
                {
                    if (i < i + 1)
                    {
                        if (i == 0 || i == size - 1)
                        {
                            if (arr[i] == 0)
                            {
                                Console.Write("_ ");
                            }
                            else
                            {
                                Console.Write(arr[i] + " ");
                            }
                        }
                        else
                        {
                            if (arr[i] == 0)
                            {
                                Console.Write(" _ ");
                            }
                            else
                            {
                                Console.Write(" " + arr[i] + " ");
                            }
                        }
                        if (i == size - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                    if (arr[i] != 0)
                    {
                        count++;
                        arr[i] = arr[i] - small;
                        small_collect[j] = small;
                    }
                    else
                    {
                        zero++;
                    }
                }
                stick_count[j] = count;
                j++;
            }
            Console.WriteLine("\nLength-of-cut sticks-of-cut");
            for (i = 0; i < size; i++)
            {
                if (stick_count[i] != 0)
                {
                    Console.WriteLine("\t" + small_collect[i] + "\t\t" + stick_count[i]);
                }
            }
        }
    }
}