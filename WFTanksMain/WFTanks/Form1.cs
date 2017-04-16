using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTanks
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var game = new Game(this);
            var MoveDown = new Action(() => { AllieTanksDesign.Top+=1; });
            var MoveUp = new Action(() => { AllieTanksDesign.Top -= 1; });
            var MoveLeft = new Action(() => { AllieTanksDesign.Left -= 1; });
            var MoveRight = new Action(() => { AllieTanksDesign.Left += 1; });
            
            if (e.KeyCode == Keys.Down && !game.Collisions())
            {
                Task t1 = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        AllieTanksDesign.Invoke(MoveDown);
                        Thread.Sleep(20);
                        if (i == 0)
                        {
                            AllieTanksDesign.Image = Properties.Resources.down1;
                        }
                        if (i == 7)
                        {
                            AllieTanksDesign.Image = Properties.Resources.down2;
                        }
                        if (i == 15)
                        {
                            AllieTanksDesign.Image = Properties.Resources.down3;
                        }
                        if (i == 22)
                        {
                            AllieTanksDesign.Image = Properties.Resources.down3;
                        }
                    }
                });
               
            }

               

                /*
                if (!(AllieTanksDesign.Top > 650))
                { AllieTanksDesign.Top += 30; }
                */
               
            
            if (e.KeyCode == Keys.Up && !game.Collisions())
            {


                Task t1 = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        AllieTanksDesign.Invoke(MoveUp);
                        Thread.Sleep(20);
                        if (i == 0)
                        {
                            AllieTanksDesign.Image = Properties.Resources.up1;
                        }
                        if (i == 7)
                        {
                            AllieTanksDesign.Image = Properties.Resources.up2;
                        }
                        if (i == 15)
                        {
                            AllieTanksDesign.Image = Properties.Resources.up3;
                        }
                        if (i == 22)
                        {
                            AllieTanksDesign.Image = Properties.Resources.up3;
                        }
                    }
                });

            }
            if (e.KeyCode == Keys.Left && !game.Collisions())
            {

                
                    Task t1 = Task.Factory.StartNew(() =>
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            AllieTanksDesign.Invoke(MoveLeft);
                            Thread.Sleep(20);
                            if (i == 0)
                            {
                                AllieTanksDesign.Image = Properties.Resources.left1;
                            }
                            if (i == 7)
                            {
                                AllieTanksDesign.Image = Properties.Resources.left2;
                            }
                            if (i == 15)
                            {
                                AllieTanksDesign.Image = Properties.Resources.left3;
                            }
                            if (i == 22)
                            {
                                AllieTanksDesign.Image = Properties.Resources.left3;
                            }
                        }
                    });
                }
            if (e.KeyCode == Keys.Right && !game.Collisions())
            {

                Task t1 = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        AllieTanksDesign.Invoke(MoveRight);
                        Thread.Sleep(20);
                        if (i == 0)
                        {
                            AllieTanksDesign.Image = Properties.Resources.right1;
                        }
                        if (i == 7)
                        {
                            AllieTanksDesign.Image = Properties.Resources.right2;
                        }
                        if (i == 15)
                        {
                            AllieTanksDesign.Image = Properties.Resources.Right3;
                        }
                        if (i == 22)
                        {
                            AllieTanksDesign.Image = Properties.Resources.Right3;
                        }
                    }
                });
            }
        }
    }
}
