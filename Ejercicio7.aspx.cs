using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationProgra2Evaluacion2
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildButtonsList();
        }

        private void BuildButtonsList()
        {
            for (int i = 1; i <= 100; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                
                // Inscribir el controlador del evento 'click'
                button.Click += new EventHandler(Button_Click);
                button.CssClass = "btn btn-primary btn-equal fw-bold";

                ButtonsPanel.Controls.Add(button);
            }
        }

        void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            LblHeadingResult.Text = "<h1> Tabla de multiplicar del número " + clickedButton.Text.ToString() + "</h1>";
            LblResult.Text = "Ha hecho click en el botón con el No. " + clickedButton.Text.ToString();
        }
    }
}