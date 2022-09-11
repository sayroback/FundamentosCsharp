using System;
using System.Collections.Generic;
using FundamentosCsharp.Models;
using FundamentosCsharp.Escuela.Entidades;

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

var curso = new Cursos() { Nombre = "301" };

Console.WriteLine(platzi);
Console.WriteLine("=========");
Console.WriteLine(curso.Nombre + ", " + curso.UniqueID);