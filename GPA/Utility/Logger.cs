using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace GPA.Utility
{
    public class Logger : ILogger
    {
        private readonly string path = @"C:\Users\hp\Documents\Results\Log";
        private readonly string filePath = @"C:\Users\hp\Documents\Results\Log\Log.txt";
        DirectoryInfo directory;
        public Logger()
        {
            directory = new DirectoryInfo(path);
            if (!directory.Exists)
                directory.Create();
        }
        public void Logs(string message)
        {



            var fileName = new FileInfo(filePath);


            using (StreamWriter writer = new StreamWriter(fileName.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite)))
            {
                writer.WriteLine($"** {DateTime.Now} --------------------------------------------------------------------------------------------------");
              
                writer.WriteLine($"{message}\n\n");



                writer.Close();
            }
        }
    }
}