using System.Text;
using System;


namespace PII_Game_Of_Life
{
    /// <summary>
    /// Clase Tablero la cual se encarga de Imprimir el string a partir de la variable "s" la cual se va generando a medida que se recorre el tablero.
    /// Cumple con el SRP y el Expert ya que su unica razón de cambio es a traves de la impresión del tablero y conoce todo lo necesario para imprimirse.
    /// </summary>
    public class Tablero
    {

        public static void Imprimir(bool[,] tablero)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();

            //Utilizo el alto y ancho del array para que se pueda imprimir un tablero de cualquier dimensión.
            for (int y = 0; y < tablero.GetLength(1); y++) //height
            {
                for (int x = 0; x < tablero.GetLength(0); x++) //width
                {
                    if (tablero[x, y])
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
        }

    }

}
