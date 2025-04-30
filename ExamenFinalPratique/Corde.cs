using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    public class Corde
    {
        Random random = new Random();
        public int Resistance { get;private set; }
        int Durabilite { get; set; }

        public Corde()
        {
            Resistance = random.Next(1, 11);
            Durabilite = Resistance * 2;
        }

        public void CreerCordes(int nombre)
        {
            for (int i = 0; i < nombre; i++)
            {
                Corde corde = new Corde();
            }
            
        }
        public override string ToString()
        {
            return $"et la corde ayant la résistance de {Resistance} et durabilité de {Durabilite}";
        }
    }
}
