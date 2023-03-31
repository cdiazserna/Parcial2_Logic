using System;

namespace JUEGO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("ADIVINA EL NÚMERO");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");


            int numMaxopt=0, intentospermitidos, intentos, numrandom, numjugadores;        
            int menu = 1;

            while (menu==1)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Elija cuántas personas van a jugar al juego, mínimo deben ser 2 y máximo 4");
                Console.WriteLine("-----------------------------------------------------");

                numjugadores= Convert.ToInt32(Console.ReadLine());
                
                switch (numjugadores)
                {
                    case 2:
                        numMaxopt = 50;
                        break;
                    case 3:
                        numMaxopt = 100;
                        break;
                    case 4:
                        numMaxopt = 200;
                        break;
                    default:
                        Console.WriteLine("Elija una cantidad de jugadores válida");
                        break;
               
                }
                Console.Clear();

                if (numMaxopt != 0)
                {
                    Random rnd = new Random();
                    int numcorrecto = rnd.Next(0, numMaxopt + 1);
                    Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                    Console.WriteLine("El juego ha comenzado");
                    Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

                    bool ganador = false;
                    int jugador1 = 1;

                    while (!ganador)
                    {
                        Console.Write($"Jugador {jugador1}, ingrese un número entre 1 y {numMaxopt}: ");
                        int numeroIngresado = int.Parse(Console.ReadLine());

                        if (numeroIngresado < numcorrecto)
                        {
                            Console.WriteLine("MAYOR");
                        }
                        else if (numeroIngresado > numcorrecto)
                        {
                            Console.WriteLine("MENOR");
                        }
                        else
                        {
                            Console.WriteLine("¡HAS GANADO!");
                            ganador = true;
                        }

                        if (!ganador)
                        {
                            jugador1++;
                            if (jugador1 > numjugadores)
                            {
                                jugador1 = 1;
                            }
                        }
                    }
                }




            }
            
        }
        
    }
}
