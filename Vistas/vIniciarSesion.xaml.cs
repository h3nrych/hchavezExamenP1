namespace hchavezExamenP1.Vistas;

public partial class vIniciarSesion : ContentPage
{
	public vIniciarSesion()
	{
		InitializeComponent();
	}

    private void Button_ClickedIniciar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vLogin());
    }
}