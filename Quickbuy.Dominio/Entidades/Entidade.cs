using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quickbuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao { get; set; }

        protected List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }  
        }


        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }


        public abstract void Validade();

        

        public bool EhValido 
        {
            get { return !MensagemValidacao.Any(); } 
        }


        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }

       /* protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        )*/
    }
}
