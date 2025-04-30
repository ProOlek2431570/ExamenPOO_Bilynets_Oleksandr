using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    public class InstrumentACordes : Corde
    {
        string Nom {  get; set; }
        public int PrixAchat { get; set; }

        public InstrumentACordes(string nom, int prixAchat) : base()
        {
            PrixAchat = Resistance * prixAchat;
        }

        public InstrumentACordes VerifierInstrument(InstrumentACordes instrument1, InstrumentACordes instrument2)
        {
            InstrumentACordes meilleurInstrument;
            if (instrument1 > instrument2) { meilleurInstrument = instrument1; }
            else { meilleurInstrument = instrument2; }
            return meilleurInstrument;
        }


        public override string ToString()
        {
            return $"L'instrument à cordes: {Nom}, a le prix d'achat de {PrixAchat} $";
        }

        public static bool operator >(InstrumentACordes instrument1, InstrumentACordes instrument2)
        {
            return instrument1.Resistance > instrument2.Resistance;
        }

        public static bool operator <(InstrumentACordes instrument1, InstrumentACordes instrument2)
        {
            return instrument1.Resistance < instrument2.Resistance;
        }
    }
}
