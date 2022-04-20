using System;

namespace PII_Game_Of_Life
{
    /// <summary>
    ///Clase LogicaJuego se encarga de realizar toda la logica del juego.
    ///Cumple con SRP y Expert debido a que su unica razón de cambio seria en caso de cambiar la logica del mismo y esta es experta en lo que hace ya que conoce toda la información necesaria para realizar su función.
    /// /// </summary>
    public class LogicaJuego
    {
        static bool[,] gameBoard;
        int boardWidth;
        int boardHeight;

        public LogicaJuego(bool[,] initialGameBoard)
        {
            gameBoard = initialGameBoard;
            boardWidth = gameBoard.GetLength(0);
            boardHeight = gameBoard.GetLength(1);

        }
        private void CalcularSiguienteGeneracion()
        {
            bool[,] cloneboard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if (gameBoard[x, y])
                    {
                        aliveNeighbors--;
                    }
                    if (gameBoard[x, y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard[x, y] = false;
                    }
                    else if (gameBoard[x, y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x, y] = false;
                    }
                    else if (!gameBoard[x, y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard[x, y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x, y] = gameBoard[x, y];
                    }
                }
            }

            gameBoard = cloneboard;
            //cloneboard = new bool[boardWidth, boardHeight];
        }
        public bool[,] SiguienteGeneracion()
        {
            this.CalcularSiguienteGeneracion();
            return gameBoard;
        }
    }
}
