using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.Modeles
{
    [Table("Vendre")]
    public class Vendre
    {

        #region Attributs

        public static List<Vendre> CollClasse = new List<Vendre>();
       
        #endregion

        #region Constructeurs

        public Vendre()
        {
            Vendre.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [ForeignKey(typeof(Magasin))]
        public int MagasinId { get; set; }
        [ForeignKey(typeof(Ville))]
        public int VilleId { get; set; }

        #endregion

        #region Methodes

        #endregion
    }
}
