using System;
using System.Runtime.CompilerServices;

namespace ResolucionParcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datos de entrada --> numberPlayers, min = 0, max, numberAttempt 
            //Datos de proceso --> randomNumber
            //Datos de salida --> resetGame, hasWinner

            int numberPlayers, min = 0, max, numberAttempt = 0, randomNumber = 0;
            bool hasWinner = false, isPlayAgain;
            string resetGame = "";

            do
            {
                //Métodos que se crearán
                PaintMenu(out numberPlayers);
                randomNumber = GenerateRandomNumber(min, out max, randomNumber, numberPlayers);
                PlayGame(numberPlayers, randomNumber, numberAttempt, min, max, hasWinner);
                isPlayAgain = PlayAgain(resetGame);
            } while (isPlayAgain);
        }

        private static bool PlayAgain(string resetGame)
        {
            Console.WriteLine("Si quieren jugar de nuevo digita YES o NO para finalizar");
            resetGame = Console.ReadLine();
            Console.Clear();

            if (resetGame.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void PlayGame(int numberPlayers, int randomNumber, int numberAttempt, int min, int max, bool hasWinner)
        {
            do
            {
                for (int i = 1; i <= numberPlayers; i++)
                {
                    Console.WriteLine(String.Format("Jugardor #{0}, lanza un número que esté entre {1} y {2}", i, min, max));
                    numberAttempt = Convert.ToInt32(Console.ReadLine());

                    if (numberAttempt > randomNumber)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else if (numberAttempt < randomNumber)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else
                    {
                        Console.WriteLine("¡Has Ganado!");
                        hasWinner = true;
                        break;
                    }
                }
            } while (!hasWinner);
        }

        private static int GenerateRandomNumber(int min, out int max, int randomNumber, int numberPlayers)
        {
            //Esto es POO, porque aquí estoy creando un objeto de una clase ya existente. De esta forma yo instancio un objeto de una clase.
            Random random = new Random();
            max = 50;

            switch (numberPlayers)
            {
                case 2:
                    randomNumber = random.Next(min, max);
                    break;
                case 3:
                    max = 100;
                    randomNumber = random.Next(min, max);
                    break;
                case 4:
                    max = 200;
                    randomNumber = random.Next(min, max);
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida.");
                    break;
            }

            return randomNumber;
        }

        private static void PaintMenu(out int numberPlayers)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*JUEGO ADIVINA EL NÚMERO*");
            Console.WriteLine("*************************");
            Console.WriteLine("¿Cuántos participantes jugarán?");
            Console.WriteLine("Dos jugadores");
            Console.WriteLine("Tres jugadores");
            Console.WriteLine("Cuatro jugadores");
            Console.WriteLine("Digite el número de jugadores\n");
            numberPlayers = Convert.ToInt32(Console.ReadLine());
        }
    }
}
