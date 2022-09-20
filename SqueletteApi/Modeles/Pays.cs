using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.Modeles
{
    [Table("Pays")]
    public class Pays
    {
        #region Attributs

        public static List<Pays> CollClasse = new List<Pays>();
       


        #endregion

        #region Constructeurs

        public Pays()
        {
            Pays.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nom { get; set; }
        
        [OneToMany]
        public List<Ville> LesVilles { get; set; }
        #endregion

        #region Methodes

        #endregion
    }
}
