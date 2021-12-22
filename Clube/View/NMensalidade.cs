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

        private void txtJurosMensal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVlrPgto_TextChanged(object sender, EventArgs e)
        {
            
            mensalidade.ValorMensalidade = Convert.ToDouble(txtVlrMesnal.Text);
            mensalidade.DataMensalidade = txtDtMensal.Text;
            mensalidade.JurosMensalidade = Convert.ToDouble(txtJurosMensal.Text);
            mensalidade.DataPgtoMensalidade = txtDtPgto.Text;

            //txtVlrPgto = Convert.ToDouble((txtVlrMesnal * txtJurosMensal * txtDtPgto) + txtVlrMesnal);
        }
    }
}
