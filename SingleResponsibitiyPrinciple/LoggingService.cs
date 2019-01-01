using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibitiyPrinciple
{
    public class LoggingService
    {
        public void LogMessage()
        {
            // Log the event of successful email delivery.
            const string filePath = @"D:\IDGLog.txt";
            const string message = "Email sent successfully!";

            using (var streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
