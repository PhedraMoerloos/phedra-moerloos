using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingModel
    {

        private int aantalOgen;
        private bool isVast;
        private bool isVisible = false;
        

        public TeerlingModel()
        {

        }

        public int AantalOgen
        {
            get
            {
                return aantalOgen;
            }
            set
            {
                aantalOgen = value;
            }
        }



        public bool IsVast
        {
            get
            {
                return isVast;
            }
            set
            {
                isVast = value;
            }
        }


        public bool IsVisible
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible = value;
            }
        }


        







    }
}
