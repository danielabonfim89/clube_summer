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
    public partial class NMensalidade : Form
    {
        Mensalidade mensalidade;
        public NMensalidade()
        {
            InitializeComponent();
            mensalidade = new Mensalidade();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroMensalidade cadMensal = new CadastroMensalidade(txtDtMensal.Text, txtVlrMesnal.Text, txtDtPgto.Text, txtJurosMensal.Text, txtVlrPgto.Text, cbQuitar.Text);

            MessageBox.Show(cadMensal.msg);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
