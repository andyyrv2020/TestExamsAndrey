namespace Test_Three
{
    internal class Cigana
    {
        static void Cigan(string[] args)
        {

        }

        static double MaxNumber(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;

        }
    }
}