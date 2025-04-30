using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    enum Difficulte
    {
        Facile, 
        Moyen,
        Difficile 

    }

    public class PieceMusique
    {
        Random random = new Random();
        string Nom { get; set; }
        int NiveauDiff { get; set; }
        int QuantiteExp { get; set; }
        int NiveauMin { get; set; }
        int Prix { get; set; }
        

        public PieceMusique(string nom, int niveauDiff, int quantiteExp, int niveauMin, int prix)
        {
            Nom = nom;
            NiveauDiff = niveauDiff;
            QuantiteExp = quantiteExp;
            NiveauMin = niveauMin;
            Prix = prix;

            string[] noms = {
            "Alice", "Benjamin", "Chloé", "David", "Émilie",
            "François", "Gabriel", "Hélène", "Isabelle", "Julien",
            "Karine", "Lucas", "Marie", "Nicolas", "Océane",
            "Paul", "Quentin", "Raphaël", "Sophie", "Thomas",
            "Ulysse", "Valérie", "William", "Xavier", "Yasmine",
            "Zoé", "Amélie", "Bruno", "Clara", "Dylan"
            };
        }

        public void GagnerExp()
        {
            if ((Difficulte)NiveauDiff == Difficulte.Facile)
            {
                QuantiteExp = random.Next(10, 31);
                NiveauMin = 1;
                Prix = 200;
            }
            if ((Difficulte)NiveauDiff == Difficulte.Moyen)
            {
                QuantiteExp = random.Next(60, 81);
                NiveauMin = 2 % 3;
                Prix = 400;
            }
            if ((Difficulte)NiveauDiff == Difficulte.Difficile)
            {
                QuantiteExp = random.Next(100, 151);
                NiveauMin = 4 % 5;
                Prix = 600;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}