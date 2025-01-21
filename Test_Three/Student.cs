using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Three
{
    public class Student
    {
        private int id;
        private int studentId;
        private string fullName;
        public Student(string firstName, string lastName)
        {
            id++;
        }

        public string FullName
        {
            get { return fullName; }
            private set { fullName = value; }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
