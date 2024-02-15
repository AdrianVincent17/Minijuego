using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    internal class Link : Personaje
    {
        private int salud;
        private int escudo;
        private int arma;
    }
    public Link(Level1 vegaZelda, int x, int  y, int s, int e, int a) : base(vegaZelda, x, y)
    {
        salud = s;
        escudo = e;
        arma = a;
    }
}
