using System;

namespace Juego
{
    public class Program
    {
        


        static void Main(string[] args)
        {
            int players, player1, player2, player3, player4, numAleator50, swth=1;
            Random aleator= new Random();

            

            Console.WriteLine("\n   **********************************");
            Console.WriteLine("   *Bienvenidos Al Juego Adivina el numero*");
            Console.WriteLine("   ****************************************\n");
            Console.WriteLine("    Por Favor Ingresa El numero de Paticipantes\n");
            Console.WriteLine("      1-  2 Jugadores.");
            Console.WriteLine("      2-  3 Jugadores.");
            Console.WriteLine("      3-  4 Jugadores.\n");
            
            players=Convert.ToInt32(Console.ReadLine());

           

            switch (players) 
            {
                case 1:
                    numAleator50 = aleator.Next(0, 50);
                    while (swth == 1)
                    {
                       
                        Console.WriteLine("\n    Jugador 1 su Numero Por Favor \n");
                        player1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n    Jugador 2 su Numero Por Favor \n");
                        player2 = Convert.ToInt32(Console.ReadLine());

                        if (player1 == numAleator50) Console.WriteLine("   JUGADOR 1 HAZ GANADO");
                        if (player2 == numAleator50) Console.WriteLine("   JUGADOR 2 HAZ GANADO");
                        if (player1 < numAleator50) Console.WriteLine("    JUGADOR 1 ES MAS ARRIBA");
                        if (player1 > numAleator50) Console.WriteLine("    JUGADOR 1 ES MAS ABAJO");
                        if (player2 < numAleator50) Console.WriteLine("    JUGADOR 2 ES MAS ARRIBA");
                        if (player2 > numAleator50) Console.WriteLine("    JUGADOR 2 ES MAS ABAJO");

                        Console.WriteLine(" para ingresar un nuevo numero marque 1 o cualquier otro para salir");
                        swth=Convert.ToInt32(Console.ReadLine());
                       Console.Clear();


                    }
                    break;


                    

                    
            }



        }
    }
}
