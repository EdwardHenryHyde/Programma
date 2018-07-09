using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Login
{
    class RegistrazioneController
    {
        int numCliente;
        string username;

        public RegistrazioneController()
        {
            numCliente = 100;
        }

        public string registra(string nome, string cognome, string dataNascita, string citta, string provincia, string CAP, string via, string telefono, string cartaidentita, string password)
        {

            using (StreamWriter w = File.AppendText(@"Clienti.txt"))
            {
                w.WriteLine("" + nome + ":" + cognome+":"+dataNascita+":"+citta+":"+provincia+":"+CAP+":"+via+":"+telefono+":"+cartaidentita);
            }

            using (StreamWriter w = File.AppendText(@"Login.txt"))
            {
                username = "Cliente" + numCliente;
                w.WriteLine(username+":"+password);
                numCliente++;
            }

            var culture = new System.Globalization.CultureInfo("it-IT");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            var mese = culture.DateTimeFormat.GetMonthName(DateTime.Today.Month);

            using (StreamWriter w = File.AppendText(@"../../../../Server_GestoreSicurezza/Server_GestoreSicurezza/bin/Debug/Logs/"+ day +" "+DateTime.Now.Day+" "+mese + " "+DateTime.Now.Year+".txt"))
            {
                w.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "@Creato utente '"+nome + " " + cognome + "'@" + "Server_Login");
            }


            return username+":"+password;
        }


    }
}
