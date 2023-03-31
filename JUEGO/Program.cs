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


            int numMaxopt, intentospermitidos, intentos, numrandom, numjugadores;
            bool ganador;
            int menu = 1;

            while (menu==1)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Elija cuántas personas van a jugar al juego, mínimo deben ser 2 y máximo 4");
                Console.WriteLine("-----------------------------------------------------");

                numjugadores= Convert.ToInt32(Console.ReadLine());
                
                switch (numjugadores)
                {
                    case 1
                }

            }
            
        }
        
    }
}
