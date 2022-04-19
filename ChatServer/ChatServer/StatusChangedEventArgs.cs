using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    //trata os argumentos para o evento statuschanged
    public class StatusChangedEventArgs : EventArgs
    {
        //estamos interessados na mensagem descrevendo o evento
        private string EventMsg;
        //propriedade para retornar e definir um mensagem do evento
        public string EventMessage { get; set; }
        //construtor para definir a mensagem do evento
        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }
}
