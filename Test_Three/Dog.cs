using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test_Three
{
    public class Dog
    {
        private string name;
        private int age;

        private Dog(string name, int age) //
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return name; } //
            private set { name = value; }
        }
        public int Age //
        {
            get { return age; }
            private set { age = value; }
        }
    }

}
