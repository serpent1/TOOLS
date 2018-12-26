using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace CreateGUID
{
    public class LogWriter
    {
        private string path = string.Empty;

        public LogWriter(string logMessage)
        {
            LogWrite(logMessage);
            EnsureLogFile();
        }

        public void EnsureLogFile()
        {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (!Directory.Exists(path + "\\Log"))
                Directory.CreateDirectory(path + "\\Log");
        }

        private string GetLogFileName()
        {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fileName = path + "\\Log" + "\\" + "Log_" + DateTime.Now.Date.ToString("yyyyMMdd") + ".txt";
            if (!File.Exists(fileName))
                File.Create(fileName);

            return fileName;
        }

        public void LogWrite(string logMessage)
        {
            try
            {
                using (StreamWriter w = File.AppendText(GetLogFileName()))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :{0}", logMessage);
            }
            catch (Exception ex)
            {
            }
        }

    }
}
