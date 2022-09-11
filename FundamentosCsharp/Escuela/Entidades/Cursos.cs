using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCsharp.Escuela.Entidades
{
    public class Cursos
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public Cursos() => UniqueID = Guid.NewGuid().ToString();
        
    } 
}
