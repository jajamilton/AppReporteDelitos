namespace AppReporteDelitos;

public partial class InicioGoogle : ContentPage
{
	public InicioGoogle()
	{
		InitializeComponent();
	}

	private void ClicRegresar(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}


    private void ClicIniciar(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Menu());
    }



}