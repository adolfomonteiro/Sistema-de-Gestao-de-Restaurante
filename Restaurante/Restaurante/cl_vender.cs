using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Restaurante
{
    class cl_vender
    {
        protected virtual string nome { get; set; }
        protected virtual string categoria { get; set; }
        protected virtual string preco { get; set; }

        protected virtual MySqlConnection connection()
        {
            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";
            return new MySqlConnection(string_conexao);
        }
    }
}
