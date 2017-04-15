using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTanks
{
    abstract class Tanks
    {
        protected enum Levels
        {
            Small,
            Medium,
            Big
        }
        protected enum Sides
        {
            AI,
            Buddy
        }
        protected Sides Side;

        public uint _currentPositionX;

        public uint CurrentPositionX
        {
            get { return _currentPositionX; }
            set { _currentPositionX = value; }
        }

        public uint _currentPositionY;

        public uint CurrentPositionY
        {
            get { return _currentPositionY; }
            set { _currentPositionY = value; }
        }

        public int _healthPoints;

        public int HealthPoints
        {
            get { return _healthPoints; }
            set { _healthPoints = value; }
        }

        public string _playerName;

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }


        protected Levels CurrentLevel;
        // TODO Skin!!!!!
        public virtual void Shot()
        {
            // TODO Tanks : Shot()
        }

        public virtual void Movement()
        {
            // TODO Tanks : Movement()
        }
    }
}
