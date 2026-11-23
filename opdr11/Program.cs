using System.Runtime.InteropServices.JavaScript;

namespace opdr11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("kies de menu tussen 1 tot 3 (progamma afsluiten).");
                char invoer = Console.ReadKey().KeyChar;
                if (Char.IsDigit(invoer))
                    // Console.WriteLine( "juist"); break;
                   if (invoer == '1')
                    {
                        Console.WriteLine(":je hebt menu 1 gekozen.");
                        
                    }
                   else if (invoer == '2')
                    {
                        Console.WriteLine(":je hebt menu 2 gekozen.");
                        
                    }
                   else if (invoer == '3')
                    {
                        Console.WriteLine(":programma sluit af");
                        break;
                    }
                else
                {
                    Console.WriteLine(":Ongeldige keuze. Voer 1, 2 of 3 in");
                }
            }
        }
    }
}
