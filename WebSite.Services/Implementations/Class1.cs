using System;
using System.IO;
using System.Text;
using WebSite.Services.Infrastructure;

namespace WebSite.Services.Implementations
{
    public class Loging : ILoging
    {
        public string LogFileName { get; set; }
        public StreamWriter StreamWriter { get; set; }

        public Loging(string fileName)
        {
            LogFileName = fileName;
        }

        public Loging() : this(@"C:\Users\Moshe\Documents\Visual Studio 2013\Projects\WebSite\WebSite\App_Data\LogFiles\Log_App.txt") { }

        public bool Open()
        {
            try
            {
                if (!File.Exists(LogFileName))
                {
                    Directory.CreateDirectory(@"C:\Users\Moshe\Documents\Visual Studio 2013\Projects\WebSite\WebSite\App_Data\LogFiles\");
                    File.Create(LogFileName);
                }
                StreamWriter = File.AppendText(LogFileName);
                
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public string Log(string message)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Clear();
            stringBuilder.Append(string.Format("{0} : {1}", DateTime.Now, message));
            StreamWriter.WriteLine(stringBuilder);
            return stringBuilder.ToString();
        }

        public bool Close(string filename)
        {
            try
            {
                StreamWriter.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}