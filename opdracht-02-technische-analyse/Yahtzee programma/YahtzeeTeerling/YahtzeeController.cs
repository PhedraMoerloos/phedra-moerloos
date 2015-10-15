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


    }
}
