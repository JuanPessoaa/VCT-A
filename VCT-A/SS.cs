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
        }

        private void SS_Load(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\Nathalia\source\repos\JuanPessoaa\VCT-A\VCT-A\Resources\Super.wav";
            //player.Load();
            //player.Play();
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
    }
}
