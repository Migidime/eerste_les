namespace opdr5
{
    using System;
    using System.Collections.Concurrent;

    namespace Invoer
    {
        class Program
        {
            static void Main(string[] args)
            {
                int breedte;
                int hoogte;
                int opp;


                Console.WriteLine("wat is de hoogte?");
                hoogte = int.Parse(Console.ReadLine());
                Console.WriteLine("wat is de breedte?");
                breedte = int.Parse(Console.ReadLine());
                opp = breedte * hoogte;
                Console.WriteLine($"de oppervlakte is  {opp}  !");
               
                Console.ReadLine();

               
            }
        } 
    }
}