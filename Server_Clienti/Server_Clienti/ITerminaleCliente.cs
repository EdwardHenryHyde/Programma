using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Clienti
{
     interface ITerminaleCliente
    {
        string[] getElencoScontrini();

        List<Premio> getPremiDisponibili();

        void getPremio();

        void diminuisciPunti();
    }
}
