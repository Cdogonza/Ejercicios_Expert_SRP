using System;
using System.Text;
using System.Collections; 
namespace SRP
{
public class Biblioteca
{
    public string SectorBiblioteca { get ; set; }
    public string EstanteBiblioteca { get ; set; }
    public string Coidigo_Lugar{get;set;}
    public StringBuilder DatosLibro= new StringBuilder();
    public Biblioteca(String sector, String estante, String codigo_lugar)
    {       
        this.SectorBiblioteca = sector;
        this.EstanteBiblioteca = estante;
        this.Coidigo_Lugar = codigo_lugar;    
    }
    public void Ver_Lugar_Libro(Libro Libro)
        {   
            DatosLibro.Append($"El codigo del libro es {Libro.Codigo} de titulo  {Libro.Titulo} esta en ");
            DatosLibro.Append($"sector {this.SectorBiblioteca} y estanteria {this.EstanteBiblioteca}");
            
            


}
}
}