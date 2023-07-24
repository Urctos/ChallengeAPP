using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHallengeAPP
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        Statistics GetStatistics();
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(long grade);
        void AddGrade(char grade);
    }
}
