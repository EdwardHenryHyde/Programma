using Server_Login.GestioneLogin;
using System;
using System.Collections.Generic;
using System.IO;
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
                    var culture = new System.Globalization.CultureInfo("it-IT");
                    var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
                    var mese = culture.DateTimeFormat.GetMonthName(DateTime.Today.Month);

                    using (StreamWriter w = File.AppendText(@"../../../../Server_GestoreSicurezza/Server_GestoreSicurezza/bin/Debug/Logs/" + day + " " + DateTime.Now.Day + " " + mese + " " + DateTime.Now.Year + ".txt"))
                    {
                        w.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "@Accesso da parte di: '" + username + "'@" + "Server_Login");
                    }
                    return "ok";
                }
            }

            return "errore";
        }

        public void aggiornaLogin()
        {
            gestoreLogin.aggiornaLogin();
        }
    }
}
