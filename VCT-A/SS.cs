using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VCT_A
{
    public partial class SS : Form
    {
        SoundPlayer player = new SoundPlayer();
        public SS()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1920, 1080);
            this.DoubleBuffered = true;
           
            // Define o caminho do GIF
            string caminhoGif = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "SS.gif");

            if (System.IO.File.Exists(caminhoGif))
            {
                // Carrega a imagem diretamente na memória
                pictureBox1.Image = Image.FromFile(caminhoGif);
            }
            player.SoundLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Super.wav");
        }

        private void SS_Load(object sender, EventArgs e)
        {
            // O Play será executado automaticamente ASSIM QUE o áudio terminar de carregar
            player.LoadCompleted += (s, args) => player.Play();
            player.LoadAsync();

            // Configurações dos componentes de tela
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            progressBar1.Parent = pictureBox1;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label1.Text = "Carregando... " + progressBar1.Value + " %";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();
        }

        private void SS_Shown(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    }
    }
}
