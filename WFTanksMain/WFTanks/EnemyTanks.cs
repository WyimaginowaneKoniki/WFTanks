using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WFTanks
{
    class EnemyTanks : Tanks
    {
        Form1 FormAccess;
        Bullet BulletAccess;
        public override void Shot(Game.Move TankDirection)
        {
            Bullet Bullets = new Bullet(TankDirection, FormAccess, FormAccess.EnemyTanksDesign);
            Bullets.BulletMove(FormAccess.EnemyTanksDesign);
        }
        public EnemyTanks(Form1 FormConstruct)
        {
            FormAccess = FormConstruct;
            Side = Sides.AI;
        }
      

        public override void Movement(Game.Move Move, Game game)
        {
           
            var MoveDown = new Action(() => { if (!(FormAccess.EnemyTanksDesign.Top > 660)) { FormAccess.EnemyTanksDesign.Top += 1; } });
            var MoveUp = new Action(() => { if (!(FormAccess.EnemyTanksDesign.Top < 0)) { FormAccess.EnemyTanksDesign.Top -= 1; } });
            var MoveLeft = new Action(() => { if (!(FormAccess.EnemyTanksDesign.Left < 0)) FormAccess.EnemyTanksDesign.Left -= 1; });
            var MoveRight = new Action(() => { if (!(FormAccess.EnemyTanksDesign.Left > 720)) FormAccess.EnemyTanksDesign.Left += 1; });
        
          Task MovementTask = new Task(() =>
           {
                if (Game.Move.Down == Move)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        if (!game.CollisionsForEnemies(Game.Move.Down))
                        {
                            FormAccess.EnemyTanksDesign.Invoke(MoveDown);
                            Thread.Sleep(20);

                            if (i == 0)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyDown1;

                            else if (i == 7)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyDown3;

                            else if (i == 15)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyDown4;

                            else if (i == 22)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyDown2;
                        }
                    }
                }
                if (Game.Move.Up == Move)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        if (!game.CollisionsForEnemies(Game.Move.Up))
                        {
                            FormAccess.EnemyTanksDesign.Invoke(MoveUp);
                            Thread.Sleep(20);

                            if (i == 0)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyUp1;

                            else if (i == 7)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyUp3;

                            else if (i == 15)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyUp4;

                            else if (i == 22)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyUp2;
                        }
                    }
                }
                if (Game.Move.Left == Move)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        if (!game.CollisionsForEnemies(Game.Move.Left))
                        {
                            FormAccess.EnemyTanksDesign.Invoke(MoveLeft);
                            Thread.Sleep(20);

                            if (i == 0)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyLeft1;

                            else if (i == 7)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyLeft3;

                            else if (i == 15)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyLeft4;

                            else if (i == 22)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyLeft2;
                        }
                    }
                }
                if (Game.Move.Right == Move)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        if (!game.CollisionsForEnemies(Game.Move.Right))
                        {
                            FormAccess.EnemyTanksDesign.Invoke(MoveRight);
                            Thread.Sleep(20);

                            if (i == 0)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyRight1;

                            else if (i == 7)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyRight3;

                            else if (i == 15)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyRight4;

                            else if (i == 22)
                                FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyRight2;
                        }
                    }
                }

      //     if (BulletAccess.isDead == true)
         //      {
                   //FormAccess.Controls.Remove(FormAccess.EnemyTanksDesign);
           //    }
                       
               
           });

          

            

         
                MovementTask.Start();
                if (MovementTask.IsCompleted)
                    MovementTask.Dispose();
            }
        }
    }

