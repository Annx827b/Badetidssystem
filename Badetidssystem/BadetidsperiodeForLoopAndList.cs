using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystem
{
    public class BadetidsperiodeForLoopAndList : Badetidsperiode
    {
        public BadetidsperiodeForLoopAndList(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt) : base(type, ugeDag, startTidspunkt, slutTidspunkt)
        {
            KredsListe = new List<Kreds>();
        }

        #region My Methods
        public override void AdderKreds(Kreds kreds)
        {
            KredsListe.Add(kreds);
        }

        public override void DeleteKreds(string id)
        {
            foreach(Kreds kreds in KredsListe)
            {
                if (kreds.ID == id)
                {
                    KredsListe.Remove(kreds);
                    break;
                }
            }
        }

        public override string ToString() 
        {
            return $"Type Of Swimming Activity: {Type} - Every {UgeDag} - At {StartTidspunkt} Till {SlutTidspunkt}"; 
        }
        #endregion

        #region Properties
        public List<Kreds> KredsListe{ get; set; }
        #endregion
        
   
    }
}
