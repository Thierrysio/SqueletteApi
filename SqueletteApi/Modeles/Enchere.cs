using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqueletteApi.Modeles
{
    public class Enchere
    {
        #region Attributs
        public static List<Enchere> CollClasse = new List<Enchere>();
        private int _id;
        private DateTime _datedebut;
        private DateTime _datefin;
        private double _prixReserve;
        private double _prixDepart;
       

        #endregion

        #region Constructeurs

        public Enchere(int id, DateTime datedebut, DateTime datefin, double prixReserve)
        {
            Enchere.CollClasse.Add(this);
            this._id = id;
            this._datedebut = datedebut;
            this._datefin = datefin;
            this._prixReserve = prixReserve;
            
        }

        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public DateTime Datedebut { get => _datedebut; set => _datedebut = value; }
        public DateTime Datefin { get => _datefin; set => _datefin = value; }
        public double PrixReserve { get => _prixReserve; set => _prixReserve = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
