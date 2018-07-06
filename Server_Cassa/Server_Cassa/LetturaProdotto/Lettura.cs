using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Cassa.LetturaProdotto
{
    class Lettura
    {
        string[] prodotti;
        int index;

        public Lettura()
        {
            prodotti = System.IO.File.ReadAllLines(@"Prodotti.txt");
            index = 0;
        }

        public string leggi()
        {
            string res = prodotti.ElementAt(index);
            index++;
            return res;
        }
    }
}
