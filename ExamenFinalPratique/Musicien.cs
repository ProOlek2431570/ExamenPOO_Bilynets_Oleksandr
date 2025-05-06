using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPratique
{
    public class Musicien
    {
        public string Nom { get; set; }
        public int Niveau { get; set; } = 1;
        public string PreferenceInstr { get; set; }
        public int MontantArgent { get; set; }
        public InstrumentACorde Instrument { get; set; }
        public List<PieceMusique> PiecesMusique { get; set; }

        public Musicien(string nom, int niveau, string preferenceInstr, int montantArgent)
        {
            Nom = nom;
            Niveau = niveau;
            PreferenceInstr = preferenceInstr;
            MontantArgent = montantArgent;
            Instrument = null;
            PiecesMusique = new List<PieceMusique>();
            PiecesMusique.Add(new PieceMusique( Difficulte.Facile));
        }

        public override string ToString()
        {
            string message = "";

            if (Instrument == null)
                message = "Vous n'avez pas d'instrument !";
            else
                message = Instrument.ToString();

            return $"Bienvenue à la simulation de votre nouvelle carrière de musicien \n" +
                $"Info Musicien\n" +
                $"Votre nom: {Nom}\n" +
                $"Instrument Préféré: {PreferenceInstr}\n" +
                $"Niveau: {Niveau} \n" +
                $"Votre montant actuel est de {MontantArgent} $\n" +
                $"{message}\n";
        }

    }
}
