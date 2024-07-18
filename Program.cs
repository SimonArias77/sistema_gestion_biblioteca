

using Sistema_Gestion_Biblioteca.Models;

Console.Clear();

var libro001 = new Libro("El señor de los anillos", 2000, "Andres Vargas", 001, "Ciencia Ficción", 85000);
var libro002 = new Libro("El código Da Vinci", 1500, "Francis Ford Coppola", 002, "Novela", 25000);
var libro003 = new Libro("Cien años de soledad", 2011, "Gabriel García Marquez", 003, "Fantasía", 120000);

// crear lista de libros
List<Libro> libros = new List<string> ();

// agregar elementos a la lista
libros.Add(libro001);
libros.Add(libro002);
libros.Add(libro003);

// mostrar lista de libros
Console.WriteLine("los libros en la lista son:");
foreach (var libro in libros)
{
    Console.WriteLine(libro);
}