using System.CodeDom;
using System.Diagnostics;
using System.Drawing.Text;
using System.Media;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        SoundPlayer musica;
        Boolean HaySonido = false;

        public Level1(CheckBox onOff)
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesDelMapa(onOff);
        }

        private void IniciarOpcionesDelMapa(CheckBox onOff)
        {
            if (onOff.Checked == true)
            {
                musica = new SoundPlayer(global::VegaJuego.Properties.Resources.sonido);
                musica.PlayLooping();
                HaySonido = true;
            }
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;
        }
        private void IniciarPersonajes()
        {
            //Lienzo, coordenaX, coordenaY, salud, escudo, arma
            Player = new Link(this, 0, 0, 100, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
            Debug.WriteLine("[X" + Player.Caja.Location.X + ",Y" + Player.Caja.Location.Y + "]");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;

            if (Player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))
            {
                Player.Salud = Player.Salud - 1;
            }
            Enemigo1.mover();

            if (Player.Salud <= 0)
            {
                this.Hide();
                if (HaySonido == true)
                {
                    musica.Stop();
                }
                Final End = new Final();
                //Paramos el temporizador
                MovEnemigos.Stop();
                End.Show();
            }
        }
        private void Level1FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void labelVida_Click(object sender, EventArgs e)
        {

        }
    }
}
