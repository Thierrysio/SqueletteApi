using SqueletteApi.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.VueModeles
{
    public  class DatabaseVueModele : BaseVueModele
    {
        #region Attributs


        #endregion

        #region Constructeurs

        public DatabaseVueModele()
        {
            this.TestDatabase();
        }

        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes

        public async void TestDatabase()
        {
            // instancier les objets
            Pays lePays = new Pays();
            Magasin leMagasin = new Magasin();
            Ville laVille = new Ville();

            //Implementer les objets
            
            lePays.Id = 0;
            lePays.Nom = "France";
            lePays.LesVilles = new List<Ville>();

            leMagasin.Id = 0;
            leMagasin.Nom = "Darty";
            leMagasin.LesVilles = new List<Ville>();

            laVille.Id = 0;
            laVille.Nom = "Lannion";
            laVille.LesMagasins = new List<Magasin>();

            lePays.LesVilles.Add(laVille);
            leMagasin.LesVilles.Add(laVille);
            laVille.LesMagasins.Add(leMagasin);

            //serialisation des objets bruts dans la database
            await App.Database.SaveItemAsync<Ville>(laVille);
            await App.Database.SaveItemAsync<Pays>(lePays);
            await App.Database.SaveItemAsync<Magasin>(leMagasin);

            // Creation des jointures
            await App.Database.MiseAJourItemRelation(lePays);
            await App.Database.MiseAJourItemRelation(leMagasin);
            await App.Database.MiseAJourItemRelation(laVille);

            // Recuperation du magasin
            var MagasinDB = App.Database.GetItemAvecRelations(leMagasin);
            string nomMagasin = MagasinDB.Result.Nom;
            List<Ville> l = MagasinDB.Result.LesVilles;
        }

        #endregion
    }
}
