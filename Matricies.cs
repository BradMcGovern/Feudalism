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
            //foreach (Control control in this.Controls)
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

            string[] stances = { "enemy", "rival", "cool", "neutral", "warm", "friend", "ally" }; 
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label)
                {
                    string startText = (((Label)control).Name).Substring(3, 4);

                    if (startText == "Stat")
                    {
                        int cellTag = Convert.ToInt32(((Label)control).Tag);
                        int stat = getStat(type, cellTag);
                        if (type == "stance")
                        {
                            ((Label)control).Text = stances[stat + 3];
                        }
                        else
                        {
                            ((Label)control).Text = stat.ToString();
                        }
                        
                        ((Label)control).BackColor = getColor(stat, type);
                    }
                }
            } //end foreach loop

            lblMatrixType.Text = type;

        } //end btnAffinity_Click()

        private int getStat(string type, int cellTag)
        {
            int territory1 = cellTag / 100;
            int territory2 = cellTag % 100;
            int lord1 = Variables.getTerritory(territory1).getLordNumber();
            int lord2 = Variables.getTerritory(territory2).getLordNumber();
            int stat;
            switch (type)
            {
                case "affinity":
                    stat = Variables.getLord(lord1).getAffinity(lord2);
                    break;
                case "opinion":
                    stat = Variables.getLord(lord1).getOpinion(lord2);
                    break;
                case "stance":
                    stat = Variables.getLord(lord1).getStance(lord2);
                    break;
                default:
                    stat = Variables.getLord(lord1).getRelationship(lord2);
                    break;

            }

            return stat;
                        
        } //end getStat()
               

        private Color getColor(int stat, string type)
        {
            int threshold;

            //set threshold
            if (type == "affinity")
            {
                switch (stat)
                {
                    case -6:
                    case -5:
                        threshold = -3;
                        break;
                    case -4:
                    case -3:
                    case -2:
                        threshold = -2;
                        break;
                    case 2:
                    case 3:
                    case 4:
                        threshold = 2;
                        break;
                    case 5:
                    case 6:
                        threshold = 3;
                        break;
                    default:
                        threshold = 0;
                        break;
                } //end switch
            }
            else if (type == "stance")
            {
                threshold = stat;
            }
            else {
                if (Math.Abs(stat) > Variables.HIGH_THRESHOLD)
                {
                    threshold = 3;
                }
                else if (Math.Abs(stat) > Variables.MEDIUM_THRESHOLD)
                {
                    threshold = 2;
                }
                else if (Math.Abs(stat) > Variables.LOW_THRESHOLD)
                {
                    threshold = 1;
                }
                else {
                    threshold = 0;
                } //end if..else

                if (stat < 0)
                    threshold *= -1;
            } //end set threshold

            // return color
            switch (threshold)
            {
                case -3:
                    return Color.Red;
                case -2:
                    return Color.FromArgb(255, 128, 128);
                case -1:
                    return Color.FromArgb(255, 192, 192);
                case 1:
                    return Color.FromArgb(192, 255, 192);
                case 2:
                    return Color.FromArgb(128, 255, 128);
                case 3:
                    return Color.Green;
                default:
                    return Color.White;
            }
        } //end getColor()



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    } //end class
} //end namespace
