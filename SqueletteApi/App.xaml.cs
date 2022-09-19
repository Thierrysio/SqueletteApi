using SqueletteApi.Vues;

namespace SqueletteApi;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new EncheresEnCoursVue();
	}
}
