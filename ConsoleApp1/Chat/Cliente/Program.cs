using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "127.0.0.1";
            short port = 1234;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                //o endpoint é o servidor
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                socket.Connect(endPoint);

                Console.WriteLine("Conectado com sucesso...");
                Console.WriteLine("Insira uma mensagem: \n");
                string info = Console.ReadLine();
                byte[] infoEnviar = Encoding.Default.GetBytes(info);
                socket.Send(infoEnviar, 0, infoEnviar.Length, SocketFlags.None);
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possivel se conectar ao servidor...");
            }
            finally
            {
                socket.Close();
            }
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
