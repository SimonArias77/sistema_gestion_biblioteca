using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Biblioteca.Models;

public class Biblioteca
{
    public List<Libro> Libros { get; set; }

    public Biblioteca()
    {
        Libros = new List<Libro>();
        Console.WriteLine("Este es el constructor de biblioteca");
    }

    public double Descuento()
    {
        double descuento = 0;
        foreach (var libro in Libros)
        {
            descuento += libro.Precio * 0.1;
        }
        return descuento;
    }

    public string Agregar(Libro libro)
    {
        Libros.Add(libro);
        return "Libro agregado exitosamente";
    }

    public string Eliminar(Libro libro)
    {
        Libros.Remove(libro);
        return "Libro eliminado exitosamente";
    }

    public string BuscarLibroAutor(string autor)
    {
        var librosAutor = Libros.Where(l => l.Autor == autor).ToList();
        if (librosAutor.Count > 0)
        {
            return $"Libros del autor {autor}: {string.Join(", ", librosAutor.Select(l => l.Titulo))}";
        }
        return "No hay libros del autor";
    }

    public string BuscarLibroGenero(string genero)
    {
        var librosGenero = Libros.Where(l => l.Genero == genero).ToList();
        if (librosGenero.Count > 0)
        {
            return $"Libros del genero {genero}: {string.Join(", ", librosGenero.Select(l => l.Titulo))}";
        }
        return "No hay libros del genero";
    }

    public string BuscarLibroAno(string ano)
    {
        var librosAno = Libros.Where(l => l.AnoPublicacion.ToString() == ano).ToList();
        if (librosAno.Count > 0)
        {
            return $"Libros publicados en {ano}: {string.Join(", ", librosAno.Select(l => l.Titulo))}";
        }
        return "No hay libros publicados en este año";
    }

    public string OrdenarPorAno(string ano)
    {
        var librosOrdenados = Libros.OrderBy(l => l.AnoPublicacion).ToList();
        if (librosOrdenados.Count > 0)
        {
            return $"Libros ordenados por año: {string.Join(", ", librosOrdenados.Select(l => l.Titulo))}";
        }
        return "No hay libros en la biblioteca";
    }

    public string Reciente()
    {
        var libroReciente = Libros.OrderByDescending(l => l.AnoPublicacion <= 2020).FirstOrDefault();
        if (libroReciente != null)
        {
            return $"Libro más reciente: {libroReciente.Titulo}";
        }
        return "No hay libros en la biblioteca";
    }

}
