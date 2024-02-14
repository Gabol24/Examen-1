using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_GabrielAlpizarTorres
{
    internal class ClsMenu
    {
        public static int opcion;
        public static void menu()
        {

            do
            {
                Console.WriteLine("--Menú Principal--");
                Console.WriteLine("1. Agregar Libro a la Biblioteca");
                Console.WriteLine("2. Eliminar un Libro de la Biblioteca");
                Console.WriteLine("3. Mostrar todos los Libros de la Biblioteca");
                Console.WriteLine("4. Buscar Libro");
                Console.WriteLine("5. Mostrar Libro de Mayor Precio");
                Console.WriteLine("6. Mostrar los tres Libros más Baratos");
                Console.WriteLine("7. Buscar Libros por Inicio del Nombre del Autor");
                Console.WriteLine("8. Salir");
                Console.WriteLine("Digite una opción...");


                string input = Console.ReadLine();

                if (int.TryParse(input, out opcion))
                {
                    switch (opcion)
                    {
                        case 1: ClsBiblioteca.AgregarLibro(); break;

                        case 2:;ClsBiblioteca.EliminarLibro(); break;

                        case 3: ClsBiblioteca.MostrarLibros(); break;

                        case 4: ClsBiblioteca.BuscarLibro(); break;

                        case 5: ClsBiblioteca.MostrarLibroMayorPrecio(); break;

                        case 6:;ClsBiblioteca.MostrarLibrosMasBaratos(); break;

                        case 7:; break;

                        case 8: Console.WriteLine("Saliendo..."); break;

                        default: Console.WriteLine("Digite una opción correcta"); break;
                    }
                }
                else
                {
                    Console.WriteLine("La opción ingresada no es válida. Por favor, ingrese un número.");
                }

            } while (opcion != 8);
        }
    }
}
