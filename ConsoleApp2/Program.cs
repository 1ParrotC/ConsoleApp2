// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Ejemplo de uso de la clase Libro
            var libro = new Libro("Cien años de soledad", "Gabriel García Márquez", 1967, true);
            Console.WriteLine(libro.ToString());
        }
    }
}
