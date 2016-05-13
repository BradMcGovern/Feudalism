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

        string[] statDescriptors = { "Very Low", "Low", "Average", "High", "Very High" };
        int selectedTerritory = 0;

        public Interface()
        {

            InitializeComponent();
     
            lblPlayerTerritory.Text = Variables.getTerritory(Variables.PLAYER_NUMBER).getName();

            //set the text of each button to match its territory name
            foreach (Control control in grpMap.Controls)
            {
                if (control is Button)
                {                  
                    string startText = (((Button)control).Name).Substring(3, 4); 

                    if (startText == "Terr")
                    {
                        int territoryNumber = Convert.ToInt32(((Button)control).Tag);
                        ((Button)control).Text = Variables.getTerritory(territoryNumber).getName();
                    }
                }
            } // end setting buttons

            //add territories to combo box
            for (int territory = 0; territory < Variables.NUMBER_OF_LORDS; territory++)
            {
                cmbTerritories.Items.Add(Variables.getTerritory(territory).getName());
            }
            cmbTerritories.SelectedIndex = 0;
            lblAffinityOther.Text = "";
            lblOpinionOfOther.Text = "";
            lblOtherOpinion.Text = "";
            lblRelationshipOther.Text = "";
            lblStanceToOther.Text = "";
            lblOtherStance.Text = "";

        } //end intitalization of Interface form

        //Begin methods for form

        //gets tag from clicked button and displays territory information in form
        private void territoryButton_Click(object sender, EventArgs e)
        {

            selectedTerritory = Convert.ToInt32(((Button)sender).Tag);

            lblLordName.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getName();
            lblTerName.Text = Variables.getTerritory(selectedTerritory).getName();
            lblHonorable.Text = statDescriptors[(Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getHonorable()) + 2];
            lblPious.Text = statDescriptors[(Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getPious()) + 2];
            lblGregarious.Text = statDescriptors[(Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getGregarious()) + 2];
            lblAdventurous.Text = statDescriptors[(Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getAdventurous()) + 2];
            lblLavish.Text = statDescriptors[(Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getLavish()) + 2];

            lblAffinityYou.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getAffinity(Variables.PLAYER_NUMBER).ToString();
            lblOpinionOfYou.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getOpinion(Variables.PLAYER_NUMBER).ToString();
            lblYourOpinion.Text = Variables.getLord(Variables.PLAYER_NUMBER).getOpinion(Variables.getTerritory(selectedTerritory).getLordNumber()).ToString();
            lblRelationshipYou.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getRelationship(Variables.PLAYER_NUMBER).ToString();
            lblStanceToYou.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getStance(Variables.PLAYER_NUMBER).ToString();
            lblYourStance.Text = Variables.getLord(Variables.PLAYER_NUMBER).getStance(Variables.getTerritory(selectedTerritory).getLordNumber()).ToString();

            lblAffinityOther.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getAffinity(cmbTerritories.SelectedIndex).ToString();
            lblOpinionOfOther.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getOpinion(cmbTerritories.SelectedIndex).ToString();
            lblOtherOpinion.Text = Variables.getLord(cmbTerritories.SelectedIndex).getOpinion(Variables.getTerritory(selectedTerritory).getLordNumber()).ToString();
            lblRelationshipOther.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getRelationship(cmbTerritories.SelectedIndex).ToString();
            lblStanceToOther.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getStance(cmbTerritories.SelectedIndex).ToString();
            lblOtherStance.Text = Variables.getLord(cmbTerritories.SelectedIndex).getStance(Variables.getTerritory(selectedTerritory).getLordNumber()).ToString();

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

        //show matrices form
        private void btnMatricies_Click(object sender, EventArgs e)
        {
            var newForm = new Matricies();
            newForm.Show();
        }

        //change relationship info displayed when a new territory is selected
        private void cmbTerritories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAffinityOther.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getAffinity(cmbTerritories.SelectedIndex).ToString();
            lblOpinionOfOther.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getOpinion(cmbTerritories.SelectedIndex).ToString();
            lblOtherOpinion.Text = Variables.getLord(cmbTerritories.SelectedIndex).getOpinion(Variables.getTerritory(selectedTerritory).getLordNumber()).ToString();
            lblRelationshipOther.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getRelationship(cmbTerritories.SelectedIndex).ToString();
            lblStanceToOther.Text = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber()).getStance(cmbTerritories.SelectedIndex).ToString();
            lblOtherStance.Text = Variables.getLord(cmbTerritories.SelectedIndex).getStance(Variables.getTerritory(selectedTerritory).getLordNumber()).ToString();

            btnMatricies.Select();
        }


    } //end class
} //end namespace
