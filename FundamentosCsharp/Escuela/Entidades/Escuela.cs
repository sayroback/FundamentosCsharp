using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCsharp.Escuela.Entidades
{
    class Escuela
    {
        public string nombreEscuela { get; set; }
        public int añoFundacion { get; set; }
        public string? cuidad { get; set; }
        public TiposEscuela tipoEscuela { get; set; }
        public Cursos[] CursosEscuela { get; set; }
        //public Escuela(string nombreEscuela, int añoFundacion, string cuidad)
        //{
        //    this.nombreEscuela = nombreEscuela;
        //    this.añoFundacion = añoFundacion;
        //    this.cuidad = cuidad;
        //}
        public Escuela(string nombre, int año) => (nombreEscuela, añoFundacion) = (nombre, año);
        public Escuela(string nombre, int año, TiposEscuela tipo, string ciudad)
        {
            (nombreEscuela, añoFundacion) = (nombre, año);
            cuidad = ciudad;
            tipoEscuela = tipo;
        }
        public override string ToString()
        {
            return $"\"Nombre\": {nombreEscuela}, Tipo: {tipoEscuela}\nCuidad: {cuidad}, Año: {añoFundacion}";
        }

    }
}

