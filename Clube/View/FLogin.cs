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
    public partial class FLogin : Form
    {
        Login login;
        public FLogin()
        {
            InitializeComponent();
            login = new Login();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            login.Username = txtLoginUsername.Text;
            login.Password = txtLoginSenha.Text;

                if(txtLoginUsername.Text != "" && txtLoginSenha.Text != "")
                {
                    MessageBox.Show("Logado", "Summer Clube", MessageBoxButtons.OK);
                } else
                {
                    MessageBox.Show("Efetue o Login", "Summer Clube", MessageBoxButtons.OK);
                }
            }

        private void btnLoginCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

