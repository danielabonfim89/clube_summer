using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Clube
{
    public class Banco
    {
        SqlConnection conexao = new SqlConnection();

      //Construtor
      public Banco()
        {
            conexao.ConnectionString = @"Data Source=DESKTOP-SPEC92O;Initial Catalog=Clube;Integrated Security=True";

        }
      //Método Conectar
      public SqlConnection conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
      //Método Desconectar
      public void desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
