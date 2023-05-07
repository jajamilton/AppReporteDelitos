namespace AppReporteDelitos;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Registro();
	}
}
