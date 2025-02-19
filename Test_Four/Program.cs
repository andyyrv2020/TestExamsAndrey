﻿namespace Test_Four
{

    class Program

    {

        static void Main(string[] args)

        {

            List<Cat> animals = new List<Cat>();



            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)

            {

                string[] line = Console.ReadLine().Split();

                IAnimal animal = CreateAnimal(line);

                animals.Add(animal);

            }



            string trainerName = Console.ReadLine();



            Trainer trainer = null;



            string name = Console.ReadLine();



            while (name != "End")

            {

                IAnimal current = animals.Where(a => a.Name.Equals(name)).FirstOrDefault();



                if (current == null)

                {

                    Console.WriteLine("No such name in the Database!");
                }




                else

                {

                    if (trainer == null)

                    {

                        trainer = new Trainer(trainerName, current);

                    }

                    trainer.Work(current);

                    trainer.Make();

                }



            }

        }

        private static IAnimal CreateAnimal(string[] line)

        {

            IAnimal animal = null;

            switch (line[0])

            {

                case "Cat":

                    animal = new Cat(line[1]);

                    break;

                case "Dog":

                    animal = new Dog(line[1]);

                    break;

            }

            return animal;

        }

    }
}

