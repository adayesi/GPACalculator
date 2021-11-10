using System;
using System.Collections.Generic;
using System.Text;
namespace CGPA
{
    public class Calculate : ICalculate
    {
        public int TotalCourseUnit { get; set; }
        public int TotalQualityPoint { get; set; }




       
        public void QualityPoint(List<Course> courses)
        {
            TotalQualityPoint = 0;
            TotalCourseUnit = 0;
          
            foreach (Course course in courses)
            {
                TotalQualityPoint += course.CourseUnit * course.Unit;

                TotalCourseUnit += course.CourseUnit;
            }
            
        }

       

        public void Gpa(List<Course> course)
        {
           
            QualityPoint(course);

            double gpa = 0.0;

            gpa = (double)TotalQualityPoint / (double)TotalCourseUnit;

            Console.WriteLine($"Your GPA is {gpa:0.00} to 2 decimal places.");
        }

    }
}
