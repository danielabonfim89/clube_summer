using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube
{
    class Mensalidade
    {
        private string dataMensalidade;
        private double valorMensalidade;
        private string dataPgtoMensalidade;
        private double jurosMensalidade;
        private double valorPagto;
        private string quitacaoMensalidade;

        public string DataMensalidade { get => dataMensalidade; set => dataMensalidade = value; }
        public double ValorMensalidade { get => valorMensalidade; set => valorMensalidade = value; }
        public string DataPgtoMensalidade { get => dataPgtoMensalidade; set => dataPgtoMensalidade = value; }
        public double JurosMensalidade { get => jurosMensalidade; set => jurosMensalidade = value; }
        public double ValorPagto { get => valorPagto; set => valorPagto = value; }
        public string QuitacaoMensalidade { get => quitacaoMensalidade; set => quitacaoMensalidade = value; }


        public void consultarMensalidade()
        {

        }

        public void calcularJuros()
        {

        }

        public void quitarMensalidade()
        {

        }
    }
}
