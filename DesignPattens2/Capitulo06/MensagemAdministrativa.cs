﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo06
{
    public class MensagemAdministrativa : IMensagem
    {
        public object Nome { get; }
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome) => Nome = nome;
               
        public void Envia() => Enviador.Envia(this);

        public string Formata() => string.Format("Enviando a mensagem para o administrador {0}", this.Nome);
        
    }
}
