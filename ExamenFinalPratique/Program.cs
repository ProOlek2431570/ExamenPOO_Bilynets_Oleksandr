namespace ExamenFinalPratique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InstrumentACorde monInst = new InstrumentACorde("test", 4);
            Console.WriteLine(monInst);

            /*
            Simulateur simulateur = new Simulateur();
       
            Console.WriteLine("\nAppuie sur une touche pour quitter...");
            Console.ReadKey(); */
        }
    }
}
