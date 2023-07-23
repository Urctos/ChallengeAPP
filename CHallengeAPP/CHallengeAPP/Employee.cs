using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CHallengeAPP
{
    public class Employee : Person
    {

        private  List<float>grade = new List<float>();

        public Employee()
            : base()
        {
            
        }

        public Employee(string name)
            : base(name)
        {

        }

        public Employee(string name, string surname)
            : base(name, surname)
        {

        }

        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {

        }


        //public int Age { get; private set; }
        

        public float Result
        {
            get
            {
                return this.grade.Sum();
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            

            foreach(var grade in this.grade)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

            }
       
            statistics.Average = statistics.Average / this.grade.Count;
            
            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                this.grade.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");               
            }
           
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(double grade)
        {
            float result = (float)Math.Round(grade, 2);
            this.AddGrade(result);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grade.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grade.Add(80);
                    break;
                case 'C':
                case 'c':

                    this.grade.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grade.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grade.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");


            }
        }



    }
}
