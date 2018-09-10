using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();

            int repeatIndex = 1;
            while(repeatIndex > 0)
            {
                Console.WriteLine("\nVälj vad du vill göra:\n  0. Avsluta program\n  1. Addera tal\n  2. Gissa intervall för slumpmässigt tal");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        repeatIndex = 2;
                        while (repeatIndex > 1)
                        {
                            Console.WriteLine("\nAnge de två tal du vill addera:");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("+");
                            int Y = Convert.ToInt32(Console.ReadLine());
                            int Sum = Add(X, Y);
                            Console.WriteLine("=\n" + Sum + "\n");
                            MenuChoice();
                            repeatIndex = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 2:
                        repeatIndex = 2;
                        while (repeatIndex > 1)
                        {
                            Console.WriteLine("\nAnge ett intervall (1-100):");
                            int intervalLow = Convert.ToInt32(Console.ReadLine());
                            int intervalHigh = Convert.ToInt32(Console.ReadLine());
                            int RandomInt = RNG.Next(1, 100);

                            if (RandomInt >= intervalLow && RandomInt <= intervalHigh)
                            {
                                Console.WriteLine("Det slumpade talet blev " + RandomInt + " vilket är inom det angivna intervallet.\n");
                            }
                            else
                            {
                                Console.WriteLine("Det slumpade talet blev " + RandomInt + " vilket inte är inom det angivna intervallet.\n");
                            }

                            MenuChoice();
                            repeatIndex = Convert.ToInt32(Console.ReadLine());
                        }

                        break;


                    default:
                        Console.WriteLine("\nFelinmatning.\n");
                        break;
                }
            }
            

        }

        public static int Add(int ValueX, int ValueY)
        {
            return ValueX + ValueY;
        }

        public static void MenuChoice()
        {
            Console.WriteLine("Välj vad du vill göra:\n  0. Stäng programmet\n  1. Tillbaka till menyn.\n  2. Kör igen.");
        }
    }
}
