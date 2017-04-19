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
        public override void Shot()
        {
            // TODO  EnemyTanks : Shot()
        }
        public EnemyTanks(Form1 FormConstruct)
        {
            FormAccess = FormConstruct;
        }


        public override void Movement(Game.Move Move, Game game)
        {
            var MoveDown = new Action(() => { if (!(FormAccess.EnemyTanksDesign.Top > 660)) { FormAccess.EnemyTanksDesign.Top += 1; } });
            var MoveUp = new Action(() => { if (!(FormAccess.EnemyTanksDesign.Top < 1)) { FormAccess.EnemyTanksDesign.Top -= 1; } });
            var MoveLeft = new Action(() => { if (!(FormAccess.EnemyTanksDesign.Left < 1)) FormAccess.EnemyTanksDesign.Left -= 1; });
            var MoveRight = new Action(() => { if (!(FormAccess.EnemyTanksDesign.Left > 720)) FormAccess.EnemyTanksDesign.Left += 1; });
            

            
                Task tDown = new Task(() =>
            {
                for (int i = 0; i < 30; i++)
                {

                    if (!game.CollisionsForEnemies(Game.Move.Down))
                    {
                        FormAccess.EnemyTanksDesign.Invoke(MoveDown);
                        Thread.Sleep(20);

                        if (i == 0)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyDown1;
                        }
                        else if (i == 7)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyDown2;
                        }
                        else if (i == 15)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyDown3;
                        }
                        else if (i == 22)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyDown4;
                        }
                    }
                }
            });
                
            Task tUp = new Task(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    if (!game.CollisionsForEnemies(Game.Move.Up))
                    {
                        FormAccess.EnemyTanksDesign.Invoke(MoveUp);
                        Thread.Sleep(20);

                        if (i == 0)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyUp1;
                        }
                        if (i == 7)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyUp2;
                        }
                        if (i == 15)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyUp3;
                        }
                        if (i == 22)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyUp4;
                        }
                    }
                }
            });

            Task tLeft = new Task(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    if (!game.CollisionsForEnemies(Game.Move.Left))
                    {
                        FormAccess.EnemyTanksDesign.Invoke(MoveLeft);
                        Thread.Sleep(20);

                        if (i == 0)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyLeft1;
                        }
                        if (i == 7)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyLeft2;
                        }
                        if (i == 15)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyLeft3;
                        }
                        if (i == 22)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyLeft4;
                        }
                    }
                }
            });

            Task tRight = new Task(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    if (!game.CollisionsForEnemies(Game.Move.Right))
                    {
                        FormAccess.EnemyTanksDesign.Invoke(MoveRight);
                        Thread.Sleep(20);

                        if (i == 0)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyRight1;
                        }
                        if (i == 7)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyRight2;
                        }
                        if (i == 15)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyRight3;
                        }
                        if (i == 22)
                        {
                            FormAccess.EnemyTanksDesign.Image = Properties.Resources.EnemyRight4;
                        }
                    }
                }
            });
            
            if (Game.Move.Down == Move)
            {
                tDown.Start();
                if (tDown.IsCompleted)
                { tDown.Dispose(); }

            }
            else if (Game.Move.Up == Move)
            {
                tUp.Start();
                if (tUp.IsCompleted)
                { tUp.Dispose(); }
            }
            else  if (Game.Move.Left == Move)
            {
                tLeft.Start();
                if (tLeft.IsCompleted)
                { tLeft.Dispose(); }
            }
           else  if (Game.Move.Right == Move)
            {
                tRight.Start();
                if (tRight.IsCompleted)
                { tRight.Dispose(); }
            }
        }
    }
}
