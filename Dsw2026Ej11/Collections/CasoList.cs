namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;


//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno> alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public List<Alumno> retornarLista()
    {
        return alumnos;
    }

    public Alumno BuscarAlumno(string nombre)
    {
        foreach(Alumno alumno in alumnos)
        {
            if (alumno.Nombre == nombre)
            {
                return alumno;
            }
            
        }
        return null;
    }
    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }
    public void PosicionDeterminada(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
    }
}
