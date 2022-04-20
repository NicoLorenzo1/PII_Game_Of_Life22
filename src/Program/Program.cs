using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Juego juego = new Juego();
            juego.CargarTablero(GestorArchivo.contentLines);
            juego.IniciarJuego();
        }


    }
}
