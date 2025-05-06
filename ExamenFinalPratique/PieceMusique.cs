using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    public enum Difficulte
    {
        Facile, 
        Moyen,
        Difficile 
    }

    public class PieceMusique
    {
        Random random = new Random();
        string Nom { get; set; }
        Difficulte NiveauDiff { get; set; }
        int QuantiteExp { get; set; }
        int NiveauMin { get; set; }
        int Prix { get; set; }
        

        public PieceMusique()
        {
            string[] noms = {
            "Alice", "Benjamin", "Chloé", "David", "Émilie",
            "François", "Gabriel", "Hélène", "Isabelle", "Julien",
            "Karine", "Lucas", "Marie", "Nicolas", "Océane",
            "Paul", "Quentin", "Raphaël", "Sophie", "Thomas",
            "Ulysse", "Valérie", "William", "Xavier", "Yasmine",
            "Zoé", "Amélie", "Bruno", "Clara", "Dylan"
            };

            Nom = noms[ Program.rand.Next(noms.Length) ];
            NiveauDiff = (Difficulte)Program.rand.Next(0, 3);
            DeterminerExpRecu();
            DeterminerNivMin();
            DeterminerPrix();
        }

        public PieceMusique(Difficulte diff)
        {
            string[] noms = {
            "Alice", "Benjamin", "Chloé", "David", "Émilie",
            "François", "Gabriel", "Hélène", "Isabelle", "Julien",
            "Karine", "Lucas", "Marie", "Nicolas", "Océane",
            "Paul", "Quentin", "Raphaël", "Sophie", "Thomas",
            "Ulysse", "Valérie", "William", "Xavier", "Yasmine",
            "Zoé", "Amélie", "Bruno", "Clara", "Dylan"
            };

            Nom = noms[Program.rand.Next(noms.Length)];
            NiveauDiff = diff;
            //sont déterminer par la difficulte
            DeterminerExpRecu();
            DeterminerNivMin();
            DeterminerPrix();
        }

        public void GagnerExp()
        {
            if (NiveauDiff == Difficulte.Facile)
            {
                QuantiteExp = random.Next(10, 31);
                NiveauMin = 1;
                Prix = 200;
            }
            if (NiveauDiff == Difficulte.Moyen)
            {
                QuantiteExp = random.Next(60, 81);
                NiveauMin = 2 % 3;
                Prix = 400;
            }
            if (NiveauDiff == Difficulte.Difficile)
            {
                QuantiteExp = random.Next(100, 151);
                NiveauMin = 4 % 5;
                Prix = 600;
            }
        }

        private void DeterminerExpRecu()
        {
            if (NiveauDiff == Difficulte.Facile)
                QuantiteExp = Program.rand.Next(10, 31);

            if (NiveauDiff == Difficulte.Moyen)
                QuantiteExp = Program.rand.Next(60, 81);

            if (NiveauDiff == Difficulte.Difficile)
                QuantiteExp = Program.rand.Next(100, 151);
        }

        private void DeterminerNivMin()
        {
            if (NiveauDiff == Difficulte.Facile)
                NiveauMin = 1;

            if (NiveauDiff == Difficulte.Moyen)
                NiveauMin = Program.rand.Next(2, 4);

            if (NiveauDiff == Difficulte.Difficile)
                NiveauMin = Program.rand.Next(4, 5);

        }

        private void DeterminerPrix()
        {
            if (NiveauDiff == Difficulte.Facile)
                Prix = 200;

            if (NiveauDiff == Difficulte.Moyen)
                Prix = 400;

            if (NiveauDiff == Difficulte.Difficile)
                Prix = 600;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}