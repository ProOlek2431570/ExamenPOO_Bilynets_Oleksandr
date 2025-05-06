using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{

    public class Violon : InstrumentACorde
    {
        Random random = new Random();
        public Violon() : base("",4)
        {
            List<string> noms = new List<string> { "Guarneri", " Stradivarius", " Amati ", " Giuseppe " };
            Nom = $"Violon + {noms[random.Next(0, 4)]}";           
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
