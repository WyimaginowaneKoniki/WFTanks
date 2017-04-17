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
            InitializeComponent();
           
            
            DoubleBuffered = true;
          
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (isKeyDown)
                return;
        
            isKeyDown = true;
            
            var EnemyTanks = new EnemyTanks(this);
            var game = new Game(this);
            var AllyTanks = new AllyTanks(this);
            Random Rnd = new Random();
            var a = Rnd.Next(0, 3);
           
                if (a == 0 && !game.CollisionsForEnemies(Game.Move.Down))
                    EnemyTanks.Movement(Game.Move.Down, game);
                if (a == 1 && !game.CollisionsForEnemies(Game.Move.Up))
                EnemyTanks.Movement(Game.Move.Up, game);
                if (a == 2 && !game.CollisionsForEnemies(Game.Move.Left))
                EnemyTanks.Movement(Game.Move.Left, game);
                if (a == 3 && !game.CollisionsForEnemies(Game.Move.Right))
                EnemyTanks.Movement(Game.Move.Right, game);
            
          
           
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
            isKeyDown = false;
        }
    }
}
