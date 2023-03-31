using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography;

namespace Juego
{
    public class Juego
    {
        static void Main(string[] args)
        {
            int NumAleatorio, NumJugador;
            bool EmJuego = true;
            decimal randomNumber;

            //Clase Random
            Random random = new Random();
            randomNumber = random.Next(min, max);

            PedirDatos(out NumJugador);
            ProcJuego(out NumJugador, out NumAleatorio);
            MostrarResultado();


        }

        static public void PedirDatos(out int Numjugador)
        {
            Console.Write("Por favor ingrese el número de jugadores entre 2 y 4: ");
            Numjugador = Convert.ToInt32(Console.ReadLine());
        }

        static public void ProcJuego(out int Numjugador, out decimal NumAleatorio, out Random max)

        {
            Console.Write("Por favor ingrese el número de jugadores entre 2 y 4: ");
            Numjugador = Convert.ToInt32(Console.ReadLine());

            int max = 0;

            switch (Numjugador)
            {
                case 0:
                    max = 50;
                    break;

                case 1:
                    max = 100;
                    break;

                case 2:
                    max = 200;
                    break;
            }

            NumAleatorio = Random.Next(max + 1);

            Console.Write("EL número secreto se generó y es : ");
            NumAleatorio = Convert.ToInt32(Console.ReadLine());

            bool Juegos = false;
            int juego = 1;

            while (Juegos)
            {
                Console.Write($"\n Jugador ,juego, Digite un número entre 0 y ,max  : ");
                int star = Convert.ToInt32(Console.ReadLine());

                if ( star > NumAleatorio)
                {
                    Console.WriteLine("Es Menor");
                    juego = (juego % Numjugador) + 1;
                }
                else if  ( star < NumAleatorio)
                {
                    Console.WriteLine("Es Mayor");
                    juego = (juego % Numjugador) + 1;
                }
                
                else
                    Console.Write($"Has ganado", Numjugador);
                { 
                juego++;
                    Juegos = true;
                }


            }
 }

        static void MostrarResultado()
        {

        }
    }
}

        
   