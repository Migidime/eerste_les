namespace opdr9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {

                {

                    Console.WriteLine("Kies de prijs: 1 small, 2 medium of 3 large:");
                    int keuze = int.Parse(Console.ReadLine());
                    switch (keuze)
                    {
                        case 1:
                            Console.WriteLine("Je hebt gekozen voor 1 small dus de prijs is 2 euro.");
                            break;
                        case 2:
                            Console.WriteLine("Je hebt gekozen voor 2 medium dus de prijs is 2,50 euro.");
                            break;
                        case 3:
                            Console.WriteLine("Je hebt gekozen voor 3 large dus de prijs is 3 euro.");
                            break;
                        default:
                            Console.WriteLine("kies 1 van deze 3 opties slimme.");
                            break;


                    }
                }
            }
        }
    }
}
    

    

