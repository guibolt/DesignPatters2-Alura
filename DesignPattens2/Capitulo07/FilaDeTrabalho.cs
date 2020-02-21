﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo07
{
    class FilaDeTrabalho
    {
        private IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando) => Comandos.Add(comando);


        public void Processa()
        {
            foreach (var comando in Comandos)
                comando.Executa();
        }




    }
}
