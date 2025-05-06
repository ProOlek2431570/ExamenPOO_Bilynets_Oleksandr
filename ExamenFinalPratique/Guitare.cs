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
        public Guitare() : base("Guitare", 6)
        {
            int choix = random.Next(1, 4);

            if (choix == 1)
                Nom += typeG.Acoustique;
            else if (choix == 2)
                Nom  += typeG.Basse;
            else Nom += typeG.Electrique;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}
