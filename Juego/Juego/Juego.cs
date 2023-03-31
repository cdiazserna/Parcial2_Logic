using System;
using System.Security.Cryptography;

namespace Juego
{
    public class Juego
    {
        static void Main(string[] args)
        {
            int NumAleatorio, NumJugador;
            decimal randomNumber, min, max;
            int i;

            //Clase Random
            Random random = new Random();
            randomNumber = random.Next(min, max);



            PedirDatos(out NumJugador, out NumAleatorio);
            ProcJuego(out NumJugador, out NumAleatorio);
            MostrarResultado();


        }

        static public void PedirDatos(out int Numjugador, out int NumAleatorio)
        {
            Console.Write("Por favor ingrese el número de jugadores entre 2 y 4: ");
            Numjugador = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un número: ");
            NumAleatorio = Convert.ToInt32(Console.ReadLine());
        }

        static public void ProcJuego(out int Numjugador, out int NumAleatorio, out int i)

        {
            while (Numjugador < 2 || Numjugador > 4)
            {
                Console.Write("Por favor ingrese el número de jugadores entre 2 y 4: ");
                Numjugador = Convert.ToInt32(Console.ReadLine());

                if (Numjugador == 2)
                {
                    i = NumAleatorio(0, 50);
                }
                else if (Numjugador == 3)

                {
                    i = numAleatorio(0, 100);
                }
                else if (Numjugador == 4)
                {
                    i = NumAleatorio(0, 200);
                    }
            }
        }
    }
}

        static void MostrarResultado()
        {

        }
    }

}