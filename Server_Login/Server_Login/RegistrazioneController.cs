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

            using (StreamWriter w = File.AppendText(@"Log.txt"))
            {
                w.WriteLine(DateTime.Now.ToString() + "@Creato utente '"+nome + "' '" + cognome + "'@" + "Server_EmissioneScontrino");
            }

            return username+":"+password;
        }


    }
}
