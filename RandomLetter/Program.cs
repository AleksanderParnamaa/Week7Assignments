using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string name = Console.ReadLine();
            Random random = new Random();
            int index = random.Next(0, name.Length);
            Console.WriteLine($"{name[index]}");

            

              
            }
        }
    }


