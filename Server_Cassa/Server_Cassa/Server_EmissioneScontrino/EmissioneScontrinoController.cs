using Server_Cassa.LetturaProdotto;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Cassa.Server_EmissioneScontrino
{
    class EmissioneScontrinoController : IEmettiScontrino
    {

        string[] prodotti;
        string[] clienti;
        int prodIndex;
        Lettura letturaProdotto = new LetturaProdotto.Lettura();

        public EmissioneScontrinoController()
        {
            
            //CREARE I FILE ED INSERIRE IL PERCORSO CORRETTO
            clienti = System.IO.File.ReadAllLines(@"Clienti.txt");
            prodIndex = 0;
        }

        public string aggiungiProdotto()
        {

            return letturaProdotto.leggi();
            
        }


        public string getNomeFromIdCarta(int idCarta)
        {

            foreach (string line in clienti)
            {
                //INSERIRE COME INDICE DELL'ARRAY LA POSIZIONE ESATTA DI QUELLO CHE CI SERVE NEL FILE CLIENTI
                string[] words = line.Split(':');
                if (int.Parse(words[10]) == idCarta)
                    return words[0];

            }

            return "errore";
        }


        public void concludiScontrino(string risultato)
        {
            //INSERIRE I PERCORSI DEI FILE SCONTRINI E LOG
            using (StreamWriter w = File.AppendText(@"Scontrini.txt"))
            {
                w.WriteLine(risultato);
            }

            using (StreamWriter w = File.AppendText(@"Log.txt"))
            {
                w.WriteLine(DateTime.Now.ToString() +"@Aggiunto scontrino@" + "Server_EmissioneScontrino");
            }
        }

        public void aggiungiPunti(int punti, CartaFedelta cartaFedelta)
        {
            throw new NotImplementedException();
        }

        public int getCodiceCartaFedelta(CartaFedelta cartaFedelta)
        {
            throw new NotImplementedException();
        }

        public string getCodiceProdotto()
        {
            throw new NotImplementedException();
        }

        public float getPrezzo(int codiceProdotto)
        {
            throw new NotImplementedException();
        }

        public float getPrezzoScontato(int codiceProdotto)
        {
            throw new NotImplementedException();
        }

        public float getTotale(Scontrino scontrino)
        {
            throw new NotImplementedException();
        }

        public bool verificaPagamento()
        {
            throw new NotImplementedException();
        }
    }
}
