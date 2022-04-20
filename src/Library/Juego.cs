using System;
using System.Threading;


namespace PII_Game_Of_Life
{
    /// <summary>
    /// Clae Juego se encarga de armar o cargar el tablero a partir de contentLines y tiene un método llamado 
    /// IniciarJuego que se encarga de crear un tablero, imprimirlo y luego se le vuelve a cargar la siguiente generación del tablero para asi continuar con su proceso.
    /// Esta clase cumple con el SRP debido a que tiene una responsabilidad unica en la cual carga el tablero e inicia el juego, y tambien con el Expert ya que conoce todo lo que necesita para realizar su función.
    /// </summary>
    public class Juego
    {
        private bool[,] board;

        public void CargarTablero(string[] contentLines)
        {
            board = new bool[contentLines.Length, contentLines[0].Length];

            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                }
            }
        }

        public void IniciarJuego()
        {
            LogicaJuego logica = new LogicaJuego(board);
            Tablero.Imprimir(board);
            while (true)
            {
                board = logica.SiguienteGeneracion();
                Tablero.Imprimir(board);
                Thread.Sleep(300);

            }
        }
    }
}


