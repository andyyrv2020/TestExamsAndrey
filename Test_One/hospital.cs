using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Test_1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int days = int.Parse(Console.ReadLine()); //int.Parse...

            int doctors = 7;

            int treated = 0;

            int untreated = 0;



            for (int day = 1; day <= days; day++) // оператор <=

            {

                int patientsCount = int.Parse(Console.ReadLine());

                if (day % 3 == 0 && untreated > treated) // Поправено от / на %

                {

                    doctors++;

                }



                if (patientsCount <= doctors) //оператор <=

                {

                    treated += patientsCount;

                }

                else //Нямаше {} 

                {

                    treated += doctors;

                    untreated += (patientsCount - doctors);

                }





            }

            Console.WriteLine($"Treated patients: {treated}."); //Двата CW трябва да се вкарат в main и да се добави $.

            Console.WriteLine($"Untreated patients: {untreated}.");

        }

    }

}