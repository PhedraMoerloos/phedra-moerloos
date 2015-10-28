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
    public partial class TeerlingVieuw : UserControl
    {

        private TeerlingController controller;


        public TeerlingVieuw(TeerlingController c)
        {
            InitializeComponent();

            controller = c;
        }

        private void TeerlingVieuw_Load(object sender, EventArgs e)
        {

            werpKnop.Visible = controller.model.IsVisible;

        }

        private void werpKnop_Click(object sender, EventArgs e)
        {

            //als niet vast staat mag er geworpen worden en het getal getoond worden
            //model moet aangemaakt worden in de controller, hier (in de presenter) moet je enkel luisteren voor click events en dingen laten zien in het design.
            if (!controller.model.IsVast) { 
                controller.Werp();

                int nieuwAantalOgen = controller.model.AantalOgen;

                Console.WriteLine(nieuwAantalOgen);

                teerlingLabel.Text = nieuwAantalOgen.ToString();
            }

            else
            {

                //niet werpen of niks doen

            }
        }

        private void teerlingLabel_Click(object sender, EventArgs e)
        {

            //eerst togglen naar bv vast, dan checken en als vast rode achtergrond
            controller.ToggleVast();

            //als je op het label klikt en hij staat op vast --> label rode achtergrond
            if (controller.model.IsVast)
            {
                teerlingLabel.BackColor = Color.Red;//rode achtergrond
            }

            //als hij dan niet meer vast staat
            else
            {
           
                teerlingLabel.BackColor = Color.Empty;//rode achtergrond

            }
                

        }


        public void UpdateUI()
        {

            //presenter is enige die met view kan praten. Als je dit in controller maakt gebeurt er niks met de view.
            bool isVast = controller.model.IsVast;

            int aantalOgen = controller.model.AantalOgen;
            teerlingLabel.Text = aantalOgen.ToString();


        }


        public void ClearLabels()
        {

            teerlingLabel.Text = "Reset";

        }


    }
}
