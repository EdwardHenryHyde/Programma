using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Login.GestioneLogin
{
    class GestoreLogin
    {
        string[] loginFile;

        public GestoreLogin()
        {
            loginFile = System.IO.File.ReadAllLines(@"Login.txt");
        }

        public bool verificaCredenziali(string username, string password)
        {
            foreach (string line in loginFile)
            {
                string[] words = line.Split(':');
                if (words[0].Equals(username) && words[1].Equals(password))
                    return true;
            }
            Thread.Sleep(10);
            return false;
        }
    }
}
