// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Apartado 2.1 a) Crear lista e insertare tres libros
            var lista = new List<Libro>();
            lista.Add(new Libro("1984", "George Orwell", 1949, true));
            lista.Add(new Libro("Rebelión en la granja", "George Orwell", 1945, false));
            lista.Add(new Libro("El Quijote", "Miguel de Cervantes", 1605, false));

            // b) Mostrar todos los libros
            Console.WriteLine("Todos los libros:");
            foreach (var libro in lista)
            {
                Console.WriteLine(libro.ToString());
            }

            Console.WriteLine();

            // c) Mostrar solo los libros cuyo autor contiene "Orwell"
            Console.WriteLine("Libros cuyo autor contiene 'Orwell':");
            foreach (var libro in lista)
            {
                if (libro.Autor.Contains("Orwell"))
                {
                    Console.WriteLine(libro.ToString());
                }
            }

            Console.WriteLine();

            // Apartado 2.2 Mostrar la fecha actual en formato corto
            Console.WriteLine("Fecha actual: " + DateTime.Now.ToShortDateString());

            Console.WriteLine();

            // Apartado 2.3 Guardar en fichero
            var ruta = "libros.txt";
            guardarLibros(lista, ruta);
            Console.WriteLine($"Libros guardados en '{ruta}'.");
        }

        private static void guardarLibros(List<Libro> lista, string ruta)
        {
            // Usando File.CreateText() y StreamWriter, escribimos cada libro en una línea
            StreamWriter sw = File.CreateText(ruta);
            foreach (var libro in lista)
            {
                sw.WriteLine($"{libro.Titulo};{libro.Autor};{libro.Anyo};{libro.Disponible}");
            }
            sw.Close();
        }
    }
}
