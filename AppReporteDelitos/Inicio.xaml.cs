namespace AppReporteDelitos;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
    }

	private void ClicIniciarSesion(object sender, EventArgs e)
	{
		Navigation.PushAsync(new InicioSesion());
	}

    private void ClicRegistrar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro());
    }

    private void ClicIniciarGoogle(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InicioGoogle());
    }

    private void ClicIniciarCelular(object sender, EventArgs e)
    {
        Navigation.PushAsync(new IniciarCelular());
    }



}