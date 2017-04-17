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
        bool isKeyDown = false;

        public Form1()
        {
           
           
            DoubleBuffered = true;
            InitializeComponent();
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            var game = new Game(this);
            var AllyTanks = new AllyTanks(this);
           
            if (e.KeyCode == Keys.Down && !game.Collisions(Game.Move.Down))
            {
                AllyTanks.Movement(Game.Move.Down, game);
            }
            else if (e.KeyCode == Keys.Up && !game.Collisions(Game.Move.Up))
            {
                AllyTanks.Movement(Game.Move.Up, game);
            }
            else if (e.KeyCode == Keys.Left && !game.Collisions(Game.Move.Left))
            {
                AllyTanks.Movement(Game.Move.Left, game);
            }
            else if (e.KeyCode == Keys.Right && !game.Collisions(Game.Move.Right))
            {
                AllyTanks.Movement(Game.Move.Right, game);
            }
        }

        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}
