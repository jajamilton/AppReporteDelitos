
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
	
	///Metodo que permite conectar con la capa de datos que permite consumir y registrar nuevos registros
	public void GuardeInformacion(){

		try
		{
			if(validacioninfo()){

				string Resultado = Data.RegistroUsuario(
					NombreUsuario.Text,
					Apellido.Text,
					Correo.Text,
					Direccion.Text,
					Celular.Text,
					Contraseña.Text)


				if(Resultado 1= null && Resultado != false){
					await DisplayAlert($"Exito Usuario {NombreUsuario.Text} creado", "Registro realizado, por favor vuelva al inicio e inicie sesion", "ok");
				}
			}
		}
		catch (System.Exception)
		{
			await DisplayAlert($"Error Usuario {NombreUsuario.Text} creado", "Profavor Vuelva a intenrtarlo", "ok");
		}
	}

	/// validacion de campos diligenciados
	public bool validacioninfo(){

		bool validacion =true;
		foreach (Control campo in Registro.controls)
		{
			if(campo.Text== ""){
				validacion=false;
				break;
			}
		}
		return validacion
	}

}
