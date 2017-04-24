using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTanks
{
    class Game
    {
        public List<PictureBox> Walls = new List<PictureBox>();
        public enum Move
        {
            Down,
            Left,
            Right,
            Up
        }

       

        public Form1 FormAccess;
        public enum GameStates
        {
            Win,
            Lose,
            Draw,
            InGame
        }

        //public GameStates CurrentGameState;
        public uint _score;

        public uint Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public Game(){}

        public Game(Form1 FormConstructor)
        {
            FormAccess = FormConstructor;

                    if (FormAccess.Contains(FormAccess.BrickWall1))
                    {
                        Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall1", true)[0]);
                    }
            if (FormAccess.Contains(FormAccess.BrickWall2))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall2", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall3))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall3", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall4))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall4", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall5))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall5", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall6))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall6", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall7))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall7", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall8))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall8", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall9))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall9", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall10))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall10", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall11))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall11", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall12))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall12", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall13))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall13", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall14))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall14", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall15))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall15", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall16))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall16", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall17))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall17", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall18))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall18", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall19))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall19", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall20))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall20", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall21))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall21", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall22))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall22", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall23))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall23", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall24))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall24", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall25))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall25", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall26))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall26", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall27))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall27", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall28))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall28", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall29))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall29", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall30))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall30", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall31))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall31", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall32))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall32", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall33))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall33", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall34))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall34", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall35))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall35", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall36))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall36", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall37))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall37", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall38))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall38", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall39))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall39", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall40))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall40", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall41))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall41", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall42))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall42", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall43))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall43", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall44))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall44", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall45))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall45", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall46))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall46", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall47))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall47", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall48))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall48", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall49))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall49", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall50))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall50", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall51))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall51", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall52))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall52", true)[0]);
            }

            if (FormAccess.Contains(FormAccess.BrickWall53))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall53", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall54))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall54", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall55))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall55", true)[0]);
            }
            if (FormAccess.Contains(FormAccess.BrickWall56))
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall56", true)[0]);
            }
        }

        public bool Collisions(Move Tank, PictureBox AllyTank)
        {
         Walls.Add((PictureBox)FormAccess.Controls.Find("EnemyTanksDesign", true)[0]);

            int a = 1;
            System.Drawing.Rectangle thing = new System.Drawing.Rectangle(0, 0, 0, 0);

            for (int i = 0; i <Walls.LongCount(); i++)
            {
                thing = Walls[i].Bounds;

                if (Tank == Move.Left)
                {
                    thing.X += a;
                    if (AllyTank.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Up)
                {
                    thing.Y += a;
                    if (AllyTank.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Down)
                {
                    thing.Y -= a;
                    if (AllyTank.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Right)
                {
                    thing.X -= a;
                    if (AllyTank.Bounds.IntersectsWith(thing))
                        return true;
                }
            }
          Walls.Remove((PictureBox)FormAccess.Controls.Find("EnemyTanksDesign", true)[0]);
            return false;
        }

        public bool CollisionsForEnemies(Move Tank, PictureBox EnemyTank)
        {
            Walls.Add((PictureBox)FormAccess.Controls.Find("AllyTanksDesign", true)[0]);

            int a = 1;
            System.Drawing.Rectangle thing = new System.Drawing.Rectangle(0, 0, 0, 0);

            for (int i = 0; i < Walls.Count(); i++)
            {
                thing = Walls[i].Bounds;

                if (Tank == Move.Left)
                {
                    thing.X += a;
                    if (EnemyTank.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Up)
                {
                    thing.Y += a;
                    if (EnemyTank.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Down)
                {
                    thing.Y -= a;
                    if (EnemyTank.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Right)
                {
                    thing.X -= a;
                    if (EnemyTank.Bounds.IntersectsWith(thing))
                        return true;
                }
            }
            Walls.Remove((PictureBox)FormAccess.Controls.Find("AllyTanksDesign", true)[0]);
            return false;
        }

        public PictureBox CollisionsForBullets(Move BulletMove, bool isAllyTank, PictureBox Bullet)
        {
            if (isAllyTank)
            { Walls.Add((PictureBox)FormAccess.Controls.Find("EnemyTanksDesign", true)[0]); }

            else
            { Walls.Add((PictureBox)FormAccess.Controls.Find("AllyTanksDesign", true)[0]); }

            int a = 1;
            System.Drawing.Rectangle thing = new System.Drawing.Rectangle(0, 0, 0, 0);

            for (int i = 0; i < Walls.Count(); i++)
            {
                thing = Walls[i].Bounds;

                if (BulletMove == Move.Left)
                {
                    thing.X += a;
                    if (Bullet.Bounds.IntersectsWith(thing))
                        return Walls[i];
                }

                else if (BulletMove == Move.Up)
                {
                    thing.Y += a;
                    if (Bullet.Bounds.IntersectsWith(thing))
                        return Walls[i];
                }

                else if (BulletMove == Move.Down)
                {
                    thing.Y -= a;
                    if (Bullet.Bounds.IntersectsWith(thing))
                        return Walls[i];
                }

                else if (BulletMove == Move.Right)
                {
                    thing.X -= a;
                    if (Bullet.Bounds.IntersectsWith(thing))
                        return Walls[i];
                }
            }
            if (isAllyTank)
            {Walls.Remove((PictureBox)FormAccess.Controls.Find("EnemyTanksDesign", true)[0]); }

            else
            { Walls.Remove((PictureBox)FormAccess.Controls.Find("AllyTanksDesign", true)[0]); }
            return null;
        }
    }
}
