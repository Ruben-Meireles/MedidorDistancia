
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace MedidorDistancia
{
    public partial class Form1 : Form
    {
        SerialPort porta;

        public Form1()
        {
            InitializeComponent();

            // Associar eventos
            btnLigar.Click += btnLigar_Click;
            btnDesligar.Click += btnDesligar_Click;
            btnAtualizar.Click += btnAtualizar_Click;

            // Configuracoes iniciais
            txtDistancia.ReadOnly = true;
            btnDesligar.Enabled = false;

            AtualizarPortas();
        }

        // Atualizar portas COM
        private void AtualizarPortas()
        {
            cmbPorta.Items.Clear();

            string[] portas = SerialPort.GetPortNames();

            Array.Sort(portas);

            cmbPorta.Items.AddRange(portas);

            if (cmbPorta.Items.Count > 0)
                cmbPorta.SelectedIndex = 0;
        }

        // Botao atualizar
        private void btnAtualizar_Click(
            object sender, EventArgs e)
        {
            AtualizarPortas();

            MessageBox.Show("Portas atualizadas!");
        }

        // Botao ligar
        private void btnLigar_Click(
            object sender, EventArgs e)
        {
            try
            {
                if (cmbPorta.SelectedItem == null)
                {
                    MessageBox.Show("Seleciona uma porta COM!");
                    return;
                }

                porta = new SerialPort(
                    cmbPorta.SelectedItem.ToString(),
                    9600
                );

                porta.NewLine = "\n";

                porta.DataReceived += Porta_DataReceived;

                porta.Open();

                btnLigar.Enabled = false;
                btnDesligar.Enabled = true;
                cmbPorta.Enabled = false;

                lblEstado.Text = "Ligado";
                lblEstado.ForeColor =
                    System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro na ligacao: " + ex.Message
                );
            }
        }

        // Receber dados do Arduino
        private void Porta_DataReceived(
            object sender,
            SerialDataReceivedEventArgs e)
        {
            try
            {
                string dados = porta.ReadLine().Trim();

                BeginInvoke(new Action(() =>
                {
                    if (dados == "ERRO")
                    {
                        txtDistancia.Text = "Sem deteccao";
                    }
                    else
                    {
                        txtDistancia.Text = dados + " cm";
                    }
                }));
            }
            catch
            {
                // Ignorar erros de comunicacao
            }
        }

        // Botao desligar
        private void btnDesligar_Click(
            object sender, EventArgs e)
        {
            FecharLigacao();
        }

        // Fechar comunicacao
        private void FecharLigacao()
        {
            if (porta != null)
            {
                porta.DataReceived -= Porta_DataReceived;

                if (porta.IsOpen)
                    porta.Close();

                porta.Dispose();
                porta = null;
            }

            btnLigar.Enabled = true;
            btnDesligar.Enabled = false;
            cmbPorta.Enabled = true;

            lblEstado.Text = "Desligado";
            lblEstado.ForeColor =
                System.Drawing.Color.Red;

            txtDistancia.Text = "---";
        }

        // Fechar aplicacao
        protected override void OnFormClosing(
            FormClosingEventArgs e)
        {
            FecharLigacao();

            base.OnFormClosing(e);
        }
    }
}

