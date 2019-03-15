using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace tiroparabolico
{
    public partial class Form1 : Form
    {
        List<vector> vectores;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            label3.Text = trackBar1.Value.ToString();
            buttonDatos.Enabled = false;
            vectores = null;
            g = pictureBox1.CreateGraphics();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            tabla aux = new tabla(vectores);
            aux.ShowDialog();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            vectores = new List<vector>();
            tiroParabolico aux = new tiroParabolico((float)numericUpDown1.Value,(float)trackBar1.Value,(float)9.81);

            float alturaMaxima = tiroParabolico.getAlturaMaxima((float)numericUpDown1.Value, (float)90, (float)9.81);
            float alcanceMaximo = tiroParabolico.getAlcance((float)numericUpDown1.Value, (float)45, (float)9.81);
            labelAlcance.Text = aux.alcance().ToString() + " Metros";
            labelAltura.Text = aux.alturaMaxima().ToString() + " Metros";
            labelTiempo.Text = aux.tiempoVuelo().ToString() + " Segundos";

            labelAlturaMaxima.Text = alturaMaxima.ToString() + " Metros";
            labelAlcanceMaximo.Text = alcanceMaximo.ToString() + " Metros";

            vectores = aux.getListVector();

            SolidBrush brush = new SolidBrush(Color.Black);
            g.Clear(Color.White);
            float width = pictureBox1.Width;
            float height = pictureBox1.Height;

            labelheight.Text  = alturaMaxima.ToString() + " m.";
            labelwidth.Text = alcanceMaximo.ToString() + " m.";
            labelmidheight.Text = (alturaMaxima / 2).ToString() + " m.";
            labelmidwidth.Text = (alcanceMaximo / 2).ToString() + " m.";


            for (int i = 0; i < vectores.Count; i++) {
                Thread.Sleep(20);
                g.FillEllipse(brush, (vectores[i].getx() / alcanceMaximo) * width,height -((vectores[i].getY() / alturaMaxima ) * height ), 5, 5);
            }

            buttonDatos.Enabled = true;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "----------- Simulacion de Tiro Parabolico -----------\n"+
                "\n"+
                "Autor: Alan Andre Morales Renteria\n"+
                "Fecha: 15 de marzo del 2019\n"+
                "\n"+
                "Centro Universitario de Ciencia Exactas e Ingenierias"
                );
        }

    }
}
