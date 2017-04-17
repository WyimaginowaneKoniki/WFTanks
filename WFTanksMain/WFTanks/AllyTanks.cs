using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WFTanks
{
    class AllyTanks : Tanks
    {
        public Form1 FormAccess;
        public AllyTanks(Form1 FormConstruct)
        {
            FormAccess = FormConstruct;
        }

        public override void Shot()
        {
            // needed?
            // TODO AllyTanks : Shot()
        }

        public override void Movement(Game.Move Move, Game game)
        { 
            var MoveDown = new Action(() => { if (!(FormAccess.AllieTanksDesign.Top > 660)) { FormAccess.AllieTanksDesign.Top += 1; } });
            var MoveUp = new Action(() => { if (!(FormAccess.AllieTanksDesign.Top < 1)) { FormAccess.AllieTanksDesign.Top -= 1; } });
            var MoveLeft = new Action(() => { if (!(FormAccess.AllieTanksDesign.Left < 1)) FormAccess.AllieTanksDesign.Left -= 1; });
            var MoveRight = new Action(() => { if (!(FormAccess.AllieTanksDesign.Left > 720)) FormAccess.AllieTanksDesign.Left += 1; });

            Task tDown = new Task(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    if (!game.Collisions(Game.Move.Down))
                    {
                        FormAccess.AllieTanksDesign.Invoke(MoveDown);
                        Thread.Sleep(20);
                    }
                    if (i == 0)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.down1;
                    }
                    else if (i == 7)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.down2;
                    }
                    else if (i == 15)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.down3;
                    }
                    else if (i == 22)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.down3;
                    }
                }
            });

            Task tUp = new Task(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    if (!game.Collisions(Game.Move.Up))
                    {
                        FormAccess.AllieTanksDesign.Invoke(MoveUp);
                        Thread.Sleep(20);
                    }
                    if (i == 0)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.up1;
                    }
                    if (i == 7)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.up2;
                    }
                    if (i == 15)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.up3;
                    }
                    if (i == 22)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.up3;
                    }
                }
            });

            Task tLeft = new Task(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    if (!game.Collisions(Game.Move.Left))
                    {
                        FormAccess.AllieTanksDesign.Invoke(MoveLeft);
                        Thread.Sleep(20);
                    }
                    if (i == 0)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.left1;
                    }
                    if (i == 7)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.left2;
                    }
                    if (i == 15)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.left3;
                    }
                    if (i == 22)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.left3;
                    }
                }
            });

            Task tRight = new Task(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    if (!game.Collisions(Game.Move.Right))
                    {
                        FormAccess.AllieTanksDesign.Invoke(MoveRight);
                        Thread.Sleep(20);
                    }
                    if (i == 0)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.right1;
                    }
                    if (i == 7)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.right2;
                    }
                    if (i == 15)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.Right3;
                    }
                    if (i == 22)
                    {
                        FormAccess.AllieTanksDesign.Image = Properties.Resources.Right3;
                    }
                }
            });
            if (Game.Move.Down == Move)
            {
                tDown.Start();
                if (tDown.IsCompleted)
                    { tDown.Dispose(); }
            }
            else if(Game.Move.Up == Move)
            {
                tUp.Start();
                if (tUp.IsCompleted)
                { tUp.Dispose(); }
            }
            else if(Game.Move.Left == Move)
            {
                tLeft.Start();
                if (tLeft.IsCompleted)
                { tLeft.Dispose(); }
            }
            else if(Game.Move.Right == Move)
            {
                tRight.Start();
                if (tRight.IsCompleted)
                { tRight.Dispose(); }
            }
        }
    }
}
