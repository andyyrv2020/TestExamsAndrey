<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };


    }
}
=======
﻿namespace Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); //int[]
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            List<int> sum5 = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && (nums[i] % 10 == 4 && nums[i] % 10 == 8))
                {
                    evens.Add(nums[i]);
                }

                else if (nums[i] % 2 != 0 && (nums[i] % 10 == 5 || nums[i] % 10 == 7))
                {
                    odds.Add(nums[i]);
                }
                if (SumDigits(nums[i]) = 15)
                {
                    sum5.Add(nums[i]);
                }
            }

            Console.WriteLine(String.Join(", ", evens));
            Console.WriteLine(String.Join(", ", evens));
            Console.WriteLine(String.Join(", ", sum5));
        }

        public static int SumDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
            
        }
    }
}

//java, c#, c
>>>>>>> 02602fa811cb70f5f0c52960b22a4a024c9e2593
