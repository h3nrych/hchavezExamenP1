using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hchavezExamenP1.Vistas;
public partial class vResumen : ContentPage
{
    private string _usuario;
    public vResumen(string nombre, string apellido, string edad, string fecha, string pais, string ciudad, string montoInicial, string pagoMensual, string usuarioIngresado)
    {
        InitializeComponent();
        _usuario = usuarioIngresado;
        lblUsuario.Text = "Usuario: " + usuarioIngresado;

        lblNombre.Text =  nombre;
        lblApellido.Text =   apellido;
        lblEdad.Text =   edad;
        lblFecha.Text =  fecha;
        lblCiudad.Text = ciudad;
        lblPais.Text =  pais;
        lblMontoInicial.Text = montoInicial;
        lblPagoMensual.Text =   pagoMensual;

        
        double montoInicialDouble;
        if (double.TryParse(montoInicial, out montoInicialDouble))
        {
            
            double costoCurso = 3000;
            double cuotaMensual = costoCurso * 0.05;
            double montoTotalCuotas = cuotaMensual * 3;

           
            double pagoTotal = montoInicialDouble + montoTotalCuotas;

            
            lblPagoTotal.Text =  pagoTotal.ToString();
        }
        else
        {
            
            DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "Aceptar");
        }
    }

    private async void btnSalir_Clicked(object sender, EventArgs e)
    {
        var iniciarSesionPage = new vIniciarSesion();

        await Navigation.PushAsync(iniciarSesionPage);
    }

}


