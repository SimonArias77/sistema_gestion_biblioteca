using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Biblioteca.Models;

public class Publicacion
{
    public string Titulo { get; set; }
    public int AnoPublicacion { get; set; }


    // Constructor para inicializar publicacion
    public Publicacion(string titulo, int anopublicacion)
    {
        Titulo = titulo;
        AnoPublicacion = anopublicacion;
    }
}
