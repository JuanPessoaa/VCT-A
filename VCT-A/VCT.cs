using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCT_A
{
    public partial class VCT : Form
    {
        public VCT()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1920, 1080);
        }

        private void VCT_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string selecao = listBox1.SelectedItem.ToString();

            comboBox1.Items.Clear(); // Limpa itens anteriores

            if (selecao == "Champions")
            {
                comboBox1.Items.Add("2021 - Berlin");
                comboBox1.Items.Add("2022 - Instanbul");
                comboBox1.Items.Add("2023 - Los Angeles");
                comboBox1.Items.Add("2024 - Seoul");
                comboBox1.Items.Add("2025 - Paris");
                comboBox1.BackColor = Color.FromArgb(197, 177, 116);
                comboBox1.Text = "";
                comboBox1.Visible = true;
                ExibirTodosComponentes(false);
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
                comboBox1.Text = "";
                comboBox1.Visible = true;
                ExibirTodosComponentes(false);
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
            

            // Mostra os demais componentes do form
            ExibirTodosComponentes(true);

            // Preenche os textos de acordo com a cidade selecionada
            switch (Campeonato)
            {
                case "2021 - Berlin":
                    ConfigurarParaCBer();
                    break;/*
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
            comboBox2.Items.AddRange(new object[] { "GMB Chronicle", "GMB d3ffo", "KRÜ Keznit" });
           
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "GMB Chronicle", "GMB d3ffo", "KRÜ Keznit" });

        }

        private void ConfigurarParaLosAngeles()
        {
            radioButton1.Text = "LA - Opção 1";
            radioButton2.Text = "LA - Opção 2";
            // ... Mude os outros RadioButtons aqui da mesma forma

            checkBox1.Text = "LA Check 1";
            // ... Mude os outros CheckBoxes aqui

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "Grupo A (LA)", "Grupo B (LA)" });
        }

        private void ConfigurarParaTokyo()
        {
            radioButton1.Text = "Tokyo - Opção 1";
            // ... configure para Tokyo
        }

        private void ConfigurarParaMadrid()
        {
            radioButton1.Text = "Madrid - Opção 1";
            // ... configure para Madrid
        }

       

        // =======================================================
        // MÉTODO AUXILIAR PARA MOSTRAR/ESCONDER COMPONENTES
        // =======================================================
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
    


private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // Só executa se o RadioButton foi MARCADO (Checked == true)
            if (rb != null && rb.Checked)
            {
                // Exemplo: Altera imagem dependendo do texto ou nome do RadioButton
                if (rb.Text.Contains("Seoul"))
                {
                    // pictureBox1.Image = Properties.Resources.imagem_seoul;
                }
                else if (rb.Text.Contains("LA"))
                {
                    // pictureBox1.Image = Properties.Resources.imagem_la;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Só lê o item SE algo foi de fato selecionado
            if (comboBox2.SelectedItem != null)
            {
                string Players = comboBox2.SelectedItem.ToString();
                // Faça o que precisar com a variável 'Players' aqui
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                string Mapas = comboBox3.SelectedItem.ToString();
                // Faça o que precisar com a variável 'Mapas' aqui
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

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
