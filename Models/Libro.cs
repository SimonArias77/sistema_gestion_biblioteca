using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Biblioteca.Models;

public class Libro : Publicacion
{
    public string Titulo { get; set; }
    public int AnoPublicacion { get; set;}
    public string Autor { get; set; }
    public int ISBN { get; set; }
    public string Genero { get; set; }
    public double Precio { get; set; }

    // constructor para inicializar el libro
    public Libro(string titulo, int anopublicacion, string autor, int isbn, string genero, double precio) : base(titulo, anopublicacion)
    {
        Titulo = titulo;
        AnoPublicacion = anopublicacion;
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        Precio = precio;
    }

    public string Descripcion()
    {
        return $"El libro tiene un ISBN: {ISBN}, el autor es: {Autor}, el genero es: {Genero} y el precio es: {Precio}";

    }

}
