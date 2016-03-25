using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feudalism
{
    public partial class Interface : Form
    {



        public Interface()
        {

            InitializeComponent();
            
        }


        private void btnConnacht_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void btnMunster_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void changeLabel (int ter)
        {
            lblName.Text = Variables.getLord(Variables.getTerritory(ter).getLordNumber()).getName();

        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
