namespace AppReporteDelitos;

public partial class IniciarCelular : ContentPage
{
	public IniciarCelular()
	{
		InitializeComponent();
	}

	private void ClicEnviarCodigo(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ConfirmacionCodigo());

	}

    private void ClicRegresar(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }

}