using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Cassa.Server_EmissioneScontrino
{
    class CartaFedelta
    {
        private int _codiceCarta;
        private int _punti;

        public CartaFedelta(int codiceCarta, int punti)
        {
            _codiceCarta = 12345;
            _punti = 0;
        
        }

        public int punti
        {
            get { return _punti; }
            set { _punti = value; }
        }

        public int codiceCarta
        {
            get { return _codiceCarta; }
            set { _codiceCarta = value; }
        }

    }
}
