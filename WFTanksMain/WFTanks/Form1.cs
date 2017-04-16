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

            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            if (e.KeyCode == Keys.Down && !game.Collisions())
            {

                Task t1 = Task.Factory.StartNew(() =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        AllieTanksDesign.Image = Properties.Resources.down1;
                        if (!((AllieTanksDesign.Top + 30) > 650))
                            { AllieTanksDesign.Top += 7; }
                        Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.down3;
                        if (!((AllieTanksDesign.Top + 23) > 650))
                            { AllieTanksDesign.Top += 8; }
                        Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.down4;
                        if (!((AllieTanksDesign.Top + 15) > 650))
                            { AllieTanksDesign.Top += 7; }
                        Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.down2;
                        if (!((AllieTanksDesign.Top + 8) > 650))
                            { AllieTanksDesign.Top += 8; }
                        Thread.Sleep(100);
                    }
                }, token);

                /*
                if (!(AllieTanksDesign.Top > 650))
                { AllieTanksDesign.Top += 30; }
                */
                tokenSource.Cancel();
                if (t1.IsCanceled)
                    t1.Dispose();
            }
            if (e.KeyCode == Keys.Up && !game.Collisions())
            {


                Task t1 = Task.Factory.StartNew(() =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        AllieTanksDesign.Image = Properties.Resources.up1;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.up3;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.up4;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.up2;
                        System.Threading.Thread.Sleep(100);
                    }
                }, token);


                if (!(AllieTanksDesign.Top < 30))
                { AllieTanksDesign.Top -= 30; }

                tokenSource.Cancel();
                if (t1.IsCanceled)
                    t1.Dispose();

            }
            if (e.KeyCode == Keys.Left && !game.Collisions())
            {

                Task t1 = Task.Factory.StartNew(() =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        AllieTanksDesign.Image = Properties.Resources.left1;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.left3;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.left4;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.left2;
                        System.Threading.Thread.Sleep(100);
                    }
                }, token);

                if (!(AllieTanksDesign.Left < 30))
                { AllieTanksDesign.Left -= 30; }

                tokenSource.Cancel();
                if (t1.IsCanceled)
                    t1.Dispose();
            }
            if (e.KeyCode == Keys.Right && !game.Collisions())
            {

                Task t1 = Task.Factory.StartNew(() =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        AllieTanksDesign.Image = Properties.Resources.right1;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.Right3;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.Right4;
                        System.Threading.Thread.Sleep(100);
                        AllieTanksDesign.Image = Properties.Resources.right2;
                        System.Threading.Thread.Sleep(100);
                    }
                }, token);

                if (!(AllieTanksDesign.Left > 700))
                { AllieTanksDesign.Left += 30; }

                tokenSource.Cancel();
                if (t1.IsCanceled)
                    t1.Dispose();
            }
        }
    }
}
