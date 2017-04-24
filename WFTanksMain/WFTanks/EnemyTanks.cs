using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTanks
{
    class EnemyTanks : Tanks
    {
        private Form1 FormAccess;
        public PictureBox EnemyTankDesign = new PictureBox();

        public override void Shot(Game.Move TankDirection)
        {
            Bullet Bullets = new Bullet(TankDirection, FormAccess, EnemyTankDesign);
        }

        public EnemyTanks()
        {
            Side = Sides.AI;

            EnemyTankDesign.BackColor = System.Drawing.Color.Transparent;
            EnemyTankDesign.Image = Properties.Resources.EnemyDown1;
            EnemyTankDesign.Location = new System.Drawing.Point(371, 275);
            EnemyTankDesign.Name = "EnemyTanksDesign";
            EnemyTankDesign.Size = new System.Drawing.Size(30, 30);
            EnemyTankDesign.TabIndex = 58;
            EnemyTankDesign.TabStop = false;
        }

        public void SetForm1(Form1 FormConstruct)
        {
            FormAccess = FormConstruct;
            FormAccess.Controls.Add(EnemyTankDesign);
        }


        public override void Movement(Game.Move Move, Game game)
        {
            var MoveDown = new Action(() => { if (!(EnemyTankDesign.Top > 660)) { EnemyTankDesign.Top += 1; } });
            var MoveUp = new Action(() => { if (!(EnemyTankDesign.Top < 0)) { EnemyTankDesign.Top -= 1; } });
            var MoveLeft = new Action(() => { if (!(EnemyTankDesign.Left < 0)) EnemyTankDesign.Left -= 1; });
            var MoveRight = new Action(() => { if (!(EnemyTankDesign.Left > 720)) EnemyTankDesign.Left += 1; });

            Task MovementTask = new Task(() =>
             {
                 if (Game.Move.Down == Move)
                 {
                     for (int i = 0; i < 30; i++)
                     {
                         if (!game.CollisionsForEnemies(Game.Move.Down, EnemyTankDesign))
                         {
                             EnemyTankDesign.Invoke(MoveDown);
                             Thread.Sleep(20);

                             if (i == 0)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyDown1;

                             else if (i == 7)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyDown3;

                             else if (i == 15)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyDown4;

                             else if (i == 22)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyDown2;
                         }
                     }
                 }
                 if (Game.Move.Up == Move)
                 {
                     for (int i = 0; i < 30; i++)
                     {
                         if (!game.CollisionsForEnemies(Game.Move.Up, EnemyTankDesign))
                         {
                             EnemyTankDesign.Invoke(MoveUp);
                             Thread.Sleep(20);

                             if (i == 0)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyUp1;

                             else if (i == 7)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyUp3;

                             else if (i == 15)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyUp4;

                             else if (i == 22)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyUp2;
                         }
                     }
                 }
                 if (Game.Move.Left == Move)
                 {
                     for (int i = 0; i < 30; i++)
                     {
                         if (!game.CollisionsForEnemies(Game.Move.Left, EnemyTankDesign))
                         {
                             EnemyTankDesign.Invoke(MoveLeft);
                             Thread.Sleep(20);

                             if (i == 0)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyLeft1;

                             else if (i == 7)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyLeft3;

                             else if (i == 15)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyLeft4;

                             else if (i == 22)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyLeft2;
                         }
                     }
                 }
                 if (Game.Move.Right == Move)
                 {
                     for (int i = 0; i < 30; i++)
                     {
                         if (!game.CollisionsForEnemies(Game.Move.Right, EnemyTankDesign))
                         {
                             EnemyTankDesign.Invoke(MoveRight);
                             Thread.Sleep(20);

                             if (i == 0)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyRight1;

                             else if (i == 7)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyRight3;

                             else if (i == 15)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyRight4;

                             else if (i == 22)
                                 EnemyTankDesign.Image = Properties.Resources.EnemyRight2;
                         }
                     }
                 }
             });

            MovementTask.Start();
            if (MovementTask.IsCompleted)
                MovementTask.Dispose();
        }
    }
}

