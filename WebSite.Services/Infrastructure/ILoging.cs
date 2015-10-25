using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Services.Infrastructure
{
    public interface ILoging
    {
        string LogFileName { get; set; }
        StreamWriter StreamWriter { get; set; }

        bool Open();
        string Log(string message);
        bool Close(string filename);
    }
}
