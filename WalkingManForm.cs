/*
 * Created by: Jadon Fournier
 * Created on: 22-Mar-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program shows a man walking
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Add this library
using System.Threading;

namespace WalkingMan
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent(); 
        }

        private void frmWalkingMan_Load(object sender, EventArgs e)
        {

        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            //Define Variables
            const byte MAX_FRAMES = 10;
            int Counter = 1;

            //Set the loop
            while (Counter < MAX_FRAMES + 1)
            {
                if (Counter == 1)
                {
                    this.picMan.Image = Properties.Resources.walk1;
                }

                else if (Counter == 2)
                {
                    this.picMan.Image = Properties.Resources.walk2;
                }

                else if (Counter == 3)
                {
                    this.picMan.Image = Properties.Resources.walk3;
                }

                else if (Counter == 4)
                {
                    this.picMan.Image = Properties.Resources.walk4;
                }

                else if (Counter == 5)
                {
                    this.picMan.Image = Properties.Resources.walk5;
                }

                else if (Counter == 6)
                {
                    this.picMan.Image = Properties.Resources.walk6;
                }

                else if (Counter == 7)
                {
                    this.picMan.Image = Properties.Resources.walk7;
                }

                else if (Counter == 8)
                {
                    this.picMan.Image = Properties.Resources.walk8;
                }

                else if (Counter == 9)
                {
                    this.picMan.Image = Properties.Resources.walk9;
                }

                else if (Counter == 10)
                {
                    this.picMan.Image = Properties.Resources.walk10;
                    Counter = 1;
                }

                //Increment the counter
                Counter = Counter + 1;

                //Refresh and set intrevals
                this.Refresh();
                Thread.Sleep(100);
            }

            
        }
    }
}
