using static System.Console;
using FundamentosCsharp.Models;

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

                platzi.CursosEscuela = new Cursos[] 
        { 
            new Cursos { Nombre = "301" }, 
            new Cursos { Nombre = "201" }, 
            new Cursos { Nombre = "101" }
        };
        //cursos[0] = new Cursos { Nombre = "301" };
        //cursos[1] = new Cursos { Nombre = "201" };
        //cursos[2] = new Cursos { Nombre = "101" };

        imprimirEscuela(platzi);
        WriteLine("=========");

        void imprimirEscuela(Escuela escuela)
        {
            WriteLine("=========");
            WriteLine("Cursos de la escuela: " + escuela.nombreEscuela);
            imprimirCursos(escuela.CursosEscuela);
        }

        void imprimirCursos(Cursos[] cursos)
        {
            foreach (var curso in cursos)
            {
                WriteLine(curso.Nombre + ", " + curso.UniqueID);
            }
        }


}
}
}
