using System;
using System.Security.Cryptography;

namespace Juego
{
    internal class Juego
    {
        static void Main(string[] args)
        {
            int NumParticipantes, NumAleatorio, NumJugador;
            decimal randomNumber, min, max;

            //Clase Random
            Random random = new Random();
            randomNumber = random.Next(min, max);


            PedirDatos(out NumParticipantes, out NumAleatorio);
            ProcJuego();
            MostrarResultado();

        }

        static void PedirDatos(out int NumParticipantes, out int NumAleatorio)
        {
            Console.Write("Por favor ingrese el número de personas a jugar: ");
            NumParticipantes = Convert.ToInt32(Console.ReadLine());

            
        }

        static void ProcJuego()
        {

        }

        static void MostrarResultado()
        {

        }
    }

}