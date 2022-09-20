using SqueletteApi.VueModeles;

namespace SqueletteApi.Vues;

public partial class DatabaseVue : ContentPage
{
	DatabaseVueModele vueModele;
    public DatabaseVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new DatabaseVueModele(); 
	}
}