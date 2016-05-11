/***********************************
/"Feudalism" game
/Interface.cs
/
/Main user interface for game
/
/Created by Brad McGovern
/
/Last updated May 11, 2016
************************************/

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
     
            lblPlayerTerritory.Text = Variables.getTerritory(Variables.playerNumber).getName();

            //set the text of each button to match its territory name
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {                  
                    string startText = (((Button)control).Text).Substring(0, 4); 

                    if (startText == "Terr")
                    {
                        int territoryNumber = Convert.ToInt32(((Button)control).Tag);
                        ((Button)control).Text = Variables.getTerritory(territoryNumber).getName();
                    }
                }
            } // end loop through buttons
        } //end intitalization of Interface form
        
        //gets tag from clicked button and displays territory information in form
        private void territoryButton_Click(object sender, EventArgs e)
        {
            int territoryNumber = Convert.ToInt32(((Button)sender).Tag);

            grpKingdomInfo.Show();

            lblLordName.Text = Variables.getLord(Variables.getTerritory(territoryNumber).getLordNumber()).getName();
            lblTerName.Text = Variables.getTerritory(territoryNumber).getName();
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
        
        //exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            
        }

    }
}
