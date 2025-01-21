namespace Test_2
{
    internal class Matrix
    {
        static void asd(string[] args)
        {
            int[,] matrix =
            {
             {1, 2, 3, 4},
             {5, 6, 7, 8},
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine(matrix[row, col]);
                }
            }
        }
    }
}
