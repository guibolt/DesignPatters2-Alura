using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattens2.Capitulo05;

namespace DesignPattens2.Capitulo04
{
    class Numero : IExpressao
    {
        
        public int Valor { get; private set; }

        public Numero(int numero) => Valor = numero;            
        

        public int Avalia() => Valor;
        

        public void Aceita(IVisitor impressora) =>  impressora.ImprimeNumero(this);
        
    }
}
