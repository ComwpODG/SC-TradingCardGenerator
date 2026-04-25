using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGenerator
{
    public partial class Form1 : Form
    {

        Bitmap myBitmap = new Bitmap(@"Assets\Bases\commandercardbaseholographic.png");
        Graphics g;
        Bitmap shipBitmap = new Bitmap(@"Assets\ShipIcons\All in one folder\100px-Hammerhead.png");
        Bitmap bgBitmap = new Bitmap(@"Assets\ShipBacks\FederationBack.png");
        StringFormat sf = new StringFormat();
        StringFormat leftsf = new StringFormat();
        RectangleF rectf;
        public Form1()
        {
            InitializeComponent();
            foreach (ShipPair sp in Infobase.Ships)
            {
                this.cbxShipAutoComplete.Items.Add(sp.ShipName);
            }

            foreach (PlayerDesc sp in Infobase.Playerbase)
            {
                this.cbxPlayers.Items.Add(sp.PlayerName);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            //reset image

            //load image
            myBitmap.Dispose();
            bgBitmap.Dispose();

            if(cbStyle.Text == "")
            {
                cbStyle.Text = "Standard";
            }

            if (cbStyle.Text == "Standard")
            { 
                myBitmap = new Bitmap(@"Assets\Bases\cardbase.png");
            }
            if (cbStyle.Text == "Holographic")
            {
                myBitmap = new Bitmap(@"Assets\Bases\cardbaseholographic.png");
            }
            if (cbStyle.Text == "Command")
            {
                myBitmap = new Bitmap(@"Assets\Bases\commandercardbaseholographic.png");
            }


            if(cbxFaction.Text == "")
            {
                cbxFaction.Text = "Federation";
            }

            bgBitmap = new Bitmap(@"Assets\ShipBacks\" + cbxFaction.Text + "Back.png");
            



            g = Graphics.FromImage(myBitmap);
            //draw text
            
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = PixelOffsetMode.None;
            
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            
            leftsf.Alignment = StringAlignment.Near;
            leftsf.LineAlignment = StringAlignment.Near;

            
            int rating = tbxRating.Text==""?100:Convert.ToInt32(tbxRating.Text);

            g.DrawImage(bgBitmap, 19, 97);
            g.DrawImage(shipBitmap, 105, 168);
            

            //Hull
            rectf = new RectangleF(668, 116, 153, 84);
            g.DrawString(tbxHull.Text, new System.Drawing.Font("Arial", 72, FontStyle.Bold), cbStyle.Text == "Command" ? Brushes.LightPink : cbHullUnique.Checked ? Brushes.Goldenrod : Brushes.White, rectf, sf);
            //Shield
            rectf = new RectangleF(668 + 269, 116, 153, 84);
            g.DrawString(tbxShield.Text, new System.Drawing.Font("Arial", 72, FontStyle.Bold), cbStyle.Text == "Command" ? Brushes.LightPink : cbShieldUnique.Checked ? Brushes.Goldenrod : Brushes.White, rectf, sf);
            //Speed
            rectf = new RectangleF(668 , 116 + 105, 153, 84);
            g.DrawString(tbxSpeed.Text, new System.Drawing.Font("Arial", 38, FontStyle.Bold), cbStyle.Text == "Command" ? Brushes.LightPink : cbSpeedUnique.Checked ? Brushes.Goldenrod : Brushes.White, rectf, sf);
            //Evasion
            rectf = new RectangleF(668 + 269, 116 + 105, 153, 84);
            g.DrawString(tbxEvasion.Text, new System.Drawing.Font("Arial", 72, FontStyle.Bold), cbStyle.Text == "Command" ? Brushes.LightPink : cbEvasionUnique.Checked ? Brushes.Goldenrod : Brushes.White, rectf, sf);
            //Range
            rectf = new RectangleF(668 , 116 + 210, 153, 84);
            g.DrawString(tbxRange.Text, new System.Drawing.Font("Arial", 38, FontStyle.Bold), cbStyle.Text == "Command" ? Brushes.LightPink : cbRangeUnique.Checked ? Brushes.Goldenrod : Brushes.White, rectf, sf);
            //Targeting
            rectf = new RectangleF(668 + 269, 116 + 210, 153, 84);
            g.DrawString(tbxTargeting.Text, new System.Drawing.Font("Arial", 72, FontStyle.Bold), cbStyle.Text == "Command" ? Brushes.LightPink : cbTargetingUnique.Checked ? Brushes.Goldenrod : Brushes.White, rectf, sf);

            //Rating
            rectf = new RectangleF(884,10,226,64);
            g.DrawString(tbxRating.Text, new System.Drawing.Font("Arial", 50, FontStyle.Bold), (rating <= 1000 ? Brushes.Gray : rating <= 2000 ? Brushes.White : rating <= 3000 ? Brushes.Green : rating <= 4000 ? Brushes.Blue : rating <= 5000 ? Brushes.Purple : Brushes.Orange), rectf, sf);
            //Player Name
            rectf = new RectangleF(18,14,783,72);
            g.DrawString(tbxPlayerName.Text, new System.Drawing.Font("Arial", 45+(tbxPlayerName.Text.Length<22?0 : 2*(22-tbxPlayerName.Text.Length)), FontStyle.Bold), Brushes.White, rectf, sf);
            //Ship Name
            rectf = new RectangleF(23,100,402,60);
            g.DrawString(tbxShipName.Text, new System.Drawing.Font("Arial", 38, FontStyle.Bold), Brushes.White, rectf, sf);
            //Ship Rank
            rectf = new RectangleF(443,97,107,82);
            g.DrawString(tbxShipRank.Text, new System.Drawing.Font("Arial", 45, FontStyle.Bold), Brushes.White, rectf, sf);
            //Gun Element
            rectf = new RectangleF(11,382,90,36);
            g.DrawString(cbElement.Text, new System.Drawing.Font("Arial", 25, FontStyle.Bold), cbElement.Text == "TH" ? Brushes.Red : cbElement.Text == "EM" ? Brushes.Cyan : Brushes.Yellow, rectf, sf);
            
            //Left menu
            rectf = new RectangleF(25,440,519,976);
            g.DrawString(tbxPlayerStats.Text, new System.Drawing.Font("Arial", 26, FontStyle.Bold), Brushes.White, rectf, leftsf);
            //Right menu
            rectf = new RectangleF(571,417,527,1182);
            g.DrawString(tbxShipStats.Text.Replace("GUNSTATSHERE","\""+cbElement.Text+" Weapon\": 2 Damage."), new System.Drawing.Font("Arial", 26, FontStyle.Bold), Brushes.White, rectf, leftsf);

            pbx.Image = myBitmap;
            g.Dispose();

        }

        private void btnShipImage_Click(object sender, EventArgs e)
        {
            if((openFileDialog1.ShowDialog()==DialogResult.OK))
            {
                try
                {
                    shipBitmap.Dispose();
                    shipBitmap = new Bitmap(openFileDialog1.FileName);
                    shipBitmap = Methods.ResizeImage(shipBitmap, 364, 251);
                    //set image
                }
                catch(Exception h)
                {

                }


                btnApply_Click(sender, e);
            }
        }

        private void cbxShipAutoComplete_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShipPair s = Infobase.Ships.FirstOrDefault(sp => sp.ShipName == cbxShipAutoComplete.Text);
            cbxFaction.Text = s.Faction;
            tbxShipName.Text = s.ShipName;
            tbxHull.Text = s.Health;
            tbxShield.Text = s.Shield;
            tbxShipRank.Text = s.Rank;
            tbxSpeed.Text = s.Speed;
            tbxEvasion.Text = s.Evasion;
            tbxTargeting.Text = s.Targeting;
            tbxRange.Text = s.Range;
            tbxShipStats.Text = s.ShipDescription;
            shipBitmap.Dispose();
            shipBitmap = new Bitmap(@"Assets\ShipIcons\All in one folder\" + s.ImageFileName);
            shipBitmap = Methods.ResizeImage(shipBitmap, 364, 251);
            tbxCardName.Text = cbxPlayers.Text + "" + cbxShipAutoComplete.Text;
            btnApply_Click(sender, e);
        }
        private void cbxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayerDesc p = Infobase.Playerbase.FirstOrDefault(sp => sp.PlayerName == cbxPlayers.Text);
            tbxCardName.Text = cbxPlayers.Text+""+cbxShipAutoComplete.Text;
            tbxPlayerName.Text = cbxPlayers.Text;
            tbxPlayerStats.Text = p.PlayerStats;
            btnApply_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap printableBMP = new Bitmap(1283, 2053);
            Graphics gp = Graphics.FromImage(printableBMP);
            gp.SmoothingMode = SmoothingMode.HighQuality;
            gp.InterpolationMode = InterpolationMode.NearestNeighbor;
            gp.PixelOffsetMode = PixelOffsetMode.None;

            gp.DrawImage(pbx.Image, 80, 128);

            printableBMP.Save(@"Output\" + tbxCardName.Text +".png", ImageFormat.Png);

            printableBMP.Dispose();
            gp.Dispose();

        }

        
    }
}
