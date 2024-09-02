using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    class MiBiblioteca
    {

        private List<Libro> Libros;

        public MiBiblioteca()
        {
            Libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
            Console.WriteLine($"Libro {libro.Titulo} agregado a la biblioteca");
        }

        public void AgregarLibro(string titulo, string autor, int? anioPublicacion = null, string? isbn = null)
        {
            Libro nuevoLibro;

            if (anioPublicacion.HasValue && isbn != null)
            {
                nuevoLibro = new Libro(titulo, autor, anioPublicacion, isbn);
            }
            else if (anioPublicacion.HasValue)
            {
                nuevoLibro = new Libro(titulo, autor, anioPublicacion);
            }
            else if (isbn != null)
            {
                nuevoLibro = new Libro(titulo, autor, isbn: isbn);
            }
            else
            {
                nuevoLibro = new Libro(titulo, autor);
            }

            Libros.Add(nuevoLibro);
            Console.WriteLine($"Libro {nuevoLibro.Titulo} agregado a la biblioteca");
        }

        public void ListarLibros()
        {
            Console.WriteLine("Libros disponibles en la biblioteca:");
            foreach (Libro libro in Libros)
            {
                Console.WriteLine(libro.ObtenerInformacion());
            }
        }

        public void EliminarLibro(string titulo)
        {
            Libro libroAEliminar = Libros.Find(libro => libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libroAEliminar != null)
            {
                Libros.Remove(libroAEliminar);
                Console.WriteLine($"Libro '{titulo}' eliminado de la biblioteca.");
            }
            else
            {
                Console.WriteLine($"No se encontró el libro '{titulo}' en la biblioteca.");
            }
        }
        public void BuscarLibro(string autor)
        {
            List<Libro> librosEncontrados = Libros.FindAll(libro => libro.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase));
            if (librosEncontrados.Count > 0)
            {
                Console.WriteLine($"Libros encontrados de {autor} encontrados en la biblioteca:");

                foreach (Libro libro in librosEncontrados)
                {
                    Console.WriteLine(libro.ObtenerInformacion());
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron libros de '{autor}' en la biblioteca.");
            }
        }
    }
}
