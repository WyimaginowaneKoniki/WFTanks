using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace WFTanks
{
    public partial class Form1 : Form
    {
        private Stopwatch BulletTime = new Stopwatch();
        private Stopwatch BulletSoundTimer = new Stopwatch();
        private SoundPlayer BulletSound = new SoundPlayer(Properties.Resources.newshot);

        private AllyTanks AllyTank = new AllyTanks();
        private EnemyTanks EnemyTank = new EnemyTanks();

        private Random Rnd = new Random();

        private int x;
        private int y;
        private int a;

        private Game.Move TankDirection;
        private Game.Move TankDirection2;

        public List<PictureBox> AlmostDestroyed = new List<PictureBox>();
        public List<PictureBox> Walls = new List<PictureBox>();

        public bool Isenemydead;
        public bool isKeyDown = true;



        public Form1()
        {
            AllyTank.SetFrom1(this);
            EnemyTank.SetForm1(this);
            InitializeComponent();

            foreach (Control c in Controls)
            {
                if (c is PictureBox && ((string)c.Tag == "Wall"))
                {
                    AlmostDestroyed.Add((PictureBox)c);
                }
            }
            x = AllyTank.AllyTankDesign.Left;
            y = AllyTank.AllyTankDesign.Top;


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
            if ((Math.Abs(y - AllyTank.AllyTankDesign.Top)) > 41 || (Math.Abs(x - AllyTank.AllyTankDesign.Left)) > 41)
            {
                x = AllyTank.AllyTankDesign.Left;
                y = AllyTank.AllyTankDesign.Top;
            }

            var game = new Game(this);


            if (e.KeyCode == Keys.Down && !game.Collisions(Game.Move.Down, AllyTank.AllyTankDesign))
            {
                TankDirection = Game.Move.Down;
                AllyTank.Movement(TankDirection);
            }

            else if (e.KeyCode == Keys.Up && !game.Collisions(Game.Move.Up, AllyTank.AllyTankDesign))
            {
                TankDirection = Game.Move.Up;
                AllyTank.Movement(TankDirection);
            }

            else if (e.KeyCode == Keys.Left && !game.Collisions(Game.Move.Left, AllyTank.AllyTankDesign))
            {
                TankDirection = Game.Move.Left;
                AllyTank.Movement(TankDirection);
            }

            else if (e.KeyCode == Keys.Right && !game.Collisions(Game.Move.Right, AllyTank.AllyTankDesign))
            {
                TankDirection = Game.Move.Right;
                AllyTank.Movement(TankDirection);
            }

            if (e.KeyCode == Keys.Space && BulletTime.ElapsedMilliseconds >= 2000)
            {
                BulletSound.Play();
                BulletSoundTimer.Start();
                AllyTank.Shot(TankDirection, this);
                BulletTime.Restart();
            }
        }

        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (BulletSoundTimer.ElapsedMilliseconds >= 1000)
            {
                BulletSoundTimer.Reset();
                BulletSound.Stop();
            }
            timer2.Start();
            var game = new Game(this);

            if (e.KeyCode == Keys.Down && !game.Collisions(Game.Move.Down, AllyTank.AllyTankDesign))
                AllyTank.Movement(Game.Move.Down);

            else if (e.KeyCode == Keys.Up && !game.Collisions(Game.Move.Up, AllyTank.AllyTankDesign))
                AllyTank.Movement(Game.Move.Up);

            else if (e.KeyCode == Keys.Left && !game.Collisions(Game.Move.Left, AllyTank.AllyTankDesign))
                AllyTank.Movement(Game.Move.Left);

            else if (e.KeyCode == Keys.Right && !game.Collisions(Game.Move.Right, AllyTank.AllyTankDesign))
                AllyTank.Movement(Game.Move.Right);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            var game = new Game(this);

            a = Rnd.Next(0, 5);
            if (!Isenemydead)
            {
                if (a == 0)
                {
                    TankDirection2 = Game.Move.Down;
                    EnemyTank.Movement(Game.Move.Down, game);
                }
                else if (a == 1)
                {
                    TankDirection2 = Game.Move.Up;
                    EnemyTank.Movement(Game.Move.Up, game);
                }
                else if (a == 2)
                {
                    TankDirection2 = Game.Move.Left;
                    EnemyTank.Movement(Game.Move.Left, game);
                }
                else if (a == 3)
                {
                    TankDirection2 = Game.Move.Right;
                    EnemyTank.Movement(Game.Move.Right, game);
                }
                else
                    EnemyTank.Shot(TankDirection2, this);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isKeyDown && timer2.Interval >= 500)
            {
                x = AllyTank.AllyTankDesign.Left;
                y = AllyTank.AllyTankDesign.Top;
            }
        }

        public PictureBox GetAllyTankDesign()
        {
            return AllyTank.AllyTankDesign;
        }

        public List<PictureBox> GetAlmostDestroyed()
        {
            return AlmostDestroyed;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public dynamic GetForm()
        {
            return this;
        }
    }
}
