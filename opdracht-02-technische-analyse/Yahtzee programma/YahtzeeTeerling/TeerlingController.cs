using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingController
    {

        // Member die de view opvangt
        TeerlingVieuw vieuw;
        public TeerlingModel model;
        static int seed = 0;
        //om random getal niet te laten dupliceren kan je dit meegeven bij het aanmaken van het random getal. Telkens je een nieuw random getal maakt kan je deze best wel ++ doen zodat dat ook altijd anders is.

        public TeerlingController()
        {

            // Maak nieuwe instantie aan van view
            vieuw = new TeerlingVieuw(this); //je moet een controller meegeven als parameter voor de view
            model = new TeerlingModel();

        }


        public TeerlingVieuw getView()
        {

            return vieuw;

        }

        public void Werp()
        {
            // model om aantal ogen te updaten
            Console.WriteLine("presenter spreekt controller aan");

            // Nieuwe instantie van random object
            Random random = new Random(seed);

            // Getal berekenen tussen 1 & 6
            int aantalOgen = random.Next(1, 7);

            // Het model updaten
            model.AantalOgen = aantalOgen;

            seed++;
        }


        public void ToggleVast()
        {

            model.IsVast = (!model.IsVast);

        }


        /*public void HideWerpButton()
        {

            model.IsVisible = false;

        }*/


       


        

    }
}
