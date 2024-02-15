using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    internal class Personaje
    {
        private int coordx;
        private int coordy;
        private Level1 lienzo;
        private PictureBox caja= new PictureBox();
        private String direccion;

        public Personaje(Level1 vegaZelda, int x, int y)
        {
            coordx = x;
            coordy = y;
            lienzo = vegaZelda;
            direccion = "Derecha";
            caja.Location=new System.Drawing.Point(Coordx, Coordy);
            caja.BackColor = System.Drawing.Color.Transparent;
            caja.Size = new System.Drawing.Size(110, 110);
            caja.BackgroundImageLayout=System.Windows.Forms.ImageLayout.None;
            caja.BackgroundImage = global::VegaJuego.Properties.Resources.derecha;

            vegaZelda.Controls.Add(caja); caja.Visible = true;
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Coordy
        {
            get { return coordy; }
            set { coordy = value; }
        }
        public int Coordx
        {
            get { return coordx; }
            set { coordx = value; }
        }

        public Level1 Lienzo
        {
            get { return lienzo; }
            set { lienzo = value; }
        }

        public PictureBox Caja
        {
            get { return caja; }
            set { caja = value; }
        }
        //Metodo que se definira en cada clase hija
            public void mover()
        {

        }
        }
    }

