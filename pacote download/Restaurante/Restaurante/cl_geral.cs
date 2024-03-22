using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Restaurante
{
    class cl_geral
    {
        //Login
        protected virtual string nome { set; get; }
        protected virtual string senha { set; get; }

        //Funcionários

        protected virtual string NomeFunc { set; get; }
        protected virtual string email { set; get; }
        protected virtual int telefone { set; get; }
        protected virtual string morada { set; get; }
        protected virtual string palavraPasse { set; get; }

        //Produtos
        protected virtual string nomeDoProduto { set; get; }
        protected virtual string categoria { set; get; }
        protected virtual string subcategoria { set; get; }
        protected virtual int preco { set; get; }
        protected virtual int quantidade { set; get; }

        //Eliminar Produto
        protected virtual int id { set; get; }
        //Conexao
        protected virtual MySqlConnection connection()
        {
            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";
            return new MySqlConnection(string_conexao);
        }
    }
}
