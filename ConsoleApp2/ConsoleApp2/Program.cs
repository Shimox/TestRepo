using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            int[] numbers = new int[5];
            for (int x = 0; x < 5; x++)
            {
                numbers[x] = RNG.Next(0, 100);

                Console.WriteLine((x + 1) + ".\t" + numbers[x]);
            }

            int loop = 1;

            while (loop == 1)
            {
                Console.WriteLine("\nVilken rad vill du byta värde på?");
                int arrayPos = Convert.ToInt32(Console.ReadLine()) - 1;
                int oldValue = numbers[arrayPos];

                Console.WriteLine("\nVad vill du att det nya värdet ska vara?");
                numbers[arrayPos] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nVärdet på potition " + (arrayPos + 1) + " har ändrats från " + oldValue + " till " + numbers[arrayPos]);
                loop = PrintArray(numbers);
            }

        }

        public static int PrintArray(int[] numbersArr)
        {
            Console.WriteLine("\nUppdaterad lista:\n");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine((x + 1) + ".\t" + numbersArr[x]);
            }
            Console.WriteLine("\nVill du fortsätta?\n1.\tJa\n2.\tNej");
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}
