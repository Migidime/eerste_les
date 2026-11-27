using System.ComponentModel.Design;

namespace opdr16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          
            Console.WriteLine("geeft getal 1 getallen");
            double getal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("geeft getal 2 getallen");
            double getal2 = double.Parse(Console.ReadLine());
            double antwoord = 0;
            Console.WriteLine("kies een keuze van 1 tot 3.");
            int keuze = int.Parse(Console.ReadLine());


            switch (keuze)
            {
                case 1:
                    Console.WriteLine("je hebt het vermenigvuldigt");
                    antwoord = getal1 * getal2;

                    break;

                 case 2:
                    antwoord = getal1 - getal2;
                    break;

                case 3:
                    antwoord = getal1 / getal2;
                    break;

                default:
                    Console.WriteLine($"ik zei 1 tot en met 3 en  {keuze} ligt daar niet tussen.");
                    break;
                    


            }

            Thread.Sleep(3000);
            sayhellogetal(antwoord);
            Console.ReadLine();
        }






        static void sayhellogetal(double antwoord)
        {
            Console.WriteLine($"het antwoord is {antwoord}.");
        }
    }
}
