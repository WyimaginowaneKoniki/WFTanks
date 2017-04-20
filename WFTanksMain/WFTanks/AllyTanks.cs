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
            var MoveDown = new Action(() => { if (!(FormAccess.AllieTanksDesign.Top > 660)) { FormAccess.AllieTanksDesign.Top += 2; } });
            var MoveUp = new Action(() => { if (!(FormAccess.AllieTanksDesign.Top < 1)) { FormAccess.AllieTanksDesign.Top -= 2; } });
            var MoveLeft = new Action(() => { if (!(FormAccess.AllieTanksDesign.Left < 1)) FormAccess.AllieTanksDesign.Left -= 2; });
            var MoveRight = new Action(() => { if (!(FormAccess.AllieTanksDesign.Left > 720)) FormAccess.AllieTanksDesign.Left += 2; });
       
            Task tDown = new Task(() =>
            {
                
                      FormAccess.AllieTanksDesign.Invoke(MoveDown);
                      Thread.Sleep(10);
                if(Enumerable.Range(0,10).Contains(Math.Abs(FormAccess.y - FormAccess.AllieTanksDesign.Top)))
                     FormAccess.AllieTanksDesign.Image = Properties.Resources.down1;
                if (Enumerable.Range(11, 20).Contains(Math.Abs(FormAccess.y - FormAccess.AllieTanksDesign.Top)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.down2;
                if (Enumerable.Range(21, 30).Contains(Math.Abs(FormAccess.y - FormAccess.AllieTanksDesign.Top)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.down4;
                    
                if (Enumerable.Range(31, 40).Contains(Math.Abs(FormAccess.y - FormAccess.AllieTanksDesign.Top)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.down3;

                
            });
           
            Task tUp = new Task(() =>
            {
               
                   
                        FormAccess.AllieTanksDesign.Invoke(MoveUp);
                        Thread.Sleep(10);

                if (Enumerable.Range(0, 10).Contains(Math.Abs(FormAccess.y - FormAccess.AllieTanksDesign.Top)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.up1;
                if (Enumerable.Range(11, 20).Contains(Math.Abs(FormAccess.y - FormAccess.AllieTanksDesign.Top)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.up2;
                if (Enumerable.Range(21, 30).Contains(Math.Abs(FormAccess.y - FormAccess.AllieTanksDesign.Top)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.up4;

                if (Enumerable.Range(31, 40).Contains(Math.Abs(FormAccess.y - FormAccess.AllieTanksDesign.Top)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.up3;

            });

            Task tLeft = new Task(() =>
            {

                        FormAccess.AllieTanksDesign.Invoke(MoveLeft);
                        Thread.Sleep(10);
                if (Enumerable.Range(0, 10).Contains(Math.Abs(FormAccess.x - FormAccess.AllieTanksDesign.Left)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.left1;
                if (Enumerable.Range(11, 20).Contains(Math.Abs(FormAccess.x - FormAccess.AllieTanksDesign.Left)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.left2;
                if (Enumerable.Range(21, 30).Contains(Math.Abs(FormAccess.x - FormAccess.AllieTanksDesign.Left)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.left4;

                if (Enumerable.Range(31, 40).Contains(Math.Abs(FormAccess.x - FormAccess.AllieTanksDesign.Left)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.left3;


            });

            Task tRight = new Task(() =>
            {
                
                    
                        FormAccess.AllieTanksDesign.Invoke(MoveRight);
                        Thread.Sleep(10);

              
                if (Enumerable.Range(0, 10).Contains(Math.Abs(FormAccess.x - FormAccess.AllieTanksDesign.Left)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.right1;
                if (Enumerable.Range(11, 20).Contains(Math.Abs(FormAccess.x - FormAccess.AllieTanksDesign.Left)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.right2;
                if (Enumerable.Range(21, 30).Contains(Math.Abs(FormAccess.x - FormAccess.AllieTanksDesign.Left)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.Right4;
                if (Enumerable.Range(31, 40).Contains(Math.Abs(FormAccess.x - FormAccess.AllieTanksDesign.Left)))
                    FormAccess.AllieTanksDesign.Image = Properties.Resources.Right3;


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
