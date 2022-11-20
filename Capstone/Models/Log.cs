﻿using System;
using System.IO;

namespace Capstone.Models
{/// <summary>
 /// A static class to Write Logs of application 
 /// </summary>
    public static class Logger
    {
        public static void WriteToLog(string msg)
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "Log.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(directory, fileName), true))
                {
                    sw.WriteLine(msg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops, Something Wrong happened, Logging failed");
            }
        }
    }
}
