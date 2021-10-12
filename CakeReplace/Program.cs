using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cake = "The c4ke i3 4 l1e";
            string fullname = $"{cake}".ToLower();
            fullname = fullname.Replace('4', 'a');
            fullname = fullname.Replace('1', 'i');
            fullname = fullname.Replace('3', 's');
            Console.WriteLine(fullname);
        }
    }
    }

