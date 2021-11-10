using System.Collections.Generic;

namespace CGPA
{
    public interface ICalculate
    {
        int TotalCourseUnit { get; set; }
        int TotalQualityPoint { get; set; }

        void Gpa(List<Course> course);
        void QualityPoint(List<Course> courses);
    }
}