using SqueletteApi.VueModeles;

namespace SqueletteApi.Vues;

public partial class DessinVue : ContentPage
{
	DessinVueModele vueModele;
    public DessinVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new DessinVueModele();
	}
}