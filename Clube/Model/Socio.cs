
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clube
{
    class Socio : Pessoa
    {
        //private string dependente;
        private Mensalidade mensalidade;
        private Categoria categoria;
        private Dependente dependente;
        private List<Dependente> dependentes = new List<Dependente>();
        private List<Mensalidade> mensalidades = new List<Mensalidade>();
        private string status;

        // public string Dependente { get => dependente; set => dependente = value; }
        public Mensalidade Mensalidade { get => mensalidade; set => mensalidade = value; }
        public Categoria Categorias { get => categoria; set => categoria = value; }
        public Dependente Dependente { get => dependente; set => dependente = value; }
        public string Status { get => status; set => status = value; }

        public void registrarSocio()
        {
        }

        public void consultarSocio()
        {

        }

    }
}
