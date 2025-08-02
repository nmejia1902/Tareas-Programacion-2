using System;

class Program
{
    static void Main(string[] args)
    {
     
        Libro libro1 = new Libro("El Principito", "Antoine de Saint-Exupéry", 1943);
        Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez", 1967);
        Libro libro3 = new Libro("1984", "George Orwell", 1949);


        Persona persona1 = new Persona("Nestor", "Mejia", 38);
        Persona persona2 = new Persona("Andrea", "Ramirez", 30);

 
        Estante estante = new Estante(1, 5);
        estante.LibrosEnEstante.Add(libro1);
        estante.LibrosEnEstante.Add(libro2);
        estante.LibrosEnEstante.Add(libro3);

        Console.WriteLine("Información de los libros:");
        libro1.MostrarInformacion();
        libro2.MostrarInformacion();
        libro3.MostrarInformacion();

        Console.WriteLine("\nSaludos de las personas:");
        persona1.Saludar();
        persona2.Saludar();

        estante.MostrarContenido();

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
