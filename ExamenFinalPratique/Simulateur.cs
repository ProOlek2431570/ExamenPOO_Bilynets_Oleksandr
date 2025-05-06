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
        List<InstrumentACorde> listInstrument;

        public Simulateur()
        {
            musicien = new Musicien("Oleksandr Bilynets", 1, "Guitare", 1000);

            //IMPORTANT DE NE PAS OUBLIER
            listInstrument = new List<InstrumentACorde>();
            //Remplir la liste
            GenererInstrument();

            Console.WriteLine(musicien) ;
        }

        public void LancerSimulation()
        {
            //Affichage de depart du musicien // Intro
            Console.WriteLine("Bienvenue à la simulation de votre nouvelle carrière de muscien \n");
            Console.WriteLine(musicien);

            Console.ReadKey();
            Console.Clear();

            //Affichage des tous les instruments
            foreach (InstrumentACorde instrument in listInstrument)
            {
                Console.WriteLine(instrument);
            }

            //Choisir le meilleur instrument  ?!?!?!
            InstrumentACorde meilleurInstrument = listInstrument[0];

            foreach (InstrumentACorde instrument in listInstrument)
            {
                if (instrument > meilleurInstrument)
                {
                    meilleurInstrument = instrument;
                }
            }
            musicien.Instrument = meilleurInstrument;

            Console.WriteLine("\nInstrument choisi automatiquement (meilleur selon la résistance) :");
            Console.WriteLine(meilleurInstrument);
            Console.WriteLine();
            Console.ReadKey();


            //menu principale
            int choix = 0;
            do
            {
                AfficherMenu();
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(musicien);
                        break;
                    case 2:
                        Console.Clear();
                       // Pratique();
                        break;
                    case 3:
                        Console.Clear();
                       // ReparerInstrument();
                        break;
                   // case 4:
                       
                }

            } while (choix != 6);
        }

        void AfficherMenu()
        {
            Console.WriteLine("1 - Voir le statut du musicien / Instrument ");
            Console.WriteLine("2 - Pratiquer ");
            Console.WriteLine("3 - Réparer votre instrument ");
        }

        void GenererInstrument()
        {
            int nbInstrument = 5;
            for (int i = 0; i < nbInstrument; i++)
            {
                int typeIn = Program.rand.Next(2);
                if (typeIn == 0)
                    listInstrument.Add(new Violon());
                else
                    listInstrument.Add(new Guitare());
            }
        }
    }
}
