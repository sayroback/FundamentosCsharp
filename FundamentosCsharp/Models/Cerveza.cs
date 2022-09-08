using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCsharp.Models
{ 
    class Cerveza : Bebida, IConAlcohol
    {
        public int Alcohol { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("Maximo permitido son 10 botellas");
        }
        public Cerveza(int Cantidad, string Name="Cerveza") : base(Name, Cantidad)
        {

        }
    }
}
