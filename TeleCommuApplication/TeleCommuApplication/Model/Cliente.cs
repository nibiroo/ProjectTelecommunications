using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleCommuApplication.Model
{
    public class Cliente
    {
        private int Cliente_ID { get; set; }
        public string Nome { get; set; }
        private string Sobrenome { get; set; }
        private string CPF { get; set; }
        private long Telefone { get; set; }
        private DateTime DataCadastro { get;set; }
        private Logradouro Endereco { get; set; }


        public bool CadastrarCliente(Cliente cliente)
        {
            this.Nome = cliente.Nome;
            this.Sobrenome = cliente.Sobrenome;
            this.DataCadastro = cliente.DataCadastro;
            this.CPF = cliente.CPF;
            this.Telefone = cliente.Telefone;
            this.Endereco = cliente.Endereco;

            return true;
        }

        public Cliente VisualizarCliente (string CPF)
        {
            var Cliente = new Cliente();

            return Cliente;
        }

    }

}
