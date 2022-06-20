using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleCommuApplication.Model
{
    public class Servico
    {
        private int Servico_ID { get;set; }
        private string Nome { get; set; }

        private string Tipo { get; set; }

        private string Descricao { get; set; }

        private float? Mensalidade { get; set; }

        private Assinatura Assinatura { get; set; }

        public bool CadastrarServico (Servico servico)
        {
            this.Nome = servico.Nome;
            this.Assinatura = servico.Assinatura;
            this.Tipo = servico.Tipo;
            this.Descricao = servico.Descricao;
            this.Mensalidade = servico.Mensalidade;
            this.Assinatura = servico.Assinatura;

            return true;
        }

    }

}
