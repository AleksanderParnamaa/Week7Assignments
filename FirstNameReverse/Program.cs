using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma Eesnimi");
            string name = (Console.ReadLine());
            for (int i = name.Length - 1; i > -1; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
