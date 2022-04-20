using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        //Tratar o nome do usuario
        private string nomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        //necessario para atualizar o formulário com mensagens da outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        //necessario para definir o formulário para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool Conectado;

        public Form1()
        {
            //na saida da aplicacao : desconectar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //verifica se n ta conectado aguarda conexao
            if (!Conectado)
            {
                InicializaConexao();
            }
            else
            {
                FecharConexao("Desconectado a pedido do Usuário.");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviaMensagem();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se pressionou enter
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }
        private void InicializaConexao()
        {
            try
            {
                //trata o endereço ip informado em um objeto IPAdress
                enderecoIP = IPAddress.Parse(txtIP.Text);
                portaHost = int.Parse(txtPORT.Text);
                tcpServidor.Connect(enderecoIP, portaHost);

                //ajuda a verificar se estamos conectados ou n
                Conectado = true;
                //preparar formulario
                nomeUsuario = txtUsuario.Text;
                //desabilita e habilita o campo apropriado
                txtIP.Enabled = false;
                txtPORT.Enabled = false;
                txtUsuario.Enabled = false;
                txtMensagem.Enabled = true;
                btnConectar.ForeColor = Color.Red;
                btnConectar.Text = "Desconectar";
            }
            catch (Exception ex)
            {
                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Erro na conexão com o servidor: \n" + ex.Message;
                }));
            }
        }
        private void ReceberMensagem()
        {

        }
        private void AtualizaLog(string strMensagem)
        {

        }
        private void EnviaMensagem()
        {

        }
        private void FecharConexao(string Motivo)
        {

        }
        private void OnApplicationExit(object sender, EventArgs e)
        {
            //executa ao sair do app
        }
    }
}
