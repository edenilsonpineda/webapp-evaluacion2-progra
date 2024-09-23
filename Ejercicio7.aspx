<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio7.aspx.cs" Inherits="WebApplicationProgra2Evaluacion2.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es-sv" data-bs-theme="dark">
<head runat="server">
    <title>Ejercicio 7 - Tabla de multiplicar dinámica</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <style>
        /**
        *  Definición de estilos para mostrar los botones con el mismo ancho
        *  y de forma tabular
        */

        .button-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(60px, 1fr));
            gap: 10px;
        }

        .btn-equal {
            width: 100%;
        }
    </style>
</head>
<body>
    <main>
        <div class="container py-4">
            <div class="bg-body-tertiary rounded-3 p-4">
                <div class="container-fluid py-5">
                    <form id="form1" runat="server">
                        <asp:Panel ID="ButtonsPanel" runat="server" CssClass="button-grid mb-4" />
                        
                        <asp:Label ID="LblHeadingResult" runat="server" Text="" CssClass="text-center mb-4" />
                        <asp:Label ID="LblResult" runat="server" Text="" />
                    </form>
                </div>
            </div>
        </div>
    </main>
</body>
</html>
