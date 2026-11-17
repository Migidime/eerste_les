namespace opdr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer = "42";
            int getal = int.Parse(invoer);
            int resultaat = getal * 2;
            Console.WriteLine("Het dubbele is: " + resultaat);
            Console.ReadLine();
            // het getal is 84 want je doet eerste int.Parse(invoer) en dat dzorgt ervoor dat je ermee kan rekenen en daarna doe je het keer 2
        }
    }
}
