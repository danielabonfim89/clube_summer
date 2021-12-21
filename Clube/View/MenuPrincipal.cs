using System;
using System.Windows.Forms;


namespace Clube
{

    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void novoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNovoUsuario novoSocio = new FNovoUsuario();
            novoSocio.Show(); 
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            login.Show();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NCategoria categoria = new NCategoria();
            categoria.Show();
        }

        private void dependenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NDependente dependente = new NDependente();
            dependente.Show();
        }

        private void dataDaMensalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NMensalidade mensal = new NMensalidade();
            mensal.Show();
        }
    }
}
