using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    public class InstrumentACorde 
    {
        string Nom {  get; set; }
        public int PrixAchat { get; set; }

        public Corde Corde { get; set; }
        public int NbCorde { get; set; }    

        //TODO : remettre la constructeur protected
        public InstrumentACorde(string nom,int nbCorde) : base()
        {
            Nom = nom;
            Corde = new Corde();
            PrixAchat = Corde.Resistance * 200;
            NbCorde = nbCorde;
        }

        public InstrumentACorde VerifierInstrument(InstrumentACorde instrument1, InstrumentACorde instrument2)
        {
            InstrumentACorde meilleurInstrument;
            if (instrument1 > instrument2) { meilleurInstrument = instrument1; }
            else { meilleurInstrument = instrument2; }
            return meilleurInstrument;
        }


        //TODO => Mettre tous les propriétés dans le ToString
        public override string ToString()
        {
            return $"L'instrument à cordes: {Nom}, a le prix d'achat de {PrixAchat} $";
        }

        public static bool operator >(InstrumentACorde instrument1, InstrumentACorde instrument2)
        {
            return instrument1.Corde.Resistance > instrument2.Corde.Resistance;
        }

        public static bool operator <(InstrumentACorde instrument1, InstrumentACorde instrument2)
        {
            return instrument1.Corde.Resistance < instrument2.Corde.Resistance;
        }
    }
}
