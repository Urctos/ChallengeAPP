using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHallengeAPP
{
    internal class Employee
    {
        public Employee(string name, string surname, int age, int grade)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Grade = grade;



        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Grade { get; private set; }

    }
}
