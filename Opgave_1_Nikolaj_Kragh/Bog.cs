using System;
using System.Linq;

namespace Opgave_1_Nikolaj_Kragh
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        public string Titel
        {
            get { return _titel; }
            set
            {
                if (value.Length < 2)
                {
                    throw new TitleTooShortException();
                }
                _titel = value;

            }
        }

        public string Forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }

        public int Sidetal
        {
            get { return _sidetal; }
            set
            {
                if (value < 10 || value > 1000)
                {
                    throw new TooManyPagesException();
                }
                _sidetal = value; 

            }
        }

        public string Isbn13
        {
            get { return _isbn13; }
            set
            {
                if (value.Length != 13)
                {
                    throw new ISBN13NotValidException();
                }
                _isbn13 = value; 

            }
        }

        public Bog() { }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            Titel = titel;
            Forfatter = forfatter;
            Sidetal = sidetal;
            Isbn13 = isbn13;
        }
    }

    public class ISBN13NotValidException : Exception
    {
        public ISBN13NotValidException() : base("ISBN13 skal være præcis 13 karakterer.")
        {
            
        }
    }

    public class TooManyPagesException : Exception
    {
        public TooManyPagesException() : base("Sidetal skal være mellem 10 og 1000, begge tal inklusiv.")
        {
            
        }
    }

    public class TitleTooShortException : Exception
    {
        public TitleTooShortException() : base("Titlen skal være 2 karakterer eller længere.")
        {

        }
    }
}
