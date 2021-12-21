using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clube
{
    public partial class Form1 : Form
    {
        Categoria categoria;
        Socio socio;
        Dependente dependente;
        Mensalidade mensalidade;
        public Form1()
        {
            InitializeComponent();

            categoria = new Categoria();
            socio = new Socio();
            dependente = new Dependente();
            mensalidade = new Mensalidade();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
        }

        private void btnDependente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMensalidade_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            MenuPrincipal menuP = new MenuPrincipal();
            menuP.Show();
            /*
            socio.Dependente = dependente;
            socio.Categoria = categoria;
            socio.Mensalidade = mensalidade;
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
