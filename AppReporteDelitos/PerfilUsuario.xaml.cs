namespace AppReporteDelitos;

public partial class PerfilUsuario : ContentPage
{
	public PerfilUsuario()
	{
		InitializeComponent();
	}

	private void ClicCerrar(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}


}