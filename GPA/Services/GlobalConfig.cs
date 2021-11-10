using CGPA;
using GPA.Repository;
using GPA.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace GPA.Services
{
    public static class GlobalConfig
    {

        public static IGradetype Gradetype;
        public static ICalculate Calculate;
        public static ILogger Logger;
        public static ICRUD CRUD;
        public static IUI UI;
            

        public static void Instantiate()
        {
            Gradetype = new Gradetype();
            Calculate = new Calculate();
            Logger = new Logger();
            CRUD = new CRUD();
            UI = new UI(Calculate,Gradetype,Logger);
        }
    }
}
