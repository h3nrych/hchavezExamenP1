namespace hchavezExamenP1.Vistas;

public partial class vRegistro : ContentPage
{
    private string _usuario;

    public vRegistro(string usuarioIngresado)
    {
        InitializeComponent();
        _usuario = usuarioIngresado;
        lblUsuario.Text = "Usuario: " + usuarioIngresado;
    }
    

    private void btnMensualidad_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(initialAmountEntry.Text, out double montoInicial))
        {
            double costoCurso = 3000;
            double resto = costoCurso - montoInicial;
            double mensualidad = (resto / 3) * 1.05; 
            initialAmountEntry.Text = montoInicial.ToString(); 
            monthlyPaymentEntry.Text = mensualidad.ToString(); 
        }
        else
        {
            DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "Aceptar");
        }

    }

    private async void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = datePicker.Date.ToString("dd/MM/yyyy");
        string pais = countryPicker.SelectedItem.ToString();
        string ciudad = cityPicker.SelectedItem.ToString();
        string montoInicial = initialAmountEntry.Text;
        string pagoMensual = monthlyPaymentEntry.Text;

        var resumenPage = new vResumen(nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual, _usuario);

        await Navigation.PushAsync(resumenPage);
    }



}