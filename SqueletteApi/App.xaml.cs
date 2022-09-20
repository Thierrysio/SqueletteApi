using SqueletteApi.Services;
using SqueletteApi.Vues;

namespace SqueletteApi;

public partial class App : Application
{
    static GestionDatabase database;
    public App()
	{
		InitializeComponent();

		MainPage = new DatabaseVue();
	}
    public static GestionDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new GestionDatabase();
            }
            return database;
        }
    }
}
