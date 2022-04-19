using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    // esse delegate é necessario para especificar os parametros que estamos passando com o nosso evento
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
    class Servidor
    {
        // armazena usuarios (accessado/consultado por user)
        public static Hashtable htUsuarios = new Hashtable(30);//30 usuarios é o limite definido
        // armazena conexões (accessado/consultado por user)
        public static Hashtable htConexoes = new Hashtable(30);//30 usuarios é o limite definido
        //armazena o end ip passado
        private IPAddress enderecoIP;
        private int portaHost;
        private TcpClient tcpCliente;

        // O evento e o seu argumento irá notificar o formulário quando um usuario se conecta, desconecta
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;

        //o construtor define o end ip pra retorna pela instancia do obj
        public Servidor(IPAddress endereco, int porta)
        {
            this.enderecoIP = endereco;
            this.portaHost = porta;
        }
        //a thread ira tratar o escutador de conexões
        private Thread thrListener;
        //obj tcp que escuta as conexoes
        private TcpListener tlsCliente;
        // ira dizer ao laço while para manter a monitoração das conexoes
        bool ServRodando = false;
        public static void IncluirUsuarios(TcpClient tcpUsuario, string strUserName)
        {
            //primeiro inclui o nome e conexão associada para ambas as hash tables
            Servidor.htUsuarios.Add(strUserName, tcpUsuario);
            Servidor.htConexoes.Add(tcpUsuario, strUserName);

            //informa a nova conexão para todos os usuários e para o formulário do servidor
            EnviaMensagemAdmin(htConexoes[tcpUsuario] + " entrou...");
        }
        public static void RemoverUsuario(TcpClient tcpUsuario)
        {
            //se usuario existir
            if (htConexoes[tcpUsuario] != null)
            {
                //primeiro mostra a informação e informa os outros usuarios sobre a conexao
                EnviaMensagemAdmin(htConexoes[tcpUsuario] + " saiu...");
                //removerUsiario da hash table
                Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
                Servidor.htConexoes.Remove(tcpUsuario);
            }
        }
        //esse evento é chamado quando queremos idsparar o evento StatusChanged
        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;

            //verificar se é null
            if (statusHandler != null)
            {
                //invoca o delegate
                statusHandler(null, e);
            }
        }
        public static void EnviaMensagemAdmin(string Mensagem)
        {
            StreamWriter swSenderSender;
            //exibe primeiro na aplicação
            e = new StatusChangedEventArgs("Administrador: " + Mensagem);
            OnStatusChanged(e);

            //cria array de clientes tcp do tamanho do numero de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            // copia os bj tcpclinte no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            //percorre a lista de clientes tcp
            for (int i = 0; i < tcpClientes.Length; i++)
            {
                // tenta enviar uma mensagem para cada cliente
                try
                {
                    //se a mensagem estiver em braco ou nula sai
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }
                    //envia mensagem para o usuario atual no laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine("Administrador: " + Mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch
                {
                    //se houve algum problema o user n existe então remove]
                    RemoverUsuario(tcpClientes[i]);
                }
            }
        }
        //envia mensagens de um usuario para todos os outros
        public static void EnviaMensagem(string Origem, string Mensagem)
        {
            StreamWriter swSenderSender;

            //primeiro exibe a mensagem na aplicação 
            e = new StatusChangedEventArgs(Origem + " disse: " + Mensagem);
            OnStatusChanged(e);

            //cria um array de cliente TCP do tamanho do numero de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            //copia os objetos TcpClient no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            //percorre a lista de clientes tcp
            for (int i = 0; i < tcpClientes.Length; i++)
            {
                try
                {
                    //se a mensagem estiver em branco ou a conexão for nula sai...
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }
                    //envia a mensagem para o usuario atual no laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine(Origem + "disse: " + Mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch
                {
                    //se houver problema remove usuario (n existe)
                    RemoverUsuario(tcpClientes[i]);
                }
            }
        }

        public void IniciaAtendimento()
        {
            try
            {
                //pegar ip
                IPAddress ipalocal = enderecoIP;
                int portalocal = portaHost;

                //cria um objeto tcp listener usando o ip do servidor e porta definidas
                tlsCliente = new TcpListener(ipalocal, portalocal);

                //inicia o tcp listener e escuta as conexoes
                tlsCliente.Start();

                //o  laço while verifica se o servidor está rodando antes de checar as conexoes
                ServRodando = true;

                //inicia uma nova thread que hospeda o listener
                thrListener = new Thread(MantemAtendimento);
                thrListener.IsBackground = true;
                thrListener.Start();
            }
            catch (Exception ex)
            {

            }
        }
        private void MantemAtendimento()
        {
            //enquanto estiver rodadndo
            while (ServRodando)
            {
                //aceita conexao pendente
                tcpCliente = tlsCliente.AcceptTcpClient();
                //cria uma nova instancia da conexão

                //----------- A FAZER -------------//
            }
        }
    }
}
