using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.Services
{
    public class Api
    {
        public async Task<ObservableCollection<T>> GetAllAsync<T>(string paramUrl, List<T> param)
        {
            try
            {
                //creation d'un navigateur
                var clientHttp = new HttpClient();
                //envoi d'une requete par URL et attente d'une reponse sous forme JSON
                var json = await clientHttp.GetStringAsync(Constantes.BaseApiAddress + paramUrl);
                //Conversion du JSON en objet
                JsonConvert.DeserializeObject<List<T>>(json, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
                //Retour sous forme de liste
                return GestionCollection.GetListes<T>(param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
