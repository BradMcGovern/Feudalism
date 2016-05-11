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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

            for (int index = 0; index < 9; index++)
            {
                comboBox1.Items.Add(Variables.getTerritory(index).getName());
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int selectedKingdom = comboBox1.SelectedIndex;
            string messageString = "You have chosen " + Variables.getTerritory(selectedKingdom).getName() + ". Is this the kingdom you wish to play?";
                
            DialogResult result = MessageBox.Show(messageString, "Kingdom Choice", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Variables.playerNumber = selectedKingdom;
                this.Close();
            }

        }
    }
}
