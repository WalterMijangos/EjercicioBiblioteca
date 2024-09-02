using Biblioteca.Clases;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la biblioteca");

            Libro unMundoFeliz = new Libro("Un mundo feliz", "Aldous Huxley");

            Console.WriteLine(unMundoFeliz.ObtenerInformacion());

            MiBiblioteca miBiblioteca = new MiBiblioteca();

            miBiblioteca.AgregarLibro(unMundoFeliz);

            miBiblioteca.AgregarLibro("Orgullo y prejuicio", "Jane Austen");

            miBiblioteca.AgregarLibro("Harry Potter y la Piedra Filosofal", "J. K. Rowling");

            miBiblioteca.AgregarLibro("Harry Potter y la Camara Secreta", "J. K. Rowling");

            miBiblioteca.ListarLibros();

            // Buscar libro por autor
            Console.WriteLine("\nBuscando libros de 'J. K. Rowling': ");
            miBiblioteca.BuscarLibro("J. K. Rowling");

            // Eliminar libro por titulo
            Console.WriteLine("\nEliminando el libro de 'Harry Potter y la Camara Secreta'.... ");
            miBiblioteca.EliminarLibro("Harry Potter y la Camara Secreta");

            // Lista para verificar si se elimino el Libro
            Console.WriteLine("\nListado de libros despues de la Eliminacion:");
            miBiblioteca.ListarLibros();

        }
    }
}
