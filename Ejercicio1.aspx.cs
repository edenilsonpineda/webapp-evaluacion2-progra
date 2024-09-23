using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationProgra2Evaluacion2.Model;

namespace WebApplicationProgra2Evaluacion2
{
    public partial class Ejercicio11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal montoCompra = decimal.Parse(txtMontoCompra.Text);
            decimal porcentajeDescuento = GetPorcentajeDescuento(montoCompra);


            // Creacion de instancia de clase Calculadora de descuentos
            CalculadoraDescuento calculadoraDescuento = new CalculadoraDescuento(montoCompra);

            // Calcular monto de descuento y total a pagar
            decimal montoDescuento = calculadoraDescuento.CalcularDescuento(porcentajeDescuento);
            decimal totalAPagar = calculadoraDescuento.GetTotalPagar();

            lblResultado.Text = $"<strong>Total de compra:</strong> {montoCompra:C} <br/> " +
                $"<strong>Porcentaje de descuento aplicado:</strong> {porcentajeDescuento}% <br/>" +
                $"<strong>Total descuento: </strong> {montoDescuento:C}<br/>" +
                $"<strong>Total a pagar: </strong>{totalAPagar:C}";
        }

        private decimal GetPorcentajeDescuento(decimal montoCompra)
        {
            if (montoCompra >= 1 && montoCompra <= 100)
            {
                return 10;
            }
            else if (montoCompra > 100 && montoCompra <= 400)
            {
                return 15;
            }
            else if (montoCompra > 400 && montoCompra <= 600)
            {
                return 20;
            }
            else if(montoCompra > 600)
            {
                return 25;
            }

            return 0;
        }
    }
}