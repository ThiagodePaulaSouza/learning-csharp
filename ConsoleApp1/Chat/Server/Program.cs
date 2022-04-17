using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string vazia ="";
            string ip = "127.0.0.1";
            short port = 1234;

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //comunicação local || rede local 
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            socket.Bind(endPoint);
            socket.Listen(5);
            Console.WriteLine("Escutanto...");
            //retorna uma nova requisição de um socket criado na conexão || cria conexão com o socket que faz a conexão
            Socket escutar = socket.Accept();
            byte[] mensagem = new byte[255];
            int tamanho = escutar.Receive(mensagem, 0, mensagem.Length, SocketFlags.None);
            //redimensionar o array de bytes
            Array.Resize(ref mensagem, tamanho);
            Console.WriteLine("Cliente Falou: ");
            Console.WriteLine(Encoding.Default.GetString(mensagem));
            socket.Close();
            Console.WriteLine("Servidor Finalizado\nPressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
