using Server_Login.GestioneLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Login
{
    class LoginController
    {

        string[] loginFile;
        GestoreLogin gestoreLogin = new GestoreLogin();

        public LoginController()
        {
            loginFile = System.IO.File.ReadAllLines(@"Login.txt");
        }

        public string verificaCredenziali(string username, string password)
        {
            if(username.Length > 1)
            {
                if (gestoreLogin.verificaCredenziali(username, password))
                {
                    return "ok";
                }
            }

            return "errore";
        }
    }
}
