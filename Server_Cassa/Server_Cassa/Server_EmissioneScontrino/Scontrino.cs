using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Cassa.Server_EmissioneScontrino
{
    class Scontrino
    {

        private DateTime _oraData;
        private int _numeroProgressivo;
        private float _totale;
        private int _puntiAcquisiti;

        public Scontrino(DateTime oraData, int numeroProgressivo, float totale, int puntiAcquisiti)
        {
            _oraData = oraData;
            _numeroProgressivo = numeroProgressivo;
            _totale = totale;
            _puntiAcquisiti = puntiAcquisiti;
        }

        public DateTime OraData { get => _oraData; set => _oraData = value; }
        public int NumeroProgressivo { get => _numeroProgressivo; set => _numeroProgressivo = value; }
        public float Totale { get => _totale; set => _totale = value; }
        public int PuntiAcquisiti { get => _puntiAcquisiti; set => _puntiAcquisiti = value; }
    }
}
