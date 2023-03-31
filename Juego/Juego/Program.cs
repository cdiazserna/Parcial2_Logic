using System;

namespace Juego
{
    public class Program
    {
        static void Main(string[] args)
        {

            int players = Askdata("Ingrese el número de jugadores (entre 2 y 4): ", 2, 4);
            int nummin = 0, numax = 0;
            switch (players)
            {
                case 2:
                    numax = 50;
                    break;
                case 3:
                    numax = 100;
                    break;
                case 4:
                    numax = 200;
                    break;
            }
            int secretNum = CalcularDatos(nummin, numax);
            MostrarResultado(secretNum, players, nummin, numax);
            if (Askdata ("¿Desea jugar de nuevo? (s/n): ") == "s")
            {
                Main();
            }
        }

        static int Askdata(string mensaje, int min, int max)
        {
            int dato;
            do
            {
                Console.Write(mensaje);
                dato = Convert.ToInt32(Console.ReadLine());
            } while (dato < min || dato > max);
            return dato;
        }

        static int CalcularDatos(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        static void MostrarResultado(int secretNum, int players, int nummin, int nummax)
        {
            int turnPlayer = 1;
            while (true)
            {
                Console.Write($"Jugador {turnPlayer}, ingrese un número entre {nummin} y {nummax}: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < secretNum)
                {
                    Console.WriteLine("MAYOR");
                    turnPlayer = (turnPlayer % players) + 1;
                }
                else if (guess > secretNum)
                {
                    Console.WriteLine("MENOR");
                    turnPlayer = (turnPlayer % players) + 1;
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    break;
                }
            }
        }
    }
}
