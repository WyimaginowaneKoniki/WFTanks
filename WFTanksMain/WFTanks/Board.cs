using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTanks
{
    public class Board
    {
        Form1 FormAccess;
        public PictureBox EagleImage = new PictureBox();

        public List<PictureBox> Wallss = new List<PictureBox>();
        public void SetFrom1(Form1 FormConstruct)
        {
            FormAccess = FormConstruct;

            for (int i = 0; i <= 55; i++)
            {
                Wallss.Add((PictureBox)new PictureBox());
                Wallss[i].Name = ("BrickWall" + i);
                Wallss[i].Image = Properties.Resources.brickimage;
                Wallss[i].Size = new System.Drawing.Size(30, 30);
                Wallss[i].SizeMode = PictureBoxSizeMode.StretchImage;

                //FormAccess.Controls.Add(Wallss[i]);
            }

            // FormAccess.Controls.Add(EagleImage);


            EagleImage.BackColor = System.Drawing.Color.Transparent;
            EagleImage.Image = Properties.Resources.eagle;
            EagleImage.Location = new System.Drawing.Point(330, 660);
            EagleImage.Name = "EagleImage";
            EagleImage.Size = new System.Drawing.Size(30, 30);
            EagleImage.SizeMode = PictureBoxSizeMode.StretchImage;

            Wallss[0].Location = new System.Drawing.Point(360, 660);
            Wallss[1].Location = new System.Drawing.Point(360, 630);
            Wallss[2].Location = new System.Drawing.Point(330, 630);
            Wallss[3].Location = new System.Drawing.Point(300, 630);
            Wallss[4].Location = new System.Drawing.Point(300, 660);
            Wallss[5].Location = new System.Drawing.Point(240, 600);
            Wallss[6].Location = new System.Drawing.Point(240, 570);
            Wallss[7].Location = new System.Drawing.Point(240, 540);
            Wallss[8].Location = new System.Drawing.Point(240, 510);
            Wallss[9].Location = new System.Drawing.Point(150, 510);
            Wallss[10].Location = new System.Drawing.Point(150, 540);
            Wallss[11].Location = new System.Drawing.Point(150, 570);
            Wallss[12].Location = new System.Drawing.Point(150, 600);
            Wallss[13].Location = new System.Drawing.Point(210, 420);
            Wallss[14].Location = new System.Drawing.Point(180, 420);
            Wallss[15].Location = new System.Drawing.Point(300, 420);
            Wallss[16].Location = new System.Drawing.Point(300, 450);
            Wallss[17].Location = new System.Drawing.Point(300, 480);
            Wallss[18].Location = new System.Drawing.Point(300, 510);
            Wallss[19].Location = new System.Drawing.Point(360, 420);
            Wallss[20].Location = new System.Drawing.Point(360, 450);
            Wallss[21].Location = new System.Drawing.Point(360, 480);
            Wallss[22].Location = new System.Drawing.Point(360, 510);
            Wallss[23].Location = new System.Drawing.Point(330, 450);
            Wallss[24].Location = new System.Drawing.Point(450, 510);
            Wallss[25].Location = new System.Drawing.Point(450, 540);
            Wallss[26].Location = new System.Drawing.Point(450, 570);
            Wallss[27].Location = new System.Drawing.Point(450, 600);
            Wallss[28].Location = new System.Drawing.Point(540, 510);
            Wallss[29].Location = new System.Drawing.Point(540, 540);
            Wallss[30].Location = new System.Drawing.Point(540, 570);
            Wallss[31].Location = new System.Drawing.Point(540, 600);
            Wallss[32].Location = new System.Drawing.Point(480, 420);
            Wallss[33].Location = new System.Drawing.Point(510, 420);
            Wallss[34].Location = new System.Drawing.Point(360, 360);
            Wallss[35].Location = new System.Drawing.Point(300, 360);
            Wallss[36].Location = new System.Drawing.Point(150, 150);
            Wallss[37].Location = new System.Drawing.Point(150, 180);
            Wallss[38].Location = new System.Drawing.Point(150, 210);
            Wallss[39].Location = new System.Drawing.Point(150, 240);
            Wallss[40].Location = new System.Drawing.Point(240, 150);
            Wallss[41].Location = new System.Drawing.Point(240, 180);
            Wallss[42].Location = new System.Drawing.Point(240, 210);
            Wallss[43].Location = new System.Drawing.Point(240, 240);
            Wallss[44].Location = new System.Drawing.Point(0, 300);
            Wallss[45].Location = new System.Drawing.Point(720, 300);
            Wallss[46].Location = new System.Drawing.Point(510, 180);
            Wallss[47].Location = new System.Drawing.Point(450, 120);
            Wallss[48].Location = new System.Drawing.Point(450, 150);
            Wallss[49].Location = new System.Drawing.Point(450, 180);
            Wallss[50].Location = new System.Drawing.Point(450, 210);
            Wallss[51].Location = new System.Drawing.Point(540, 120);
            Wallss[52].Location = new System.Drawing.Point(540, 150);
            Wallss[53].Location = new System.Drawing.Point(540, 180);
            Wallss[54].Location = new System.Drawing.Point(540, 210);
            Wallss[55].Location = new System.Drawing.Point(480, 150);


        }

    }
}
