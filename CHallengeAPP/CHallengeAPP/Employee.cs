﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHallengeAPP
{
    public class Employee
    {
          
        private  List<float>grade = new List<float>(); 
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        //public int Grade { get; private set; }

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
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grade.Count;         
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
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                //var value = float.Parse(grade);
                //this.AddGrade(value);
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
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


    }
}
