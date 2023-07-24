
namespace CHallengeAPP
{
    internal class Supervisor : IEmployee
    {
        string IEmployee.Name => "Zenon";
        string IEmployee.Surname => "Maj";

        private List<float> grade = new List<float>();

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grade.Add(100);
                    break;
                case "5":
                    this.grade.Add(80);
                    break;
                case "4":
                    this.grade.Add(60);
                    break;
                case "3":
                    this.grade.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.grade.Add(35);
                    break;
                case "2+":
                case "+2":
                    this.grade.Add(25);
                    break;
                case "2":
                    this.grade.Add(20);
                    break;
                case "1":
                    this.grade.Add(0);
                    break;
                default:
                    throw new Exception("Wrong number");
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grade.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        void IEmployee.AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        Statistics IEmployee.GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}

