using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_GestoreNegozio
{
    class ScontriniNegozio
    {
        List<Scontrino> scontrini;

        public ScontriniNegozio(List<Scontrino> scontrini)
        {
            this.scontrini = scontrini ?? throw new ArgumentNullException(nameof(scontrini));
        }
    }
}
