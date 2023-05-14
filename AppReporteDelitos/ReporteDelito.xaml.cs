namespace AppReporteDelitos;

public partial class ReporteDelito : ContentPage
{
	public ReporteDelito()
	{
		InitializeComponent();
	}

	private void ClicCerrar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

	private async void ClicReportar(object sender, EventArgs e)
	{
		await DisplayAlert("Delito reportado", "", "OK");
	}
}