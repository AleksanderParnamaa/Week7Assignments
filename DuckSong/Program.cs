using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =5; i > 1; i--)

            {
                if (i != 1)
                {
                    Console.WriteLine($"{i} little ducks went swimming one day, over the hill and far away, mother duck said quack quack quack, but only {i - 1} little ducks came back");

                }

                else
                {
                    Console.WriteLine($"{i} little duck went swimming one day, over the hill and far away, mother duck said quack quack quack, but no little ducks came back");
                }
            }
            Console.WriteLine("Sad mother duck went out one day, over the hill and far away, The sad mother duck said quack quack quack quack and all of the 5 little ducks came back.");
        }
    }
}
