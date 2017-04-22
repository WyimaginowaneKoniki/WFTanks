using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Stopwatch BulletTime = new Stopwatch();
        public int x;
        public int y;
        public bool isKeyDown = true;
        Random Rnd = new Random();
        public int a;
        private Game.Move TankDirection;
        private Game.Move TankDirection2;
        public Form1()
        {
            InitializeComponent();
            x = AllieTanksDesign.Left;
            y = AllieTanksDesign.Top;


            DoubleBuffered = true;
           
            timer1.Interval = 1100;
            timer1.Start();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Tick += timer2_Tick;
            timer2.Interval = 3000;
            timer2.Start();
            BulletTime.Start();
        }

       
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           

            timer2.Stop();
            if ((Math.Abs(y - AllieTanksDesign.Top)) > 41 || (Math.Abs(x - AllieTanksDesign.Left)) > 41)
            {
                x = AllieTanksDesign.Left;
                y = AllieTanksDesign.Top;
            }

            var game = new Game(this);

            var AllyTanks = new AllyTanks(this);

           
            if (e.KeyCode == Keys.Down && !game.Collisions(Game.Move.Down))
            {
                TankDirection = Game.Move.Down;
                AllyTanks.Movement(TankDirection, game);
            }

            if (e.KeyCode == Keys.Up && !game.Collisions(Game.Move.Up))
            {
                TankDirection = Game.Move.Up;
                AllyTanks.Movement(TankDirection, game);
            }

            if (e.KeyCode == Keys.Left && !game.Collisions(Game.Move.Left))
            {
                TankDirection = Game.Move.Left;
                AllyTanks.Movement(TankDirection, game);
            }

            if (e.KeyCode == Keys.Right && !game.Collisions(Game.Move.Right))
            {
                TankDirection = Game.Move.Right;
                AllyTanks.Movement(TankDirection, game);
            }

            if (e.KeyCode == Keys.Space && BulletTime.ElapsedMilliseconds>=2000)
            {
                    AllyTanks.Shot(TankDirection);
                BulletTime.Restart();
            }
        }

        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
            timer2.Start();
            var game = new Game(this);

            var AllyTanks = new AllyTanks(this);

            if (e.KeyCode == Keys.Down && !game.Collisions(Game.Move.Down))
                AllyTanks.Movement(Game.Move.Down, game);

            else if (e.KeyCode == Keys.Up && !game.Collisions(Game.Move.Up))
                AllyTanks.Movement(Game.Move.Up, game);

            else if (e.KeyCode == Keys.Left && !game.Collisions(Game.Move.Left))
                AllyTanks.Movement(Game.Move.Left, game);

            else if (e.KeyCode == Keys.Right && !game.Collisions(Game.Move.Right))
                AllyTanks.Movement(Game.Move.Right, game);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            var game = new Game(this);
            var EnemyTanks = new EnemyTanks(this);

         
            a = Rnd.Next(0,5);
            if (a == 0)
            {
                TankDirection2 = Game.Move.Down;
                EnemyTanks.Movement(Game.Move.Down, game);
            }
            else if (a == 1)
            {
                TankDirection2 = Game.Move.Up;
                EnemyTanks.Movement(Game.Move.Up, game);
            }
            else if (a == 2)
            {
                TankDirection2 = Game.Move.Left;
                EnemyTanks.Movement(Game.Move.Left, game);
            }
            else if (a == 3)
            {
                TankDirection2 = Game.Move.Right;
                EnemyTanks.Movement(Game.Move.Right, game);
            }
            else
                EnemyTanks.Shot(TankDirection2);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isKeyDown && timer2.Interval >= 500)
            {
                x = AllieTanksDesign.Left;
                y = AllieTanksDesign.Top;
            }
        }
      

    }
}
