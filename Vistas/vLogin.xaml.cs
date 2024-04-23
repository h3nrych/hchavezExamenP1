namespace hchavezExamenP1.Vistas;

public partial class vLogin : ContentPage
{

    string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] contrase�as = { "uisrael2024", "parcial1", "2024" };

    public vLogin()
    {
        InitializeComponent();
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrase�aIngresada = txtContrasena.Text;

        bool usuarioValido = false;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuarioIngresado && contrase�as[i] == contrase�aIngresada)
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
            DisplayAlert("Alerta", "Usuario/Contrase�a incorrectas", "cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}