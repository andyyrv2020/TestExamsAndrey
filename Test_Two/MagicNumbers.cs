﻿namespace Test_2
{
    internal class MagicNumbers
    {
        static void mara(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); //[]
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            List<int> sum5 = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && (nums[i] % 10 == 4 || nums[i] % 10 == 8)) // ||
                {
                    evens.Add(nums[i]); //[i]
                } //}

                if (nums[i] % 2 != 0 && (nums[i] % 10 == 5 || nums[i] % 10 == 7)) //if
                {
                    odds.Add(nums[i]);
                }

                if (SumDigits(nums[i]) == 15) //==
                {
                    sum5.Add(nums[i]);
                }
            }

            Console.WriteLine(String.Join(", ", evens));
            Console.WriteLine(String.Join(", ", odds)); //odds
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
            return sum; //return
        }
    }
}