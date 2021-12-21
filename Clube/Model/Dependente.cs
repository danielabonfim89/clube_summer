using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube
{
    class Dependente : Pessoa
    {
        private string parentesco;

        public string Parentesco { get => parentesco; set => parentesco = value; }
    }
}
