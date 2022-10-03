
using SqueletteApi.VueModeles;

namespace SqueletteApi.Vues;

public partial class DessinVue : ContentPage
{
	DessinVueModele vueModele;
    public DessinVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new DessinVueModele();
       // TOTO.IsAnimationPlaying = false;

    }


   
    private void Button_Clicked(object sender, EventArgs e)
	{
        TOTO.IsAnimationPlaying = true;
    }
}