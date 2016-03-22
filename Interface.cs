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
            changeLabel(0);
        }

        private void btnMunster_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void changeLabel (int name)
        {
            lblName.Text = Variables.getTerritory(name).getName();

        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
