using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest2
{
    internal class Hold
    {
        public Dictionary<int, Studerende> Allestudernde = new Dictionary<int, Studerende>();


        #region Instance fields
        private string _type;
        private int _optagelsesår;
        private string _lokation;
        private string _betegnelse;
        private bool _vinteroptage;




        #endregion

        #region Constructor
        public Hold()
        {
            Dictionary<int, Studerende> Studerende = Allestudernde;
            _type = "";
            _optagelsesår = 2024;
            _lokation = "";
            _betegnelse = "";
            _vinteroptage = false;
        }


        #endregion

        #region Properties
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Optagelsesår
        {
            get { return _optagelsesår; }
            set { _optagelsesår = value; }
        }
        public string Lokation
        {
            get { return _lokation; }
            set { _lokation = value; }
        }
        public string Betegnelse
        {
            get { return _betegnelse; }
            set { _betegnelse = value; }
        }
        public bool Vinteroptag
        {
            get { return _vinteroptage; }
            set { _vinteroptage = value; }
        }

        #endregion

        #region Methods

        public void AdderStudent(Studerende studerende)
        {
            Allestudernde.Add(studerende.Id, studerende);
        }

        public void DeleteStudent(int id)
        {
            Allestudernde.Remove(id);

        }

        public void PrintStuderende()
        {
            Console.WriteLine("\n\nStuderende på holdet\n\n");
           foreach(Studerende s in Allestudernde.Values) { Console.WriteLine(s); }
        }


        public override string ToString() { return $"Type: {Type} - Optagelsesår: {Optagelsesår} Lokation: {Lokation} - Betegnelse: {Betegnelse} - Vinteroptag: {Vinteroptag}"; }
        #endregion
    }
}
