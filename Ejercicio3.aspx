<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="WebApplicationProgra2Evaluacion2.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es-sv">
<head runat="server">
    <title>Ejercicio 3 - Cálculo de descuento a compra</title>
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
            <div class="bg-dark rounded-3 p-4">
                <h1 class="display-6 fw-bold text-center mb-4">Calculadora de descuento a compra</h1>
                <!-- Renderizar formulario -->
                <form id="formCalculoSalario" runat="server" class="form">
                    <div class="form-group required mb-2">

                        <label for="txtMontoSalario" class="form-label fw-semibold control-label">Ingrese su salario:</label>
                        <asp:TextBox CssClass="form-control w-50" ID="txtMontoSalario" runat="server" />
                        
                        <asp:RequiredFieldValidator
                            ID="RequiredTxtMontoSalario" 
                            runat="server" 
                            ControlToValidate="txtMontoSalario" 
                            Display="Static" 
                            ErrorMessage="El campo de salario es requerido. *" 
                            CssClass="text-danger fw-semibold mb-4" />

                        <!-- Validacion mediante expresión regular -->
                        <asp:RegularExpressionValidator
                            ID="regexValidadorSalario"
                            runat="server"
                            ControlToValidate="txtMontoSalario"
                            ErrorMessage="El monto ingresado no es válido. Ingrese únicamente valores númericos (ej. 100 o 99.99)"
                            ValidationExpression="^\d+(\.\d{1,2})?$"
                            CssClass="text-danger fw-semibold"
                            Display="Static" />
                    </div>
                    <div class="mb-4">
                        <asp:Button CssClass="btn btn-primary fw-semibold" ID="BtnCalculcarDescuento" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
                    </div>
                    <div class="mt-4">

                        <asp:Label ID="LblResultado" Text="" runat="server" />
                    </div>
                </form>
            </div>
        </div>
    </main>
</body>
</html>

