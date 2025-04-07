using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Csim
    {
        private string num;
        private int saldo;
        public List<Ctel> telefonate;

        /*public Csim
            {
                this.num = "0000000000";
                saldo = 0;
                telefonate = new List<Ctel>();
            }*/

        public Csim(string num, int saldo)
        {
            this.num = num;
            this.saldo = saldo;
            telefonate = new List<Ctel>();
        }

        public void addCtel(Ctel ct)
        {
            telefonate.Add(ct);
        }

        public string cerca(string num)
        {
            string telefo = "";

            for(int i = 0; i < telefonate.Count; i++)
            {
                if (telefonate[i].num == num)
                {
                    telefo += telefonate[i].informazioni() + "\n\r";
                }
            }
            return telefo;
        }

        public string totale_minuti()
        {
            int totale = 0;
            for (int i = 0; i < telefonate.Count; i++)
            {
                totale += telefonate[i].durata;
            }
            return $"il totale delle chiamate è di {totale} minuti";
        }

        public string info()
        {
            string tele = $"il numero {num} ha un saldo di {saldo} euro\n\r";
            for(int i = 0; i < telefonate.Count; i++)
            {
                tele += telefonate[i].informazioni() + "\n\r";
            }

            return tele;
        }
    }
}
