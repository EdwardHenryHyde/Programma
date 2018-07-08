using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_AmministratoreInventario
{
    interface IGestioneInventario
    {
        void aggiungiProdotto();

        void modificaProdotto();

        void eliminaProdotto();
    }
}
