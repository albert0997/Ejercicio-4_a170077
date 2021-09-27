using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculararea
{
    public class Figuras
    {
        public decimal lado { get; set; }
        public decimal altura { get; set; }
        public decimal radio { get; set; }

        public decimal calcularcuadrado(decimal lado)
        {
            return lado * lado;
        }

        public decimal calculatriangulo (decimal lado, decimal altura)
        {
            return (lado * altura) / 2;
        }

        public decimal calcularcirculo (decimal radio)
        {
            var resultado = Math.PI * Math.Pow(Convert.ToDouble(radio), 2);
            return Convert.ToDecimal(resultado);
        }
    }
}