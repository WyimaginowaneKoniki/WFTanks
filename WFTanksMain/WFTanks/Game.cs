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
        public enum Move
        {
            Down,
            Left,
            Right,
            Up
        }

        public List<PictureBox> Walls = new List<PictureBox>();

        public Form1 FormAccess;
        public enum GameStates
        {
            Win,
            Lose,
            Draw,
            InGame
        }

        public GameStates CurrentGameState;
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

            for (int i = 1; i <= 56; i++)
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall" + i, true)[0]);
        }

        public bool Collisions(Move Tank)
        {
            Walls.Add((PictureBox)FormAccess.Controls.Find("EnemyTanksDesign", true)[0]);

            int a = 1;
            System.Drawing.Rectangle thing = new System.Drawing.Rectangle(0, 0, 0, 0);

            for (int i = 0; i < Walls.LongCount(); i++)
            {
                thing = Walls[i].Bounds;

                if (Tank == Move.Left)
                {
                    thing.X += a;
                    if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Up)
                {
                    thing.Y += a;
                    if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Down)
                {
                    thing.Y -= a;
                    if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Right)
                {
                    thing.X -= a;
                    if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(thing))
                        return true;
                }
            }
            return false;
        }

        public bool CollisionsForEnemies(Move Tank)
        {
            Walls.Add((PictureBox)FormAccess.Controls.Find("AllieTanksDesign", true)[0]);

            int a = 1;
            System.Drawing.Rectangle thing = new System.Drawing.Rectangle(0, 0, 0, 0);

            for (int i = 0; i < Walls.LongCount(); i++)
            {
                thing = Walls[i].Bounds;

                if (Tank == Move.Left)
                {
                    thing.X += a;
                    if (FormAccess.EnemyTanksDesign.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Up)
                {
                    thing.Y += a;
                    if (FormAccess.EnemyTanksDesign.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Down)
                {
                    thing.Y -= a;
                    if (FormAccess.EnemyTanksDesign.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (Tank == Move.Right)
                {
                    thing.X -= a;
                    if (FormAccess.EnemyTanksDesign.Bounds.IntersectsWith(thing))
                        return true;
                }
            }
            return false;
        }

        public bool CollisionsForBullets(Move BulletMove, bool isAllyTank, PictureBox Bullet)
        {
            if (isAllyTank)
            { Walls.Add((PictureBox)FormAccess.Controls.Find("EnemyTanksDesign", true)[0]); }

            else
            { Walls.Add((PictureBox)FormAccess.Controls.Find("AllieTanksDesign", true)[0]); }

            int a = 1;
            System.Drawing.Rectangle thing = new System.Drawing.Rectangle(0, 0, 0, 0);

            for (int i = 0; i < Walls.LongCount(); i++)
            {
                thing = Walls[i].Bounds;

                if (BulletMove == Move.Left)
                {
                    thing.X += a;
                    if (Bullet.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (BulletMove == Move.Up)
                {
                    thing.Y += a;
                    if (Bullet.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (BulletMove == Move.Down)
                {
                    thing.Y -= a;
                    if (Bullet.Bounds.IntersectsWith(thing))
                        return true;
                }

                else if (BulletMove == Move.Right)
                {
                    thing.X -= a;
                    if (Bullet.Bounds.IntersectsWith(thing))
                        return true;
                }
            }
            return false;
        }
    }
}
