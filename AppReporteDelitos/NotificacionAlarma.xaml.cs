namespace AppReporteDelitos;

public partial class NotificacionAlarma : ContentPage
{
	public NotificacionAlarma()
	{
		InitializeComponent();
	}

	private async void ClicAlarma(object sender, EventArgs e)
	{
		await DisplayAlert("Alarma Generada", "", "OK");
	}


	private void ClicCerrar(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

}