using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCsharp.Models
{
    interface IConAlcohol
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado();
    }
}
