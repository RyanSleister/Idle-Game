using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idle_Game
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        int gold = 0;
        int goldGeneration = 0;
        int clickGeneration = 1;
        //Declare values to be used in the program


        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            gold = gold + goldGeneration;
            lblGold.Text = "Gold: " + gold.ToString();
            //Increase gold per 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gold = gold + clickGeneration;
            //Add gold as the user clicks the button
        }

        private void btnShoes_Click(object sender, EventArgs e)
        {
            if (gold >= 10)
            {
                gold = gold - 10;
                goldGeneration = goldGeneration + 1;
                //Subtract gold from total and increase gold generation rate
            }
            else
            {
                //print not enough gold?
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Close the program
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (gold >= 100)
            {
                gold = gold - 100;
                goldGeneration = goldGeneration + 5;
                //subtract gold from total and increase gold generation
            }
            else
            { }
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            if(gold >= 1000)
            {
                gold = gold - 1000;
                goldGeneration = goldGeneration + 150;
                //Subtract gold from total and increase gold generation
            }
            else
            { }
        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            if(gold >= 25000)
            {
                gold = gold - 25000;
                goldGeneration = goldGeneration + 5000;
                //Subtract gold from total and increase gold generation
            }
            else
            { }
        }

        private void btnClickProfit_Click(object sender, EventArgs e)
        {
            if(gold >= 10000)
            {
                gold = gold - 10000;
                clickGeneration = 1000;
                //Take gold from total, increase how much gold is generated per click

                btnClickProfit.Hide();
                //Hide the button

                BackColor = Color.SandyBrown;
                //Change the color of the background
            }

            //Subtract gold from total and increase click profit
        }
    }
} 