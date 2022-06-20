using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleCommuApplication.Model
{
    public class Assinatura
    {
        private int Assinatura_ID { get; set; }
        private string Nome { get; set; }
        private string Tipo { get; set; }
        private Adicional[] Adicionais { get; set; }
        private float ValorMensal { get; set; }

        public bool CadastrarAssinatura(Assinatura assinatura)
        {
            this.Nome = assinatura.Nome;
            this.Tipo = assinatura.Tipo;
            this.Adicionais = assinatura.Adicionais;
            this.ValorMensal = assinatura.ValorMensal;

            return true;
        }


    }

    

}
