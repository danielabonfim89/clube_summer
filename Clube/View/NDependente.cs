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
    public partial class NDependente : Form
    {
        Socio socio;
        Dependente dependente;
        
        public NDependente()
        {
            InitializeComponent();
            socio = new Socio();
            dependente = new Dependente();
        }

        private void NDependente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroDependente cadastroDep = new CadastroDependente(txtNomeDep.Text, txtEmailDep.Text, txtNroCartao.Text, cbParentesco.Text);


            MessageBox.Show(cadastroDep.msg);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelar a Operação?", "Summer Clube?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
