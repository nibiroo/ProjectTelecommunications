using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleCommuApplication.Model
{
    public class Empresa
    {
        public int Nome { get; set; }
        private string CNPJ { get; set; }
        private string InscricaoEstadual { get; set; }
        private string RazaoSocial { get; set; }
        private List<Servico> Servicos { get; set; }
        private List<Cliente> Clientes { get; set;}


        public List<Servico> VisualizarServicos()
        {
            var listaServicos = new List<Servico>();

            return listaServicos;
        }

        public List<Cliente> VisualizarClientes()
        {
            var listaClientes = new List<Cliente>();

            return listaClientes;
        }

    }

}
