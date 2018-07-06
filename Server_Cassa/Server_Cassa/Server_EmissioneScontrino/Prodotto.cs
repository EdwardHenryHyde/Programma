using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Cassa.Server_EmissioneScontrino
{
    class Prodotto
    {

        private int _codice;
        private string _nome;
        private float _prezzo;
        private int _sconto;

        public Prodotto(int codice, string nome, float prezzo, int sconto)
        {
            _codice = codice;
            _nome = nome ?? throw new ArgumentNullException(nameof(nome));
            _prezzo = prezzo;
            _sconto = sconto;
        }

        public int Codice { get => _codice; set => _codice = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public float Prezzo { get => _prezzo; set => _prezzo = value; }
        public int Sconto { get => _sconto; set => _sconto = value; }
    }
}
