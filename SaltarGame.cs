using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory
{
    public partial class SaltarGame : Form
    {
        int contadorMovimiento = 1;
        bool VolarArriba = false;
        int Distancia = 0;
        Random PosicionRandom = new Random();
        public SaltarGame()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public void IniciarJuegoSaltar()
        {
            pictureBoxPlayer.Location = new Point(19, 255);
            Distancia = PosicionRandom.Next(-160, 118);
            pictureBoxtuboArriba.Location = new Point(270, -173 - Distancia);
            pictureBoxTuboAbajo.Location = new Point(270, 319 - Distancia);
            labelPointSaltar.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int CantidadMovimientos = 5;
            if (contadorMovimiento<=CantidadMovimientos)
            {
                pictureBoxPlayer.Image = Properties.Resources.angry_bird_red_icon;
                contadorMovimiento++;
            }
            if ((contadorMovimiento > CantidadMovimientos/2)&&(contadorMovimiento <= CantidadMovimientos * 2))
            {
                pictureBoxPlayer.Image = Properties.Resources.angry_bird_red_icon;
                contadorMovimiento++;
            }
            contadorMovimiento = (contadorMovimiento > CantidadMovimientos * 2) ? 0 : contadorMovimiento;

            int ly = pictureBoxPlayer.Location.Y;
            int lx = pictureBoxPlayer.Location.X;
            if (VolarArriba)
            {
                ly = ly - 3;
                VolarArriba = false;
            }
            else
            {
                ly=ly+15;
            }
            pictureBoxPlayer.Location = new Point(pictureBoxPlayer.Location.X, ly);
            //pictureBoxPlayer.Location = new Point(pictureBoxPlayer.Location.X, ly);
            if (pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxPiso.Bounds) || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxtuboArriba.Bounds) || pictureBoxPlayer.Bounds.IntersectsWith(pictureBoxTuboAbajo.Bounds))
            {
                IniciarJuegoSaltar();
            }
            labelPointSaltar.Location = new Point(pictureBoxPlayer.Location.X + 30, pictureBoxPlayer.Location.Y - 25);
            labelPointSaltar.Text=(pictureBoxTuboAbajo.Location.X == pictureBoxPlayer.Location.X)? Convert.ToString((Convert.ToInt32(labelPointSaltar.Text)+1)).ToString():labelPointSaltar.Text;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBoxPlayer_Click(object sender, EventArgs e)
        {

        }

        private void SaltarGame_Load(object sender, EventArgs e)
        {

        }
    }
}
