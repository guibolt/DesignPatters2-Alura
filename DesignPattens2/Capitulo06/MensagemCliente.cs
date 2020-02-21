using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo06
{
    public class MensagemCliente : IMensagem
    {
        public MensagemCliente(string nome) =>  Nome = nome;
        
        public string Nome { get; }
        public IEnviador Enviador { get; set; }

        public void Envia() => Enviador.Envia(this);

        public string Formata() =>  string.Format("Enviando a mensagem para o cliente {0}", this.Nome);
        
    }
}
