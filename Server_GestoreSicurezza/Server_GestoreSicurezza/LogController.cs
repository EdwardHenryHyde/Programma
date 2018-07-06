using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_GestoreSicurezza
{
    class LogController : ILog
    {

        string[] files;

        public LogController()
        {

            files = Directory.GetFiles("Logs");

        }

       

        public string[] getEntry(string data)
        {

            if (files.Contains(data + ".txt"))
            {
                return System.IO.File.ReadAllLines(@"" + data + ".txt");
            }

            return null;
        }

        public string show()
        {
            throw new NotImplementedException();
        }

    }
}
