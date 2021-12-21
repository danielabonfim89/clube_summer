using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clube
{
    public class CadastroCategoria
    {
        Banco conexao = new Banco();
        SqlCommand cmd = new SqlCommand();
        public string msg = "";

        public CadastroCategoria(string nome)
        {
            //Comando SQL -- SqlCommand insert, update, delete
            cmd.CommandText = "insert into Categoria (nome) values (@nome)";


            //Parametros
            cmd.Parameters.AddWithValue("@nome", nome);
           

            try
            {
                //Conectar com Banco --Banco(conexao)
                cmd.Connection = conexao.conectar();
                //Executar Comando
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

 