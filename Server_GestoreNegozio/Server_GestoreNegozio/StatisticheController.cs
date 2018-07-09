using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_GestoreNegozio
{
    class StatisticheController : IGestioneNegozio
    {

        public string[] getStatistiche(string dataInizio, string dataFine)
        {


            if (dataInizio.Contains("marzo"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + "800";
                result[1] = "Guadagno lordo:    " + "31021";
                result[2] = "Nuovi Clienti: " + "15";
                result[3] = "N° premi corrisposti:   " + "11";
                result[4] = "Prodotto più venduto:  " + "uovo Kinder";
                return result;

            }
            else if (dataInizio.Contains("giugno"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 2780;
                result[1] = "Guadagno lordo:    " + 201299;
                result[2] = "Nuovi Clienti: " + 49;
                result[3] = "N° premi corrisposti:   " + 50;
                result[4] = "Prodotto più venduto:  " + "acqua Levissima";
                return result;

            }
            else if (dataInizio.Contains("dicembre"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 602;
                result[1] = "Guadagno lordo:    " + 35329;
                result[2] = "Nuovi Clienti: " + 19;
                result[3] = "N° premi corrisposti:   " + 73;
                result[4] = "Prodotto più venduto:  " + "pandoro Bauli";
                return result;

            }
            else
                return null;
        }

        public string[] getReportMensile(string mese)
        {

            if (mese.Equals("gennaio"))
            {
                //SCONTRINI + GUDADAGNO + CLIENTI + PREMI + PRODOTTO PIU VENDUTO
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 1237;
                result[1] = "Guadagno lordo:    " + 65000;
                result[2] = "Nuovi Clienti: " + 186;
                result[3] = "N° premi corrisposti:   " + 38;
                result[4] = "Prodotto più venduto:  " + "acqua SanBenedetto";
                return result;
            }
            else if (mese.Equals("febbraio"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 923;
                result[1] = "Guadagno lordo:    " + 42432;
                result[2] = "Nuovi Clienti: " + 91;
                result[3] = "N° premi corrisposti:   " + 15;
                result[4] = "Prodotto più venduto:  " + "pasta Barilla";
                return result;
                
            }
            else if (mese.Equals("marzo"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 1023;
                result[1] = "Guadagno lordo:    " + 50123;
                result[2] = "Nuovi Clienti: " + 111;
                result[3] = "N° premi corrisposti:   " + 20;
                result[4] = "Prodotto più venduto:  " + "acqua Levissima";
                return result;
            }
            else if (mese.Equals("aprile"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 1842;
                result[1] = "Guadagno lordo:    " + 73000;
                result[2] = "Nuovi Clienti: " + 214;
                result[3] = "N° premi corrisposti:   " + 50;
                result[4] = "Prodotto più venduto:  " + "uovo Kinder";
                return result;

            }
            else if (mese.Equals("maggio"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 1020;
                result[1] = "Guadagno lordo:    " + 38210;
                result[2] = "Nuovi Clienti: " + 42;
                result[3] = "N° premi corrisposti:   " + 10;
                result[4] = "Prodotto più venduto:  " + "latte Granarolo";
                return result;
                
            }
            else if (mese.Equals("giugno"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 940;
                result[1] = "Guadagno lordo:    " + 30212;
                result[2] = "Nuovi Clienti: " + 39;
                result[3] = "N° premi corrisposti:   " + 9;
                result[4] = "Prodotto più venduto:  " + "acqua Guizza";
                return result;
               
            }
            else if (mese.Equals("luglio"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 1023;
                result[1] = "Guadagno lordo:    " + 53200;
                result[2] = "Nuovi Clienti: " + 58;
                result[3] = "N° premi corrisposti:   " + 27;
                result[4] = "Prodotto più venduto:  " + "acqua Levissima";
                return result;

            }
            else if (mese.Equals("agosto"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 1430;
                result[1] = "Guadagno lordo:    " + 42000;
                result[2] = "Nuovi Clienti: " + 62;
                result[3] = "N° premi corrisposti:   " + 31;
                result[4] = "Prodotto più venduto:  " + "acqua Levissima";
                return result;

            }
            else if (mese.Equals("settembre"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 2190;
                result[1] = "Guadagno lordo:    " + 70212;
                result[2] = "Nuovi Clienti: " + 112;
                result[3] = "N° premi corrisposti:   " + 161;
                result[4] = "Prodotto più venduto:  " + "quaderni Pigna";
                return result;
                
            }
            else if (mese.Equals("ottobre"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 1340;
                result[1] = "Guadagno lordo:    " + 50213;
                result[2] = "Nuovi Clienti: " + 52;
                result[3] = "N° premi corrisposti:   " + 20;
                result[4] = "Prodotto più venduto:  " + "pasta Barilla";
                return result;
               
            }
            else if (mese.Equals("novembre"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 923;
                result[1] = "Guadagno lordo:    " + 42432;
                result[2] = "Nuovi Clienti: " + 91;
                result[3] = "N° premi corrisposti:   " + 15;
                result[4] = "Prodotto più venduto:  " + "prosciutto di Parma";
                return result;
                
            }
            else if (mese.Equals("dicembre"))
            {
                string[] result = new string[5];
                result[0] = "N° Scontrini emessi:    " + 1212;
                result[1] = "Guadagno lordo:    " + 72012;
                result[2] = "Nuovi Clienti: " + 80;
                result[3] = "N° premi corrisposti:   " + 91;
                result[4] = "Prodotto più venduto:  " + "pandoro Bauli";
                return result;
                
            }
            else
            {
                return null;
            }

        }

        public List<Scontrino> getScontriniIntervallo(DateTime dataInizio, DateTime dataFine)
        {
            return null;
        }

        public string[] generaStatistiche(string mese)
        {
            return null;
        }

    }
}
