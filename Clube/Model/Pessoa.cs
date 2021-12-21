using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube
{
    public abstract class Pessoa
    {
        private string nome;
        private string endereco;
        private string telefone;
        private string email;
        private string nroCartao;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string NroCartao { get => nroCartao; set => nroCartao = value; }
    }
}
