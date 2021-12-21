using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clube
{
    public class CadastroSocio
    {
        Banco conexao = new Banco();
        SqlCommand cmd = new SqlCommand();
        public string msg = "";

        public CadastroSocio(string nome, string endereco, string telefone, string email, string nrocartao, string situacao, string username, string senha)
        {
            //Comando SQL -- SqlCommand insert, update, delete
            cmd.CommandText = "insert into Socio (nome, endereco, telefone, email, nro_cartao, situacao, username, senha) values (@nome, @telefone, @endereco, @email, @nro_cartao, @situacao, @username, @senha)";


            //Parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nro_cartao", nrocartao);
            cmd.Parameters.AddWithValue("@situacao", situacao);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                //Conectar com Banco --Banco(conexao)
                cmd.Connection = conexao.conectar();
                //Grava registro na Tabela
                cmd.ExecuteNonQuery();
                //Desconectar com Banco
                conexao.desconectar();
                //Monstrar mensagem de erro ou sucesso
                this.msg = "Cadastrado com Sucesso!!!";

            }
            catch (SqlException e)
            {
                this.msg = "Erro ao se conectar com o Banco de Dados" + e;
            }
        }

    }
}
