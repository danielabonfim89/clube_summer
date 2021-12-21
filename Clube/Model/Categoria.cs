using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube
{
    class Categoria
    {
        private string categorias;
        private List<Socio> socios = new List<Socio>();
        

        public string Categorias { get => categorias; set => categorias = value; }
  
    }
}
