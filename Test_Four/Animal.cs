using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Four
{
    abstract class Animal : IAnimal

    {

        private string name;



        protected Animal(string name)

        {

            Name = name;

        }



        public string Name

        {

            get { return name; }

            private set

            {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))

                {

                    throw new ArgumentException("Name can't be null or empty!");

                }

                name = value;

            }

        }



        public string Type { }



        public void Perform()

        {

            Console.WriteLine($">>> {this.MakeNoise()}");

            Console.WriteLine($">>> {this.MakeTrick()}");

        }



        public override string ToString()

        {

            return base.ToString();

        }

    }
}
