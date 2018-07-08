using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_GestoreNegozio
{
    interface IGestioneNegozio
    {

        string[] getStatistiche(string inizio, string fine);

        string[] getReportMensile(string mese);

    }
}
