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

            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    string startText = (((Label)control).Text).Substring(0, 4);

                    if (startText == "lord")
                    {
                        int lordNumber = Convert.ToInt32(((Label)control).Tag);
                        string label = "";
                        int stat;
                        string statAtStr;
                        for (int lord2 = 0; lord2 < Variables.numberOfLords; lord2++)
                        {
                            stat = Variables.getLord(lordNumber).getAffinity(lord2);
                            statAtStr = stat.ToString() + " ";
                            if (stat > -1)
                                statAtStr = " " + statAtStr;
                            label += statAtStr;
                        }

                        ((Label)control).Text = label;
                    }
                }
            }  

        }
    }
}
