using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Three
{
    public class School
    {
        private List<Student> students;
        private string name;

        public School(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return Name; }
            private set { name = value; }
        }
        public void EnrollStudent(Student student)
        {
            students.Add(student);
        }
        public Student UnenrollStudent(int id)
        {
            if (this.students.Count <= 0 || id >= this.students.Count)
            {
                return null;
            }
            Student student = new Student("", "");
            if (student != null)
            {
                this.students.Remove(student);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name}:");
            foreach (var student in this.students)
            {
                sb.AppendLine();
                sb.Append(student.ToString());
            }
            return base.ToString();
        }
    }
}
