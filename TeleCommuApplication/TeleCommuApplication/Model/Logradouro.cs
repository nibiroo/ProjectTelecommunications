using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleCommuApplication.Model
{
    public class Logradouro
    {
        private Cliente Cliente { get; set; }
        private string Rua { get; set; }

        public string Numero { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Complemento { get; set; }
    }
}
