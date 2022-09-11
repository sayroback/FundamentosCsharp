using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCsharp.Models
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public string añoFundacion;

        public void Timbrar()
        {
            //Cancion de Zelda 
            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //
            Console.Beep(783, 250); //Sol
            Console.Beep(880, 250); //La
            Console.Beep(987, 1000); //
            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //
            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(1760, 1000); //La'
            Console.Beep(1567, 500); //Sol'
            Console.Beep(1174, 1000); //Re
            Console.Beep(1046, 250); //Do
            Console.Beep(987, 250); //Si
            Console.Beep(880, 1000); //La

            //Console.Beep(523, 500); //Do
        }
    }
}
