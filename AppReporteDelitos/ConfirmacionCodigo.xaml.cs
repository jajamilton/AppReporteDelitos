namespace AppReporteDelitos;

public partial class ConfirmacionCodigo : ContentPage
{
	public ConfirmacionCodigo()
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