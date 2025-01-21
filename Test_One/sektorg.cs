namespace Test_1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            string sector = Console.ReadLine();//; липсва

            int row = int.Parse(Console.ReadLine());

            int col = int.Parse(Console.ReadLine());

            double totalSum = 0;

            switch (sector)// не е декларирана коя променлива да се използва

            {



                case "Sector A":

                    totalSum = GetTotalProfit(row, col, 11.60);

                    Console.WriteLine($"{sector} profit is {totalSum:f2} lv."); //на всеки case се добавя writeline с параметри

                    break; //липсва break;

                case "Sector B":

                    totalSum = GetTotalProfit(row, col, 14.50); //; липсва

                    Console.WriteLine($"{sector} profit is {totalSum:f2} lv.");

                    break;

                case "Sector C":

                    totalSum = GetTotalProfit(row, col, 16.10);

                    Console.WriteLine($"{sector} profit is {totalSum:f2} lv.");

                    break;

                case "Sector D": //липсва :

                    totalSum = GetTotalProfit(row, col, 8.40);

                    Console.WriteLine($"{sector} profit is {totalSum:f2} lv.");

                    break;



            }

            static double GetTotalProfit(int row, int col, double price)

            {

                return row * col * price;

            }

        }

    }

}