using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);
        bool conectado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Application.Exit();
                return;
            }
            if (txtIP.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço IP");
                txtIP.Focus();
                return;
            }
            try
            {
                // analisa end ip do servidor informado no textbox
                IPAddress enderecoIP = IPAddress.Parse(txtIP.Text);
                int portaHost = int.Parse(txtPORT.Text);

                //cria uma nova instancia do objeto chatServidor
                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                //vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                //inicia atendimento
                mainServidor.IniciaAtendimento();

                //mostra que nos iniciamos o antendimento para conexões
                
                listaLog.Items.Add("Servidor ativo, aguardando usuários conectarem-se...");
                listaLog.SetSelected(listaLog.Items.Count - 1, true);
                
            }
            catch (Exception ex)
            {
                listaLog.Items.Add("Erro de conexao: " + ex.Message);
                listaLog.SetSelected(listaLog.Items.Count - 1, true);
                
                return;
            }
            conectado = true;
            txtIP.Enabled = false;
            txtPORT.Enabled = false;
            btnStartServer.ForeColor = Color.Red;
            btnStartServer.Text = "Sair";
        }
        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            //chama metodo que atualiza formulario
            //invoke para trabalhar com threads diferentes
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }
        private void AtualizaStatus(string strMensagem)
        {
            //atualiza o logo com mensagem
            listaLog.Items.Add(strMensagem);
            listaLog.SetSelected(listaLog.Items.Count - 1, true);
        }
    }
}
