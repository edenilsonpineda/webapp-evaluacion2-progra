using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationProgra2Evaluacion2.Model;

namespace WebApplicationProgra2Evaluacion2
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected CalculadoraSalario calculadoraSalario;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if(txtMontoSalario.Text != "")
                {
                    decimal salarioBruto = decimal.Parse(txtMontoSalario.Text);
                    calculadoraSalario = new CalculadoraSalario(salarioBruto);

                    LblResultado.Text = $"<h4 class='mb-4'>Resum&eacute;n de Retenciones</h4>" +
                        $"<p class='fw-semibold'>Descuentos ISSS: <span class='text-danger fw-bold'>{calculadoraSalario.DescuentoIsss:C}</span></p>" +
                        $"<p class='fw-semibold'>Descuentos Renta: <span class='text-danger fw-bold'>{calculadoraSalario.DescuentoRenta:C}</span></p>" +
                        $"<p class='fw-semibold'>Descuentos AFP: <span class='text-danger fw-bold'>{calculadoraSalario.DescuentoAfp:C}</span></p>" +
                        $"<p class='fw-semibold'>Descuentos Seguros: <span class='text-danger fw-bold'>{calculadoraSalario.DescuentoSeguros:C}</span></p>" +
                        $"<p class='fw-semibold'>Total descuentos: <span class='text-danger fw-bold'>{calculadoraSalario.TotalDescuentos:C}</span></p>" +
                        $"<p class='fw-semibold'>Salario liquído: <span class='text-success fw-bold'>{calculadoraSalario.SalarioNeto:C}</span></p>";
                }
            }
        }
    }
}