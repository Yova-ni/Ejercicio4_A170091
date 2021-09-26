using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Areas1
{
    public class Areacalculo1
    {
        public decimal base1 { get; set; }
        public decimal altura { get; set; }
        public decimal radio { get; set; }
        public decimal areacuadrado(decimal base1)
        {
            
            return base1 * base1;
        }

        public decimal areatriangulo (decimal base1, decimal altura)
        {
            return (base1 * altura) / 2;
        }

        public decimal areacirculo(decimal radio)
        {
            var resultado = Math.PI * Math.Pow(Convert.ToDouble(radio), 2);
            return Convert.ToDecimal(resultado);
        }
    }
}