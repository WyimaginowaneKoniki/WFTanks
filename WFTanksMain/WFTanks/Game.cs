using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTanks
{
    class Game
    {
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
        }
        public bool Collisions()
        {
            if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(FormAccess.BrickWall1.Bounds))
            {
                
                FormAccess.AllieTanksDesign.Left += 1;
                return true;
                
            }
            else
            {

                return false;
            }
        }


    }
}
