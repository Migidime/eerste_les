namespace opdr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int geboorte;


            Console.WriteLine("wat is mijn lievelings getal?");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                if (number == 2)
                {
                    Console.WriteLine("das mijn favoriete getal");
                    break;
                }
                else
                {
                    Console.WriteLine($"ehh nummer {number} fout!");
                    Console.WriteLine("probeer het nog een keer");
                    number = int.Parse(Console.ReadLine());
                }
            }
            
        }
    }
}
