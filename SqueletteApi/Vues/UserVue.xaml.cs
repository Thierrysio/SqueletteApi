using SqueletteApi.VueModeles;

namespace SqueletteApi.Vues;

public partial class UserVue : ContentPage
{
	UserVueModele vueModele;
    public UserVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new UserVueModele();
	}
}