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
        int id;
        string[] prodotti;
        string[] clienti;
        int prodIndex;
        Lettura letturaProdotto = new LetturaProdotto.Lettura();

        public EmissioneScontrinoController()
        {
            
            //CREARE I FILE ED INSERIRE IL PERCORSO CORRETTO
            clienti = System.IO.File.ReadAllLines(@"Clienti.txt");
            prodIndex = 0;
            id = 12345;
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

            var culture = new System.Globalization.CultureInfo("it-IT");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            var mese = culture.DateTimeFormat.GetMonthName(DateTime.Today.Month);

            using (StreamWriter w = File.AppendText(@"../../../../Server_GestoreSicurezza/Server_GestoreSicurezza/bin/Debug/Logs/" + day + " " + DateTime.Now.Day + " " + mese + " " + DateTime.Now.Year + ".txt"))
            {
                w.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "@Creato scontrino ID: '" + id + "'@" + "Server_EmissioneScontrino");
            }
            id++;
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
