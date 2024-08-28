using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest2
{
    internal class Studerende
    {
        #region Instance fields
        private string _name;
        private int _id;
        private string _adresse;
        private string _cpr;




        #endregion

        #region Constructor
        public Studerende()
        {
            _name = "";
            _id = 0;
            _adresse = "";
            _cpr = "";
        }


        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { if (value.Length < 2) { throw new FormatException("Name must contain more than 2 letters"); } _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { if (value < 0) { throw new FormatException("Id must be higher than 0"); } _id = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public string CprNummer
        {
            get { return _cpr; }
            set { if (value.Length != 10) { throw new FormatException("Cpr Number must be 10 charecters only"); } _cpr = value; }
        }

        #endregion

        #region Methods

        public override string ToString() { return $"Name: {Name} - Id: {Id} Adresse: {Adresse} - Cpr: {CprNummer}" ; }
        #endregion
    }
}
