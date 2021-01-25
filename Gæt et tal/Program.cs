using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæt_et_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int securedNumber = r.Next(1, 11);
            int guessNumber = 0;
            while (true)
            {
                Console.WriteLine("Gæt et tal mellem 1-10");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < securedNumber)
                {
                    Console.WriteLine("Højere");
                    guessNumber++;
                    Console.WriteLine($"Du har brugt {guessNumber} forsøg");
                }
                else if (guess > securedNumber)
                {
                    Console.WriteLine("Lavere");
                    guessNumber++;
                    Console.WriteLine($"Du har brugt {guessNumber} forsøg");
                }
                else if (guess == securedNumber)
                {
                    Console.WriteLine("Godt gættet!");
                    guessNumber++;
                    Console.WriteLine($"Du gættet tallet på {guessNumber} forsøg");
                }
            }
        }
    }
}
