using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystem
{
    public class Badetidsperiode
    {
        #region Instance Fields
        protected string _type;
        protected DayOfWeek _ugeDag;
        protected DateTime _startTidspunkt;
        protected DateTime _slutTidspunkt;

        #endregion

        #region Constructor 
        public Badetidsperiode(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            Type = type;
            UgeDag = ugeDag;
            StartTidspunkt = startTidspunkt;
            SlutTidspunkt = slutTidspunkt;
            Kredse = new Dictionary<string, Kreds>();

            try
            {
                if (StartTidspunkt > SlutTidspunkt)
                {
                    throw new ArgumentException() ;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Startstidspunktet kan ikke være efter slutstidspunktet!");
            }

            try
            {
                if (Type.Length < 4)
                {
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Type skal være mindst 4 tegn!");
            }
        }
        #endregion

        #region My Methods

        public virtual void AdderKreds(Kreds kreds)
        {
            Kredse.Add(kreds.ID, kreds);
        }
        
        public virtual void DeleteKreds(string id)
        {
            Kredse.Remove(id);
        }

        public override string ToString()
        {
           
            return $"Badetidstype:{Type} - Dato: {UgeDag} - {StartTidspunkt} til {SlutTidspunkt}";
        }

        public virtual void HurtigOversigt()
        {
            foreach (KeyValuePair<string, Kreds> kreds in Kredse)
            {
                Console.WriteLine($"{kreds.Key}, {kreds.Value}");
            }
        }

        #endregion

        #region Properties
        public string Type { get; set; }

        public DayOfWeek UgeDag { get; set; }

        public DateTime StartTidspunkt { get; set; }

        public DateTime SlutTidspunkt { get; set; }

        public Dictionary<string, Kreds> Kredse { get; set; }
        #endregion
    }
}
