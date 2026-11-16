namespace eerste_les
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "jan";
            int age = 10;
            int how_old;

            how_old = 2;
            age = age + 1;
            age += 7;
            age += how_old;

           
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"je bent {age} jaar oud correct?");


        }
    }
}
