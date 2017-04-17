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

        public Game(Form1 FormConstructor)
        {
            FormAccess = FormConstructor;
            for (int i = 1; i <= 56; i++)
            {
                Walls.Add((PictureBox)FormAccess.Controls.Find("BrickWall" + i, true)[0]);
            }
        }
        public bool Collisions(Move Tank)
        {

            System.Drawing.Rectangle thing = new System.Drawing.Rectangle(0, 0, 0, 0);
            for (int i = 0; i < 56; i++)
            {
                thing = Walls[i].Bounds;

                if (Tank == Move.Left)
                {
                    thing.X += 1;
                    if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(thing))
                    { return true; }
                }
                else if (Tank == Move.Up)
                {
                    thing.Y += 1;
                    if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(thing))
                    { return true; }
                }
                else if (Tank == Move.Down)
                {
                    thing.Y -= 1;
                    if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(thing))
                    { return true; }
                }
                else if (Tank == Move.Right)
                {
                    thing.X -= 1;
                    if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(thing))
                    { return true; }
                }
            }
            return false;


        }
    }
}
