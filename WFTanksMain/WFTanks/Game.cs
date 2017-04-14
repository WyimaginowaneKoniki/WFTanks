using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTanks
{
    class Game
    {
        public enum GameStates
        {
            Win,
            Lose,
            Draw,
            InGame
        }
        public GameStates CurrentGameState;
        private uint _score;

        public uint Score
        {
            get { return _score; }
            set { _score = value; }
        }


        public bool Collisions()
        {
            // TODO Game : Collisions()
            return true;
        }


    }
}
