using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.Modeles
{
    [Table("Magasin")]
    public class Magasin
    {
        #region Attributs

        public static List<Magasin> CollClasse = new List<Magasin>();

        #endregion

        #region Constructeurs

        public Magasin()
        {
            Magasin.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nom { get; set; }
        [ManyToMany(typeof(Vendre))]
        public List<Ville> LesVilles { get; set; }
        #endregion

        #region Methodes

        #endregion
    }
}
