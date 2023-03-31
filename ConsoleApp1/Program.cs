using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al juego de adivinanza de números!");

            bool jugarOtraVez = true;

            while (jugarOtraVez)
            {
                Console.Write("Ingrese la cantidad de jugadores (entre 2 y 4): ");
                int cantidadJugadores = int.Parse(Console.ReadLine());

                int numeroMaximo = 0;

                switch (cantidadJugadores)
                {
                    case 2:
                        numeroMaximo = 50;
                        break;
                    case 3:
                        numeroMaximo = 100;
                        break;
                    case 4:
                        numeroMaximo = 200;
                        break;
                    default:
                        Console.WriteLine("Cantidad de jugadores inválida");
                        break;
                }

                if (numeroMaximo != 0)
                {
                    Random rnd = new Random();
                    int numeroAdivinar = rnd.Next(1, numeroMaximo + 1);

                    Console.WriteLine("El número a adivinar ha sido generado. ¡Comienza el juego!");

                    bool haGanado = false;

                    int jugadorActual = 1;

                    while (!haGanado)
                    {
                        Console.Write($"Jugador {jugadorActual}, ingrese un número entre 1 y {numeroMaximo}: ");
                        int numeroIngresado = int.Parse(Console.ReadLine());

                        if (numeroIngresado < numeroAdivinar)
                        {
                            Console.WriteLine("MAYOR");
                        }
                        else if (numeroIngresado > numeroAdivinar)
                        {
                            Console.WriteLine("MENOR");
                        }
                        else
                        {
                            Console.WriteLine("¡HAS GANADO!");
                            haGanado = true;
                        }

                        if (!haGanado)
                        {
                            jugadorActual++;
                            if (jugadorActual > cantidadJugadores)
                            {
                                jugadorActual = 1;
                            }
                        }
                    }
                }

                Console.Write("¿Desea jugar otra vez? (s/n): ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "s")
                {
                    jugarOtraVez = false;
                }
            }

            Console.WriteLine("¡Gracias por jugar!");

        }
    }
}
