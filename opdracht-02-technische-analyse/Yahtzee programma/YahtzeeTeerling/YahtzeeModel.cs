using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeModel
    {


        public YahtzeeModel()
        {
            //constructor

        }

        private int aantalTeerlingen = 3;

        private int maxAantalWorpen = 3;

        private int aantalWorpen;

        private int score = 0;


        public int AantalTeerlingen
        {

            get
            {
                return aantalTeerlingen;
            }
            set
            {
                aantalTeerlingen = value;
            }

        }


        public int MaxAantalWorpen
        {

            get
            {
                return maxAantalWorpen;
            }
            set
            {
                maxAantalWorpen = value;
            }

        }


        public int AantalWorpen
        {

            get
            {
                return aantalWorpen;
            }
            set
            {
                aantalWorpen = value;
            }

        }




        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }



    }
}
