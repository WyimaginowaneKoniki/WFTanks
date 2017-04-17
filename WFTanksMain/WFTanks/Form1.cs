using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTanks
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var game = new Game(this);
            var AllyTanks = new AllyTanks();

            if (e.KeyCode == Keys.Down && !game.Collisions(Game.Move.Down))
            {
                AllyTanks.Movement(this, Game.Move.Down);
            }
            else if (e.KeyCode == Keys.Up && !game.Collisions(Game.Move.Up))
            {
                AllyTanks.Movement(this, Game.Move.Up);
            }
            else if (e.KeyCode == Keys.Left && !game.Collisions(Game.Move.Left))
            {
                AllyTanks.Movement(this, Game.Move.Left);
            }
            else if (e.KeyCode == Keys.Right && !game.Collisions(Game.Move.Right))
            {
                AllyTanks.Movement(this, Game.Move.Right);
            }
        }
    }
}
