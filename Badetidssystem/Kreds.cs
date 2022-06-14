using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystem
{
    public class Kreds
    {
        #region Instance Fields
        protected string _id;
        protected string _navn;
        protected string _adresse;
        protected int _antalDeltagere;
        protected int _minimumsAlder;
        protected int _maximumsAlder;
        #endregion

        #region Constructor 
        public Kreds(string iD, string navn, string adresse, int antalDeltagere, int minimumsAlder, int maximumsAlder )
        {
            ID = iD;
            Navn = navn;
            Adresse = adresse;
            AntalDeltagere = antalDeltagere;
            MinimumsAlder = minimumsAlder;
            MaximumsAlder = maximumsAlder;

            try
            {
                if (AntalDeltagere <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Antallet af deltagere skal være større end 0!");
            }

            try
            {
                if(MinimumsAlder>MaximumsAlder)
                {
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Minimumsalder må ikke være større end maximumsalder!");
            }
        }
        #endregion

        #region My Methods
        public override string ToString()
        {
            return $"ID: {ID} - Navn: {Navn} - Adresse: {Adresse} - Antal Deltagere: {AntalDeltagere} - Minimumsalder: {MinimumsAlder} år Maximumsalder: {MaximumsAlder} år";
        }
        #endregion

        #region Properties
        public string ID { get; set; }

        public string Navn { get; set; }

        public string Adresse { get; set; }

        public int AntalDeltagere { get; set; }

        public int MinimumsAlder { get; set; }

        public int MaximumsAlder { get; set; }
        #endregion
    }
}
