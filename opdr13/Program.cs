using System.Threading.Channels;

namespace opdr13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("voor 5 getalen in pls");
            }


            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("voer getal " + (i + 1) + " in:");
                bool isValidInput = false;
                while (!isValidInput)

                    try
                    {

                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                        isValidInput = true;
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Ongeldige invoer. Voer een geldig getal in:");
                    }
            }
                Console.WriteLine("dit zijn uw getallen:");
                for (int i = 0; i < numbers.Length; i++)

                    Console.WriteLine(numbers[i]);
            
        }
    }
}
