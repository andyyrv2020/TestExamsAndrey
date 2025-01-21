namespace Test_2
{
    internal class papai
    {
        static void lapai(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); //.toArray()

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            List<int> sum5 = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens.Add(nums[i]);
                }

                if (SumDigits(nums[i]) % 10 == 5) //[i], вътре във FOR цикъла
                {
                    sum5.Add(nums[i]);
                }
                if (nums[i] % 2 != 0) // сменя се на if от else 
                { //{

                    odds.Add(nums[i]);
                }
            }

            Console.WriteLine(String.Join(", ", evens));
            Console.WriteLine(String.Join(", ", odds));
            Console.WriteLine(String.Join(", ", sum5)); //вътре в main-a 
        }

        public static int SumDigits(int number)
        {
            int sum = 0;

            while (number != 0) //number != 0
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}