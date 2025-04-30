using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    public class Violon : InstrumentACordes
    {
        Random random = new Random();
        public Violon(string nom, int prixAchat) : base(nom, prixAchat)
        {

            List<string> noms = new List<string> { "Guarneri", " Stradivarius", " Amati ", " Giuseppe " };
            foreach (var item in noms[random.Next(0, 4)])
                nom = $"Violon + {item}";

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
