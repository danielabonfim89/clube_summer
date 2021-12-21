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
    public partial class FNovoUsuario : Form
    {
        Socio socio;
        Dependente dependente;
        Categoria categoria;
        Login login;

        public FNovoUsuario()
        {
            InitializeComponent();
            socio = new Socio();
            dependente = new Dependente();
            categoria = new Categoria();
            login = new Login();

        }

        private void FNovoUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelar a Operação?", "Summer Clube?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroSocio cadastro = new CadastroSocio(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtEmail.Text, txtNroCartao.Text, cbStatus.Text, txtUsername.Text, txtSenha.Text);

           
            MessageBox.Show(cadastro.msg);


        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
