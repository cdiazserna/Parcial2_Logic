using System;

namespace Juego
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();

            int players, nummin = 0, nummax = 0;

            Console.WriteLine("Ingrese el número de jugadores: Minimo 2 - Máximo 4");
            players= Convert.ToInt32(Console.ReadLine());

            switch (players)
            {

                case 2: nummax = 50;
                    break;

                case 3:
                    nummax = 100;
                    break;
                case 4:
                    nummax = 200;
                    break;

            }

            int secretnum = random.Next(nummin, nummax);
        }
    }
}
