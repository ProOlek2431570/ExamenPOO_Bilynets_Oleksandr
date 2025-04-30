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

    public class Guitare : InstrumentACordes
    {
        Random random = new Random();
        public Guitare(string nom, int prixAchat) : base(nom, prixAchat)
        {
            if (random.Next(1, 4) == 1)
                nom += typeG.Acoustique;
            else if (random.Next(0, 3) == 2)
                nom += typeG.Basse;
            else nom += typeG.Electrique;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}
