using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Cassa.Server_EmissioneScontrino
{
    interface IEmettiScontrino
    {
        int getCodiceCartaFedelta(CartaFedelta cartaFedelta);

        string getCodiceProdotto();

        string aggiungiProdotto();

        bool verificaPagamento();

        void aggiungiPunti(int punti, CartaFedelta cartaFedelta);

        float getPrezzo(int codiceProdotto);

        float getPrezzoScontato(int codiceProdotto);

        float getTotale(Scontrino scontrino);

    }
}
