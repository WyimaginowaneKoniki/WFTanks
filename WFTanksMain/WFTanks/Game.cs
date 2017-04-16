﻿using System;
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
        public bool Collisions()
        {   //TODO 
            if (FormAccess.AllieTanksDesign.Bounds.IntersectsWith(Walls[0].Bounds))
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
