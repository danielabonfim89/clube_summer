using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clube
{
    public class CadastroMensalidade
    {
        Banco conexao = new Banco();
        SqlCommand cmd = new SqlCommand();
        public string msg = "";
        public CadastroMensalidade(string data_mensalidade, string valor_mensalidade, string data_pagamento, string juros_mensalidade, string valor_pagamento, string quitacao_mensalidade)
        {
            
            if(valor_mensalidade != "" && valor_pagamento != "")
            {
                valor_mensalidade = valor_mensalidade.Replace(",", ".");
                valor_pagamento = valor_pagamento.Replace(",", ".");
            }
            

            //Comando SQL -- SqlCommand insert, update, delete
            cmd.CommandText = "insert into Mensalidade (data_mensalidade, valor_mensalidade, data_pagamento, juros_mensalidade, valor_pagamento, quitacao_mensalidade) values (@data_mensalidade, @valor_mensalidade, @data_pagamento, @juros_mensalidade, @valor_pagamento, @quitacao_mensalidade)";
            //Parametros
            cmd.Parameters.AddWithValue("@data_mensalidade", data_mensalidade);
            cmd.Parameters.AddWithValue("@valor_mensalidade", valor_mensalidade);
            cmd.Parameters.AddWithValue("@data_pagamento", data_pagamento);
            cmd.Parameters.AddWithValue("@juros_mensalidade", juros_mensalidade);
            cmd.Parameters.AddWithValue("@valor_pagamento", valor_pagamento);
            cmd.Parameters.AddWithValue("@quitacao_mensalidade", quitacao_mensalidade);

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

