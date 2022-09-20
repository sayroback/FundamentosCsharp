﻿using FundamentosCsharp.Models;
using static System.Console;

namespace FundamentosCsharp.Escuela.Entidades
{
  public class Ejemplos
  {
    public Ejemplos()
    {

      Bebida bebida = new Bebida("Fanta", 2);
      bebida.Beber();

      Cerveza cerveza = new Cerveza(3);
      cerveza.Beber();
      cerveza.MaxRecomendado();

      //TimbreEscuela escuela = new TimbreEscuela();
      //escuela.nombre = "Franco";
      //Console.WriteLine(escuela.nombre);
      //escuela.Timbrar();

      var platzi = new Escuela("platzi", 2014, tipo: TiposEscuela.Secundaria, ciudad: "Mexico");
      //platzi.cuidad = "Mexico";
      //platzi.tipoEscuela = TiposEscuela.Secundaria;

      platzi.CursosEscuela = new List<Cursos>()
      {
        new Cursos { Nombre = "301", Jornada = TiposJornada.Mañana },
        new Cursos { Nombre = "201", Jornada = TiposJornada.Mañana },
        new Cursos { Nombre = "101", Jornada = TiposJornada.Mañana }
      };
      //cursos[0] = new Cursos { Nombre = "301" };
      //cursos[1] = new Cursos { Nombre = "201" };
      //cursos[2] = new Cursos { Nombre = "101" };

      // agregar elemento a una lista
      platzi.CursosEscuela.Add(new Cursos { Nombre = "401", Jornada = TiposJornada.Tarde });
      platzi.CursosEscuela.Add(new Cursos { Nombre = "202", Jornada = TiposJornada.Tarde });
      
      var otraColeccion = new List<Cursos>()
      {
        new Cursos { Nombre = "501", Jornada = TiposJornada.Mañana },
        new Cursos { Nombre = "603", Jornada = TiposJornada.Mañana },
        new Cursos { Nombre = "502", Jornada = TiposJornada.Mañana }
      };
      //Agrega otra colleccion a una colleccion
      platzi.CursosEscuela.AddRange(otraColeccion);
      
      imprimirEscuela(platzi);
      WriteLine("=========");
      //Elimina todos los elementos de una collecion
      //platzi.CursosEscuela.Clear();

      //Remover un elemento
      // platzi.CursosEscuela.Remove();
      imprimirEscuela(platzi);

      void imprimirEscuela(Escuela escuela)
      {
        WriteLine("=========");
        WriteLine("Cursos de la escuela: " + escuela.nombreEscuela);
        imprimirCursos(escuela.CursosEscuela);
      }

      void imprimirCursos(List<Cursos> cursos)
      {
        foreach (var curso in cursos)
        {
          WriteLine(curso.Nombre + ", " + curso.UniqueID);
        }
      }


    }
  }
}
