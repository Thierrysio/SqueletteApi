using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.Modeles
{
    [Table("Ville")]
    public class Ville
    {
        #region Attributs
        public static List<Ville> CollClasse = new List<Ville>();


        #endregion

        #region Constructeurs

        public Ville()
        {
            Ville.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nom { get; set; }
        [ManyToMany(typeof(Vendre))]
        public List<Magasin> LesMagasins { get; set; }
        
        [ForeignKey(typeof(Pays))]
        public int PaysId { get; set; }
        #endregion

        #region Methodes

        #endregion
    }
}
