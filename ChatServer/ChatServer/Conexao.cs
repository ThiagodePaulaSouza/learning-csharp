using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    //Esta classe trata as conexões, serão tantas quanto as instâncias do usuários conectados
    class Conexao
    {
        TcpClient tcpCliente;

        //thread que ira enviar a informação para o cliente
        private Thread thrSender;
        private StreamReader srReceptor;
        private StreamWriter swEnviador;
        private string usuarioAtual;
        private string strResposta;

        public Conexao(TcpClient tcpCon)
        {
            this.tcpCliente = tcpCon;
            //a thread que aceita o cliente e espera a mensagem
            thrSender = new Thread(AceitaCliente);
            //para que a thread morra quando finalizado a gente deixa ela em backgroud
            thrSender.IsBackground = true;
            //a thread chama o metodo AceitaCliente()
            thrSender.Start();
        }

        private void FecharConexao()
        {
            //fecha os obj abertos
            tcpCliente.Close();
            srReceptor.Close();
            swEnviador.Close();
        }

        //ocorre quando um novo cliente é aceito
        private void AceitaCliente()
        {
            srReceptor = new StreamReader(tcpCliente.GetStream());
            swEnviador = new StreamWriter(tcpCliente.GetStream());

            // le a info da conta do cliente
            usuarioAtual = srReceptor.ReadLine();

            //temos uma resposta do cliente
            if (usuarioAtual != "")
            {
                // armazena o nome do usuario na hashtable
                if (Servidor.htUsuarios.Contains(usuarioAtual))
                {
                    // 1 => significa usuario n conectado
                    swEnviador.WriteLine("0|Este nome de usuário já existe."); //tratar no cliente
                    swEnviador.Flush(); //libera recursos
                    FecharConexao();
                    return;
                }
                else if (usuarioAtual == "Administrador")
                {
                    // 1 => n conectado
                    swEnviador.WriteLine("0|Este nome de usuário é reservado.");
                    swEnviador.Flush(); //libera recursos
                    FecharConexao();
                    return;
                }
                else
                {
                    // 1 => conectou com sucesso!
                    swEnviador.WriteLine("1");
                    swEnviador.Flush(); //libera recursos

                    //inclui o user na hashtable e inicia a escuta das suas msg
                    Servidor.IncluirUsuarios(tcpCliente, usuarioAtual);
                }
            }
            else
            {
                FecharConexao();
                //interrompe conexão do metodo
                return;
            }

            try
            {
                //continua aguardando por uma msg do user
                while ((strResposta = srReceptor.ReadLine()) != "")
                {
                    //se for Inválido remove
                    if (strResposta == null)
                    {
                        Servidor.RemoverUsuario(tcpCliente);
                    }
                    else
                    {
                        //envia msg para todos os user
                        Servidor.EnviaMensagem(usuarioAtual, strResposta);
                    }
                }
            }
            catch
            {
                //se houver algum problema remove user
                Servidor.RemoverUsuario(tcpCliente);
            }
        }
        
    }
}
