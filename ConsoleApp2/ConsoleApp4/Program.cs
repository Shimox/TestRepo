using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            int[,] numberGrid = new int[10, 10];
            int width = 10;
            int height = 10;
            for(int y=0; y<height; y++)
            {
                for(int x=0; x<width; x++)
                {
                    numberGrid[x, y] = (x+1) * (y+1);
                    Console.Write(numberGrid[x, y] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
