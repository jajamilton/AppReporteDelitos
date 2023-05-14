
using CommunityToolkit.Maui.Alerts;

namespace AppReporteDelitos;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

	private async void ClicRegistrarse(object sender, EventArgs e)
	{
        await DisplayAlert($"Exito Usuario {NombreUsuario.Text} creado", "Registro realizado, por favor vuelva al inicio e inicie sesion", "ok");

		NombreUsuario.Text =string.Empty;
        Apellido.Text = string.Empty;
        Correo.Text=string.Empty;
        Direccion.Text=string.Empty;
        Celular.Text=string.Empty;
        Contraseña.Text=string.Empty;
    }

	private void ClicRegresar(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

}