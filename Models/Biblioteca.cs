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

    public string Agregar()
    {
        Libros.Add(new Libro("el señor de los anillos", 2000, "Andres Vargas", 007, "Ciencia Ficción", 85000));
        return "Libro agregado exitosamente";
    }

    public string Eliminar()
    {
        Libros.RemoveAt(Libros.Count - 1);
        return "Libro eliminado exitosamente";
    }

    public string Buscar(string titulo)
    {
        var libro = Libros.FirstOrDefault(l => l.Titulo == titulo);
        if (libro != null)
        {
            return $"Libro encontrado: {libro.Titulo}";
        }
        return "Libro no encontrado";
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
