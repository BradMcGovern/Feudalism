/***********************************
/Matrices.cs
/"Feudalism" game
/
/Form that shows the different relation matrices
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
    public partial class Matricies : Form
    {
        public Matricies()
        {
            InitializeComponent();

            //change text of lord labels
             foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label)
                {
                    string startText = (((Label)control).Name).Substring(3, 4);

                    if (startText == "Terr")
                    {
                        int territoryNumber = Convert.ToInt32(((Label)control).Tag);
                        ((Label)control).Text = Variables.getTerritory(territoryNumber).getName();
                    }
                }
            } //end changing territory labels         

        }

        private void btnAffinity_Click(object sender, EventArgs e)
        {
            fillMatrix("affinity");
        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            fillMatrix("opinion");
        }

        private void btnRelationship_Click(object sender, EventArgs e)
        {
            fillMatrix("relationship");
        }

        private void btnStance_Click(object sender, EventArgs e)
        {
            fillMatrix("stance");
        }

        private void fillMatrix(string type)
        {
            int cellTag;  //tag of cell in matrix that indicates column and row
            int territory1; //territory for that row
            int territory2; //territory for that column
            Lord lord1; //lord of the territory for that row
            int lord2; //lord number of the territory for that column
            int stat; //stat showing the relation between the two lords

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label)
                {
                    string startText = (((Label)control).Name).Substring(3, 4);

                    if (startText == "Stat")
                    {
                        cellTag = Convert.ToInt32(((Label)control).Tag);
                        territory1 = cellTag / 100;
                        territory2 = cellTag % 100;
                        lord1 = Variables.getLord(Variables.getTerritory(territory1).getLordNumber());
                        lord2 = Variables.getTerritory(territory2).getLordNumber();
                        stat = lord1.getRelation(lord2, type);

                        if (type == "stance")
                        {
                            ((Label)control).Text = Variables.stances[stat + 3];
                        }
                        else
                        {
                            ((Label)control).Text = stat.ToString();
                        }
                        
                        ((Label)control).BackColor = Variables.getColor(stat, type);
                    }
                }
            } //end foreach loop

            lblMatrixType.Text = type;

        } //end btnAffinity_Click()               

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    } //end class
} //end namespace
