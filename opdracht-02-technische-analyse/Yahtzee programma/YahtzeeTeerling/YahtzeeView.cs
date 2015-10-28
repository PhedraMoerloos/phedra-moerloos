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


            scoreLabel.Text = "0";
            aantalWorpenLabel.Text = "0";

            yController.yModel.AantalWorpen = 0;
            aantalWorpenLabel.Text = yController.yModel.AantalWorpen.ToString();

        }

        private void werpAlleTeerlingen_Click(object sender, EventArgs e)
        {

            aantalWorpenLabel.Text = yController.yModel.AantalWorpen.ToString();

            List<int> listAantalOgen = new List<int>();

            //doorloop de teerlingen
            for (int teerlingNummer = 0; teerlingNummer < yController.yModel.AantalTeerlingen; ++teerlingNummer)
            {

                TeerlingController tijdelijkeTeerling = new TeerlingController();

                teerlingen[teerlingNummer].Werp();

                listAantalOgen.Add(tijdelijkeTeerling.model.AantalOgen);

                teerlingen[teerlingNummer].getView().UpdateUI();
                //gaat niet direct vanuit buitenwereld naar presenter kunnen voor de updateUI methode. GetView --> c# ziet presenter en view als 1 dus daarmee --> getView(), hierdoor geraak je in de "View" (presenter EN view) 


            }


            //list is gevuld met ints van elk random getal.


            //score

            //als je gegooid hebt 

            yController.CalculateScore(listAantalOgen);

            int score = yController.yModel.Score;

            scoreLabel.Text = score.ToString();






            yController.yModel.AantalWorpen++;

            if (yController.yModel.AantalWorpen > yController.yModel.MaxAantalWorpen)
            {

                yController.yModel.AantalWorpen = 0;
                yController.yModel.Score = 0;

                for (int teerlingNummer = 0; teerlingNummer < yController.yModel.AantalTeerlingen; ++teerlingNummer)
                {

                    teerlingen[teerlingNummer].getView().ClearLabels();



                }


                



            }

           

            


        }

        private void scoreTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void aantalWorpenTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void aantalWorpenLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
