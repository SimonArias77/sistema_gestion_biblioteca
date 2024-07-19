using Sistema_Gestion_Biblioteca.Models;
// Creación de instancias de libros
var libro001 = new Libro("El senor de los anillos", 2000, "Andres_Vargas", 456, "Ciencia Ficción", 85000);
var libro002 = new Libro("El código Da Vinci", 1500, "Francis Ford Coppola", 789, "Novela", 25000);
var libro003 = new Libro("Cien años de soledad", 2011, "Gabriel García Marquez", 863, "Fantasía", 120000);

// Crear lista de libros
List<Libro> libros = new List<Libro>();

// instanciar biblioteca
Biblioteca biblioteca = new Biblioteca();

// Agregar elementos a la lista
biblioteca.Agregar(libro001);
biblioteca.Agregar(libro002);
biblioteca.Agregar(libro003);

inicioPrograma();

int Menu()
{
    Console.WriteLine("0. Mostrar lista de libros");
    Console.WriteLine("1. Agregar libro");
    Console.WriteLine("2. Eliminar libro");
    Console.WriteLine("3. Buscar libro por título");
    Console.WriteLine("4. Buscar libros por autor");
    Console.WriteLine("5. Buscar libros por género");
    Console.WriteLine("6. Buscar libros por año");
    Console.WriteLine("7. Ordenar libros por año");
    Console.WriteLine("8. Libro más reciente");
    Console.WriteLine("9. Descuento");
    Console.WriteLine("10. Salir");
    Console.Write("Elija una opción: ");
    return Convert.ToInt32(Console.ReadLine());
}



// realizacion de menú por medio del switch
void inicioPrograma()
{
    int opcion;
    do
    {
        opcion = Menu();
        switch (opcion)
        {
            case 0:
                MostrarLibros();
                break;

            case 1:
                CrearLibro();
                break;

            case 2:
                EliminarLibro();
                break;

            case 3:
                BuscarLibroTitulo();
                break;

            case 4:

                Console.WriteLine("por favor escriba el autor del libro:");
                string? autor = Console.ReadLine();
                biblioteca.BuscarLibroAutor(autor);
                break;

            case 5:
                biblioteca.BuscarLibroGenero("genero");
                break;

            case 6:
                biblioteca.BuscarLibroAno("ano");
                break;

            case 7:
                biblioteca.OrdenarPorAno("ano");
                break;

            case 8:
                biblioteca.Reciente();
                break;

            case 9:
                biblioteca.Descuento();
                break;

            case 10:
                Console.WriteLine("Salir");
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    } while (opcion != 10);
}

//Función para pedir al usuario los datos para crear un nuevo libro
void CrearLibro()
{
    Console.Write("Ingrese el título del libro: ");
    string titulo = Console.ReadLine();

    Console.Write("Ingrese el año de publicación: ");
    int ano = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el autor del libro: ");
    string autor = Console.ReadLine();

    Console.Write("Ingrese el ISBN del libro: ");
    int isbn = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el género del libro: ");
    string genero = Console.ReadLine();

    Console.Write("Ingrese el precio del libro: ");
    double precio = Convert.ToDouble(Console.ReadLine());

    var libro = new Libro(titulo, ano, autor, isbn, genero, precio);
    biblioteca.Agregar(libro);
}


void MostrarLibros()
{
    foreach (var libro in biblioteca.Libros)
    {
        Console.WriteLine($"Título: {libro.Titulo}, Año de publicación: {libro.AnoPublicacion}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Género: {libro.Genero}, Precio: {libro.Precio}");
    }
    Console.WriteLine();
}

//solicitar el Isbn Para Eliminar el libro
void EliminarLibro()
{
    Console.Write("Ingrese el ISBN del libro que desea eliminar: ");
    int isbn = Convert.ToInt32(Console.ReadLine());
    var libro = biblioteca.Libros.FirstOrDefault(l => l.ISBN == isbn);
    biblioteca.Eliminar(libro);
}

void BuscarLibroTitulo()
{
    Console.WriteLine("por favor escriba el titulo del libro:");
    string? titulo = Console.ReadLine();
    var libro = biblioteca.Libros.FirstOrDefault(libro => libro.Titulo.ToLower() == titulo.ToLower());
    if (libro == null)
    {
        Console.WriteLine("Libro no encontrado");
    }
    else
    {
        Console.WriteLine($"Libro encontrado: {libro.Descripcion()}");
    }
}