namespace Test_1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int days = int.Parse(Console.ReadLine()); //int

            int kgFood = int.Parse(Console.ReadLine());

            double dailyFoodFirst = double.Parse(Console.ReadLine());

            double dailyFoodSecond = double.Parse(Console.ReadLine()); // readline 

            double dailyFoodThird = double.Parse(Console.ReadLine());



            double foodNeeded = days * dailyFoodFirst + days * dailyFoodSecond + days * dailyFoodThird; // double 



            if (kgFood >= foodNeeded) // от <= на >=

            {

                Console.WriteLine($"{Math.Floor(kgFood - foodNeeded)} kilos of food left.");//$

            }

            else

            {

                Console.WriteLine($"{Math.Ceiling(foodNeeded - kgFood)} more kilos of food are needed.");//$

            }

        }

    }

}

