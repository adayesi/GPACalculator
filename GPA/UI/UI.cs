using CGPA;
using GPA.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace GPA
{
    public class UI : IUI
    {
        ICalculate calculate;
        List<Course> courses;
        IGradetype grade;
        ILogger log;

        public UI(ICalculate _calculate, IGradetype gradetype, ILogger _log)
        {
            calculate = _calculate;
            grade = gradetype;
            log = _log;
            courses = new List<Course>();

        }

        //int totalQualityPoint = 0;
        // int totalCourseUnit = 0;
        string courseCode = "";
        public void Register()
        {

            int count = 0;
            Console.Write("Enter number of course(s) offered: ");
            string numberOfCourses = Console.ReadLine();
            int noc = int.Parse(numberOfCourses);

            while (count < noc)
            {

                while (true)
                {
                    try
                    {
                        Console.Write("Enter Course Code: ");
                        courseCode = Console.ReadLine();

                        if (Utility.Utility.StringValidator(courseCode) == true)
                        {
                            break;
                        }
                    }
                    catch(Exception e)
                    {
                        log.Logs(e.Message);
                    }
                    
                }
                Console.Write("Enter Course Unit: ");
                string courseUnit = Console.ReadLine();


                byte unit = byte.Parse(courseUnit);
                Console.Write("Enter Course Score: ");

                string courseScore = Console.ReadLine();
                int score = int.Parse(courseScore);


                Course course = new Course(courseCode, unit, score);

                course.GradeType = grade.Grade(course.CourseScore);
                course.Unit = grade.GradeUnit(course.GradeType);
                courses.Add(course);

                count++;
            }

        }




        public void Display()
        {
            var sb = new StringBuilder();
            sb.Append("|---------------|-------------|-------|------------|");
            sb.Append("\n");
            sb.Append("| COURSE & CODE | COURSE UNIT | GRADE | GRADE UNIT |");
            sb.Append("\n");
            sb.Append("|---------------|-------------|-------|------------|");
            sb.Append("\n");
            foreach (var course in courses)
            {

                sb.Append($"| {course.CourseCode,-14}| {course.CourseUnit,-12}| {course.GradeType,-6}| {course.Unit,-11}|");
                sb.Append("\n");


            }
            sb.Append("|---------------|-------------|-------|------------|");
            sb.Append("\n");

            Console.WriteLine(sb.ToString());
            calculate.Gpa(courses);

        }
    }
}
