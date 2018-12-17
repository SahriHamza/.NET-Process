using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsolePremier
{
    public class Premier
    {


        public void NombresPremiers()
        {

            for (int p = 1; p < 1000000; p++)
            {
                int i = 2;
                while ((p % i) != 0 && Math.Sqrt(i) < p)
                {
                    i++;
                }
                if (i == p)
                    Console.WriteLine(p.ToString());
                Thread.Sleep(50);


            }
        }


        static public void ConsoleConfig()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetBufferSize(132, 600);
            Console.SetWindowSize(16, 32);
        }

    }
}
