using SqueletteApi.Modeles;
using SqueletteApi.Services;
using SqueletteApi.Vues;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.VueModeles
{
    internal class UserVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();

        private ObservableCollection<Magasin> _maListe;

        #endregion

        #region Constructeurs

        public UserVueModele()
        {
            this.TestBase();
            //this.PostUser(new User(0, "esssssai01", "tititiddddtit","pseudo","ddd"));
        }

        #endregion

        #region Getters/Setters
        public ObservableCollection<Magasin> MaListe
        {
            get { return _maListe; }
            set { SetProperty(ref _maListe, value); }
        }
        #endregion

        #region Methodes

        public async void PostUser(User param)
        {
            int x = await _apiServices.PostAsync<User>(param, "api/postUser");
           
        }
        public async void TestBase()
        {
            Pays lePays = new Pays();
            Magasin leMagasin = new Magasin();
            Ville laVille = new Ville();

            lePays.LesVilles = new List<Ville>();
            leMagasin.LesVilles = new List<Ville>();
            laVille.LesMagasins = new List<Magasin>();
            lePays.Id = 0;
            lePays.Nom = "zzz";
            leMagasin.Id = 0;
            leMagasin.Nom = "nom";
            laVille.Id = 0;
            laVille.Nom = "fghjg";
           

            lePays.LesVilles.Add(laVille);
            leMagasin.LesVilles.Add(laVille);
            laVille.LesMagasins.Add(leMagasin);
            await App.Database.SaveItemAsync<Pays>(lePays);
            await App.Database.SaveItemAsync<Magasin>(leMagasin);
            await App.Database.SaveItemAsync<Ville>(laVille);

            await App.Database.MiseAJourItemRelation(lePays);
            await App.Database.MiseAJourItemRelation(leMagasin);
            await App.Database.MiseAJourItemRelation(laVille);


            var MagasinStored = App.Database.GetItemAvecRelations(leMagasin);
            var VilleStored = App.Database.GetItemAvecRelations(laVille);

            string x = MagasinStored.Result.Nom;
            List<Ville> l = MagasinStored.Result.LesVilles;
            List<Magasin> l2 = VilleStored.Result.LesMagasins;

            MaListe =  App.Database.GetItemsAsync<Magasin>();
        }
        #endregion
    }
}
