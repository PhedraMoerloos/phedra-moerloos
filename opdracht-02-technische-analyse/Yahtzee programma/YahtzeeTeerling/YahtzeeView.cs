using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class YahtzeeView : UserControl
    {

        public YahtzeeController yController;

        public List<TeerlingController> teerlingen = new List<TeerlingController>();





        public YahtzeeView(YahtzeeController controller)
        {
            InitializeComponent();

            yController = controller;
        }




        private void YahtzeeView_Load(object sender, EventArgs e)
        {

            Console.WriteLine(yController.yModel.AantalTeerlingen);
            for (int teerlingNummer = 0; teerlingNummer < yController.yModel.AantalTeerlingen; ++teerlingNummer)
            {
                // Maak instantie aan van teerlingControllers (hier bv 4)
                TeerlingController tijdelijkeTeerling = new TeerlingController();

                teerlingen.Add(tijdelijkeTeerling);
            }

            // Teerlingen tonen
            for (int teerlingNummer = 0; teerlingNummer < yController.yModel.AantalTeerlingen; ++teerlingNummer)
            {
                // Maak instantie aan van teerlingViews
                //controller.getView --> view die gelinkt is aan die controller
                TeerlingVieuw teerlingView = teerlingen[teerlingNummer].getView();

                // breedte van teerling ophalen en positie berekenen (0 * breedte teerling, ...)
                int horizontalPosition = teerlingNummer * teerlingView.Width;

                teerlingView.Location = new System.Drawing.Point(horizontalPosition, 0);

                Controls.Add(teerlingView);


            }


        }

        private void werpAlleTeerlingen_Click(object sender, EventArgs e)
        {
             

            //doorloop de teerlingen
            for (int teerlingNummer = 0; teerlingNummer < yController.yModel.AantalTeerlingen; ++teerlingNummer)
            {

                teerlingen[teerlingNummer].Werp();
                teerlingen[teerlingNummer].getView().UpdateUI();
                //gaat niet direct vanuit buitenwereld naar presenter kunnen voor de updateUI methode. GetView --> c# ziet presenter en view als 1 dus daarmee --> getView(), hierdoor geraak je in de "View" (presenter EN view) 


            }

            

          

            yController.yModel.AantalWorpen++;

            if (yController.yModel.AantalWorpen > yController.yModel.MaxAantalWorpen)
            {

                yController.yModel.AantalWorpen = 0;


                for (int teerlingNummer = 0; teerlingNummer < yController.yModel.AantalTeerlingen; ++teerlingNummer)
                {

                    teerlingen[teerlingNummer].getView().ClearLabels();
                  

                }



            }

           

            Console.WriteLine(yController.yModel.AantalWorpen);
        
        }
    }
}
