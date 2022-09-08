using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCsharp.Models
{
    class Bebida
    {
        // public private protected: modificadores de acceso
        // Atributos
        public string Name { get; set; }
        public int Cantidad { get; set; }

        //Constructor
        public Bebida(string Name, int Cantidad)
        {
            this.Name = Name;
            this.Cantidad = Cantidad;
            
        }
        // Metodo
        public void Beber()
        {
            Cantidad -= 1;
            Console.WriteLine("Bebiste una " + Name + " te quedan " + Cantidad);
        }
    }
}
