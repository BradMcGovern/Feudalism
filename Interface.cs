/***********************************
/"Feudalism" game
/Interface.cs
/
/Main user interface for game
/
/Created by Brad McGovern
/
/Last updated May 16, 2016
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
            Lord thisLord = Variables.getLord(Variables.getTerritory(selectedTerritory).getLordNumber());

            //fill info boxes
            lblLordName.Text = thisLord.getName();
            lblTerName.Text = Variables.getTerritory(selectedTerritory).getName();
            lblHonorable.Text = statDescriptors[thisLord.getHonorable() + 2];
            lblPious.Text = statDescriptors[thisLord.getPious() + 2];
            lblGregarious.Text = statDescriptors[thisLord.getGregarious() + 2];
            lblAdventurous.Text = statDescriptors[thisLord.getAdventurous() + 2];
            lblLavish.Text = statDescriptors[thisLord.getLavish() + 2];

            //fill relations to player
            fillRelationBoxes("player", Variables.PLAYER_NUMBER);

            //fill relations to selected territoy/lord
            fillRelationBoxes("other", cmbTerritories.SelectedIndex);

            //change territory button backcolors to match relationship with this territory
            foreach (Control control in grpMap.Controls)
            {
                if (control is Button)
                {
                    string startText = (((Button)control).Name).Substring(3, 4);

                    if (startText == "Terr")
                    {
                        int territoryNumber = Convert.ToInt32(((Button)control).Tag);
                        ((Button)control).BackColor = Variables.getColor(thisLord.getRelationship(Variables.getTerritory(territoryNumber).getLordNumber()), "relationship");
                    }
                }
            } // end change button colors


        } //end territoryBUtton_Click()

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

        //change relationship info displayed when a new territory is selected from drop-down list
        private void cmbTerritories_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillRelationBoxes("other", cmbTerritories.SelectedIndex);
            btnMatricies.Select();
        }

        //function to fill in the boxes showing the relations stats
        private void fillRelationBoxes(string withWhom, int otherLordNumber)
        {
            int thisLordNumber = Variables.getTerritory(selectedTerritory).getLordNumber(); //lord number of the lord of the displayed territory
            Lord thisLord = Variables.getLord(thisLordNumber); //the lord of the displayed territory
            Lord otherLord = Variables.getLord(otherLordNumber); //the lord to compare the displayed lord with, based on the lord number passed to the function

            //the various stats to fill the boxes with
            int affinity;
            int theirOpinion;
            int opinionOfThem;
            int relationship;
            int theirStance;
            int stanceToThem;

            //holding variables for the boxes to be filled
            Label affinityBox;
            Label theirOpinionBox;
            Label opinionOfThemBox;
            Label relationshipBox;
            Label theirStanceBox;
            Label stanceToThemBox;

            //set stats
            affinity = thisLord.getRelation(otherLordNumber, "affinity");
            theirOpinion = thisLord.getRelation(otherLordNumber, "opinion");
            opinionOfThem = otherLord.getRelation(thisLordNumber, "opinion");
            relationship = thisLord.getRelation(otherLordNumber, "relationship");
            theirStance = thisLord.getRelation(otherLordNumber, "stance");
            stanceToThem = otherLord.getRelation(thisLordNumber, "stance");

            //set which boxes are filled, based on value passed to function
            switch (withWhom)
            {
                case "other":

                    affinityBox = lblAffinityOther;
                    theirOpinionBox = lblOpinionOfOther;
                    opinionOfThemBox = lblOtherOpinion;
                    relationshipBox = lblRelationshipOther;
                    theirStanceBox = lblStanceToOther;
                    stanceToThemBox = lblOtherStance;
                    break;

                default:
                    affinityBox = lblAffinityYou;
                    theirOpinionBox = lblOpinionOfYou;
                    opinionOfThemBox = lblYourOpinion;
                    relationshipBox = lblRelationshipYou;
                    theirStanceBox = lblStanceToYou;
                    stanceToThemBox = lblYourStance;
                    break;
            }

            //fill boxes with stats
            affinityBox.Text = affinity.ToString();
            theirOpinionBox.Text = theirOpinion.ToString();
            opinionOfThemBox.Text = opinionOfThem.ToString();
            relationshipBox.Text = relationship.ToString();
            theirStanceBox.Text = theirStance.ToString();
            stanceToThemBox.Text = stanceToThem.ToString();

            //change backcolor of boxes based on stat
            affinityBox.BackColor = Variables.getColor(affinity, "affinity");
            theirOpinionBox.BackColor = Variables.getColor(theirOpinion, "opinion");
            opinionOfThemBox.BackColor = Variables.getColor(opinionOfThem, "opinion");
            relationshipBox.BackColor = Variables.getColor(relationship, "relationship");
            theirStanceBox.BackColor = Variables.getColor(theirStance, "stance");
            stanceToThemBox.BackColor = Variables.getColor(stanceToThem, "stance");

        } //end fillRelationBoxes()

    } //end class
} //end namespace
