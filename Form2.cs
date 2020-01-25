using System;
using System.Collections;
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
    public partial class FormGame : Form
    {
        int TamanioClumnasFilas = 4;//para el size de las filas y columnas
        int Movimientos = 0;
        int CantidadDeCartasVoltear = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccioandas;
        PictureBox CartaTemporal1;//para cuando se selecciona la carta
        PictureBox CartaTemporal2;
        int CartaActual = 0;//para saver q carta estamos actualmente

        public FormGame()
        {
            InitializeComponent();
            iniciarJuego();
        }
        public void iniciarJuego()
        {
            timer1.Enabled = false;//configuramos el timer
            timer1.Stop();//detenemos el timer
            labelPuntuacion.Text = "0";//instanciamos la puntuacion
            CantidadDeCartasVoltear = 0;//la cantidad de cartas a voltear
            Movimientos = 0;
            panelJuego.Controls.Clear();//limpiamos el panel del juego
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccioandas = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioClumnasFilas;
            tablaPanel.ColumnCount = TamanioClumnasFilas;

            for (int i = 0; i < TamanioClumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioClumnasFilas - 10;//saca el porcentaje para el size de la ventana
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));//para q se adapte el panel
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;
            for (int i = 0; i < TamanioClumnasFilas; i++)
            {
                for (int j = 0; j < TamanioClumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = String.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Voltear;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += buttonCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            panelJuego.Controls.Add(tablaPanel);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }
        private void buttonCarta_Click(object sender, EventArgs e)
        {
            if (CartasSeleccioandas.Count < 2)
            {
               
                var CartasSeleccionaUsuario = (PictureBox)sender;
                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionaUsuario.Name)-1]);
                CartasSeleccionaUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccioandas.Add(CartasSeleccionaUsuario);
                if (CartasSeleccioandas.Count == 2)
                {
                    
                    CartaTemporal1 = (PictureBox)CartasSeleccioandas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccioandas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                    if (Carta1 != Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                        Movimientos--;
                        labelPuntuacion.Text = Convert.ToString(Movimientos);
                    }
                    else
                    {
                        Movimientos++;
                        labelPuntuacion.Text = Convert.ToString(Movimientos);
                        CantidadDeCartasVoltear++;
                        if (CantidadDeCartasVoltear > 7)
                        {
                            if (Movimientos>0)
                            {
                                MessageBox.Show("Juego Termino \n Ganeste");
                            }
                            else
                            {
                                MessageBox.Show("Juego Termino \n Perdiste");
                            }
                            
                            iniciarJuego();
                        }
                        CartaTemporal1.Enabled = false;
                        CartaTemporal2.Enabled = false;
                        CartasSeleccioandas.Clear();

                    }
                }
            }

        }

        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.img11;
                    break;

                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + NumeroImagen);
                    break;
            }
            return TmpImg;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta==1)
            {
                CartaTemporal1.Image = Properties.Resources.Voltear;
                CartaTemporal2.Image = Properties.Resources.Voltear;

                CartasSeleccioandas.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }
    }
}
