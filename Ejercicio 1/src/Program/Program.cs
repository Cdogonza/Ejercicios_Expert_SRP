using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");


            Biblioteca libroA = new Biblioteca("A","7",libro1.Codigo);
            Biblioteca libroB = new Biblioteca("B","3",libro2.Codigo);

            libroB.Ver_Lugar_Libro(libro2);
            libroA.Ver_Lugar_Libro(libro1);
            Console.WriteLine(libro1.Titulo);
        }
    }
}
