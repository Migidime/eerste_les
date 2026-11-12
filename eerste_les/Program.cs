namespace eerste_les
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "migidime";
            int age = 10;
            int how_old;

            how_old = 6;
            age = age + 10;
            age += 20;
            age += how_old;

           
            Console.WriteLine($"Hello migidime {name}");
            Console.WriteLine($"je bent {age} jaar oud");


        }
    }
}
