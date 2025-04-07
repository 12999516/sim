using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Ctel
    {
        public string num { get; set; }
        public int durata { get; set; }

        public Ctel(string num, int durata)
        {
            this.num = num;
            this.durata = durata;
        }

        public string informazioni()
        {
            return $"hai chiamato il numero {num}. la chiamata ha avuto una durata di {durata}";
        }
    }
}
