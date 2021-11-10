using System;
using System.Collections.Generic;
using System.Text;

namespace GPA
{
    public class Gradetype : IGradetype
    {
        public char Grade(int courseScore)
        {
            char grade = 'H';
            if (courseScore <= 100 && courseScore >= 70)
                grade = 'A';
            if (courseScore <= 69 && courseScore >= 60)
                grade = 'B';
            if (courseScore <= 59 && courseScore >= 50)
                grade = 'C';
            if (courseScore <= 49 && courseScore >= 45)
                grade = 'D';
            if (courseScore <= 44 && courseScore >= 40)
                grade = 'E';
            if (courseScore <= 39 && courseScore >= 0)
                grade = 'F';
            return grade;
        }
        public byte GradeUnit(char grade)
        {
            byte gradeunit = 0;
            if (grade == 'A')
                return 5;
            if (grade == 'B')
                return 4;
            if (grade == 'C')
                return 3;
            if (grade == 'D')
                return 2;
            if (grade == 'E')
                return 1;
            if (grade == 'F')
                return 0;

            return gradeunit;
        }
    }
}
