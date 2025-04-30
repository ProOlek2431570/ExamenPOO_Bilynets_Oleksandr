using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    public class Simulateur
    {
        Musicien musicien;

        public Simulateur()
        {
            Musicien musicien = new Musicien("Oleksandr Bilynets", 1, "Guitare", 1000);

            Console.WriteLine(musicien) ;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
