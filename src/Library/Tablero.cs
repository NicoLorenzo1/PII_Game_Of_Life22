using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        static string url = @"../../assets/board.txt";
        static string content = File.ReadAllText(url);
        static string[] contentLines = content.Split('\n');
        public static bool[,] board = new bool[contentLines.Length, contentLines[0].Length];

        private void LeerTablero(bool[,] board)
        {
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
    }
}


