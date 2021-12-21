using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clube
{
    public class CadastroDependente
    {
        Banco conexao = new Banco();
        SqlCommand cmd = new SqlCommand();
        public string msg = "";
        public CadastroDependente(string nome, string email, string nrocartao, string parentesco)
        {
            //Comando SQL -- SqlCommand insert, update, delete
            cmd.CommandText = "insert into Dependente (nome, email, nro_cartao, parentesco) values (@nome, @email, @nro_cartao, @parentesco)";

            //Parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nro_cartao", nrocartao);
            cmd.Parameters.AddWithValue("@parentesco", parentesco);

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
