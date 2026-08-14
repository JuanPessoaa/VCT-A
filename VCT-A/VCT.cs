using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCT_A.Properties;
using WMPLib;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
/*Nome: Windows Media Player
Caminho: C:\Windows\system32\wmp.dll
Versão: 1.0
Versão do Arquivo: 12.0.26100.8875 (WinBuild.160101.0800)*/

//label6 total
//label7 numero
//label8 data
//label9 local
namespace VCT_A
{
    public partial class VCT : Form
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        SoundPlayer playerwav = new SoundPlayer();
        public VCT()
        {
            InitializeComponent();

            player.settings.setMode("loop", true);

            this.Size = new System.Drawing.Size(1920, 1080);
            this.DoubleBuffered = true;
        }
        private void VCT_Load(object sender, EventArgs e)
        {
            Tocar("MusicFEARLESS.mp3");
        }

        private void Tocar(string arquivo)
        {
            player.controls.stop();
            string caminho = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath,"Audio",arquivo);
            player.URL = caminho;
            player.controls.play();
        }

        private void TocarWav(string nomeArquivo)
        {
            string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", nomeArquivo);

            if (System.IO.File.Exists(caminho))
            {
                // Remove e adiciona o evento pra nn duplicar
                playerwav.LoadCompleted -= Playerwav_LoadCompleted;
                playerwav.LoadCompleted += Playerwav_LoadCompleted;
                playerwav.SoundLocation = caminho;
                playerwav.LoadAsync();
            }
        }

        //executa o wav assim que carregar
        private void Playerwav_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            playerwav.Play();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string selecao = listBox1.SelectedItem.ToString();

            comboBox1.Items.Clear();

            if (selecao == "Champions")
            {
                TocarWav("AudioListBox.wav");
                player.controls.stop();
                comboBox1.Text = "";
                comboBox1.Visible = true;
                comboBox1.Items.Add("2021 - Berlin");
                comboBox1.Items.Add("2022 - Instanbul");
                comboBox1.Items.Add("2023 - Los Angeles");
                comboBox1.Items.Add("2024 - Seoul");
                comboBox1.Items.Add("2025 - Paris");
                comboBox1.BackColor = Color.FromArgb(197, 177, 116);
                comboBox1.ForeColor = Color.Black;
                comboBox2.BackColor = Color.FromArgb(197, 177, 116);
                comboBox2.ForeColor = Color.White;
                comboBox3.BackColor = Color.FromArgb(197, 177, 116);
                comboBox3.ForeColor = Color.White;
                pictureBox11.BackColor = Color.FromArgb(197, 177, 116);
                pictureBox12.BackColor = Color.FromArgb(197, 177, 116);
                listBox1.BackColor = Color.FromArgb(197, 177, 116);
                listBox1.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton6.ForeColor = Color.White;
                radioButton7.ForeColor = Color.White;
                radioButton8.ForeColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                this.Text = "Valorant Champions Tour | Champions";
                this.BackgroundImage = Properties.Resources.WallpaperChampionsD;
                pictureBox1.BackgroundImage = Properties.Resources.vcticonpreta;
                ExibirTodosComponentes(false);
            }
            else if (selecao == "Masters")
            {
                TocarWav("AudioListBox.wav");
                player.controls.stop();
                comboBox1.Text = "";
                comboBox1.Visible = true;
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
                comboBox1.ForeColor = Color.White;
                comboBox2.BackColor = Color.FromArgb(111, 74, 204);
                comboBox2.ForeColor = Color.Black;
                comboBox3.BackColor = Color.FromArgb(111, 74, 204);
                comboBox3.ForeColor = Color.Black;
                pictureBox11.BackColor = Color.FromArgb(111, 74, 204);
                pictureBox12.BackColor = Color.FromArgb(111, 74, 204);
                listBox1.BackColor = Color.FromArgb(111, 74, 204);
                listBox1.ForeColor = Color.White;
                groupBox1.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                this.Text = "Valorant Champions Tour | Masters";
                this.BackgroundImage = Properties.Resources.WallpaperMastersD;
                pictureBox1.BackgroundImage = Properties.Resources.vcticonbranca;
                ExibirTodosComponentes(false);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string Campeonato = comboBox1.SelectedItem.ToString();

            ExibirTodosComponentes(true);
            TocarWav("AudioComboBox.wav");

            switch (Campeonato)
            {
                case "2021 - Berlin":
                    ConfigurarParaCBer();
                    break;
                case "2022 - Instanbul":
                    ConfigurarParaCIns();
                    break;
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
                    ConfigurarParaMTok();
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
                    break;
            }
        }
        private void ConfigurarParaCBer()
        {
            Limpar();
            Tocar("MusicCBer.mp3");
            this.Text = "Valorant Champions Tour | Champions 2021 - Berlin";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyChampions;
            pictureBox9.BackgroundImage = Properties.Resources.LogoCBer;
            pictureBox6.BackgroundImage = Properties.Resources.CapaCBer;
            label7.Text = "$1.000.000";
            label8.Text = "1 a 12 de dezembro de 2021";
            label9.Text = "Berlin, Alemanha";
            label10.Text = "$350.000";
            label11.Text = "$150.000";
            label12.Text = "$90.000";
            label13.Text = "$90.000";
            radioButton1.Text = "Acend";
            radioButton2.Text = "Cloud9";
            radioButton3.Text = "FNATIC";
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
            comboBox2.Items.AddRange(new object[] { "GMB Chronicle", "GMB d3ffo", "KRÜ Keznit" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Fracture", "Haven", "Icebox", "Split" });
        }

        private void ConfigurarParaCIns()
        {
            Limpar();
            Tocar("MusicCIns.mp3");
            this.Text = "Valorant Champions Tour | Champions 2022 - Instanbul";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyChampions;
            pictureBox9.BackgroundImage = Properties.Resources.LogoCIns;
            pictureBox6.BackgroundImage = Properties.Resources.CapaCIns;
            label7.Text = "$1.000.000";
            label8.Text = "1 a 12 de dezembro de 2021";
            label9.Text = "Berlin, Alemanha";
            label10.Text = "$350.000";
            label11.Text = "$150.000";
            label12.Text = "$90.000";
            label13.Text = "$90.000";
            radioButton1.Text = "DRX";
            radioButton2.Text = "FNATIC";
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
        }

        private void ConfigurarParaCLos()
        {
            Limpar();
            Tocar("MusicCLos.mp3");
            this.Text = "Valorant Champions Tour | Champions 2023 - Los Angeles";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyChampions;
            pictureBox9.BackgroundImage = Properties.Resources.LogoCLos;
            pictureBox6.BackgroundImage = Properties.Resources.CapaCLos;
            radioButton1.Text = "Bilibili Gaming";
            radioButton2.Text = "DRX";
            radioButton3.Text = "EDward Gaming";
            radioButton4.Text = "Evil Geniuses";
            radioButton5.Text = "FNATIC";
            radioButton6.Text = "FUT";
            radioButton7.Text = "LOUD";
            radioButton8.Text = "Paper Rex";
            checkBox1.Text = "1º Evil Geniuses";
            checkBox2.Text = "2º Paper Rex";
            checkBox3.Text = "3º LOUD";
            checkBox4.Text = "4º FNATIC";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "LOUD aspas", "EG Demon1", "LOUD Less" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Fracture", "Haven", "Lotus", "Pearl", "Split" });
        }

        private void ConfigurarParaCSeo()
        {
            Limpar();
            Tocar("MusicCSeo.mp3");
            this.Text = "Valorant Champions Tour | Champions 2024 - Seoul";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyChampions;
            pictureBox9.BackgroundImage = Properties.Resources.LogoCSeo;
            pictureBox6.BackgroundImage = Properties.Resources.CapaCSeo;
            radioButton1.Text = "DRX";
            radioButton2.Text = "EDward Gaming";
            radioButton3.Text = "FNATIC";
            radioButton4.Text = "G2";
            radioButton5.Text = "Leviatán";
            radioButton6.Text = "Sentinels";
            radioButton7.Text = "Team Heretics";
            radioButton8.Text = "Trace";
            checkBox1.Text = "1º EDward Gaming";
            checkBox2.Text = "2º Team Heretics";
            checkBox3.Text = "3º Leviatán";
            checkBox4.Text = "4º Sentinels";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "TH RieNs", "TH MiniBoo", "EDG ZmjjKK" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Abyss", "Ascent", "Bind", "Haven", "Icebox", "Lotus", "Sunset" });
        }

        private void ConfigurarParaCPar()
        {
            Limpar();
            Tocar("MusicCPar.mp3");
            this.Text = "Valorant Champions Tour | Champions 2025 - Paris";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyChampions;
            pictureBox9.BackgroundImage = Properties.Resources.LogoCPar;
            pictureBox6.BackgroundImage = Properties.Resources.CapaCPar;
            radioButton1.Text = "DRX";
            radioButton2.Text = "FNATIC";
            radioButton3.Text = "G2";
            radioButton4.Text = "GIANTX";
            radioButton5.Text = "MIBR";
            radioButton6.Text = "NRG";
            radioButton7.Text = "Paper Rex";
            radioButton8.Text = "Team Heretics";
            checkBox1.Text = "1º NRG";
            checkBox2.Text = "2º FNATIC";
            checkBox3.Text = "3º DRX";
            checkBox4.Text = "4º Paper Rex";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "DRX Flashback", "FNC kaajak", "DRX HYUNMIN" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Abyss", "Ascent", "Bind", "Corrode", "Haven", "Lotus", "Sunset" });
        }

        private void ConfigurarParaMRey1()
        {
            Limpar();
            Tocar("MusicMRey1.mp3");
            this.Text = "Valorant Champions Tour | 2021.1 - Masters Reykjavík";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMRey1;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMRey;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMRey1;
            radioButton1.Text = "FNATIC";
            radioButton2.Text = "KRÜ";
            radioButton3.Text = "NUTURN";
            radioButton4.Text = "Sentinels";
            radioButton5.Text = "Team Liquid";
            radioButton6.Text = "Team Vikings";
            radioButton7.Text = "Version1";
            radioButton8.Text = "X10 CRIT";
            checkBox1.Text = "1º Sentinels";
            checkBox2.Text = "2º FNATIC";
            checkBox3.Text = "3º NUTURN";
            checkBox4.Text = "4º Team Liquid";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "FNC Derke", "FNC Magnum", "FNC Doma" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Haven", "Icebox", "Split" });
        }

        private void ConfigurarParaMBer()
        {
            Limpar();
            Tocar("MusicMBer.mp3");
            this.Text = "Valorant Champions Tour | Masters 2021.2 - Berlin";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMBer;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMBer;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMBer;
            radioButton1.Text = "100 Thieves";
            radioButton2.Text = "Acend";
            radioButton3.Text = "Gambit";
            radioButton4.Text = "G2";
            radioButton5.Text = "KRÜ";
            radioButton6.Text = "Sentinels";
            radioButton7.Text = "Team Envy";
            radioButton8.Text = "Vision Strikers";
            checkBox1.Text = "1º Gambit";
            checkBox2.Text = "2º Team Envy";
            checkBox3.Text = "3º 100 Thieves";
            checkBox4.Text = "4º G2";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "GMB nAts", "G2 keloqz", "GMB Chronicle" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Haven", "Icebox", "Split" });
        }

        private void ConfigurarParaMRey2()
        {
            Limpar();
            Tocar("MusicMRey2.mp3");
            this.Text = "Valorant Champions Tour | Masters 2022.1 - Reykjavík";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMRey2;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMRey;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMRey2;
            radioButton1.Text = "DRX";
            radioButton2.Text = "G2";
            radioButton3.Text = "LOUD";
            radioButton4.Text = "OpTic Gaming";
            radioButton5.Text = "Paper Rex";
            radioButton6.Text = "Team Liquid";
            radioButton7.Text = "The Guard";
            radioButton8.Text = "ZETA DIVISION";
            checkBox1.Text = "1º OpTic Gaming";
            checkBox2.Text = "2º LOUD";
            checkBox3.Text = "3º ZETA DIVISION";
            checkBox4.Text = "4º Paper Rex";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "OPTC yay", "OPTC Marved", "ZETA SugarZ3ro" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Fracture", "Haven", "Icebox", "Split" });
        }

        private void ConfigurarParaMCop()
        {
            Limpar();
            Tocar("MusicMCop.mp3");
            this.Text = "Valorant Champions Tour | Masters 2022.2 - Copenhagen";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMCop;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMCop;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMCop;
            radioButton1.Text = "DRX";
            radioButton2.Text = "FNATIC";
            radioButton3.Text = "FunPlus Phoenix";
            radioButton4.Text = "Guild";
            radioButton5.Text = "Leviatán";
            radioButton6.Text = "OpTic Gaming";
            radioButton7.Text = "Paper Rex";
            radioButton8.Text = "XSET";
            checkBox1.Text = "1º FunPlus Phoenix";
            checkBox2.Text = "2º Paper Rex";
            checkBox3.Text = "3º OpTic Gaming";
            checkBox4.Text = "4º FNATIC";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "FPX ardiis", "FPX Shao", "FPX Zyppan" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Fracture", "Haven", "Icebox", "Split" });
        }

        private void ConfigurarParaMSao()
        {
            Limpar();
            Tocar("MusicMSao.mp3");
            this.Text = "Valorant Champions Tour | LOCK//IN (Masters) 2023.0 - São Paulo";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMSao;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMSao;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMSao;
            radioButton1.Text = "100 Thieves";
            radioButton2.Text = "DRX";
            radioButton3.Text = "FNATIC";
            radioButton4.Text = "Leviatán";
            radioButton5.Text = "LOUD";
            radioButton6.Text = "Natus Vincere";
            radioButton7.Text = "NRG";
            radioButton8.Text = "TALON";
            checkBox1.Text = "1º FNATIC";
            checkBox2.Text = "2º LOUD";
            checkBox3.Text = "3º DRX";
            checkBox4.Text = "4º Natus Vincere";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "LOUD Less", "LOUD aspas", "LOUD cauanzin" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Fracture", "Haven", "Icebox", "Lotus", "Pearl", "Split" });
        }

        private void ConfigurarParaMTok()
        {
            Limpar();
            Tocar("MusicMTok.mp3");
            this.Text = "Valorant Champions Tour | Masters 2023.1 - Tokyo";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMTok;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMTok;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMTok;
            radioButton1.Text = "DRX";
            radioButton2.Text = "EDward Gaming";
            radioButton3.Text = "Evil Geniuses";
            radioButton4.Text = "FNATIC";
            radioButton5.Text = "LOUD";
            radioButton6.Text = "NRG";
            radioButton7.Text = "Paper Rex";
            radioButton8.Text = "Team Liquid";
            checkBox1.Text = "1º FNATIC";
            checkBox2.Text = "2º Evil Geniuses";
            checkBox3.Text = "3º Paper Rex";
            checkBox4.Text = "4º NRG";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "EDG ZmjjKK", "EG Demon1", "EG Boostio" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Fracture", "Haven", "Lotus", "Pearl", "Split" });
        }

        private void ConfigurarParaMMad()
        {
            Limpar();
            Tocar("MusicMMad.mp3");
            this.Text = "Valorant Champions Tour | Masters 2024.1 - Madrid";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMMad;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMMad;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMMad;
            radioButton1.Text = "EDward Gaming";
            radioButton2.Text = "FunPlus Phoenix";
            radioButton3.Text = "Gen.G";
            radioButton4.Text = "Karmine Corp";
            radioButton5.Text = "LOUD";
            radioButton6.Text = "Paper Rex";
            radioButton7.Text = "Sentinels";
            radioButton8.Text = "Team Heretics";
            checkBox1.Text = "1º Sentinels";
            checkBox2.Text = "2º Gen.g";
            checkBox3.Text = "3º Paper Rex";
            checkBox4.Text = "4º LOUD";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "SEN zekken", "SEN TenZ", "SEN johnqt" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Icebox", "Lotus", "Split", "Sunset" });
        }

        private void ConfigurarParaMSha()
        {
            Limpar();
            Tocar("MusicMSha.mp3");
            this.Text = "Valorant Champions Tour | Masters 2024.2 - Shangai";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMSha;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMSha;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMSha;
            radioButton1.Text = "100 Thieves";
            radioButton2.Text = "EDward Gaming";
            radioButton3.Text = "FNATIC";
            radioButton4.Text = "FUT";
            radioButton5.Text = "Gen.G";
            radioButton6.Text = "G2";
            radioButton7.Text = "Paper Rex";
            radioButton8.Text = "Team Heretics";
            checkBox1.Text = "1º Gen.G";
            checkBox2.Text = "2º Team Heretics";
            checkBox3.Text = "3º G2";
            checkBox4.Text = "4º 100 Thieves";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "TH Wo0t", "TH RieNs", "TH benjyfishy" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Icebox", "Lotus", "Split", "Sunset" });
        }

        private void ConfigurarParaMBan()
        {
            Limpar();
            Tocar("MusicMBan.mp3");
            this.Text = "Valorant Champions Tour | Masters 2025.1 - Bangkok";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMBan;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMBan;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMBan;
            radioButton1.Text = "DRX";
            radioButton2.Text = "EDward Gaming";
            radioButton3.Text = "G2";
            radioButton4.Text = "Sentinels";
            radioButton5.Text = "T1";
            radioButton6.Text = "Team Liquid";
            radioButton7.Text = "Team Vitality";
            radioButton8.Text = "Trace";
            checkBox1.Text = "1º T1";
            checkBox2.Text = "2º G2";
            checkBox3.Text = "3º EDward Gaming";
            checkBox4.Text = "4º Team Vitality";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "TH Wo0t", "TH RieNs", "TH benjyfishy" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Bind", "Breeze", "Icebox", "Lotus", "Split", "Sunset" });
        }

        private void ConfigurarParaMTor()
        {
            Limpar();
            Tocar("MusicMTor.mp3");
            this.Text = "Valorant Champions Tour | Masters 2025.2 - Toronto";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMTor;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMTor;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMTor;
            radioButton1.Text = "FNATIC";
            radioButton2.Text = "G2";
            radioButton3.Text = "Gen.G";
            radioButton4.Text = "Paper Rex";
            radioButton5.Text = "Rex Regum Qeon";
            radioButton6.Text = "Sentinels";
            radioButton7.Text = "Wolves";
            radioButton8.Text = "Xi Lai Gaming";
            checkBox1.Text = "1º Paper Rex";
            checkBox2.Text = "2º FNATIC";
            checkBox3.Text = "3º Wolves";
            checkBox4.Text = "4º G2";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "FNC Alfajer", "FNC kaajak", "PRX Jinggg" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Haven", "Icebox", "Lotus", "Pearl", "Split", "Sunset" });
        }

        private void ConfigurarParaMSan()
        {
            Limpar();
            Tocar("MusicMSan.mp3");
            this.Text = "Valorant Champions Tour | Masters 2026.1 - Santiago";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMSan;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMSan;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMSan;
            radioButton1.Text = "All Gamers";
            radioButton2.Text = "BBL";
            radioButton3.Text = "FURIA";
            radioButton4.Text = "G2";
            radioButton5.Text = "Gentle Mates";
            radioButton6.Text = "Nongshim RedForce";
            radioButton7.Text = "NRG";
            radioButton8.Text = "Paper Rex";
            checkBox1.Text = "1º Nongshim RedForce";
            checkBox2.Text = "2º Paper Rex";
            checkBox3.Text = "3º NRG";
            checkBox4.Text = "4º G2";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "PRX d4v41", "PRX Jinggg", "PRX f0rsakeN" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Abyss", "Bind", "Breeze", "Corrode", "Haven", "Pearl", "Split" });
        }

        private void ConfigurarParaMLon()
        {
            Limpar();
            Tocar("MusicMLon.mp3");
            this.Text = "Valorant Champions Tour | Masters 2026.2 - London";
            pictureBox8.BackgroundImage = Properties.Resources.TrophyMLon;
            pictureBox9.BackgroundImage = Properties.Resources.LogoMLon1;
            pictureBox6.BackgroundImage = Properties.Resources.CapaMLon;
            radioButton1.Text = "EDward Gaming";
            radioButton2.Text = "FUT";
            radioButton3.Text = "G2";
            radioButton4.Text = "Leviatán";
            radioButton5.Text = "Paper Rex";
            radioButton6.Text = "Team Heretics";
            radioButton7.Text = "Team Vitality";
            radioButton8.Text = "Xi Lai Gaming";
            checkBox1.Text = "1º Leviatán";
            checkBox2.Text = "2º Paper Rex";
            checkBox3.Text = "3º EDward Gaming";
            checkBox4.Text = "4º Team Vitality";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "LEV spike", "LEV Neon", "LEV Sato" });
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Ascent", "Breeze", "Fracture", "Haven", "Lotus", "Pearl", "Split" });
        }

        private void ExibirTodosComponentes(bool visivel)
        {
            label1.Visible = visivel;
            label2.Visible = visivel;
            label3.Visible = visivel;
            label4.Visible = visivel;
            label5.Visible = visivel;
            label6.Visible = visivel;
            label7.Visible = visivel;
            label8.Visible = visivel;
            label9.Visible = visivel;
            groupBox1.Visible = visivel;
            radioButton1.Visible = visivel;
            radioButton2.Visible = visivel;
            radioButton3.Visible = visivel;
            radioButton4.Visible = visivel;
            radioButton5.Visible = visivel;
            radioButton6.Visible = visivel;
            radioButton7.Visible = visivel;
            radioButton8.Visible = visivel;
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
            checkBox1.Visible = visivel;
            checkBox2.Visible = visivel;
            checkBox3.Visible = visivel;
            checkBox4.Visible = visivel;
            comboBox2.Visible = visivel;
            comboBox3.Visible = visivel;
        }
        private void Limpar()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
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
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                if (rb.Text.Contains("100 Thieves"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources._100Thieves;
                }
                else if (rb.Text.Contains("Acend"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Acend;
                }
                else if (rb.Text.Contains("All Gamers"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.AllGamers;
                }
                else if (rb.Text.Contains("BBL"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.BBL;
                }
                else if (rb.Text.Contains("Bilibili Gaming"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.BilibiliGaming;
                }
                else if (rb.Text.Contains("Cloud9"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Cloud9;
                }
                else if (rb.Text.Contains("DRX"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.DRX;
                }
                else if (rb.Text.Contains("EDward Gaming"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.EDwardGaming;
                }
                else if (rb.Text.Contains("Evil Geniuses"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.EvilGeniuses;
                }
                else if (rb.Text.Contains("FNATIC"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.FNATIC;
                }
                else if (rb.Text.Contains("FunPlus Phoenix"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.FunPlusPhoenix;
                }
                else if (rb.Text.Contains("FURIA"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.FURIA;
                }
                else if (rb.Text.Contains("FUT"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.FUT;
                }
                else if (rb.Text.Contains("G2"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.G2;
                }
                else if (rb.Text.Contains("Gambit"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Gambit;
                }
                else if (rb.Text.Contains("Gen.G"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.GenG;
                }
                else if (rb.Text.Contains("Gentle Mates"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.GentleMates;
                }
                else if (rb.Text.Contains("GIANTX"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.GIANTX;
                }
                else if (rb.Text.Contains("Guild"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Guild;
                }
                else if (rb.Text.Contains("Karmine Corp"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.KarmineCorp;
                }
                else if (rb.Text.Contains("KRÜ"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.KRU;
                }
                else if (rb.Text.Contains("Leviatán"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Leviatan;
                }
                else if (rb.Text.Contains("LOUD"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.LOUD250;
                }
                else if (rb.Text.Contains("MIBR"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.MIBR;
                }
                else if (rb.Text.Contains("Natus Vincere"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.NatusVicere;
                }
                else if (rb.Text.Contains("Nongshim RedForce"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.NongshimRedForce;
                }
                else if (rb.Text.Contains("NRG"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.NRG;
                }
                else if (rb.Text.Contains("NUTURN"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.NUTURN;
                }
                else if (rb.Text.Contains("OpTic Gaming"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.OpTicGaming250;
                }
                else if (rb.Text.Contains("Paper Rex"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.PaperRex;
                }
                else if (rb.Text.Contains("Rex Regum Qeon"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.RexRegumQeon;
                }
                else if (rb.Text.Contains("Sentinels"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Sentinels1;
                }
                else if (rb.Text.Contains("T1"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.T1;
                }
                else if (rb.Text.Contains("TALON"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.TALON;
                }
                else if (rb.Text.Contains("Team Envy"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.TeamEnvy;
                }
                else if (rb.Text.Contains("Team Heretics"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.TeamHeretics;
                }
                else if (rb.Text.Contains("Team Liquid"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.TeamLiquid;
                }
                else if (rb.Text.Contains("Team Secret"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.TeamSecret;
                }
                else if (rb.Text.Contains("Team Vikings"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.TeamVikings;
                }
                else if (rb.Text.Contains("Team Vitality"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.TeamVitality;
                }
                else if (rb.Text.Contains("The Guard"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.TheGuard;
                }
                else if (rb.Text.Contains("Trace"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Trace;
                }
                else if (rb.Text.Contains("Version1"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Version1;
                }
                else if (rb.Text.Contains("Vision Strikers"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.VisionStrikers;
                }
                else if (rb.Text.Contains("Wolves"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.Wolves;
                }
                else if (rb.Text.Contains("X10 CRIT"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.X10CRIT;
                }
                else if (rb.Text.Contains("Xi Lai Gaming"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.XiLaiGaming;
                }
                else if (rb.Text.Contains("XSET"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.XSET;
                }
                else if (rb.Text.Contains("ZETA DIVISION"))
                {
                    pictureBox10.BackgroundImage = Properties.Resources.ZETADIVISION;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string Players = comboBox2.SelectedItem.ToString();

                switch (Players)
                {
                    case "DRX Flashback":
                        pictureBox11.BackgroundImage = Properties.Resources.DRXFlashbackCPar;
                        break;
                    case "DRX HYUNMIN":
                        pictureBox11.BackgroundImage = Properties.Resources.DRXHYUNMINCPar;
                        break;
                    case "EDG ZmjjKK":
                        if (this.Text == "Valorant Champions Tour | Champions 2024 - Seoul")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.EDGZmjjKKCSeo;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.EDGZmjjKKMTok;
                        }
                        break;
                    case "EG Boostio":
                        pictureBox11.BackgroundImage = Properties.Resources.EGBoostioMTok;
                        break;
                    case "EG Demon1":
                        if (this.Text == "Valorant Champions Tour | Champions 2023 - Los Angeles")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.EGDemon1CLos;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.EGDemon1MTok;
                        }
                        break;
                    case "FNC Alfajer":
                        pictureBox11.BackgroundImage = Properties.Resources.FNCAlfajerMTor;
                        break;
                    case "FNC Derke":
                        pictureBox11.BackgroundImage = Properties.Resources.FNCDerkeMRey1;
                        break;
                    case "FNC Doma":
                        pictureBox11.BackgroundImage = Properties.Resources.FNCDomaMRey1;
                        break;
                    case "FNC kaajak":
                        if (this.Text == "Valorant Champions Tour | Champions 2025 - Paris")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.FNCkaajakCPar;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.FNCkaajakMTor;
                        }
                        break;
                    case "FNC Magnum":
                        pictureBox11.BackgroundImage = Properties.Resources.FNCMagnumMRey1;
                        break;
                    case "FPX ardiis":
                        pictureBox11.BackgroundImage = Properties.Resources.FPXardiisMCop;
                        break;
                    case "FPX Shao":
                        pictureBox11.BackgroundImage = Properties.Resources.FPXShaoMCop;
                        break;
                    case "FPX Zyppan":
                        pictureBox11.BackgroundImage = Properties.Resources.FPXZyppanMCop;
                        break;
                    case "G2 keloqz":
                        pictureBox11.BackgroundImage = Properties.Resources.G2keloqzMBer;
                        break;
                    case "GMB Chronicle":
                        if (this.Text == "Valorant Champions Tour | Champions 2021 - Berlin")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.GMBChronicleCBer;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.GMBChronicleMBer;
                        }
                        break;
                    case "GMB d3ffo":
                        pictureBox11.BackgroundImage = Properties.Resources.GMBd3ffoCBer;
                        break;
                    case "GMB nAts":
                        pictureBox11.BackgroundImage = Properties.Resources.GMBnAtsMBer;
                        break;
                    case "KRÜ Keznit":
                        pictureBox11.BackgroundImage = Properties.Resources.KRUKeznitCBer;
                        break;
                    case "LEV Neon":
                        pictureBox11.BackgroundImage = Properties.Resources.LEVNeonMLon;
                        break;
                    case "LEV Sato":
                        pictureBox11.BackgroundImage = Properties.Resources.LEVSatoMLon;
                        break;
                    case "LEV spike":
                        pictureBox11.BackgroundImage = Properties.Resources.LEVspikeMLon;
                        break;
                    case "LOUD aspas":
                        if (this.Text == "Valorant Champions Tour | Champions 2023 - Los Angeles")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.LOUDaspasCLos;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.LOUDaspasMSao;
                        }
                        break;
                    case "LOUD cauanzin":
                        pictureBox11.BackgroundImage = Properties.Resources.LOUDcauanzinMSao;
                        break;
                    case "LOUD Less":
                        if (this.Text == "Valorant Champions Tour | Champions 2023 - Los Angeles")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.LOUDLessCLos;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.LOUDLessMSao;
                        }
                        break;
                    case "OPTC crashies":
                        pictureBox11.BackgroundImage = Properties.Resources.OPTCcrashiesCIns;
                        break;
                    case "OPTC Marved":
                        pictureBox11.BackgroundImage = Properties.Resources.OPTCMarvedMRey2;
                        break;
                    case "OPTC Victor":
                        pictureBox11.BackgroundImage = Properties.Resources.OPTCVictorCIns;
                        break;
                    case "OPTC yay":
                        if (this.Text == "Valorant Champions Tour | Champions 2022 - Instanbul")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.OPTCyayCIns;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.OPTCyayMRey2;
                        }
                        break;
                    case "PRX d4v41":
                        pictureBox11.BackgroundImage = Properties.Resources.PRXd4v41MSan;
                        break;
                    case "PRX f0rsakeN":
                        pictureBox11.BackgroundImage = Properties.Resources.PRXf0rsakeNMSan;
                        break;
                    case "PRX Jinggg":
                        if (this.Text == "Valorant Champions Tour | Masters 2025.2 - Toronto")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.PRXJingggMTor;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.PRXJingggMSan;
                        }
                        break;
                    case "SEN johnqt":
                        pictureBox11.BackgroundImage = Properties.Resources.SENjohnqtMMad;
                        break;
                    case "SEN TenZ":
                        pictureBox11.BackgroundImage = Properties.Resources.SENTenZMMad;
                        break;
                    case "SEN zekken":
                        pictureBox11.BackgroundImage = Properties.Resources.SENzekkenMMad;
                        break;
                    case "TH benjyfishy":
                        if (this.Text == "Valorant Champions Tour | Masters 2024.2 - Shangai")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.THbenjyfishyMSha;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.THbenjyfishyMBan;
                        }
                        break;
                    case "TH MiniBoo":
                        pictureBox11.BackgroundImage = Properties.Resources.THMiniBooCSeo;
                        break;
                    case "TH RieNs":
                        if (this.Text == "Valorant Champions Tour | Champions 2024 - Seoul")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.THRieNsCSeo;
                        }
                        else if (this.Text == "Valorant Champions Tour | Masters 2024.2 - Shangai")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.THRieNsMSha;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.THRieNsMBan;
                        }
                        break;
                    case "TH Wo0t":
                        if (this.Text == "Valorant Champions Tour | Masters 2024.2 - Shangai")
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.THWo0tMSha;
                        }
                        else
                        {
                            pictureBox11.BackgroundImage = Properties.Resources.THWo0tMBan;
                        }
                        break;
                    case "ZETA SugarZ3ro":
                        pictureBox11.BackgroundImage = Properties.Resources.ZETASugarZ3roMRey2;
                        break;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                string Mapas = comboBox3.SelectedItem.ToString();

                switch (Mapas)
                {
                    case "Abyss":
                        pictureBox12.BackgroundImage = Properties.Resources.Abyss;
                        break;
                    case "Ascent":
                        pictureBox12.BackgroundImage = Properties.Resources.Ascent;
                        break;
                    case "Bind":
                        pictureBox12.BackgroundImage = Properties.Resources.BindA;
                        break;
                    case "Breeze":
                        pictureBox12.BackgroundImage = Properties.Resources.Breeze;
                        break;
                    case "Corrode":
                        pictureBox12.BackgroundImage = Properties.Resources.Corrode;
                        break;
                    case "Fracture":
                        pictureBox12.BackgroundImage = Properties.Resources.Fracture;
                        break;
                    case "Haven":
                        pictureBox12.BackgroundImage = Properties.Resources.Haven;
                        break;
                    case "Icebox":
                        pictureBox12.BackgroundImage = Properties.Resources.Icebox;
                        break;
                    case "Lotus":
                        pictureBox12.BackgroundImage = Properties.Resources.Lotus;
                        break;
                    case "Pearl":
                        pictureBox12.BackgroundImage = Properties.Resources.Pearl;
                        break;
                    case "Split":
                        pictureBox12.BackgroundImage = Properties.Resources.Split;
                        break;
                    case "Sunset":
                        pictureBox12.BackgroundImage = Properties.Resources.Sunset;
                        break;
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
                    case "1º Acend":
                        pictureBox2.BackgroundImage = Properties.Resources.Acend;
                        break;
                    case "1º LOUD":
                        pictureBox2.BackgroundImage = Properties.Resources.LOUD250;
                        break;
                    case "1º Evil Geniuses":
                        pictureBox2.BackgroundImage = Properties.Resources.EvilGeniuses;
                        break;
                    case "1º EDward Gaming":
                        pictureBox2.BackgroundImage = Properties.Resources.EDwardGaming;
                        break;
                    case "1º NRG":
                        pictureBox2.BackgroundImage = Properties.Resources.NRG;
                        break;
                    case "1º Sentinels":
                        pictureBox2.BackgroundImage = Properties.Resources.Sentinels1;
                        break;
                    case "1º Gambit":
                        pictureBox2.BackgroundImage = Properties.Resources.Gambit;
                        break;
                    case "1º OpTic Gaming":
                        pictureBox2.BackgroundImage = Properties.Resources.OpTicGaming250;
                        break;
                    case "1º FunPlus Phoenix":
                        pictureBox2.BackgroundImage = Properties.Resources.FunPlusPhoenix;
                        break;
                    case "1º FNATIC":
                        pictureBox2.BackgroundImage = Properties.Resources.FNATIC;
                        break;
                    case "1º Gen.G":
                        pictureBox2.BackgroundImage = Properties.Resources.GenG;
                        break;
                    case "1º T1":
                        pictureBox2.BackgroundImage = Properties.Resources.T1;
                        break;
                    case "1º Paper Rex":
                        pictureBox2.BackgroundImage = Properties.Resources.PaperRex;
                        break;
                    case "1º Nongshim RedForce":
                        pictureBox2.BackgroundImage = Properties.Resources.NongshimRedForce;
                        break;
                    case "1º Leviatán":
                        pictureBox2.BackgroundImage = Properties.Resources.Leviatan;
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
            if (checkBox2.Checked)
            {
                string Podio = checkBox2.Text;

                switch (Podio)
                {
                    case "2º Gambit":
                        pictureBox3.BackgroundImage = Properties.Resources.Gambit;
                        break;
                    case "2º OpTic Gaming":
                        pictureBox3.BackgroundImage = Properties.Resources.OpTicGaming250;
                        break;
                    case "2º Paper Rex":
                        pictureBox3.BackgroundImage = Properties.Resources.PaperRex;
                        break;
                    case "2º Team Heretics":
                        pictureBox3.BackgroundImage = Properties.Resources.TeamHeretics;
                        break;
                    case "2º FNATIC":
                        pictureBox3.BackgroundImage = Properties.Resources.FNATIC;
                        break;
                    case "2º Team Envy":
                        pictureBox3.BackgroundImage = Properties.Resources.TeamEnvy;
                        break;
                    case "2º LOUD":
                        pictureBox3.BackgroundImage = Properties.Resources.LOUD250;
                        break;
                    case "2º Evil Geniuses":
                        pictureBox3.BackgroundImage = Properties.Resources.EvilGeniuses;
                        break;
                    case "2º Gen.g":
                        pictureBox3.BackgroundImage = Properties.Resources.GenG;
                        break;
                    case "2º G2":
                        pictureBox3.BackgroundImage = Properties.Resources.G2;
                        break;
                }
            }
            else
            {
                pictureBox3.BackgroundImage = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                string Podio = checkBox3.Text;
                switch (Podio)
                {
                    case "3º KRÜ":
                        pictureBox4.BackgroundImage = Properties.Resources.KRU;
                        break;
                    case "3º DRX":
                        pictureBox4.BackgroundImage = Properties.Resources.DRX;
                        break;
                    case "3º LOUD":
                        pictureBox4.BackgroundImage = Properties.Resources.LOUD250;
                        break;
                    case "3º Leviatán":
                        pictureBox4.BackgroundImage = Properties.Resources.Leviatan;
                        break;
                    case "3º NUTURN":
                        pictureBox4.BackgroundImage = Properties.Resources.NUTURN;
                        break;
                    case "3º 100 Thieves":
                        pictureBox4.BackgroundImage = Properties.Resources._100Thieves;
                        break;
                    case "3º ZETA DIVISION":
                        pictureBox4.BackgroundImage = Properties.Resources.ZETADIVISION;
                        break;
                    case "3º OpTic Gaming":
                        pictureBox4.BackgroundImage = Properties.Resources.OpTicGaming250;
                        break;
                    case "3º Paper Rex":
                        pictureBox4.BackgroundImage = Properties.Resources.PaperRex;
                        break;
                    case "3º G2":
                        pictureBox4.BackgroundImage = Properties.Resources.G2;
                        break;
                    case "3º Wolves":
                        pictureBox4.BackgroundImage = Properties.Resources.Wolves;
                        break;
                    case "3º NRG":
                        pictureBox4.BackgroundImage = Properties.Resources.NRG;
                        break;
                }
            }
            else
            {
                pictureBox4.BackgroundImage = null;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                string Podio = checkBox4.Text;
                switch (Podio)
                {
                    case "4º Team Liquid":
                        pictureBox5.BackgroundImage = Properties.Resources.TeamLiquid;
                        break;
                    case "4º FunPlus Phoenix":
                        pictureBox5.BackgroundImage = Properties.Resources.FunPlusPhoenix;
                        break;
                    case "4º FNATIC":
                        pictureBox5.BackgroundImage = Properties.Resources.FNATIC;
                        break;
                    case "4º Sentinels":
                        pictureBox5.BackgroundImage = Properties.Resources.Sentinels1;
                        break;
                    case "4º Paper Rex":
                        pictureBox5.BackgroundImage = Properties.Resources.PaperRex;
                        break;
                    case "4º G2":
                        pictureBox5.BackgroundImage = Properties.Resources.G2;
                        break;
                    case "4º Natus Vincere":
                        pictureBox5.BackgroundImage = Properties.Resources.NatusVicere;
                        break;
                    case "4º NRG":
                        pictureBox5.BackgroundImage = Properties.Resources.NRG;
                        break;
                    case "4º LOUD":
                        pictureBox5.BackgroundImage = Properties.Resources.LOUD250;
                        break;
                    case "4º 100 Thieves":
                        pictureBox5.BackgroundImage = Properties.Resources._100Thieves;
                        break;
                    case "4º Team Vitality":
                        pictureBox5.BackgroundImage = Properties.Resources.TeamVitality;
                        break;
                }
            }
            else
            {
                pictureBox5.BackgroundImage = null;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void VCT_Shown(object sender, EventArgs e)
        {

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
