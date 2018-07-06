using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Login
{
    interface IRegistrazione
    {

        string registra(string nome, string cognome, string dataNascita, string citta, string provincia, int CAP, string via, int telefono, string cartaidentita, string password);

        int assegnaCarta();

    }
}
