using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace opdr8
{
    internal class Program
    {
        static void Main(string[] args) {
            //    int name;
            //    int lucky;
            //    int appel;
            //    name = int.Parse(Console.ReadLine());
            //    lucky = int.Parse(Console.ReadLine());
            //    appel = int.Parse(Console.ReadLine());
            //    while (true)
            //        if (name == lucky)
            //        {
            //            Console.WriteLine("Gefeliciteerd, je hebt het juiste woord geraden!");
            //            break;
            //        }

            //    else if (name == appel)
            //        {
            //            Console.WriteLine("Helaas, appel is niet goed. Probeer het opnieuw.");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Helaas, dat is niet het juiste woord. Probeer het opnieuw.");

            //        }

            string invoer;

            Console.WriteLine("Geef het woord op:");
            invoer = Console.ReadLine();

            //Console.WriteLine($"Dit heb je ingevoerd: {invoer}");

            if (invoer.ToUpper() == "LUCKY")
            {
                Console.WriteLine("Dit is goed!");
            } else
            {
                Console.WriteLine("Dit is fout!");
            }
     
        }
    }
}