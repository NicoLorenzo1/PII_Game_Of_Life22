using System.Text;
using System;
using System.Threading;


namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        static bool[,] b; //variable que representa el tablero
        static int width; //variabe que representa el ancho del tablero
        static int height; //variabe que representa altura del tablero

        public static void Imprimir()
        {

            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (b[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                LogicaJuego.GameBoard;
                Thread.Sleep(300);

            }
        }

    }

}
