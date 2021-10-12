using System;

namespace Week7Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Palun sisesta kasutajanimi");
            string UserName = Console.ReadLine();
            Console.WriteLine("Palun Sisesta Pin Kood");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number == 1234 && UserName == "Aleks")
    
            {
                Console.WriteLine($"Tere tulemast {UserName}!");
            }
           
            else
            {
                Console.WriteLine("Midagi Läks valesti proovi uuesti");
                i = i + 1;
                Console.WriteLine($"proovi uuesti {3 - i} katset jäänd");
            }
            

        }
    }
        }
    

