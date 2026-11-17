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
                int leeftijd;
                int geboorte;


                Console.WriteLine("wanneer ben je geboren?");
                geboorte = int.Parse(Console.ReadLine());
                leeftijd = 2026 - geboorte;
                Console.WriteLine($"je bent  {leeftijd}  oud !");
                if (leeftijd == 18)
                {
                    Console.WriteLine("je bent even oud als mij");
                }
                Console.ReadLine();

               
            }
        } 
    }
}