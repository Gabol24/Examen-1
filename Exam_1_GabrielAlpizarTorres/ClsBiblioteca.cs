using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_GabrielAlpizarTorres
{
    internal class ClsBiblioteca
    {
        private List<ClsLibro> libros;

        public ClsBiblioteca()
        {
            libros = new List<ClsLibro>();
        }

        public void AgregarLibro(ClsLibro libro)
        {
            libros.Add(libro);
        }

        public void EliminarLibro(int codigo)
        {
            ClsLibro libro = libros.Find(l => l.Codigo == codigo);
            if (libro != null)
            {
                libros.Remove(libro);
                Console.WriteLine("Libro eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("El libro no está en la biblioteca.");
            }
        }

        public static void MostrarLibros()
        {
            Console.WriteLine("Libros en la biblioteca:");
            foreach (var libro in libros)
            {
                Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Disponible: {(libro.Disponible ? "Sí" : "No")}");
            }
        }

        public void AgregarLibro()
        {
            List<ClsLibro> listaLibros = new List<ClsLibro>();

            do
            {
                Console.WriteLine("Digite el código del Libro:");
                int codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el Título del Libro:");
                string titulo = Console.ReadLine();

                Console.WriteLine("Digite el Nombre del Autor:");
                string autor = Console.ReadLine();

                Console.WriteLine("Digite la Fecha de Publicación (YYYY-MM-DD):");
                DateTime fechaPublicacion;
                while (!DateTime.TryParse(Console.ReadLine(), out fechaPublicacion))
                {
                    Console.WriteLine("Formato de fecha incorrecto. Intente de nuevo (YYYY-MM-DD):");
                }

                Console.WriteLine("Digite Precio del Libro:");
                float precio;
                while (!float.TryParse(Console.ReadLine(), out precio))
                {
                    Console.WriteLine("Precio inválido. Intente de nuevo:");
                }

                Console.WriteLine("Digite el Disponible de Libros (true/false):");
                bool disponible;
                while (!bool.TryParse(Console.ReadLine(), out disponible))
                {
                    Console.WriteLine("Valor de disponibilidad inválido. Intente de nuevo (true/false):");
                }


                listaLibros.Add(new ClsLibro(codigo, titulo, autor, fechaPublicacion, precio, disponible));

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El libro se ingresó correctamente.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("¿Desea ingresar otro libro? (Sí/No): ");
            } while (Console.ReadLine().Trim().ToUpper() == "SI");
        }

        public static void BuscarLibro(List<ClsLibro> libros)
        {
            int cod = 0;
            bool existe = false;

            Console.WriteLine("Digite el código del Libro:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out cod))
            {
                foreach (var libro in libros)
                {
                    if (libro.Codigo == cod)
                    {
                        Console.WriteLine($"Código: {libro.Codigo}, Título: {libro.Titulo}, Autor: {libro.Autor}, Precio: {libro.Precio}, Disponible: {(libro.Disponible ? "Sí" : "No")}");
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    Console.Clear();
                    Console.WriteLine("¡El libro ingresado no existe!");
                }
            }
            else
            {
                // La entrada del usuario no es un número entero
                Console.WriteLine("La entrada no es un número entero válido. Inténtelo de nuevo.");
            }
        }

        public static void MostrarLibroMayorPrecio(List<ClsLibro> libros)
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("La biblioteca está vacía. No hay libros para mostrar.");
                return;
            }
            ClsLibro libroMayorPrecio = libros[0];

            foreach (var libro in libros)
            {
                if (libro.Precio > libroMayorPrecio.Precio)
                {
                    libroMayorPrecio = libro;
                }
            }
            Console.WriteLine("Libro con el mayor precio:");
            Console.WriteLine($"Título: {libroMayorPrecio.Titulo}, Autor: {libroMayorPrecio.Autor}, Precio: {libroMayorPrecio.Precio}");
        }

        public static void MostrarLibrosMasBaratos(List<ClsLibro> libros)
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("La biblioteca está vacía. No hay libros para mostrar.");
                return;
            }
            libros.Sort((libro1, libro2) => libro1.Precio.CompareTo(libro2.Precio));

            Console.WriteLine("Los tres libros más baratos:");

            int contador = 0;
            foreach (var libro in libros)
            {
                if (contador < 3)
                {
                    Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Precio: {libro.Precio}");
                    contador++;
                }
                else
                {
                    break;
                }
            }
        }
    }



}

