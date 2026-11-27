namespace opdr15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kies 2 getallen");
            int getal1 = int.Parse(Console.ReadLine());
            int getal2 = int.Parse(Console.ReadLine());

            int antwoord = getal1 + getal2;

            sayhellogetal(antwoord);
            Console.ReadLine();
        }


       
    
    

     static void sayhellogetal(int antwoord)
        {
            Console.WriteLine($"het antwoord is {antwoord}.");
        }




 }   }

