using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.VueModeles
{
    public class EncheresEnCoursVueModele
    {
        #region Attributs

        private ObservableCollection<Enchere> _maListeEncheresEnCoursTypeClassique;

        #endregion

        #region Constructeurs

        public EncheresEnCoursVueModele()
        {

        }

        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes
        public async void GetListeEnCheresEnCoursTypeClassique(int id)
        {
            MaListeEncheresEnCoursTypeClassique = await _apiServices.GetAllAsyncID<Enchere>
                ("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", id);
            Enchere.CollClasse.Clear();

        }
        #endregion

    }
}
