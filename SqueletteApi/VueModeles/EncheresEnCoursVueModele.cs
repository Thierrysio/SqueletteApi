using SqueletteApi.Modeles;
using SqueletteApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.VueModeles
{
    public class EncheresEnCoursVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();

        private ObservableCollection<Enchere> _maListeEncheresEnCoursTypeClassique;
        private Enchere _maEnchere;
        #endregion

        #region Constructeurs

        public EncheresEnCoursVueModele()
        {
            this.GetEnchereTest("19");
        }

        #endregion

        #region Getters/Setters
        public ObservableCollection<Enchere> MaListeEncheresEnCoursTypeClassique
        {
            get { return _maListeEncheresEnCoursTypeClassique; }
            set { SetProperty(ref _maListeEncheresEnCoursTypeClassique, value); }
        }

        public Enchere MaEnchere
        {
            get { return _maEnchere; }
            set { SetProperty(ref _maEnchere, value); }
        }
        #endregion

        #region Methodes
        public async void GetListeEnCheresEnCoursTypeClassique()
        {
            MaListeEncheresEnCoursTypeClassique = await _apiServices.GetAllAsync<Enchere>
                ("api/getEncheresEnCours", Enchere.CollClasse);
            Enchere.CollClasse.Clear();

        }

        public async void GetEnchereTest(string param)
        {
            MaEnchere = await _apiServices.GetOneAsyncID<Enchere>
                ("api/getEnchereTest", param);
            Enchere.CollClasse.Clear();

        }
        #endregion

    }
}
