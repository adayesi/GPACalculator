using GPA;
using GPA.Services;
using System;
using System.Collections.Generic;
namespace CGPA
{
    class Program
    {       

        static void Main(string[] args)
        {
            GlobalConfig.Instantiate();
            var user = GlobalConfig.UI;
            var log = GlobalConfig.Logger;
            try
            {
                user.Register();
            }catch(Exception e)
            {
               
                log.Logs($"error{e.Message}");
            }
            
            user.Display();
 
        }
    }
}

