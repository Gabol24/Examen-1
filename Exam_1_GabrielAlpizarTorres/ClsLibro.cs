using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_GabrielAlpizarTorres
{
    internal class ClsLibro : ILibro 
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public float Precio { get; set; }
        public bool Disponible { get; set; }


        public ClsLibro(int codigo, string titulo, string autor, DateTime fechaPublicacion, float precio, bool disponible)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            FechaPublicacion = fechaPublicacion;
            Precio = precio;
            Disponible = disponible;
        }


        public void Prestar()
        {

            Console.WriteLine("Libro prestado.");
        }

        public void Devolver()
        {

            Console.WriteLine("Libro devuelto.");
        }

        public void Consultar()
        {

            Console.WriteLine("Consultando información del libro.");
        }
    }
}
