using System;
using System.IO;


namespace PII_Game_Of_Life
{
    /// <summary>
    /// Clase GestorArchivo se encarga de leer el archiv que se le pasa en la url, esta clase cumple con el patron expert y srp debido a que 
    /// si se quiere cambiar la forma de leer el archivo solamente se deberia cambiar esta clase.
    /// </summary>
    public class GestorArchivo
    {

        static string url = @"../../assets/board.txt";
        static string content = File.ReadAllText(url);
        public static string[] contentLines = content.Split('\n');


    }
}