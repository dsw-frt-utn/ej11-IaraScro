namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        Alumno a1 = new Alumno(1, "Juan", 8);
        Alumno a2 = new Alumno(2, "Maria", 9);
        Alumno a3 = new Alumno(3, "Pedro", 7);

        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        Console.WriteLine("LISTA DE ALUMNOS");
        foreach (Alumno alumno in lista.retornarLista())
        {
            Console.WriteLine($"{alumno.Id} - {alumno.Nombre}");
        }


        Alumno encontrado = lista.BuscarAlumno("Maria");

        if (encontrado != null)
        {
            Console.WriteLine($"Alumno encontrado: {encontrado.Nombre}");
        }

        Alumno noExiste = lista.BuscarAlumno("Carlos");

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }


        lista.EliminarAlumno(a2);

        Console.WriteLine("LISTA DESPUES DE ELIMINAR MARIA");

        foreach (Alumno alumno in lista.retornarLista())
        {
            Console.WriteLine($"{alumno.Id} - {alumno.Nombre}");
        }

        lista.PosicionDeterminada(0);

        Console.WriteLine("LISTA DESPUES DE ELIMINAR PRIMER ELEMENTO");

        foreach (Alumno alumno in lista.retornarLista())
        {
            Console.WriteLine($"{alumno.Id} - {alumno.Nombre}");
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Juan", 8);
Alumno a2 = new Alumno(2, "Maria", 9);
Alumno a3 = new Alumno(3, "Pedro", 7);

        diccionario.AgregarAlumno(a1);
        diccionario.AgregarAlumno(a2);
        diccionario.AgregarAlumno(a3);

        Console.WriteLine("DICCIONARIO DE ALUMNOS");

        foreach (var item in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"{item.Key} - {item.Value.Nombre}");
        }

        Alumno encontrado = diccionario.BuscarAlumno(2);

        if (encontrado != null)
        {
            Console.WriteLine($"Alumno encontrado: {encontrado.Nombre}");
        }

        Alumno noExiste = diccionario.BuscarAlumno(10);

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }


        diccionario.EliminarAlumno(2);

        Console.WriteLine("DICCIONARIO DESPUES DE ELIMINAR");

        foreach (var item in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"{item.Key} - {item.Value.Nombre}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Console.WriteLine("PRIMER LIBRO");
        Console.WriteLine(linq.GetPrimero().Titulo);

        Console.WriteLine();

        Console.WriteLine("ULTIMO LIBRO");
        Console.WriteLine(linq.GetUltimo().Titulo);

        Console.WriteLine();

        Console.WriteLine("TOTAL PRECIOS");
        Console.WriteLine(linq.GetTotalPrecios());

        Console.WriteLine();

        Console.WriteLine("PROMEDIO PRECIOS");
        Console.WriteLine(linq.GetPromedioPrecio());

        Console.WriteLine();

        Console.WriteLine("LIBROS CON ID MAYOR A 15");

        foreach (Libro libro in linq.GetListById())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo}");
        }

        Console.WriteLine();

        Console.WriteLine("LIBROS FORMATEADOS");

        foreach (string libro in linq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine();

        Console.WriteLine("LIBRO CON MAYOR PRECIO");
        Console.WriteLine(linq.GetMayorPrecio().Titulo);

        Console.WriteLine();

        Console.WriteLine("LIBRO CON MENOR PRECIO");
        Console.WriteLine(linq.GetMenorPrecio().Titulo);

        Console.WriteLine();

        Console.WriteLine("LIBROS MAYORES AL PROMEDIO");

        foreach (Libro libro in linq.GetMayorPromedio())
        {
            Console.WriteLine($"{libro.Titulo} - {libro.Precio}");
        }

        Console.WriteLine();

        Console.WriteLine("LIBROS ORDENADOS DESCENDENTE");

        foreach (Libro libro in linq.GetOrdenDescendente())
        {
            Console.WriteLine(libro.Titulo);
        }
    
}
}
