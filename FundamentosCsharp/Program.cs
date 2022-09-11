using System;
using System.Collections.Generic;
using FundamentosCsharp.Models;

namespace FundamentosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Fanta", 2);
            bebida.Beber();

            Cerveza cerveza = new Cerveza(3);
            cerveza.Beber();
            cerveza.MaxRecomendado();

            Escuela escuela = new Escuela();
            escuela.nombre = "Franco";
            Console.WriteLine(escuela.nombre);
            escuela.Timbrar();
        }
    }
}
