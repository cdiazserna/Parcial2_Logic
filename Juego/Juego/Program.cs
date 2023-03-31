using System;

namespace Juego
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int players, nummin = 0, nummax = 0;
            int secretnum = random.Next(nummin, nummax);
            int turnplayer = 1;

            AskData(out players, nummin, nummax);
            Chancenumber(turnplayer, nummin, nummax, secretnum, players);

           

            Console.Write("\nDigite 'y' para intentarlo nuevamente o 'n' para finalizar: ");
            string newplay = Console.ReadLine();
        }

        public static void AskData(out int players, int nummin, int nummax)
        {
            do { 
            Console.WriteLine("Ingrese el número de jugadores: Minimo 2 - Máximo 4");
            players = Convert.ToInt32(Console.ReadLine());
               } while (players< 2 || players> 4);
        

            switch (players)
            {

                case 2:
                    nummax = 50;
                    break;

                case 3:
                    nummax = 100;
                    break;
                case 4:
                    nummax = 200;
                    break;

            }
        }

        public static int Chancenumber (int turnplayer, int nummin, int nummax, int secretnum, int players)

        {
            while (true)
            {
                Console.WriteLine($"Turno jugador {turnplayer}, ingrese un número entre {nummin} y {nummax}");
                int chance = Convert.ToInt32(Console.ReadLine());

                if (chance < secretnum)
                {
                    Console.Write("MAYOR");
                    turnplayer = (turnplayer % players) + 1;
                }
                else if (chance > secretnum)
                {
                    Console.Write("MENOR");
                    turnplayer = (turnplayer % players) + 1;
                }
                else
                {
                    Console.Write("¡HAS GANADO!");
                    break;
                }
                return turnplayer;
            }
        }
    }
}
