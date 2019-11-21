using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Player;
        Random rand = new Random();
        string[]  vs= new string[]{"Rock","Paper","Scissors"};

        private void Rock_Click(object sender, EventArgs e)
        {
            Player = 0;
            WinCheck();

        }

        private void Paper_Click(object sender, EventArgs e)
        {
            Player = 1;
            WinCheck();
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            Player = 2;
            WinCheck();
        }

        //0-win 1-lose 2-Tie

        private void WinCheck()
        {
            int ai = rand.Next(3);

            int stat;

            if (Player == ai)
            {
                stat = 2;
            }
            else if (Player == 0 && ai == 2)
            {
                stat = 0;
            }
            else if (ai == 0 && Player == 2)
            {
                stat = 1;
            }
            else if (Player > ai)
            {
                stat = 0;
            }
            else
            {
                stat = 1;
            }




            if (stat == 0)
            {
                this.label1.Text = $"You Won AI Chose {vs[ai]}";
            }
            else if (stat == 1)
            {
                this.label1.Text = $"You Lost AI Chose {vs[ai]}";
            }
            else
            {
                this.label1.Text = $"You Tied AI Chose {vs[ai]}";
            }
        }
    }
}
