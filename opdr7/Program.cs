using System.ComponentModel.Design;

namespace opdr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
               
                Console.WriteLine("Geef een getal:");

                char invoer = Console.ReadKey().KeyChar;
                if (Char.IsDigit(invoer))
                {
                    //Console.WriteLine("Is een getal!");
                    if (invoer == '2')
                    {
                        Console.WriteLine("Jeej!");
                        //Environment.Exit(0); beindigt alles 
                        break;
                    } else
                    {
                        Console.WriteLine("Jammer joh!");
                    }
                } 
                else
                {
                    Console.WriteLine("Voer eeen getal in!");
                }

            }
            Console.WriteLine("THE END!");


            
        }
    }
}
