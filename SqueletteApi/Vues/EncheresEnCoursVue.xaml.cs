using SqueletteApi.VueModeles;

namespace SqueletteApi.Vues;

public partial class EncheresEnCoursVue : ContentPage
{
	EncheresEnCoursVueModele vueModele;
    public EncheresEnCoursVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new EncheresEnCoursVueModele();
	}
}