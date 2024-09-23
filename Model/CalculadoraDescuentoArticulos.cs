using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationProgra2Evaluacion2.Model
{
    public class CalculadoraDescuentoArticulos
    {
        private const int DESCUENTO_I = 10;
        private const int DESCUENTO_II = 20;
        private const int DESCUENTO_III = 30;
        private const int DESCUENTO_IV = 40;
        private const int DESCUENTO_V = 50;

        // Utilizada para almacenar el total de descuento
        private decimal totalDescuento;

        public decimal TotalCompra { get; set; }
        public int CantidadArticulos { get; set; }


        public decimal TotalDescuento()
        {
            if(CantidadArticulos >= 1 && CantidadArticulos <= 5)
            {
                totalDescuento = TotalCompra * (DESCUENTO_I / 100);
            }
            else if(CantidadArticulos >= 6 && CantidadArticulos <= 10)
            {
                totalDescuento = TotalCompra * (DESCUENTO_II / 100);
            }
            else if(CantidadArticulos >= 11 && CantidadArticulos <= 15)
            {
                totalDescuento = TotalCompra * (DESCUENTO_III / 100);
            }
            else if(CantidadArticulos >= 16 && CantidadArticulos <= 20)
            {
                totalDescuento = TotalCompra * (DESCUENTO_III / 100);
            }

            return totalDescuento;
        }

        public decimal TotalPagar()
        {
            return TotalCompra - totalDescuento;
        }

    }
}