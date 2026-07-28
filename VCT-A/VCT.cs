using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace VCT_A
{
    public partial class VCT : Form
    {
        private WindowsMediaPlayer[] players = new WindowsMediaPlayer[2];
        public VCT()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(1920, 1080);

            string[] caminhosMusicas = new string[]
            {
                @"C:\Users\Nathalia\source\repos\JuanPessoaa\VCT-A\VCT-A\Resources\CBer.mp3",
                @"C:\Users\Nathalia\source\repos\JuanPessoaa\VCT-A\VCT-A\Resources\CIns.mp3"
            };

            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new WindowsMediaPlayer();
                players[i].URL = caminhosMusicas[i];
                players[i].controls.stop();
            }
        }
    
        

        private void VCT_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string selecao = listBox1.SelectedItem.ToString();

            //comboBox1.Items.Clear();

            if (selecao == "Champions")
            {
                comboBox1.Items.Add("2021 - Berlin");
                comboBox1.Items.Add("2022 - Instanbul");
                comboBox1.Items.Add("2023 - Los Angeles");
                comboBox1.Items.Add("2024 - Seoul");
                comboBox1.Items.Add("2025 - Paris");
                comboBox1.BackColor = Color.FromArgb(197, 177, 116);
                comboBox2.BackColor = Color.FromArgb(197, 177, 116);
                comboBox3.BackColor = Color.FromArgb(197, 177, 116);
                pictureBox2.BackColor = Color.FromArgb(197, 177, 116);
                pictureBox3.BackColor = Color.FromArgb(197, 177, 116);
                pictureBox4.BackColor = Color.FromArgb(197, 177, 116);
                pictureBox5.BackColor = Color.FromArgb(197, 177, 116);
                pictureBox11.BackColor = Color.FromArgb(197, 177, 116);
                pictureBox12.BackColor = Color.FromArgb(197, 177, 116);
                checkBox1.BackColor = Color.FromArgb(197, 177, 116);
                checkBox2.BackColor = Color.FromArgb(197, 177, 116);
                checkBox3.BackColor = Color.FromArgb(197, 177, 116);
                checkBox4.BackColor = Color.FromArgb(197, 177, 116);
                comboBox1.Text = "";
                comboBox1.Visible = true;
                ExibirTodosComponentes(false);
                Silenciar();
            }
            else if (selecao == "Masters")
            {
                comboBox1.Items.Add("2021.1 - Reykjavík");
                comboBox1.Items.Add("2021.2 - Berlin");
                comboBox1.Items.Add("2022.1 - Reykjavík");
                comboBox1.Items.Add("2022.2 - Copenhagen");
                comboBox1.Items.Add("2023.0 - São Paulo");
                comboBox1.Items.Add("2023.1 - Tokyo");
                comboBox1.Items.Add("2024.1 - Madrid");
                comboBox1.Items.Add("2024.2 - Shangai");
                comboBox1.Items.Add("2025.1 - Bangkok");
                comboBox1.Items.Add("2025.2 - Toronto");
                comboBox1.Items.Add("2026.1 - Santiago");
                comboBox1.Items.Add("2026.2 - London");
                comboBox1.BackColor = Color.FromArgb(111, 74, 204);
                comboBox2.BackColor = Color.FromArgb(111, 74, 204);
                comboBox3.BackColor = Color.FromArgb(111, 74, 204);
                pictureBox2.BackColor = Color.FromArgb(111, 74, 204);
                pictureBox3.BackColor = Color.FromArgb(111, 74, 204);
                pictureBox4.BackColor = Color.FromArgb(111, 74, 204);
                pictureBox5.BackColor = Color.FromArgb(111, 74, 204);
                pictureBox11.BackColor = Color.FromArgb(111, 74, 204);
                pictureBox12.BackColor = Color.FromArgb(111, 74, 204);
                checkBox1.BackColor = Color.FromArgb(111, 74, 204);
                checkBox2.BackColor = Color.FromArgb(111, 74, 204);
                checkBox3.BackColor = Color.FromArgb(111, 74, 204);
                checkBox4.BackColor = Color.FromArgb(111, 74, 204);
                comboBox1.Text = "";
                comboBox1.Visible = true;
                ExibirTodosComponentes(false);
                Silenciar();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string Campeonato = comboBox1.SelectedItem.ToString();
            
            ExibirTodosComponentes(true);

            switch (Campeonato)
            {
                case "2021 - Berlin":
            
                    ConfigurarParaCBer();
                    
                    break;
                case "2022 - Instanbul":
                    ConfigurarParaCIns();
                    
                    break;/*
                case "2023 - Los Angeles":
                    ConfigurarParaCLos();
                    break;
                case "2024 - Seoul":
                    ConfigurarParaCSeo();
                    break;
                case "2025 - Paris":
                    ConfigurarParaCPar();
                    break;
                case "2021.1 - Reykjavík":
                    ConfigurarParaMRey1();
                    break;
                case "2021.2 - Berlin":
                    ConfigurarParaMBer();
                    break;
                case "2022.1 - Reykjavík":
                    ConfigurarParaMRey2();
                    break;
                case "2022.2 - Copenhagen":
                    ConfigurarParaMCop();
                    break;
                case "2023.0 - São Paulo":
                    ConfigurarParaMSao();
                    break;
                case "2023.1 - Tokyo":
                    ConfigurarParaMTokd();
                    break;
                case "2024.1 - Madrid":
                    ConfigurarParaMMad();
                    break;
                case "2024.2 - Shangai":
                    ConfigurarParaMSha();
                    break;
                case "2025.1 - Bangkok":
                    ConfigurarParaMBan();
                    break;
                case "2025.2 - Toronto":
                    ConfigurarParaMTor();
                    break;
                case "2026.1 - Santiago":
                    ConfigurarParaMSan();
                    break;
                case "2026.2 - London":
                    ConfigurarParaMLon();
                    break;*/
            }
        }
        private void ConfigurarParaCBer()
        {
            Limpar();
            radioButton1.Text = "Acend";
            radioButton2.Text = "Cloud9";
            radioButton3.Text = "Fnatic";
            radioButton4.Text = "Gambit";
            radioButton5.Text = "KRÜ";
            radioButton6.Text = "Team Liquid";
            radioButton7.Text = "Team Secret";
            radioButton8.Text = "X10 CRIT";

            checkBox1.Text = "1º Acend";
            checkBox2.Text = "2º Gambit";
            checkBox3.Text = "3º KRÜ";
            checkBox4.Text = "4º Team Liquid";

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] {"GMB Chronicle", "GMB d3ffo", "KRÜ Keznit"});
           
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Fracture", "Haven", "Icebox", "Split" });

            players[0].controls.play();
        }
        private void ConfigurarParaCIns()
        {
            Limpar();
            radioButton1.Text = "DRX";
            radioButton2.Text = "Fnatic";
            radioButton3.Text = "FunPlus Phoenix";
            radioButton4.Text = "Leviatán";
            radioButton5.Text = "LOUD";
            radioButton6.Text = "OpTic Gaming";
            radioButton7.Text = "Team Liquid";
            radioButton8.Text = "XSET";

            checkBox1.Text = "1º LOUD";
            checkBox2.Text = "2º OpTic Gaming";
            checkBox3.Text = "3º DRX";
            checkBox4.Text = "4º FunPlus Phoenix";

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "OPTC yay", "OPTC Victor", "OPTC crashies" });

            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Fracture", "Haven", "Icebox", "Pearl" });

            players[1].controls.play();
        }
        private void ExibirTodosComponentes(bool visivel)
        {
            groupBox1.Visible = visivel;

            comboBox2.Visible = visivel;
            comboBox3.Visible = visivel;

            pictureBox2.Visible = visivel;
            pictureBox3.Visible = visivel;
            pictureBox4.Visible = visivel;
            pictureBox5.Visible = visivel;
            pictureBox6.Visible = visivel;
            pictureBox8.Visible = visivel;
            pictureBox9.Visible = visivel;
            pictureBox10.Visible = visivel;
            pictureBox11.Visible = visivel;
            pictureBox12.Visible = visivel;

            radioButton1.Visible = visivel;
            radioButton2.Visible = visivel;
            radioButton3.Visible = visivel;
            radioButton4.Visible = visivel;
            radioButton5.Visible = visivel;
            radioButton6.Visible = visivel;
            radioButton7.Visible = visivel;
            radioButton8.Visible = visivel;

            checkBox1.Visible = visivel;
            checkBox2.Visible = visivel;
            checkBox3.Visible = visivel;
            checkBox4.Visible = visivel;

            label1.Visible = visivel;
            label2.Visible = visivel;
            label3.Visible = visivel;
            label4.Visible = visivel;
            label5.Visible = visivel;
        }
        private void Limpar()
        {
            pictureBox2.BackgroundImage = null;
            pictureBox3.BackgroundImage = null;
            pictureBox4.BackgroundImage = null;
            pictureBox5.BackgroundImage = null;
            pictureBox6.BackgroundImage = null;
            pictureBox8.BackgroundImage = null;
            pictureBox9.BackgroundImage = null;
            pictureBox10.BackgroundImage = null;
            pictureBox11.BackgroundImage = null;
            pictureBox12.BackgroundImage = null;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            Silenciar();
        }

        private void Silenciar()
        {
            foreach (var player in players)
            {
                player.controls.stop();
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                if (rb.Text.Contains("LOUD"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.LOUD;
                }
                else if (rb.Text.Contains("OpTic Gaming"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.OpTicGaming;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string Players = comboBox2.SelectedItem.ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                string Mapas = comboBox3.SelectedItem.ToString();

                switch (Mapas)
                {
                    case "Ascent":
                        pictureBox12.BackgroundImage = Properties.Resources.Ascent;
                        break;

                    /*case "Bind":
                        pictureBox1.Image = Properties.Resources.bind;
                        break;*/

                    case "Breeze":
                        pictureBox12.BackgroundImage = Properties.Resources.Breeze;
                        break;

                    /*case "Fracture":
                        pictureBox1.Image = Properties.Resources.fracture;
                        break;

                    case "Haven":
                        pictureBox1.Image = Properties.Resources.haven;
                        break;

                    case "Icebox":
                        pictureBox1.Image = Properties.Resources.icebox;
                        break;

                    case "Pearl":
                        pictureBox1.Image = Properties.Resources.pearl;
                        break;

                    default:
                        pictureBox1.Image = null; // Caso não encontre, limpa a imagem
                        break;*/
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                string Podio = checkBox1.Text;

                switch (Podio)
                {
                    case "1º LOUD":
                        pictureBox2.BackgroundImage = Properties.Resources.LOUD;
                        break;

                    /*case "Bind":
                        pictureBox1.Image = Properties.Resources.bind;
                        break;*/

                    case "1º OpTic Gaming":
                        pictureBox2.BackgroundImage = Properties.Resources.OpTicGaming;
                        break;
                }
            }
            else
            {
                pictureBox2.BackgroundImage = null;
            }
        
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }
