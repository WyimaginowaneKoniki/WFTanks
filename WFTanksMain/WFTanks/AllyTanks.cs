using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTanks
{
    class AllyTanks : Tanks
    {
        public Form1 FormAccess;
        public PictureBox AllyTankDesign = new PictureBox();

        public AllyTanks()
        {
            Side = Sides.Buddy;

            AllyTankDesign.BackColor = System.Drawing.Color.Transparent;
            AllyTankDesign.Image = Properties.Resources.Up1;
            AllyTankDesign.Location = new System.Drawing.Point(720, 660);
            AllyTankDesign.Name = "AllyTanksDesign";
            AllyTankDesign.Size = new System.Drawing.Size(30, 30);
            AllyTankDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            AllyTankDesign.TabIndex = 0;
            AllyTankDesign.TabStop = false;
        }

        public void SetFrom1(Form1 FormConstruct)
        {
            FormAccess = FormConstruct;
            FormAccess.Controls.Add(AllyTankDesign);
        }

        public override void Shot(Game.Move TankDirection)
        {
            Bullet Bullets = new Bullet(TankDirection, FormAccess, AllyTankDesign);
        }

        public override void Movement(Game.Move Move, Game game)
        {
            var MoveDown = new Action(() =>  { if (!(AllyTankDesign.Top > 660)) { AllyTankDesign.Top += 3; } });
            var MoveUp = new Action(() =>    { if (!(AllyTankDesign.Top < 0)) { AllyTankDesign.Top -= 3; } } );
            var MoveLeft = new Action(() => { if (!(AllyTankDesign.Left < 0)) { AllyTankDesign.Left -= 3; } });
            var MoveRight = new Action(() => { if (!(AllyTankDesign.Left > 720)) { AllyTankDesign.Left += 3; } });

            Task MovementTask = new Task(() =>
            {
                if (Game.Move.Down == Move)
                {
                    AllyTankDesign.Invoke(MoveDown);
                    Thread.Sleep(10);

                    if (Enumerable.Range(0, 10).Contains(Math.Abs(FormAccess.y - AllyTankDesign.Top)))
                        AllyTankDesign.Image = Properties.Resources.Down4;

                    else if (Enumerable.Range(11, 20).Contains(Math.Abs(FormAccess.y - AllyTankDesign.Top)))
                        AllyTankDesign.Image = Properties.Resources.Down3;

                    else if (Enumerable.Range(21, 30).Contains(Math.Abs(FormAccess.y - AllyTankDesign.Top)))
                        AllyTankDesign.Image = Properties.Resources.Down2;

                    else if (Enumerable.Range(31, 40).Contains(Math.Abs(FormAccess.y - AllyTankDesign.Top)))
                        AllyTankDesign.Image = Properties.Resources.down1;
                }
                if (Game.Move.Up == Move)
                {
                    AllyTankDesign.Invoke(MoveUp);
                    Thread.Sleep(10);

                    if (Enumerable.Range(0, 10).Contains(Math.Abs(FormAccess.y - AllyTankDesign.Top)))
                        AllyTankDesign.Image = Properties.Resources.Up4;

                    else if (Enumerable.Range(11, 20).Contains(Math.Abs(FormAccess.y - AllyTankDesign.Top)))
                        AllyTankDesign.Image = Properties.Resources.Up3;

                    else if (Enumerable.Range(21, 30).Contains(Math.Abs(FormAccess.y - AllyTankDesign.Top)))
                        AllyTankDesign.Image = Properties.Resources.Up2;

                    else if (Enumerable.Range(31, 40).Contains(Math.Abs(FormAccess.y - AllyTankDesign.Top)))
                        AllyTankDesign.Image = Properties.Resources.Up1;

                }
                if (Game.Move.Left == Move)
                {
                    AllyTankDesign.Invoke(MoveLeft);
                    Thread.Sleep(10);

                    if (Enumerable.Range(0, 10).Contains(Math.Abs(FormAccess.x - AllyTankDesign.Left)))
                        AllyTankDesign.Image = Properties.Resources.Left4;

                    else if (Enumerable.Range(11, 20).Contains(Math.Abs(FormAccess.x - AllyTankDesign.Left)))
                        AllyTankDesign.Image = Properties.Resources.Left3;

                    else if (Enumerable.Range(21, 30).Contains(Math.Abs(FormAccess.x - AllyTankDesign.Left)))
                        AllyTankDesign.Image = Properties.Resources.Left2;

                    else if (Enumerable.Range(31, 40).Contains(Math.Abs(FormAccess.x - AllyTankDesign.Left)))
                        AllyTankDesign.Image = Properties.Resources.Left1;
                }
                if (Game.Move.Right == Move)
                {
                    AllyTankDesign.Invoke(MoveRight);
                    Thread.Sleep(10);

                    if (Enumerable.Range(0, 10).Contains(Math.Abs(FormAccess.x - AllyTankDesign.Left)))
                        AllyTankDesign.Image = Properties.Resources.Right4;

                    else if (Enumerable.Range(11, 20).Contains(Math.Abs(FormAccess.x - AllyTankDesign.Left)))
                        AllyTankDesign.Image = Properties.Resources.Right3;

                    else if (Enumerable.Range(21, 30).Contains(Math.Abs(FormAccess.x - AllyTankDesign.Left)))
                        AllyTankDesign.Image = Properties.Resources.Right2;

                    else if (Enumerable.Range(31, 40).Contains(Math.Abs(FormAccess.x - AllyTankDesign.Left)))
                        AllyTankDesign.Image = Properties.Resources.Right1;
                }
            });

            MovementTask.Start();
            if (MovementTask.IsCompleted)
                MovementTask.Dispose();

        }
    }
}
