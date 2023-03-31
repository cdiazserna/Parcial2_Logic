using System;

namespace Juego
{
    public class Program
    {



        static void Main(string[] args)
        {
            int players, player1, player2, player3, player4, numAleator50, swth = 1, numAleator100, numAleator200;
            Random aleator = new Random();



            Console.WriteLine("\n   **********************************");
            Console.WriteLine("   *Bienvenidos Al Juego Adivina el numero*");
            Console.WriteLine("   ****************************************\n");
            Console.WriteLine("    Por Favor Ingresa El numero de Paticipantes\n");
            Console.WriteLine("      1-  2 Jugadores.");
            Console.WriteLine("      2-  3 Jugadores.");
            Console.WriteLine("      3-  4 Jugadores.\n");

            players = Convert.ToInt32(Console.ReadLine());



            switch (players)
            {
                case 1:
                    numAleator50 = aleator.Next(0, 50);
                    while (swth == 1)
                    {

                        Console.WriteLine("\n    Jugador 1 su Numero del 0 al 50 Por Favor \n");
                        player1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n    Jugador 2 su Numero del 0 al 50 Por Favor \n");
                        player2 = Convert.ToInt32(Console.ReadLine());

                        if (player1 == numAleator50) Console.WriteLine("   JUGADOR 1 HAZ GANADO");
                        if (player2 == numAleator50) Console.WriteLine("   JUGADOR 2 HAZ GANADO");
                        if (player1 < numAleator50) Console.WriteLine("    JUGADOR 1 ES MAS ARRIBA");
                        if (player1 > numAleator50) Console.WriteLine("    JUGADOR 1 ES MAS ABAJO");
                        if (player2 < numAleator50) Console.WriteLine("    JUGADOR 2 ES MAS ARRIBA");
                        if (player2 > numAleator50) Console.WriteLine("    JUGADOR 2 ES MAS ABAJO");

                        Console.WriteLine(" para ingresar un nuevo numero marque 1 o cualquier otro para salir");
                        swth = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                    }
                    break;
                case 2:
                    numAleator100 = aleator.Next(0, 100);
                    while (swth == 1)
                    {

                        Console.WriteLine("\n    Jugador 1 su Numero del 0 al 100 Por Favor \n");
                        player1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n    Jugador 2 su Numero del 0 al 100 Por Favor \n");
                        player2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n    Jugador 3 su Numero del 0 al 100 Por Favor \n");
                        player3 = Convert.ToInt32(Console.ReadLine());
                        if (player1 == numAleator100) Console.WriteLine("   JUGADOR 1 HAZ GANADO");
                        if (player2 == numAleator100) Console.WriteLine("   JUGADOR 2 HAZ GANADO");
                        if (player3 == numAleator100) Console.WriteLine("   JUGADOR 2 HAZ GANADO");
                        if (player1 < numAleator100) Console.WriteLine("    JUGADOR 1 ES MAS ARRIBA");
                        if (player1 > numAleator100) Console.WriteLine("    JUGADOR 1 ES MAS ABAJO");
                        if (player2 < numAleator100) Console.WriteLine("    JUGADOR 2 ES MAS ARRIBA");
                        if (player2 > numAleator100) Console.WriteLine("    JUGADOR 2 ES MAS ABAJO");
                        if (player3 < numAleator100) Console.WriteLine("    JUGADOR 3 ES MAS ARRIBA");
                        if (player3 > numAleator100) Console.WriteLine("    JUGADOR 3 ES MAS ABAJO");

                        Console.WriteLine(" para ingresar un nuevo numero marque 1 o cualquier otro para salir");
                        swth = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                    }
                    break;
                case 3:
                    numAleator200 = aleator.Next(0, 200);
                    while (swth == 1)
                    {

                        Console.WriteLine("\n    Jugador 1 su Numero del 0 al 200 Por Favor \n");
                        player1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n    Jugador 2 su Numero del 0 al 200 Por Favor \n");
                        player2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n    Jugador 3 su Numero del 0 al 200 Por Favor \n");
                        player3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n    Jugador 4 su Numero del 0 al 200 Por Favor \n");
                        player4 = Convert.ToInt32(Console.ReadLine());
                        if (player1 == numAleator200) Console.WriteLine("   JUGADOR 1 HAZ GANADO");
                        if (player2 == numAleator200) Console.WriteLine("   JUGADOR 2 HAZ GANADO");
                        if (player3 == numAleator200) Console.WriteLine("   JUGADOR 2 HAZ GANADO");
                        if (player1 < numAleator200) Console.WriteLine("    JUGADOR 1 ES MAS ARRIBA");
                        if (player1 > numAleator200) Console.WriteLine("    JUGADOR 1 ES MAS ABAJO");
                        if (player2 < numAleator200) Console.WriteLine("    JUGADOR 2 ES MAS ARRIBA");
                        if (player2 > numAleator200) Console.WriteLine("    JUGADOR 2 ES MAS ABAJO");
                        if (player3 < numAleator200) Console.WriteLine("    JUGADOR 3 ES MAS ARRIBA");
                        if (player3 > numAleator200) Console.WriteLine("    JUGADOR 3 ES MAS ABAJO");
                        if (player4 < numAleator200) Console.WriteLine("    JUGADOR 4 ES MAS ARRIBA");
                        if (player4 > numAleator200) Console.WriteLine("    JUGADOR 4 ES MAS ABAJO");
                        Console.WriteLine(" para ingresar un nuevo numero marque 1 o cualquier otro para salir");
                        swth = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                    }
                    break;
            }
        }
    }
}
