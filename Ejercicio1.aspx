<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="WebApplicationProgra2Evaluacion2.Ejercicio11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es-sv" data-bs-theme="dark">
<head runat="server">
    <title>Ejercicio 1 - Cálculo de descuentos</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <style>
        .form-group.required .control-label:after {
            content: "*";
            color: red;
        }
    </style>
</head>
<body>
    <main>
        <div class="container py-4">
            <div class="bg-body-tertiary rounded-3 p-4">
                <h1 class="display-6 fw-bold text-center mb-4">Calculo de descuentos</h1>
                <!-- Renderizar formulario -->
                <form id="formCalculoDescuento" runat="server" class="form">
                    <div class="form-group mb-4 required">
                        <label for="txtMontoCompra" class="form-label fw-semibold control-label">Ingrese el monto de compra:</label>
                        <asp:TextBox CssClass="form-control w-50" ID="txtMontoCompra" runat="server"/>

                        <!-- Validacion mediante expresión regular -->
                        <asp:RegularExpressionValidator
                            ID="regexValidadorMonto"
                            runat="server"
                            ControlToValidate="txtMontoCompra"
                            ErrorMessage="El monto ingresado no es válido. Ingrese únicamente valores númericos (ej. 100 o 99.99)"
                            ValidationExpression="^\d+(\.\d{1,2})?$"
                            CssClass="text-danger fw-semibold"
                            Display="Dynamic" />
                    </div>
                    <div class="mb-4">
                        <asp:Button CssClass="btn btn-primary btn-md fw-semibold" ID="BtnCalculcarCompra" runat="server" Text="Calcular descuento" OnClick="BtnCalcular_Click"/>
                    </div>
                    <div class="mb-4 text-start">
                        <asp:Label ID="lblResultado" runat="server" CssClass="text-white" Text=""></asp:Label>
                    </div>
                </form>
            </div>
        </div>
    </main>
</body>
</html>
