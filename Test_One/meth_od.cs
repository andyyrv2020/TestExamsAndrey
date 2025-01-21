namespace Test_1
{
    internal class Program
    {
        static int Numbers(int x, int y) //параметри x,y в метод Numbers
        {
            return x + y; //връща стойност х + у
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(5, 3));// тук се извикват 5 + 3 и ги пресмята
        }
    }
}