using SqueletteApi.Modeles;
using SqueletteApi.Services;
using SqueletteApi.Vues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.VueModeles
{
    internal class UserVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();



        #endregion

        #region Constructeurs

        public UserVueModele()
        {
            this.PostUser(new User(0, "esssssai01", "tititiddddtit","pseudo","ddd"));
        }

        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes

        public async void PostUser(User param)
        {
            int x = await _apiServices.PostAsync<User>(param, "api/postUser");
           
        }

        #endregion
    }
}
