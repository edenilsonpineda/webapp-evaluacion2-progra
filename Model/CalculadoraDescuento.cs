using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationProgra2Evaluacion2.Model
{
    public class CalculadoraDescuento
    {
        public decimal Monto { get; set; }
        private decimal MontoDescuento { get; set; }

        // Constructor 
        public CalculadoraDescuento(decimal monto)
        {
            Monto = monto;
        }

        public decimal CalcularDescuento(decimal porcentaje)
        {
            MontoDescuento = Monto * (porcentaje / 100);
            
            return MontoDescuento;
        }

        public decimal GetTotalPagar()
        {
            return Monto - MontoDescuento;
        }
    }
}