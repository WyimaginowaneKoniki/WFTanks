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

        public override void Shot()
        {
            // needed?
            // TODO AllyTanks : Shot()
        }

        public override void Movement(Form1 FormAccess, Game.Move Move)
        {
            var MoveDown = new Action(() => { if (!(FormAccess.AllieTanksDesign.Top > 620)) { FormAccess.AllieTanksDesign.Top += 1; } });
            var MoveUp = new Action(() => { if (!(FormAccess.AllieTanksDesign.Top < 1)) { FormAccess.AllieTanksDesign.Top -= 1; } });
            var MoveLeft = new Action(() => { if (!(FormAccess.AllieTanksDesign.Left < 1)) FormAccess.AllieTanksDesign.Left -= 1; });
            var MoveRight = new Action(() => { if (!(FormAccess.AllieTanksDesign.Left > 700)) FormAccess.AllieTanksDesign.Left += 1; });
            if (Game.Move.Down == Move)
            {
                
                   Task t1 = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        FormAccess.AllieTanksDesign.Invoke(MoveDown);
                        Thread.Sleep(20);
                        if (i == 0)
                        {
                            FormAccess.AllieTanksDesign.Image = Properties.Resources.down1;
                        }
                        if (i == 7)
                        {
                            FormAccess.AllieTanksDesign.Image = Properties.Resources.down2;
                        }
                        if (i == 15)
                        {
                            FormAccess.AllieTanksDesign.Image = Properties.Resources.down3;
                        }
                        if (i == 22)
                        {
                            FormAccess.AllieTanksDesign.Image = Properties.Resources.down3;
                        }
                    }
                });
            }
            else if(Game.Move.Up == Move)
            {
                Task t1 = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        FormAccess.AllieTanksDesign.Invoke(MoveUp);
                        Thread.Sleep(20);
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
            }
            else if(Game.Move.Left == Move)
            {
                Task t1 = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        FormAccess.AllieTanksDesign.Invoke(MoveLeft);
                        Thread.Sleep(20);
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
            }
            else if(Game.Move.Right == Move)
            {
                Task t1 = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        FormAccess.AllieTanksDesign.Invoke(MoveRight);
                        Thread.Sleep(20);
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
            }
        }
    }
}
