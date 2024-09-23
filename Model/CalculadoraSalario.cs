using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationProgra2Evaluacion2.Model
{
    public class CalculadoraSalario
    {
        private const decimal PORCENTAJE_AFP = 5.0m;
        private const decimal PORCENTAJE_ISSS = 3.0m;
        private const decimal PORCENTAJE_RENTA = 10.0m;
        private const decimal PORCENTAJE_SEGURO_MINIMO = 4.0m;
        private const decimal PORCENTAJE_SEGURO_MAXIMO = 6.0m;

        public decimal SalarioBruto { get; set; }
        public CalculadoraSalario() { }

        public CalculadoraSalario(decimal salarioBruto)
        {
            if (salarioBruto <= 0)
                throw new ArgumentException(nameof(salarioBruto), "El salario bruto no puede ser negativo");

            SalarioBruto = salarioBruto;
        }

        /// <summary>
        /// Calcula el total de descuentos en concepto de ISSS.
        /// </summary>
        public decimal DescuentoIsss => SalarioBruto > 657.25m ? SalarioBruto * (PORCENTAJE_ISSS / 100) : 0;

        /// <summary>
        /// Calcula el total de descuentos en concepto de renta.
        /// </summary>
        public decimal DescuentoRenta => SalarioBruto > 857.15m ? SalarioBruto * (PORCENTAJE_RENTA / 100) : 0;

        /// <summary>
        /// Calcula el total de descuentos de AFP.
        /// </summary>
        public decimal DescuentoAfp => SalarioBruto > 450.00m ? SalarioBruto * (PORCENTAJE_AFP / 100) : 0;

        /// <summary>
        /// Calcula el total de descuentos de seguros.
        /// </summary>
        public decimal DescuentoSeguros => SalarioBruto < 1000 ? SalarioBruto * (PORCENTAJE_SEGURO_MINIMO / 100) : SalarioBruto * (PORCENTAJE_SEGURO_MAXIMO / 100);

        /// <summary>
        /// Calcula el salario neto (liquido) después de descuentos.
        /// </summary>
        public decimal SalarioNeto => SalarioBruto - TotalDescuentos;

        /// <summary>
        /// Calcula el total de todos los descuentos.
        /// </summary>
        public decimal TotalDescuentos => DescuentoIsss + DescuentoRenta + DescuentoAfp + DescuentoSeguros;
    }
}