using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Clienti
{
    class TerminaleClienteController : ITerminaleCliente
    {
        int numero;

        public TerminaleClienteController()
        {
            numero = 0;
        }

        public string[] getElencoScontrini()
        {
            if (numero % 2 == 0)
            {
                numero++;
                return System.IO.File.ReadAllLines(@"Scontrini1.txt");
            }
            else if (numero % 2 == 1)
            {
                numero++;
                return System.IO.File.ReadAllLines(@"Scontrini2.txt");
            }
            else
                return null;
        }




        public void diminuisciPunti()
        {
            throw new NotImplementedException();
        }

        

        public List<Premio> getPremiDisponibili()
        {
            throw new NotImplementedException();
        }

        public void getPremio()
        {
            throw new NotImplementedException();
        }
    }
}
