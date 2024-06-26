namespace hchavezExamenP1.Vistas;

public partial class vLogin : ContentPage
{

    string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] contraseņas = { "uisrael2024", "parcial1", "2024" };

    public vLogin()
    {
        InitializeComponent();
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contraseņaIngresada = txtContrasena.Text;

        bool usuarioValido = false;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuarioIngresado && contraseņas[i] == contraseņaIngresada)
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
        {
            Navigation.PushAsync(new vRegistro(usuarioIngresado));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseņa incorrectas", "cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}