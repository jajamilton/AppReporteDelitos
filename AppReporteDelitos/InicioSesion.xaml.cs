namespace AppReporteDelitos;

public partial class InicioSesion : ContentPage
{
	public InicioSesion()
	{
		InitializeComponent();
	}

	private void ClicIniciar(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Menu());
	}

    private void ClicRegresar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }


}