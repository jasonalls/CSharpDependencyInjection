using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDependencyInjection.Contracts;

namespace CSharpDependencyInjection.Logging
{
    internal class FileLogger : IErrorLogger
    {
        public void LogMessage(Exception ex)
        {
            var folderPath = ConfigurationManager.AppSettings["ErrorFolder"];
            if (!(Directory.Exists(folderPath)))
            {
                Directory.CreateDirectory(folderPath);
            }
            var objFileStrome = new FileStream(folderPath + "errlog.txt", FileMode.Append, FileAccess.Write);
            var objStreamWriter = new StreamWriter(objFileStrome);
            objStreamWriter.Write("Message: " + ex.Message);
            objStreamWriter.Write("StackTrace: " + ex.StackTrace);
            objStreamWriter.Write("Date/Time: " + DateTime.Now.ToString(CultureInfo.InvariantCulture));
            objStreamWriter.Write("============================================");
            objStreamWriter.Close();
            objFileStrome.Close();
        }
    }
}
