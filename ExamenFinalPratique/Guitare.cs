using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    enum typeG
    {
        Acoustique,
        Basse,
        Electrique
    }

    public class Guitare : InstrumentACorde
    {
        Random random = new Random();
        public Guitare(string nom, int nbCorde) : base(nom, nbCorde)
        {
            int choix = random.Next(1, 4);

            if (choix == 1)
                nom += typeG.Acoustique;
            else if (choix == 2)
                nom += typeG.Basse;
            else nom += typeG.Electrique;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}
