using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {



        public Yahtzee()
        {
            InitializeComponent();
        }



        private void Yahtzee_Load(object sender, EventArgs e)
        {

            YahtzeeController yController = new YahtzeeController();

            YahtzeeView yahtzeeView = yController.getView();

            Controls.Add(yahtzeeView);

            
        }


       
    }
}
