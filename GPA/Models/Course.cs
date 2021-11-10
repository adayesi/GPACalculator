using GPA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGPA
{
    public class Course
    {
        public string CourseCode { get; set; }
        public byte CourseUnit { get; set; }
        public int CourseScore { get; set; }
        public char GradeType { get; set; }
        public int QualityPoint { get; set;}
        public byte Unit { get; set; }

      
        public Course(string courseCode, byte courseUnit, int courseScore)
        {
            CourseCode = courseCode;
            CourseUnit = courseUnit;
            CourseScore = courseScore;
           
        }
    }
}
