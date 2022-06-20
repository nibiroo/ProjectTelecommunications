using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleCommuApplication.Model
{
    public class Fatura
    {
        private int Fatura_ID { get; set; }
        private Cliente Cliente { get; set; }
        private float Valor { get; set; }
        private DateTime DataGeracao { get; set; }
        private DateTime DataLimite { get; set; }

        public Fatura GerarFatura ()
        {
            return new Fatura();
        }

        public Fatura VisualizarFatura()
        {
            return new Fatura();
        }

    }


}
