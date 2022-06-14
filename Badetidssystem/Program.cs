using System;

namespace Badetidssystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Badetidsperiode b1 = new Badetidsperiode("Aftendukkert", DayOfWeek.Wednesday, new DateTime(2022, 06, 08).AddHours(18).AddMinutes(30), new DateTime(2022, 06, 08).AddHours(20).AddMinutes(00));
            Badetidsperiode b2 = new Badetidsperiode("Morgendukkert", DayOfWeek.Monday, new DateTime(2022, 06, 22).AddHours(06).AddMinutes(30), new DateTime(2022, 06, 22).AddHours(08).AddMinutes(00));

            BadetidsperiodeForLoopAndList b3 = new BadetidsperiodeForLoopAndList("Formiddagsdukkert", DayOfWeek.Sunday, new DateTime(2022, 06, 12).AddHours(10).AddMinutes(00), new DateTime(2022, 06, 12).AddHours(12).AddMinutes(00));
            BadetidsperiodeForLoopAndList b4 = new BadetidsperiodeForLoopAndList("Natdukkert", DayOfWeek.Saturday, new DateTime(2022, 06, 15).AddHours(01).AddMinutes(00), new DateTime(2022, 06, 15).AddHours(03).AddMinutes(00));


            Kreds k1 = new Kreds("1", "Hajerne", "Piratstræde 3, 9930", 20, 10, 12);
            Kreds k2 = new Kreds("2", "Havfruerne", "Mågevej 80, 9930", 15, 12, 14);
            Kreds k3 = new Kreds("3", "Guppy", "Strandvejen 8, 9930", 30, 14, 15);
            Kreds k4 = new Kreds("4", "Klovnfiskene", "Skibsvraget 6, 9930", 40, 10, 15);

            Console.WriteLine("Velkommen til Badetidsystemet");
            Console.WriteLine();
            b1.AdderKreds(k1);
            Console.WriteLine(b1);
            b1.AdderKreds(k3);
            b1.DeleteKreds("1");
            b1.HurtigOversigt();
            Console.WriteLine();
            b2.AdderKreds(k4);
            Console.WriteLine(b2);
            b2.HurtigOversigt();
   
        }
    }
}
