using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeController
    {

        public YahtzeeModel yModel;
        public YahtzeeView yView;


        public YahtzeeController()
        {
            //constructor
            yView = new YahtzeeView(this);
            yModel = new YahtzeeModel();

        }



        public YahtzeeView getView()
        {

            return yView;

        }



        public int CalculateScore(List<int> listAantalOgen)
        {

            string verzameling = "";

            for (int i = 0; i < listAantalOgen.Count -1; i++)
            {

                verzameling += listAantalOgen[i];

            }


            if (verzameling == "123" || verzameling == "234" || verzameling == "345" || verzameling == "456"
                || verzameling == "111" || verzameling == "222" || verzameling == "333" || verzameling == "444" || verzameling == "555" || verzameling == "666")
            {
            
                yModel.Score++;

            }


            return yModel.Score;

        }


    }
}
